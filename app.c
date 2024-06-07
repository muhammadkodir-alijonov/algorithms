#include <stdio.h>

// Funksiya: Uchta sondan eng kichigi va eng kattasini topish
void findMinMax(int a, int b, int c)
{
    int min, max;

    // Eng kichik sonni topish
    if (a <= b && a <= c)
    {
        min = a;
    }
    else if (b <= a && b <= c)
    {
        min = b;
    }
    else
    {
        min = c;
    }

    // Eng katta sonni topish
    if (a >= b && a >= c)
    {
        max = a;
    }
    else if (b >= a && b >= c)
    {
        max = b;
    }
    else
    {
        max = c;
    }

    printf("Eng kichik son: %d\n", min);
    printf("Eng katta son: %d\n", max);
}

int main()
{
    int a, b, c;

    // Foydalanuvchidan uchta sonni kiritishni so'raymiz
    printf("Uchta son kiriting (bo'sh joy bilan ajratilgan): ");
    scanf("%d %d %d", &a, &b, &c);

    // Eng kichik va eng katta sonni topamiz
    findMinMax(a, b, c);

    return 0;
}
