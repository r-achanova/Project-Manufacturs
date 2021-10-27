using Manufacturs.Data;
using System;

namespace Manufacturs
{
    class Program
    {
        static void Main(string[] args)
        {
            ManufacturContext db = new ManufacturContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            Display display = new Display();
        }
    }
}
