﻿// See https://aka.ms/new-console-template for more information



namespace ASSIGNMENT_2
{
    public class class1
    {
        public static void Main(string[] args)
        {


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

    public class Player
    {
        public String Name { get; }
        public Game Class1 { get; set; }
        public int GemCount { get; set; }

        public Player(string name, Game Game)
        {
            Name = name;
            Game = Class1;
            GemCount = 0;
        }
        public void Move(char direction)
        {
            // Implement movement logic here
        }
    }
    public class Cell
    {
        public string Occupant { get; set; }
    }

    public class Board
    {
        public Cell[,] Grid { get; }

        public Board()
        {
            //Initialize the board with players,gems, and obstacles
        }

        public void Display()
        {
            //print the current state of the board to the console
        }

        public bool IsValidMove(Player Player, char direction)
        {

            //Check if the move is valid
            return false;

            //Placeholder
        }

        public void CollectGem(Player Player)
        {

            //Check if the player's contains a gem and update the player's GemCount
        }

    }

    public class Play
    {
        public Board Board { get; }
        public Player Player1 { get; }
        public Player Player2 { get; }
        public Player Currentturn { get; set; }

        public int TotalTurns { get; set; }

        public Play()
        {
            //Initializing the game with a board and two players
        }

        public void Begin()
        {

            //start the game, display the board, and alternate player turns
        }

        public void ShiftTurns()
        {
            //move between player1 and player2
        }

        public bool IsGameOver()
        {
            //check if the game has reached its end condition

            return false;

            //placeholder
        }

        public void ReportWinner()
        {
            //announce the winner of the game
        }
    }
}


        


