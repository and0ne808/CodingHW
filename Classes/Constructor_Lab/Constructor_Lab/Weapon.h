#pragma once
#ifndef WEAPON_H
#define WEAPON_H
#include<iostream>

enum weaponType { PISTOL, SHOTGUN, RIFLE };

class Weapon {
public:
	Weapon(weaponType inputType = PISTOL);
	Weapon(weaponType inputType, int inputClipSize);
	Weapon(weaponType inputType, int inputClipSize, int inputAmmo);
	bool fire();
	void reload(int addedAmmo);
	int checkAmmo() const;
	static int GetWeaponCount();

private:
	weaponType type;
	int ammo;
	int clipSize;
	static int weaponsCreated;

};


#endif