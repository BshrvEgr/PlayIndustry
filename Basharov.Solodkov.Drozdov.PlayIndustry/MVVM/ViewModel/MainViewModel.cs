using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Basharov.Solodkov.Drozdov.PlayIndustry.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<PlayBuilds> playBuilds;
        private List<PlayRoom> playRooms;
        private List<Computer> computers;

        public MainViewModel()
        {
            playBuilds = PlayIndustryEntities.GetConnect().PlayBuilds.ToList();
            playRooms = PlayIndustryEntities.GetConnect().PlayRoom.ToList();
            computers = PlayIndustryEntities.GetConnect().Computer.ToList();
        }

        public List<PlayBuilds> PlayBuilds
        {
            get { return playBuilds; }
            set { playBuilds = value; Update("PlayBuilds"); }
        }

        public List<PlayRoom> PlayRooms
        {
            get { return playRooms; }
            set { playRooms = value; Update("PlayRooms"); }
        }

        public List<Computer> Computers
        {
            get { return computers; }
            set { computers = value; Update("Computers"); }
        }


        #region Commands

        public RelayCommand MainWindowClose
        {
            get
            {
                return new RelayCommand(obj => { CloseWindow(); });
            }
        }

        public RelayCommand MainWindowMinimize
        {
            get
            {
                return new RelayCommand(obj => { MinimizeWindow(); });   
            }
        }

        #endregion

        #region Methods

        private void CloseWindow() => Application.Current.Shutdown();

        private void MinimizeWindow() => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void Update(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
