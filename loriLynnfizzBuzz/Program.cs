Console.WriteLine("Welcome to the FizzBuzz Looper!");       //intro
Console.WriteLine("Enter your desired loop limit pl0x..."); //user prompt

int tooBuzzed = int.Parse(Console.ReadLine());  //Collects user input and converts it to a 32bit integer.

for(int i = 1; i <= tooBuzzed; i++)     //loops beginning at 1 until the number entered by the user
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");  //every instance of a number divisible by both 3 and 5 is noted as fizzbuzz.
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("buzz");      //every instance of a number divisible by 3 is noted as "buzz".
    }
    else if(i % 5 ==0)
    {
        Console.WriteLine("Fizz");      //every instance of a number divisible by 5 is noted as "fizz".
    }
    else    
    {
        Console.WriteLine(i);           //if "i" is neither divisble by 3 or by 5, it will print the current number and return to the beginning of the loop (if applicable)
    }
}