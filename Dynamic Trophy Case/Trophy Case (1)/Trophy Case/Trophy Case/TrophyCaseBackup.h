#pragma once
#include <iostream>
#include <string>
#include "Trophy.h"
#include "TrophyColor.h"

using namespace std;

class TrophyCase
{
public:
	TrophyCase(); // constructor
	TrophyCase(int newSize);
	TrophyCase(const TrophyCase &copyThis); //copy constructor
	TrophyCase(const TrophyCase &copyThis, int newSize);
	~TrophyCase(); // destructor

	friend ostream& operator<<(ostream& sout, const TrophyCase& trophyCase);

	void AddTrophy(Trophy newTrophy);
	void Print();

	TrophyCase& operator=(const TrophyCase& copyThis);

private:
	Trophy* Trophies; // dynamic array of trophies
	int count; // number of trophies in case
	int size; // size of dynamic array
};
