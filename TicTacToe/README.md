# Tic-Tac-Toe Game - Mission 4

A console-based Tic-Tac-Toe game implemented in C# using .NET 10.0.

## Project Structure

- **Program.cs** - Driver class that manages game flow and user interaction
- **GameHelper.cs** - Supporting class with board printing and winner checking methods

## How to Run

1. Navigate to the TicTacToe directory:
   ```
   cd TicTacToe
   ```

2. Build the project:
   ```
   dotnet build
   ```

3. Run the game:
   ```
   dotnet run
   ```

## How to Play

- Players take turns entering positions 1-9 corresponding to the board layout
- Player 1 uses X, Player 2 uses O
- The first player to get three in a row (horizontal, vertical, or diagonal) wins
- If all positions are filled with no winner, the game ends in a tie

## Testing

Run the automated test script to verify the game works correctly:
```
.\RunTests.ps1
```

This will simulate two games:
1. X wins with the top row
2. O wins with the left column

## Requirements

- .NET 10.0 SDK

## Team Development Notes

This project follows the paired programming approach:
- One half of the team developed the Driver class (Program.cs)
- The other half developed the Supporting class (GameHelper.cs)
- Each half worked independently until integration
