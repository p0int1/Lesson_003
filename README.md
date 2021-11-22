Дополнительное Задание 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс Printer.  
В  теле  класса  создайте  метод  void  Print(string  value),  который  выводит  на  экран  значение 
аргумента.  
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове 
соответствующего  метода  их  экземпляра,  строки,  переданные  в  качестве  аргументов  методов, 
выводились разными цветами.  
Обязательно используйте приведение типов.  

Задание 2 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс, представляющий учебный класс ClassRoom.  
Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), 
void Relax().  
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil 
и переопределите каждый из методов, в зависимости от успеваемости ученика.   
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
Выведите  информацию  о  том,  как  все  ученики  экземпляра  класса  ClassRoom  умеют  учиться,  читать, 
писать, отдыхать.  
 
Задание 3 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Vehicle.  
В  теле  класса  создайте  поля:  координаты  и  параметры  средств  передвижения  (цена,  скорость,  год 
выпуска).  
Создайте 3 производных класса Plane, Саг и Ship.  
Для класса Plane должна быть определена высота и количество пассажиров.  
Для класса Ship — количество пассажиров и порт приписки.  
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
 
Задание 4 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс DocumentWorker. 
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().   
В  тело  каждого  из  методов  добавьте  вывод  на  экран  соответствующих  строк:  "Документ  открыт", 
"Редактирование  документа  доступно  в  версии  Про",  "Сохранение  документа  доступно  в 
версии Про".   
Создайте производный класс ProDocumentWorker.  
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных 
форматах доступно в версии Эксперт". 
Создайте  производный  класс  ExpertDocumentWorker  от  базового  класса  ProDocumentWorker. 
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран 
"Документ сохранен в новом формате". 
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
Если  пользователь  не  вводит  ключ,  он  может  пользоваться  только  бесплатной  версией  (создается 
экземпляр  базового  класса),  если  пользователь  ввел  номера  ключа  доступа  pro  и  exp,  то  должен 
создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.  