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
using WPF.DesignPattern.Models;

namespace WPF.DesignPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMVC_Click(object sender, RoutedEventArgs e)
        {
            var mainView = new MVC.Views.MainView();
            mainView.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var personRepository = new PersonRepository();

            var mainView = new MVVM.Views.MainView()
            {
                // 데이터 바인딩을 위한 작업
                // View(xaml)에서 MainViewModel의 속성들을 바인딩할 수 있게 된다.
                DataContext = new MVVM.ViewModels.MainViewModel(personRepository) 
            };
            mainView.Show();
        }
    }
}
