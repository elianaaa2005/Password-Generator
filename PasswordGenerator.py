import random
import string

def generate_password(length, complexity):
    char_sets = {
        1: string.ascii_lowercase,
        2: string.ascii_letters,
        3: string.ascii_letters + string.digits,
        4: string.printable.strip(),
    }
    char_set = char_sets.get(complexity, string.ascii_lowercase)
    password = ''.join(random.choice(char_set) for _ in range(length))
    return password

while True:
    print("Password Generator v1.1")
    while True:
        try:
            length = int(input("How many characters should be in your password? (8-16 characters): "))
            if 8 <= length <= 16:
                break
            print("Please enter a valid number between 8 and 16.")
        except ValueError:
            print("Please enter a valid number between 8 and 16.")

    while True:
        try:
            complexity = int(input('''Please choose the complexity of the password:
1: Only lowercase
2: Lowercase and uppercase
3: Lowercase, uppercase, and numbers
4: Lowercase, uppercase, numbers and symbols
'''))
            if 1 <= complexity <= 4:
                break
            print("Please enter a valid number between 1 and 4.")
        except ValueError:
            print("Please enter a valid number between 1 and 4.")

    password = generate_password(length, complexity)
    print(f"Your generated password is: {password}")

    while True:
        choice = input("Press enter to generate another password, or type 'close' to exit: ")
        if choice.lower() == 'close':
            break
        elif choice:
            print("Please press enter or type 'close'.")
        else:
            break
