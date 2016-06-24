using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDatabaseApp
{
    public partial class Form1 : Form
    {
        List<person> listPerson = new List<person>();
        int personListIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PeopleEntities myEntities = new PeopleEntities())
            {
                var customers = from c in myEntities.people
                                select c;
                listPerson = customers.ToList();
            }
            DisplayCustomer(personListIndex);
        }

        private void DisplayCustomer(int i)
        {
            if (listPerson[i] != null)
            {
                nameBox.Text = listPerson[i].Name;
                streetBox.Text = listPerson[i].Street;
                townBox.Text = listPerson[i].Town;
                phoneBox.Text = listPerson[i].Phone;
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personListIndex = (personListIndex + 1) % listPerson.Count;
            DisplayCustomer(personListIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personListIndex = (personListIndex - 1 + listPerson.Count) % listPerson.Count; //add length because modulo -1 won't wrap around
            DisplayCustomer(personListIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (PeopleEntities myEntities = new PeopleEntities())
            {
                person newPerson = new person {
                    Name = nameBox.Text,
                    Town = townBox.Text,
                    Phone = phoneBox.Text,
                    Street = streetBox.Text};
                myEntities.people.Add(newPerson);
                listPerson.Add(newPerson);
                myEntities.SaveChanges();
                    
            }   
        }
    }
}
