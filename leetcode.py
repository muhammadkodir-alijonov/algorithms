x1 = int(input("x1 kordinatani kiriting: "))
y2 = int(input("y1 kordinatani kiriting: "))
x2 = int(input("x2 kordinatani kiriting: "))
y1 = int(input("y2 kordinatani kiriting: "))
z1 = x1 + y1
z2 = x2 + y2

if x1 < 9 and y1 < 9 and x2 < 9 and y2 < 9 and z1 % 2 !=0 and z2 % 2!=0:
    print("Oq")
else:
    print("Qora")
if x1 < 9 and y1 < 9 and x2 < 9 and y2 < 9 and z1 % 2 ==0:
    print("x1 va y1 Qora katakda")
if x1 < 9 and y1 < 9 and x2 < 9 and y2 < 9 and z2 % 2 ==0:
    print("x2 va y2 Qora katakda")
if x1 < 9 and y1 < 9 and x2 < 9 and y2 < 9 and z1 % 2 !=0:
    print("x1 va y1 Oq katakda")
if x1 < 9 and y1 < 9 and x2 < 9 and y2 < 9 and z2 % 2 !=0:
    print("x2 va y2 Oq katakda")