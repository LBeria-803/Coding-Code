word = str(input("What is your word, master?"))
if word.lower() == word[::-1]:
    print("Word is a PALINDROME!")
else:
    print("Word is NOT a PALINDROME!")
