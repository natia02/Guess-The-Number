# Guess The Number

## Overview

`Guess The Number` is a simple console-based number guessing game implemented in C#. The game works as follows:

1. The player thinks of a number within a specified range.
2. The player provides the minimum and maximum values of this range to the program.
3. The program will then attempt to guess the number by asking the player if the guessed number is correct, higher, or lower.
4. The player responds with `>`, `<`, or `Yes`.
5. The game continues until the program correctly guesses the number.

## Rules

1. Think of a number.
2. Enter the minimum and maximum range for the program to guess within.
3. The program will guess a number, and you will respond with `>`, `<`, or `Yes`.
    - `>` means your number is higher.
    - `<` means your number is lower.
    - `Yes` means the program guessed correctly.
4. The game ends when the program guesses your number correctly.

## Code Explanation

The program consists of three main parts:
1. Displaying the rules of the game.
2. Reading and validating the input range from the user.
3. Performing the guessing process using a binary search approach.

### Functions

- `PrintGameRules()`: Prints the rules of the game.
- `GetValidInteger(string prompt)`: Prompts the user for an integer input and validates it.
- `PerformGuessing(int minRange, int maxRange)`: Performs the guessing process 
by adjusting the range based on user feedback.