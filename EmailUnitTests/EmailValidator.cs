using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Notes:In addition since the email username needs to have at least 1 if it doesnt then it would start
//with a non alpha character which already markes it wrong. In this case there was no need to test if there was less than one character because if there is non then a non alpha is starting the email.
namespace EmailUnitTests
{
    public class EmailValidator
    {

        public static bool IsValidEmail(string email)
        {
            //checks for null or empty
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            //checks for space
            if (email.Contains(" "))
            {
                return false;
            }

            //checks if email contains @ or .
            if (email.Contains("@") == false || email.Contains(".") == false)
            {
                return false;
            }

            int atSymbolIndex = email.IndexOf('@');
            int dotIndex = email.IndexOf('.', atSymbolIndex);

           

            //checks if @ is before .
            if (atSymbolIndex !> 0 && dotIndex !< atSymbolIndex)
            {
                return false;
            }



            string[] section = email.Split('@');
            string username = section[0];
            string validcharDomain = section[1];
           

            if (email.IndexOf('@', atSymbolIndex +1)!=-1)
            {
                return false;
            }


          

            // makes sure username is not greater than 100 or less than 1
            if (username.Length > 100 )
            {
               
                return false;
            }

            //makes sure domain is not greater than 100 or less than 3
            if (validcharDomain.Length > 100 || validcharDomain.Length < 3)
            {
                return false;
            }



            //makes sure that no alpha characters at the begging or end of an email.
            if (char.IsLetter(email[0]) == false || char.IsLetter(email[email.Length - 1]) == false)
            {
                return false;
            }

            




           //makes sure email can only contain these characters
            string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~@!$%^&*_=+}{\\'?-.";


            foreach (char c in email)
            {
                

                if (validCharacters.Contains(c) == false)
                {
                    return false;
                }
                

          
            }
            




            return true;


        }

        }

    }

