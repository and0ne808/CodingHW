#include <iostream>
#include <string>
#include "Shape.h"
#include "Square.h"
#include "Rectangle.h"
#include "Triangle.h"

using namespace std;

 int main()
 {
	 Shape *shapes[5];
	 shapes[0] = new Square("Square", 4);
	 shapes[1] = new Rectangle("Rectangle", 5, 3);
	 shapes[2] = new Triangle("Triangle", 4);
	 shapes[3] = new Square("BiggerSquare", 6);
	 shapes[4] = new Triangle("SmallerTriangle", 3);

	 for (int i = 0; i < 5; i++)
	 {
		 shapes[i]->Draw();
	 }


	 char a;
	 cout << "Enter any character and press ENTER to exit..." << endl;
	 cin >> a;
	 return 0;
 }