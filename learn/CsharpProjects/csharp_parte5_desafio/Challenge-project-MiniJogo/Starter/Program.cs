/*

- The code declares the following variables:
    - Variables to determine the size of the Terminal window.
    - Variables to track the locations of the player and food.
    - Arrays `states` and `foods` to provide available player and food appearances
    - Variables to track the current player and food appearance

- The code provides the following methods:
    - A method to determine if the Terminal window was resized.
    - A method to display a random food appearance at a random location.
    - A method that changes the player appearance to match the food consumed.
    - A method that temporarily freezes the player movement.
    - A method that moves the player according to directional input.
    - A method that sets up the initial game state.

- The code doesn't call the methods correctly to make the game playable. The following features are missing:
    - Code to determine if the player has consumed the food displayed.
    - Code to determine if the food consumed should freeze player movement.
    - Code to determine if the food consumed should increase player movement.
    - Code to increase movement speed.
    - Code to redisplay the food after it's consumed by the player.
    - Code to terminate execution if an unsupported key is entered.
    - Code to terminate execution if the terminal was resized.

*/

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
ConsoleKey key;

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    key = Console.ReadKey(true).Key;

    bool otherKey = key == ConsoleKey.Escape || key == ConsoleKey.UpArrow 
                    || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow
                    || key == ConsoleKey.RightArrow ? false : true;
    
    if (otherKey)
    {
        Move(otherKey:otherKey, velocidade:VelocidadePlayer());    
    }
    else
    {
        Move(velocidade:VelocidadePlayer());
    }

    
    if(ConsumedFood())
    {
        ChangePlayer();
        ShowFood();
        if(DamagedPlayer())
        {
            FreezePlayer();
        }
    }
    if(TerminalResized())
    {
        FinishGame("Console was resized.");
    }
}

int VelocidadePlayer()
{
    int result = 1;

    if(player == states[(int)typeStates.Happy])
    {
        result = 3;
    }

    return result;
}


// Returns true if the Terminal was resized 


bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
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

bool DamagedPlayer()
{
    return player == states[(int)typeStates.Damaged] ? true : false;
}

bool ConsumedFood()
{
    bool result = false;

    int leftSidePlayer = playerX;
    int rigthSidePlayer = playerX + (player.Length -1);

    int leftSideFood = foodX;
    int rigthSideFood = foodX + (foods[food].Length -1);

    if( foodY == playerY && (rigthSidePlayer >= leftSideFood && leftSidePlayer <= rigthSideFood))
    {
        result = true;

        // Limpa a comida
        // Caso o lado esquerdo do personagem seja maior que o lado esquerdo da comida
        // apagamos a comida da esquerda para direita até o personagem
        if (leftSidePlayer > leftSideFood)
        {
            Console.SetCursorPosition(leftSideFood, playerY);
            for (int i = leftSideFood; i < leftSidePlayer; i++)
            {
                Console.Write(" ");
            }
        }
        // Caso o lado direito do personagem seja menor que o lado direito da comida
        // apagamos a comida da direita para esquerda até o personagem
        else
        {
            for (int i = rigthSidePlayer; i < rigthSideFood; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(rigthSidePlayer, playerY);
        }
    }

    return result;
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
    System.Threading.Thread.Sleep(3000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool otherKey = false, int velocidade = 1) 
{
    int lastX = playerX;
    int lastY = playerY;

    switch (key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= velocidade; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += velocidade; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
        default:
            shouldExit = otherKey;
            break;
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

void FinishGame(string message)
{
    Console.Clear();

        for(int i= 5; i> 0; i--)
        {
            Console.Write($"\r{message}. Program exiting in {i}");
            System.Threading.Thread.Sleep(1000);
            // Console.Write($"\r{new String(' ', Console.BufferWidth)}");
        }

        shouldExit = true;
}