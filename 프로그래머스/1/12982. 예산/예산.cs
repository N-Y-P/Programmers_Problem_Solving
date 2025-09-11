using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int sum = 0;
        
        Array.Sort(d);
        foreach(var i in d) {
            if(sum + i > budget) break;
            sum += i;
            answer++;
        }
        return answer;
    }
}