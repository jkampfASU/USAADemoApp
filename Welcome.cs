﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class welcomeForm : Form
    {
        public List<string> Animals = new List<string>();
        public List<string> Colors = new List<string>();

        public bool isManager = false;

        public welcomeForm()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Animals.Add("Dog");
            Animals.Add("Cat");
            Animals.Add("Lion");
            Animals.Add("Platypus");
            Animals.Add("Dinosaur");
            Animals.Add("Snail");
            Animals.Add("Monkey");

            Colors.Add("Red");
            Colors.Add("Blue");
            Colors.Add("Green");
            Colors.Add("Yellow");

            Random randColor = new Random();
            Random randAnimal = new Random();
            int randomColorIndex = randColor.Next(Colors.Count);
            int randomAnimalIndex = randColor.Next(Colors.Count);
            string userName = "Welcome, " + Colors[randomColorIndex] + Animals[randomAnimalIndex];
            welcomeLabel.Text = userName;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(managerCheckBox.Checked == true)
            {
                postButton.Enabled = false;
            }
            if(managerCheckBox.Checked == false)
            {
                postButton.Enabled = true;
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {

        }

        private void viewTopIssuesButton_Click(object sender, EventArgs e)
        {
            issueBoardForm form1 = new issueBoardForm();
            form1.Show();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {

        }
    }
}
