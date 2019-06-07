using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASoftware1Project
{
    public class Product
    {
        public BindingList<Part> associatedParts = new BindingList<Part>(); //list creation

        //if i am dealing with an object, I need to add the "return associatedParts" and the set
        public BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } } //sets the list


        public int ProductID { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int Inv { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int count; //must be static

        public Product(int productID, string name, double price, int inv, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Inv = inv;
            Min = min;
            Max = max;
        }

        public Product(string name, double price, int inv, int min, int max)
        {
            ProductID = count++;
            Name = name;
            Price = price;
            Inv = inv;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part p)
        {
            this.AssociatedParts.Add(p);
        }

        public bool RemoveAssociatedPart(Part p)
        {
            this.AssociatedParts.Remove(p);
            return true;
        }

        public Part LookupAssociatedPart(int foundAssociatedPartIndex)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID.Equals(foundAssociatedPartIndex))
                {
                    return AssociatedParts[i];
                }
            }
            return null;
        }
    }
}
