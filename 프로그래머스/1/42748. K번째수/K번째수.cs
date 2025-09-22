using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int m = commands.GetLength(0);
        int[] answer = new int[m];
        
        for (int t = 0; t < m; t++) {
            int i = commands[t, 0];   
            int j = commands[t, 1];   
            int k = commands[t, 2]; 
            
            int len = j - i + 1;
            int[] slice = new int[len];

            Array.Copy(array, i - 1, slice, 0, len);
            Array.Sort(slice);              
            answer[t] = slice[k - 1]; 
        }
        return answer;
    }
}