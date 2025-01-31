/*
Define Vehicle Base Class:
Create a base class named Vehicle to represent general vehicles.
Add properties to the class: Make (string type), Model (string type), and Year (integer type).
Implement a constructor in the Vehicle class to initialize these properties.
Add a virtual method named GetInfo() to display the vehicle's details.
Define Derived Classes:
Create a derived class named Car that inherits from Vehicle.
Create a derived class named Motorcycle that inherits from Vehicle.
Override the GetInfo() method in both derived classes to include specific details (e.g., type of vehicle).
Input Handling:
Use the Console.ReadLine() method to prompt the user to enter the make, model, and year of the vehicle.
Create Instances and Display Information:
Instantiate the Car and Motorcycle classes using the input provided by the user for make, model, and year.
Call the GetInfo() method on each instance to display the vehicle's details.
Instructions:

Write the C# code for the Vehicle base class and the derived Car and Motorcycle classes as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by running it and providing different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Vehicle base class and the derived Car and Motorcycle classes.
Include any additional instructions or notes if necessary.
*/

using System;

class Vehicle
{
    // Define properties
    // Complete Step 1:............
    public string Make;
    public string Model;
    public int Year;

    // Define constructor
    // Complete Step 2:............
    public Vehicle(string Make, string Model, int Year){
        this.Make=Make;
        this.Model=Model;
        this.Year=Year;
    }

    // Define virtual method
    // Complete Step 3:............
    public virtual void GetInfo(){
        
        
        //Console.WriteLine("Vehicle year: "+Year);
    }
}

class Car : Vehicle
{
    // Override GetInfo method
    // Complete Step 4:............
    public Car(string Make, string Model, int Year) : base(Make, Model, Year)
    {
    }
    public override void GetInfo(){
        //Console.WriteLine("Car Information:");
        Console.WriteLine("Car: "+Year+" "+Make+" "+Model);
        //base.GetInfo();
    }
}

class Motorcycle : Vehicle
{
    // Override GetInfo method
    // Complete Step 5:............
    public Motorcycle(string Make, string Model, int Year) : base(Make, Model, Year)
    {
    }
    public override void GetInfo(){
        Console.WriteLine("Motorcycle: "+Year+" "+Make+" "+Model);
        base.GetInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        string carMake, carModel;
        int carYear;

        string motorcycleMake, motorcycleModel;
        int motorcycleYear;

        // Prompt the user to enter vehicle details for Car
        Console.WriteLine("Enter car make:");
        // Complete Step 6:............
        carMake=Console.ReadLine();

        Console.WriteLine("Enter car model:");
        // Complete Step 7:............
        carModel=Console.ReadLine();

        Console.WriteLine("Enter car year:");
        // Complete Step 8:............
        carYear=Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter vehicle details for Motorcycle
        Console.WriteLine("Enter motorcycle make:");
        // Complete Step 9:............
        motorcycleMake=Console.ReadLine();

        Console.WriteLine("Enter motorcycle model:");
        // Complete Step 10:............
        motorcycleModel=Console.ReadLine();

        Console.WriteLine("Enter motorcycle year:");
        // Complete Step 11:............
        motorcycleYear=Convert.ToInt32(Console.ReadLine());

        Car car=new Car(carMake,carModel,carYear);
        car.GetInfo();

        Motorcycle motorcycle=new Motorcycle(motorcycleMake,motorcycleModel,motorcycleYear);
        motorcycle.GetInfo();

        // Create instances of Car and Motorcycle
        // Complete Step 12:............
        

        

        // Display vehicle information
        // Complete Step 13:............
    }
}