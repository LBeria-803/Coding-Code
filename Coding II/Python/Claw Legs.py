from turtle import *
 
screensize(900, 900)
speed(0)

def holder():
    pencolor("grey")
    fillcolor("grey")
    begin_fill()
    penup()
    goto(148, -149)
    pendown()
    goto(148, -159)
    goto(-150, -159)
    goto(-150, -149)
    goto(148, -149)
    end_fill()
    hideturtle()

def outerclaws():
    pencolor("darkgrey")
    fillcolor("darkgrey")

holder()
mainloop()