# 7.Custom List

Create a generic data structure that can store **any** type that **can** be compared. Implement functions:

- **void Add(T element)**
- **T Remove(int index)**
- **bool Contains(T element)**
- **void Swap(int index1, int index2)**
- **int CountGreaterThan(T element)**
- **T Max()**
- **T Min()**

Create a command interpreter that reads commands and modifies the custom list that you have created. Set the custom list&#39;s type to string. Implement the commands:

- **Add \&lt;element\&gt;** - Adds the given element to the end of the list
- **Remove \&lt;index\&gt;** - Removes the element at the given index
- **Contains \&lt;element\&gt;** - Prints if the list contains the given element **(True or False)**
- **Swap \&lt;index\&gt; \&lt;index\&gt;** - Swaps the elements at the given indexes
- **Greater \&lt;element\&gt;** - Counts the elements that are greater than the given element and prints their count
- **Max** - Prints the maximum element in the list
- **Min** - Prints the minimum element in the list
- **Print** - Prints all of the elements in the list, each on a separate line
- **END** - stops the reading of commands

There will **not** be any **invalid** input commands.

### Examples

| **Input** | **Output** |
| --- | --- |
| Add aaAdd bbAdd ccMaxMinGreater aaSwap 0 2Contains aaPrintEND | ccaa2Trueccbbaa    |