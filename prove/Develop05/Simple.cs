class Simple : Goal
    {
        private bool _isComplete;

        public Simple(string name, string description, int points, bool isComplete = false)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordGoal()
        {
            if (_isComplete)
            {
                Console.WriteLine("This goal is already completed.");
                return 0;
            }

            _isComplete = true;
            Console.WriteLine($"You completed '{GetName()}' and earned {GetPoints()} points!");
            return GetPoints();
        }

        public override string GetStatus()
        {
            string check = _isComplete ? "X" : " ";
            return $"[{check}] {GetName()} ({GetDescription()})";
        }

        public override string GetRepresentation()
        {
            return $"Simple:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
        }
    }