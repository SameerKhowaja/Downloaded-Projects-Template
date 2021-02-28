using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class ScreenShot_image : Form
    {
        public ScreenShot_image()
        {
            InitializeComponent();

            Pic_Box.SizeMode = PictureBoxSizeMode.StretchImage; // to be the Capture Image  as size as the Picture Box size 
            Pic_Box.Image = Form1.BM; 
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Image File | *.PNG";
            SFD.FileName = "";
            if(SFD.ShowDialog()==DialogResult.OK)
            {
                Form1.BM.Save(SFD.FileName);
            }
        }
    }
}
