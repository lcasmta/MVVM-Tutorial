using MVVM_Tutorial.ViewModel;
using System.Windows;

namespace MVVM_Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}
