# 3 ta son berilgan shu sonlarning yig'indisi eng katta bo'ladigan iktasini chiqaruvchi programa tuzilsin c dastulash tilida 

a = int(input("a sonning kiriting=>"))

b = int(input("b sonning kiriting=>"))

c = int(input("c sonning kiriting=>"))
min_ = 0
max_ = 0
#eng kattasi uchun
if a >= b and a >= c:
    max_ = a
    print(f"katta {max_}")
elif b >= a and b >= c:
    max_ = b
    print(f"katta {max_}")
else:
    print(f"katta {c}")
    
#eng kichigi uchun
if a <= b and a <= c:
    min_ = a
    print(f"kichik {min_}")
elif b <= a and b <= c:
    min_ = b
    print(f"kichik {min_}")
else:
    print(f"kichik {min_}")