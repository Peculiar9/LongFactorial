public class FactorialClass
{
    public static int Factorial(int n){
        if (n >= 1) return n * Factorial(n - 1);
        else return 1;
    }
}