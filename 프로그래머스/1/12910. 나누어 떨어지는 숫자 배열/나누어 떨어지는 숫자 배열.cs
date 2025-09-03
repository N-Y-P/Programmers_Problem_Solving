using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        var answer = arr.Where(x => x % divisor == 0)
                     .OrderBy(x => x)
                     .ToArray();
        return answer.Length == 0 ? new int[] { -1 } : answer;
    }
}