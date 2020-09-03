#include "Highway.h"
#include "RoadLine.h"
#include "rlutil.h"
#include <iostream>


using namespace std;
using namespace rlutil;

const int LINE_COUNT = 4;
const int SIDE_LENGTH = 40;
const char SIDE_SHAPE = '$';
const int LANE_CENTER = 13;


Highway::Highway()
{
	draw();
}

Highway::~Highway()
{

}

void Highway::setWidth(int width)
{
	this->width = width;
}
void Highway::setHeight(int height)
{
	this->height = height;
}
int Highway::getWidth()
{
	return width;
}
int Highway::getHeight()
{
	return height;
}
void Highway::draw()
{
	setColor(YELLOW);
	//DRAW SIDES
	for (int i = 1; i <= SIDE_LENGTH; i++)
	{
		locate(1, i);
		cout << SIDE_SHAPE;
		locate(25, i);
		cout << SIDE_SHAPE;
	}

	//DRAW LANES
	int j = 4;
	for (int i = 0; i < LINE_COUNT; i++)
	{
		RoadLine *line = new RoadLine(LANE_CENTER, j);
		line->draw();
		j += 9;
	}
}
