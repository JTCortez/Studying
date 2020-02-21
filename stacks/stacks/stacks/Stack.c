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

void reverseString(Node **pHead, char str[]){
	if (isEmpty(*pHead)){
		for (int i = 0;str[i] != '\0'; ++i){
			push (pHead, str[i]);
		}
	}
}

char minStack(Node **pTop, char min)
{
	//Node *pMin = pTop;

	if (!*pTop){
		return min;
	}
	if (peek(*pTop) <= min){
		min = peek(*pTop);
	}
	//printf('%c', pMin->data);
	//pop(pMin);
	pop(pTop);
	return (minStack(pTop, min));
	//return min;

}