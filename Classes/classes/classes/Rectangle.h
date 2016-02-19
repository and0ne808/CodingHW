#pragma once
#ifndef RECTANGLE_H
#define RECTANGLE_H
class Rectangle {
	int width, height;
public:
	void set_values(int w, int h);
	int area(void);
};
#endif