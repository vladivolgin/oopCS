# oopCS

В этом репозитории собраны задания, предложенные на курсе ![image](https://user-images.githubusercontent.com/87894035/151812209-e8457968-fd43-4d1e-bceb-07cac0335db6.png) по изучению Объектно-ориентированного программирования на языке C# .

# Задание Bank
Это задание было направленно на изучение работы классов в ООП.
Содержание задания :
1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип). Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.
# Задание Zdanie
Это задание было направленно на изучение модификаторов доступа и инкапсуляции в ООП .
Содержание задания : 
1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.

Основной код программы :

![image](https://user-images.githubusercontent.com/87894035/152641787-d742fcd2-0067-4d58-9e96-7de494512600.png)![image](https://user-images.githubusercontent.com/87894035/152641819-16613b61-61fc-4ade-8221-72ea0a18dac7.png)
![image](https://user-images.githubusercontent.com/87894035/152641831-61b5a600-aa4c-409c-8341-97c008feadb9.png)

Решение было реализованно с помощью пяти классов .
