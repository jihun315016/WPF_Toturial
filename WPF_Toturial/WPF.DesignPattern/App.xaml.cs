using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.DesignPattern.MVVM.Models;

namespace WPF.DesignPattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var personRepository = new PersonRepository();

            var mainView = new MVVM.Views.MainView()
            {
                // 데이터 바인딩을 위한 작업
                // View(xaml)에서 MainViewModel의 속성들을 바인딩할 수 있게 된다.
                // DataContext -> UI에 바인딩 될 데이터 소스(데이터가 오는 곳)
                DataContext = new MVVM.ViewModels.MainViewModel(personRepository)
            };
            mainView.Show();
        }
    }
}
