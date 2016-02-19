#include <iostream>
#include <string>
using namespace std;

class Vehicle {
public: virtual string getType() = 0;
};

class Car : public Vehicle {
public: string getType() { return "Car"; }
};

class Motorcycle : public Vehicle {
public: string getType() { return "Motorcycle"; }
};

int main()
{
	Vehicle* vPtr = new Vehicle();
	cout << vPtr->getType() << " ";
	Vehicle* cPtr = new Car();
	cout << cPtr->getType() << " ";
	Vehicle* mPtr = new Motorcycle();
	cout << mPtr->getType();



	char a;
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> a;
	return 0;
}