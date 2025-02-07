using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJack_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BJEngine gameEngine = null;
     

        string path = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\PNG-cards-1.3\\";

        public MainWindow()
        {
            InitializeComponent();
            gameEngine = new BJEngine();
            gameEngine.Start();

            // Disable the Hit and Stand buttons initially
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;

            UpdateScreen();
        }

        private void UpdateScreen()
        {
            PlayerPanel.Children.Clear();
            DealerPanel.Children.Clear();

            foreach (Card c in gameEngine.playerCards)
            {
                ShowCard(c, PlayerPanel);
            }

            foreach (Card c in gameEngine.dealerCards)
            {
                ShowCard(c, DealerPanel);
            }

            // Update chips display after every change
            UpdateChipsDisplay();
        }

        // Method to handle placing the bet
        private void PlaceBet_Click(object sender, RoutedEventArgs e)
        {
            // Get the bet amount entered by the player
            string betAmountText = BetAmount.Text;

            // Try to parse the bet amount
            if (int.TryParse(betAmountText, out int betAmount))
            {
                if (betAmount <= gameEngine.playerChips && betAmount > 0)
                {
                    // Set the current bet in the game engine
                    gameEngine.currentBet = betAmount;

                    // Update the displayed chips
                    UpdateChipsDisplay();

                    // Disable BetAmount TextBox and enable Hit/Stand buttons
                    BetAmount.IsEnabled = false;
                    HitButton.IsEnabled = true;
                    StandButton.IsEnabled = true;

                    MessageBox.Show($"Bet of {betAmount} placed!");
                    UpdateChipsDisplay();
                }
                else
                {
                    MessageBox.Show("Invalid bet amount. Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the bet.");
            }
        }
        // Method to update the chips display
        private void UpdateChipsDisplay()
        {
            ChipsDisplay.Text = "Chips: " + gameEngine.playerChips;
        }

        private void ShowCard(Card c, WrapPanel panel)
        {
            ImageSource imgSource = new BitmapImage(new Uri(path + c.GetImageFileName()));
            Image image = new Image();
            image.Source = imgSource;
            image.Margin = new Thickness(5);
            panel.Children.Add(image);
        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {



            //By professor:

            bool hitResult = gameEngine.Hit();
            UpdateScreen();

            if (!hitResult)
            {
                MessageBox.Show("Busted!!! Game Over!");
                HitButton.IsEnabled = false;  // Disable Hit button after bust
            }
        }


        private void StandButton_Click(Object sender, RoutedEventArgs e)
        {
             //TODO: Assginment1

            string result = gameEngine.Stand();
            MessageBox.Show(result);
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;

            // Update the screen to show dealer's drawn cards
            UpdateScreen();

            // Optionally, adjust chips based on the result


            bool playerWon = result.Contains("You Win");
            gameEngine.AdjustChips(playerWon);
        }
       

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            // Clearing the game panels
            PlayerPanel.Children.Clear();
            DealerPanel.Children.Clear();

            // Restarting the game engine
            gameEngine.ResetGame();
            gameEngine.Start();

            // Updating screen
            UpdateScreen();

            // Enable BetAmount TextBox for new bet
            BetAmount.IsEnabled = true;
            BetAmount.Clear();

            // Disable the Hit and Stand buttons until a valid bet is placed
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;

            MessageBox.Show("Game Restarting....");
        }
    }
}
       

   


