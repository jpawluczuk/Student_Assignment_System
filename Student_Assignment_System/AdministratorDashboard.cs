﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assignment_System
{
    public partial class AdministratorDashboard : Form
    {
        List<Administrator> AdminList = new List<Administrator>();
        List<Module> ModuleList = new List<Module>();
        public AdministratorDashboard()
        {
            InitializeComponent();
        }

        private void AdministratorDashboard_Load(object sender, EventArgs e)
        {
            Administrator A01 = new Administrator("A001", "Admin1", 0835555555, "12/03/2014", "Treakle Morrison", "15/02/1987", "123 Doll St.", "1234567L");
            Administrator A02 = new Administrator("A002", "Admin1", 1231231234, "15/06/2017", "Barry Benson", "28/11/1994", "42 Wallaby way", "7654321P");
            AdminList.Add(A01);
            AdminList.Add(A02);

            Module M01 = new Module("M001", "Software Testing", 5);
            Module M02 = new Module("M002", "Discrete Mathematics", 5);
            Module M03 = new Module("M003", "Applications Development", 5);
            Module M04 = new Module("M004", "Web Development Fundamentals", 5);
            Module M05 = new Module("M005", "Data Driven Systems", 5);
            Module M06 = new Module("M006", "Computer Science", 5);
            ModuleList.Add(M01);
            ModuleList.Add(M02);
            ModuleList.Add(M03);
            ModuleList.Add(M04);
            ModuleList.Add(M05);
            ModuleList.Add(M06);



        }
        private void tabPageDashboard_Click(object sender, EventArgs e)
        {

        }

        public static void ReadFile<T>(ref List<T> list, string file)
        {
            List<T> templist = new List<T>();
            FileInfo fileInfo = new FileInfo(file);
            FileStream stream;

            if (fileInfo.Exists)
            {
                stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    templist = formatter.Deserialize(stream) as List<T>;
                    list = templist;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception caught {e}");
                }
                stream.Close();
            }
            else
            {
                Console.WriteLine($"ERROR CANT FIND FILE " + fileInfo.FullName);
            }
        }

        public static void WriteFile<T>(List<T> list, string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            FileStream stream;

            if (fileInfo.Exists)
            {
                stream = new FileStream(file, FileMode.Truncate, FileAccess.Write);
                Console.WriteLine("found file " + fileInfo.FullName);
            }
            else
            {
                stream = new FileStream(file, FileMode.Create, FileAccess.Write);
                Console.WriteLine("created file" + fileInfo.FullName);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, list);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }

            stream.Close();
            Console.WriteLine("Data written to file");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteFile<Administrator>(AdminList, "AdminFile.dat");
            WriteFile<Module>(ModuleList, "ModuleFile.dat");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadFile<Administrator>(ref AdminList, "AdminFile.dat");
            ReadFile<Module>(ref ModuleList, "ModuleFile.dat");
        }

        private void Administrator_Logout(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 5)
            {
                this.Hide();
                var Login = new Form1();
                Login.Closed += (s, args) => this.Close();
                Login.Show();
            }
        }
    }
}
