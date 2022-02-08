// See https://aka.ms/new-console-template for more information
using RegexPattern;

//Console.WriteLine("Hello, World!");
Patterns patterns = new Patterns();
if (patterns.validateEmail("abc+100@gmail.com"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.validateFirstName("Pankaj"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.validateLastName("Kumar"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.validateMobile("91 7883773486"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.password1("helloworld123"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.password2("Helloworld123"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.password3("123@tEst"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
if (patterns.password4("123@tEst"))
{
    Console.WriteLine("Happy");
}
else
    Console.WriteLine("Sad");
Console.ReadKey();
