using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// exHyperLink.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class exHyperLink : Window
    {
        public exHyperLink()
        {
            InitializeComponent();
        }

        private void link_MouseEnter(object sender, MouseEventArgs e)
        {
            link.TextDecorations = TextDecorations.Underline;
        }

        private void link_MouseLeave(object sender, MouseEventArgs e)
        {
            link.TextDecorations = null;
        }

        private void link_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // .NET 6.0 이하
            //System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);

            // .NET 6.0 이상
            Process.Start(new ProcessStartInfo { FileName = link.NavigateUri.ToString(), UseShellExecute = true });

        }
    }
}
