#pragma once
#include<string>
#include<iostream>
#include "TrophyColor.h"

using namespace std;

class Trophy
{
public:
	//CONSTRUCTORS

	//ACCESSORS
	string getName();
	int getLevel();
	TrophyColor getColor();

	//MUTATORS
	void setName(string newName);
	void setLevel(int newLevel);
	void setColor(TrophyColor newColor);

	void Print();
	friend ostream& operator<<(ostream& sout, const Trophy& trophy);

private:
	string name; //the name of the Trophy
	int level; //the level of the Trophy (1 to 50, inclusive)
	TrophyColor color; //the color of the Trophy (bronze, silver, gold) as a TrophyColor
};