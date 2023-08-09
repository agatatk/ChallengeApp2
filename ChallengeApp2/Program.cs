using ChallengeApp2;


  Employee employee1 = new Employee("Adam", "Kowalski", 25);
  Employee employee2 = new Employee("Agata", "Badach", 40);
  Employee employee3 = new Employee("Zuzia", "Różdżka", 37);

  employee1.AddScore(4);
  employee1.AddScore(5);
  employee1.AddScore(6);
  employee1.AddScore(9);
  employee1.AddScore(1);

  employee2.AddScore(2);
  employee2.AddScore(3);
  employee2.AddScore(9);
  employee2.AddScore(1);
  employee2.AddScore(7);

  employee3.AddScore(2);  
  employee3.AddScore(8);
  employee3.AddScore(4);
  employee3.AddScore(6);
  employee3.AddScore(5);

 var result1 = employee1.Result;
 var result2 = employee2.Result;
 var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
  { 
    employee1, employee2, employee3
  };

  int maxResult = -1;
  Employee? employeeWithMaxResult = null;


  foreach (var employee in employees)
  {
       if (employee.Result > maxResult)
       {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
       }
  }

Console.WriteLine("Pracownik - " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ",wiek" + employeeWithMaxResult.Age + ", "  + employeeWithMaxResult.Result+  " punktów");