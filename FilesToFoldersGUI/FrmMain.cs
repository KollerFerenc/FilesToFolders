using FilesToFolders;
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
using Serilog;
using System.Threading;

namespace FilesToFoldersGUI
{
    public partial class FrmMain : Form
    {
        internal static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private bool _cancelMode = false;
        private CancellationTokenSource _cancellationTokenSource = new();

        public FrmMain()
        {
            InitializeComponent();
            ConfigureLogger();
        }

        private void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(Path.Join(baseDirectory, @"logs\log-.txt"),
                    rollingInterval: RollingInterval.Year,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u4}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_cancelMode)
            {
                _cancellationTokenSource.Cancel();
            }
            else
            {
                Log.CloseAndFlush();
                this.Close();
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFolderLocation.Text))
            {
                EnableInterface(false);
                _cancellationTokenSource = new();

                FileSorter fileSorter = new(_cancellationTokenSource.Token);

                var task = Task.Run(
                    () => fileSorter.Sort(@txtFolderLocation.Text, trimText: txtTrimText.Text, trimDirection: GetTrimDirection()));
                await task;

                System.Media.SystemSounds.Beep.Play();
                txtFolderLocation.Text = "";
                EnableInterface(true);
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

        private void EnableInterface(bool enable)
        {
            _cancelMode = !enable;

            if (_cancelMode)
            {
                btnExit.Text = "Cancel";
            }
            else
            {
                btnExit.Text = "Exit";
            }

            btnStart.Enabled = enable;
            btnOpenFolder.Enabled = enable;
            txtFolderLocation.Enabled = enable;
            gbxTrim.Enabled = enable;
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
}
