using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        var set = new HashSet<int>();
        
        for(int i = 0; i<numbers.Length; i++) {
            for(int j = i+1; j<numbers.Length; j++) {
                set.Add(numbers[i] + numbers[j]);
            }
        }
        return set.OrderBy(x => x).ToArray();
    }
}