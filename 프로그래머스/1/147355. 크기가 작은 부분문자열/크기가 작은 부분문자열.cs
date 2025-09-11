using System;

public class Solution {
    public int solution(string t, string p) {
        
        int answer = 0;
        long e = long.Parse(p);
        int size = p.Length;
        
        for(int i = 0; i<=t.Length-size; i++) {
            long num = long.Parse(t.Substring(i,size));
            if(num <= e) {
                answer++;
            }
        }       
        return answer;
    }
}