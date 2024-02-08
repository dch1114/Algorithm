public class Solution {
    public int solution(int num) {
        int answer = 0;
        long numLong = num;
        for(int i = 0; i <= 500; i++)
        {
            if (numLong == 1)
            {
                return i;
            }
            if (numLong % 2 == 0)
            {
                numLong = numLong / 2;
            } else
            {
                numLong = numLong * 3 + 1;
            }

        }
        return -1;
    }
}