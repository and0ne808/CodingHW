#include "Rectangle.h"

void Rectangle::Draw()
{
	Shape::Draw();
	for (int i = 0; i < m_height; i++)
	{
		for (int j = 0; j < m_width; j++)
		{
			cout << "*";
		}
		cout << endl;
	}
}