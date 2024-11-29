def min_flips(a, b, c):
    flips = 0
    while a > 0 or b > 0 or c > 0:
        # Har bir sonning o‘ng tarafdagi bitini ajratib olamiz
        bit_a = a & 1
        bit_b = b & 1
        bit_c = c & 1

        # Shartlarni tekshiramiz
        if bit_c == 0:
            flips += bit_a + bit_b  # Ikkalasini ham 0 qilish kerak bo‘lsa
        elif bit_c == 1:
            if bit_a == 0 and bit_b == 0:
                flips += 1  # Hech bo‘lmaganda bittasini 1 qilish kerak

        # Keyingi bitlarga o‘tamiz
        a >>= 1
        b >>= 1
        c >>= 1

    return flips


# Test
a, b, c = 2, 6, 5  # Misol: a=2(010), b=6(110), c=5(101)
print(min_flips(a, b, c))  # Natija: 3
