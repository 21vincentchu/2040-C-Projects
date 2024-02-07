
namespace VincentChuAssignmentM4
{
    public class TicTacToe
    {
        SquareState[,] board;
        public TicTacToe() //Constructor
        {
            board = new SquareState[3, 3]; //2D array
            // Initialize the board with all squares set to Empty
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = SquareState.Empty;
                }
            }
        }
        public void MakeMove(int move, SquareState player) //Does calculation of 1-9 and "translates" to a valid 2d array place
        {
            int row = (move - 1) / 3; // Calculate the row index from the move
            int col = (move - 1) % 3; // Calculate the column index from the move

            if (move >= 1 && move <= 9 && board[row, col] == SquareState.Empty)
            {
                board[row, col] = player;
            }
            else
            {
                throw new ArgumentException("Invalid move.");
            }
        }

        public SquareState CheckWinner()
        {
            for (int i = 0; i < 3; i++) // Check rows
            {
                SquareState lineResult = CheckLine(board[i, 0], board[i, 1], board[i, 2]);
                if (lineResult != SquareState.Empty)
                {
                    return lineResult;
                }
            }

            for (int i = 0; i < 3; i++) // Check columns
            {
                SquareState lineResult = CheckLine(board[0, i], board[1, i], board[2, i]);
                if (lineResult != SquareState.Empty)
                {
                    return lineResult;
                }
            }

            SquareState diagonalResult = CheckLine(board[0, 0], board[1, 1], board[2, 2]);
            if (diagonalResult != SquareState.Empty) // Check diagonals
            {
                return diagonalResult;
            }

            diagonalResult = CheckLine(board[0, 2], board[1, 1], board[2, 0]);
            if (diagonalResult != SquareState.Empty)
            {
                return diagonalResult;
            }

            // Check for a tie (draw)
            if (CountFilledSquares() == 9)
            {
                return SquareState.Empty; // Draw
            }

            return SquareState.Empty; // If no winner found
        }

        private SquareState CheckLine(SquareState a, SquareState b, SquareState c)
        {
            if (a != SquareState.Empty && a == b && b == c)
            {
                return a;
            }
            return SquareState.Empty;
        }

        private int CountFilledSquares()
        {
            int filledSquaresCount = 0;
            foreach (SquareState square in board)
            {
                if (square != SquareState.Empty)
                {
                    filledSquaresCount++;
                }
            }
            return filledSquaresCount;
        }
        public void PrintBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] != SquareState.Empty)// Print the content of the square if it's not empty
                    {
                        Console.Write(board[row, column]);
                    }
                    else // Print a space if the square is empty
                    {
                        Console.Write(" ");
                    }

                    if (column < 2) // If we're not on the last column, print a separator
                    {
                        Console.Write(" | ");
                    }
                }

                if (row < 2) // If we're not on the last row, print a horizontal line
                {
                    Console.WriteLine("\n---------");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
    public enum SquareState
    {
        Empty,
        X,
        O,
        Draw
    }
}