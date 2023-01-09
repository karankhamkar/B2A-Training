using SupplierCascading.Model;
using System.Collections.Generic;
using System.Linq;

namespace SupplierCascading.Service
{
    public class DataService
    {
        private static List<SubCategory> subCategories = new List<SubCategory>()
        {
            new SubCategory(){Category ="Electronic", Name="Computer"},
            new SubCategory(){Category ="Electronic", Name="Mobile"},
            new SubCategory(){Category ="Electronic", Name="Home Appliences"},
            new SubCategory(){Category ="Food", Name="Grains"},
            new SubCategory(){Category ="Food", Name="Lentiles"},
            new SubCategory(){Category ="Food", Name="Fruits"},
            new SubCategory(){Category ="Medical", Name="Mashine"},
            new SubCategory(){Category ="Medical", Name="Tabletes"},
            new SubCategory(){Category ="Weapons", Name="Missile"},
            new SubCategory(){Category ="Weapons", Name="Hand Granet"},
            new SubCategory(){Category ="Weapons", Name="Tructs"},
        };
        public static List<string> GetAllCategories()
        {
            return subCategories.Select(c => c.Category).Distinct().ToList();
        }
        public static List<string> GetAllSubCategories(string selectedCategory)
        {
            return subCategories.Where(x => x.Category == selectedCategory).Select(y => y.Name).ToList();
        }
    }
}
