namespace assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager



            //// 1
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// 2
            //Console.WriteLine("Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First Grade: " + grades.First());
            //Console.WriteLine("Last Grade: " + grades.Last());

            //// 3
            //grades.Sort();

            //Console.WriteLine("Sorted Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //// 4
            //int firstAbove90 = grades.First(g => g > 90);
            //Console.WriteLine("First grade above 90: " + firstAbove90);

            //// 5
            //List<int> failingGrades = grades.Where(g => g < 75).ToList();

            //Console.WriteLine("Failing Grades:");
            //foreach (int grade in failingGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //// 6
            //grades.RemoveAll(g => g < 75);

            //Console.WriteLine("Grades after removing failing grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //// 7
            //bool has100 = grades.Any(g => g == 100);
            //Console.WriteLine("Any grade equals 100: " + has100);

            //// 8
            //List<string> gradeStrings = grades
            //    .Select(g => "Grade: " + g)
            //    .ToList();

            //Console.WriteLine("Grade Strings:");
            //foreach (string grade in gradeStrings)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion

            #region Exercise 2: Leaderboard

            //// 1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedDictionary<int, string> players = new SortedDictionary<int, string>();

            //players.Add(500, "Ahmed");
            //players.Add(200, "Sara");
            //players.Add(800, "Ali");
            //players.Add(350, "Mona");


            //// 2. Print all entries (they should be sorted by score automatically)
            //foreach (var item in players)
            //{
            //    Console.WriteLine(item.Key + " = " + item.Value);
            //}


            //// 3. Access the first key and first value
            //Console.WriteLine(players.First().Key);
            //Console.WriteLine(players.First().Value);


            //// 4. Check if score 500 exists
            //Console.WriteLine(players.ContainsKey(500));


            //// 5. Safely get the player with score 999
            //if (players.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Player not found");


            //// 6. Remove the player with score 200 and print the updated list
            //players.Remove(200);

            //foreach (var p in players)
            //{
            //    Console.WriteLine(p.Key + " = " + p.Value);
            //    }

            #endregion
            #region Exercise 3: Phone Book
            // 1. Create a Collection  with 4 contacts (name → phone number)

            //    Dictionary<string, string> contacts = new Dictionary<string, string>
            //{
            //    { "Ahmed", "01012345678" },
            //    { "Sara", "01123456789" },
            //    { "Ali", "01234567890" },
            //    { "Mona", "01567890123" }
            //};


            //    // 2. Add a new contact using [] syntax (add or update)
            //    contacts["Omar"] = "01098765432";


            //    // 3. Try adding a duplicate using .Add() — catch the exception and print the error
            //    try
            //    {
            //        contacts.Add("Ahmed", "01111111111");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //    // 4. Try adding a duplicate using .TryAdd() — print whether it succeeded
            //    bool result = contacts.TryAdd("Sara", "01222222222");
            //    Console.WriteLine(result);


            //    // 5. Search for a contact that doesn’t exist
            //    Console.WriteLine(contacts.ContainsKey("Khaled"));


            //    // 6. Get a contact with a fallback of "Not Found"
            //    Console.WriteLine(contacts.GetValueOrDefault("Khaled", "Not Found"));


            //    // 7. Print all Keys on one line, then all Values on another line
            //    Console.WriteLine(string.Join(", ", contacts.Keys));
            //    Console.WriteLine(string.Join(", ", contacts.Values));
            //}
            // }
            #endregion






        }
    }
}
    
