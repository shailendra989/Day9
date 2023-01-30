using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9PraticeProblemAssignment1
{
    internal class AddressBookManagementSystem
    {
        List<Contacts> contacts ;

        public void addContacts(Contacts c)
        {
            if(contacts==null)
            {
                contacts = new List<Contacts>(); 
            }
            this.contacts.Add(c);

        }

        public void deleteContact(string name)
        {
            for(int i =0; i < contacts.Count; i++)
            {
                if (contacts[i].firstName == name)
                {
                    contacts.Remove(contacts[i]);
                    break;
                }
            }

        }


        public  List<Contacts> getContacts()
        {
            return contacts;

        }
         
    }
}
