using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.DesignPattern.MVVM.Commands
{
    // Command를 작설할 때마다 ICommand를 추가해서 이벤트를 각각 추가하기 번거로우니까
    // CommandBase를 생성하여 상속받을 수 있도록 구현
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object? parameter);
    }
}
