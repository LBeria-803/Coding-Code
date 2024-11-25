# Understanding Python Operators
# Goal: Count the number of digits in a given number
# //=
# //
def countDigits(num):
    num = abs(num)
    digitCount = 0
    while num != 0:
        num //= 10 # num = num // 10
        digitCount += 1
    return digitCount

n1 = int(input("Your Number, Sire? "))

print(f"There are {countDigits(n1)} digits in {n1} Sire!")