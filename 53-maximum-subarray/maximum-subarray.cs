public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length==0)return 0;
        return FindLargestSum(0,nums.Length-1,nums);
    }
    public int FindLargestSum(int i,int j,int[] nums){
        if(i==j) return nums[i];
        int mid = (i+j)/2;
        int right = FindLargestSum(i,mid,nums);
        int left = FindLargestSum(mid+1,j,nums);
        int crossSum = FindCrossSum(i, j, mid, nums);
        return Math.Max(Math.Max(left, right), crossSum);
    }
    public int FindCrossSum(int i, int j, int mid, int[] nums) {
        // Left sum calculation (from mid to i)
        int leftSum = int.MinValue;
        int sum = 0;
        for (int k = mid; k >= i; k--) {
            sum += nums[k];
            leftSum = Math.Max(leftSum, sum);
        }

        // Right sum calculation (from mid+1 to j)
        int rightSum = int.MinValue;
        sum = 0;
        for (int k = mid + 1; k <= j; k++) {
            sum += nums[k];
            rightSum = Math.Max(rightSum, sum);
        }

        // Return the sum of the best left and right part
        return leftSum + rightSum;
    }
}