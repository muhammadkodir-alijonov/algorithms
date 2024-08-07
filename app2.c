#include <stdio.h>

int main()
{
    // Your code here
    int list1[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int list2[] = {};
    list2 = list1; // Fix: Remove the empty brackets
    list2[0] = 0;
    printf("%d\n salom= %d", list1[0]); // Fix: Replace the empty brackets with the appropriate index or expression
}