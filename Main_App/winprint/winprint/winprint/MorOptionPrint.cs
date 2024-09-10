using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winprint
{
    public partial class MorOptionPrint : Form
    {
        int pagesizecortroller;
        public MorOptionPrint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDGV.AddCellHeight =int.Parse( numericUpDownCellHeight.Value.ToString());
            PrintDGV.AddWidth = trackBarPageWidth.Value;
            this.Close();
        }

        private void numericUpDownCellHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDGV.AddCellHeight = 0; 
            PrintDGV.AddWidth = 0;
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
                        label2.Text = (trackBarPageWidth.Value/2).ToString();


                        pic_landscape.Left = 182 - (trackBarPageWidth.Value / 2);
                        pic_landscape.Width = 50 + (trackBarPageWidth.Value);
                        pagesizecortroller = int.Parse(label2.Text);
               
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MorOptionPrint_Load(object sender, EventArgs e)
        {
            pagesizecortroller = 0;
            if (System.IO.File.Exists("Arm.png"))
                pictureBox1.Image = Image.FromFile("Arm.Png");
            if (System.IO.File.Exists("backgroundimage.png"))
                pictureBox2.Image = Image.FromFile("backgroundimage.Png");
            if (System.IO.File.Exists("FontSetting.txt"))
                button5.Font = FontSetting.ReadFontFromText();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            button3_Click(null,null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (.png)|*.png|All Files (*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);

                if (System.IO.File.Exists("Arm.png"))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    System.IO.File.Delete("Arm.png");
                }

                System.IO.File.Copy(op.FileName, "Arm.png");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (.png)|*.png|All Files (*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(op.FileName);

                if (System.IO.File.Exists("backgroundimage.png"))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    System.IO.File.Delete("backgroundimage.png");
                }

                System.IO.File.Copy(op.FileName, "backgroundimage.png");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button4_Click(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            if (System.IO.File.Exists("backgroundimage.png"))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                System.IO.File.Delete("backgroundimage.png");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;

            if (System.IO.File.Exists("backgroundimage.png"))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                System.IO.File.Delete("backgroundimage.png");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            

            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                button5.Font = fontDlg.Font;
                FontSetting.SaveFontToText(fontDlg.Font);
                //button5.ForeColor = fontDlg.Color; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FontSetting.RemoveFont();
        }

        private void contextMenuStripArm_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("Arm.png"))
                
                {
                    pictureBox1.Image = null;
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    ProcessStartInfo startInfo = new ProcessStartInfo("Arm.png");
                    startInfo.Verb = "edit";

                    Process.Start(startInfo);
                    if (System.IO.File.Exists("Arm.png"))
                        pictureBox1.Image = Image.FromFile("Arm.Png");
                }
            }
            catch
            {
                ;
            }

        }

        private void ویرایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (System.IO.File.Exists("backgroundimage.png"))
                {
                    pictureBox2.Image = null;
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    ProcessStartInfo startInfo = new ProcessStartInfo("backgroundimage.png");
                    startInfo.Verb = "edit";

                    Process.Start(startInfo);
                  
                    if (System.IO.File.Exists("backgroundimage.png"))
                        pictureBox2.Image = Image.FromFile("backgroundimage.Png");
                }
            }
            catch
            {
                ;
            }
        }

        private void contextMenuBackground_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
