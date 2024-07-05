son1 = float(input("Birinchi sonni kiriting: "))
son2 = float(input("Ikkinchi sonni kiriting: "))
son3 = float(input("Uchinchi sonni kiriting: "))

if son1 >= son2 and son1 >= son3:
    eng_katta = son1
elif son2 >= son1 and son2 >= son3:
    eng_katta = son2
else:
    eng_katta = son3

if son1 <= son2 and son1 <= son3:
    eng_kichik = son1
elif son2 <= son1 and son2 <= son3:
    eng_kichik = son2
else:
    eng_kichik = son3

print(f"Eng katta son: {eng_katta}")
print(f"Eng kichik son: {eng_kichik}")
