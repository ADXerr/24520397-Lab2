namespace NT106_Lab2
{
    partial class bai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.MonAn = new System.Windows.Forms.TextBox();
            this.ListMonAn = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MonAnHomNay = new System.Windows.Forms.TextBox();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picURL = new System.Windows.Forms.TextBox();
            this.picURLButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn:";
            // 
            // MonAn
            // 
            this.MonAn.Location = new System.Drawing.Point(148, 39);
            this.MonAn.Name = "MonAn";
            this.MonAn.Size = new System.Drawing.Size(287, 22);
            this.MonAn.TabIndex = 1;
            // 
            // ListMonAn
            // 
            this.ListMonAn.Location = new System.Drawing.Point(441, 39);
            this.ListMonAn.Multiline = true;
            this.ListMonAn.Name = "ListMonAn";
            this.ListMonAn.ReadOnly = true;
            this.ListMonAn.Size = new System.Drawing.Size(347, 337);
            this.ListMonAn.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(224, 382);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(124, 59);
            this.Add.TabIndex = 3;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(18, 382);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(124, 59);
            this.Find.TabIndex = 4;
            this.Find.Text = "Tìm món ăn";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(450, 382);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(124, 59);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(664, 382);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 59);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Món ăn hôm nay là";
            // 
            // MonAnHomNay
            // 
            this.MonAnHomNay.Location = new System.Drawing.Point(255, 501);
            this.MonAnHomNay.Name = "MonAnHomNay";
            this.MonAnHomNay.ReadOnly = true;
            this.MonAnHomNay.Size = new System.Drawing.Size(287, 22);
            this.MonAnHomNay.TabIndex = 8;
            // 
            // picHinh
            // 
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinh.Location = new System.Drawing.Point(182, 164);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(253, 212);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinh.TabIndex = 9;
            this.picHinh.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Họ và tên:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(287, 22);
            this.name.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hình ảnh món ăn:";
            // 
            // picURL
            // 
            this.picURL.Location = new System.Drawing.Point(184, 119);
            this.picURL.Name = "picURL";
            this.picURL.Size = new System.Drawing.Size(215, 22);
            this.picURL.TabIndex = 13;
            // 
            // picURLButton
            // 
            this.picURLButton.Location = new System.Drawing.Point(405, 119);
            this.picURLButton.Name = "picURLButton";
            this.picURLButton.Size = new System.Drawing.Size(30, 23);
            this.picURLButton.TabIndex = 14;
            this.picURLButton.Text = "...";
            this.picURLButton.UseVisualStyleBackColor = true;
            this.picURLButton.Click += new System.EventHandler(this.picURLButton_Click);
            // 
            // bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.picURLButton);
            this.Controls.Add(this.picURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.MonAnHomNay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListMonAn);
            this.Controls.Add(this.MonAn);
            this.Controls.Add(this.label1);
            this.Name = "bai6";
            this.Text = "BAI8";
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MonAn;
        private System.Windows.Forms.TextBox ListMonAn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonAnHomNay;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox picURL;
        private System.Windows.Forms.Button picURLButton;
    }
}