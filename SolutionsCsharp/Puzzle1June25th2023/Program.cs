// // Console.WriteLine("Hello, World!");

// Step One - 

// 1. Use the random math function to create a random number
// 2. Make sure the random number is between 0 and 10.
// 3. Display the random number on the output


int randomNumber (){
    Console.WriteLine("This function creates a random number between 1 and 10");
    Random rnd = new Random();
    int resultOfRandomNumber = rnd.Next(0, 10);
    return resultOfRandomNumber;
}

int resultOfFunction = randomNumber();
Console.WriteLine(resultOfFunction);

