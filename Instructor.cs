using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_122_W23_Lecture_5_Classes
{
    public class Instructor
    {

        // Fields - don't put public
        string _lastName;
        string _firstName;
        string _phone;

        // Constructor
        public Instructor(string lastName, string firstName, string phone)
        {
            // Keyword this
            _lastName = lastName;
            _firstName = firstName;
            _phone = phone;
        }

        // Property

        // How do you define a property?
        // Access Modifier - type of the field - name of the field ( Upper Case ) - No parentheses
        // Two New Keywords
        // Getter and Setter
        // Getter allows the user to READ the value
        // Setter allows the user to WRITE the value

        // Get is used to READ the information, if you ONLY have a get - it's read only

        // Properties are about granting access to fields ( getters and setters )
        public string LastName
        {
            // get
            get
            {
                return _lastName;
            }
            // set
            set
            {
                // This code block runs if the value is not an empty string
                if(value != "")
                {
                    _lastName = value;
                }
                else
                {
                    MessageBox.Show("Please enter a valid last name");
                }
                // Value is the value being assigned by the user
                
            }
       
        } // LastName

        //string firstName;
        //string phone;


        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string FirstName { 
            get => _firstName; 
            set => _firstName = value; 
        }
    }
}
