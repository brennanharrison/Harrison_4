// Programmer: Brennan Harrison
// Project: Harrison_4
// Date: 11/21/2018
// Description: Create a registration application for Hopkins Film School (RegistrationForm Class).

using System;
using System.Windows.Forms;
using System.IO;

namespace Harrison_4
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Constant fields.
        private const decimal LIVE_ACTION_CLASS_PRICE = 79.95m; // Price of a live action class.
        private const decimal ANIMATION_CLASS_PRICE = 99.95m;   // Price of an animation class.
        private const int MAX_NOTE = 4;                         // Number of selected classes limit.

        // Declare fields.
        private int classCount;                 // Hold the number of selected classes.
        private string classList;               // Hold the selected classes.
        private decimal classPrice;             // Price per class.
        private decimal totalRegistrationPrice; // Total registration price.
        private string paymentType;             // Selected payment type.
        private string emailRequested;          // Selected option for being emailed a receipt.

        // Form load event handler.
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Display the current date in the registrationDateMaskedTextBox control.
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Display the MAX_NOTE variable in the noteLabel control.
            noteLabel.Text = "(Max of " + MAX_NOTE.ToString() + ")";

            // Call the PopulateList() method.
            PopulateList();

            // Call the UpdateTotals() method.
            UpdateTotals();
            
            // Declare and initialize a string array with elements.
            string[] status = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher",
                                "Light Technician", "Sound Technician" };

            // Iterate through each element in the status array.
            for (int index = 0; index < status.Length; index++)
            {
                // Add each element in the status array as an item to the statusComboBox control.
                statusComboBox.Items.Add(status[index]);
            }

            // Allow the user to select multiple items in the classesListBox control
            // and sort the items by alphabetical order.
            classesListBox.SelectionMode = SelectionMode.MultiSimple;
            classesListBox.Sorted = true;
        }

        // Custom PopulateList() method.
        private void PopulateList()
        {
           if (liveActionRadioButton.Checked) // If the liveActionRadioButton control is checked then:
            {
                try // Try-block.
                {
                    /* Create a StreamReader object.
                     * Clear the items in the classesListBox control.
                     * Open a file called "LiveActionClasses.txt". 
                     * Using a while loop, if the data from the beginning to the end of the file has not been read then:
                     * Add the data from the file as items to the classesListBox control. 
                     * Close the file. */
                    StreamReader inputFile;
                    classesListBox.Items.Clear();
                    inputFile = File.OpenText("LiveActionClasses.txt");
                    while (!inputFile.EndOfStream) 
                    {
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close();
                }
                catch (Exception ex) // Catch-block.
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
            else // Otherwise:
            {
                try // Try-block.
                {
                    /* Create a StreamReader object.
                     * Clear the items in the classesListBox control.
                     * Open a file called "AnimationClasses.txt". 
                     * Using a while loop, if the data from the beginning to the end of the file has not been read then:
                     * Add the data from the file as items to the classesListBox control. 
                     * Close the file. */
                    StreamReader inputFile;
                    classesListBox.Items.Clear();
                    inputFile = File.OpenText("AnimationClasses.txt");
                    while (!inputFile.EndOfStream) 
                    {
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close();
                }
                catch (Exception ex) // Catch-block.
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Custom UpdateTotals() method.
        private void UpdateTotals()
        {
            // Initialize the classCount, classList,
            // and totalRegistrationPrice variables with starting values.
            classCount = 0;
            classList = "";
            totalRegistrationPrice = 0.00m;

            if (liveActionRadioButton.Checked) // If the liveActionRadioButton control is checked then:
            {
                // Set the classPrice variable to the LIVE_ACTION_CLASS_PRICE variable.
                classPrice = LIVE_ACTION_CLASS_PRICE;

                // Iterate through each item in the classesListBox control.
                for (int counter = 0; counter < classesListBox.Items.Count; counter++)
                {
                    if (classesListBox.GetSelected(counter)) // If a classesListBox item is selected then:
                    {
                        // Increment and assign the items selected in the classesListBox control with the 
                        // classList variable and concatenate each selected item on a new line.
                        classList += classesListBox.Items[counter] + "\n";
                        classCount++; // Increment the classCount variable every time an item is selected.
                    }
                }
            }
            else // Otherwise:
            {
                // Set the classPrice variable to the ANIMATION_CLASS_PRICE variable.
                classPrice = ANIMATION_CLASS_PRICE;

                // Iterate through each item in the classesListBox control.
                for (int counter = 0; counter < classesListBox.Items.Count; counter++)
                {
                    if (classesListBox.GetSelected(counter)) // If a classesListBox item is selected then:
                    {
                        // Increment and assign the items selected in the classesListBox control with the 
                        // classList variable and concatenate each selected item on a new line.
                        classList += classesListBox.Items[counter] + "\n";
                        classCount++; // Increment the classCount variable every time an item is selected.
                    }
                }
            }

            if (cashRadioButton.Checked) // If the cashRadioButton is checked then:
            {
                // Set the paymentType variable to "Cash".
                paymentType = "Cash";
            }
            else // Otherwise:
            {
                // Set the paymentType variable to "Check".
                paymentType = "Check";
            }

            if (emailReceiptCheckBox.Checked) // If the emailReceiptCheckBox is checked then:
            {
                // Set the emailRequested variable to "Yes".
                emailRequested = "Yes";
            }
            else // Otherwise:
            {
                // Set the emailRequested variable to "No".
                emailRequested = "No";
            }

            // Calculate the totalRegistrationPrice variable.
            totalRegistrationPrice = classCount * classPrice;

            /* Display the classCount variable.
             * Display the classPrice variable.
             * Display the totalRegistrationPrice variable. */
            numberOfClassesLabel.Text = classCount.ToString();
            pricePerClassLabel.Text = classPrice.ToString("c");
            totalRegistrationPriceLabel.Text = totalRegistrationPrice.ToString("c");
        }

        // animationRadioButton click event handler.
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the PopulateList() method every time the animationRadioButton control is checked.
            PopulateList();

            // Call the UpdateTotals() method every time the animationRadioButton control is checked.
            UpdateTotals();
        }

        //classesListBox selected index changed event handler.
        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time an item is selected in the classesListBox control.
            UpdateTotals();
        }

        // checkRadioButton checked changed event handler.
        private void checkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the checkRadioButton control is checked.
            UpdateTotals();
        }

        // emailReceiptCheckBox checked changed event handler.
        private void emailReceiptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the emailReceiptCheckBox control is checked.
            UpdateTotals();
        }

        // aboutToolStripMenuItem click event handler.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the AboutForm class.
            AboutForm help = new AboutForm();

            // Display the AboutForm.
            help.ShowDialog();
        }

        // saveToolStripMenuItem click event handler.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" 
                && dateOfBirthMaskedTextBox.MaskFull) // If the firstNameTextBox, lastNameTextBox, and emailTextBox controls
                                                      // are not empty and the dateOfBirthMaskedTextBox control's mask is full
                                                      // then:
            {
                if (classCount > 0 && classCount <= MAX_NOTE) // If the classCount variable is greater than zero but
                                                              // less than or equal to MAX_NOTE then:
                {
                    // Display a message box showing the complete registration summary.
                    MessageBox.Show("HOPKINS FILM SCHOOL REGISTRATION SUMMARY\n\n" +
                                "Registration Date: " + registrationDateMaskedTextBox.Text + "\n" +
                                "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                                "Email Address: " + emailTextBox.Text + "\n" +
                                "Date of Birth: " + dateOfBirthMaskedTextBox.Text + "\n" +
                                "Registrant Status: " + statusComboBox.Text + "\n" +
                                "\nClasses Selected:\n" + classList +
                                "\nNumber of Classes Selected: " + classCount.ToString() + "\n" +
                                "Price per Class: " + classPrice.ToString("c") + "\n" +
                                "Total Registration Price: " + totalRegistrationPrice.ToString("c") + "\n" +
                                "Payment Type: " + paymentType + "\n" +
                                "Email Receipt Requested: " + emailRequested, "Registration Form Summary",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try // Try-block.
                    {
                        /* Create a StreamWriter object.
                         * Append a file called "RegistrationData.txt".
                         * Write the contents of the complete registration summary in the same format as the prior message box. 
                         * Close the file. */
                        StreamWriter outputFile;
                        outputFile = File.AppendText("RegistrationData.txt");
                        outputFile.WriteLine("HOPKINS FILM SCHOOL REGISTRATION SUMMARY");
                        outputFile.WriteLine();
                        outputFile.WriteLine("Registration Date: " + registrationDateMaskedTextBox.Text);
                        outputFile.WriteLine("Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                        outputFile.WriteLine("Email Address: " + emailTextBox.Text);
                        outputFile.WriteLine("Date of Birth: " + dateOfBirthMaskedTextBox.Text);
                        outputFile.WriteLine("Registrant Status: " + statusComboBox.Text);
                        outputFile.WriteLine();
                        outputFile.WriteLine("Classes Selected: ");

                        // Iterate through each item in the classesListBox control.
                        for (int count = 0; count < classesListBox.Items.Count; count++)
                        {
                            if (classesListBox.GetSelected(count)) // If a classesListBox item is selected then:
                            {
                                // Write each selected item on a new line in the "RegistrationData.txt" file.
                                outputFile.WriteLine(classesListBox.Items[count]);
                            }
                        }

                        outputFile.WriteLine();
                        outputFile.WriteLine("Number of Classes Selected: " + classCount.ToString());
                        outputFile.WriteLine("Price per Class: " + classPrice.ToString("c"));
                        outputFile.WriteLine("Total Registration Price: " + totalRegistrationPrice.ToString("c"));
                        outputFile.WriteLine("Payment Type: " + paymentType);
                        outputFile.WriteLine("Email Receipt Requested: " + emailRequested);
                        outputFile.WriteLine();
                        outputFile.Close();
                    }
                    catch (Exception ex) // Catch-block.
                    {
                        // Display the default error message.
                        MessageBox.Show(ex.Message);
                    }
                }
                else // Otherwise:
                {
                    // Display a message box asking for the correct number of selected classes before registering.
                    MessageBox.Show("Please select one to four classes before registering.",
                      "Incorrect Number of Selected Classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Otherwise:
            {
                // Display a message box asking for the correct infomration before registering.
                MessageBox.Show("Please enter your full name, email, and complete date of birth before registering.",
                               "Insufficient Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Call the ResetForm() method every time the saveToolStripMenuItem is clicked.
            ResetForm();
        }

        // Custom ResetForm() method.
        private void ResetForm()
        {
            // Reset the RegistrationForm to its original appearance at startup.
            registrationDateMaskedTextBox.Text = "";
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dateOfBirthMaskedTextBox.Text = "";
            statusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            classesListBox.ClearSelected();
            cashRadioButton.Checked = true;
            emailReceiptCheckBox.Checked = false;

            // Give the focus to the registrationDateMaskedTextBox control.
            registrationDateMaskedTextBox.Focus();
        }

        // clearToolStripMenuItem click event handler.
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the ResetForm() method every time the clearToolStripMenuItem is clicked.
            ResetForm();
        }

        // exitToolStripMenuItem click event handler.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold user selection in dialog box.
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to exit the registration form?",
                                       "Exit Registration Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take appropriate action based on user selection in dialog box.
            if (selection == DialogResult.Yes)
            {
                // Close the RegistrationForm (ending the program).
                this.Close();
            }
        }
    }
}
