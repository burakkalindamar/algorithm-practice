public class Solution {
    public bool IsPalindrome(int x) {
     
        string sayi = x.ToString();
        int left = 0;
        int right = sayi.Length - 1;  

        while (left < right) {
            if (sayi[left] != sayi[right])
                return false;                          
            left++;
            right--;
        }       
        return true;
    }  
}
