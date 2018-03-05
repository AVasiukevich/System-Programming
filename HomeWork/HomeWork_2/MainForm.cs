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

namespace HomeWork_2
{
    public partial class mainForm : Form
    {
        private string nameFile;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_whence_Click(object sender, EventArgs e)
        {
            tb_whence.Text = string.Empty;
            var open_window = new OpenFileDialog();
            open_window.Filter = "All files (*.*)|*.*";
            if (open_window.ShowDialog() == DialogResult.OK)
            {
                tb_whence.Text = open_window.FileName;
                nameFile = open_window.SafeFileName;
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
            new Thread(Copy).Start();
        }
        private void Copy()
        {
            if (!String.IsNullOrEmpty(tb_where.Text) && !String.IsNullOrEmpty(tb_whence.Text))
            {
                var streamRead = new FileStream(tb_whence.Text, FileMode.Open);
                var streamWrite = new FileStream($"{tb_where.Text}\\{nameFile}", FileMode.Create);
                byte[] buffer = new byte[4096];
                var max = (int)Math.Ceiling((double)streamRead.Length / 4096);

                while (true)
                {
                    if (streamWrite.Length == streamRead.Length)
                        break;
                    var ReadLength = streamRead.Read(buffer, 0, buffer.Length);
                    streamWrite.Write(buffer, 0, ReadLength);
                    this.Invoke(new Action<int>(GetProgress), max);
                }

                streamRead.Close(); streamRead.Dispose();
                streamWrite.Close(); streamWrite.Dispose();
            }
        }
        private void GetProgress(int max)
        {
            if(prg_main.Value == 0)
                prg_main.Maximum = max;

            ++prg_main.Value;
        }
    }
}
