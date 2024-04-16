namespace Truda_Escape
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu_box = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_box
            // 
            this.Menu_box.BackColor = System.Drawing.Color.Transparent;
            this.Menu_box.Controls.Add(this.button1);
            this.Menu_box.Location = new System.Drawing.Point(261, 97);
            this.Menu_box.Name = "Menu_box";
            this.Menu_box.Size = new System.Drawing.Size(417, 584);
            this.Menu_box.TabIndex = 0;
            this.Menu_box.TabStop = false;
            this.Menu_box.Text = "Меню";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.Menu_box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Menu_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu_box;
        private System.Windows.Forms.Button button1;
    }
}