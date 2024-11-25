from turtle import *

speed(10000)


rows = numinput("odd", "Give me an odd number for your row sizes!", default=None, minval=None, maxval=None) 
columns = numinput("odd", "Give me an odd number for your column sizes!", default=None, minval=None, maxval=None) 

left(90) 
startCoordsy = 0
startCoordsx = 0
boxlistx = []
boxlisty = []
boxlistcoords = []
loop = True

def box():
    goto(startCoordsx, startCoordsy)
    pendown()
    forward(50)
    right(90)
    forward(50)
    right(90)
    forward(50)
    right(90)
    forward(50)
    penup()
    right(90)
    boxlistx.append(startCoordsx)
    boxlisty.append(startCoordsy)
    boxlistcoords.append((startCoordsx, startCoordsy))

def action():
    global startCoordsx, startCoordsy
    if rows and columns % 2 == 1:
        for n in range(int(columns)):
            for i in range(int(rows)):
                box()
                startCoordsx = startCoordsx + 50
            startCoordsy = startCoordsy + 50
            startCoordsx = 0
        
    elif rows or columns % 2 == 0:
        write("Give me an odd number!", font=("Comic Sans MS", 40))

def red():
    fillcolor("red")
    pencolor("red")

def orange():
    fillcolor("orange")
    pencolor("orange")

def yellow():
    fillcolor("yellow")
    pencolor("yellow")

def green():
    fillcolor("green")
    pencolor("green")

def blue():
    fillcolor("blue")
    pencolor("blue")

def indigo():
    fillcolor("indigo")
    pencolor("indigo")

def violet():
    fillcolor("purple")
    pencolor("purple")

def color_the_box():
    begin_fill()
    forward(50)
    right(90)
    forward(50)
    right(90)
    forward(50)
    right(90)
    forward(50)
    right(90)
    end_fill()

def colorpicker():
    global rgbBox
    rgbBox = textinput("r=red, o=orange, y=yellow, g=green, b=blue, i=indigo, v=violet", "Give me the color you want in your box!")
    if rgbBox == "r" or "red":
        red()
    elif rgbBox == "o" or "orange":
        orange()
    elif rgbBox == "y" or "yellow":
        yellow()
    elif rgbBox == "g" or "green":
        green()
    elif rgbBox == "b" or "blue":
        blue()
    elif rgbBox == "i" or "indigo":
        indigo()
    elif rgbBox == "v" or "violet":
        violet()

def boxpicker():
    global select
    select = int(numinput("(IN ORDER OF BOXES DRAWN!, FIRST BOX STARTS AT ZERO!)", "Please pick a box you would like to color!", default=None, minval=None, maxval=None))
    goto(boxlistcoords[select])
    color_the_box()

def epic():
    global loop
    while loop == True:
        colorpicker()
        boxpicker()
        if rgbBox or select == "stop":
            loop = False
        else:
            loop = True
    
action()
epic()
mainloop()
