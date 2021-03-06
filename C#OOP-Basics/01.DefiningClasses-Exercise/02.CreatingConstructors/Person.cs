﻿using System;

public class Person
{
    private string name;
    private int age;

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
        : this()
    {
        this.age = age;
    }

    public Person(string name, int age) : this(age)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
    }

    public int Age
    {
        get { return this.age; }
    }
}