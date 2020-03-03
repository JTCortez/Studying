#include "binaryTree.h"

int main(void){

	Node *pTree = NULL;

	recursiveInsert(&pTree, 5);
	recursiveInsert(&pTree, 3);
	recursiveInsert(&pTree, 7);
	recursiveInsert(&pTree, 1);
	recursiveInsert(&pTree, 2);
	recursiveInsert(&pTree, 6);
	recursiveInsert(&pTree, 8);
	recursiveInsert(&pTree, 9);

	preOrderTraversal(&pTree);
	printf("\n");
	inOrderTraversal(&pTree);
	printf("\n");
	postOrderTraversal(&pTree);
	printf("\n");

	return 0;
}