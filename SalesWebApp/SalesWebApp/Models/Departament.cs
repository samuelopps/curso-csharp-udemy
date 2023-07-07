using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebApp.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sallers { get; set; } = new List<Seller>();

        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaler(Seller slr)
        {
            Sallers.Add(slr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sallers.Sum(slr => slr.TotalSales(initial, final));
        }
    }
}
