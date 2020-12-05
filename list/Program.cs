using System;
using System.Collections.Generic;
using list.Models;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
	    List<EmployeeEntity> _list = new List<EmployeeEntity>();
            List<EmployeeEntity> _result = new List<EmployeeEntity>();

            Console.WriteLine();
            Console.WriteLine("-Add(new EmployeeEntity() {???})");
	    _list.Add(new EmployeeEntity() { EmployeeID=45, FirstName="shigeru", LastName="yoshida" });
	    _list.Add(new EmployeeEntity() { EmployeeID=61, FirstName="eisaku", LastName="sato" });
	    foreach (EmployeeEntity emp in _list)
	    {
            	Console.WriteLine(emp);
	    }

            Console.WriteLine();
            Console.WriteLine("-FindAll(x => true)");
            _result = _list.FindAll(x => true);
	    Console.WriteLine(String.Join("\n",_result));

            Console.WriteLine();
            Console.WriteLine("-Exists(x => x.EmployeeID==??)");
	    foreach (EmployeeEntity emp in _list)
	    {
            	Console.WriteLine(emp.EmployeeID+": " +_list.Exists(x => x.EmployeeID==emp.EmployeeID));
	    }

            Console.WriteLine();
            Console.WriteLine("-Insert(1, new EmployeeEntity() {???})");
	    _list.Insert(1, new EmployeeEntity() { EmployeeID=58, FirstName="hayato", LastName="ikeda" });
            _result = _list.FindAll(x => true);
	    Console.WriteLine(String.Join("\n",_result));

            Console.WriteLine();
            Console.WriteLine("-RemoveAt(0)");
	    _list.RemoveAt(0);
            _result = _list.FindAll(x => true);
	    Console.WriteLine(String.Join("\n",_result));
        }
    }
}
