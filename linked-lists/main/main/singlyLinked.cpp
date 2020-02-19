#include "singlyLinked.h"

singlyLinked::singlyLinked()
{
	pHead = nullptr;
}

singlyLinked::~singlyLinked()
{
	cout << "freeing memory" << endl;
	destroyList();
}

void singlyLinked::setHead(Node * const newHead) {
	pHead = newHead;
}

Node *singlyLinked::makeNode(const int newData)
{
	Node *pMem = new Node(newData);

	return pMem;
}

////
////void singlyLinked::insertAtFront(const int newData){
////	insertAtFront(pHead, newData);
////}


Node * singlyLinked::getHead() {
	return pHead;
}

void singlyLinked::insertAtFront(const int newData){
	Node *pMem = makeNode(newData);

	if (pHead == nullptr){
		setHead(pMem);
	}
	else if (pMem){
		pMem->setNext(pHead);
		setHead(pMem);
	}
	
}

void singlyLinked::printList(singlyLinked &rhs){
	Node *pCur = rhs.getHead();
	while (pCur){
		cout << pCur->getData() << "--> ";
		pCur = pCur->getNext();
	}
	cout << "\n";
}

void singlyLinked::destroyListHelper(Node * const pMem){
	if (pMem){
		destroyListHelper(pMem->getNext());
		delete pMem;
	}
}

void singlyLinked::destroyList()
{
	destroyListHelper(pHead);
}

void singlyLinked::removeDups()
{
	Node *pCur = pHead;
	Node *pPrev = nullptr;
	Node *pDup = pHead;
	//Node *pTemp = nullptr;
	cout << pDup->getData() << pCur->getData();

	if (pHead){
		while (pDup->getNext()){
			while(pCur->getNext()){
				pPrev = pCur;
				pCur = pCur->getNext();

				cout << pDup->getData() << pCur->getData();
				if(pDup->getData() == pCur->getData()){
					cout <<"IM A DUAP" << pDup->getData() << pCur->getData();
					//pPrev->setNext(pCur->getNext());
					//pCur = nullptr;
				}
			}
			//pDup = pDup->getNext();
			///pCur = pDup;
			//cout << pDup->getData() << pCur->getData();
		}
	}

}


