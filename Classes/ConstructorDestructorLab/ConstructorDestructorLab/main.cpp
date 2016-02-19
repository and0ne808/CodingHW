#include <iostream>
#include <string>
#include "Vector2.h"

using namespace std;

void PrintVector(const Vector2& v)
{
	cout << "(" << v.GetX() << ", " << v.GetY() << ")" << endl;
}

Vector2 ModifyVector(Vector2 v)
{
	v.SetX(10);
	v.SetY(12);
	PrintVector(v);
	return v;
}

int main()
{
	Vector2 vectorA;
	Vector2 vectorB;

	PrintVector(vectorA);
	PrintVector(vectorB);

	vectorA.SetX(5);
	vectorA.SetY(7);
	vectorB.SetX(2);
	vectorB.SetY(3);

	PrintVector(vectorA);
	PrintVector(vectorB);

	//COPY CONSTRUCTOR TESTING
	ModifyVector(vectorA);

	// ASSIGNMENT OPERATOR TESTING
	vectorA = ModifyVector(vectorA);
	PrintVector(vectorA);

	// DESTRUCTOR TESTING
	Vector2* vectorC = new Vector2(4, 5);
	PrintVector(*vectorC);
	delete vectorC;
	vectorC = NULL;

	cout << "Press any key to exit..." << endl;
	char c;
	cin.get(c);

	return 0;
}