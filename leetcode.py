number = int(input("Raqam kiriting=>"))
reversedNumber = 0

if number < 0:
    print("Kiritilgan son 0 dan kichik")

while number != 0:
    reversedNumber = reversedNumber*10 + number%10
    number //=10

print(reversedNumber)