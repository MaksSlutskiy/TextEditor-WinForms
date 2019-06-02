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

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|JSON (*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = File.ReadAllText(ofd.FileName);
                textBox1.Enabled = true;
            }
           


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Text files (*.txt)| *.txt|All files (*.*)|*.*|JSON (*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(ofd.FileName, textBox1.Text);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Enabled = false;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowHelp = true;
           
            MyDialog.Color = textBox1.ForeColor;


            if (MyDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = MyDialog.Color;
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.png)|*.png|AllImage (*.*)|*.*|JSON (*.jpg)|*.jpg";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }

        private void textColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        private void toCutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Paste(Clipboard.GetText());

            
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Cut();
        }
    }
}
