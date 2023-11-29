using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSource.Bind
{
    public class Beverage
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public BeverageCategory Category { get; set; }
    }


    public class Coffee : Beverage 
    {
        // Coffee 고유의 속성이 있다면 작성

        public Coffee() 
        { 
            Category = BeverageCategory.Coffee;
            ImagePath = @"/Bind/coffee.png";
            //ImagePath = @"C:\Users\jihun\coding\WPF_Toturial\WPF_Toturial\SampleSource\Assets\coffee.png";
        }
    }
    

    public class Tea : Beverage 
    {
        // Tea 고유의 속성이 있다면 작성

        public Tea()
        {
            Category = BeverageCategory.Tea;
            ImagePath = @"/Bind/tea.png";
        }
    }


    public enum BeverageCategory
    {
        Coffee,
        Tea
    }
}
