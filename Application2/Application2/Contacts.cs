using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    // Creating the class to hold the information for the contact list
    public class Contacts
    {
        string firstName;
        string lastName;
        string email;
        string phoneNumber;
        int imageIndex;

        //Setting up the getters and setter for the class fields
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }

            set
            {
                imageIndex = value;
            }
        }
        // Overrriding the toString method so we can get the text correctly on the listview item.
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + PhoneNumber + " " + Email; 
        }


    }

    
}
