#include "TrophyCase.h"
#include <algorithm>
TrophyCase::TrophyCase()
{
	size = 5;
	count = 0;
	Trophies = new Trophy[size];
}
TrophyCase::TrophyCase(int newSize)
{
	size = newSize;
	count = 0;
	Trophies = new Trophy[size];
}
TrophyCase::TrophyCase(const TrophyCase &copyThis)
{
	size = copyThis.size;
	count = copyThis.count;
	Trophies = new Trophy[size];
	for (int i = 0; i < count; i++)
	{
		Trophies[i] = copyThis.Trophies[i];
	}
}
TrophyCase::TrophyCase(const TrophyCase &copyThis, int newSize)
{
	size = newSize;
	count = copyThis.count;
	Trophies = new Trophy[size];
	for (int i = 0; i < count; i++)
	{
		Trophies[i] = copyThis.Trophies[i];
	}
}
TrophyCase::~TrophyCase()
{
	delete[] Trophies;
	Trophies = NULL;
}
void TrophyCase::AddTrophy(Trophy newTrophy)
{

	count++;
	if (count > size)
	{
		/*
		size_t newSize = size * 2;
		Trophy* newArr = new Trophy[newSize];

		memcpy(newArr, Trophies, size * sizeof(int));

		size = newSize;
		delete[] Trophies;
		Trophies = newArr;
		*/

		TrophyCase newCase(*this, size * 2);

		*this = newCase;


	
	}
	Trophies[count - 1] = newTrophy;
	cout << newTrophy;

}
void TrophyCase::Print()
{
	for (int i = 0; i < count; i++)
	{
		cout << Trophies[i];
	}
}
ostream& operator<<(ostream& sout, const TrophyCase& trophyCase)
{
	for (int i = 0; i < trophyCase.count; i++)
	{
		sout << trophyCase.Trophies[i];
	}
	return sout;
}

TrophyCase& TrophyCase::operator=(const TrophyCase& copyThis)
{
	if (this != &copyThis) // self-assignment protection
	{
		delete[] Trophies;
		size = copyThis.size;
		count = copyThis.count;

		Trophies = new Trophy[size];

		for (int i = 0; i < count; i++)
		{
			Trophies[i] = copyThis.Trophies[i];
		}
		
		//*Trophies = *copyThis.Trophies;
	}
	return *this;
	
}
