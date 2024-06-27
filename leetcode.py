secret_number = 9
guess = -1 #taxmin



while guess != secret_number:
    guess = int(input("Maxfiy raqamni toping: "))
    if guess < secret_number:
        print("Juda kichik!")
    elif guess > secret_number:
        print("Juda katta!")
    else:
        print("Tabriklaymiz! Siz to'g'ri topdingiz.")
