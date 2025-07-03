namespace AnimalSimulation
{
    internal class PositionVaidator
    {
        private Position _startOfTheWorld;
        private Position _endOfTheWorld;

        public PositionVaidator(Position starOfTheWorld, Position endOfTheWorld)
        {
            _startOfTheWorld = starOfTheWorld;
            _endOfTheWorld = endOfTheWorld;
        }
        public bool IsValidPosition(Position position)
        {
            bool IsValidX= position.X >= _startOfTheWorld.X && position.X <= _endOfTheWorld.X;
            bool IsValidY = position.Y >= _startOfTheWorld.Y && position.Y <= _endOfTheWorld.Y;
            if (IsValidX && IsValidY)
            {
                return true;
            }
            return false;
        }
    }
}