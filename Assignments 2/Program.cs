// See https://aka.ms/new-console-template for more information




    public class class1
    {
        public static void Main(string[] args)
        {
            ///

        }
    }
    public class Game
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Game(int x, int y)
        {
            X = x;
            Y = y;

        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



    public class Player
    {
        public String Name { get; set; }
        public int GemCount { get; set; }

        public Position Position { get; set; }


        public Player(string name, Position startPosition)
        {
            Name = name;
            Position = startPosition;
            GemCount = 0;
        }
        public void move(char direction)
        {

            // Implement movement logic here

            switch (direction)
            {
                case 'U':
                    Position.X--;
                    break;
                case 'D':
                    Position.X++;
                    break;
                case 'L':
                    Position.Y--;
                    break;
                case 'R':
                    Position.Y++;
                    break;
            }
           
        }
    }
    public class Cell
    {
        public string Occupant { get; set; }
    }


    public class Board
    {
        public Cell[,] Grid { get; set; }

        public Board()
        {
            //Initialize the board with players,gems, and obstacles
        }

        public void Display()
        {
            //print the current state of the board to the console

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Console.Write(Grid[i, j].Occupant + " ");
                }
                Console.WriteLine();
            }
        }

        public bool IsValidMove(Player player, char direction)
        {

            //Check if the move is valid


            int newX = player.Position.X;
            int newY = player.Position.Y;

            switch (direction)
            {
                case 'U':
                    newY--;
                    break;
                case 'D':
                    newY++;
                    break;
                case 'L':
                    newX--;
                    break;
                case 'R':
                    newX++;
                    break;
                default:
                    return false;
            }


            //Placeholder

            if (newX < 0 || newX >=
                Grid.GetLength(1) || newY < 0 || newY >= Grid.GetLength(0))
            {
                return false;

                //out of bonds
            }

            if (Grid[newY, newX].Occupant == "O")
            {
                return false;

                //obstacles in the way
            }
            return true;
        }

        public void CollectGem(Player player)
        {

            //Check if the player's contains a gem and update the player's GemCount

            if (Grid[player.Position.Y,
                player.Position.X].Occupant == "G")
            {
                player.GemCount++;
                Grid[player.Position.Y,
                    player.Position.X].Occupant = "_";
            }
        }

    }


    class Play
    {
        public Board Board { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public int TotalTurns { get; set; } = 0;
        public Player CurrentTurn { get; set; }

        public Play()
        {
            Board = new Board();
            Player1 = new Player("P1", new Position(0, 0));
            Player2 = new Player("P2", new Position(5, 5));
            CurrentTurn = Player1;
        }

        public void Begin()
        {

            //start the game, display the board, and alternate player turns

            while (!IsGameOver())
            {
                Console.Clear();
                Board.Display();
                // Console.WriteLine($"Current Turn:{CurrentTurn.Name}");
                Console.Write("Enter direction(U,D,L,R):");
                char direction = Console.ReadKey().KeyChar;
                var isValidMove = Board.IsValidMove(CurrentTurn, direction);
                if (isValidMove)
                {
                     CurrentTurn.move(direction);
                    Board.CollectGem(CurrentTurn);
                    SwitchTurn();
                    TotalTurns++;
                }
                else{
                        Console.WriteLine("\nInvalidmove.Try again");
                   }
                

                AnnouncementWinner();
            }
        }
        public void SwitchTurn()
        {

            //move between player1 and player2


            CurrentTurn = (CurrentTurn == Player1) ? Player2 : Player1;
        }


        public bool IsGameOver()
        {
            //check if the game has reached its end condition

            return TotalTurns >= 30;
        }
        public void AnnouncementWinner()
        {

            //announce the winner of the game

            Console.Clear();
            Board.Display();
            Console.WriteLine("GameOver!");

            if (Player1.GemCount > Player2.GemCount)
                Console.WriteLine($"Player" +
                    $"{Player1.Name}wins with{Player1.GemCount}gems!");
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }


    }


            
        
    



        



