using ConsoleApp1.Models;
using ConsoleApp1.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata;

class Program
{
    static async Task Main(string[] args)
    {
        await guardarEstudianteAsync();
    }

    public static async Task guardarEstudianteAsync()
    {
        Console.WriteLine("Guardar Estudiantes desde la clase Repository");

        EstudianteRepository estudianteRepository = new EstudianteRepository();
        Student std = new Student();
        std.Name = "Lola";
        std.LastName = "Perez";
        await estudianteRepository.guardarEstudiante(std);
    }
}