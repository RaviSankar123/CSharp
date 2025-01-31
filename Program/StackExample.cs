using System;
using System.Collections;//required for Collections

//it allows LIFO order when processing employees.


public class Employees{
    public void CreateEmployee(){
        Stack s=new Stack();
        s.Push(100);
        s.Push("ravisankar");
        s.Push("chennai");
        
        s.Pop();//remove top of the element
        
        foreach(var type in s){
            Console.WriteLine(type);
        }
    }
}

public class StackExample{
    public static void Main(String[] args){
        Employees employee = new Employees();
        employee.CreateEmployee();
    }
}