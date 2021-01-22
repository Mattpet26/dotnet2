# Daily Code Challenge - Stacks and Queues

## Perfect Sequence
*Author: Matthew Petersen*

---

### Problem Domain

Write the following methods that implement a Stack : isEmpty, Pop, Push and Peek
Write the following methods that implement a Queue : isEmpty, Enqueue, Dequeue and Peek.

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

Stacks and Queues are great. They both operate very similiar, but with slight differences. Stacks utilize a LIFO or Last in first. While Queue utilizes FIFO or First in first out. 

---


### Whiteboard Visual
***[Your Whiteboard Image]***


---

### Change Log
01/22/2021 - Start of stacks and queues

---
