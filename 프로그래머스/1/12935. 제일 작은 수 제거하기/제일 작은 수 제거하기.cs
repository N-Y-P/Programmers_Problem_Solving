using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int min = arr.Min();
        
        if(arr.Length == 1) {//길이 1이면 -1반환
            return new int[] {-1};
        }
        return arr.Where(x => x != min).ToArray();
    }
}