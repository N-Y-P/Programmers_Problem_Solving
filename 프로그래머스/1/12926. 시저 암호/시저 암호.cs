public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        foreach(var c in s) {
            if(c == ' ') {
                answer += ' ';
                continue;
            }
            if('A' <= c && c <= 'Z') {
                answer += (char)('A' + (c - 'A' + n) % 26);
            }
            else if('a' <= c && c <= 'z') {
                answer += (char)('a' + (c - 'a' + n) % 26);
            }
        }
        return answer;
    }
}