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

namespace SampleSource.Bind
{
    /// <summary>
    /// exBinding1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exBinding : Window
    {
        public exBinding()
        {
            InitializeComponent();

            Binding binding = new Binding();

            // Source : 입력하는 부분
            binding.Source = txt2; 

            // 바인딩 될 속성
            binding.Path = new PropertyPath(TextBox.TextProperty);

            // 바인딩 방향
            binding.Mode = BindingMode.TwoWay; 

            // Target : 출력되는 부분
            lbl2.SetBinding(Label.ContentProperty, binding); 
        }
    }
}
