using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] {};
        List<int> temp = new List<int>();
        for(int i = 0;i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                temp.Add(arr[i]);
            }
        }
        if(temp.Count == 0)
        {
            temp.Add(-1);
        }
        temp.Sort();
        answer = temp.ToArray();
        return answer;
    }
}