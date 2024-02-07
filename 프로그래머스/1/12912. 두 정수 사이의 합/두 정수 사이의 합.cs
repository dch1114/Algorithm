public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if(a>b) // a가 b보다 크면 swap하기
        {
            int c=a;
            a=b;
            b=c;
        }
        for(int i=a;i<=b;i++)
        {
            answer+=i;
        }
        return answer;
    }
}