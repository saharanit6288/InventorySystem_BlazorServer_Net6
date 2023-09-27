using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Activities.Interfaces
{
    public interface IPurchaseInventoryUseCase
    {
        Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string doneBy);
    }
}
