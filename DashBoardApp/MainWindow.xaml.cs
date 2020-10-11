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

namespace DashBoardApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RevenueDistribution inputed = new RevenueDistribution();
            DataContext = new RevenueDistributionViewModel(inputed);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }

    internal class RevenueDistributionViewModel
    {
        //private RevenueDistribution inputed;
        public List<RevenueDistribution> _revenues { get; private set; }

        public RevenueDistributionViewModel(RevenueDistribution inputed)
        {
            _revenues = new List<RevenueDistribution>();
            _revenues.Add(inputed);
        }
    }

    internal class RevenueDistribution
    {
        public string Title { get; private set; }
        public int Percentage { get; private set; }
        public RevenueDistribution()
        {
            Title = "Actual Consumption";
            Percentage = CalculatePercentage();
        }

        private int CalculatePercentage()
        {
            return 58;
        }
    }
}
