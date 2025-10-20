namespace NT106_Lab2
{
    partial class menuForm
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
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.bai7 = new System.Windows.Forms.Button();
            this.bai5 = new System.Windows.Forms.Button();
            this.bai6 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.Location = new System.Drawing.Point(62, 40);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(123, 62);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bài 1";
            this.bai1.UseVisualStyleBackColor = true;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.Location = new System.Drawing.Point(191, 40);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(123, 62);
            this.bai2.TabIndex = 1;
            this.bai2.Text = "Bài 2";
            this.bai2.UseVisualStyleBackColor = true;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai3
            // 
            this.bai3.Location = new System.Drawing.Point(320, 40);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(123, 62);
            this.bai3.TabIndex = 2;
            this.bai3.Text = "Bài 3";
            this.bai3.UseVisualStyleBackColor = true;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai4
            // 
            this.bai4.Location = new System.Drawing.Point(449, 40);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(123, 62);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "Bài 4";
            this.bai4.UseVisualStyleBackColor = true;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // bai7
            // 
            this.bai7.Location = new System.Drawing.Point(320, 108);
            this.bai7.Name = "bai7";
            this.bai7.Size = new System.Drawing.Size(123, 62);
            this.bai7.TabIndex = 4;
            this.bai7.Text = "Bài 7";
            this.bai7.UseVisualStyleBackColor = true;
            this.bai7.Click += new System.EventHandler(this.bai7_Click);
            // 
            // bai5
            // 
            this.bai5.Location = new System.Drawing.Point(62, 108);
            this.bai5.Name = "bai5";
            this.bai5.Size = new System.Drawing.Size(123, 62);
            this.bai5.TabIndex = 5;
            this.bai5.Text = "Bài 5";
            this.bai5.UseVisualStyleBackColor = true;
            this.bai5.Click += new System.EventHandler(this.bai5_Click);
            // 
            // bai6
            // 
            this.bai6.Location = new System.Drawing.Point(191, 108);
            this.bai6.Name = "bai6";
            this.bai6.Size = new System.Drawing.Size(123, 62);
            this.bai6.TabIndex = 6;
            this.bai6.Text = "Bài 6";
            this.bai6.UseVisualStyleBackColor = true;
            this.bai6.Click += new System.EventHandler(this.bai6_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(261, 210);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 62);
            this.exit.TabIndex = 7;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 303);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bai6);
            this.Controls.Add(this.bai5);
            this.Controls.Add(this.bai7);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai2;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai4;
        private System.Windows.Forms.Button bai7;
        private System.Windows.Forms.Button bai5;
        private System.Windows.Forms.Button bai6;
        private System.Windows.Forms.Button exit;
    }
}

