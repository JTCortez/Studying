#pragma once
#include "queue.h"

Node * makeNode(int data){
	Node *pMem = (Node *) malloc(sizeof(Node));
	pMem->data = data;

	return pMem;
}

void enqueue(Queue *pQ, int data){
	Node *pMem = makeNode(data);

	if (pMem){
		if (pQ->pHead){
			pQ->pTail->pNext = pMem;
			pQ->pTail = pMem;
		}
		else{
			pQ->pHead = pMem;
			pQ->pTail = pMem;
		}
	}
}

void firstOut(Queue *pQ){
	Node *pTemp = NULL;
	if (pQ->pHead->pNext){
		pTemp = pQ->pHead;
		pQ->pHead = pQ->pHead->pNext;
	}
	else{
		pQ->pHead = NULL;
		pQ->pTail = NULL;
	}
	free(pTemp);
}

unsigned int isEmpty(Queue *pQ){
	return !pQ->pHead;
}

int peek(Queue *pQ){
	return (pQ->pHead->data);
}

void printQueue(Queue *pQ){
	Node *pCur = pQ->pHead;
	if (pCur){
		while(pCur){
			printf("%d <--", pCur->data);
			pCur = pCur->pNext;
		}
	}

	printf("%d www", pQ->pHead->data);
}