 class Program
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        private void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine($"You have {_score} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create new goal");
                Console.WriteLine(" 2. List goals");
                Console.WriteLine(" 3. Save goals");
                Console.WriteLine(" 4. Load goals");
                Console.WriteLine(" 5. Record goals");
                Console.WriteLine(" 6. Quit");
                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input == "1")
                {
                    CreateGoal();
                }
                else if (input == "2")
                {
                    ListGoals();
                }
                else if (input == "3")
                {
                    SaveGoals();
                }
                else if (input == "4")
                {
                    LoadGoals();
                }
                else if (input == "5")
                {
                    RecordGoal();
                }
                else if (input == "6")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
                private void CreateGoal()
        {
            Console.WriteLine("The type of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string choice = Console.ReadLine();

            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                _goals.Add(new Simple(name, description, points));
            }
            else if (choice == "2")
            {
                _goals.Add(new Eternal(name, description, points));
            }
            else if (choice == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new Checklist(name, description, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }
        }
        private void ListGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            Console.WriteLine("The goals are: ");

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            }
        }
        private void RecordGoal()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record yet.");
                return;
            }
            ListGoals();
            Console.Write("Which goal did you accomplish? ");

            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            int index = num - 1;
            if (index < 0 || index >= _goals.Count)
            {
                Console.WriteLine("Invalid goal.");
                return;
            }
            int earned = _goals[index].RecordEvent();
            _score += earned;

            Console.WriteLine($"Congragulations! You have earned {earned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string file = Console.ReadLine();

            using (StreamWriter output = new StreamWriter(file))
            {
                output.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    output.WriteLine(goal.GetRepresentation());
                }
            }
        }
        private void LoadGoals()
        {
            Console.Write("File name to load: ");
            string file = Console.ReadLine();

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(file);

            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                Goal goal = CreateGoal(lines[i]);
                _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded!");
        }
        private Goal CreateGoal(string line)
        {
            string[] typeAndData = line.Split(':');
            string type = typeAndData[0];
            string[] parts = typeAndData[1].Split(',');

            if (type == "Simple")
            {
                return new Simple(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2]),
                    bool.Parse(parts[3]));
            }
            if (type == "Eternal")
            {
                return new Eternal(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2]));
            }
            return new Checklist(
                parts[0],
                parts[1],
                int.Parse(parts[2]),
                int.Parse(parts[4]),
                int.Parse(parts[5]),
                int.Parse(parts[3]));
        }
    }
