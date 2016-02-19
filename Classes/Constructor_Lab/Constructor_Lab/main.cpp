#include <iostream>
#include <string>
#include <cstdlib>
#include "Weapon.h"

using namespace std;

int main()
{
	Weapon weapons[6] = { Weapon(PISTOL, 6),Weapon(PISTOL, 12) ,Weapon(PISTOL, 12, 6) ,Weapon(RIFLE, 13, 3),Weapon(RIFLE, 4, 4),Weapon(SHOTGUN, 4, 1) };

	/*Use a for-loop and a while loop to fire the weapons until they are empty.  DO NOT attempt to 
	fire an empty weapon (no CLICKs should be printed)*/

	for (int i = 0; i < Weapon::GetWeaponCount(); i++)
	{
		while (weapons[i].checkAmmo() > 0)
		{
			weapons[i].fire();
		}
	}

	cout << Weapon::GetWeaponCount() << endl;


	char a;
	cout << "Enter any character and press ENTER to quit." << endl;
	cin >> a;

	return 0;
}