## Class

* A class is a comprehensive code combination of objects. In OOP (Object Oriented Programming), the object is the small building block that contains the properties of the class. So when we write a class, we gather the properties and methods of various objects together.
## Constructor

### To briefly mention constructor methods, it is the process of assigning values to properties in a non-static class during the instance of the class.
* Every class has an exception constructor.
* If you want to manipulate the constructor in a class, you can do this by creating a method with the same name as the class name.
* Constructors do not return values.

## Overloading

* Overloading is the structure that allows the method structures that we have created in our applications to be rewritten, to gain flexibility and to switch to a more functional structure, and to create our method with more than one parameter with the same name.
```
public class Baby
{

public Baby () //Constructor I  (Constructor snippet => ctor+tab+tab)
{
BirthDate = DateTime.Now;
}

public Baby (string motherName) //Constructor II (overload)
{
BirthDate = DateTime.Now;
MotherName = motherName;
}

public Baby (string motherName,string fatherName) //Constructor III (overload)
{
BirthDate = DateTime.Now;
MotherName = motherName;
FatherName = fatherName;
}

//Property snippet => prop+tab+tab
public string MotherName { get; set; }
public string FatherName { get; set; }
public DateTime BirthDate { get; set; }
}
```
## Object Initializer (Nesne Oluşturucu)

* We can also create an object without a constructor.
```
Baby baby = new Baby {MotherName = "Ayşe",FatherName ="Ahmet",BirthDate=DateTime.Now };
```
