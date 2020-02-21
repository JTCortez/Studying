#pragma once
#include <stdio.h>

typedef struct node{
	int data;
	struct Node *pNext;
}Node;

typedef struct queue{
	Node *pHead;
	Node *pTail;
}Queue;

//queues (FIFO)-> enqueue, remove, isEmpty, peek
Node * makeNode(int data);
void enqueue(Queue *pQ, int data);
void firstOut(Queue *pQ);
unsigned int isEmpty(Queue *pQ);
int peek(Queue *pQ);
void printQueue(Queue *pQ);