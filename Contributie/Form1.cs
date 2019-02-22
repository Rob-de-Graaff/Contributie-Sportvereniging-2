using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contributie
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Sport> sports;
        private Dictionary<int, Member> members;
        private Sport tempSport;
        private Member tempMember;
        private List<Sport> selectedList;
        private double price;
        private double _priceTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sports = new Dictionary<int, Sport>();
            members = new Dictionary<int, Member>();
            selectedList = new List<Sport>();

            sports.Add(1, new Sport("voetbal", 0));
            sports.Add(2, new Sport("volleybal", 0));
            sports.Add(3, new Sport("basketbal", 0));
            sports.Add(4, new Sport("handbal", 0));
            sports.Add(5, new Sport("atletiek", 0));

            members.Add(1, new Member("John Deer", Convert.ToDateTime("10/2/1990"), Convert.ToDateTime("15/8/2000"), 40, 0, 0, 5));
            members.Add(2, new Member("John Dough", Convert.ToDateTime("18/2/2005"), Convert.ToDateTime("1/8/2015"), 40, 0, 0, 5));

            // Sets properties per member
            foreach (KeyValuePair<int, Member> entry in members)
            {
                int age = CalculateYears(entry.Value.DateOfBirth);
                int membership = CalculateYears(entry.Value.StartDate);

                // Sets discount property
                if (age<18 || age>=40)
                {
                    entry.Value.Discount = 0.10;
                }

                // Sets  member discount property
                if (membership >=entry.Value.MemberLimit)
                {
                    entry.Value.MemberDiscount = 0.05;
                }
            }

            // Displays name property
            listBoxSports.DataSource = sports.Values.ToList();
            listBoxSports.DisplayMember = "name";

            // Displays name property
            listBoxMembers.DataSource = members.Values.ToList();
            listBoxMembers.DisplayMember = "name";

            // Displays calculation, total
            labelTicketsTotal.Text = $@"Contribution Total = (sportcount * price + contribution) * (discount + memberdiscount)";
            labelPriceTotal.Text = $@"Total: € {Math.Round(_priceTotal, 2):0.00},-";

            buttonReset.Enabled = false;
            buttonReset.Visible = false;
        }

        private void ButtonAddSport_Click(object sender, EventArgs e)
        {
            tempSport = (Sport)listBoxSports.SelectedItem;

            // Checks if selectedLists contains selected sport
            if (!selectedList.Contains(tempSport))
            {
                selectedList.Add(tempSport);
            }

            // Displays properties
            listBoxSelected.DataSource = null;
            listBoxSelected.DataSource = selectedList;
            listBoxSelected.DisplayMember = "Value";
        }

        private void ButtonRemoveSport_Click(object sender, EventArgs e)
        {
            tempSport = (Sport)listBoxSelected.SelectedItem;

            selectedList.Remove(tempSport);

            // Displays properties
            listBoxSelected.DataSource = null;
            listBoxSelected.DataSource = selectedList;
            listBoxSelected.DisplayMember = "Value";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            tempMember = (Member)listBoxMembers.SelectedItem;

            if (listBoxSelected != null)
            {
                int sportAmount = selectedList.Count;
                
                // Sets extra amount property of each sport
                switch (sportAmount)
                {
                    case 1:
                    case 2:
                        price = 25;
                        SetExtraAmount(price);
                        break;
                    case 3:
                    case 4:
                        price = 22;
                        SetExtraAmount(price);
                        break;
                    case 5:
                        price = 20;
                        SetExtraAmount(price);
                        break;
                }

                
                // Updates display
                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = selectedList;
                listBoxSelected.DisplayMember = "Value";

                _priceTotal = 0;
                _priceTotal = (selectedList.Count * price + tempMember.Contribution) * (1 - (tempMember.Discount + tempMember.MemberDiscount));

                // Displays calculation, total
                labelTicketsTotal.Text = $@"Contribution Total = (sportcount {selectedList.Count} * price € {price} + contribution € {tempMember.Contribution}) * (discount {tempMember.Discount*100}% + memberdiscount {tempMember.MemberDiscount*100}%)";
                labelPriceTotal.Text = $@"Total: € {Math.Round(_priceTotal, 2):0.00},-";
            }
        }

        // Sets extra amount property of each sport
        private void SetExtraAmount(double price)
        {
            foreach (KeyValuePair<int, Sport> entry in sports)
            {
                entry.Value.ExtraAmount = price;
            }
        }

        private static int CalculateYears(DateTime date)
        {
            int years = DateTime.Now.Year - date.Year;  
            if (DateTime.Now.DayOfYear < date.DayOfYear)  
                years = years - 1;  
  
            return years; 
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            listBoxSports.SelectedIndex = 0;
            listBoxMembers.SelectedIndex = 0;
            listBoxSelected.DataSource = null;
            selectedList.Clear();
            price = 0;
            _priceTotal = 0;

            // Displays calculation, total
            labelTicketsTotal.Text = $@"Contribution Total = (sportcount {selectedList.Count} * price € {price} + contribution € {0}) * (discount {0}% + memberdiscount {0}%)";
            labelPriceTotal.Text = $@"Total: € {Math.Round(_priceTotal, 2):0.00},-";
        }
    }
}
