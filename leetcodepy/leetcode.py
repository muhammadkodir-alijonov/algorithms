class Todo:
    def __init__(self):
        # Bo'sh todo list yaratamiz
        self.tasks = []

    def add_task(self, task_name):
        # Vazifani ro'yxatga qo'shamiz
        self.tasks.append(task_name)
        print(f"Vazifa qo'shildi: {task_name}")

    def remove_task(self, task_index):
        # Vazifani indeks bo'yicha o'chiramiz
        if 0 <= task_index < len(self.tasks):
            removed_task = self.tasks.pop(task_index)
            print(f"Vazifa o'chirildi: {removed_task}")
        else:
            print("Bunday vazifa yo'q")

    def update_task(self, task_index, new_task_name):
        # Indeks bo'yicha vazifani yangilash
        if 0 <= task_index < len(self.tasks):
            old_task = self.tasks[task_index]
            self.tasks[task_index] = new_task_name
            print(f"Vazifa yangilandi: '{old_task}' -> '{new_task_name}'")
        else:
            print("Bunday vazifa yo'q")

    def show_tasks(self):
        # Barcha vazifalarni ko'rsatish
        if self.tasks:
            print("Todo ro'yxati:")
            for i, task in enumerate(self.tasks, start=1):
                print(f"{i}. {task}")
        else:
            print("Todo ro'yxat bo'sh")

# Todo obyektini yaratish
my_todo = Todo()

# Vazifalar qo'shish
my_todo.add_task("Python darsini o'rganish")
my_todo.add_task("Uy vazifasini bajarish")
my_todo.add_task("Kitob o'qish")

# Barcha vazifalarni ko'rsatish
my_todo.show_tasks()

# 2-vazifani yangilash
my_todo.update_task(1, "Matematika vazifasini bajarish")

# Vazifalarni qayta ko'rsatish
my_todo.show_tasks()

# 1-vazifani o'chirish
my_todo.remove_task(0)

# Qolgan vazifalarni ko'rsatish
my_todo.show_tasks()
