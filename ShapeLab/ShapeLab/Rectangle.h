#ifndef RECTANGLE_H
#define RECTANGLE_H
#include <iostream>
#include <string>
#include "Shape.h"

using namespace std;

class Rectangle : public Shape
{
public:
	virtual void Draw();
	Rectangle(string name, int width, int height) : Shape(name), m_width(width), m_height(height) {}
private:
	int m_width;
	int m_height;
};

#endif
