#pragma once
#include<iostream>

class DayOfYear
{
	int m_month;
	int m_day;
public:
	void Set(int newMonth);
	DayOfYear();
	DayOfYear(int month);
	DayOfYear(int month, int day);

};