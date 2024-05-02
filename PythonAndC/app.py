

def my_func(x,y):
    try:
        result = x // y
    except ZeroDivisionError:
        print("Zero division error")
    else:
        print("Result is", result)
    finally:
        print("Finally block")

