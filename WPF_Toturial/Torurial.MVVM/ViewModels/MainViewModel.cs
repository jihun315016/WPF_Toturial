using MySampleApp.Commands;
using MySampleApp.Mdoels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySampleApp.ViewModels
{
    public class MainViewModel
    {
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public bool DecafOption { get; set; }

        private ICoffeeDAO _coffeeDAO;
        private ObservableCollection<Coffee> _coffeeList;


        public MainViewModel(ICoffeeDAO coffeeDAO)
        {
            _coffeeDAO = coffeeDAO;

            SaveCommand = new SaveCommand(_coffeeDAO);

            DeleteCommand = new DeleteCommand(_coffeeDAO);

            DisPlayListView();
        }

        private void DisPlayListView()
        {
            // throw new NotImplementedException();
        }
    }
}
