namespace NT106_Lab2
{
    partial class bai1
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
            this.write = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.read = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(57, 161);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(125, 71);
            this.write.TabIndex = 1;
            this.write.Text = "Ghi";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(188, 52);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(403, 257);
            this.result.TabIndex = 2;
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(57, 84);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(125, 71);
            this.read.TabIndex = 0;
            this.read.Text = "Đọc";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(57, 238);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 71);
            this.exit.TabIndex = 4;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 343);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Name = "bai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button exit;
    }
}