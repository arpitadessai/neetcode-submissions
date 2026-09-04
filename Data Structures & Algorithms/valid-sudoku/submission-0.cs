public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //check rows
        for (int r = 0; r < board.Length; r++)
        {
            HashSet<char> thisRow = new HashSet<char>();
            foreach (var item in board[r])
            {
                if (item == '.')
                {
                    continue;
                }

                if (!thisRow.Add(item))
                {
                    return false;
                }
            }
        }

        // check columns
        for (int c = 0; c < board.Length; c++)
        {
            HashSet<char> thisColumn = new HashSet<char>();
            for (int i = 0; i < board[c].Length; i++)
            {
                if (board[i][c] == '.')
                {
                    continue;
                }

                if (!thisColumn.Add(board[i][c]))
                {
                    return false;
                }
            }
        }

        // check sub-boards
        int subBoardsPerRow = 3;
        int subBoardsPerColumn = 3;
        for (int subBoardRow = 0; subBoardRow < subBoardsPerRow; subBoardRow++)
        {
            for (int subBoardColumn = 0; subBoardColumn < subBoardsPerColumn; subBoardColumn++)
            {
                HashSet<char> currentSubBoard = new HashSet<char>();
                int startRow = subBoardRow*3;
                int startColumn = subBoardColumn*3;

                for (int r = startRow; r < startRow + 3; r++)
                {
                    for (int c = startColumn; c < startColumn + 3; c++)
                    {
                        if (board[r][c] == '.')
                        {
                            continue;
                        }

                        if (!currentSubBoard.Add(board[r][c]))
                        {
                            return false;
                        }
                    }
                }
            }
        }

        return true;
    }
}
