using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_WebApp.Models
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Email;
        public DateTime B_Date;
        public string Sex;
        public string Country;
        public string City;
        public string Phone_Num; //У тебя int в отчете. Но правильнее будет все-же string сделать
        public string PresentPost;
        public int Salary;
        public string Login;
        public string Password;
    }
}