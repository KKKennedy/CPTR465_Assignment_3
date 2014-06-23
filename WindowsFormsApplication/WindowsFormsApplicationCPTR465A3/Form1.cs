using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientAccountPackage;


namespace WindowsFormsApplicationCPTR465A3
{
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
        }

        private void ButtonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                String TRN = TextBoxTRN.Text.ToString();
                String FirstName = TextBoxFirstName.Text.ToString();
                String LastName = TextBoxLastName.Text.ToString();
                String Branch = TextBoxBranch.Text.ToString();
                String AccountType = ComboBoxAccount.Text.ToString();
                Double CurrentBalance = Convert.ToDouble(TextBoxTRN.Text.ToString());


                ClientAccount.addClient(TRN, FirstName, LastName, Branch, AccountType, CurrentBalance);

               
               
            }
            catch (TypeInitializationException ex) {

                Exception x = ex.InnerException;
                while (x is TypeInitializationException) {

                    x = x.InnerException;
                               
             }
                MessageBox.Show(x.StackTrace + x.Message);
               
            }



        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
          
            try
            {
                String TRN = TextBoxTRNSearch.Text.ToString();
                
                ClientAccount[] clientArray = new ClientAccount[1];

                Array.Copy (ClientAccount.getClient(TRN), clientArray, 1);

       
               
            }
            catch (TypeInitializationException ex) {

                Exception x = ex.InnerException;
                while (x is TypeInitializationException) {

                    x = x.InnerException;
                               
             }
                MessageBox.Show(x.StackTrace + x.Message);
               
            }

        }

        private void ButtonShowAllClients_Click(object sender, EventArgs e)
        {
                try
            {
                
                
                ClientAccount[] clientArray = new ClientAccount[ClientAccount.getAllClients().Length];

                Array.Copy (ClientAccount.getAllClients(), clientArray, 1);

       
               
            }
            catch (TypeInitializationException ex) {

                Exception x = ex.InnerException;
                while (x is TypeInitializationException) {

                    x = x.InnerException;
                               
             }
                MessageBox.Show(x.StackTrace + x.Message);
               
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
             try
            {
                String TRN = TextBoxTRNDelete.Text.ToString();
                
               ClientAccount.deleteClient(TRN);

       
               
            }
            catch (TypeInitializationException ex) {

                Exception x = ex.InnerException;
                while (x is TypeInitializationException) {

                    x = x.InnerException;
                               
             }
                MessageBox.Show(x.StackTrace + x.Message);
               
            }
        
        }
        
    
    }

       
    }

