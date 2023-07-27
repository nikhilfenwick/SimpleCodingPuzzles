// // Console.WriteLine("Hello, World!");

// Step One - 

// 1. Use the random math function to create a random number
// 2. Make sure the random number is between 0 and 10.
// 3. Display the random number on the output

// Step Two - 

// 1. Update the code in Step One, and turn it into a function called 'ReturnRandomNumber'.

// Step Three

// 1. Use the ReturnRandomNumber function to generate 99 random numbers.
// 2. Store these 99 numbers in an array.
// 3. Display the array.

// Step Four - 

// 1. Improve the display to something like "random number 1 is: x", "random number 2 is : x" and so on.

// Step Five - 

// 1. Put the code in Step Three and Step Four into a single function called 'NinetyNineRandomNumbersGenerateandDisplay'


int ReturnRandomNumber (){
    // Console.WriteLine("This function creates a random number between 1 and 99");
    Random rnd = new Random();
    int resultOfRandomNumber = rnd.Next(0, 99);
    return resultOfRandomNumber;
}

int resultOfFunction = ReturnRandomNumber();
Console.WriteLine(resultOfFunction);

// Substep One - Create a for loop to loop 99 times. 
// Substep Two - Call the ReturnRandomNumber function inside the loop. 

int[] Storing99Values = new int[99];

for(int i = 0; i < 99; i++){
    int resultOfFunction1 = ReturnRandomNumber();
// 1. Use the ReturnRandomNumber function to generate 99 random numbers. - DONE. 

  Storing99Values[i] = resultOfFunction1; 

// 2. Store these 99 numbers in an array - DONE. 

}

// for(int i = 0; i < 99; i++){
    
//     i = 0;
//     i += 1;
//     Console.WriteLine("The Random Number " + i + " is " + Storing99Values[i]);

// }


for(int i = 0; i < 99; i++){
    int sp = i;
    sp ++;
    Console.WriteLine("The Random Number " + sp + " is " + Storing99Values[i]);

}