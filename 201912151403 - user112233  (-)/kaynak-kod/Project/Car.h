#ifndef CAR_H_
#define CAR_H_

class Car
{
private:
	int positionX;
	int positionY;
	int width;
	int height;
	char bodyShape;
	char wheelShape;
public:
	Car();
	Car(int,int);
	~Car();
	void setPositionX(int);
	void setPositionY(int);
	void setWidth(int);
	void setHeight(int);
	int getPositionX();
	int getPositionY();
	int getWidth();
	int getHeight();
	void draw();
	void changeLane(int);
};


#endif
