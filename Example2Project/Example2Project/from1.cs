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

namespace Example2Project
{
    public partial class from1 : Form
    {
        public from1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Red;
            staColor.Text = txtEditor.BackColor.ToString();

            //or

            // btnRed_Click(null, null);

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Blue;
            staColor.Text = txtEditor.BackColor.ToString();

            //or
            // btnBlue_Click(null, null);

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Green;
            staColor.Text = txtEditor.BackColor.ToString();

            //or
            // btnGreen_Click(null, null);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = txtEditor.BackColor;
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = dlgColor.Color;
                staColor.Text = txtEditor.BackColor.ToString();
            }

        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = txtEditor.ForeColor;
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = dlgColor.Color;
                staColor.Text = txtEditor.ForeColor.ToString();
            }


        }

        private void mnuRedBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Red;
            staColor.Text = txtEditor.BackColor.ToString();



        }

        private void mnuBlueBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Blue;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuGreenBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.Green;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuOtherBg_Click(object sender, EventArgs e)
        {
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = dlgColor.Color;
                staColor.Text = txtEditor.BackColor.ToString();
            }

        }

        private void mnuFg_Click(object sender, EventArgs e)
        {
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = dlgColor.Color;
                staColor.Text = txtEditor.ForeColor.ToString();
            }

        }

        private void mnuRed2_Click(object sender, EventArgs e)
        {
            btnRed_Click(null, null);
        }

        private void mnuBlue2_Click(object sender, EventArgs e)
        {
            btnBlue_Click(null, null);

        }

        private void mnuGreen2_Click(object sender, EventArgs e)
        {
                btnGreen_Click(null, null);

        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = txtEditor.Font;
            var result = dlgFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.Font = dlgFont.Font;
            }
            

        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Left;

        }

        private void mnuAlignCenter_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Center; 
        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Right;

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            var result = dlgOpen.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgOpen.FileName;
                //logic to open
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Open);
                    sr = new StreamReader(fs);
                    txtEditor.Text = sr.ReadToEnd ();
                   

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }



            }


        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            var result = dlgSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgSave.FileName;
                //logic to save
                FileStream fs = null;
                StreamWriter sw= null;
                try
                {
                    fs=new FileStream(fileName, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(txtEditor.Text);
                   
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                    if(fs!= null)
                    {
                        fs.Close();
                    }
                }
                

                
            }
        }
    }
}
