using System;
using System.Collections.Generic;//required for generic collection

public class Employees{
    public void CreateEmployee(){
        List<string> list=new List<string>();
        list.Add("hi");
        list.Add("ravisankar");
        list.Add("chennai");
        
        //list.Reverse();
        list.Sort();
        list.Remove("chennai");
        
        foreach(object type in list){
            Console.WriteLine(type);
        }
    }
}

public class ListExample{
    public static void Main(String[] args){
        Employees employee = new Employees();
        employee.CreateEmployee();
    }
}