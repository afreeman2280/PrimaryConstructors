using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors
{
    public class CollectionExpression
    {
        int[] ages = { 1, 2, 3, 4, 5 };
        List<int > ageValues = new List< int>() { 98,4,22,45};
        

        public void PrintAges(IEnumerable<int> ageslist)
        {
            foreach (var age in ageslist)
            {
                Console.WriteLine(age);
            }
        }


    }
}
