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
        public Position MoveByX(int newX) =>  new Position(X + newX, Y);
        public Position MoveByY(int newY) => new Position(X, Y + newY);
    }
}