using System;
using System.Collections.Generic;//required for generic collection

public class Employees{
    public void CreateEmployee(){
        Dictionary<int,string> dic = new Dictionary<int,string>();
        dic.Add(101,"A1");
        dic.Add(102,"A2");
        dic.Add(103,"A3");
        
        //var to access int and string datatype
        foreach(var type in dic){
            Console.WriteLine(type.Key);
            Console.WriteLine(type.Value);
        }
    }
}

public class DictionaryExample{
    public static void Main(String[] args){
        Employees employee = new Employees();
        employee.CreateEmployee();
    }
}