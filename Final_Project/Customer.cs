using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Customer
    {
        public int Customer_ID;
        public string Customer_FN;
        public string Customer_LN;
        public string Address;
        public int PhoneNumber;
        public Customer(int ID, string firstname, string lastname, string address, int phonenumber)
        {

        }
        public string Type_Of_Reservation;
        public DateTime Date_Of_Reservation;

        public string PetName;
        public int Estimated_Age;
        public string Description_Of_Breed;
        public string Gender;

    }
}
