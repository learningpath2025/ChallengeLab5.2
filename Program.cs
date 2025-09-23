using System.Collections.Immutable;

namespace ChallengeLab5._2
{
    internal class Program
    {
        public static IEnumerable<int> MissingNumbers(int[] ia, int l)
        {
            Array.Sort(ia);
            int[] nn = GetNaturalNumbers(l).ToArray();
            var d = nn.Except(ia);
            return d;
        }

        public static List<int> GetNaturalNumbers(int x)
        {
            List<int> n = new List<int>();
            for(int i = 1; i <= x; i++)
            {
                n.Add(i);              
            }
            return n;
        }

        static void Main(string[] args)
        {
            int[] ia = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int l = ia.Length;
            var d = MissingNumbers(ia, l);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
