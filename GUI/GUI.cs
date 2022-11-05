namespace DQAPP
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"<��>{DateTime.Now.ToString("HH:mm:ss")}��\n{textBox3.Text}\n";
            string art = textBox3.Text;
            textBox3.Text = "";
            if (art.EndsWith("?") || art.EndsWith("��"))
            {
                if (art.Contains("��"))
                {
                    art = art.Replace("��", "��");
                    art = art.Replace("��", "û��");
                    art = art.Replace("��", "����");
                    art = art.Replace("��", "����");
                }
                else if (art.Contains("��"))
                {
                    art = art.Replace("��", "��");
                    art = art.Replace("��", "û��");
                    art = art.Replace("��", "����");
                    art = art.Replace("����", "��");
                    art = art.Replace("��", "");
                    art = art.Replace("ô", "");
                }
                art = art.Replace("?", "��");
                art = art.Replace("��", "��");
                richTextBox1.Text += $"<{textBox1.Text}>{DateTime.Now.ToString("HH:mm:ss")}��\n{art}\n";
            }
            else
            {
                List<string> appx = new List<string>(new StreamReader(Application.StartupPath + "\\appx.txt").ReadToEnd().Split('\n'));
                richTextBox1.Text += $"<{textBox1.Text}>{DateTime.Now.ToString("HH:mm:ss")}��\n{appx[new Random().Next(0, appx.Count+1)]}\n";
            }
        }
    }
}