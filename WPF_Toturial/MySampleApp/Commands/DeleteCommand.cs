using MySampleApp.Mdoels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySampleApp.Commands
{
    public class DeleteCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private ICoffeeDAO _coffeeDAO;

        public DeleteCommand(ICoffeeDAO coffeeDAO)
        {
            _coffeeDAO = coffeeDAO;
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
