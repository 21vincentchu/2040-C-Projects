namespace VincentChuAssignmentM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic Tac Toe. Below is the layout on where to place x's and o's");
            PrintLayoutBoard();
            TicTacToe game = new TicTacToe();
        
            SquareState currentPlayer = SquareState.X; // Start with 'X'
            bool gameInProgress = true;
            while (gameInProgress)
            {
                //Check everytime if there is a winner, then print
                SquareState winner = game.CheckWinner();
                if (winner != SquareState.Empty)
                {
                    gameInProgress = false;
                    if (winner == SquareState.X){
                        Console.WriteLine("Player X wins!");
                    }else if (winner == SquareState.O){
                        Console.WriteLine("Player O wins!");
                    }else{ // Draw
                        Console.WriteLine("It's a draw!");
                    }
                    break; // Exit the loop
                }

                Console.WriteLine($"Player {currentPlayer}, enter a number from 1 to 9 to fill the board:");
                try
                {
                    // Read user input for the move
                    int move = int.Parse(Console.ReadLine()!);

                    // Make the move and print the updated board
                    game.MakeMove(move, currentPlayer);
                    game.PrintBoard();

                    // Switch players
                    if (currentPlayer == SquareState.X){
                        currentPlayer = SquareState.O;
                    }else{
                        currentPlayer = SquareState.X;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                }
            }
            Console.WriteLine();
        }
        public static void PrintLayoutBoard()
        {
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9 ");
        }
    }
}