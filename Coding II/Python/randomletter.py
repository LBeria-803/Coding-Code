import random

word = int(input('Give me the amount of words you want in your word!'))

letters = [
    'a',
    'b',
    'c',
    'd',
    'e',
    'f',
    'g',
    'h',
    'i',
    'j',
    'k',
    'l',
    'm',
    'n',
    'o',
    'p',
    'q',
    'r',
    's',
    't',
    'u',
    'v',
    'w',
    'x',
    'y',
    'z'
]

finalword = ''
while word>0:
    letter = random.choice(letters)
    finalword = finalword + letter
    word = word - 1

print(f'Here is your word: {finalword}')
