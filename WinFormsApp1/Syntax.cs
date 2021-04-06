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
    class Syntax
    {
        private string currentText = "bb";

        private void CheckSyntax(TextBox textBox)
        {
            string[] text = textBox.Text.Split();

            for (int i = 0; i < textBox.TextLength; i++)
            {
                if (text.Length > 1 && text[2] == "a")
                {
                    currentText = "aa";
                }
                else
                {
                    currentText = "bb";
                }
            }
        }

        public Label AddLabelOnText(Panel panel, TextBox textBox)
        {
            CheckSyntax(textBox);

            Label syntaxLabel = new Label()
            {
                Text = currentText,
                Location = new Point(0, 56),
                TabIndex = 10,
                Parent = panel,
                BackColor = textBox.BackColor,
                ForeColor = textBox.ForeColor,
                Font = textBox.Font
            };

            return syntaxLabel;
        }

        public void ChangeLocation(Label syntaxLabel)
        {
            syntaxLabel.Text = "aaa";
            syntaxLabel.ForeColor = Color.White;
            syntaxLabel.Location = new Point(510, 130);
        }
    }
}
