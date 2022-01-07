/*
 * Name:                Steven Kelly
 * StudentID:           S00200293
 * Date:                07/01/2022
 * Lab:                 Exam_January_2022
 * Description:         "Club Members"
 * Developer notes:     "Calulation methods may be missing or incorrect due to me running out of time. 
 *                      Much time was spent reformatting test data to get program to work and debugging issues". 
 * Github: 
 *                      Clone: "https://github.com/StevenK418/OOP_Exam_January_2022.git"
 *                      View Online: "https://github.com/StevenK418/OOP_Exam_January_2022"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Exam_January_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dictionary<Member, string> memberAccounts = new Dictionary<Member, string>();

        static List<Member> members = new List<Member>();

        public MainWindow()
        {
            InitializeComponent();

            //Instantiate new members and initialize with test data
            JuniorMember jm1 = new JuniorMember("Jack Murphy", new DateTime(2020, 5, 7), 1000m, Member.PaymentSchedule.annual);
            JuniorMember jm2 = new JuniorMember("Emily Kelly", new DateTime(2021, 1, 10), 1000m, Member.PaymentSchedule.biannual);

            Member m1 = new Member("Ella Doyle", new DateTime(2019, 3, 20), 1000, Member.PaymentSchedule.annual);
            Member m2 = new Member("Fionn Kennedy", new DateTime(2018, 8, 15), 1000m, Member.PaymentSchedule.biannual);
            Member m3 = new Member("Louise Moore", new DateTime(2017, 2, 10), 1000m, Member.PaymentSchedule.monthly);

            SeniorMember sm1 = new SeniorMember("Cian Daly", new DateTime(2015, 4, 24), 1000m, Member.PaymentSchedule.annual);
            SeniorMember sm2 = new SeniorMember("Bobby Quinn",  new DateTime(2014, 12, 1), 1000m, Member.PaymentSchedule.biannual);
            SeniorMember sm3 = new SeniorMember("Eve Gallagher",  new DateTime(2013, 6, 1), 1000, Member.PaymentSchedule.monthly);

            //Add the new members to the members list
            memberAccounts.Add(jm1, "JuniorMember");
            memberAccounts.Add(jm2, "JuniorMember");
            memberAccounts.Add(m1, "Member");
            memberAccounts.Add(m2, "Member");
            memberAccounts.Add(m3, "Member");
            memberAccounts.Add(sm1, "SeniorMember");
            memberAccounts.Add(sm2, "SeniorMember");
            memberAccounts.Add(sm3, "SeniorMember");

            //Add the members to a basic list also to act as item source for list box
            members.Add(jm1);
            members.Add(jm2);
            members.Add(m1);
            members.Add(m2);
            members.Add(m3);
            members.Add(sm1);
            members.Add(sm2);
            members.Add(sm3);

            //Set the source of the members listbox to the members dictionary List
            LSTBX_MembersList.ItemsSource = members;
        }

        private void LSTBX_MembersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get a reference to the listbox
            ListBox box = (ListBox)sender;
            //get a reference to the selected item
            Member selectedMember = (Member)box.SelectedItem;

            //Set the fields to the appropriate property values of the selected item
            TBLK_Name.Text = selectedMember.name;
            TBLK_JoinDate.Text = selectedMember.JoinDate.ToShortDateString();
            TBLK_BasicFee.Text = $"€{selectedMember.Fee.ToString()}";
            TBLK_PaymentSchedule.Text = $"{selectedMember.paymentSchedule.ToString()} -";
            //TBLK_RenewalDate.Text = $"{selectedMember.ren}";

            //Get the memberType and set teh field to the appropriate type
            foreach (var member in memberAccounts)
            {
                if(member.Key.name == selectedMember.name)
                {
                    TBLK_MemberType.Text = $"{member.Value}";
                }
            }
            TBLK_RenewalDate.Text = selectedMember.RenewalDate.ToShortDateString();
            TBLK_DaysToRenewal.Text = selectedMember.DateToRenewal.ToString();
        }

        /// <summary>
        /// This was to calculate fees but ran out of time, sadly!
        /// </summary>
        /// <param name="member"></param>
        private void CalculateFees(Member member)
        {
           /* decimal fees;
            //Get the memberType and set teh field to the appropriate type
            foreach (var clubMember in memberAccounts)
            {
                if (clubMember.Key.name == member.name)
                {
                    if (clubMember.Value == "   Member")
                    {
                        if (clubMember.Key.paymentSchedule == member.PaymentSchedule.monthly)
                        {

                        }
                        else if(clubMember.Value == "JuniorMember")
                        {

                        }
                    }
                    else if(clubMember.Value == "JuniorMember")
                    {

                    }
                }
            }
            return fees;*/
        }

        private void radioButton_Selected(object sender, RoutedEventArgs e)
        {
            //Retrieve and store the checked radio button sending the event
            RadioButton radioButton = (RadioButton)sender;

            //Check the radio button that's selected
            if (radioButton == RDBTN_All)
            {
                FilterView("All");
            }
            else if (radioButton == RDBTN_Regular)
            {
                FilterView("Member");
            }
            else if (radioButton == RDBTN_Senior)
            {
                FilterView("SeniorMember");
            }
            else if (radioButton == RDBTN_Junior)
            {
                FilterView("JuniorMember");
            }
        }

        /// <summary>
        /// Changes the view of the Listbox to members matching a given category type.
        /// </summary>
        /// <param name="category"></param>
        private void FilterView(string category)
        {
            List<Member> categorizedAMembers = new List<Member>();

            //Iterate through members collection
            foreach (var member in memberAccounts)
            {
                //If the member has the type specified, add it to the new List
                if (member.Value == category)
                {
                    categorizedAMembers.Add(member.Key);
                }
                else if (category == "All")
                {
                    //Otherwise, if All is selected, add each member to the list
                    categorizedAMembers.Add(member.Key);
                }
            }

            //Set the source of the listbox to the new List
            LSTBX_MembersList.ItemsSource = categorizedAMembers;
        }
    }
}
