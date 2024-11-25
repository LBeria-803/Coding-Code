from turtle import *
import os

setup(900, 900)
setworldcoordinates(0,900,900,0)
penup()
os.chdir("C:\\Users\\Landon Beria\\Pictures")
bgpic("arms.png")

pencolor("red")

def goforward():
    forward(5) 
    
def turnleft():
    left(5)

def turnright():
    right(5)

def draw():
    pendown()

def stopdraw():
    penup()

def giveCoordinates():
    global x, y
    x = xcor()
    y = ycor()
    print(f"{x}, {y}")

onkeypress(giveCoordinates, "x")
onkeypress(goforward, "w")
onkeypress(turnleft, "a")
onkeypress(turnright, "d")
onkeypress(draw, "f")
onkeypress(stopdraw, "e")

listen('x')
listen("w")
listen("a")
listen("d")
listen("f")
listen("e")

mainloop()


