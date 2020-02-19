#include <stdio.h>
#include <iostream>

using std::cout;
using std::endl;

class Node {
public:
	Node (int newData = 0);
	~Node();
	
	int getData() const;
	Node *& getNext();

	void setData(const int newData);
	void setNext(Node * const newNext);

private:
	int pData;
	Node *pNext;

};