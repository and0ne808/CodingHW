#include "Triangle.h"

void Triangle::Draw()
{
	Shape::Draw();
	for (int i = 0; i < m_height; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			cout << "*";
		}
		cout << endl;
	}
}