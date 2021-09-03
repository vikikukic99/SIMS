using SIMS2021.Model;
using SIMS2021_wpf.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Service
{
    public class BillService : BaseService<Bill>
    {
        public BillService() 
        {
            repository = new BillRepository();
        }
    }
}
