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
        int side = 0, back = 0, right_d = 0, right_m = 0, left_ = 0, temp;
        Image back_front = Properties.Resources.перед_фон, back_left = Properties.Resources.лево_фон, back_back = Properties.Resources.зад_фон, back_right = Properties.Resources.право_фон,
            back_im = Properties.Resources.зад_закрытые_шторы_магнит,
            right_im = Properties.Resources.право_диск_лист, 
            left_im = Properties.Resources.лево_пк_open,
            front_im = Properties.Resources.перед_сток,
            mT = Properties.Resources.магнит_тр , 
            mK = Properties.Resources.магнит_кв, mZ = Properties.Resources.магнит_зв, disk = Properties.Resources.диск,
            sum_im = Properties.Resources.сумка_замок;
        string kodik, i_che = "";
        bool sum_kod = false, front_Tru = false, front_M = false, front_Ch = false,
            i_mT = false, i_mZ = false, i_mK = false, i_disk = false;

        string vrem;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(1920, 1080);
            kodik = $"{random.Next(9)}{random.Next(9)}{random.Next(9)}{random.Next(9)}";
            kod.Text = kodik;
            temp = random.Next(24);
            vrem = $"{(temp < 10 ? $"0{temp}" : $"{temp}")}:";
            temp = random.Next(59);
            vrem += $"{(temp < 10 ? $"0{temp}" : $"{temp}")}";
            M_vrem.Text = vrem;
            mT.Tag = "mT"; mK.Tag = "mK"; mZ.Tag = "mZ"; disk.Tag = "disk";
        }


        private void front_add()
        {
            side = 0;
            this.BackgroundImage = back_front;
            front_p.Image = front_im;
        }


        private void Kod_ch(object sender, EventArgs e)
        {
            int j = 0;

            for (int i = sumka.Controls.Count - 1; i >= 0; i--)
            {
                if (Convert.ToChar((((NumericUpDown)sumka.Controls[i]).Value).ToString()) == kod.Text[kodik.Length - 1 - i])
                {
                    j++; 
                }
                else
                {
                   break;
                }
            }
            if(j == 4)
            {
                sum_kod = true;
                sumka.Visible = false;
            }
        }

        private void right_add()
        {
            side = 3;
            this.BackgroundImage = back_right;
            front_p.Image = right_im;
        }

        private void back_add()
        {
            side = 2;
            this.BackgroundImage = back_back;
            front_p.Image = back_im;
        }

        private async void left_add()
        {
            side = 1;
            this.BackgroundImage = back_left;
            front_p.Image = left_im;
            if (left_ == 1)
            {
                await Task.Delay(400);
                kod.Visible = true;
            }
        }

        private void i_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image != null)
            {
                i_che = ((PictureBox)sender).Image.Tag.ToString();
            }
            else
            {
                i_che = "";
            }
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
                if (((PictureBox)inventory.Controls[i]).Image != null)
                {
                    if (((PictureBox)inventory.Controls[i]).Image.Tag == im.Tag)
                    {
                        ((PictureBox)inventory.Controls[i]).Image = null;
                        break;
                    }
                }
            }
        }

        private void magnit_Click(object sender, EventArgs e)
        {
            if (i_mK & i_mT & i_mZ)
            {
                inventory_und(mK);
                inventory_und(mT);
                inventory_und(mZ);
                for (int i = magnitiki.Controls.Count - 1; i >= 0; i--)
                {
                    ((PictureBox)magnitiki.Controls[i]).Visible = false;
                }
                M_vrem.Visible = true;
            }
        }

        private void front_ch(int X, int Y)
        {
            if(Y > 471 & Y < 831 & X > 93 & X < 411 & !front_Tru)
            {
                if (back >= 1)
                {
                    front_Tru = true;
                    MessageBox.Show("Там МЕТЕОРИИИИТ за окном!!", "Студент:");
                    MessageBox.Show("Не может быть! Надо скорее сообщить администрации!!!", "Татьяна Владимировна:");
                    front_im = Properties.Resources.перед_без_ТВ_магнит;
                    front_p.Image = front_im;
                }
                else
                {
                    MessageBox.Show("Вы готовы сдать практическую работу? Я вас слушаю.", "Татьяна Владимировна:");
                }
            }

            else if (Y > 736 & Y < 887 & X > 476 & X < 684)
            {
                if (!sum_kod)
                {
                    if (front_Tru)
                    {
                        this.BackgroundImage = sum_im;
                        front_p.Image = null;
                        left.Visible = false;
                        right.Visible = false;
                        ///sumka.BringToFront();
                        sumka.Visible = true;
                        //back_but.BringToFront();
                        back_but.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("НЕ ТРОГАЙ МОЮ СУМКУ!!!!!!", "Татьяна Владимировна:");
                    }
                }
                else
                {
                    this.BackgroundImage = sum_im;
                    front_p.Image = null;
                    left.Visible = false;
                    right.Visible = false;
                    back_but.Visible = true;
                }
            }
            else if(this.BackgroundImage == sum_im & Y > 0 & Y < 1080 & X > 0 & X < 1920)
            {
                if ( !i_mT)
                {
                    inventory_add(mT);
                    i_mT = true;
                }
            }
            else if (Y > 234 & Y < (234 + 248) & X > 694 & X < (694 + 266))
            {
                if (!front_M)
                {
                    if (front_Tru)
                    {
                        this.BackgroundImage = null;
                        front_p.Image = null;
                        left.Visible = false;
                        right.Visible = false;
                        magnitiki.Visible = true;
                        back_but.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Не играйтесь с доской!", "Татьяна Владимировна:");
                    }
                }
            }
            front_p.Refresh();
            //front_p.Image = front_im;
        }

        private void right_ch(int X, int Y)
        {
            if (Y > 570 & Y < 670 & X > 310 & X < 465)
            {
                if (right_d == 0 & right_m == 0)
                {
                    right_im = Properties.Resources.право_лист;
                }
                else if (right_d == 0 & right_m == 1)
                {
                    right_im = Properties.Resources.право_магнит;
                }
                if (right_d == 0 & right_m == 2)
                {
                    right_im = null;
                }
                right_d = 1;
                inventory_add(disk);
                i_disk = true;
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
                    i_mK = true;
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
                    i_mK = true;
                }
            }
            front_p.Image = right_im;
        }

        private void back_ch(int X, int Y)
        {
            if (back == 0 & Y > 140 & Y < 870)
            {
                back_im = Properties.Resources.зад_открфтые_шторы_магнит;
                front_p.Image = back_im;
                MessageBox.Show("ЭТО ЧТО.... МЕТЕОРИИИИИТ!??!!??!!?! Надо рассказать...", "... ..:");
                back = 1;
            }
            else if (back == 1 & Y > 550 & Y < 770 & X > 160 & X < 320)
            {
                back_im = Properties.Resources.зад_открфтые_шторы;
                back = 2;
                inventory_add(mZ);
                i_mZ = true;
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
                i_disk = false;
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

        private void back_but_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.перед_фон;
            front_p.Image = front_im;
            sumka.Visible = false;
            magnitiki.Visible = false;
            left.Visible = true;
            front_p.Visible = true;
            right.Visible = true;
            back_but.Visible = false;
            front_p.Refresh();
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
            front_p.Refresh();
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
            front_p.Refresh();
            i_che = "";
        }

        private void menu_Click(object sender, EventArgs e)
        {
            
        }

        private void front_p_MouseClick(object sender, MouseEventArgs e)
        {
            switch (side)
            {
                case 0: front_ch(e.X, e.Y); break;
                case 1: left_ch(e.X, e.Y); break;
                case 2: back_ch(e.X, e.Y); 
                    break;
                case 3: right_ch(e.X, e.Y); break;
            }
            i_che = "";
        }
    }
}
