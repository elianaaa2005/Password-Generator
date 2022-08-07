import random, string
length = int(input("How long will your password be? "))
char = string.ascii_letters + string.digits + string.punctuation
password = []
for x in range(length):
    password.append(random.choice(char))
print("Your password is " + ''.join(password))
a=input("Press close to exit the program.")
