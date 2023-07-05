using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.dt_Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.btn_DataMatrix = new System.Windows.Forms.Button();
            this.btn_QRCODE = new System.Windows.Forms.Button();
            this.cboSheets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFileName.Location = new System.Drawing.Point(272, 400);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(620, 26);
            this.txtFileName.TabIndex = 4;
            // 
            // dt_Data
            // 
            this.dt_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Data.GridColor = System.Drawing.Color.Black;
            this.dt_Data.Location = new System.Drawing.Point(16, 4);
            this.dt_Data.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.RowHeadersWidth = 51;
            this.dt_Data.RowTemplate.Height = 29;
            this.dt_Data.Size = new System.Drawing.Size(1203, 274);
            this.dt_Data.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên file:";
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ChooseFile.FlatAppearance.BorderSize = 0;
            this.btn_ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChooseFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseFile.Image = global::Project.Properties.Resources.upload;
            this.btn_ChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChooseFile.Location = new System.Drawing.Point(903, 384);
            this.btn_ChooseFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(44, 58);
            this.btn_ChooseFile.TabIndex = 2;
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // btn_DataMatrix
            // 
            this.btn_DataMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DataMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.btn_DataMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DataMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DataMatrix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DataMatrix.Image = global::Project.Properties.Resources.digital;
            this.btn_DataMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DataMatrix.Location = new System.Drawing.Point(709, 504);
            this.btn_DataMatrix.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_DataMatrix.Name = "btn_DataMatrix";
            this.btn_DataMatrix.Size = new System.Drawing.Size(183, 80);
            this.btn_DataMatrix.TabIndex = 1;
            this.btn_DataMatrix.Text = "Data Matrix";
            this.btn_DataMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DataMatrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DataMatrix.UseVisualStyleBackColor = false;
            this.btn_DataMatrix.Click += new System.EventHandler(this.btn_DataMatrix_Click);
            // 
            // btn_QRCODE
            // 
            this.btn_QRCODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_QRCODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.btn_QRCODE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QRCODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QRCODE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QRCODE.Image = global::Project.Properties.Resources.qr1;
            this.btn_QRCODE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QRCODE.Location = new System.Drawing.Point(340, 504);
            this.btn_QRCODE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_QRCODE.Name = "btn_QRCODE";
            this.btn_QRCODE.Size = new System.Drawing.Size(171, 80);
            this.btn_QRCODE.TabIndex = 0;
            this.btn_QRCODE.Text = "QR Code";
            this.btn_QRCODE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QRCODE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QRCODE.UseVisualStyleBackColor = false;
            this.btn_QRCODE.Click += new System.EventHandler(this.btn_QRCODE_Click);
            // 
            // cboSheets
            // 
            this.cboSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSheets.FormattingEnabled = true;
            this.cboSheets.Location = new System.Drawing.Point(272, 311);
            this.cboSheets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSheets.Name = "cboSheets";
            this.cboSheets.Size = new System.Drawing.Size(134, 31);
            this.cboSheets.TabIndex = 7;
            this.cboSheets.SelectedIndexChanged += new System.EventHandler(this.cboSheets_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sheet: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSheets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_Data);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.btn_DataMatrix);
            this.Controls.Add(this.btn_QRCODE);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private Button btn_QRCODE;
        private Button btn_DataMatrix;
        private Button btn_ChooseFile;

        private TextBox txtFileName;
        public DataGridView dt_Data;
        private Label label1;
        private ComboBox cboSheets;
        private Label label2;
    }
}