using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanNgoc_211204324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "plain text (*.rft)|*.rft";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = openFileDialog1.OpenFile();
                    StreamReader sr = new StreamReader(stream);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "plain text (*.rft)|*.rft";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Đã lưu thành công");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFont_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
