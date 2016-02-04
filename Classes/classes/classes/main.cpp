#include <iostream>

using namespace std;

struct myStruct
{
	int x;
	int y;
};



int main()
{
	myStruct superStruct;
	superStruct.x = 1;
	superStruct.y = 2;
	cout << superStruct.x << endl;
	char a;
	cout << "Please enter any character and press ENTER to close this window..." << endl;
	cin >> a;
	return 0;
}