public class Solution {
    public int TotalNQueens(int n) {
        //Given an NxN chessboard, how many combinations of N queens can there be where they cannot attack each other?
        //Initialize board as 2D array with no placement
        //Place a Queen at [0][0], remove [0] column, [0] row, and [n+0] diagonal
        int solution = 0;
        recursiveQueens(ref solution, new int[n], 0);
        return solution;
    }
    private void recursiveQueens(ref int solutions, int[] result, int row){
        //If at the bottom left of the board, this is the only solution in the row.
        if (row == result.Length){
            solutions++;
            return;
        }
        for(int i = 0; i < result.Length; i++){
            //assume square is available
            bool available = true;

            //check for conflicts and turn square unavailable
            for (int j = 0; j < row; j++){
                if (result[j] == i || result[j] - row + j == i || result[j] - j + row == i) available = false; 
            }
            //
            if(available){
                result[row] = i; 
                recursiveQueens(ref solutions, result, row+1);
            }
        }
        return;
    }
}
