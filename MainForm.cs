using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        public static string imagePath;
        private Form1 form1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create new OpenFileDialog instance
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //Set the filter
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            //Set the initial dir
            openFileDialog1.InitialDirectory =  "C:";

            //Set the title
            openFileDialog1.Title = "Open a image file";

            //Make multiselect false
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                form1 = new Form1();
                form1.Show();
            }
        }    
    }
}
