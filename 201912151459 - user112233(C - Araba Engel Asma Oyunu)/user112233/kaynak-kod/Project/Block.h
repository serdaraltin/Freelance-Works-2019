#ifndef BLOCK_H_
#define BLOCK_H_

class Block {

private:

	int positionX;
	int positionY;
	int width;
	int height;
	char blockShape;
	bool deleted;

public:
	Block();
	Block(int, int);
	~Block();
	void setPositionX(int);
	void setPositionY(int);
	void setWidth(int);
	void setHeight(int);
	int getPositionX();
	int getPositionY();
	int getWidth();
	int getHeight();
	void draw();
	void animate();
	void deleteBlock();
	void unDrawBlock();
	bool isDeleted();



};







#endif

