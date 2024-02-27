using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] aa = s.ToCharArray();
        Array.Sort(aa);
        Array.Reverse(aa);
        answer = new string(aa);
        return answer;
    }
}