#pragma once
#include <stdio.h>

typedef struct node{
	int data;
	struct Node *pNext;
}Node;

Node * makeNode(int newData);
void insertAtFront(Node **pHead, int newData);
void printList(Node *pHead);
void removeNode(Node **pHead, int removeData);