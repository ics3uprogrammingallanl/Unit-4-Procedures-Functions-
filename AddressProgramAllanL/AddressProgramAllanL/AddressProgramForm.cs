/*
 * Created by: Allan L
 * Created on: April 30, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Address Program
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullNameAllanL
{
    public partial class frmAddressProgram : Form
    {

        //variables
        String userAptNum;
        String userAddress;
        String userCity;
        String userProvince;
        String userPostalCode;

        public frmAddressProgram()
        {
            InitializeComponent();
        }

        public void PrintInformation(String aptNum, String address, String city, String province, String postalCode)
        {
            //display information
            MessageBox.Show("Apt Number: " + aptNum + ", Address: " + address + ", City: " + city + ", Province: " + province + ", Postal Code: " + postalCode, "Information Program");
        }

        public void PrintInformation(String address, String city, String province, String postalCode)
        {
            //display information
            MessageBox.Show("Address: " + address + ", City: " + city + ", Province: " + province + ", Postal Code: " + postalCode, "Information Program");
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            //get the users inputs
            userAptNum = txtAptNum.Text;
            userAddress = txtAddress.Text;
            userCity = txtCity.Text;
            userProvince = txtProvince.Text;
            userPostalCode = txtPostCode.Text;

            //check to see if they haven't entered something
            if (userAddress == "")
            {
                MessageBox.Show("Please enter your address", "Information Program");
            }
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your city", "Information Program");
            }
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your city", "Information Program");
            }
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your Postal Code", "Information Program");
            }
            else if (userAptNum == "")
            {
                PrintInformation(userAddress, userCity, userProvince, userPostalCode);
            }
            else
            {
                PrintInformation(userAptNum, userAddress, userCity, userProvince, userPostalCode);
            }
        }
    }
}
