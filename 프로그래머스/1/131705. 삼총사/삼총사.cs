using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int size = number.Length;
        for(int i = 0; i<size-2; i++) {
            for(int j = i+1; j<size-1; j++) {
                for(int h = j+1; h<size; h++) {
                    if(number[i] + number[j] + number[h] == 0) {
                        answer++;
                    }
                    
                }
            }
        }
        return answer;
    }
}