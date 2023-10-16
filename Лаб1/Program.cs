using Library;


namespace Лаб1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MazeGame game = new ();
            Maze mazeWithBomb = game.Create(new MazeWithBombFactory());
            Console.WriteLine("Лабиринт с ловушками!");

            Room room1WithBomb = mazeWithBomb.RoomNo(1);
            room1WithBomb.Enter();

            Maze mazeWithTraps = game.Create(new MazeWithTrapFactory());
            Room room1WithTrap = mazeWithTraps.RoomNo(1);
            room1WithTrap.Enter();
            Console.ReadLine();
        }
    }
}
