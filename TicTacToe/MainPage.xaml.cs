namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        public int Turn = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        public void Winner(string Sign)
        {
            LblWinner.Text += Sign;
            SemanticScreenReader.Announce(LblWinner.Text);
            btnOne.IsEnabled = false;
            btnTwo.IsEnabled = false;
            btnThree.IsEnabled = false;
            btnFour.IsEnabled = false;
            btnFive.IsEnabled = false;
            btnSix.IsEnabled = false;
            btnSeven.IsEnabled = false;
            btnEight.IsEnabled = false;
            btnNine.IsEnabled = false;
            ReplayBtn.IsVisible = true;
        }
        public void Checker(object sender)
        {
            string[] Squers = {btnOne.Text,btnTwo.Text,btnThree.Text,btnFour.Text,btnFive.Text,btnSix.Text,btnSeven.Text,btnEight.Text,btnNine.Text};
            if (Squers[0] == Squers[1] && Squers[1] == Squers[2] && Squers[0] != "" && Squers[1] != "" && Squers[2] != "")
                Winner(Squers[0]);
            else if (Squers[3] == Squers[4] && Squers[4] == Squers[5] && Squers[3] != "" && Squers[4] != "" && Squers[5] != "")
                Winner(Squers[3]);
            else if (Squers[6] == Squers[7] && Squers[7] == Squers[8] && Squers[6] != "" && Squers[7] != "" && Squers[8] != "")
                Winner(Squers[6]);
            else if (Squers[0] == Squers[4] && Squers[4] == Squers[8] && Squers[0] != "" && Squers[4] != "" && Squers[8] != "")
                Winner(Squers[0]);
            else if (Squers[2] == Squers[5] && Squers[5] == Squers[7] && Squers[2] != "" && Squers[5] != "" && Squers[7] != "")
                Winner(Squers[2]);
            else if (Squers[0] == Squers[3] && Squers[3] == Squers[6] && Squers[0] != "" && Squers[3] != "" && Squers[6] != "")
                Winner(Squers[0]);
            else if (Squers[1] == Squers[4] && Squers[4] == Squers[7] && Squers[4] != "" && Squers[4] != "" && Squers[7] != "")
                Winner(Squers[1]);
            else if (Squers[2] == Squers[5] && Squers[5] == Squers[8] && Squers[5] != "" && Squers[5] != "" && Squers[8] != "")
                Winner(Squers[2]);
            else if (Squers[0] != "" && Squers[1] != "" && Squers[2] != "" && Squers[3] != "" && Squers[4] != "" && Squers[5] != "" && Squers[6] != "" && Squers[7] != "" && Squers[8] != "")
                Winner("DRAW!");
        }
        private void OnReplayClicked(object sender, EventArgs e)
        {
            btnOne.IsEnabled = true;
            btnTwo.IsEnabled = true;
            btnThree.IsEnabled = true;
            btnFour.IsEnabled = true;
            btnFive.IsEnabled = true;
            btnSix.IsEnabled = true;
            btnSeven.IsEnabled = true;
            btnEight.IsEnabled = true;
            btnNine.IsEnabled = true;
            ReplayBtn.IsVisible = false;
            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            btnFive.Text = "";
            btnSix.Text = "";
            btnSeven.Text = "";
            btnEight.Text = "";
            btnNine.Text = "";
            Turn = 0;
            LblPlayer.Text = "Current player: x";
            LblWinner.Text = "Winner is: ";
            SemanticScreenReader.Announce(LblPlayer.Text);
            SemanticScreenReader.Announce(LblPlayer.Text);
        }
        private void OnSqrClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Turn % 2 == 0)
            {
                btn.Text = "x";
                LblPlayer.Text = "Current player: o";
            }
            else
            {
                btn.Text = "o";
                LblPlayer.Text = "Current player: x";
            }
            btn.IsEnabled= false;
            Turn++;
            SemanticScreenReader.Announce(btn.Text);
            SemanticScreenReader.Announce(LblPlayer.Text);
            Checker(sender);
        }
    }
}