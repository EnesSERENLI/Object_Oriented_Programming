## Inheritance

* It means we can add additional properties to an existing class without changing it. This improves reusability.
* A class inherits from only one class, but can inherit as much as it wants.
* When this is done, all the properties of the base class are transferred to the new class.

```
public class BaseClass
{
    public int ID { get; set; }
    public string Name { get; set; }
}

public class ChildClass : BaseClass //Inheritance process
{
}
```
