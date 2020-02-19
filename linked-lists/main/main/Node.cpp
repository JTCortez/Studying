#include "Node.h"

Node::Node(int newData)
{
	pData = newData;
	pNext = nullptr;

}

Node::~Node()
{
	cout << "destructor" << endl;

}

int Node::getData() const
{
	return pData;
}

Node *& Node::getNext()
{
	return pNext;
}

void Node::setData(const int newData)
{
	pData = newData;
}

void Node::setNext(Node * const newNext)
{
	pNext = newNext;
}
