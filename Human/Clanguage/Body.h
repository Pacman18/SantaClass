#pragma once
//  std�� iostream�� ���ǵ� 
#include <string>

// string ���� ���� �ҷ��� 
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