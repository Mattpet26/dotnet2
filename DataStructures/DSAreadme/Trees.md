# Data Structure - Trees

## Perfect Sequence
*Author: Matthew Petersen*

---

### Problem Domain

Create the following: 
1. Node class that has properties for a value, left and right.
2. Tree class which implements a Node called root.
3. BinaryTree which utilizes traversal methods: Inorder, Postorder, Preorder.
4. BinarySearchTree methods which adds a value to the correct location AND checks if the tree contains a value.

---

### Inputs and Expected Outputs
Binary Tree
| Method | Summary | Example | 
| :-------- | :------------------------------- |:----------------------------------------- |
| InOrder | Returns the tree nodes in left, node, right order. | Tree.InOrder(root, list<int>) |
| PostORder | Returns the tree nodes a left, right node | Tree.PostORder(root, list<int>) |
| PreORder | Returns the tree nodes in a DFS manner | Tree.PreORder(root, list<int>) |

BinarySearchTree
| Method | Summary | Example | 
| :-------- | :--------------------- |:----------- |
| Add | Adds a value to a BST in the correct location | Tree.Add() |
| Contains | Returns a bool based on if the tree contains the input | Tree.Contains(5) |

---

### Big O

BST + Binary Tree Traversal
| Time | Space | 
| :----------- | :----------- |
| O(log(n)) | O(log(n)) |
| O(n) | O(n) | 

BST's have an O(Log(n)) time and space complexity due to the fact that we may have to traverse the entire tree, checking the value of each node.

Binary Trees have an O(n) time and space complexity, each traversal operating like a DepthFirstSearch. We only traverse each node once, adding the value to the list.

---


### Whiteboard Visual
***[Your Whiteboard Image]***
![image](DataStructures/images/idk.PNG)

---

### Change Log
01/29/2021 - Initial upload of Trees!

---
