using System.Drawing;

namespace Truda_Escape
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.front_p = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.i1 = new System.Windows.Forms.PictureBox();
            this.kod = new System.Windows.Forms.Label();
            this.sumka = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sum_1 = new System.Windows.Forms.NumericUpDown();
            this.back_but = new System.Windows.Forms.Button();
            this.magnitiki = new System.Windows.Forms.GroupBox();
            this.M_vrem = new System.Windows.Forms.Label();
            this.m3 = new System.Windows.Forms.PictureBox();
            this.m2 = new System.Windows.Forms.PictureBox();
            this.m1 = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.front_p)).BeginInit();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i1)).BeginInit();
            this.sumka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum_1)).BeginInit();
            this.magnitiki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).BeginInit();
            this.clock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(12, 560);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 75);
            this.left.TabIndex = 0;
            this.left.Text = "◀";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(1833, 560);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 75);
            this.right.TabIndex = 1;
            this.right.Text = "▶";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // front_p
            // 
            this.front_p.BackColor = System.Drawing.Color.Transparent;
            this.front_p.Image = global::Truda_Escape.Properties.Resources.перед_сток;
            this.front_p.Location = new System.Drawing.Point(0, 0);
            this.front_p.Name = "front_p";
            this.front_p.Size = new System.Drawing.Size(1920, 1080);
            this.front_p.TabIndex = 2;
            this.front_p.TabStop = false;
            this.front_p.MouseClick += new System.Windows.Forms.MouseEventHandler(this.front_p_MouseClick);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 75);
            this.menu.TabIndex = 3;
            this.menu.Text = "≡";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // inventory
            // 
            this.inventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventory.BackColor = System.Drawing.Color.Transparent;
            this.inventory.BackgroundImage = global::Truda_Escape.Properties.Resources.inventory;
            this.inventory.Controls.Add(this.pictureBox4);
            this.inventory.Controls.Add(this.pictureBox3);
            this.inventory.Controls.Add(this.pictureBox2);
            this.inventory.Controls.Add(this.pictureBox1);
            this.inventory.Controls.Add(this.i1);
            this.inventory.Location = new System.Drawing.Point(629, -38);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(664, 172);
            this.inventory.TabIndex = 4;
            this.inventory.TabStop = false;
            this.inventory.Text = " ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(525, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.i_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(402, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.i_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(278, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.i_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(155, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.i_Click);
            // 
            // i1
            // 
            this.i1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.i1.Location = new System.Drawing.Point(32, 44);
            this.i1.Name = "i1";
            this.i1.Size = new System.Drawing.Size(107, 107);
            this.i1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i1.TabIndex = 0;
            this.i1.TabStop = false;
            this.i1.Click += new System.EventHandler(this.i_Click);
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.BackColor = System.Drawing.Color.White;
            this.kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kod.Location = new System.Drawing.Point(571, 663);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(0, 73);
            this.kod.TabIndex = 5;
            this.kod.Visible = false;
            // 
            // sumka
            // 
            this.sumka.BackColor = System.Drawing.Color.Transparent;
            this.sumka.Controls.Add(this.numericUpDown3);
            this.sumka.Controls.Add(this.numericUpDown2);
            this.sumka.Controls.Add(this.numericUpDown1);
            this.sumka.Controls.Add(this.sum_1);
            this.sumka.Location = new System.Drawing.Point(465, 335);
            this.sumka.Name = "sumka";
            this.sumka.Size = new System.Drawing.Size(998, 389);
            this.sumka.TabIndex = 7;
            this.sumka.TabStop = false;
            this.sumka.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 174F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.Location = new System.Drawing.Point(783, 70);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(175, 270);
            this.numericUpDown3.TabIndex = 13;
            this.numericUpDown3.Tag = "1";
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.Kod_ch);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 174F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(536, 70);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(175, 270);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Tag = "1";
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Kod_ch);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 174F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(289, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 270);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Tag = "1";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Kod_ch);
            // 
            // sum_1
            // 
            this.sum_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sum_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 174F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_1.Location = new System.Drawing.Point(41, 70);
            this.sum_1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.sum_1.Name = "sum_1";
            this.sum_1.Size = new System.Drawing.Size(175, 270);
            this.sum_1.TabIndex = 10;
            this.sum_1.Tag = "1";
            this.sum_1.ValueChanged += new System.EventHandler(this.Kod_ch);
            // 
            // back_but
            // 
            this.back_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_but.Location = new System.Drawing.Point(920, 974);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(75, 75);
            this.back_but.TabIndex = 9;
            this.back_but.Text = "▼";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Visible = false;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // magnitiki
            // 
            this.magnitiki.BackColor = System.Drawing.Color.Transparent;
            this.magnitiki.Controls.Add(this.M_vrem);
            this.magnitiki.Controls.Add(this.m3);
            this.magnitiki.Controls.Add(this.m2);
            this.magnitiki.Controls.Add(this.m1);
            this.magnitiki.Location = new System.Drawing.Point(0, -23);
            this.magnitiki.Name = "magnitiki";
            this.magnitiki.Size = new System.Drawing.Size(1920, 1087);
            this.magnitiki.TabIndex = 10;
            this.magnitiki.TabStop = false;
            this.magnitiki.Visible = false;
            // 
            // M_vrem
            // 
            this.M_vrem.AutoSize = true;
            this.M_vrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 171.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M_vrem.Location = new System.Drawing.Point(622, 454);
            this.M_vrem.Name = "M_vrem";
            this.M_vrem.Size = new System.Drawing.Size(725, 260);
            this.M_vrem.TabIndex = 4;
            this.M_vrem.Text = "label1";
            this.M_vrem.Visible = false;
            // 
            // m3
            // 
            this.m3.Location = new System.Drawing.Point(1248, 617);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(400, 400);
            this.m3.TabIndex = 6;
            this.m3.TabStop = false;
            this.m3.Click += new System.EventHandler(this.magnit_Click);
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(251, 617);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(517, 400);
            this.m2.TabIndex = 5;
            this.m2.TabStop = false;
            this.m2.Click += new System.EventHandler(this.magnit_Click);
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(270, 75);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(400, 400);
            this.m1.TabIndex = 0;
            this.m1.TabStop = false;
            this.m1.Click += new System.EventHandler(this.magnit_Click);
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.Color.Transparent;
            this.clock.Controls.Add(this.numericUpDown5);
            this.clock.Controls.Add(this.numericUpDown4);
            this.clock.Location = new System.Drawing.Point(585, 129);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(801, 800);
            this.clock.TabIndex = 11;
            this.clock.TabStop = false;
            this.clock.Visible = false;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 204F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown5.Location = new System.Drawing.Point(429, 243);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(321, 315);
            this.numericUpDown5.TabIndex = 4;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.clock_ch);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 204F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown4.Location = new System.Drawing.Point(51, 243);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(321, 315);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.clock_ch);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Truda_Escape.Properties.Resources.перед_фон;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.sumka);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.magnitiki);
            this.Controls.Add(this.front_p);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Truda Escape";
            ((System.ComponentModel.ISupportInitialize)(this.front_p)).EndInit();
            this.inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i1)).EndInit();
            this.sumka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum_1)).EndInit();
            this.magnitiki.ResumeLayout(false);
            this.magnitiki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).EndInit();
            this.clock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.PictureBox front_p;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.GroupBox inventory;
        private System.Windows.Forms.PictureBox i1;
        private System.Windows.Forms.Label kod;
        private System.Windows.Forms.GroupBox sumka;
        private System.Windows.Forms.NumericUpDown sum_1;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox magnitiki;
        private System.Windows.Forms.PictureBox m1;
        private System.Windows.Forms.Label M_vrem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox m3;
        private System.Windows.Forms.PictureBox m2;
        private System.Windows.Forms.GroupBox clock;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

