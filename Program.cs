using System;
using _teste01.Models;

System.Console.WriteLine("hello23");

// Primeira Clinica

Clinica c1 = new Clinica();
Clinica.InstanceCount = 1;
c1.ObjectCount = 1;

// Segunda Clinica
Clinica c2 = new Clinica();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

System.Console.WriteLine($"Valor C1: {c1.ObjectCount}");
System.Console.WriteLine($"Instance Count: {Clinica.InstanceCount}");
System.Console.WriteLine($"Valor C2: {c2.ObjectCount}");