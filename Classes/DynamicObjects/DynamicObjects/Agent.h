#pragma once
#include <vector>
#include <string>

using namespace std;

class Agent
{
public:
	Agent(string name = "");
	~Agent();
private:
	string m_name;
	Vector2* m_position;
	Vector2* m_velocity;
};