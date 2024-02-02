using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace usb_util2010
{
    class PathPrefix
    {
        private const int MinimumPortNumber = 1;
        private const int MaximumPortNumber = 203;

        public static void AssignPathPrefixToPort(string pathPrefix, int newPort, bool USB2)
        {
            RegistryKey registryKey = GetCUsbCSequencerKey(USB2, true);
            registryKey.SetValue("PathPrefix" + newPort, pathPrefix);
            UnassignOldPorts(newPort, pathPrefix, USB2, registryKey);
        }

        //Iterate through the CUsbCSequencer subkey and unassign the given port by
        //deleting the key. If 
        public static void UnassignOldPorts(int skipPort, string pathPrefix, bool USB2, RegistryKey CUsbCSequencerSubKey)
        {
            foreach (string name in CUsbCSequencerSubKey.GetValueNames())
            {
                string currentPathPrefix = Convert.ToString(CUsbCSequencerSubKey.GetValue(name));
                if (currentPathPrefix.Equals(pathPrefix))
                {
                    // See if the subkeyname is valid. If it is, return the port number.
                    int portNumber=GetPortFromSubkeyName(name);
                    if (portNumber == skipPort)
                        return;

                    //Delete if pathprefixes match and currentport is not equal to skipPort
                    CUsbCSequencerSubKey.DeleteValue(name);
                }
            }
        }

        //Given a HWPortID/PathPrefix, find the port number it is assigned to on the registry
        public static int FindUSBPortFromRegistry(string pathPrefix, bool USB2)
        {
            RegistryKey CUsbCSequencerSubKey;
            if (USB2)
            {
                CUsbCSequencerSubKey = GetCUsbCSequencerKey(true, false);
            }
            else
            {
                CUsbCSequencerSubKey = GetCUsbCSequencerKey(false, false);
            }
            return FindUSBPortFromRegistryKey(pathPrefix, CUsbCSequencerSubKey);       
        }

        //Returns the correct subkey for CUsbCSequencer or CUsbCSequencer20, depending on 
        //if the programmer is looking for USB 2.0 or USB 1.1
        private static RegistryKey GetCUsbCSequencerKey(bool USB2, bool getWriteAccess)
        {
            RegistryKey returnKey =null;

            try
            {
                if (Registry.LocalMachine.OpenSubKey("SOFTWARE", true).OpenSubKey("Motorola", true) == null)
                    Registry.LocalMachine.OpenSubKey("SOFTWARE", true).CreateSubKey("Motorola", RegistryKeyPermissionCheck.ReadWriteSubTree);

                returnKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true).OpenSubKey("Motorola", true).CreateSubKey("NexTest", RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating the NexTest registry key.  This could be due to a difference between 64 and 32 bit windows.");
                throw new Exception("Registry Exception", ex);
            }
            
            if (getWriteAccess)
            {
                //Create or open subkey for write-access
                if (USB2)
                {
                    returnKey = returnKey.CreateSubKey("CUsbCSequencer20",RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                else
                {
                    returnKey = returnKey.CreateSubKey("CUsbCSequencer",RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
            }
            else
            {
                //Open subkey read only
                if (USB2)
                {
                    returnKey = returnKey.CreateSubKey("CUsbCSequencer20",RegistryKeyPermissionCheck.ReadSubTree);
                }
                else
                {
                    returnKey = returnKey.CreateSubKey("CUsbCSequencer", RegistryKeyPermissionCheck.ReadSubTree);
                }
            }
            return returnKey;
        }

        //Provided a given Path Prefix value and the correct CUsbCSequencer subkey,
        //see if the pathprefix has already been assigned a port and then return the port number.
        //Return -1 if the pathprefix has not yet been assigned to a port.
        private static int FindUSBPortFromRegistryKey(string pathPrefix, RegistryKey CUsbCSequencerSubKey)
        {
            foreach (string name in CUsbCSequencerSubKey.GetValueNames())
            {
                string currentPathPrefix = Convert.ToString(CUsbCSequencerSubKey.GetValue(name));
                if (currentPathPrefix.Equals(pathPrefix))
                {
                    // See if the subkeyname is valid. If it is, return the port number.
                    return GetPortFromSubkeyName(name);
                }
            }

            return 0;
        }

        //Given a string name from the registry, see if it follows the format
        //"PathPrefixX" where is an int from 1 to 21 inclusive. Return X if it is.
        //Return -1 for failures.
        private static int GetPortFromSubkeyName(string PathPrefixName)
        {
            if (PathPrefixName == null)
            {
                //No string passed
                return -1;
            }

            if (PathPrefixName.Length <= "PathPrefix".Length || PathPrefixName.Length > "PathPrefix203".Length)
            {
                //Invalid length
                return -2;
            }

            string trimmedString = PathPrefixName.Substring("PathPrefix".Length);
            try
            {
                int portNumber = Convert.ToInt32(trimmedString);

                if(portNumber<MinimumPortNumber || portNumber > MaximumPortNumber)
                {
                    //PortNumber is outside the allowable range
                    return -1;
                }
                
                return portNumber;
            }
            catch(FormatException e)
            {
                //Name postfix is not a valid integer
                return -1;
            }
            
        }
    }
}
