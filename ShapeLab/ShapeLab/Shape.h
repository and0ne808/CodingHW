#ifndef SHAPE_H
#define SHAPE_H

#include <iostream>
#include <string>

using namespace std;

class Shape
{
public:
	Shape(string name);
	virtual void Draw();
protected:
	string m_name;
};

#endif