﻿namespace SF.HW03.Task14_3_3;

public class Contact // модель класса
{
    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }

    public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public override string ToString()
    {
        return $"{Name} {LastName}, {PhoneNumber}, {Email}";
    }
}