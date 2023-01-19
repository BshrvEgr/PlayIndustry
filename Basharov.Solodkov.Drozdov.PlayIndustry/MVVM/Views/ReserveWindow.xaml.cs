using System.Linq;
using System.Windows;


namespace Basharov.Solodkov.Drozdov.PlayIndustry
{
    public partial class ReserveWindow : Window
    {
        MainWindow window = new MainWindow();
        private Computer currentComputer;
        public ReserveWindow(Computer computer)
        {
            InitializeComponent();

            if (computer != null)
                currentComputer = computer;
        }

        private void ReserveComputer_Click(object sender, RoutedEventArgs e)
        {
            PlayIndustryEntities.GetConnect().Customer.Add(new Customer { FullName = FullNameText.Text });
            PlayIndustryEntities.GetConnect().SaveChanges();
            currentComputer.IdCustomer = PlayIndustryEntities.GetConnect().Customer.Where(c => c.FullName == FullNameText.Text).FirstOrDefault().Id;
            currentComputer.IsActive = true;
            PlayIndustryEntities.GetConnect().SaveChanges();
            window.Update();
            this.Close();
        }
    }
}
