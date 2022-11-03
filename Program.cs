#region var
const int PIRATE = 1;
const int STONE_CHEWER = 2;
const int GHOST_WARRIOR = 3;
const int OUTWORLDER = 4;
const int DARK_GOBLIN = 5;


int health_Player1 = 0;
int health_Player2 = 0;
int speed_Player1 = 0;
int speed_Player2 = 0;
int attack_Player1 = 0;
int attack_Player2 = 0;
int damage1 = 0;
int damage2 = 0;
int amor_Player1 = 0;
int amor_Player2 = 0;


int Player1;
int Player2;

const int DRAW = 0;
int winner = DRAW;
#endregion

Console.Write("Player1, please choose PIRATE (1), STONE_CHEWER (2), GHOST_WARRIOR (3), Outworlder(4), or Dark Goblin(5)  ");
Player1 = int.Parse(Console.ReadLine()!);

Console.Write("Player2, please choose PIRATE (1), STONE_CHEWER (2), GHOST_WARRIOR (3),  Outworlder(4), or Dark Goblin(5)  ");
Player2 = int.Parse(Console.ReadLine()!);

switch (Player1)
{
    case 1 or PIRATE:
        {
            health_Player1 = 20;
            speed_Player1 = 3;
            attack_Player1 = 3;
            amor_Player1 = 3;
        }
        break;


    case 2 or STONE_CHEWER:
        {
            health_Player1 = 50;
            speed_Player1 = 1;
            attack_Player1 = 8;
            amor_Player1 = 10;
        }
        break;

    case 3 or GHOST_WARRIOR:
        {
            health_Player1 = 20;
            speed_Player1 = 5;
            attack_Player1 = 2;
            amor_Player1 = 2;
        }
        break;

    case 4 or OUTWORLDER:
        {
            health_Player1 = 15;
            speed_Player1 = 10;
            attack_Player1 = 1;
            amor_Player1 = 2;
        }
        break;

    case 5 or DARK_GOBLIN:
        {
            health_Player1 = 10;
            speed_Player1 = 3;
            attack_Player1 = 1;
            amor_Player1 = 8;
        }
        break;
}

switch (Player2)
{
    case 1 or PIRATE:
        {
            health_Player2 = 20;
            speed_Player2 = 3;
            attack_Player2 = 3;
        }
        break;


    case 2 or STONE_CHEWER:
        {
            health_Player2 = 50;
            speed_Player2 = 1;
            attack_Player2 = 8;
        }
        break;

    case 3 or GHOST_WARRIOR:
        {
            health_Player2 = 20;
            speed_Player2 = 5;
            attack_Player2 = 2;
        }
        break;
    case 4 or OUTWORLDER:
        {
            health_Player2 = 15;
            speed_Player2 = 10;
            attack_Player2 = 1;
            amor_Player2 = 2;
        }
        break;

    case 5 or DARK_GOBLIN:
        {
            health_Player2 = 10;
            speed_Player2 = 3;
            attack_Player2 = 1;
            amor_Player2 = 8;
        }
        break;
    default:
        break;
}

damage1 = speed_Player1 * attack_Player1;
damage2 = speed_Player2 * attack_Player2;

int health_amor_Player1 = 0;
health_amor_Player1 = health_Player1 + amor_Player1;

int health_amor_Player2 = 0;
health_amor_Player2 = health_Player2 + amor_Player2;


while (health_Player1 > 0 && health_Player2 > 0)
{
    health_amor_Player1 -= damage2;
    health_amor_Player2 -= damage1;
}

if (health_Player1 > 0) { winner = Player1; }
else if (health_Player2 > 0) { winner = Player2; }

else {Console.Write("No winner");}
Console.Write($"The winner is {winner} congratulations");