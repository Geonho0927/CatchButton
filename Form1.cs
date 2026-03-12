using System.Media;
using System.Threading.Tasks;

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

            SystemSounds.Hand.Play();

            Random rd = new Random();

            int maxX = this.ClientSize.Width - 250;
            int maxY = this.ClientSize.Height - 120;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            targetButton.Location = new Point(nextX, nextY);

            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("축하합니다~!");

        }
    }
}
