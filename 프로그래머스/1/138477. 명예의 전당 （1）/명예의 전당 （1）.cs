using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        
        var krr = new List<int>();
        var answer = new int[score.Length];
        
        for(int i = 0; i<score.Length; i++) {
            krr.Add(score[i]);
            krr.Sort();//정렬
            if(krr.Count > k) {//수가 넘어갈 때
                krr.RemoveAt(0);//전체에서 가장 작은 값 제거
            }
            answer[i] = krr[0];
        }

        return answer;
    }
}