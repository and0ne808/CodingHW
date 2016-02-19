#include "Vector2.h"
#include <iostream>

Vector2::Vector2(int x, int y)
{
	m_x = new int(x);
	m_y = new int(y);
}

Vector2::Vector2(const Vector2& vector)
{
	m_x = new int(*vector.m_x);
	m_y = new int(*vector.m_y);
}
Vector2& Vector2::operator=(const Vector2& obj)
{
	// Deallocate existing memory, if necessary
	// Allocate new memory

	*m_x = obj.GetX();
	*m_y = obj.GetY();



	return *this;
}

Vector2::~Vector2()
{
	delete m_x;
	m_x = NULL;

	delete m_y;
	m_y = NULL;
}


int Vector2::GetX() const
{
	return *m_x;
}

int Vector2::GetY() const
{
	return *m_y;
}

void Vector2::SetX(int x)
{
	*m_x = x;
}

void Vector2::SetY(int y)
{
	*m_y = y;
}
