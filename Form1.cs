using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageViewer;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                var width = screen.Width;
                var height = screen.Height;

                InitializeComponent();
                pictureBox1.Image = System.Drawing.Image.FromFile(MainForm.imagePath);
                this.ClientSize = new Size(pictureBox1.Image.Width, pictureBox1.Image.Height);
                this.MaximumSize = new Size(width, height);
                pictureBox1.Size = new Size(pictureBox1.Image.Width, pictureBox1.Image.Height);
                pictureBox1.MaximumSize = new Size(width, height);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("ERROR: 404 FILE NOT FOUND");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("ERROR: NO INPUT IN TEXTFIELD");
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("ERROR: UNKNOWN FILE TYPE. PLEASE CHOOSE A IMAGE FILE");
            }
        }
    }
}
