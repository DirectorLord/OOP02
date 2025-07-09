namespace OOP02
{
    using System;
    using System.Runtime.CompilerServices;
    using static OOP02.Program;

    public class Program
    {
        #region Question2
        //Develop a Class to represent the Hiring Date Data
        public class HiringDate
        {
            private int day; private int month; private int year;
            //the constructor
            public HiringDate(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            #region Setters and getters for date
            #region day
            public int getDay() { return day; }
            public void setDay(int day) { this.day = day; }
            #endregion

            #region month
            public int getMonth() { return month; }
            public void setMonth(int month) { this.month = month; }
            #endregion

            #region year
            public int getYear() { return year; }
            public void setYear(int year) { this.year = year; }
            #endregion

            #endregion

        }
        #endregion
        #region Question3
        //Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
        public string[] securityPrivileges = { "Guest", "DBA", "Secuirty officer" };
        #endregion

        #region Question1
        //Design and implement a Class for the employees in a company:
        public class Employee
        {
            //the attributes
            private int id; private string name; private char gender; private string securityLevel; private double salary; private HiringDate hireDate;
            //the constructor
            public Employee(int id, string name, char gender, string securityLevel, double salary, HiringDate hireDate)
            {
                this.id = id;
                this.name = name;
                this.gender = gender;
                this.securityLevel = securityLevel;
                this.salary = salary;
                this.hireDate = hireDate;
            }
            //setters and getters

            #region Setters and getters
            #region Setter and getter for ID
            public int getId() { return id; }
            public void setId(int id) { this.id = id; }
            #endregion

            #region Setter and getter for name
            public string getName() { return name; }
            public void setName(string name) { this.name = name; }
            #endregion

            #region Setter and getter for Gender
            public char getGender()
            { return gender; }
            public void setGender(char gender) { this.gender = gender; }
            #endregion

            #region Security level setter and getter
            public string getSecurityLevel() { return securityLevel; }
            public void setSecurityLevel(string securityLevel) { this.securityLevel = securityLevel; }
            #endregion

            #region Setter and getter for salary
            public double getSalary() { return salary; }
            public void setSalary(double salary) { this.salary = salary; }
            #endregion

            #region setter and getter for hiringdate
            public HiringDate getHireDate() { return hireDate; }
            public void setHireDate(HiringDate hireDate) { this.hireDate = hireDate; }
            #endregion 
            #endregion
            //to return the employee information
            public override string ToString()
            {
                return $"ID: {id}, Name: {name}, Gender: {gender}, Security Level: {securityLevel}, Salary: {salary}, Hire Date: {hireDate}";
            }
            

        }
        #endregion

        
        public static void Main(string[] args)
        {
            //creating the actual array here
            Employee[] emprr = new Employee[3];
            //creating the employees
            emprr[0] = new Employee(1, "alice in a wonderland", 'F', "DBA", 5500, new HiringDate(15, 3, 2020));
            emprr[1] = new Employee(2, "nick wilde", 'M', "Guest", 3500, new HiringDate(20, 6, 2021));
            emprr[2] = new Employee(3, "Jessie", 'M', "Security Officer", 5000, new HiringDate(10, 1, 2019));
            //printing the employees
            foreach (var emp in emprr)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }


}