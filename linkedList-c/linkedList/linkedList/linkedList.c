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

	Node *pCur = *pHead;
	Node *pPrev =  NULL;

	if (*pHead) {
		while (pCur->data != removeData){
			pPrev = pCur;
			pCur = pCur->pNext;
		}

		if (pCur == *pHead){
			*pHead = pCur->pNext;
			free(pCur);
		}
		else{
			pPrev->pNext = pCur->pNext;
			free(pCur);
		}

	}
}

void removeDups(Node **pHead){
	Node *pCur = NULL;
	Node *pDup = *pHead;
	Node *pPrev = NULL;
	Node *pTemp = NULL;

	if (pHead){
		while(pDup){
			pCur = pDup->pNext;
			pPrev = pDup;
			while(pCur){
				if(pDup->data == pCur->data){
					printf("pdup: %d, pcur: %d\n", pDup->data, pCur->data);
					pTemp = pCur;
					pPrev->pNext = pCur->pNext;
					free(pTemp);
					pCur = pPrev->pNext;
				}
				else{
					pPrev = pCur;
					pCur = pCur->pNext;
				}
			}
			pDup = pDup->pNext;
		}
	}
}

void weaveList(Node **pHead){
	Node *p2 = *pHead;
	Node *p1 = p2->pNext;
	Node *pTemp1 = NULL, *pTemp2 = NULL;
	Node *p2Next = NULL;

	if (*pHead && p1->pNext){
		while(p1->pNext){
			p2 = p2->pNext;
			p1 = p1->pNext;
			p1 = p1->pNext;
		}

		p1 = *pHead;
		while (p2){
			p2Next = p2->pNext;
			pTemp2 = p2->pNext;
			pTemp2 = pTemp2->pNext;
			pTemp1 = p1->pNext;
			p2->pNext = pTemp2;
			p2Next->pNext = pTemp1;
			p1->pNext = p2Next;
			p1 = pTemp1;
			p2 = pTemp2;

		}
	}

}