using System.Linq;

public class Solution {
    public string solution(string phone_number) {
        string p = phone_number;
        string answer = new string(
            p.Select((ch, idx) => idx < p.Length - 4 ? '*' : ch)
             .ToArray()
        );
        return answer;
    }
}