from tkinter import *
from functools import partial

#gui setup
app = Tk() 
app.geometry('350x100')
app.title("Trash Calculator")

#gui widgets
labelExpression = Label(app,text = "Expression:")
labelExpression.grid(column=0, row=0)

entryField = Entry(app) 
entryField.grid(row=0, column=1)
expressionString = ""

labelPreValue = Label(app,text = "    is Equal:")
labelPreValue.grid(column=2, row=0)

labelValue = Label(app,text = "NULL", fg = "red",font = 16)
labelValue.grid(column=3, row=0)

#func adding the new number into the string
def ExpressionFunc(num,entryField):
    global expressionString #calling a reffrence from the top of the code
    expressionString = expressionString + num
    entryField.insert(END, num)
    print(expressionString)

#func show the final solution 
def EqualFunc(entryField,labelValue):
    global expressionString
    labelValue.config(text= str(eval(expressionString))) #eval change the string into equation then str change it into string
    entryField.delete(0, END) #reseting the text field 
    expressionString =  "" #reseting the string 
    


button1 = Button(app, text=' 1 ', fg='black', bg='red',
                     command= partial(ExpressionFunc, "1", entryField) ,height=1, width=7)
button1.grid(row=3, column=0)

button2 = Button(app, text=' 2 ', fg='black', bg='blue', 
                     command= partial(ExpressionFunc, "2", entryField), height=1, width=7) 
button2.grid(row=3, column=1)

button3 = Button(app, text=' 3 ', fg='black', bg='green', 
                     command=partial(ExpressionFunc, "3", entryField), height=1, width=7) 
button3.grid(row=3, column=2)

button4 = Button(app, text=' 4 ', fg='black', bg='yellow', 
                     command=partial(ExpressionFunc, "4", entryField), height=1, width=7) 
button4.grid(row=2, column=0)

button5 = Button(app, text=' 5 ', fg='black', bg='pink', 
                     command=partial(ExpressionFunc, "5", entryField), height=1, width=7) 
button5.grid(row=2, column=1)

button6 = Button(app, text=' 6 ', fg='black', bg='brown', 
                     command=partial(ExpressionFunc, "6", entryField), height=1, width=7) 
button6.grid(row=2, column=2)

button7 = Button(app, text=' 7 ', fg='black', bg='aqua', 
                     command=partial(ExpressionFunc, "7", entryField), height=1, width=7) 
button7.grid(row=1, column=0)

button8 = Button(app, text=' 8 ', fg='black', bg='orange', 
                     command=partial(ExpressionFunc, "8", entryField), height=1, width=7) 
button8.grid(row=1, column=1)

button9 = Button(app, text=' 9 ', fg='black', bg='silver', 
                     command=partial(ExpressionFunc, "9", entryField), height=1, width=7) 
button9.grid(row=1, column=2)

button0 = Button(app, text=' 0 ', fg='black', bg='white', 
                     command=partial(ExpressionFunc, "0", entryField), height=1, width=7) 
button0.grid(row=3, column=3)

buttonplus = Button(app, text=' + ', fg='black', bg='purple', 
                     command=partial(ExpressionFunc, "+", entryField), height=1, width=7) 
buttonplus.grid(row=1, column=3)

buttonminus = Button(app, text=' - ', fg='black', bg='purple', 
                     command=partial(ExpressionFunc, "-", entryField), height=1, width=7) 
buttonminus.grid(row=1, column=4)

buttondiv = Button(app, text=' / ', fg='black', bg='purple', 
                     command=partial(ExpressionFunc, "/", entryField), height=1, width=7) 
buttondiv.grid(row=2, column=3)

buttonmulti = Button(app, text=' * ', fg='black', bg='purple', 
                     command=partial(ExpressionFunc, "*", entryField), height=1, width=7) 
buttonmulti.grid(row=2, column=4)

buttonequal = Button(app, text=' = ', fg='red', bg='black', 
                     command=partial(EqualFunc, entryField, labelValue), height=1, width=7) 
buttonequal.grid(row=3, column=4)


app.mainloop()
