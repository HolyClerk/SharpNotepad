using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Development
    {
        private bool isDarkTheme = false;

        public string publicPathDir;

        private string _pathDirectory = "";

        public string pathDirectory
        {
            get
            {
                return _pathDirectory;
            }
            set
            {
                _pathDirectory = value;
            }
        }

        public void CreateFile(string text)
        {
            StreamWriter file = new StreamWriter(pathDirectory);
            file.Write(text);
            file.Close();
        }

        public void CreateFile(string text, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.ShowDialog();
            publicPathDir = saveFileDialog.FileName.ToString(); // Используется для отображения в одном из лейблов
            string changedFileName = saveFileDialog.FileName.ToString();

            if (changedFileName != "")
            {
                // Необходимо заменять один слеш на два, иначе StreamWriter выдает ошибку
                pathDirectory = changedFileName.Replace(@"\", @"\\");

                // Запись и закрытие файла, который находится на пути, указанный в поле pathDirectory
                StreamWriter file = new StreamWriter(pathDirectory);
                file.Write(text);
                file.Close();
            }
        }

        public void ChangeTheme(Panel panel, Label label, Label label2, TextBox textBox, Button button1, Button button2, Button button3)
        {
            if (!isDarkTheme)
            {
                isDarkTheme = true;

                panel.BackColor = Color.FromArgb(38, 38, 38);

                label.ForeColor = Color.White;
                label2.ForeColor = Color.White;

                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;

                textBox.BackColor = Color.FromArgb(84, 84, 84);
                textBox.ForeColor = Color.White;
            }
            else
            {
                isDarkTheme = false;

                panel.BackColor = SystemColors.InactiveBorder;

                label.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;

                textBox.BackColor = Color.FromArgb(46, 54, 67);
                textBox.ForeColor = Color.White;
            }
        }
    }
}
