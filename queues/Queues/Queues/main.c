#include "queue.h"

int main(void){

	Queue pQ = {NULL, NULL};
	//Node *pNode;
	int peeked = 0;


	enqueue(&pQ, 1);
	enqueue(&pQ, 2);
	enqueue(&pQ, 3);
	enqueue(&pQ, 4);

	firstOut(&pQ);

	peeked = peek(&pQ);
	printf("%d \n", peeked);

	printQueue(&pQ);

	return 0;
}