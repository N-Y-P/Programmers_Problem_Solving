using System.Linq;

public class Solution {
    public bool solution(int x) {
        int sum = x.ToString().Sum(c => c - '0');
        if(x%sum != 0 ){//나누어 떨어지지 않으면
            return false;
        }
        return true;
    }
}