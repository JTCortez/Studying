#include "Node.h"

Node::Node(int newData)
{
	pData = newData;
}

Node::~Node()
{
}

int Node::getData() const
{
	return pData;
}

Node * Node::getNext() const
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
