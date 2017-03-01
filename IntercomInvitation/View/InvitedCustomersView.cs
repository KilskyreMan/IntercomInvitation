using IntercomInvitation.DomainModel;
using IntercomInvitation.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IntercomInvitation.View
{
    /// <summary>
    /// Simple WinForm to allow user to select (json) file containing potential customers and
    /// list those within a 100KM radius of Intercom's Dublin office.
    /// 
    /// Normally for UX work, I would implement Martin Fowler's Passive View pattern
    /// but UI in this case is pretty simple and would be overkill.
    /// 
    /// See https://martinfowler.com/eaaDev/PassiveScreen.html
    /// </summary>
    public partial class InvitedCustomersView : Form
    {
        private readonly string defaultJsonPath;
        private readonly string defaultJsonName;

        public InvitedCustomersView()
        {
            defaultJsonPath = Application.StartupPath;
            defaultJsonName = Path.Combine(defaultJsonPath, "customers.json");

            InitializeComponent();

            if (File.Exists(defaultJsonName))
            {
                DisplayCustomersWithinRange(defaultJsonName);
            }
        }

        private void intercomLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.intercom.com");
        }

        private void findFileBtn_Click(object sender, System.EventArgs e)
        {
            openFileDialog.InitialDirectory = defaultJsonPath;
            openFileDialog.FileName = defaultJsonName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DisplayCustomersWithinRange(openFileDialog.FileName);
            }
        }

        private void DisplayCustomersWithinRange(string pathToJsonFile)
        {
            customerJsonFile.Text = pathToJsonFile;
            List<Customer> withinRange = 
                CustomersToInvite.LivingWithin100Km(new CustomerDB(pathToJsonFile));
            if (withinRange.Count > 0)
            {
                customerList.DataSource = withinRange;
                customerList.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                customerList.DataSource = new List<string>()
                {
                    "No customers found.",
                    "Have you selected a valid file containing potential customers?"
                };
                customerList.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void DoneBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
