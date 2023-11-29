using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// exBinding2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exBinding2 : Window
    {
        List<Beverage> beverageList;

        public exBinding2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(System.Environment.CurrentDirectory);
            string imagePath = "pack://application:,,,/Assets/tes.png";
            if (System.IO.File.Exists(imagePath))
            {
                MessageBox.Show("!!");
            }
            else
            {
                MessageBox.Show("??");
            }
            beverageList = new List<Beverage>()
            {
                new Coffee() {Name = "아메리카노", Price = 1500},
                new Coffee() {Name = "카페라떼", Price = 2500},
                new Coffee() {Name = "콜드브루", Price = 2500},
                new Coffee() {Name = "카페모카", Price = 3500},
                new Tea() {Name = "아이스티", Price = 1500},
                new Tea() {Name = "캐모마일", Price = 2000},
                new Tea() {Name = "페퍼민트", Price = 2000}
            };

            lst.ItemsSource = beverageList.FindAll(b => b.Category == BeverageCategory.Coffee);
        }
    }
}
