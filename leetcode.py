# Boshlang'ich va oxirgi qiymatlarni belgilaymiz
start = -10
end = 13

# Manfiy va musbat sonlarning yig'indisini saqlash uchun o'zgaruvchilar
sum_negative = 0
sum_positive = 0

# Joriy qiymatni boshlang'ich qiymatga tenglaymiz
current = start

# While siklini boshlaymiz
while current <= end:
    if current < 0:
        sum_negative += current
    elif current > 0:
        sum_positive += current
    current += 1

# Natijalarni chop etamiz
print("Manfiy sonlar yig'indisi:", sum_negative)
print("Musbat sonlar yig'indisi:", sum_positive)
