using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public static class TextProcessor
    {
        ///<summary>
        ///<para>Takes a password as a string and a label to modify it's text to show an error about the password</para>
        ///<para>checks if it's longer than 6 characters , has digits , has symbols</para>
        ///</summary>
        public static bool CheckPassword(string pass, Label label)
        {
            Password password= new Password(pass);
            if (!password.iscorrect) 
            {
                SystemSounds.Beep.Play();
                label.Visible= true;
                if (!password.hasDigits) { label.Text = "Your password should have at least one digit"; }
                if (!password.hasSymbols) { label.Text= "Your password should have at least one symbol"; }
                if (!password.isLong) { label.Text = "Your password should be at least 6 characters long"; }
                return false;
            }
            else
            {
                label.Visible= false;
                return true;
            }
        }
        /// <summary>
        /// <para>Takes a username as an input and a label to modify it's text to show an error</para>
        /// <para>only checks if username is longer than 5 characters</para>
        /// </summary>
        /// <param name="user"></param>
        /// <param name="label"></param>
        public static bool CheckUsername(string user, Label label)
        {
            if (!(user.Length >= 5)) { label.Text = "Your username should be at least 5 characters long"; label.Visible = true;SystemSounds.Beep.Play();return false; }
            else { label.Visible = false;return true; }
        }
    }
}
