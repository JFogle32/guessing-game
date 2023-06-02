﻿using System;
Main();

void Main()

        Console.WriteLine("Welcome to Guessing Game - Can you guess the secret number?");
        Console.WriteLine("Choose your difficulty level:");
        Console.WriteLine("Press 1 for Easy.");
        Console.WriteLine("Press 2 for Medium.");
        Console.WriteLine("Press 3 for Hard.");
        Console.WriteLine("Press 4 to cheat and have endless tries!");
        string difficulty = Console.ReadLine();
        int parsedChosenDifficulty = int.Parse(difficulty);
        int allowedTries = 0; 
        
        if (parsedChosenDifficulty == 1) { 
            allowedTries = 8;
        }
        if (parsedChosenDifficulty == 2) { 
            allowedTries = 6;
        }
        if (parsedChosenDifficulty == 3) { 
            allowedTries = 4;
        }
        else if (parsedChosenDifficulty == 4) {  
        };

        Console.WriteLine("Guess any number!"); 
        
       
        int numberOfTries = 0;
        int secretNumber = new Random().Next(0, 100); 

        while (true)
        {
            string userGuess = Console.ReadLine(); 
            
            
            numberOfTries++;
            int parsedUserGuess = int.Parse(userGuess);

            
            if (parsedUserGuess == secretNumber) {
                Console.WriteLine($@"You guessed the secret number - {secretNumber}!"); 
                break; 
            }
            if (numberOfTries == allowedTries) 
            {
                Console.WriteLine($@"The right number was {secretNumber}, sorry!");
                break;
            }
            if (parsedUserGuess == 0) 
            {
                Console.WriteLine("You haven't guessed a number yet!");
            }
            if (parsedChosenDifficulty == 4)
            {
               string highLow = parsedUserGuess > secretNumber ? "Your guess is higher than the secret number." : "Your guess is lower than the secret number.";
                Console.WriteLine($@"FAILURE. You guessed {parsedUserGuess}. {highLow} Keeping guessing!"); 
            }
            else
            {
                int attemptsLeft = (allowedTries - numberOfTries); 
                string highLow = parsedUserGuess > secretNumber ? "Your guess is higher than the secret number." : "Your guess is lower than the secret number.";
                Console.WriteLine($@"FAILURE. You guessed {parsedUserGuess}. {highLow} You have {attemptsLeft} attempt(s) left.");
            }
        }
