using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_4_TPL
{
    public partial class mainForm : Form
    {
        private string nameFolder;
        private Progress<int> progress;
        private List<string> _list_paths;

        public mainForm()
        {
            InitializeComponent();
            _list_paths = new List<string>();
        }

        private void btn_whence_Click(object sender, EventArgs e)
        {
            _list_paths.Clear();
            tb_whence.Text = string.Empty;
            var open_window = new OpenFileDialog();
            open_window.Filter = "All files (*.*)|*.*";
            open_window.Multiselect = true;
            if (open_window.ShowDialog() == DialogResult.OK)
            {
                tb_whence.Text += open_window.FileName;
                _list_paths.AddRange(open_window.FileNames);
            }
        }

        private void btn_where_Click(object sender, EventArgs e)
        {
            tb_where.Text = string.Empty;
            var open_window = new FolderBrowserDialog();
            if (open_window.ShowDialog() == DialogResult.OK)
            {
                tb_where.Text = open_window.SelectedPath;
            }
        }
        private void btn_copy_Click(object sender, EventArgs e)
        {
            prg_main.Value = 0;
            prg_main.Maximum = 0;
            progress = new Progress<int>(i => { prg_main.Maximum += i; prg_main.Value += i; });

            if (nameFolder != null)
            {
                nameFolder = $"{tb_where.Text}\\{nameFolder}";
                Directory.CreateDirectory(nameFolder);
            }
            else
                nameFolder = tb_where.Text;

            foreach (var item in _list_paths)
            {
                Task.Run(() => Copy(progress, item));
            }
        }
        private void Copy(IProgress<int> progress, string path)
        {
            if (!String.IsNullOrEmpty(tb_where.Text) && !String.IsNullOrEmpty(tb_whence.Text))
            {
                var streamRead = new FileStream(path, FileMode.Open);
                var streamWrite = new FileStream($"{nameFolder}\\{Path.GetFileName(path)}", FileMode.Create);
                byte[] buffer = new byte[4096];
                var max = (int)Math.Ceiling((double)streamRead.Length / 4096);
                while (true)
                {
                    if (streamWrite.Length == streamRead.Length)
                        break;
                    var ReadLength = streamRead.Read(buffer, 0, buffer.Length);
                    streamWrite.Write(buffer, 0, ReadLength);
                    progress.Report(1);
                }
                streamRead.Close(); streamRead.Dispose();
                streamWrite.Close(); streamWrite.Dispose();
            }
        }

        private void btn_whence_folder_Click(object sender, EventArgs e)
        {
            var open_window = new FolderBrowserDialog();
            if (open_window.ShowDialog() == DialogResult.OK)
            {
                tb_whence.Text = open_window.SelectedPath;
                nameFolder = Path.GetFileName(open_window.SelectedPath);
                _list_paths.AddRange(Directory.GetFiles(open_window.SelectedPath));
            }
        }
    }
}
