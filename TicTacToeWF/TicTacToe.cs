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

            for (int i = 1, x = 0, y = 0; i < 10; i++)
            {
                Button temp = new Button();
                temp.Text = "";
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
                    if (((buttons[0].Text == buttons[1].Text && buttons[1].Text == buttons[2].Text) && (buttons[0].Text != string.Empty)) || 
                    ((buttons[3].Text == buttons[4].Text && buttons[4].Text == buttons[5].Text) && (buttons[3].Text != string.Empty)) ||
                    ((buttons[6].Text == buttons[7].Text && buttons[7].Text == buttons[8].Text) && (buttons[6].Text != string.Empty)) ||
                    ((buttons[0].Text == buttons[3].Text && buttons[3].Text == buttons[6].Text) && (buttons[0].Text != string.Empty)) ||
                    ((buttons[1].Text == buttons[4].Text && buttons[4].Text == buttons[7].Text) && (buttons[1].Text != string.Empty)) ||
                    ((buttons[2].Text == buttons[5].Text && buttons[5].Text == buttons[8].Text) && (buttons[2].Text != string.Empty)))
                    {
                        this.Text = "Game Over!";
                        foreach (Button button in buttons) button.Enabled = false;
                    }
                };
                buttons.Add(temp);
                x += 50;
                if (i%3 == 0)
                {
                    x = 0;
                    y += 50;
                }
            }

            foreach (Button button in buttons) this.Controls.Add(button);
        }
    }
}