public class Solution {
    public bool IsPalindrome(string s) {
        var ca = s.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray();
        int l = 0, r = ca.Length - 1;
        while (l < r) {
            if (ca[l] != ca[r]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
