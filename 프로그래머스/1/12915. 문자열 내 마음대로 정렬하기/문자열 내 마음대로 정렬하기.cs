using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {     
        return strings
            .OrderBy(x => x[n])   // n번째 문자
            .ThenBy(x => x)       // 사전순
            .ToArray();
    }
}