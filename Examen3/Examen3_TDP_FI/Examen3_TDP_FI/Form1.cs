using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen3_TDP_FI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            Stream myStream = null;
            string document_path = "";

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Elije Archivo...";
            openFileDialog1.Filter = "txt file|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                document_path = openFileDialog1.FileName;

                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        ReadFile(document_path);
                    }
                }
            }
        }

        public void ReadFile(string path)
        {

        }
    }
}
