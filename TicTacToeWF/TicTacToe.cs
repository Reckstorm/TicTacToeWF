namespace TicTacToeWF
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(170, 200);
            this.Text = "Tic-Tac-Toe";

            this.BackColor = Color.Yellow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;

            this.MaximumSize = new Size(170, 200);
            this.MinimumSize = new Size(170, 200);

            List<Button> buttons = new List<Button>();
            bool isX = false;

            for (int i = 0, x = 0, y = 0; i < 9; i++)
            {
                Button temp = new Button();
                temp.Text = " ";
                temp.ForeColor = Color.White;
                temp.Size = new Size(50, 50);
                temp.Font = new Font("Arial", 15, FontStyle.Bold);
                temp.BackColor = Color.Black;
                temp.Location = new Point(x, y);
                temp.Click += (e, sender) =>
                {
                    if (isX)
                    {
                        temp.Text = "O";
                        temp.BackColor = Color.Transparent;
                        isX = false;
                    }
                    else
                    {
                        temp.Text = "X";
                        temp.BackColor = Color.Transparent;
                        isX = true;
                    }
                    temp.Enabled = false;
                };
                buttons.Add(temp);
                if (i == 2 || i == 5) x = 0;
                else x += 50;
                if (i == 2 || i == 5 || i == 8) y += 50;
            }

            foreach (Button button in buttons) this.Controls.Add(button);
        }
    }
}