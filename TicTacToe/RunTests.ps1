# Automated Test Script for Tic-Tac-Toe
# This script simulates a game where X wins with the top row

Write-Host "Running automated Tic-Tac-Toe test..." -ForegroundColor Cyan
Write-Host ""

# Test 1: X wins with top row (positions 1, 2, 3)
Write-Host "Test 1: X wins with top row" -ForegroundColor Yellow
$input1 = @"
1
4
2
5
3
"@

$input1 | dotnet run

Write-Host "`n=================================`n" -ForegroundColor Green

# Test 2: Simulate another game - O wins with left column (positions 1, 4, 7)
Write-Host "Test 2: O wins with left column" -ForegroundColor Yellow
$input2 = @"
2
1
3
4
5
7
"@

$input2 | dotnet run

Write-Host "`n=================================`n" -ForegroundColor Green

Write-Host "Automated tests completed!" -ForegroundColor Cyan
