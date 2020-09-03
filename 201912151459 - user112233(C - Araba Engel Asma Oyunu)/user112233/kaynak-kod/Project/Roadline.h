#ifndef ROADLINE_H_
#define ROADLINE_H_

class RoadLine {

private:

	int positionX;
	int positionY;
	int width;
	int height;
	char shape;


public:

	RoadLine();
	RoadLine(int, int);
	~RoadLine();
	void setPositionX(int);
	void setPositionY(int);
	void setWidth(int);
	void setHeight(int);
	int getPositionX();
	int getPositionY();
	int getWidth();
	int getHeight();
	void draw();





};







#endif
