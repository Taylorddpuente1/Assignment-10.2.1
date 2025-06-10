// find the positive number from list of nums -LINQ QUERY
using System.Threading.Channels;

namespace LINQAssignment
{
    class program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, -1, 3, -3, 10, -200 };
            var positivenumbers = from num in nums
                                  where num > 0
                                  select num;
            foreach (var num in positivenumbers)
            {

                Console.WriteLine(num);
            }

        }
    }
}