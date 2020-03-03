#pragma once
#include <stdio.h>

typedef struct node{
	int data;
	struct Node *pLeft;
	struct Node *pRight;

}Node;

Node * makeNode(int newData);
void recursiveInsert(Node **pTree, int newData);
void preOrderTraversal(Node **pTree);
void inOrderTraversal(Node **pTree);
void postOrderTraversal(Node **pTree);