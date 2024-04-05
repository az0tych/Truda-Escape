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
            this.i5 = new System.Windows.Forms.PictureBox();
            this.i4 = new System.Windows.Forms.PictureBox();
            this.i3 = new System.Windows.Forms.PictureBox();
            this.i2 = new System.Windows.Forms.PictureBox();
            this.i1 = new System.Windows.Forms.PictureBox();
            this.kod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.front_p)).BeginInit();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i1)).BeginInit();
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
            this.inventory.Controls.Add(this.i5);
            this.inventory.Controls.Add(this.i4);
            this.inventory.Controls.Add(this.i3);
            this.inventory.Controls.Add(this.i2);
            this.inventory.Controls.Add(this.i1);
            this.inventory.Location = new System.Drawing.Point(629, -38);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(664, 172);
            this.inventory.TabIndex = 4;
            this.inventory.TabStop = false;
            this.inventory.Text = " ";
            // 
            // i5
            // 
            this.i5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.i5.Location = new System.Drawing.Point(525, 45);
            this.i5.Name = "i5";
            this.i5.Size = new System.Drawing.Size(107, 107);
            this.i5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i5.TabIndex = 4;
            this.i5.TabStop = false;
            this.i5.Click += new System.EventHandler(this.i_Click);
            // 
            // i4
            // 
            this.i4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.i4.Location = new System.Drawing.Point(402, 45);
            this.i4.Name = "i4";
            this.i4.Size = new System.Drawing.Size(107, 107);
            this.i4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i4.TabIndex = 3;
            this.i4.TabStop = false;
            this.i4.Click += new System.EventHandler(this.i_Click);
            // 
            // i3
            // 
            this.i3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.i3.Location = new System.Drawing.Point(278, 45);
            this.i3.Name = "i3";
            this.i3.Size = new System.Drawing.Size(107, 107);
            this.i3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i3.TabIndex = 2;
            this.i3.TabStop = false;
            this.i3.Click += new System.EventHandler(this.i_Click);
            // 
            // i2
            // 
            this.i2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.i2.Location = new System.Drawing.Point(155, 44);
            this.i2.Name = "i2";
            this.i2.Size = new System.Drawing.Size(107, 107);
            this.i2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i2.TabIndex = 1;
            this.i2.TabStop = false;
            this.i2.Click += new System.EventHandler(this.i_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Truda_Escape.Properties.Resources.перед_фон;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.front_p);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Truda Escape";
            ((System.ComponentModel.ISupportInitialize)(this.front_p)).EndInit();
            this.inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.i5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i1)).EndInit();
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
        private System.Windows.Forms.PictureBox i2;
        private System.Windows.Forms.PictureBox i5;
        private System.Windows.Forms.PictureBox i4;
        private System.Windows.Forms.PictureBox i3;
        private System.Windows.Forms.Label kod;
    }
}

