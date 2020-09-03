
#include <windows.h>
#include <iostream>
#include <ctime>
#include <cstdlib>
#include <vector>

#include "RoadLine.h"
#include "Highway.h"
#include "Car.h"
#include "Block.h"
#include "rlutil.h"


using namespace std;
using namespace rlutil;

const int CAR_ON_LEFT_LANE  = 6;
const int CAR_ON_RIGHT_LANE = 20;

const int LEFT_BLOCK = 2;
const int RIGHT_BLOCK = 14;

const int SCORED = 36;
const int BLOCK_SCORE = 50;

Highway *road;
Car *car;
vector<Block> blocks;

int toGenerate = 0;

int gameScore = 0;

void startScreen() {
	hidecursor();
	saveDefaultColor();
	setColor(2);
	cout<< "Welcome! Use <-- and --> buttons to move, ESC to quit" <<endl;
	setColor(5);
	cout << "Every passed block you get 50 points. Good Luck !" << endl;
	setColor(6);
	anykey("Hit any key to start.\n");



}
void drawMap()
{
    HWND console = GetConsoleWindow();
	RECT r;
	GetWindowRect(console, &r); //stores the console's current dimensions

	MoveWindow(console, r.left, 0, 240, 700, TRUE);

	hidecursor();
	cls();
	road->draw();
	car->draw();
}

void animateBlocks()
{
	Sleep(50);
	for (int i = 0; i < blocks.size(); i++)
		blocks[i].animate();

	toGenerate++;
}


void generateBlock()
{

	if (toGenerate % 20 == 0)
	{
		srand(time(NULL));
		int location = rand() % 2;
		if (location == 0)
			blocks.push_back(Block(LEFT_BLOCK, 1));
		else
			blocks.push_back(Block(RIGHT_BLOCK, 1));

	}

	animateBlocks();
}

bool isCrashed(Block block, Car *car)
{
	if (block.isDeleted())
		return false;

	if(block.getPositionX() == 2) // BLOCK IS ON THE LEFT LANE
		if (((car->getPositionX() - (car->getWidth() / 2)) < (block.getPositionX() + (block.getWidth() - 1))) && (car->getPositionY() < (block.getPositionY() + block.getWidth() - 1)))
			return true;
	if (block.getPositionX() == 14) // BLOCK IS ON THE RIGHT LANE
		if (((car->getPositionX() + (car->getWidth() / 2)) > (block.getPositionX())) && (car->getPositionY() < (block.getPositionY() + block.getWidth() - 1)))
			return true;

	return false;
}

void calculateScore(Block block)
{
	if (block.getPositionY() == SCORED)
		gameScore += BLOCK_SCORE;
}

void gameOver()
{
	locate(6, 18);
	setBackgroundColor(WHITE);
	setColor(BLACK);
	cout << "***GAME OVER***";
	locate(8, 19);
	cout << "Your Score" ;
	locate(11, 20);
	cout << gameScore;
	while(1)
		cin.get();
}

int main()
{
	startScreen();

	road = new Highway();
	car = new Car();



	drawMap();
	//GAME LOOP
	while (1)
	{
		generateBlock();


		for (int i = 0; i < blocks.size(); i++)
		{
			// HANDLE CRASH
			if (isCrashed(blocks[i], car))
				gameOver();
			// CALCULATE SCORE
			calculateScore(blocks[i]);
		}

		// HANDLE KEY PRESSED
		if (kbhit()) {
			char k = getkey();

			if (k == KEY_ESCAPE)
			{
				gameOver();
				break;
			}
			if (k == KEY_LEFT)
			{
				car->changeLane(CAR_ON_LEFT_LANE);
			}
			if (k == KEY_RIGHT)
			{
				car->changeLane(CAR_ON_RIGHT_LANE);
			}

		}
	}

	return 0;
}
