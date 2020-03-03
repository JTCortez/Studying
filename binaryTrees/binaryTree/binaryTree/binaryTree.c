#include "binaryTree.h"

Node * makeNode(int newData){
	Node *pMem = (Node *) malloc(sizeof(Node));

	pMem->data = newData;
	pMem->pLeft = NULL;
	pMem->pRight = NULL;
	return pMem;
}

void recursiveInsert(Node **pTree, int newData){
	Node *pRoot = *pTree;
	Node *pMem = NULL;
	if (!*pTree){
		pMem = makeNode(newData);
		*pTree = pMem;
	}
	else{
		if (newData < pRoot->data){
			recursiveInsert(&(pRoot->pLeft), newData);
		}
		else if (newData > pRoot->data){
			recursiveInsert(&(pRoot->pRight), newData);
		}
	}
}

void preOrderTraversal(Node **pTree){
	Node *pRoot = NULL;
	if(*pTree){
		pRoot = *pTree;
		printf("%d,", pRoot->data);
		preOrderTraversal(&pRoot->pLeft);
		preOrderTraversal(&pRoot->pRight);
	}

}

void inOrderTraversal(Node **pTree){
	Node *pRoot = NULL;
	if (*pTree) {
		pRoot = *pTree;
		inOrderTraversal(&pRoot->pLeft);
		printf("%d,", pRoot->data);
		inOrderTraversal(&pRoot->pRight);
	}
}

void postOrderTraversal(Node **pTree){
	Node *pRoot = NULL;
	if (*pTree) {
		pRoot = *pTree;
		postOrderTraversal(&pRoot->pLeft);
		postOrderTraversal(&pRoot->pRight);
		printf("%d,", pRoot->data);
	}
}