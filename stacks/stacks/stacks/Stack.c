#include "Stack.h";

Node *makeNode (char newData){
	Node *pMem = (Node *) malloc(sizeof(Node));

	pMem->data = newData;
	pMem->pNext = NULL;

	return pMem;
}

void push (Node **pTop, char newData){
	Node *pMem = makeNode(newData);

	if (pMem){
		pMem->pNext = *pTop;
		*pTop = pMem;
	}
}

void pop(Node **pTop){
	Node *pTemp = NULL;

	if(*pTop){
		pTemp = *pTop;
		*pTop = (*pTop)->pNext;
		free (pTemp);
	}
	
}

char peek(Node *pTop){
	Node *pTemp = pTop;
	return pTemp->data;
}


unsigned int isEmpty(Node *pTop){
	return !pTop;
}

void printStack(Node *pTop){
	while (pTop){
		printf("----\n");
		printf("%c", pTop->data);
		printf("----\n");
		pTop = pTop->pNext;
	}
}
