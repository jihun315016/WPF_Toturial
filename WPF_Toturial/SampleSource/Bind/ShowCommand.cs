using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleSource.Bind
{
    public class ShowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            // 유효성 검사 생략
            return true;
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
