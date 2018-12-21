using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace nameAndAddressShelll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<nameAndAddress> listOfNames = new List<nameAndAddress>();


        public MainWindow()
        {
            InitializeComponent();
            txtFirstName.Focus();
            stateList st = new stateList();
            foreach (stateList state in st.buildStateList())
            {
                cmbState.Items.Add(state.stateCode + "," + state.stateName);
            }
        }

        /* ------------- Events Below  ----------------*/

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // The data grid is refresh every time the save button is clicked, 
            // before we retrive information from the list.
           dataGrid1.Items.Clear();
           dataGrid1.Items.Refresh();
            initializer();
            

        }

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtState.Text = stateInitial();
        }

        private void txtState_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtState.IsReadOnly = true;
        }


        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtPhone.Text = phoneNumber();
        }

        private void txtFirstName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var fName = sender as TextBox;
            fName.MaxLength = 10;
            e.Handled = Regex.IsMatch(e.Text, "[^a-zA-Z]+");
        }

        private void txtLastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var lName = sender as TextBox;
            lName.MaxLength = 10;
            e.Handled = Regex.IsMatch(e.Text, "[^a-zA-Z]+");
        }

        private void txtCity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var cityTBox = sender as TextBox;
            cityTBox.MaxLength = 20;
            e.Handled = Regex.IsMatch(e.Text, "[^a-zA-Z]+");
        }

        private void txtPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var phoneTBox = sender as TextBox;
            phoneTBox.MaxLength = 15;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void txtZipCode_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var zipTBox = sender as TextBox;
            zipTBox.MaxLength = 5;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void TxtXML_Click(object sender, RoutedEventArgs e)
        {
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "temp.xml";
            string outPut = myPath + "\\" + fileName;
            foreach (nameAndAddress list in listOfNames)
            {
                writeTextXML(list, outPut);
            }
            txtErrorMessage.Text = "XML file is located at " + outPut;
        }

        // Creates a string builder sb to append attributes from listOfNames. 
        // Strinbuilder sb is passed as an argument to writeText
        private void txtFile_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (nameAndAddress people in listOfNames)
            {
                sb.Append(people.firstName);
                sb.Append(" ");
                sb.Append(people.lastName.Trim());
                sb.Append(";");
                sb.Append(people.address.Trim());
                sb.Append(";");
                sb.Append(people.city);
                sb.Append(", ");
                sb.Append(people.state.Trim());
                sb.Append(" ");
                sb.Append(people.zipCode.Trim());
                sb.Append(";");
                sb.Append(people.phoneNumber.Trim());
                sb.Append(";");
                sb.Append(";");
            }
            writeText(sb.ToString());
        }

  



        /* -------- METHODS BELOW ----------- */

        // Extracts and returns the state code based
        // on what the user has selected from the combobox
        private string stateInitial()
        {
            // retrives the state code using substring method
            //int startIndex = 0;
            //int length = 2;
            // string codeState = cmbState.SelectedItem.ToString().Substring(startIndex, length);

            // retrives the statecode using the split method
            string[] stateCodeSplit;
            stateCodeSplit = cmbState.SelectedItem.ToString().Split(',');
            return stateCodeSplit[0];
        }

        // Method that formats phone number input to American style phone numbers.
        private string phoneNumber()
        {
            validateStuff phoneNumber = new validateStuff();
            string formatttedNumber = phoneNumber.FormatPhoneNumber(txtPhone.Text);
            return formatttedNumber;
        }

        // Method that takes input from the user,
        // saves the input into a list,
        // Sorts and displays the list
        public void initializer()
        { 
            listOfNames.Add(new nameAndAddress()
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                address = txtAddress.Text,
                city = txtCity.Text,
                state = txtState.Text,
                zipCode = txtZipCode.Text,
                phoneNumber = txtPhone.Text,

            });

            listOfNames.Sort();
            
            foreach (nameAndAddress person in listOfNames)
            {
                dataGrid1.Items.Add(person);
            }                     
        }

        // A method that creates a text file and places that text file in your " Mydocuments" folder
        private void writeText(string inString)
        {
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "temp.txt";
            string outPut = myPath + "\\" + fileName;

            using (System.IO.StreamWriter myWriter = new System.IO.StreamWriter(outPut))
            {
                
                string[] mystrings = inString.Split(';');
                foreach (string s in mystrings)
                {
                    myWriter.WriteLine(s);
                }
            }

            txtErrorMessage.Text = "text file is located at " + outPut;
        }

    

        // Method accept a list and outputfile and uses serialization to write xml
        private bool writeTextXML(nameAndAddress outXml, string outputFileName)
        {
            string temp = System.DateTime.Now.Ticks.ToString();
            bool ok = true;
            try
            {
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(nameAndAddress));

                System.IO.StreamWriter file = new System.IO.StreamWriter(outputFileName);
                writer.Serialize(file, outXml);
                file.Close();
            }
            catch (IOException ioe)
            {

                ok = false;
                txtErrorMessage.Text = ioe.Message;
            }
            return ok;
            
        }
             
        
    }
}
