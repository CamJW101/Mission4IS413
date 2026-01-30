namespace TicTacToe
{
    /// <summary>
    /// Driver class for the Tic-Tac-Toe game
    /// This class manages the game flow and user interaction
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("=================================");
            Console.WriteLine("  Welcome to Tic-Tac-Toe!");
            Console.WriteLine("=================================");
            Console.WriteLine("\nPlayer 1 is X, Player 2 is O");
            Console.WriteLine("Enter positions 1-9 corresponding to:");
            Console.WriteLine("\n 1 | 2 | 3 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine();

            // Create a game board array to store the players' choices
            // Initialize with position numbers for reference
            string[] board = new string[9];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = " ";
            }

            // Create an instance of the supporting class
            GameHelper helper = new GameHelper();

            // Track current player (1 for Player 1/X, 2 for Player 2/O)
            int currentPlayer = 1;
            
            // Track number of moves made
            int moveCount = 0;
            
            // Game loop - continues until there's a winner or the board is full
            bool gameOver = false;
            
            while (!gameOver && moveCount < 9)
            {
                // Print the current board
                helper.PrintBoard(board);
                
                // Ask the current player for their choice
                string playerSymbol = currentPlayer == 1 ? "X" : "O";
                Console.Write($"Player {currentPlayer} ({playerSymbol}), enter your move (1-9): ");
                
                string? input = Console.ReadLine();
                
                // Validate input
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int position) || position < 1 || position > 9)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
                    continue;
                }
                
                // Convert position to array index (1-9 becomes 0-8)
                int arrayIndex = position - 1;
                
                // Check if the position is already taken
                if (board[arrayIndex] != " ")
                {
                    Console.WriteLine("That position is already taken! Choose another spot.");
                    continue;
                }
                
                // Update the game board array with the player's choice
                board[arrayIndex] = playerSymbol;
                moveCount++;
                
                // Check for a winner by calling the method in the supporting class
                int[] winnerResult = helper.CheckWinner(board);
                
                if (winnerResult[0] == 1)
                {
                    // There is a winner!
                    gameOver = true;
                    helper.PrintBoard(board);
                    
                    // Determine which player won
                    string winningPlayer = winnerResult[1] == 1 ? "Player 1 (X)" : "Player 2 (O)";
                    Console.WriteLine("=================================");
                    Console.WriteLine($"  {winningPlayer} WINS!");
                    Console.WriteLine("=================================");
                }
                else
                {
                    // Switch to the other player
                    currentPlayer = currentPlayer == 1 ? 2 : 1;
                }
            }
            
            // Check if the game ended in a tie
            if (!gameOver && moveCount == 9)
            {
                helper.PrintBoard(board);
                Console.WriteLine("=================================");
                Console.WriteLine("  It's a tie! No winner.");
                Console.WriteLine("=================================");
            }
            
            Console.WriteLine("\nThanks for playing!");
        }
    }
}
