  class Eternal : Goal
    {
        public Eternal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordGoal()
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
            return $"Eternal:{GetName()},{GetDescription()},{GetPoints()}";
        }
    }
