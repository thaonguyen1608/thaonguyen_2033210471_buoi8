using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapMau
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=A209PC02;Initial Catalog=QL_IDNAME; Integrated Security=True";
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strcon);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO dbo.HocSinh VALUES (4,'Nguyen Nguyen')";
            SqlCommand sqlcmd = new SqlCommand(cmd, sqlcon);
            sqlcmd.ExecuteNonQuery();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

        }
    }
}
 using System.Data.SqlClient;
namespace BaiTapMau
{
    partial class Form1
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
            this.btnC = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(43, 53);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnR
            // 
            this.BtnR.Location = new System.Drawing.Point(172, 53);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(75, 23);
            this.BtnR.TabIndex = 1;
            this.BtnR.Text = "R";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(43, 156);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 2;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(172, 156);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.btnC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnD;
    }
}