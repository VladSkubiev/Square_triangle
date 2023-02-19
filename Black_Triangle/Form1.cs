using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Triangle
{
   
    public partial class Form1 : Form
    {
        Triangle1 tr1 = new Triangle1();
        Triangle2 tr2 = new Triangle2();
        Triangle3 tr3 = new Triangle3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Равнобедренный")
            {

                tr1.SquareTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                tr1.PerimeterTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                richTextBox1.Text = "Равнобедренный\nПериметр=" + tr1.P + "\nПлощадь=" + tr1.S;

            }


            if (comboBox1.Text == "Равносторонний ")
            {
                tr2.SquareTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                tr2.PerimeterTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                richTextBox1.Text = "Равносторонний\nПериметр=" + tr2.P + "\nПлощадь=" + tr2.S;
            }


            if (comboBox1.Text == "Прямоугольный")
            {
                tr3.SquareTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                tr3.PerimeterTriangle(textBox1.Text, textBox2.Text, textBox3.Text);
                richTextBox1.Text = "Равнобедренный\nПериметр=" + tr3.P + "\nПлощадь=" + tr3.S;
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = null;
            richTextBox1.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    //Интерфейс или абстракт
    //В нем объявляем методы и переменные, которые должны быть в классах 
    interface ITriangle
    {
       void SquareTriangle(string str1, string str2, string str3);
        void PerimeterTriangle(string str1, string str2, string str3); 
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        double P { get; set; }
        double S { get; set; }


    }

    // класс треугольника 1 типа
     public class Triangle1 : ITriangle 
    {
       
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double P { get; set; }
        public double S { get; set; }

        public  void PerimeterTriangle(string str1, string str2, string str3)
        {
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);



            P = Math.Sqrt(b * b + a * a - 2 * a * b * Math.Cos(c)) + a + b;
        }

        public void SquareTriangle(string str1, string str2, string str3)
        {
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);
            

            S = 0.5 * a * b * Math.Sin(c);

        }
    }

    // класс равностроннего треугольника  типа
    public class Triangle2 : ITriangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double P { get; set; }
        public double S { get; set; }

        public void PerimeterTriangle(string str1, string str2, string str3)
        {

            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);

            P = Math.Sqrt(b * b + a * a - 2 * a * b * Math.Cos(c)) + a + b;

        }

        public void SquareTriangle(string str1, string str2, string str3)
        {
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);
            
            //c = (c*180)/3.14;
            S = (0.5 * a * b * c);

        }
    }
    // класс треугольника 1 типа
    public class Triangle3 : ITriangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double P { get; set; }
        public double S { get; set; }

        public void PerimeterTriangle(string str1, string str2, string str3)
        {
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);



            P = Math.Sqrt(b * b + a * a - 2 * a * b * Math.Cos(c)) + a + b;

        }

        public void SquareTriangle(string str1, string str2, string str3)
        {
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);
            
            S = 0.5 * a * b * Math.Sin(c);
        }
    }
}
