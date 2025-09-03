using System;

public class Solution {
    public string solution(string[] seoul) {
        int idx = Array.IndexOf(seoul, "Kim"); 
        return $"김서방은 {idx}에 있다";
    }
}