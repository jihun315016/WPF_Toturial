using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleSource.Bind
{
    public class FruitViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Fruit> _fruitList;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand SaveCommand { get; set; }

        public ObservableCollection<Fruit> FruitList
        {
            get { return _fruitList; }
            set
            {
                _fruitList = value;
                OnPropertyChanged("FruitList");
            }
        }

        public FruitViewModel()
        {
            FruitList = new ObservableCollection<Fruit>()
            {
                new Fruit() {Name = "사과", Price = 2000, IsOranic = true},
                new Fruit() {Name = "딸기", Price = 5000, IsOranic = true},
                new Fruit() {Name = "블루베리", Price = 3000, IsOranic = false}
            };
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        
    }
}
