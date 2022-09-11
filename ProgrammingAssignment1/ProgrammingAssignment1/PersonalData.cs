using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        string firstName;
        string middleName;
        string lastName;
        string streetAddress;
        string city;
        string state;
        string postalCode;
        string country;
        string phoneNumber;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                // delete code below and replace with correct code
                return firstName;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                // delete code below and replace with correct code
                return middleName;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                // delete code below and replace with correct code
                return lastName;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                // delete code below and replace with correct code
                return streetAddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                // delete code below and replace with correct code
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                // delete code below and replace with correct code
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                // delete code below and replace with correct code
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                // delete code below and replace with correct code
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                // delete code below and replace with correct code
                return phoneNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here

            StreamReader input = null;

            try
            {
                input = File.OpenText(fileName);

                string csvData = input.ReadLine();
                string[] data = csvData.Split(',');
                firstName = data[0];
                middleName = data[1];
                lastName = data[2];
                streetAddress = data[3];
                city = data[4];
                state = data[5];
                postalCode = data[6];
                country = data[7];
                phoneNumber = data[8];
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            finally
            {
                if (input != null)
                {
                    input.Close();
                }
            }
        }

        #endregion
    }
}
