#ifndef SQUARE_H
#define SQUARE_H

#include <iostream>
#include <string>
#include "Shape.h"

using namespace std;

class Square : public Shape
{
public:
	Square(string name, int size) : Shape(name) { m_size = size; }
	virtual void Draw();
private:
	int m_size;
};

#endif
