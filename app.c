#include <stdio.h>

void findLargestSumPair(int a, int b, int c)
{
    // Uchta sonning har xil kombinatsiyalarini solishtiramiz
    int sum1 = a + b;
    int sum2 = a + c;
    int sum3 = b + c;

    // Eng katta yig'indini aniqlash
    if (sum1 >= sum2 && sum1 >= sum3)
    {
        printf("Eng katta yig'indi: %d va %d\n", a, b);
    }
    else if (sum2 >= sum1 && sum2 >= sum3)
    {
        printf("Eng katta yig'indi: %d va %d\n", a, c);
    }
    else
    {
        printf("Eng katta yig'indi: %d va %d\n", b, c);
    }
}
int main()
{
    int a, b, c;

    // Foydalanuvchidan uchta sonni kiritishni so'raymiz
    printf("Uchta son kiriting (bo'sh joy bilan ajratilgan): ");
    scanf("%d %d %d", &a, &b, &c);

    // Eng katta yig'indini beruvchi ikkita sonni topamiz
    findLargestSumPair(a, b, c);

    return 0;
}