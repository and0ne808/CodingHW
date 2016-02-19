#include<iostream>
#include "DayOfYear.h"
using namespace std;

int main()
{
	DayOfYear days[5]; // creates 5 days of year

	days[0] = DayOfYear();
	days[1] = DayOfYear(2);
	days[2] = DayOfYear(2, 7);

	DayOfYear* days = new DayOfYear[5];

	DayOfYear* days[5];
	days[0] = new DayOfYear();
	days[1] = new DayOfYear(2);




	char a;
	cout << "Please enter any character and press ENTER to close" << endl;
	cin >> a;
	return 0;
}