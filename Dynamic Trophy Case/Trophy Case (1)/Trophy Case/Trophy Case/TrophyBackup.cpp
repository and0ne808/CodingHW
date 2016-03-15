//#include "Trophy.h"

string Trophy::getName()
{
	return name;
}
int Trophy::getLevel()
{
	return level;
}
TrophyColor Trophy::getColor()
{
	return color;
}
void Trophy::setName(string newName)
{
	name = newName;
}
void Trophy::setLevel(int newLevel)
{
	level = newLevel;
}
void Trophy::setColor(TrophyColor newColor)
{
	color = newColor;
}
void Trophy::Print()
{
	string trophy_color;
	if (color == TrophyColor::bronze)
	{
		trophy_color = "Bronze";
	}
	else if (color == TrophyColor::silver)
	{
		trophy_color = "Silver";
	}
	else if (color == TrophyColor::gold)
	{
		trophy_color = "Gold";
	}

	cout << "NAME: " << name << " LEVEL: " << level << " COLOR: " << trophy_color << endl;
}
ostream& operator<< (ostream& sout, const Trophy& trophy)
{
	string trophy_color;
	if (trophy.color == TrophyColor::bronze)
	{
		trophy_color = "Bronze";
	}
	else if (trophy.color == TrophyColor::silver)
	{
		trophy_color = "Silver";
	}
	else if (trophy.color == TrophyColor::gold)
	{
		trophy_color = "Gold";
	}

	sout << "NAME: " << trophy.name << " LEVEL: " << trophy.level << " COLOR: " << trophy_color << endl;
	return sout;
}