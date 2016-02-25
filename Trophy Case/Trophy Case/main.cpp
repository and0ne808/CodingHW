#include <iostream>
#include <string>
#include "TrophyColor.h"


using namespace std;

//Program Functions
void mainMenu();
int exitApplication();

//MAIN PROGRAM---------------------------------------------------------------------
int main()
{
	TrophyColor myColor = TrophyColor::bronze;

	mainMenu();
	return(exitApplication());
}
//END MAIN PROGRAM------------------------------------------------------------------

void mainMenu()
{
	// display welcome message with instructions
	int choice;

	cout << "Please choose an option and press ENTER to proceed..." << endl;
	cout << "1 - Add a new Trophy" << endl;
	cout << "2 - Print all the Trophies" << endl;
	cout << "3 - Copy Constructor and Print Trophies" << endl;
	cout << "4 - Assignment Operator and Print Trophies" << endl;
	cout << "5 - Exit the program" << endl;

	//Check for validity of entry
	cin >> choice;
	while (!(choice > 0 && choice < 6))
	{
		cout << "Please enter an integer between 1 and 4 only" << endl;
		cin >> choice;
	}

	//Get choice from user
	switch (choice) {
	case 1:
		cout << "You have chosen to add a new trophy" << endl;
		mainMenu();
		break;
	case 2:
		cout << "You have chosen to print all the trophies" << endl;
		mainMenu();
		break;
	case 3:
		cout << "You chose Copy Constructor and Print Trophies" << endl;
		mainMenu();
		break;
	case 4:
		cout << "You chose Assignment Operator and Print Trophies" << endl;
		mainMenu();
		break;
	default:
		break;
	}

}

int exitApplication()
{
	char a;
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> a;
	return 0;
}