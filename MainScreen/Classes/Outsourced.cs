using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASoftware1Project
{
    class Outsourced : Part     //child of Part
    {
        public String CompanyName { get; set; }


        public Outsourced(int PartID, String Name, Double Price, int InStock, int Min, int Max, String cName) //overload methods
            : base(PartID, Name, Price, InStock, Min, Max)
        {
            CompanyName = cName;
        }

        public Outsourced(String Name, Double Price, int InStock, int Min, int Max, String cName)
            : base(Name, Price, InStock, Min, Max)
        {
            CompanyName = cName;
        }
    }
}
