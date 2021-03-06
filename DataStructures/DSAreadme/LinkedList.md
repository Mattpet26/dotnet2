# Daily Code Challenge - LinkedList

## Perfect Sequence
*Author: Matthew Petersen*

---

### Problem Domain

Write the following methods that implement a linked list: Insert, Includes, toString, append, insertBefore, insertAfter, kthFromEnd and ziplist.

---

### Inputs and Expected Outputs

| Input | Expected Output | Method | 
| :------------------- | :---------------- |:----------- |
| 1 -> 2 -> null, 5 | 5 -> 1 -> 2 -> null | Insert |
| 1 -> 2 -> null, 5 | true | Includes |
| 1 -> 2 -> null, 5 | "5 -> 1 -> 2 -> NULL" | toString |
| 1 -> 2 -> null, 5 | 1 -> 2 -> -> 5 -> null | Append |
| 1 -> 2 -> 3-> null, 2, 5 | 1 -> 2 -> 5 -> 3 -> null | insertAfter |
| 1 -> 2 -> null, 2, 5 | 1 -> 5 -> 2 -> NULL | insertBefore |
| 1 -> 2 -> 3 -> null, 2 | 2 | kthFromEnd |
| 1 -> 2 null, 3 -> 4 -> null | 1 -> 3 -> 2 -> 4 -> null | ziplist |

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

LinkedLists are pretty simple, they have a head node which can reference a head.next. We can traverse a linkedlist by utilizing a while(head.next != null). This traverses the linkedlist until we hit the last node, because it points to null!

---


### Whiteboard Visual
***[Your Whiteboard Image]***
![whiteboard](../../images/CC6.PNG)
![whiteboard](../../images/CC7.PNG)
![whiteboard](../../images/CC8.PNG)


---

### Change Log
01/18/2021 - Added append, insertBefore, insertAfter. All tests passing!
01/19/2021 - Added kthFromEnd. All tests passing!
1/20/2021 - Added ziplist function. All tests passing.

---
