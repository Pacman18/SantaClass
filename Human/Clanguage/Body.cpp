
#include "Body.h"

using namespace std;

string Body::GetName()
{
	return this->Name;
}

Body::Body(string name, float size) :  Name(name), Size(size)
{

}

Body::~Body()
{

}
