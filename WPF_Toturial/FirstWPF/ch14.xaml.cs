using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace FirstApp
{
    /// <summary>
    /// ch14.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch14 : Window
    {
        public ch14()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|JSON File(*.json)|*.json";
            
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // richTxt 컨텐트 시작부터 끝까지 범위 지정
                    TextRange textRange = new TextRange(richTxt.Document.ContentStart, richTxt.Document.ContentEnd);
                    sw.WriteLine(textRange.Text);
                    MessageBox.Show("파일이 저장되었습니다.");
                }
            }
        }
    }
}
