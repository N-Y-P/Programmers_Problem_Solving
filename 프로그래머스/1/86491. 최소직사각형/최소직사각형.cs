using System;

public class Solution {
    public int solution(int[,] sizes) {
        int s = sizes.GetLength(0);
        int big = 0;
        int small = 0;
        
        for(int i = 0; i<s; i++) {
            int x = sizes[i, 0];
            int y = sizes[i, 1];
            
            if(x<y) (x,y) = (y,x);
            
            if(x>big) big = x;
            if(y>small) small = y;
        }
        
        return big*small;
    }
}