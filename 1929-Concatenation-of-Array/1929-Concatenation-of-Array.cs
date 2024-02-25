public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int[] sayilar = new int[nums.Length*2];

        for(var i = 0;i<nums.Length;i++){
            sayilar[i]=nums[i];
            sayilar[i+nums.Length]=nums[i];
        }
        
        return sayilar;
    }
} 