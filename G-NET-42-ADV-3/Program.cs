namespace G_NET_42_ADV_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise1
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades[0]}");
            Console.WriteLine($"Last: {grades[grades.Count - 1]}");

            grades.Sort();
            Console.WriteLine("Sorted Grades:");
            foreach (var g in grades)
                Console.Write(g + " ");
            Console.WriteLine();

            int firstAbove90 = -1;
            foreach (var g in grades)
            {
                if (g > 90)
                {
                    firstAbove90 = g;
                    break;
                }
            }
            Console.WriteLine($"First > 90: {firstAbove90}");

            Console.WriteLine("Failing Grades (<75):");
            foreach (var g in grades)
            {
                if (g < 75)
                    Console.Write(g + " ");
            }
            Console.WriteLine();

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("After removing failing:");
            foreach (var g in grades)
                Console.Write(g + " ");
            Console.WriteLine();

            bool has100 = false;
            foreach (var g in grades)
            {
                if (g == 100)
                {
                    has100 = true;
                    break;
                }
            }
            Console.WriteLine("Contains 100? " + has100);

            Console.WriteLine("Grades as strings:");
            foreach (var g in grades)
                Console.WriteLine("Grade: " + g);
            #endregion
        }
    }
}
