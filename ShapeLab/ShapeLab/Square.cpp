#include "Square.h"
#include "Shape.h"
#include <string>
#include <iostream>

using namespace std;

void Square::Draw()
{
	Shape::Draw();
	for (int i = 0; i < m_size; i++)
	{
		for (int j = 0; j < m_size; j++)
		{
			cout << "*";
		}
		cout << endl;
	}

}