using System;
using System.Collections;//required for ArrayList

public class Employees{
    public void CreateEmployee(){
        ArrayList arrayList = new ArrayList();//non generic
        arrayList.Add(100);
        arrayList.Add("ravisankar");
        arrayList.Add("akshit");
        
        arrayList.Remove(100);
        arrayList.RemoveAt(1);//index
        arrayList[0]="Anbu";//update
        
        for(int i=0; i<arrayList.Count; i++){
            Console.WriteLine(arrayList[i]);
        }
    }
}

public class ArrayListExample{
    public static void Main(String[] args){
        Employees employee = new Employees();
        employee.CreateEmployee();
    }
}