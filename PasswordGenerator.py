import random, string
import os
import time
loopCode = True
loopCode2 = True

while loopCode == True:
    try:
        print('''Password Generator v1.1
    ''')
        length = int(input('''How many characters should be in your password?
A length between 8-16 characters is recommended:
'''))
    except ValueError:
        print("This is not a valid number, please try again.")
        time.sleep(2)
        os.system('cls' if os.name == 'nt' else 'clear')
        continue
    
    while loopCode2 == True:
        try:
            print ("")
            userDecision = int(input('''Please choose the complexity of the password.
It is recommended to have a mix of character types in your password:

1: Only lowercase
2: Lowercase and uppercase
3: Lowercase, uppercase, and numbers
4: Lowercase, uppercase, numbers and symbols
'''))
        except ValueError:
            print('''
Something went wrong, please ensure you are entering a valid number.''')
            time.sleep(2)
            os.system('cls' if os.name == 'nt' else 'clear')
            continue
    
        if userDecision == 1:
            char = string.ascii_lowercase
            password = []
            for x in range(length):
                password.append(random.choice(char))
            print("")
            print("Your generated password is " + ''.join(password))
            break
        
        elif userDecision == 2:
            char = string.ascii_lowercase + string.ascii_uppercase
            password = []
            for x in range(length):
                password.append(random.choice(char))
            print("")
            print("Your generated password is " + ''.join(password))
            break
        
        elif userDecision == 3:
            char = string.ascii_lowercase + string.ascii_uppercase + string.digits
            password = []
            for x in range(length):
                password.append(random.choice(char))
            print("")
            print("Your generated password is " + ''.join(password))
            break
        
        elif userDecision == 4:
            char = string.ascii_lowercase + string.ascii_uppercase + string.digits + string.punctuation
            password = []
            for x in range(length):
                password.append(random.choice(char))
            print("")
            print("Your generated password is " + ''.join(password))
            break
        
        else:
            print('''
Something went wrong, ensure you are entering a valid number.''')
            time.sleep(2)
            os.system('cls' if os.name == 'nt' else 'clear')

    print("")
    input('''Press enter if you wish to generate another password.
Alternatively, press close to exit the program.
''')
    oos.system('cls' if os.name == 'nt' else 'clear')

