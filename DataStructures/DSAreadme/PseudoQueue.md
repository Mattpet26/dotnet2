# Daily Code Challenge - PseudoQueue

## Perfect Sequence
*Author: Matthew Petersen*

---

### Problem Domain

Implement a Queue while using two Stacks.

---

### Inputs and Expected Outputs
PseudoQueue
| Method | Summary | Example | 
| :-------- | :--------------------- |:----------- |
| Enqueue | Adds a value to the front of the stack. | Enqueue(15) |
| Dequeue | Remove the last value from the stack. | Dequeue() |

---

### Big O


| Time | Space | Method |
| :----------- | :----------- |:----------- |
| O(1) | O(1) | Enqueue |
| O(n) | O(n) | Dequeue |


Enqueue is a simple method, it just pushes the integer to the internal stack. Thus it has a O(1)

Dequeue is slightly more complicated. First the internal stack needs to be flipped, then the value will be popped off the stack. Then we will flip the stack back to return it to its proper orientation.

---


### Whiteboard Visual
***[Your Whiteboard Image]***


---

### Change Log
01/22/2021 - Pseudoqueue created and tests passing

---
