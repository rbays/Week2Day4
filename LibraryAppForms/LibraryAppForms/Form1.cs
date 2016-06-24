using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppForms
{
    public partial class Form1 : Form
    {
        List<Book> bookList = new List<Book>();
        
        public Form1()
        {
            InitializeComponent();
        }
        //show correct areas of screen to appropriate users, clears user inputs
        private void loginButton_Click(object sender, EventArgs e)
        {
            //clear inputs
            foreach (Control boxWords in radioBox.Controls)
            {
                boxWords.Text = "";
            }
            foreach (Control boxWords in adminBoxGroup.Controls)
            {
                boxWords.Text = "";
            }
            searchBox.Text = "";

            //show and hide screen sections
            if (loginUsernameTextBox.Text.ToLower() == "user")
            {
                userButtonGroup.Show();
                userSearchGroup.Show();
                radioBox.Show();
                adminBoxGroup.Hide();
                adminButtonGroup.Hide();
            }
            else if (loginUsernameTextBox.Text.ToLower() == "admin")
            {
                userButtonGroup.Show();
                userSearchGroup.Show();
                radioBox.Show();
                adminBoxGroup.Show();
                adminButtonGroup.Show();
            }
            else
            {
                userButtonGroup.Hide();
                userSearchGroup.Hide();
                radioBox.Hide();
                adminBoxGroup.Hide();
                adminButtonGroup.Hide();
            }
        }


        //load library on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //load library on form load
            using (LibraryDBEntities MyEntities = new LibraryDBEntities())
            {
                var books = from book in MyEntities.Books
                            select book;
                bookList = books.ToList();
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string criteria = "Author";
            List<RadioButton> selectionRadios = new List<RadioButton>();
            selectionRadios.Add(authorRadio);
            selectionRadios.Add(titleRadio);
            selectionRadios.Add(illustratorRadio);
            selectionRadios.Add(genreRadio);

            if (searchBox.Text != "")
            {
                foreach (RadioButton radio in selectionRadios)
                {
                    if (radio.Checked)
                    {
                        criteria = radio.Text;
                    }
                }

                List<Book> searchReturnList = new List<Book>();

                foreach (Book book in bookList)
                {
                    if (book(criteria) == searchBox.Text)
                    {
                        MessageBox.Show("it worked " + criteria);
                    }




            }

            
            }
        }
    }
}
