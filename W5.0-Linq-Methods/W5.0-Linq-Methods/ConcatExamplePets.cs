using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5._0_Linq_Methods
{
    public class ConcatExamplePets
    {
        public string Name { get; set; }

        public int Age { get; set; }


        private static ConcatExamplePets[] GetCats()
        {
            ConcatExamplePets[] cats = { new ConcatExamplePets { Name="Barley", Age=8 },
                                     new ConcatExamplePets { Name="Boots", Age=4 },
                                     new ConcatExamplePets { Name="Whiskers", Age=1 } };
            return cats;
        }


        static ConcatExamplePets[] GetDogs()
        {
            ConcatExamplePets[] dogs = { new ConcatExamplePets { Name="Bounder", Age=3 },
                                     new ConcatExamplePets { Name="Snoopy", Age=14 },
                                     new ConcatExamplePets { Name="Fido", Age=9 } };
            return dogs;
        }

        public static void ConcatExample()
        {
            ConcatExamplePets[] cats = GetCats();
            ConcatExamplePets[] dogs = GetDogs();

            IEnumerable<string> query =
                cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name));

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
