namespace _0405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "�������� ������ � ������� ����?",
    "���������",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                button1.BackColor = Color.Red;

            this.TopMost = true;
        }
    }
}