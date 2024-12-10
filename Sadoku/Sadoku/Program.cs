// See https://aka.ms/new-console-template for more information
using Sadoku.Classes;

Board board = new Board();
board.GenerateBoard();
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(board.GetTiles()[i][j].GetAssignedBlock().ToString() + " ");
    }

    Console.Write("\n");
}