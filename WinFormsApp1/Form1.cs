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
            Development.ChangeTheme(panel1, label1, label2, mTextBox, button1, button2, button3, button4, button5);
        }

        private void mTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mTextBox.Lines.Length > 24)
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

            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label2.Location = new Point(345, 9);
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

            label2.Font = new Font("Segoe UI", 10);
            label2.Location = new Point(355, 9);
            label2.Text = Development.publicPathDir;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Development.CreateFile(mTextBox.Text, saveFileDialog1);

            label2.Font = new Font("Segoe UI", 10);
            label2.Location = new Point(355, 9);
            label2.Text = Development.publicPathDir;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Development.ChangeTheme(panel1, label1, label2, mTextBox, button1, button2, button3, button4, button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mTextBox.Font = new Font("Segoe UI", mTextBox.Font.Size + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mTextBox.Font = new Font("Segoe UI", mTextBox.Font.Size - 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            EventOnKeyDown((e.KeyCode == Keys.S) && e.Control);
        }

        private void mTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EventOnKeyDown((e.KeyCode == Keys.S) && e.Control);
        }

        private void EventOnKeyDown(bool myKeysPressed)
        {
            if (myKeysPressed)
            {
                if (saveFileDialog1.FileName.ToString() != "")
                {
                    Development.CreateFile(mTextBox.Text); // Используется 1 перегрузка без использования диалог. окна
                }
                else
                {
                    Development.CreateFile(mTextBox.Text, saveFileDialog1); // Используется 2 перегрузка
                }

                label2.Font = new Font("Segoe UI", 10);
                label2.Location = new Point(355, 9);
                label2.Text = Development.publicPathDir;
            }
        }
    }
}
