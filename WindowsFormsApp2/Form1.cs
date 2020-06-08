using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYGPS;

namespace WindowsFormsApp2
{
    public partial class form1 : Form
    {
        public string path;
        public bool ischange = false;
        public form1()
        {
            InitializeComponent();
        }

        private void choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                path = openFile.FileName;
            }
            text1.Text = path;
            ischange = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (ischange)
            {
                ischange = false;
                StringBuilder str = START.start(path);
                Clipboard.SetText(str.ToString());
                MessageBox.Show("转换结果已复制到剪切板,请粘贴到网页左侧的框里");
            }
            else
            {
                MessageBox.Show("请先选择文件");
            }
           
        }
    }
}
