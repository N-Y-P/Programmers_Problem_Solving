using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        answer = new string(s.OrderByDescending(x=>x)
                           .ToArray());
        return answer;
    }
}