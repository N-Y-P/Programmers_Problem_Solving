using System;

public class Solution {
    public long solution(long n) {
        
        var sqrt = Math.Sqrt(n);
        if(sqrt%1 != 0) {//만약 sqrt가 정수가 아니라면
            return -1;
        }
        return (long)Math.Pow(sqrt + 1, 2);
    }
}