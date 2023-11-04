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
using System.Windows.Shapes;

namespace WPF.DesignPattern.MVVM.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            txtId.TextChanged += Txt_TextChanged;
            txtName.TextChanged += Txt_TextChanged;
            txtGender.TextChanged += Txt_TextChanged;
            txtAge.TextChanged += Txt_TextChanged;
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 텍스트가 변경이 될 때, 바인딩된 값이 업데이트가 된다.
            BindingExpression be = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }

        private void ListViewItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lstView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
