public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
    int m = matrix.Length;
    int n = matrix[0].Length;
    List<int> res = new List<int>();
    int left = 0;
    int right = n-1;
    int top = 0;
    int bottom = m-1;
        while(top <= bottom && left <= right){
            for(int i = left; i<=right;i++){
                res.Add(matrix[top][i]);
            }
            top++;
            for(int i = top; i<=bottom;i++){
                res.Add(matrix[i][right]);
            }
            right--;
            if(top<=bottom){
            for(int i = right; i>=left;i--){
                res.Add(matrix[bottom][i]);
            }
            bottom--;
            }
            if(left<=right){
            for(int i = bottom; i>=top;i--){
                res.Add(matrix[i][left]);
            }
            left++;
            }
        }
            return res;
       } 
 
    }
