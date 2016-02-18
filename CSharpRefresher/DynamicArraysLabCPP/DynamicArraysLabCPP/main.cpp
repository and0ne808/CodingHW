#include<iostream>
#include<string>
#include<iomanip>

using namespace std;

const int TITLE_COLUMNS = 6;
const int TITLE_ROWS = 3;
const int BOX_WIDTH = 9;

void drawTable(string** categories, int** dollars);

int main()
{


	string** categories;
	categories = new string*[TITLE_COLUMNS];

	for (int row = 0; row < TITLE_COLUMNS; row++)
	{
		categories[row] = new string[TITLE_ROWS];
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

	categories[4][0] = "This";
	categories[4][1] = "Category";
	categories[4][2] = "Rocks!";

	categories[5][0] = "Learning";
	categories[5][1] = "with C++";
	categories[5][2] = "is fun!";

	
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
			dollars[i][j] = (j + 1) * 100;
	}

	drawTable(categories, dollars);

	string categoryInput;

	while (true)
	{
		bool validInput = false;

		while (validInput == false)
		{
			cout << "Please enter the FIRST LINE of the category name..." << endl;
			cin >> categoryInput;

			if (categoryInput == "q")
			{
				return 0; //QUIT APPLICATION
			}


			for (int i = 0; i < COLUMNS; i++)
			{
				if (categories[i][0] == categoryInput)
				{
					validInput = true;
				}
			}
		}

		int dollarInput;
		validInput = false;
		while (validInput == false)
		{
			cout << "Please enter the dollar amount..." << endl;
			cin >> dollarInput;
			for (int i = 1; i <= 5; i++)
			{
				if (i * 100 == dollarInput)
				{
					validInput = true;
				}
			}
		}

		int selectedColumn;
		for (int i = 0; i < TITLE_COLUMNS; i++)
		{
			if (categoryInput == categories[i][0])
			{
				selectedColumn = i;
			}
		}

		int selectedRow;
		for (int i = 0; i < ROWS; i++)
		{
			if (dollarInput == (i + 1) * 100)
			{
				selectedRow = i;
			}
		}

		dollars[selectedColumn][selectedRow] = 0;
		drawTable(categories, dollars);
	}
	//END LOOP HERE

	char a;
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> a;
	return 0;
}

void drawTable(string** categories, int** dollars)
{
	//CREATE TITLES
	for (int i = 0; i < ((BOX_WIDTH + 3) * TITLE_COLUMNS) + 1; i++)
	{
		cout << "-";
	}
	cout << endl;

	for (int j = 0; j < TITLE_ROWS; j++)
	{
		for (int i = 0; i < TITLE_COLUMNS; i++)
		{
			if (i == 0)
			{
				cout << "| ";
			}
			cout << left << setw(BOX_WIDTH) << categories[i][j] << right << " | ";
		}
		cout << endl;
	}

	for (int i = 0; i < ((BOX_WIDTH + 3) * TITLE_COLUMNS) + 1; i++)
	{
		cout << "-";
	}
	cout << endl;

	//CREATE DOLLAR ARRAY
	const int COLUMNS = 6;
	const int ROWS = 5;

	for (int j = 0; j < ROWS; j++)
	{
		for (int i = 0; i < COLUMNS; i++)
		{
			if (i == 0)
			{
				cout << "| ";
			}
			if (dollars[i][j] != 0)
			{
				cout << right << setw(BOX_WIDTH) << dollars[i][j] << " | ";
			}
			else
			{
				cout << right << setw(BOX_WIDTH) << " " << " | ";
			}
		}
		cout << endl;
		for (int i = 0; i < ((BOX_WIDTH + 3) * TITLE_COLUMNS) + 1; i++)
		{
			cout << "-";
		}
		cout << endl;
	}
}