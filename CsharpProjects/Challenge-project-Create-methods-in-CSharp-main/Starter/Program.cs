using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// If player can speed
int speed = 1;

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    Move(canSpeed: speed);
    if(FoodConsumed())
    {
        ChangePlayer();
        playerState();
        ShowFood();
    }
    if(!shouldExit) shouldExit = TerminalResized();
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    bool isResized = (height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5);
    if(isResized) Console.WriteLine("Console was resized. Program exiting.");
    return isResized;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool CloseOnNondirection = false, int canSpeed = 1) 
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY -= canSpeed;
            break;
		case ConsoleKey.DownArrow: 
            playerY += canSpeed;
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= canSpeed;
            break;
		case ConsoleKey.RightArrow: 
            playerX += canSpeed; 
            break;
		case ConsoleKey.Escape:
            shouldExit = true;
            break;
        default:
            shouldExit = CloseOnNondirection;
            return;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

// Returns true if the food was consumed by the player
bool FoodConsumed() {
    return playerX == foodX && playerY == foodY;
}

void playerState()
{
    switch (player)
    {
        case "('-')": // Temporarily stop.
            speed = 1;
            break;
        case "(^-^)":
            speed = 3;
            break;
        case "(X_X)": // Temporarily stop.
            FreezePlayer();
            speed = 1;
            break;
        default:
            speed = 1;
            break;
    }
}