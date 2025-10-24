namespace NT106_Lab2
{
    partial class bai7
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
            this.fileContent = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // fileContent
            // 
            this.fileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContent.Location = new System.Drawing.Point(292, 12);
            this.fileContent.Name = "fileContent";
            this.fileContent.Size = new System.Drawing.Size(678, 697);
            this.fileContent.TabIndex = 0;
            this.fileContent.TabStop = false;
            this.fileContent.Text = "File content";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(274, 697);
            this.treeView.TabIndex = 0;
            // 
            // bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 721);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.fileContent);
            this.Name = "bai7";
            this.Text = "bai7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fileContent;
        private System.Windows.Forms.TreeView treeView;
    }
}