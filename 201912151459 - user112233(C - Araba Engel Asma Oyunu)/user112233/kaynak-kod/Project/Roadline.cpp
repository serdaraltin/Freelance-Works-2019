#include "RoadLine.h"
#include "rlutil.h"
#include <iostream>


using namespace std;
using namespace rlutil;

const int LINE_WIDTH = 1;
const int LINE_HEIGHT= 7;
const int LINE_DEFAULT_X = 13;
const int LINE_DEFAULT_Y = 4;
const char LINE_SHAPE = '|';

RoadLine::RoadLine()
{
	width = LINE_WIDTH;
	height = LINE_HEIGHT;
	positionX = LINE_DEFAULT_X;
	positionY = LINE_DEFAULT_Y;
	setColor(WHITE);
	shape = LINE_SHAPE;
}

RoadLine::RoadLine(int positionX, int positionY)
{
	width = LINE_WIDTH;
	height = LINE_HEIGHT;
	this->positionX = positionX;
	this->positionY = positionY;
	setColor(WHITE);
	shape = LINE_SHAPE;
}

RoadLine::~RoadLine()
{

}
void RoadLine::setPositionX(int positionX)
{
	this->positionX = positionX;
}
void RoadLine::setPositionY(int positionY)
{
	this->positionY = positionY;
}
void RoadLine::setWidth(int width)
{
	this->width = width;
}
void RoadLine::setHeight(int height)
{
	this->height = height;
}
int RoadLine::getPositionX()
{
	return positionX;
}
int RoadLine::getPositionY()
{
	return positionY;
}
int RoadLine::getWidth()
{
	return width;
}
int RoadLine::getHeight()
{
	return height;
}

void RoadLine::draw()
{

	for (int i = 0; i < height; i++)
	{
		locate(positionX, positionY+i);
		cout << shape;

	}
}
