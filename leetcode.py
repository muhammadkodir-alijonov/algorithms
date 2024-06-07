

def shoh_yurish(x1, y1, x2, y2):
    return abs(x2 - x1) <= 1 and abs(y2 - y1) <= 1

x1 = int(input("x1 kordinatani kiriting: "))
y2 = int(input("y1 kordinatani kiriting: "))
x2 = int(input("x2 kordinatani kiriting: "))
y1 = int(input("y2 koxlrdinatani kiriting: "))
# Natijani tekshirish
print(shoh_yurish(x1, y1, x2, y2))
    