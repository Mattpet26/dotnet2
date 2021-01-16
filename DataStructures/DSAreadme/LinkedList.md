# Daily Code Challenge - LinkedList

## Perfect Sequence
*Author: Matthew Petersen*

---

### Problem Domain

Write the following methods that implement a linked list: Insert, Includes and toString.

---

### Inputs and Expected Outputs

| Input | Expected Output | Method | 
| :----------- | :----------- |:----------- |
| 1 -> 2 -> null, 5 | 5 -> 1 -> 2 -> null | Insert |
| 1 -> 2 -> null, 5 | true | Includes |
| 1 -> 2 -> null, 5 | "5 -> 1 -> 2 -> NULL" | toString |
---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

LinkedLists are pretty simple, they have a head node which can reference a head.next. We can traverse a linkedlist by utilizing a while(head.next != null). This traverses the linkedlist until we hit the last node, because it points to null!
---


### Whiteboard Visual
***[Your Whiteboard Image]***
![Image 1](../../images/CC5.PNG)


---

### Change Log
No current changes at this time.  

---
