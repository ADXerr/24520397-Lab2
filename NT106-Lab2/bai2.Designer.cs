namespace NT106_Lab2
{
    partial class bai2
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
            this.content = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.readFileName = new System.Windows.Forms.TextBox();
            this.readSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readLineCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.readWordCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.readCharacterCount = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(0, 0);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(196, 83);
            this.read.TabIndex = 0;
            this.read.Text = "Đọc ";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(354, 12);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(434, 426);
            this.content.TabIndex = 1;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(12, 111);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(77, 24);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "Tên file:";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(12, 152);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(51, 24);
            this.size.TabIndex = 3;
            this.size.Text = "Size:";
            // 
            // readFileName
            // 
            this.readFileName.Location = new System.Drawing.Point(95, 114);
            this.readFileName.Name = "readFileName";
            this.readFileName.ReadOnly = true;
            this.readFileName.Size = new System.Drawing.Size(253, 22);
            this.readFileName.TabIndex = 4;
            // 
            // readSize
            // 
            this.readSize.Location = new System.Drawing.Point(95, 155);
            this.readSize.Name = "readSize";
            this.readSize.ReadOnly = true;
            this.readSize.Size = new System.Drawing.Size(253, 22);
            this.readSize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL:";
            // 
            // readURL
            // 
            this.readURL.Location = new System.Drawing.Point(95, 197);
            this.readURL.Multiline = true;
            this.readURL.Name = "readURL";
            this.readURL.ReadOnly = true;
            this.readURL.Size = new System.Drawing.Size(253, 53);
            this.readURL.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số dòng:";
            // 
            // readLineCount
            // 
            this.readLineCount.Location = new System.Drawing.Point(105, 267);
            this.readLineCount.Name = "readLineCount";
            this.readLineCount.ReadOnly = true;
            this.readLineCount.Size = new System.Drawing.Size(243, 22);
            this.readLineCount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số từ:";
            // 
            // readWordCount
            // 
            this.readWordCount.Location = new System.Drawing.Point(95, 311);
            this.readWordCount.Name = "readWordCount";
            this.readWordCount.ReadOnly = true;
            this.readWordCount.Size = new System.Drawing.Size(253, 22);
            this.readWordCount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số kí tự:";
            // 
            // readCharacterCount
            // 
            this.readCharacterCount.Location = new System.Drawing.Point(95, 353);
            this.readCharacterCount.Name = "readCharacterCount";
            this.readCharacterCount.ReadOnly = true;
            this.readCharacterCount.Size = new System.Drawing.Size(253, 22);
            this.readCharacterCount.TabIndex = 13;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(0, 405);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(196, 46);
            this.exit.TabIndex = 14;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.readCharacterCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.readWordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readLineCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readSize);
            this.Controls.Add(this.readFileName);
            this.Controls.Add(this.size);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.content);
            this.Controls.Add(this.read);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.TextBox readFileName;
        private System.Windows.Forms.TextBox readSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox readURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readLineCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox readWordCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox readCharacterCount;
        private System.Windows.Forms.Button exit;
    }
}