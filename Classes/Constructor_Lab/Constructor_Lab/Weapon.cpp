#include "Weapon.h"
#include<iostream>

using namespace std;

int Weapon::weaponsCreated = 0;

int Weapon::GetWeaponCount()
{
	return weaponsCreated;
}

Weapon::Weapon(weaponType inputType)
	:type(inputType)
{
	Weapon::weaponsCreated++;
	if (type == PISTOL)
	{
		clipSize = 6;
		cout << "PISTOL" << endl;
	}
	else if (type == SHOTGUN)
	{
		clipSize = 2;
		cout << "SHOTGUN" << endl;
	}
	else if (type == RIFLE)
	{
		clipSize = 13;
		cout << "RIFLE" << endl;
	}

	ammo = 0;


}
Weapon::Weapon(weaponType inputType, int inputClipSize)
	:type(inputType) , clipSize(inputClipSize), ammo(0)
{
	Weapon::weaponsCreated++;
}
Weapon::Weapon(weaponType inputType, int inputClipSize, int inputAmmo)
	:type(inputType) , clipSize(inputClipSize) , ammo(inputAmmo)
{
	Weapon::weaponsCreated++;
}
bool Weapon::fire()
{

	if (ammo > 0)
	{
		cout << "BANG" << endl;
		ammo--;
		return true;
	}
	else
	{
		cout << "CLICK" << endl;
		return false;
	}
}
void Weapon::reload(int addedAmmo)
{

	cout << "RELOADING" << endl;

	if (addedAmmo > 0)
	{
		ammo += addedAmmo;

		if (ammo > clipSize)
		{
			ammo = clipSize;
		}
	}

}
int Weapon::checkAmmo() const
{
	return ammo;
}