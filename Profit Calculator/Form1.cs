using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profit_Calculator
{
    public partial class ProjectCalculator : Form
    {
        public ProjectCalculator()
        {
            InitializeComponent();
        }

        private void initialInvestment_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int breakYear = 1;

            bool validEntry = double.TryParse(initialInvestmentValue.Text, out double seedMoney);

            if (validEntry)
            {
                inputError.SetError(initialInvestmentValue, "");

                validEntry = double.TryParse(yearlyRevenueValue.Text, out double moneyIn);

                if (validEntry)
                {
                    inputError.SetError(yearlyRevenueValue, "");

                    validEntry = double.TryParse(yearlyExpensesValue.Text, out double moneyOut);

                    if (validEntry)
                    {
                        inputError.SetError(yearlyExpensesValue, "");

                       
                        double yearlyProfit = moneyIn - moneyOut;
                        seedMoney *= -1.0;

                        while (seedMoney + yearlyProfit < 0)
                        {
                            seedMoney += yearlyProfit;
                            breakYear++;
                        }

                        breakEvenYearValue.Text = breakYear.ToString();
                    }

                    else
                    {
                        yearlyExpensesValue.Focus();
                        inputError.SetError(yearlyExpensesValue, "This is not a valid input.");
                    }
                }

                else
                {
                    yearlyRevenueValue.Focus();
                    inputError.SetError(yearlyRevenueValue, "This is not a valid input.");
                }
            }

            else
            {
                initialInvestmentValue.Focus();
                inputError.SetError(initialInvestmentValue, "This is not a valid input.");
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doubleBreakEven_Click(object sender, EventArgs e)
        {

            cumulativeProfitValues.Items.Clear();

            int breakYear = int.Parse(breakEvenYearValue.Text);

            List<double> runningProfits = new List<double>();

            bool validEntry = double.TryParse(initialInvestmentValue.Text, out double seedMoney);

            if (validEntry)
            {
                inputError.SetError(initialInvestmentValue, "");

                validEntry = double.TryParse(yearlyRevenueValue.Text, out double moneyIn);

                if (validEntry)
                {
                    inputError.SetError(yearlyRevenueValue, "");

                    validEntry = double.TryParse(yearlyExpensesValue.Text, out double moneyOut);

                    if (validEntry)
                    {
                        inputError.SetError(yearlyExpensesValue, "");

                        seedMoney *= -1.0;
                        double yearlyProfit = moneyIn - moneyOut;
                        

                        breakYear *= 2;

                        for (int i = 0; i < breakYear; i++)
                        {
                            seedMoney += yearlyProfit;
                            runningProfits.Add(seedMoney);
                        }


                        String preparedItem;

                        for (int i = 0; i < runningProfits.Count; i++)
                        {

                            preparedItem = (i + 1) + ":";

                            if (runningProfits[i] < 0)
                            {
                                preparedItem += "-";
                            }

                            preparedItem += "$" + runningProfits[i].ToString("0.00");

                            cumulativeProfitValues.Items.Add(preparedItem);
                        }

                        
                    }

                    else
                    {
                        yearlyExpensesValue.Focus();
                        inputError.SetError(yearlyExpensesValue, "This is not a valid input.");
                    }
                }

                else
                {
                    yearlyRevenueValue.Focus();
                    inputError.SetError(yearlyRevenueValue, "This is not a valid input.");
                }
            }

            else
            {
                initialInvestmentValue.Focus();
                inputError.SetError(initialInvestmentValue, "This is not a valid input.");
            }
        }
    }
}
