#include <iostream>

using namespace std;



int main()
{

	int myInt = 5;
	int* myPtr;
	myPtr = &myInt;
	cout << myInt << endl;
	cout << myPtr << endl;
	cout << *myPtr << endl;

	int* myPtr2 = myPtr;
	cout << myPtr2 << endl;
	cout << *myPtr2 << endl;

	myInt++;
	cout << *myPtr << endl;
	cout << *myPtr2 << endl;

	/*
	After all of this, use your first pointer to change it's pointee's value by incrementing it by one (hint: you will need the *)
	Print the pointee's value through the first pointer
	Print the pointee's value through the second pointer
	*/

	*myPtr += 1;
	cout << *myPtr << endl;
	cout << *myPtr2 << endl;

	int myArray[] = { 5,2,19,6,8 };
	int* ptrArray = &myArray[0];
	cout << *ptrArray << endl;

	for (int i = 0; i < 5; i++)
	{
		cout << ptrArray << endl;
		cout << *(ptrArray++)*3 << endl;
	}


	//EXIT APPLICATION
	char a;
	cout << "Please enter any character and press ENTER to close this window..." << endl;
	cin >> a;
	return 0;
}