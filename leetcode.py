#Sonning raqamlari yigʼindisi va necha xonali ekanini aniqlash

n = int(input("n sonni kiriting=>"))
sum_ = 0
count = 0
while n > 0:
    count += 1
    qoldiq = n % 10
    sum_ = qoldiq + sum_*10
    n //=10
    
print(f"sonning teskarisi {sum_} va {count} xonali")