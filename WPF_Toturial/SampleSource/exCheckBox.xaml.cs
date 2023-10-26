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

namespace SampleSource
{
    /// <summary>
    /// exCheckBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exCheckBox : Window
    {
        public exCheckBox()
        {
            InitializeComponent();
        }

        private void chkAll_Checked(object sender, RoutedEventArgs e)
        {
            ChangeCheckBoxStatusToChkAll();
        }

        private void chkAll_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeCheckBoxStatusToChkAll();
        }

        private void ChangeCheckBoxStatusToChkAll()
        {
            foreach (var element in stackPanel.Children)
            {
                if (element is CheckBox ele)
                {
                    ele.IsChecked = chkAll.IsChecked;
                }
            }
        }    
    }
}
