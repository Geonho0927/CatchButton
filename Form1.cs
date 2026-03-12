using System.Media;
using System.Threading.Tasks;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void targetButton_MouseEnter(object sender, EventArgs e)
        {
            score -= 5;
            SystemSounds.Hand.Play();

            Random rd = new Random();

            int maxX = this.ClientSize.Width - targetButton.Width;
            int maxY = this.ClientSize.Height - targetButton.Height;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            targetButton.Location = new Point(nextX, nextY);

            this.Text = $"버튼 위치: ({nextX}, {nextY}), 점수: {score}점";
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            score += 100;
            SystemSounds.Beep.Play();
            targetButton.Width = (int)(targetButton.Width * 0.9);
            targetButton.Height = (int)(targetButton.Height * 0.9);
            MessageBox.Show("축하합니다~!");

        }
    }
}
