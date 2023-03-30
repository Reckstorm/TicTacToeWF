namespace TicTacToeWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 200);
            this.Text = "Tic-Tac-Toe";

            this.BackColor = Color.Yellow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;

            this.MaximumSize = new Size(170, 200);
            this.MinimumSize = new Size(170, 200);

            List<Button> buttons = new List<Button>();

            for (int i = 0, x = 0, y = 0; i < 9; i++)
            {
                Button temp = new Button();
                temp.Text = " ";
                temp.ForeColor = Color.White;
                temp.Size = new Size(50, 50);
                temp.Font = new Font("Arial", 15, FontStyle.Bold);
                temp.BackColor = Color.Black;
                temp.Location = new Point(x, y); 
                buttons.Add(temp);
                if (i == 2 || i == 5) x = 0;
                else x += 50;
                if (i == 2 || i == 5 || i == 8) y += 50;
            }

            foreach (Button button in buttons) this.Controls.Add(button);
        }

        #endregion
    }
}