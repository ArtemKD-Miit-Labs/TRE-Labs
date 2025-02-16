correct_password = "secret123"

input_password = input("Введите пароль: ")

if input_password == correct_password:
    print("Доступ разрешен")
else:
    print("Доступ запрещен")

input()