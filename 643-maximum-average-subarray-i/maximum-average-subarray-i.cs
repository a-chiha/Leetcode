public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int maxAvg = 0;
        int i = 0;
        int res = 0;
        for(int j = 0; j<k;j++){
            maxAvg+=nums[j];
        }
              res=maxAvg;
        for(i=k;i<nums.Length;i++){
           
                maxAvg+=nums[i];
                maxAvg-=nums[i-k];
             res = Math.Max(res,maxAvg);
            }
return (double)res/k;
        }
        
    }
