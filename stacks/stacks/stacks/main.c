#include "Stack.h"

int main(void){

	Node *pHead = NULL;
	char str[] = "swag";

	char min = 0;

	reverseString(&pHead, str);

	printStack(pHead);

	pHead = NULL;
	printf("-----MIN NODE-----\n");
	
	push(&pHead, '4');
	push(&pHead, '2');
	push(&pHead, '7');
	push(&pHead, '3');
	push(&pHead, '1');
	push(&pHead, '7');
	push(&pHead, '3');
	
	printStack(pHead);

	min = minStack(&pHead, peek(pHead));
	printf("MIN: %c", min);

	return 0;
}