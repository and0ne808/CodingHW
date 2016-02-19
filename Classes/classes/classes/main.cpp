#include <iostream>
#include "Rectangle.h"
using namespace std;

int main()
{
	Rectangle myRectangle;
	myRectangle.set_values(2, 3);
	cout << myRectangle.area() << endl;
	char a;
	cout << "Please enter any character and press ENTER to close this window..." << endl;
	cin >> a;
	return 0;
}