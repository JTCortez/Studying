#pragma once

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct node{
	char data;
	struct node *pNext;
}Node;

Node *makeNode (char newData);
void push (Node **pTop, char newData);
void pop(Node **pTop);
char peek(Node *pTop);
unsigned int isEmpty(Node *pTop);
void printStack(Node *pTop);
