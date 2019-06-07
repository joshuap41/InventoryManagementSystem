using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASoftware1Project
{
    class InHouse : Part    //child of Part
    {
        //includes the instance variable. This also protects the variable. the property represents the protected variable
        public int MachineID { get; set; } 
        
        
        public InHouse(int PartID, String Name, Double Price, int InStock, int Min, int Max, int mID)
            : base(PartID, Name, Price, InStock, Min, Max)
        {
            MachineID = mID;
        }
        
        public InHouse(String Name, Double Price, int InStock, int Min, int Max, int mID)
            : base(Name, Price, InStock, Min, Max)
        {
            MachineID = mID;
        }
    }
}
