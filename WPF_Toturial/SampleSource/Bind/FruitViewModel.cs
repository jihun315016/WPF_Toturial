using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleSource.Bind
{
    public class FruitViewModel
    {
        public ICommand SaveCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsOranic { get; set; }

        private ObservableCollection<Fruit> fruitList;

        private FruitRepository _fruitRepository;

        public FruitViewModel(FruitRepository fruitRepository)
        {
            _fruitRepository = fruitRepository;



            fruitList = new ObservableCollection<Fruit>()
            {
                new Fruit() {Name = "사과", Price = 2000, IsOranic = true},
                new Fruit() {Name = "딸기", Price = 5000, IsOranic = true},
                new Fruit() {Name = "블루베리", Price = 3000, IsOranic = false}
            };
        }
    }
}
