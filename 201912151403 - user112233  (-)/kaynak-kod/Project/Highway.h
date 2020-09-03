#ifndef HIGHWAY_H_
#define HIGHWAY_H_

class Highway {

private:


	int width;
	int height;


public:

	void setWidth(int);
	void setHeight(int);
	int getWidth();
	int getHeight();
	Highway();
	~Highway();
	void draw();


};

#endif
