using MySampleApp.Mdoels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySampleApp.Commands
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private ICoffeeDAO _coffeeeDAO;

        public SaveCommand(ICoffeeDAO coffeeDAO)
        {
            _coffeeeDAO = coffeeDAO;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
            // throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            // bool result = _coffeeeDAO.Save(new Coffee());
        }
    }
}
