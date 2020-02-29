#include "linkedList.h"

int main(void){
	Node *pHead = NULL;

	//remove dupe and remove node check
	/*insertAtFront(&pHead, 1);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 3);
	insertAtFront(&pHead, 1);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 12);

	removeDups(&pHead);

	printList(pHead);*/
	insertAtFront(&pHead, 6);
	insertAtFront(&pHead, 5);
	insertAtFront(&pHead, 4);
	insertAtFront(&pHead, 3);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 1);
	insertAtFront(&pHead, 6);
	insertAtFront(&pHead, 5);
	insertAtFront(&pHead, 4);
	insertAtFront(&pHead, 3);
	insertAtFront(&pHead, 2);
	insertAtFront(&pHead, 1);

	printList(pHead);
	weaveList(&pHead);

	printList(pHead);

	return 0;
}