using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLongLength(0)];
        
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0];
            int end = commands[i, 1];
            int find = commands[i, 2];
            
            int[] temp = new int[end - start + 1];
            for(int a = 0; a < temp.Length; a++) { temp[a] = array[a + start - 1]; }
            Array.Sort(temp);
            answer[i] = temp[find - 1];
        }
        return answer;
    }
}