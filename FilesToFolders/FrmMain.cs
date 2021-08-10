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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFolderLocation.Text))
            {
                SortFiles(@txtFolderLocation.Text);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolderLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SortFiles(string pathToDirectory, string searchPattern = "*.*")
        {
            List<string> fileNames = new(16);

            foreach (string f in Directory.GetFiles(pathToDirectory, searchPattern))
            {
                try
                {
                    fileNames.Add(Path.GetFullPath(f));
                }
                catch (Exception)
                {

                }
            }

            foreach (string f in fileNames)
            {
                try
                {
                    Directory.CreateDirectory(Path.Combine(pathToDirectory, TrimText(f, txtTrimText.Text, GetTrimDirection())));
                }
                catch (Exception)
                {
                    fileNames.Remove(f);
                }
            }

            foreach (string f in fileNames)
            {
                try
                {
                    File.Move(f, Path.Combine(pathToDirectory, TrimText(f, txtTrimText.Text, GetTrimDirection()), Path.GetFileName(f)));
                }
                catch (Exception)
                {

                }
            }

            System.Media.SystemSounds.Beep.Play();
        }

        private string TrimText(string input, string separator, TrimDirection trim)
        {
            try
            {
                input = Path.GetFileNameWithoutExtension(input);

                if (string.IsNullOrWhiteSpace(separator) || string.IsNullOrEmpty(separator))
                {
                    return input;
                }
                else if (input.Contains(separator))
                {
                    switch (trim)
                    {
                        case TrimDirection.Right:
                            return input.Substring(0, input.IndexOf(separator));
                        case TrimDirection.Left:
                            return input.Substring(input.IndexOf(separator) + 1);
                        default:
                            goto case TrimDirection.Right;
                    }
                }
                else
                {
                    return input;
                }
            }
            catch (Exception)
            {
                return Path.GetFileNameWithoutExtension(input);
            }
        }

        private TrimDirection GetTrimDirection()
        {
            if (rbtnTrimRight.Checked)
            {
                return TrimDirection.Right;
            }
            else
            {
                return TrimDirection.Left;
            }
        }
    }

    enum TrimDirection
    {
        Right = 0,
        Left = 1
    }
}
