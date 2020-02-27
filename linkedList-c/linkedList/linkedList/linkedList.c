#include "linkedList.h"

Node * makeNode(int newData){
	Node *pMem = (Node *) malloc(sizeof(Node));

	pMem->data = newData;
	return pMem;
}

void insertAtFront(Node **pHead, int newData){
	Node *pMem = NULL;

	pMem = makeNode(newData);

	if (pHead){
		pMem->pNext = *pHead;
		*pHead = pMem;
	}
}

void printList(Node *pHead){
	Node *pCur = pHead;

	if (pHead){
		while (pCur){
			printf("%d -->", pCur->data);
			pCur = pCur->pNext;
		}
		printf("\n");
	}
}

void removeNode(Node **pHead, int removeData){

}