using System.IO;
using System;

class Program
{
    Program()
    {
        Console.WriteLine("Constructor called");
    }
    
    ~Program()
    {
        Console.WriteLine("Destructor called");
    }
    
    static void Main(string [] args)
    {
        Console.WriteLine("Main Program");
	Program p= new Program();
        Console.ReadLine();
    }
}

----------------------------------------------------------------------------------------------------


using System.IO;
using System;

public class Customer:IDisposable
{
    private StringReader _reader;
    private bool disposed= false;
    
    public Customer(string value)
    {
        this._reader= new StringReader(value);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if(!disposed)
        {
            if(disposing)
            {
                if(_reader!=null)
                {
                    this._reader.Dispose();
                }
            }
        }
        disposed=true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
 
 class sample
 {
     public static void Main()
    {
        Customer c= new Customer("Sample");
        Console.ReadLine();
    }
}


--------------------------------------------------------------------------------------------


using System;
 
public class FirstInterface
{
    public static void Main(string[] args)
    {
        Car car = new Car(0);
 
        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))
        {
            car.Drive();
        }
    }
 
    public interface Vehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
 
    public class Car : Vehicle
    {
        public int Fuel { get; set; }
 
        public Car(int fuel)
        {
            Fuel = fuel;
        }
 
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("I am driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }
 
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}


----------------------------------------------------------------------------------------------------------



using System.IO;
using System;

public abstract class Animal
{
        private string Name;
        public void SetName(string _name)
        {
            Name=_name;
        }
        public string GetName()
        {
            return Name;
        }
        
        public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog is eating");
    }
}

class Customer
 {
    public static void Main()
    {
        Dog dog = new Dog();
        Console.WriteLine("Enter Dog Name: ");
        string dogname= Console.ReadLine();
        dog.SetName(dogname);
        dog.GetName();
        dog.Eat();
        Console.ReadLine();
    }
}


--------------------------------------------------------------------------------------------------------


using System.IO;
using System;

public class PhotoBook
{
    protected int numPages;
 
    public PhotoBook()
    {
        numPages = 16;
    }
 
    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }
 
    public int GetNumberPages()
    {
        return numPages;
    }
}
    
    public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()
    {
        numPages = 64;
    }
}

public class PhotoBookTest
{
    public static void Main(string [] args)
    {
        PhotoBook photobook1 = new PhotoBook();
        Console.WriteLine("Default PhotoBook Pages: "+photobook1.GetNumberPages());
 
        PhotoBook photobook2 = new PhotoBook(24);
        Console.WriteLine("New PhotBook has: "+photobook2.GetNumberPages()+" pages");
 
        BigPhotoBook BigPhotoAlbum = new BigPhotoBook();
        Console.WriteLine("Big PhotoBook has: "+BigPhotoAlbum.GetNumberPages()+" pages");
        Console.ReadLine();
    }
}

-------------------------------------------------------------------------------------------------------


using System.IO;
using System;

 public class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return Name;
        }
 
        ~Person()
        {
            Name = string.Empty;
        }
    }
    
    public class Class2
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
            Console.ReadLine();
        }
    }
}


------------------------------------------------------------------------------------------------------------


