using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer.DA;

namespace BusinessLayer.DC
{
    public class BcCategoria
    {
        public DataSet ReadAll()
        {
            return new DcCategoria().ReadAll();
        }
    }
}
