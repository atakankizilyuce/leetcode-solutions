namespace IsValidSudoku
{
    internal class Program
    {
        public static bool IsValidSudoku(char[][] board)
        {
            var rows = new Dictionary<int, HashSet<char>>();
            var columns = new Dictionary<int, HashSet<char>>();
            var squares = new Dictionary<string, HashSet<char>>();

            for (var r = 0; r < 9; r++)
            {
                for (var c = 0; c < 9; c++)
                {
                    if (board[r][c] == '.')
                    {
                        continue;
                    }

                    var key = (r / 3) + "," + (c / 3);

                    if ((rows.ContainsKey(r) && rows[r].Contains(board[r][c])) ||
                        (columns.ContainsKey(c) && columns[c].Contains(board[r][c])) ||
                        (squares.ContainsKey(key) && squares[key].Contains(board[r][c])))
                    {
                        return false;
                    }

                    if (!rows.ContainsKey(r))
                    {
                        rows[r] = new HashSet<char>();
                    }
                    if (!columns.ContainsKey(c))
                    {
                        columns[c] = new HashSet<char>();
                    }
                    if (!squares.ContainsKey(key))
                    {
                        squares[key] = new HashSet<char>();
                    }

                    rows[r].Add(board[r][c]);
                    columns[c].Add(board[r][c]);
                    squares[key].Add(board[r][c]);
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

        }
    }
}
