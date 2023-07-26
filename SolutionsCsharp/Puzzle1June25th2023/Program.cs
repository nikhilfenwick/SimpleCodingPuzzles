// // Console.WriteLine("Hello, World!");

// Step One - 

// 1. Use the random math function to create a random number
// 2. Make sure the random number is between 0 and 10.
// 3. Display the random number on the output

// Step Two

// 1. Update the code in Step One, and turn it into a function called 'ReturnRandomNumber'.

// Step Three

// 1. Use the ReturnRandomNumber function to generate 99 random numbers.
// 2. Store these 99 numbers in an array.
// 1. Display the array.

int ReturnRandomNumber (){
    Console.WriteLine("This function creates a random number between 1 and 10");
    Random rnd = new Random();
    int resultOfRandomNumber = rnd.Next(0, 10);
    return resultOfRandomNumber;
}

int resultOfFunction = ReturnRandomNumber();
Console.WriteLine(resultOfFunction);


