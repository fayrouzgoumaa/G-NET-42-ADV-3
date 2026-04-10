namespace G_NET_42_ADV_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise1
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First: {grades[0]}");
            //Console.WriteLine($"Last: {grades[grades.Count - 1]}");

            //grades.Sort();
            //Console.WriteLine("Sorted Grades:");
            //foreach (var g in grades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //int firstAbove90 = -1;
            //foreach (var g in grades)
            //{
            //    if (g > 90)
            //    {
            //        firstAbove90 = g;
            //        break;
            //    }
            //}
            //Console.WriteLine($"First > 90: {firstAbove90}");

            //Console.WriteLine("Failing Grades (<75):");
            //foreach (var g in grades)
            //{
            //    if (g < 75)
            //        Console.Write(g + " ");
            //}
            //Console.WriteLine();

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("After removing failing:");
            //foreach (var g in grades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //bool has100 = false;
            //foreach (var g in grades)
            //{
            //    if (g == 100)
            //    {
            //        has100 = true;
            //        break;
            //    }
            //}
            //Console.WriteLine("Contains 100? " + has100);

            //Console.WriteLine("Grades as strings:");
            //foreach (var g in grades)
            //    Console.WriteLine("Grade: " + g);
            #endregion
            #region Exercise2
            //List<KeyValuePair<string, int>> players = new List<KeyValuePair<string, int>>();

            //players.Add(new KeyValuePair<string, int>("Ahmed", 500));
            //players.Add(new KeyValuePair<string, int>("Sara", 200));
            //players.Add(new KeyValuePair<string, int>("Ali", 800));
            //players.Add(new KeyValuePair<string, int>("Mona", 350));

            //players.Sort((a, b) => b.Value.CompareTo(a.Value));

            //Console.WriteLine("Leaderboard:");
            //foreach (var p in players)
            //    Console.WriteLine($"{p.Key} - {p.Value}");

            //Console.WriteLine($"Top Player: {players[0].Key}");

            //bool found500 = false;
            //foreach (var p in players)
            //{
            //    if (p.Value == 500)
            //    {
            //        found500 = true;
            //        break;
            //    }
            //}
            //Console.WriteLine("Score 500 exists? " + found500);

            //bool found999 = false;
            //foreach (var p in players)
            //{
            //    if (p.Value == 999)
            //    {
            //        Console.WriteLine(p.Key);
            //        found999 = true;
            //    }
            //}
            //if (!found999)
            //    Console.WriteLine("Score 999 not found");

            //players.RemoveAll(p => p.Value == 200);

            //Console.WriteLine("After removing score 200:");
            //foreach (var p in players)
            //    Console.WriteLine($"{p.Key} - {p.Value}");
            #endregion
            #region Exercise3
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook["Ahmed"] = "0100";
            phoneBook["Sara"] = "0111";
            phoneBook["Ali"] = "0122";
            phoneBook["Mona"] = "0133";
            phoneBook["Omar"] = "0144";
            try
            {
                phoneBook.Add("Ahmed", "9999");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Duplicate Error: " + ex.Message);
            }
            bool added = phoneBook.TryAdd("Sara", "8888");
            Console.WriteLine("TryAdd Sara success? " + added);

            if (!phoneBook.ContainsKey("Khaled"))
                Console.WriteLine("Khaled not found");

            if (phoneBook.TryGetValue("Khaled", out string number))
                Console.WriteLine(number);
            else
                Console.WriteLine("Not Found");
            Console.WriteLine("Names:");
            foreach (var key in phoneBook.Keys)
                Console.Write(key + " ");

            Console.WriteLine();

            Console.WriteLine("Numbers:");
            foreach (var value in phoneBook.Values)
                Console.Write(value + " ");
            #endregion
        }
    }
}
