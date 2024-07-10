def is_prime(num):
    if num < 2:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True

def print_primes_up_to(n):
    print(f"{n} gacha bo'lgan tub sonlar:")
    for i in range(2, n + 1):
        if is_prime(i):
            print(i, end=" ")

# n ni kiriting
n = int(input("n ni kiriting: "))
print_primes_up_to(n)
