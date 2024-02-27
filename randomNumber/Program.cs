// See https://aka.ms/new-console-template for more information
Random random = new Random();
int previousNumber = 1000;
int randomNumber = 0;

 

while (previousNumber >  0)
{
    // Generate random number less than the previous number
    randomNumber = random.Next(0, previousNumber);

    Console.WriteLine(randomNumber);
    Console.WriteLine("----");

    // Update previous number for the next iteration
    previousNumber = randomNumber;
}
