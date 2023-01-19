using Basharov.Solodkov.Drozdov.PlayIndustry.ViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Basharov.Solodkov.Drozdov.PlayIndustry
{
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e) => this.DragMove();

        public void Update()
        {
            mainViewModel.PlayBuilds = PlayIndustryEntities.GetConnect().PlayBuilds.ToList();
            mainViewModel.PlayRooms = PlayIndustryEntities.GetConnect().PlayRoom.ToList();
            mainViewModel.Computers = PlayIndustryEntities.GetConnect().Computer.ToList();
        }

        private void PlayBuildsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayBuilds playBuild = (PlayBuilds)PlayBuildsListView.SelectedItem;
            var rooms = PlayIndustryEntities.GetConnect().PlayRoom.Where(r => r.IdPlayBuild == playBuild.IdBuild).ToList();
            PlayRoomsListView.ItemsSource = rooms;
            PlayRoomsListView.Visibility = Visibility.Visible;
            ComputersListView.Visibility = Visibility.Hidden;
        }

        private void PlayRoomsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(PlayRoomsListView.Visibility != Visibility.Hidden)
            {
                PlayRoom playRoom = (PlayRoom)PlayRoomsListView.SelectedItem;
                var computers = PlayIndustryEntities.GetConnect().Computer.Where(c => c.IdPlayRoom == playRoom.IdRoom).ToList();
                ComputersListView.ItemsSource = computers;
                PlayRoomsListView.Visibility = Visibility.Hidden;
                ComputersListView.Visibility = Visibility.Visible;
            }
        }

        private void Reserve_Click(object sender, RoutedEventArgs e)
        {
            var reserveComputer = (sender as Button).DataContext as Computer;
            if (reserveComputer.IsActive != true)
            {
                ReserveWindow window = new ReserveWindow(reserveComputer);
                window.Show();
            }
        }
    }
}
