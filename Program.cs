// Initialize new random function
Random random = new Random();
int generatedNumber = random.Next(1, 101);

// Global variables
int userGuess = 0;
int attempts = 0;

while (userGuess != generatedNumber)
{
    Console.Write("Guess the number from 1-100: ");
    userGuess = Convert.ToInt32(Console.ReadLine());

    if (userGuess > generatedNumber)
    {
        Console.WriteLine("Your guess is too high, try again.");
        attempts++;
        Console.WriteLine();

    }
    else if (userGuess < generatedNumber)
    {

        Console.WriteLine("Your guess is too low, try again.");
        attempts++;
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Congratulations! You have guessed {generatedNumber}.");
        Console.WriteLine($"Number of attempts: {attempts}");
    }
}

Console.WriteLine("Thank you for playing, goodbye!");