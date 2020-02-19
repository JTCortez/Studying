#pragma once
#include <stdio.h>
#include <iostream>

using std::cout;
using std::endl;

using namespace std;

class Node {
public:
	Node (int newData = 0);
	~Node();
	
	int getData() const;
	Node * getNext() const;

	void setData(const int newData);
	void setNext(Node * const newNext);

private:
	int pData;
	Node *pNext;

};