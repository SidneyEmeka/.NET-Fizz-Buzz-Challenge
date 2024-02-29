// Create the for loop that counts from 1 to 100
for (int i = 1; i <= 100; i++)
{
// Using If-else if-else statements create the conditions
    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i} - Fizz Buzz");
    else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");
    else if(i % 3 == 0) Console.WriteLine($"{i} - Fizz");
   else Console.WriteLine(i); //dispaly i
}