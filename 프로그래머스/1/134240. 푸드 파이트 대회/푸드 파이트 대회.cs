using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for(int i = 1; i<food.Length; i++) {
            int n = food[i]/2;
            for(int j = 1; j<n+1; j++) {
                answer += i;
            }
        }
        string reverse = new string(answer.Reverse().ToArray());
        
        return answer + "0" + reverse;
    }
}