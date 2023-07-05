using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private Form activeForm;
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main(), sender);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            /*OpenChildForm(new Manual(), sender);*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
    }
}
