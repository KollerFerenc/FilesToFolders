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

namespace FilesToFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> FileNames = new List<string>();

            foreach (string f in Directory.GetFiles(@txtFolderLocation.Text, "*.*"))
            {
                FileNames.Add(Path.GetFullPath(f));
            }

            foreach (string f in FileNames)
            {
                Directory.CreateDirectory(Path.Combine(@txtFolderLocation.Text, TrimText(f, txtTrimText.Text, TrimDirection())));
            }

            foreach (string f in FileNames)
            {
                File.Move(f, Path.Combine(@txtFolderLocation.Text, TrimText(f, txtTrimText.Text, TrimDirection()), Path.GetFileName(f)));
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtFolderLocation.Text = folderBrowserDialog1.SelectedPath;
        }

        private string TrimText(string input, string separator, Trim trim)
        {
            input = Path.GetFileNameWithoutExtension(input);

            if (string.IsNullOrWhiteSpace(separator) || string.IsNullOrEmpty(separator))
            {
                return input;
            }
            else if(input.Contains(separator))
            {
                switch (trim)
                {
                    case Trim.Right:
                        return input.Substring(0, input.IndexOf(separator));
                    case Trim.Left:
                        return input.Substring(input.IndexOf(separator) + 1);
                    default:
                        goto case Trim.Right;
                }
            }
            else
            {
                return input;
            }
        }

        private Trim TrimDirection()
        {
            if (rbtnTrimRight.Checked)
            {
                return Trim.Right;
            }
            else
            {
                return Trim.Left;
            }
        }
    }

    enum Trim
    {
        Right = 0,
        Left = 1
    }
}
