using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace SampleSource.Bind
{
    /// <summary>
    /// exBind1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exBind1 : Window
    {
        private ObservableCollection<Fruit> fruits;

        public exBind1()
        {
            InitializeComponent();

            fruits = new ObservableCollection<Fruit>()
            {
                new Fruit() { Name = "사과", Price = 2000, IsOranic = true },
                new Fruit() { Name = "딸기", Price = 3000, IsOranic = true }
            };
            lstView.ItemsSource = fruits;
        }
    }
}
