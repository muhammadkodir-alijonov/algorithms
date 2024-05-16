
# Bo'sh array yaratamiz
my_array = []

# Foydalanuvchi tomonidan sonlar kiritish
n = int(input("Qiymatlar sonini kiriting: "))
for i in range(n):
    element = int(input(f"{i+1}-chi qiymatni kiriting: "))
    my_array.append(element)

# Teskari tartibda chiqarish
print("Teskarida chiqarilgan qiymatlar:")
for i in range(len(my_array) - 1, -1, -1):
    print(my_array[i])

