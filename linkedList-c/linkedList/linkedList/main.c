#include "linkedList.h"

int main(void){
	Node *pHead = NULL;

	insertAtFront(&pHead, 1);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 3);

	printList(pHead);

	return 0;
}