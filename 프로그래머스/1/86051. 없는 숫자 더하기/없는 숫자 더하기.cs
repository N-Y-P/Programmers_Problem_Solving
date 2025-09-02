using System;

public class Solution {
    public int solution(int[] numbers) {
        int sum = 45;
        for(int i = 0; i<numbers.Length; i++) {
            sum -= numbers[i];
        }
        return sum;
    }
}