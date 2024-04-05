using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Truda_Escape
{
    public partial class Form1 : Form
    {
        //SoundPlayer S_disk = new SoundPlayer(Properties.Resources.дисковод);
        Random random = new Random();
        int side = 0, back = 0, right_d = 0, right_m = 0, left_ = 0;
        Image back_im = Properties.Resources.зад_закрытые_шторы_магнит,
            right_im = Properties.Resources.право_диск_лист, 
            left_im = Properties.Resources.лево_пк_open,
            front_im = Properties.Resources.перед_сток,
            mT = Properties.Resources.магнит_тр , 
            mK = Properties.Resources.магнит_кв, mZ = Properties.Resources.магнит_зв, disk = Properties.Resources.диск;
        string kodik, i_che = "";

        public Form1()
        {
            InitializeComponent();
            kodik = $"{random.Next(9)}{random.Next(9)}{random.Next(9)}{random.Next(9)}";
            kod.Text = kodik;
            mT.Tag = "mT"; mK.Tag = "mK"; mZ.Tag = "mZ"; disk.Tag = "disk";
        }

        private void front_add()
        {
            side = 0;
            this.BackgroundImage = Properties.Resources.перед_фон;
            front_p.Image = front_im;
        }

        private void right_add()
        {
            side = 3;
            this.BackgroundImage = Properties.Resources.право_фон;
            front_p.Image = right_im;
        }

        private void back_add()
        {
            side = 2;
            this.BackgroundImage = Properties.Resources.зад_фон;
            front_p.Image = back_im;
        }

        private async void left_add()
        {
            side = 1;
            this.BackgroundImage = Properties.Resources.лево_фон;
            front_p.Image = left_im;
            if (left_ == 1)
            {
                await Task.Delay(400);
                kod.Visible = true;
            }
        }


        private void i_Click(object sender, EventArgs e)
        {
            i_che = ((PictureBox)sender).Image.Tag.ToString();
        }

        private void inventory_add(Image im)
        {
            for (int i = inventory.Controls.Count - 1; i >= 0; i--)
            {
                if (((PictureBox)inventory.Controls[i]).Image == null)
                {
                    ((PictureBox)inventory.Controls[i]).Image = im;
                    break;
                }
            }
        }

        private void inventory_und(Image im)
        {
            for (int i = inventory.Controls.Count - 1; i >= 0; i--)
            {
                if (((PictureBox)inventory.Controls[i]).Image.Tag == im.Tag)
                {
                    ((PictureBox)inventory.Controls[i]).Image = null;
                    break;
                }
            }
        }

        private void front_ch()
        {
            
        }

        private void right_ch(int X, int Y)
        {
            if (Y > 570 & Y < 670 & X > 310 & X < 465)
            {
                if (right_d == 0 & right_m == 0)
                {
                    right_im = Properties.Resources.право_лист;
                    right_d = 1;
                    inventory_add(disk);
                }
                else if (right_d == 0 & right_m == 1)
                {
                    right_im = Properties.Resources.право_магнит;
                    right_d = 1;
                    inventory_add(disk);
                }
                if (right_d == 0 & right_m == 2)
                {
                    right_im = null;
                    right_d = 1;
                    inventory_add(disk);
                }
            }
            if (Y > 820 & Y < 920 & X > 1030 & X < 1178)
            {
                if(right_d == 0 & right_m == 0)
                {
                    right_im = Properties.Resources.право_диск_магнит;
                    right_m = 1;
                }
                else if(right_d == 0 & right_m == 1)
                {
                    right_im = Properties.Resources.право_диск;
                    right_m = 2;
                    inventory_add(mK);
                }

                else if(right_d == 1 & right_m == 0)
                {
                    right_im = Properties.Resources.право_магнит;
                    right_m = 1;
                }
                else if(right_d == 1 & right_m == 1)
                {
                    right_im = null;
                    right_m = 2;
                    inventory_add(mK);
                }
            }
            front_p.Image = right_im;
        }

        private void back_ch(int X, int Y)
        {
            if (back == 0 & Y > 140 & Y < 870)
            {
                back_im = Properties.Resources.зад_открфтые_шторы_магнит;
                back = 1;
            }
            else if (back == 1 & Y > 550 & Y < 770 & X > 160 & X < 320)
            {
                back_im = Properties.Resources.зад_открфтые_шторы;
                back = 2;
                inventory_add(mZ);
            }
            front_p.Image = back_im;
        }

        private async void left_ch(int X, int Y)
        {
            if (i_che == disk.Tag.ToString() & left_ == 0 & Y > 930 & Y < 1080 & X > 400 & X < 595)
            {
                left_im = Properties.Resources.лево_пк_close;
                left_ = 1;
                inventory_und(disk);
                await Task.Delay(200);
                kod.Visible = true;
            }
            front_p.Image = left_im;
        }

        private void playSound()
        {
            SoundPlayer Sound = new SoundPlayer();
            Sound.Play();
        }

        private void left_Click(object sender, EventArgs e)
        {
            kod.Visible = false;
            switch (side)
            {
                case 0: left_add(); break;
                case 1: back_add(); break;
                case 2: right_add(); break;
                case 3: front_add(); break;
            }
        }

        private void right_Click(object sender, EventArgs e)
        {
            kod.Visible = false;
            switch (side)
            {
                case 0: right_add(); break;
                case 1: front_add(); break;
                case 2: left_add(); break;
                case 3: back_add(); break;
            }
            i_che = "";
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void front_p_MouseClick(object sender, MouseEventArgs e)
        {
            switch (side)
            {
                case 0: ; break;
                case 1: left_ch(e.X, e.Y); break;
                case 2: back_ch(e.X, e.Y); 
                    break;
                case 3: right_ch(e.X, e.Y); break;
            }
            i_che = "";
        }
    }
}
