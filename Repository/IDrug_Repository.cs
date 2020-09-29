using MailOrderPharmacy_DrugService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrderPharmacy_DrugService.Repository
{
    public interface IDrug_Repository
    {
        DrugDetails searchDrugsByID(int DrugId);
        DrugDetails searchDrugsByName(string Name);

        IEnumerable<DrugLocation> GetDispatchableDrugStock(int DrugId, string Location);
    }
}
