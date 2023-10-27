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
    /// exTextBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exTextBox : Window
    {
        public exTextBox()
        {
            InitializeComponent();
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show(txt1.Text);
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show(txt2.Text);
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show(txt3.Text);
        }
    }
}
