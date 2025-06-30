namespace AnimalSimulation
{
    internal class PositionVaidator
    {
        public static bool IsValidPosition(Position position, int startX, int endX, int startY, int endY)
        {
            bool IsValidX= position.X >= startX && position.X <= endX;
            bool IsValidY = position.Y >= startY && position.Y <= endY;
            if (IsValidX && IsValidY)
            {
                return true;
            }
            return false;
        }
    }
}