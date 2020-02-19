#include "singlyLinked.h"

int main(void){

	singlyLinked List;


	//cout<<"hi";
	//List.setHead( new Node(0));
	//Node *pHead = nullptr;
	//List.setHead(pHead);
	//List.makeNode(1);

	////List.setHead(1);
	List.insertAtFront(6);
	List.insertAtFront(5);
	List.insertAtFront(4);
	List.insertAtFront(3);
	List.insertAtFront(2);
	List.insertAtFront(1);
	List.insertAtFront(6);
	List.insertAtFront(4);
	List.insertAtFront(3);


	List.printList(List);

	List.removeDups();

	//List.printList(List);

	List.destroyList();

	return 0;
}