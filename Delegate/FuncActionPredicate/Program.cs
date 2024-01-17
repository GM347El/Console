

using System.ComponentModel;

MathClass mathClass = new();

//********Func
//System.Console.WriteLine(mathClass.Sum(12, 5));
//Func<int, int, int> calc = mathClass.Sum;
//System.Console.WriteLine(calc(12, 19));
//Func<int, int, int> calc = (a, b) => a + b;
//System.Console.WriteLine(calc(25, 95));
// float d = 3.6f, e = 4.56f;
// int c = 5;
// Func<float, float, int, float> calc2 = (arg1, arg2, arg3) => (arg1 + arg2) * arg3;
// var result = calc2(d, e, c);
// System.Console.WriteLine(result);

// Func<decimal, decimal, decimal> calculateTotalSalary = (annualSalary, bonusPercentage) => annualSalary + annualSalary * bonusPercentage/100;
// var sum = calculateTotalSalary(145645464m, 20m);

// System.Console.WriteLine(sum);

//end func

//**********action

Action<int, string, string> employeesalary = (a, b, c) => System.Console.WriteLine($"{b} {c} salary:{a}"); ;
employeesalary(146464, "arsalan", "reza");

#region Classes method
public class MathClass
{
    public int Sum(int a, int b) => a + b;
}
delegate TResult Func2<out TResult>();
delegate TResult Func2<in T1, out TResult>(T1 arg);
delegate TResult Func2<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
delegate TResult Func2<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);


#endregion Classes method