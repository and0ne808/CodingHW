#include "Trophy.h"

//TROPHY CONSTRUCTOR
Trophy::Trophy()
{
	//Allocate memory for all data members of class
	name = new string();
	level = new int();
	color = new TrophyColor();
}

//TROPHY COPY CONSTRUCTOR
Trophy::Trophy(const Trophy & trophy)
{
	//Make a DEEP copy using data from trophy

	name = new string(*trophy.name);
	level = new int(*trophy.level);
	color = new TrophyColor(*trophy.color);
}

//TROPHY DESTRUCTOR
Trophy::~Trophy()
{
	//Delete all data associated w/ Trophy
	delete name;
	name = NULL;
	delete level;
	level = NULL;
	delete color;
	color = NULL;
}

//TROPHY ACCESSORS
string Trophy::getName()
{
	return *name;
}
int Trophy::getLevel()
{
	return *level;
}
TrophyColor Trophy::getColor()
{
	return *color;
}

//TROPHY MODIFIERS
void Trophy::setName(string newName)
{
	*name = newName;
}
void Trophy::setLevel(int newLevel)
{
	*level = newLevel;
}
void Trophy::setColor(TrophyColor newColor)
{
	*color = newColor;
}

//TROPHY INSERTION OPERATOR
ostream& operator<< (ostream& sout, const Trophy& trophy)
{
	string trophy_color;
	if (*trophy.color == TrophyColor::bronze)
	{
		trophy_color = "Bronze";
	}
	else if (*trophy.color == TrophyColor::silver)
	{
		trophy_color = "Silver";
	}
	else if (*trophy.color == TrophyColor::gold)
	{
		trophy_color = "Gold";
	}

	sout << "NAME: " << *trophy.name << " LEVEL: " << *trophy.level << " COLOR: " << trophy_color << endl;
	return sout;
}

Trophy & Trophy::operator=(const Trophy & trophy)
{
	if (this != &trophy) //Self-Assignment Protection
	{
		//Deep Copy - new, independent memory created

		name = new string(*trophy.name);
		level = new int(*trophy.level);
		color = new TrophyColor(*trophy.color);
	}
	return *this;
}
