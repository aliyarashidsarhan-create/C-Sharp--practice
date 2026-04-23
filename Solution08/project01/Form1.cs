using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace project01
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // ADD STUDENT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill all boxes");
                return;
            }

            int id;
            int age;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID must be a number");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Age must be a number");
                return;
            }

            if (students.Any(x => x.Id == id))
            {
                MessageBox.Show("ID already exists");
                return;
            }

            students.Add(new Student
            {
                Id = id,
                Name = txtName.Text.Trim(),
                Age = age
            });

            RefreshTable();
            ClearBoxes();
        }

        // DELETE STUDENT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Enter valid ID");
                return;
            }

            var s = students.FirstOrDefault(x => x.Id == id);

            if (s != null)
            {
                students.Remove(s);
                RefreshTable();
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        // SEARCH STUDENT
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim().ToLower();

            var result = students
                .Where(x => x.Name.ToLower().Contains(name))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }

        // SHOW ALL
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        // REFRESH TABLE
        void RefreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        // CLEAR INPUTS
        void ClearBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSearch.Clear();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
    }
}