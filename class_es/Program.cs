using System;
using namespace_name;

class Program
{
    static void Main(string[] args)
    {
        string name="sri";
        int age=22;

        class_name greet= new class_name();
        greet.method_name(name,age);

    }

}
/*
Namespaces - help organize code and prevent naming conflicts.
it helps us call the certain code of lines in the file.

Public - makes classes and methods accessible from other
parts of the program.using public will allow user to access the code. 
public means it is available to public.

Static -  allows methods to be called without an instance 
of the class. it is like constructor(__init__) in python , 
it is called automamtically when the class is called,
 that means it doesnot require ant object to call the class.
 
Void - indicates that a method does not return a value
*/