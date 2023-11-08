using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleSource.Bind
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            // 유효성 검사 생략
            return true;
        }

        /// <summary>
        /// SaveCommand가 호출되면 실행할 동작 정의
        /// </summary>
        /// <param name="parameter"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
