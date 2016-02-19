#ifndef Vector2_H
#define Vector2_H

class Vector2
{
public:
	Vector2(int x = 0, int y = 0);
	Vector2(const Vector2& vector);
	Vector2& operator=(const Vector2& obj);
	~Vector2(); //Destructor
	int GetX() const;
	int GetY() const;
	void SetX(int x);
	void SetY(int y);
private:
	int* m_x;
	int* m_y;
};

#endif
