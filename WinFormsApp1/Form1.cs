using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Development Development = new Development();

        public Form1()
        {
            InitializeComponent();
            Development.ChangeTheme(panel1, label1, label2, mTextBox, button1, button2, button3);
        }

        private void mTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mTextBox.Lines.Length > 28)
            {
                mTextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                mTextBox.ScrollBars = ScrollBars.None;
            }

            // Изменение заголовка файла
            if (Development.publicPathDir == "")
            {
                label2.Text = "*Unnamed file";
            }
            else
            {
                label2.Text = "*" + Development.publicPathDir;
            }

            label2.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName.ToString() != "")
            {
                Development.CreateFile(mTextBox.Text); // Используется 1 перегрузка без использования диалог. окна
            }
            else
            {
                Development.CreateFile(mTextBox.Text, saveFileDialog1); // Используется 2 перегрузка
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Development.CreateFile(mTextBox.Text, saveFileDialog1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Development.ChangeTheme(panel1, label1, label2, mTextBox, button1, button2, button3);
        }
    }
}
