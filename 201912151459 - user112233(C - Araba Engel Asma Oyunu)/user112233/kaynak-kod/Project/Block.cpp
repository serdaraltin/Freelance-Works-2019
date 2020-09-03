#include "Block.h"
#include "rlutil.h"
#include <iostream>



using namespace std;
using namespace rlutil;

const int BLOCK_WIDTH = 4;
const int BLOCK_LENGTH = 11;
const int BLOCK_DEFAULT_X = 2;
const int BLOCK_DEFAULT_Y = 1;
const char BLOCK_SHAPE = '&';
const int SIDE_LENGTH = 40;


Block::Block()
{
	deleted = false;
	width = BLOCK_WIDTH;
	height = BLOCK_LENGTH;
	positionX = BLOCK_DEFAULT_X;
	positionY = BLOCK_DEFAULT_Y;
	blockShape = BLOCK_SHAPE;

}
Block::Block(int positionX, int positionY)
{
	deleted = false;
	width = BLOCK_WIDTH;
	height = BLOCK_LENGTH;
	this->positionX = positionX;
	this->positionY = positionY;
	blockShape = BLOCK_SHAPE;

}
Block::~Block()
{

}

void Block::setHeight(int height) {

	this->height = height;
}
void Block::setWidth(int width) {

	this->width = width;
}
void Block::setPositionX(int positionX) {

	this->positionX = positionX;
}
void Block::setPositionY(int positionY) {

	this->positionY = positionY;
}
int Block::getHeight()
{

	return height;
}
int Block::getWidth() {

	return width;
}

int Block::getPositionX() {

	return positionX;
}
int Block::getPositionY() {

	return	positionY;
}
bool Block::isDeleted()
{
	return deleted;
}
void Block::draw()
{
	if (!deleted)
	{
		setColor(CYAN);
		locate(positionX, positionY);

		int X = positionX;
		for (int i = 0; i < BLOCK_LENGTH; i++)
		{
			for (int j = 0; j < BLOCK_WIDTH; j++)
			{
				locate(X, positionY + j);
				cout << blockShape;
			}
			locate(++X, positionY);
		}
	}
}

void Block::deleteBlock()
{
	unDrawBlock();
	positionX = -1;
	positionY = -1;
	deleted = true;
}

void Block::unDrawBlock()
{
	locate(positionX, positionY);
	blockShape = ' ';
	draw();
	blockShape = BLOCK_SHAPE;
}

void Block::animate()
{
	if (deleted)
		return;

	if (positionY > SIDE_LENGTH - BLOCK_WIDTH)
	{
		deleteBlock();
		return;
	}

	unDrawBlock();

	positionY++;
	draw();
}
