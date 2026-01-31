namespace TicTacToe;

public class GameHelper
{
    public void PrintBoard(string[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            if (i == 3 || i == 6)
            {
                Console.WriteLine();
            }
            Console.Write($"{board[i]} ");
        }
        Console.WriteLine();
    }

    public int[] CheckWinner(string[] board) //index 0 is winner or not (1 true, 0 false), index 1 is who won (0 = o's, 1 = x's) 
    {
        int[] winners = new int[2];
        winners[0] = 0;
        winners[1] = -1;
        
        if (board[0] == board[1] && board[0] == board[2]) //012
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[0] == board[3] && board[0] == board[6]) //036
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[0] == board[4] && board[0] == board[8]) //048
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[2] == board[5] && board[2] == board[8]) //258
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[2] == board[4] && board[2] == board[6]) //246
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[1] == board[4] && board[1] == board[7]) //147
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[3] == board[4] && board[3] == board[5]) //345
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }
        else if (board[6] == board[7] && board[6] == board[8]) //678
        {
            winners[0] = 1;
            if ((board[0]).ToLower()[0] == 'o')
            {
                winners[1] = 0;
            }
            else if ((board[0]).ToLower()[0] == 'x')
            {
                winners[1] = 1;
            }
        }

        return winners;
    }
}