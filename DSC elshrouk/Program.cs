#region Q1

double R = double.Parse(Console.ReadLine());
double area = 3.141592653 * R * R;
Console.WriteLine(area.ToString("F9"));

#endregion
#region Q2

Console.WriteLine("Enter two numbers:");

string input = Console.ReadLine();
string[] parts = input.Split(' ');

int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);

Console.WriteLine($"{x} + {y} = {x + y}");
Console.WriteLine($"{x} * {y} = {x * y}");
Console.WriteLine($"{x} - {y} = {x - y}");

#endregion
#region Q3


Console.WriteLine("Enter two numbers:");

string input = Console.ReadLine(); 
string[] parts = input.Split(' ');   

int A = int.Parse(parts[0]);
int B = int.Parse(parts[1]);

if (A % B == 0 || B % A == 0)
Console.WriteLine("Multiples");
else
Console.WriteLine("No Multiples");

#endregion
#region Q4
{
Console.WriteLine(" Enter three numbers A B C:");

string line = Console.ReadLine();
string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int A = int.Parse(parts[0]);
int B = int.Parse(parts[1]);
int C = int.Parse(parts[2]);

int min = Math.Min(A, Math.Min(B, C));
int max = Math.Max(A, Math.Max(B, C));

Console.WriteLine($"{min} {max}");
}
#endregion

#region Q5
{
    Console.WriteLine(" Enter one character:");

    char ch = char.Parse(Console.ReadLine());

    if (char.IsDigit(ch))
    {
        Console.WriteLine("IS DIGIT");
    }
    else
    {
        Console.WriteLine("ALPHA");
        if (char.IsUpper(ch))
            Console.WriteLine("IS CAPITAL");
        else
            Console.WriteLine("IS SMALL");
    }
}
#endregion


#region Q7
{
    Console.WriteLine(" Enter four numbers A B C D:");

    string line = Console.ReadLine();
    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    long A = long.Parse(parts[0]);
    long B = long.Parse(parts[1]);
    long C = long.Parse(parts[2]);
    long D = long.Parse(parts[3]);

    long product = A * B * C * D;
    int lastTwo = (int)(product % 100);

    Console.WriteLine(lastTwo.ToString("00"));
}
#endregion

#region Q8
{
    Console.WriteLine(" Enter four numbers A B C D:");

    string line = Console.ReadLine();
    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    double A = double.Parse(parts[0]);
    double B = double.Parse(parts[1]);
    double C = double.Parse(parts[2]);
    double D = double.Parse(parts[3]);

    double left = Math.Pow(A, B);
    double right = Math.Pow(C, D);

    if (left > right)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
#endregion

#region Q9
{
    Console.WriteLine(" Enter a number:");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(n);
}
#endregion

#region Q10
{
    Console.WriteLine(" Enter a string that contains digits and letters:");

    string s = Console.ReadLine();

    string digitsOnly = new string(s.Where(char.IsDigit).ToArray());

    if (int.TryParse(digitsOnly, out int value))
        Console.WriteLine(value);
    else
        Console.WriteLine("No digits to convert.");
}
#endregion

#region Q11
{
    Console.WriteLine(" Enter a string:");
    string s = Console.ReadLine();

    Console.WriteLine("Enter start index:");
    int start = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter length:");
    int length = int.Parse(Console.ReadLine());

    string sub = s.Substring(start, length);
    Console.WriteLine(sub);
}
#endregion

#region Q12
{
    Console.WriteLine("  Enter first string:");
    string s1 = Console.ReadLine();
    
    Console.WriteLine("Enter second string:");
    string s2 = Console.ReadLine();

    string combined = s1 + s2;
    Console.WriteLine(combined);
}
#endregion

#region Q13
{
    Console.WriteLine("Enter principal, rate, time:");

    string line = Console.ReadLine();
    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    double principal = double.Parse(parts[0]);
    double rate = double.Parse(parts[1]);
    double time = double.Parse(parts[2]);

    double interest = (principal * rate * time) / 100.0;

    Console.WriteLine(interest);
}
#endregion

#region Q14
{
    Console.WriteLine("Enter temperature:");

    int temp = int.Parse(Console.ReadLine());

    string result = temp < 10
        ? "Just Cold"
        : (temp > 30 ? "Just Hot" : "Just Good");

    Console.WriteLine(result);
}
#endregion

#region Q15
{
    Console.WriteLine(" Enter a number:");

    int n = int.Parse(Console.ReadLine());

    if (n % 3 == 0 && n % 4 == 0)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
#endregion
#region Q16
{
    Console.WriteLine("Enter a number:");

    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");
}
#endregion

#region Q17
{
    Console.WriteLine(" Enter a character:");

    char ch = char.ToLower(Console.ReadLine()[0]);

    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        Console.WriteLine("Vowel");
    else
        Console.WriteLine("Consonant");
}
#endregion