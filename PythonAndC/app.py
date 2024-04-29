class FileWriter(object):
    def __init__(self, file_name):
        self.file_name = file_name

    def __enter__(self):
        self.file = open(self.file_name, "r")
        return self.file

    def __exit__(self, exception_type, exception_value, traceback):
        self.file.close()

with FileWriter("test.txt") as file:
    print(file.read())

