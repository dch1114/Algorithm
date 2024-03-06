using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min;
        int max;
        
        min = gcd(n, m);
        max = (n * m) / min;
        
        answer[0] = min;
        answer[1] = max;
        return answer;
    }
    public int gcd(int n, int m)
    {
        if(m == 0) return n;
        else return gcd(m, n%m);
    }
}