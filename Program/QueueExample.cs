using System;
using System.Collections;//required for ArrayList

//it ensures FIFO order when processing employees.
public class Employees{
    public void CreateEmployee(){
        Queue q=new Queue();
        q.Enqueue(100);
        q.Enqueue("ravisankar");
        q.Enqueue("chennai");
        
        q.Dequeue();//remove top of the element
        
        foreach(object type in q){
            Console.WriteLine(type);
        }
    }
}

public class QueueExample{
    public static void Main(String[] args){
        Employees employee = new Employees();
        employee.CreateEmployee();
    }
}