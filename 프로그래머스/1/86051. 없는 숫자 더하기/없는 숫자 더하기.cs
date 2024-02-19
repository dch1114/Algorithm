using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] c) {

        int a = 0;

        for(int i =0; i < 10; i++)
        {
            if(!c.Contains(i))
                a += i;
        }
        return a;
    }
}