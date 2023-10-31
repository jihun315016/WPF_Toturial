using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.DesignPattern.MVVM.Commands
{
    public class RelayCommand<T> : ICommand
    {

        // 2:30~
        private readonly Action<T>? _excute;
        private readonly Predicate<T> _canExcute;

        public RelayCommand(Action<T>? excute, Predicate<T> canExcute = null)
        {
            this._excute = excute;
            this._canExcute = canExcute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
