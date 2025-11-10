using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i<=number; i++) {
            int a = 0;
            for(int j = 1; j*j<=i; j++) {
                if(i % j == 0) {
                    a += 2;
                    if(j*j == i) {
                        a--;
                    }
                }
            }
            answer += (a > limit) ? power : a;
        }
        return answer;
    }
}