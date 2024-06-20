#pragma once
//  std는 iostream에 정의됨 
#include <string>

// string 관련 내용 할려고 
using namespace std;

class Body
{
public :

	string GetName();	

	Body(string name, float size);

	~Body();

private :
	string Name;
	float Size;
};