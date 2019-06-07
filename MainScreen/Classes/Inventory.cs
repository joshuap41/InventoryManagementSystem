using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASoftware1Project
{
    static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get => products; set { products = value; } } //property to set the list

        private static BindingList<Part> aPart = new BindingList<Part>();
        public static BindingList<Part> AllParts { get => aPart; set { aPart = value; } } //Property to set the list

        //3
        //This saves the data from "partsDataGridView_CellClick" in MainScreenForm for both Part and Product
        public static Part CurrentPart { get; set; }
        public static int CurrentPartIndex { get; set; }

        public static Product CurrentProduct { get; set; }
        public static int CurrentProductIndex { get; set; }

        public static Part CurrentAssociatedPart { get; set; }
        public static int CurrentAssociatedPartIndex { get; set; }


        #region Product Methods
        public static void AddProduct(Product aProduct)
        {
            Products.Add(aProduct);
        }

        public static bool RemoveProduct(Product aProduct)
        {
            Products.Remove(aProduct);
            return true;
        }

        public static Product LookupProduct(int foundProductIndex)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (Products[i].ProductID.Equals(foundProductIndex))
                {
                    return Products[i];
                }
            }
            return null;
        }

        public static void UpdateProduct(int index, Product product)
        {
            Products[index] = product;
        }
        #endregion




        #region Part Methods
        public static void AddPart(Part aPart)
        {
            AllParts.Add(aPart);
        }

        public static bool DeletePart(Part aPart)
        {
            AllParts.Remove(aPart);
            return true;
        }

        public static Part LookupPart(int foundPartIndex)
        {
            //2
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID.Equals(foundPartIndex))
                {
                    return AllParts[i];
                }
            }
            return null;
        }

        public static void UpdatePart(int index, Part part)
        {
            AllParts[index] = part;
        }
        #endregion
    }
}
