# Traditional try-except block
file = open("example.txt", "r")
try:
    # Perform some operations on the file
    data = file.read()
    print(data)
except:
    print("An error occurred while reading the file.")
finally:
    file.close()

# Using a context manager
with open("example.txt", "r") as file:
    # Perform the same operations on the file
    data = file.read()
    print(data)
    
class OpenFile:
    def __init__(self, filename, mode) :
        self.filename = filename
        self.mode = mode

    def _enter__(self):
        self. file = open(self. filename, self .mode)
        return self.file

    def __exit__(self, exc_type, exc_val, traceback):
        self. file. close()


with OpenFile('sample.txt', 'W') as f:
    f.write('Testing')
    
print(f.closed)

f = open("demofile2.txt", "a")
f.write("Now the file has more content!")
f.close()


