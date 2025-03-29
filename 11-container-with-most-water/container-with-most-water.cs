public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int maxarea = 0;
        int i = 0;
        int j = n-1;
        while(i<j){
            int curWidth = j-i;
            int curHeight = Math.Min(height[i],height[j]);
            maxarea = Math.Max(maxarea,curWidth*curHeight);
            if(height[i]<=height[j]){
                i++;
            }
            else{
                j--;
            }
        }
        return maxarea;
    }
}