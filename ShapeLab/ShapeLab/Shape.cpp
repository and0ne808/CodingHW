#include "Shape.h"

Shape::Shape(string name)
{
	m_name = name;
}

void Shape::Draw()
{
	cout << m_name << endl;
}