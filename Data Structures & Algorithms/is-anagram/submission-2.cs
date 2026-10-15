public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        var set = new Dictionary<char, int>();
        var arrS = s.ToCharArray();
        var arrT = t.ToCharArray();
        for (int i = 0; i < arrS.Length; i++) {
            if (!set.ContainsKey(arrS[i])) {
                set.Add(arrS[i], 1);
            } else {
                set[arrS[i]]++;
            }
        }
        for (int i = 0; i < arrT.Length; i++) {
            if (!set.ContainsKey(arrT[i]) || set[arrT[i]] == 0) {
                return false;
            } 
                set[arrT[i]]--;
            }
        return true;
    }
}
