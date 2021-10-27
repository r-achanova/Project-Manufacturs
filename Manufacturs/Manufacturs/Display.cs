using Manufacturs.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturs
{
   public class Display
    {
        private int closeOperationId = 9;
        private ManufacturBusiness manufacturBusiness = new ManufacturBusiness();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 18) + "MENU" + new string('-', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Add new department");
            Console.WriteLine("2. Update department");
            Console.WriteLine("3. List of employees by DeparmentId");
            Console.WriteLine("4. List all employees");
            Console.WriteLine("5. Add new employee");
            Console.WriteLine("6. Update employee");
            Console.WriteLine("7. Fetch employee  by ID");
            Console.WriteLine("8. Delete employee  by ID");
            Console.WriteLine("9. Exit");

        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    // case 1: AddDepartment(); break;
                    //  case 2: UpdateDepartment(); break;
                    //  case 3: ListByDeparment();break
                    // case 4: ListAll(); break;
                    // case 5: AddEmployee(); break;
                    // case 6: UpdateEmployee(); break;
                    // case 7: FetchEmployee(); break;
                    // case 8: DeleteEmployee(); break;

                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
    }
}
