#include "Car.h"
#include "rlutil.h"
#include <iostream>


using namespace std;
using namespace rlutil;

const int CAR_WIDTH = 5;
const int CAR_LENGTH = 5;
const int CAR_DEFAULT_X = 6;
const int CAR_DEFAULT_Y = 32;
const char CAR_BODY_SHAPE = '#';
const char CAR_WHEEL_SHAPE = '@';

const int CAR_ON_LEFT_LANE = 6;
const int CAR_ON_RIGHT_LANE = 20;

Car::Car()
{
	width = CAR_WIDTH;
	height = CAR_LENGTH;
	positionX = CAR_DEFAULT_X;
	positionY = CAR_DEFAULT_Y;
	bodyShape = CAR_BODY_SHAPE;
	wheelShape = CAR_WHEEL_SHAPE;
	//draw();
}
Car::Car(int positionX, int positionY)
{
	width = CAR_WIDTH;
	height = CAR_LENGTH;
	this->positionX = positionX;
	this->positionY = positionY;
	bodyShape = CAR_BODY_SHAPE;
	wheelShape = CAR_WHEEL_SHAPE;
	//draw();
}

Car::~Car() {

}
void Car::setPositionX(int positionX) {

	this->positionX = positionX;
}
void Car::setPositionY(int positionY) {

	this->positionY = positionY;
}
void Car::setWidth(int width) {

	this->width = width;
}
void Car::setHeight(int height) {

	this->height = height;
}
int Car::getPositionX() {

	return positionX;

}
int Car::getPositionY() {

	return positionY;
}
int Car::getWidth() {

	return width;
}
int Car::getHeight() {

	return height;
}
void Car::draw()
{
	// Draw Car body
	locate(positionX, positionY);
	setColor(RED);
	for (int i = 0; i < CAR_LENGTH; i++)
	{
		locate(positionX, positionY + i);
		cout << bodyShape;
	}
	// Draw Car body left side
	locate(positionX - 1, positionY);
	for (int i = 2; i < CAR_LENGTH - 1; i++)
	{
		locate(positionX - 1, positionY + i);
		cout << bodyShape;
	}
	// Draw Car body right side
	locate(positionX + 1, positionY);
	for (int i = 2; i < CAR_LENGTH - 1; i++)
	{
		locate(positionX + 1, positionY + i);
		cout << bodyShape;
	}

	// Draw Car wheel Front-Left
	locate(positionX, positionY);
	setColor(MAGENTA);
	for (int i = 1; i < CAR_LENGTH - 3; i++)
	{
		locate(positionX - 2, positionY + i);
		cout << wheelShape;
	}
	// Draw Car wheel Rear-Left
	for (int i = 3; i < CAR_LENGTH; i++)
	{
		locate(positionX - 2, positionY + i);
		cout << wheelShape;
	}
	// Draw Car wheel Front-Right
	for (int i = 1; i < CAR_LENGTH - 3; i++)
	{
		locate(positionX + 2, positionY + i);
		cout << wheelShape;
	}
	// Draw Car wheel Rear-Right
	for (int i = 3; i < CAR_LENGTH; i++)
	{
		locate(positionX + 2, positionY + i);
		cout << wheelShape;
	}
}

void Car::changeLane(int LANE)
{
	bodyShape = ' ';
	wheelShape = ' ';
	draw();

	setPositionX(LANE);
	bodyShape = CAR_BODY_SHAPE;
	wheelShape = CAR_WHEEL_SHAPE;
	draw();
}
