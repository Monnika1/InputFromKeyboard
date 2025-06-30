namespace AnimalSimulation
{
    public record class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Position MoveByX(int newX)
        {
            if (X == 0 && newX == -1) 
            {
                return new Position(0, Y); 
            }
            if (X == 3 && newX == 1) 
            {
                return new Position(3, Y); 
            }
          return  new Position(X + newX, Y);
        }
        public Position MoveByY(int newY)
        {
            if (Y == 0 && newY == -1)
            {
                return new Position(X, 0);
            }
            if (Y == 3 && newY == 1) 
            {
                return new Position(X, 3);
            }
            return new Position(X, Y + newY);
        }
    }
}