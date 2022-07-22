using ConsoleApp2.Data;
using ConsoleApp2.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Consultar();
        }
        static void Consultar()
        {
            using var db = new ApplicationContext();

            
        }
    }
}
