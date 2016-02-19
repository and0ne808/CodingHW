#ifndef TRIANGLE_H
#define TRIANGLE_H

#include <iostream>
#include <string>
#include "Shape.h"

using namespace std;

class Triangle : public Shape
{
public:
	void Draw();
	Triangle(string name, int height) : Shape(name) { m_height = height; }
private:
	int m_height;

};

#endif
