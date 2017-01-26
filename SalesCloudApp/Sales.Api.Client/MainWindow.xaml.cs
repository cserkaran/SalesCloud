using Sales.Api.Client.Services;
using System.Windows;

namespace Sales.Api.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // initialize the shell context.
            ClientContext.Instance.Initialize();
            DataContext = ClientContext.Instance.MainVm;
        }
    }
}
