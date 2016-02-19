#include "DayOfYear.h"
#include<iostream>

	DayOfYear::DayOfYear()
	{
		m_month = 1;
		m_day = 1;
	}
	DayOfYear::DayOfYear(int month)
	{
		m_month = month;
		m_day = 1;
	}
	DayOfYear::DayOfYear(int month, int day)
	{
		m_month = month;
		m_day = day;
	}
	void DayOfYear::Set(int newMonth)
	{
		newMonth = newMonth;
	}