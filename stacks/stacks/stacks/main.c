#include "Stack.h"

int main(void){

	Node *pHead = NULL;
	char str[] = "swag";

	for (int i = 0; str[i] != '\0'; ++i){
		push (&pHead, str[i]);
	}

	printStack(pHead);

	return 0;
}