#include "Node.h"

class singlyLinked
{
public:
	singlyLinked();
	~singlyLinked();

	//void insertAtFront(const int newData);
	void insertAtFront(const int newData);
	void setHead(Node * const newHead);
	Node * getHead();
	void printList(singlyLinked &rhs);

	void destroyList();
	void destroyListHelper(Node * const pMem);

	void removeDups();

private:
	Node *pHead;
	Node * makeNode(const int newData);

	//void insertAtFront(Node *const pHead, const int newData);

};