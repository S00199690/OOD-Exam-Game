using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static RyanMcDonald_S00199690.Game;

namespace RyanMcDonald_S00199690
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //lists for all games and filtered
        List<Game> AllGames;
        List<Game> filteredGames;

        //intialises database
        GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //querys the database and returns all the games
            var query = from p in db.Games
                        select p;

            AllGames = query.ToList();

            lbxGames.ItemsSource = AllGames;
        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //checks to see what game is being selected
            Game selectedGame = lbxGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tblkGameDetails.Text = $"{selectedGame.Price:C}";
            }
        }

        private void cbxPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //switch statement that checks what the index combobox is currently on
            switch (cbxPlatform.SelectedIndex)
            {
                //all platforms
                case 0:
                    //returns and sorts all games and refreshs game listbox
                    var queryAll = from games in db.Games
                                   select games;
                    filteredGames = queryAll.ToList();
                    lbxGames.ItemsSource = null;
                    lbxGames.ItemsSource = filteredGames;
                    break;

                //pc platform
                case 1:
                    //returns and sorts pc games and refreshs game listbox
                    var queryPC = from games in db.Games
                                      where games.Platform.Contains("PC")
                                      select games;
                   
                    filteredGames = queryPC.ToList();
                    lbxGames.ItemsSource = null;
                    lbxGames.ItemsSource = filteredGames;
                    break;

                //xbox platform
                case 2:
                    //returns and sorts xbox games and refreshs game listbox
                    var queryXbox = from games in db.Games
                                  where games.Platform.Contains("Xbox")
                                  select games;

                    filteredGames = queryXbox.ToList();
                    lbxGames.ItemsSource = null;
                    lbxGames.ItemsSource = filteredGames;
                    break;

                //ps platform
                case 3:
                    //returns and sorts pc games and refreshs game listbox
                    var queryPS = from games in db.Games
                                  where games.Platform.Contains("PS")
                                  select games;

                    filteredGames = queryPS.ToList();
                    lbxGames.ItemsSource = null;
                    lbxGames.ItemsSource = filteredGames;
                    break;

                //switch platform
                case 4:
                    //returns and sorts pc games and refreshs game listbox
                    var querySwitch = from games in db.Games
                                  where games.Platform.Contains("Switch")
                                  select games;

                    filteredGames = querySwitch.ToList();
                    lbxGames.ItemsSource = null;
                    lbxGames.ItemsSource = filteredGames;
                    break;

                default:
                    break;


            }
        }
    }
}
