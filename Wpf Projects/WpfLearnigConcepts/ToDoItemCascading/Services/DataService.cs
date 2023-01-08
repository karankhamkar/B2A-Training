using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoItemCascading.Model;

namespace ToDoItemCascading.Services
{
    public class DataService
    {
        private static List<SubCategory> subCategories = new List<SubCategory>()
        {
            new SubCategory(){Category = "Personal", Name = "Health"},
            new SubCategory(){Category = "Personal", Name = "Education"},
            new SubCategory(){Category = "official", Name = "Meeting"},
            new SubCategory(){Category = "official", Name = "Training"},
            new SubCategory(){Category = "Mis", Name = "Timpass"},
        };
        public static List<string> GetAllCategories()
        {
            return subCategories.Select(x => x.Category).Distinct().ToList();
        }
        public static List<string> GetAllSubCategories(string selectedCategory)
        {
            //  Lambda
            return subCategories.Where(y => y.Category == selectedCategory).Select(y => y.Name).ToList();

            //List<string> result = new List<string>();

            // 1. Simple For Loop
            //for (int i = 0; i < subCategories.Count; i++)
            //{
            //    var subCategory = subCategories[i];

            //    if (subCategory.Category == selectedCategory)
            //    {
            //        result.Add(subCategory.Name);
            //    }
            //}

            // 2. Better For each Loop
            //foreach (SubCategory subCategory in subCategories)
            //{
            //    if (subCategory.Category == selectedCategory)
            //    {
            //        result.Add(subCategory.Name);
            //    }
            //}

            //return result;

            // 3. LINQ
            //return (from sc in subCategories
            //          where sc.Category == selectedCategory
            //          select sc.Name).ToList();

           
        }
    }
    
}
