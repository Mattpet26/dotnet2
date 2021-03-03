# Depth first

Implement a depth-first traversal on a graph.

## Challenge

Create a function that accepts an adjacency list as a graph, and conducts a depth first traversal.

## Approach & Efficiency

We start at node A, once A is seen it is added to the stack and then popped. Now we add A's children to the stack, B and C. We now check if B has been seen, no it has not, so we pop it and output B. Now we repeat the steps with B, adding its children and checking if they have been seen. This process is continued through the graph until there is nothing left to be seen.

Time:
- O(n)

Space:
- O(n)

## Whiteboard

![whiteboard](../../../resources/CC38.PNG)
