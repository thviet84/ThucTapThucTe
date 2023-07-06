using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtConfirmMK = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtTK, "txtTK");
            this.txtTK.Name = "txtTK";
            this.txtTK.Click += new System.EventHandler(this.txtTK_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Register_Click);
            this.btn_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Exit, "btn_Exit");
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_Exit);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.txtConfirmMK);
            this.panel5.Controls.Add(this.pictureBox7);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // txtConfirmMK
            // 
            this.txtConfirmMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtConfirmMK, "txtConfirmMK");
            this.txtConfirmMK.Name = "txtConfirmMK";
            this.txtConfirmMK.UseSystemPasswordChar = true;
            this.txtConfirmMK.Click += new System.EventHandler(this.txtConfirmMK_Click);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project.Properties.Resources.registered;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.txtMK);
            this.panel4.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtMK, "txtMK");
            this.txtMK.Name = "txtMK";
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.Click += new System.EventHandler(this.txtMK_Click);
            this.txtMK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtTK);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseUp);
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseDown);
            this.pictureBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseUp);
            // 
            // Register
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Load += new System.EventHandler(this.Register_Load_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtTK;
        private Button btn_Login;
        private Button btn_Exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtMK;
        private PictureBox pictureBox4;
        private Panel panel5;
        private TextBox txtConfirmMK;
        private PictureBox pictureBox7;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}