public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();
        foreach (string s in strs){
            char[] ca = s.ToCharArray();
            Array.Sort(ca);  // void, don't assign
            string sorted = new string(ca);

    if (!dict.ContainsKey(sorted))
        dict[sorted] = new List<string>();

    dict[sorted].Add(s);
        }
        List<List<string>> result = dict.Values.ToList();
return result;
    }
}
