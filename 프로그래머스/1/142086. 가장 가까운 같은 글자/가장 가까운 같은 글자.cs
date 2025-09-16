using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int[] arr = new int[26];//제한사항 : s는 영어 소문자로만 이루어져있다
        for(int i = 0; i<26; i++) {
            arr[i] = -1;//일단 -1로 채우기
        }
        for(int i = 0; i<s.Length; i++) {
            int idx = s[i] - 'a';
            int prev = arr[idx];
            answer[i] = (prev == -1) ? -1 : i - prev;
            arr[idx] = i; 
        }
        return answer;
    }
}