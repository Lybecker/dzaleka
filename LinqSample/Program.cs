using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Linq query expression. See more at https://linqsamples.com/
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Lambda expression
            var scoreQuery2 = scores.Where((x) => x > 80);

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

        }
    }
}