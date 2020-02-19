#include "Node.h"

using std::cin;
using std::cout;
using std::endl;

class singlyLinked
{
public:
	singlyLinked();

private:
	Node *pHead;
	Node * makeNode(const int newData);

};