using dz_23._02.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_23._02
{
    public partial class Form1 : Form
    {
        static CountryDataContext db = new CountryDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            foreach(var ctr in db.Countries)
                res.Add($"{ctr.Name}, Capital: {ctr.Capital}, Population: {ctr.Population}, Area: {ctr.Area} km^2, Continent: {ctr.Continent}");
            listBox1.DataSource = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            foreach (var ctr in db.Countries)
                res.Add($"{ctr.Name}");
            listBox1.DataSource = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            foreach (var ctr in db.Countries)
                res.Add($"{ctr.Capital}");
            listBox1.DataSource = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                           where i.Continent == "Europe"
                           select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                               where i.Area > Convert.ToInt32(textBox1.Text)
                               select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                               where i.Name.Contains("a") && i.Name.Contains("u")
                               select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                               where i.Name.StartsWith("A")
                               select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                               where i.Area > Convert.ToInt32(textBox2.Text) && i.Area < Convert.ToInt32(textBox3.Text)
                               select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = from i in db.Countries
                               where i.Population > Convert.ToInt32(textBox4.Text)
                               select i;
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                orderby i.Area descending
                                select i).Take(5);
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                orderby i.Population descending
                                select i).Take(5);
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                orderby i.Area descending
                                select i).Take(1);
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                orderby i.Population descending
                                select i).Take(1);
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                where i.Continent == "Africa"
                                orderby i.Area
                                select i).Take(1);
            foreach (var i in linq_request)
                res.Add($"{i.Name}");
            listBox1.DataSource = res;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            var linq_request = (from i in db.Countries
                                where i.Continent == "Asia"
                                select i.Area).Average();
            res.Add($"Avg Area in Asia: {linq_request} km^2");
            listBox1.DataSource = res;
        }
    }
}
