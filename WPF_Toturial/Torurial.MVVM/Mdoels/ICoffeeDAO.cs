using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySampleApp.Mdoels
{
    public interface ICoffeeDAO
    {
        public IEnumerable<Coffee> GetAll();
        bool Save(Coffee coffee);
        bool Delete(string name);
    }
}
