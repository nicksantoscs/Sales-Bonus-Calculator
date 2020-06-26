using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_COMP1098
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            double hours = Convert.ToDouble(hoursWorked_Textbox.Text);
            hours /= 160;
            double sales = double.Parse(totalSales_Textbox.Text, NumberStyles.Currency);
            sales *= 0.02;

            double bonus = hours * sales;
            salesBonus_Textbox.Text = bonus.ToString();
        }

        private void print_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing...", "");
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            employeeName_Textbox.Text = "";
            employeeId_Textbox.Text = "";
            hoursWorked_Textbox.Text = "";
            totalSales_Textbox.Text = "";
            salesBonus_Textbox.Text = "";
        }
        
        private void english_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            employeeId_Label.Text = "Employee's ID:";
            employeeName_Label.Text = "Employee's Name:";
            hoursWorked_Label.Text = "Hours Worked:";
            totalSales_Label.Text = "Total Sales:";
            salesBonus_Label.Text = "Sales Bonus:";
            calculate_Button.Text = "Calculate";
            print_Button.Text = "Print";
            clear_Button.Text = "Clear";
            language_Groupbox.Text = "Language";
        }

       

        private void french_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalSales_Label.Text = "Ventes totales";
            employeeId_Label.Text = "ID de l'employé:";
            employeeName_Label.Text = "Le nom de l'employé:";
            hoursWorked_Label.Text = "Heures travaillées:";
            salesBonus_Label.Text = "Bonus de vente:";
            calculate_Button.Text = "Calculer";
            print_Button.Text = "Impression";
            clear_Button.Text = "Clair";
            language_Groupbox.Text = "Langue";
        }

        private void portuguese_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            employeeName_Label.Text = "Nome do empregado:";
            employeeId_Label.Text = "ID do empregador:";
            hoursWorked_Label.Text = "Horas trabalhadas:";
            totalSales_Label.Text = "Vendas totais:";
            salesBonus_Label.Text = "Bônus de Vendas:";
            calculate_Button.Text = "Calcular";
            print_Button.Text = "Impressão";
            clear_Button.Text = "Claro";
            language_Groupbox.Text = "Língua";
        }

        private void hoursWorked_Textbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double hours = Convert.ToDouble(hoursWorked_Textbox.Text);
                if (hours <= 160 && hours >= 0)
                {
                    hoursWorked_Textbox.Text = hours.ToString();
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show ("Please enter a number lower than 160.", "Error");
                    hoursWorked_Textbox.Text = "";

                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Please enter a number lower than 160.", "Error");
                hoursWorked_Textbox.Text = "";
            }
        }

        private void totalSales_Textbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double sales = Convert.ToDouble(totalSales_Textbox.Text);
                totalSales_Textbox.Text = (sales.ToString("C"));
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Only numbers are valid.");
                totalSales_Textbox.Text = "";
            }
        }

        private void salesBonus_Textbox_Validating(object sender, EventArgs e)
        {

        }
    }
}
