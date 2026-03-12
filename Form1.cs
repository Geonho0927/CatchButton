namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void targetButton_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();

            int maxX = this.ClientSize.Width - 160;
            int maxY = this.ClientSize.Height - 70;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            targetButton.Location = new Point(nextX, nextY);

            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
