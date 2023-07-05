using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using OfficeOpenXml;
using System.IO;
using System.Globalization;
using OfficeOpenXml.Core.ExcelPackage;
using Excel = Microsoft.Office.Interop.Excel;
using QRCoder;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using ZXing.Datamatrix;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using ExcelPackage = OfficeOpenXml.ExcelPackage;
using ExcelDataReader;
using ZXing.QrCode.Internal;
using Image = iTextSharp.text.Image;
using QRCode = QRCoder.QRCode;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Unidecode.NET;
using ZXing.Datamatrix.Encoder;

namespace Project
{
    public partial class Main : Form
    {

        string filePath = "";
        DataTable dataTable = new DataTable();

        public Main()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        //Chọn file
        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                txtFileName.Text = Path.GetFullPath(filePath);

                if (Path.GetExtension(filePath).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    ReadCSVFile(filePath);
                }
                else
                {
                    /*ReadExcelFile(filePath);*/
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                    // Clear existing items in the ComboBox
                    cboSheets.Items.Clear();

                    // Add sheet names to the ComboBox
                    foreach (Excel.Worksheet worksheet in workbook.Worksheets)
                    {
                        cboSheets.Items.Add(worksheet.Name);

                    }

                    workbook.Close();
                    excelApp.Quit();

                    if (cboSheets.Items.Count > 0)
                    {
                        cboSheets.SelectedIndex = 0; // Chọn sheet đầu tiên
                    }
                }
            }

        }
        private void cboSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSheet = cboSheets.SelectedItem.ToString();
            ReadExcelFile(filePath, selectedSheet);
        }

        //Đọc file Excel
        private void ReadExcelFile(string filePath, string selectedSheet)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[selectedSheet];

            Excel.Range range = worksheet.UsedRange;
            object[,] values = range.Value;
            dataTable = new DataTable();

            int rowCount = range.Rows.Count;
            int columnCount = range.Columns.Count;
            if (rowCount >= 2 && columnCount >= 1)
            {
                for (int row = 1; row <= range.Rows.Count; row++)
                {
                    bool hasData = false; // Đặt Flag kiểm tra xem hàng có bất kỳ dữ liệu nào không
                    DataRow dataRow = null;
                    for (int col = 1; col <= range.Columns.Count; col++)
                    {
                        if (row == 1)
                        {
                            DataColumn dataColumn = new DataColumn();
                            Excel.Range cell = range.Cells[row, col] as Excel.Range;
                            if (cell != null && cell.Value != null)
                            {
                                dataColumn.ColumnName = cell.Value.ToString();
                                dataTable.Columns.Add(dataColumn);
                            }
                        }
                        else
                        {
                            if (col == 1)
                                dataRow = dataTable.NewRow();
                            if (values[row, col] != null)
                            {
                                string cellValue = values[row, col].ToString();
                                dataRow[col - 1] = cellValue;
                                hasData = true;
                            }

                        }
                    }

                    if (hasData)
                    {
                        dataTable.Rows.Add(dataRow); // Chỉ thêm hàng vào dataTable nếu nó có dữ liệu
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu sheet rỗng !");
            }

            workbook.Close();
            excelApp.Quit();

            dt_Data.DataSource = dataTable;
            dt_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt_Data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_Data.AutoResizeRows();
            dt_Data.AutoResizeColumns();
        }

        //Đọc file CSV
        private void ReadCSVFile(string filePath)
        {
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                dataTable.Clear();

                // Đọc dòng tiêu đề
                string headerRow = reader.ReadLine();
                if (headerRow != null)
                {
                    string[] headers = headerRow.Split(',');
                    foreach (string header in headers)
                    {
                        // Kiểm tra xem cột đã tồn tại chưa
                        if (!dataTable.Columns.Contains(header))
                        {
                            // Thêm cột vào DataTable với tên từng tiêu đề
                            DataColumn dataColumn = new DataColumn(header);
                            dataTable.Columns.Add(dataColumn);
                        }
                    }
                }

                // Đọc các dòng dữ liệu
                while (!reader.EndOfStream)
                {
                    string dataRow = reader.ReadLine();
                    if (dataRow != null)
                    {
                        string[] dataValues = dataRow.Split(',');
                        if (dataValues.Length == dataTable.Columns.Count)
                        {
                            DataRow newRow = dataTable.NewRow();
                            for (int i = 0; i < dataValues.Length; i++)
                            {
                                // Thiết lập giá trị cho từng cột của dòng dữ liệu
                                newRow[i] = dataValues[i];
                            }
                            dataTable.Rows.Add(newRow);
                        }
                    }
                }
            }

            dt_Data.DataSource = dataTable;
            dt_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt_Data.AutoResizeRows();
            dt_Data.AutoResizeColumns();
        }

        public static string KeepVietnameseCharacters(string input)
        {

            input = input.Unidecode();
            string pattern = @"[^\p{L}\s0-9:]";
            input = Regex.Replace(input, pattern, "");

            return input;
            
        }


        private void btn_QRCODE_Click(object sender, EventArgs e)
        {
            
            if (dataTable.Rows.Count > 0)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    // Request the user to enter the PDF file name
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = selectedFolder;
                    saveFileDialog.FileName = "QRCode.pdf";
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
                        document.Open();
                        float pageHeight = document.PageSize.Height;
                        float pageWidth = document.PageSize.Width;

                        int counter = 1;
                        Bitmap qrCodeBitmap = null;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            StringBuilder stringBuilder = new StringBuilder();

                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                string columnName = dataTable.Columns[col].ColumnName;
                                string data = row[col].ToString();
                                string columnData = columnName + ": " + data;
                                stringBuilder.AppendLine(columnData);

                            }
                            string combinedData = stringBuilder.ToString().TrimEnd('\n');

                            byte[] bytes = Encoding.Unicode.GetBytes(combinedData);
                            combinedData = Encoding.Unicode.GetString(bytes);
                            QrCodeEncodingOptions encodingOptions = new QrCodeEncodingOptions()
                            {
                                DisableECI = true,
                                CharacterSet = "UTF-8",
                                Width = 200,
                                Height = 200,
                                Margin = 0
                            };
                            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter();
                            barcodeWriter.Format = BarcodeFormat.QR_CODE;
                            barcodeWriter.Options = encodingOptions;
                            qrCodeBitmap = barcodeWriter.Write(combinedData);

                            // Add QR code image to PDF
                            Image qrCodeImage = Image.GetInstance(qrCodeBitmap, ImageFormat.Png);
                            qrCodeImage.Alignment = Element.ALIGN_CENTER;
                            float qrCodeWidth = qrCodeImage.ScaledWidth;
                            float qrCodeHeight = qrCodeImage.ScaledHeight;
                            float qrCodeX = (pageWidth - qrCodeWidth) / 2;
                            float qrCodeY = (pageHeight + qrCodeHeight) / 2;
                            qrCodeImage.SetAbsolutePosition(qrCodeX, qrCodeY);
                            document.Add(qrCodeImage);

                            // Add combinedData below the QR code
                            Paragraph paragraph = new Paragraph(counter.ToString()) // Hiển thị số thứ tự
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            paragraph.SpacingBefore = qrCodeHeight + 80;
                            document.Add(paragraph);

                            document.NewPage();
                            counter++;
                        }

                        document.Close();
                        writer.Close();

                        MessageBox.Show("Hình QR Code và dữ liệu đã được xuất ra file PDF!");

                        // Mở thư mục chứa file PDF
                        Process.Start(selectedFolder);
                    }        
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file Excel hoặc CSV !");
            }
        }

        //Data Matrix
        private void btn_DataMatrix_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = selectedFolder;
                    saveFileDialog.FileName = "DataMatrix.pdf";
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
                        document.Open();
                        float pageHeight = document.PageSize.Height;
                        float pageWidth = document.PageSize.Width;

                        int counter = 1;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            StringBuilder stringBuilder = new StringBuilder();

                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {

                                string columnName = dataTable.Columns[col].ColumnName;
                                string data = row[col].ToString();
                                string columnData = columnName + ": " + data;
                                stringBuilder.AppendLine(columnData);

                            }

                            string combinedData = stringBuilder.ToString().TrimEnd('\n'); // Loại bỏ dấu xuống hàng cuối cùng
                            combinedData = KeepVietnameseCharacters(combinedData);                           
                            byte[] bytes = Encoding.UTF8.GetBytes(combinedData);
                            combinedData = Encoding.UTF8.GetString(bytes);
                            BarcodeWriter barcodeWriter = new BarcodeWriter();
                            barcodeWriter.Format = BarcodeFormat.DATA_MATRIX; // Sử dụng mã Data Matrix theo chuẩn GS1
                            DatamatrixEncodingOptions encodingOptions = new DatamatrixEncodingOptions()
                            {
                                SymbolShape = SymbolShapeHint.FORCE_SQUARE,
                                Width = 200,
                                Height = 200,
                                Margin = 0,
                                GS1Format = true,
                                PureBarcode = false,

                            };

                            barcodeWriter.Options.Hints.Add(EncodeHintType.GS1_FORMAT, encodingOptions.GS1Format);

                            barcodeWriter.Options = encodingOptions;

                            Bitmap qrCodeBitmap = barcodeWriter.Write(combinedData);

                            // Add QR code image to PDF
                            iTextSharp.text.Image qrCodeImage = iTextSharp.text.Image.GetInstance(qrCodeBitmap, ImageFormat.Png);
                            qrCodeImage.Alignment = Element.ALIGN_CENTER;
                            float qrCodeWidth = qrCodeImage.ScaledWidth;
                            float qrCodeHeight = qrCodeImage.ScaledHeight;

                            float qrCodeX = (pageWidth - qrCodeWidth) / 2;
                            float qrCodeY = (pageHeight + qrCodeHeight) / 2;

                            qrCodeImage.SetAbsolutePosition(qrCodeX, qrCodeY);
                            document.Add(qrCodeImage);


                            Paragraph paragraph = new Paragraph(counter.ToString()) // Hiển thị số thứ tự
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            paragraph.SpacingBefore = qrCodeHeight + 80;
                            document.Add(paragraph);

                            document.NewPage();
                            counter++;
                        }

                        document.Close();
                        writer.Close();

                        // Open the PDF folder
                        Process.Start(selectedFolder);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file Excel hoặc CSV!");
                }
            }

        }

    }
}
