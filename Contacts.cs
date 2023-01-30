using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day9PraticeProblemAssignment1
{
    internal class Contacts
    {
        public string firstName;
        private string lastName;
        private string city;
        private string state;
        private double zip;
        private double phoneNumber;

        private bool isMale;

        public void setIsMale(bool y)
        {
            this.isMale = y;
        }
        public bool getIsMale()
        {
            return isMale;
        }



        public string getLastName()
        {
           return lastName; 
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }



        public string getCity()
        {
            return city;
           
        }

        public void setCity(String city)
        {
            this.city = city;
        }
        public  string getState()
        {
            return state;
        }
        public void   setState(String state)
        {
            this.state = state;
        }
        
        public void setzip(double zip)
        {
            this.zip = zip;
        }

        public void setPhoneNumber(double phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }


         public double getZip()
        {
            return zip;
        }
         public double getPhoneNumber()
        {
            return  phoneNumber;
        }






      

     /* public Contacts(string firstName , string lastName, string address,int phoneNumber,string city,string state, int zip,int phonewNumber)
        { 
            this.fisrstName= firstName;
            this.lastName= lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
           

        }*/







    }
}
