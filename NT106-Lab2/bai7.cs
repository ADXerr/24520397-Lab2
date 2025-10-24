using System.IO;
using System.Windows.Forms;

namespace NT106_Lab2
{
    public partial class bai7 : Form
    {
        private PictureBox pictureBox;
        private TextBox textBox;

        public bai7()
        {
            InitializeComponent();
            SetupFileContent();
            LoadDrives();

            treeView.BeforeExpand += TreeView_BeforeExpand;
            treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            treeView.AfterSelect += TreeView_AfterSelect;
        }

        private void SetupFileContent()
        {
            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Dock = DockStyle.Fill;
            textBox.Visible = false;
            textBox.ReadOnly = true;
            fileContent.Controls.Add(textBox);

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Visible = false;
            fileContent.Controls.Add(pictureBox);
        }

        private void LoadDrives()
        {
            treeView.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("...");
                treeView.Nodes.Add(node);
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                string path = e.Node.Tag.ToString();

                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    node.Tag = dir;
                    node.Nodes.Add("...");
                    e.Node.Nodes.Add(node);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file;
                    e.Node.Nodes.Add(node);
                }
            }
            catch { }
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (Directory.Exists(path))
            {
                e.Node.Expand();
            }
            else if (File.Exists(path))
            {
                DisplayFile(path);
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (File.Exists(path))
            {
                DisplayFile(path);
            }
        }

        private void DisplayFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            pictureBox.Visible = false;
            textBox.Visible = false;

            try
            {
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    pictureBox.Image = System.Drawing.Image.FromFile(path);
                    pictureBox.Visible = true;
                }
                else if (ext == ".txt" || ext == ".cs" || ext == ".html" || ext == ".json" || ext == ".xml")
                {
                    textBox.Text = File.ReadAllText(path);
                    textBox.Visible = true;
                }
                else
                {
                    textBox.Text = "Không thể hiển thị loại file này.";
                    textBox.Visible = true;
                }
            }
            catch
            {
                textBox.Text = "Lỗi khi đọc file hoặc không có quyền truy cập.";
                textBox.Visible = true;
            }
        }
    }
}