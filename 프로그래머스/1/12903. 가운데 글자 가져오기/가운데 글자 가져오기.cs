public class Solution {
    public string solution(string s) {
        
        int n = s.Length;
        int start = (n-1)/2;//홀
        int len = (n%2 == 0) ? 2 : 1;//짝수면 2 홀수면 1
        
        return s.Substring(start, len);
    }
}