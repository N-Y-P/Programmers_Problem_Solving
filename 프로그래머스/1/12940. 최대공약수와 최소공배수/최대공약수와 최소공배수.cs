public class Solution {
    
int gcd(int a, int b) {
    int c = 0;
    while(b != 0) {
        c = a%b;
        a = b;
        b = c;
    }
    return a;
}
    
int lcm(int a, int b) {
    return (a*b)/gcd(a,b);
}
    
    public int[] solution(int n, int m) {
        int a = gcd(n,m);
        int b = lcm(n,m);
        return new int [] {a, b} ;
    }
}
