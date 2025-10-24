namespace NT106_Lab2
{
    partial class bai3
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
            this.read = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.readInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(12, 39);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(170, 89);
            this.read.TabIndex = 0;
            this.read.Text = "Đọc";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 349);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(170, 89);
            this.exit.TabIndex = 1;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // readInput
            // 
            this.readInput.Location = new System.Drawing.Point(188, 39);
            this.readInput.Multiline = true;
            this.readInput.Name = "readInput";
            this.readInput.ReadOnly = true;
            this.readInput.Size = new System.Drawing.Size(283, 399);
            this.readInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đọc file input:";
            // 
            // readOutput
            // 
            this.readOutput.Location = new System.Drawing.Point(477, 39);
            this.readOutput.Multiline = true;
            this.readOutput.Name = "readOutput";
            this.readOutput.ReadOnly = true;
            this.readOutput.Size = new System.Drawing.Size(311, 399);
            this.readOutput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đọc file output:";
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readInput);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.read);
            this.Name = "bai3";
            this.Text = "bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox readInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox readOutput;
        private System.Windows.Forms.Label label2;
    }
}