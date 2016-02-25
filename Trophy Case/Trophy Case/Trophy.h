#pragma once
#include<string>
#include<iostream>
#include "TrophyColor.h"

using namespace std;

class Trophy
{
private:
	string name; //the name of the Trophy
	int level; //the level of the Trophy (1 to 50, inclusive)
	TrophyColor color; //the color of the Trophy (bronze, silver, gold) as a TrophyColor
};