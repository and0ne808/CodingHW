#include <iostream>
#include <string>
#include "TrophyColor.h"
#include "Trophy.h"
#include "TrophyCase.h"

using namespace std;

//Program Functions
void mainMenu(TrophyCase* myCase);
int exitApplication();

//Trophy Functions
void makeTrophy(TrophyCase* myCase);
void makeCopy(TrophyCase* myCase);
void assignmentCopy(TrophyCase* myCase);

//MAIN PROGRAM---------------------------------------------------------------------
int main()
{
	cout << "Welcome to the Trophy Program for Serious Skillz!" << endl;
	TrophyCase* andrewCase = new TrophyCase();
	mainMenu(andrewCase);
	return(exitApplication());
}
//END MAIN PROGRAM------------------------------------------------------------------

void mainMenu(TrophyCase* myCase)
{
	// display welcome message with instructions
	int* choice = new int();

	cout << "Please choose an option and press ENTER to proceed..." << endl;
	cout << "1 - Add a new Trophy" << endl;
	cout << "2 - Print all the Trophies" << endl;
	cout << "3 - Copy Constructor and Print Trophies" << endl;
	cout << "4 - Assignment Operator and Print Trophies" << endl;
	cout << "5 - Exit the program" << endl;

	//Check for validity of entry
	cin >> *choice;
	while (!(*choice > 0 && *choice < 6))
	{
		cout << "Please enter an integer between 1 and 5 only" << endl;
		cin >> *choice;
	}

	

	//Get choice from user
	switch (*choice) {
	case 1:
		makeTrophy(myCase);	
		break;
	case 2:
		cout << "You have chosen to print all the trophies" << endl;
		cout << *myCase;
		mainMenu(myCase);
		break;
	case 3:
		cout << "Here is the copied TrophyCase:" << endl;
		makeCopy(myCase);
		break;
	case 4:
		cout << "Here is the copied TrophyCase:" << endl;
		assignmentCopy(myCase);
		break;
	default:
		break;
	}

}

int exitApplication()
{
	char* a = new char();
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> *a;
	return 0;
}

void makeTrophy(TrophyCase* myCase)
{
	string* newTrophy_name = new string();
	int* newTrophy_level = new int(0);
	string newTrophy_color;
	TrophyColor* newColor = new TrophyColor();

	cout << "Please enter the name of the Trophy" << endl;
	while(getline(cin, *newTrophy_name))
		if (*newTrophy_name != "")
		{
			break;
		}

	cout << "Please enter the level of the Trophy (1 - 50)" << endl;
	cin >> *newTrophy_level;
	while (*newTrophy_level > 50 || *newTrophy_level < 1)
	{
		cout << "ERROR: Please enter an integer between 1 and 50" << endl;
		cin >> *newTrophy_level;
	}

	cout << "Please enter the color: gold, silver, or bronze." << endl;
	cin >> newTrophy_color;
	for (int i = 0; newTrophy_color[i]; i++) newTrophy_color[i] = tolower(newTrophy_color[i]);

	while (!(newTrophy_color == "bronze" || newTrophy_color == "silver" || newTrophy_color == "gold"))
	{
		cout << "ERROR: Please enter either GOLD, SILVER, or BRONZE" << endl;
		cin >> newTrophy_color;

		//Lowercase
		for (int i = 0; newTrophy_color[i]; i++) newTrophy_color[i] = tolower(newTrophy_color[i]);

	}

	if (newTrophy_color == "bronze")
	{
		*newColor = TrophyColor::bronze;
	}
	else if (newTrophy_color == "silver")
	{
		*newColor = TrophyColor::silver;
	}
	else if (newTrophy_color == "gold")
	{
		*newColor = TrophyColor::gold;
	}

	Trophy* newTrophy = new Trophy();
	newTrophy->setName(*newTrophy_name);
	newTrophy->setLevel(*newTrophy_level);
	(*newTrophy).setColor(*newColor);

	myCase->AddTrophy(*newTrophy);


	mainMenu(myCase);
}
void makeCopy(TrophyCase* myCase)
{
	TrophyCase* copiedCase = new TrophyCase(*myCase);
	cout << *copiedCase;
	mainMenu(myCase);
}
void assignmentCopy(TrophyCase* myCase)
{
	TrophyCase copiedCase = *myCase;
	cout << copiedCase;
	mainMenu(myCase);
}