using EOGCodeChallenge.ViewModels;
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

namespace EOGCodeChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameModel _game;
        //Testing repsotiry changes
        public MainWindow()
        {
            InitializeComponent();

            _game = new GameModel();
            grid1.DataContext = _game;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
            // Load data by setting the CollectionViewSource.Source property:
            // playerListModelViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource playerModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playerModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // playerModelViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource gameModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("gameModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // gameModelViewSource.Source = [generic data source]
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _game.ExecuteSimulation();
        }
    }
}
