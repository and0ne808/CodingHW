#include<iostream>
#include<string>
#include<iomanip>

using namespace std;

int main()
{
	const int CAT_ROWS = 6;
	const int CAT_COLUMNS = 3;

	string** categories;
	categories = new string*[CAT_ROWS];

	for (int row = 0; row < CAT_ROWS; row++)
	{
		categories[row] = new string[CAT_COLUMNS];
	}

	categories[0][0] = "Test";
	categories[0][1] = "Category";
	categories[0][2] = "One";

	categories[1][0] = "Second";
	categories[1][1] = "Category";
	categories[1][2] = "";

	categories[2][0] = "Category";
	categories[2][1] = "Number";
	categories[2][2] = "Three";

	categories[3][0] = "Another";
	categories[3][1] = "Stupid";
	categories[3][2] = "Category";

	categories[4][0] = "This is";
	categories[4][1] = "a Sweet";
	categories[4][2] = "Category";

	categories[5][0] = "I Love";
	categories[5][1] = "C++";
	categories[5][2] = "";

	for (int i = 0; i < (15 * CAT_ROWS) + 1; i++)
	{
		cout << "-";
	}
	cout << endl;

	for (int j = 0; j < CAT_COLUMNS; j++)
	{
		for (int i = 0; i < CAT_ROWS; i++)
		{
			if (i == 0)
			{
				cout << "| ";
			}
			cout << left << setw(12) << categories[i][j] << right << " | ";
		}
		cout << endl;
	}

	for (int i = 0; i < (15 * CAT_ROWS) + 1; i++)
	{
		cout << "-";
	}
	cout << endl;

	//CREATE DOLLAR ARRAY
	const int COLUMNS = 6;
	const int ROWS = 5;

	int** dollars;
	dollars = new int*[COLUMNS];

	for (int row = 0; row < COLUMNS; row++)
	{
		dollars[row] = new int[ROWS];
	}

	for (int i = 0; i < COLUMNS; i++)
	{
		for (int j = 0; j < ROWS; j++)
	dollars[i][j] = (j+1)*100;
	}

	for (int j = 0; j < ROWS; j++)
	{
		for (int i = 0; i < COLUMNS; i++)
		{
			if (i == 0)
			{
				cout << "| ";
			}
			cout << right << setw(12) << dollars[i][j] << " | ";
		}
		cout << endl;
		for (int i = 0; i < (15 * CAT_ROWS) + 1; i++)
		{
			cout << "-";
		}
		cout << endl;
	}


	char a;
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> a;
	return 0;
}