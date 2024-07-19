using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class FoodItem:Invenotory
    {
        public enum FoodType
        {
            wet,
            dry
        }
        public FoodType foodType { get; set; }
        public string Animal;
        public string brand;
    }
}
