  class Eternal : Goal
    {
        public Eternal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            Console.WriteLine($"You recorded '{GetName()}' and earned {GetPoints()} points!");
            return GetPoints();
        }

        public override string GetStatus()
        {
            return $"[] {GetName()} ({GetDescription()})";
        }

        public override string GetRepresentation()
        {
            // Eternal:Name,Description,Points
            return $"Eternal:{GetName()},{GetDescription()},{GetPoints()}";
        }
    }
