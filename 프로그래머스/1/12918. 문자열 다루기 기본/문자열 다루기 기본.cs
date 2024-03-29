public class Solution {
    public bool solution(string s) {
        if (s.Length == 4 || s.Length == 6) {
            foreach (char c in s) {
                if (!char.IsDigit(c)) {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}