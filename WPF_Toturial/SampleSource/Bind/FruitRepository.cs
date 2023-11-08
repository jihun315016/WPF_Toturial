using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSource.Bind
{
    public class FruitRepository
    {
        private List<Fruit> fruitList;

        public FruitRepository()
        {
            fruitList = new List<Fruit>()
            {
                new Fruit() {Name = "사과", Price = 2000, IsOranic = true},
                new Fruit() {Name = "딸기", Price = 5000, IsOranic = true},
                new Fruit() {Name = "블루베리", Price = 3000, IsOranic = false}
            };
        }

        public IEnumerable<Fruit> GetAll()
        {
            return fruitList ??= new List<Fruit>();
        }

        public bool Save(Fruit fruit)
        {
            try
            {
                Fruit? item = fruitList.Find(n => n.Name == fruit.Name);
                if (item == null)
                {
                    fruitList.Add(fruit);
                }
                else
                {
                    item.Name = fruit.Name;
                    item.Price = fruit.Price;
                    item.IsOranic = fruit.IsOranic;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
