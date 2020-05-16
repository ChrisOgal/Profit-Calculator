namespace Profit_Calculator
{
    partial class ProjectCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.initialInvestment = new System.Windows.Forms.Label();
            this.yearlyRevenue = new System.Windows.Forms.Label();
            this.yearlyExpenses = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.breakEvenYear = new System.Windows.Forms.Label();
            this.doubleBreakEven = new System.Windows.Forms.Button();
            this.cumulativeProfit = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.initialInvestmentValue = new System.Windows.Forms.TextBox();
            this.yearlyRevenueValue = new System.Windows.Forms.TextBox();
            this.yearlyExpensesValue = new System.Windows.Forms.TextBox();
            this.cumulativeProfitValues = new System.Windows.Forms.ListBox();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            this.breakEvenYearValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.initialInvestment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.yearlyRevenue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.yearlyExpenses, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.calculate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.breakEvenYear, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.doubleBreakEven, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cumulativeProfit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.exit, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.initialInvestmentValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yearlyRevenueValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.yearlyExpensesValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cumulativeProfitValues, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.breakEvenYearValue, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.06773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.93227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // initialInvestment
            // 
            this.initialInvestment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialInvestment.AutoSize = true;
            this.initialInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialInvestment.Location = new System.Drawing.Point(39, 24);
            this.initialInvestment.Name = "initialInvestment";
            this.initialInvestment.Size = new System.Drawing.Size(147, 20);
            this.initialInvestment.TabIndex = 0;
            this.initialInvestment.Text = "Initial Investment";
            this.initialInvestment.Click += new System.EventHandler(this.initialInvestment_Click);
            // 
            // yearlyRevenue
            // 
            this.yearlyRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearlyRevenue.AutoSize = true;
            this.yearlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenue.Location = new System.Drawing.Point(45, 51);
            this.yearlyRevenue.Name = "yearlyRevenue";
            this.yearlyRevenue.Size = new System.Drawing.Size(135, 20);
            this.yearlyRevenue.TabIndex = 1;
            this.yearlyRevenue.Text = "Yearly Revenue";
            // 
            // yearlyExpenses
            // 
            this.yearlyExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearlyExpenses.AutoSize = true;
            this.yearlyExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyExpenses.Location = new System.Drawing.Point(42, 77);
            this.yearlyExpenses.Name = "yearlyExpenses";
            this.yearlyExpenses.Size = new System.Drawing.Size(142, 20);
            this.yearlyExpenses.TabIndex = 2;
            this.yearlyExpenses.Text = "Yearly Expenses";
            // 
            // calculate
            // 
            this.calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(30, 141);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(165, 30);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // breakEvenYear
            // 
            this.breakEvenYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breakEvenYear.AutoSize = true;
            this.breakEvenYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakEvenYear.Location = new System.Drawing.Point(41, 192);
            this.breakEvenYear.Name = "breakEvenYear";
            this.breakEvenYear.Size = new System.Drawing.Size(144, 20);
            this.breakEvenYear.TabIndex = 4;
            this.breakEvenYear.Text = "Break Even Year";
            // 
            // doubleBreakEven
            // 
            this.doubleBreakEven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doubleBreakEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBreakEven.Location = new System.Drawing.Point(45, 233);
            this.doubleBreakEven.Name = "doubleBreakEven";
            this.doubleBreakEven.Size = new System.Drawing.Size(136, 77);
            this.doubleBreakEven.TabIndex = 5;
            this.doubleBreakEven.Text = "Calculate for double BE years";
            this.doubleBreakEven.UseVisualStyleBackColor = true;
            this.doubleBreakEven.Click += new System.EventHandler(this.doubleBreakEven_Click);
            // 
            // cumulativeProfit
            // 
            this.cumulativeProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cumulativeProfit.AutoSize = true;
            this.cumulativeProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativeProfit.Location = new System.Drawing.Point(267, 261);
            this.cumulativeProfit.Name = "cumulativeProfit";
            this.cumulativeProfit.Size = new System.Drawing.Size(145, 20);
            this.cumulativeProfit.TabIndex = 6;
            this.cumulativeProfit.Text = "Cumulative Profit";
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(73, 380);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 33);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // initialInvestmentValue
            // 
            this.initialInvestmentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialInvestmentValue.Location = new System.Drawing.Point(229, 23);
            this.initialInvestmentValue.Name = "initialInvestmentValue";
            this.initialInvestmentValue.Size = new System.Drawing.Size(100, 24);
            this.initialInvestmentValue.TabIndex = 8;
            // 
            // yearlyRevenueValue
            // 
            this.yearlyRevenueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenueValue.Location = new System.Drawing.Point(229, 51);
            this.yearlyRevenueValue.Name = "yearlyRevenueValue";
            this.yearlyRevenueValue.Size = new System.Drawing.Size(100, 24);
            this.yearlyRevenueValue.TabIndex = 9;
            // 
            // yearlyExpensesValue
            // 
            this.yearlyExpensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyExpensesValue.Location = new System.Drawing.Point(229, 77);
            this.yearlyExpensesValue.Name = "yearlyExpensesValue";
            this.yearlyExpensesValue.Size = new System.Drawing.Size(100, 24);
            this.yearlyExpensesValue.TabIndex = 10;
            // 
            // cumulativeProfitValues
            // 
            this.cumulativeProfitValues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cumulativeProfitValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativeProfitValues.FormattingEnabled = true;
            this.cumulativeProfitValues.ItemHeight = 18;
            this.cumulativeProfitValues.Location = new System.Drawing.Point(259, 316);
            this.cumulativeProfitValues.Name = "cumulativeProfitValues";
            this.cumulativeProfitValues.Size = new System.Drawing.Size(160, 130);
            this.cumulativeProfitValues.TabIndex = 12;
            // 
            // inputError
            // 
            this.inputError.ContainerControl = this;
            // 
            // breakEvenYearValue
            // 
            this.breakEvenYearValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breakEvenYearValue.AutoSize = true;
            this.breakEvenYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakEvenYearValue.Location = new System.Drawing.Point(339, 193);
            this.breakEvenYearValue.Name = "breakEvenYearValue";
            this.breakEvenYearValue.Size = new System.Drawing.Size(0, 18);
            this.breakEvenYearValue.TabIndex = 13;
            // 
            // ProjectCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectCalculator";
            this.Text = "Project Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label initialInvestment;
        private System.Windows.Forms.Label yearlyRevenue;
        private System.Windows.Forms.Label yearlyExpenses;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label breakEvenYear;
        private System.Windows.Forms.Button doubleBreakEven;
        private System.Windows.Forms.Label cumulativeProfit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox initialInvestmentValue;
        private System.Windows.Forms.TextBox yearlyRevenueValue;
        private System.Windows.Forms.TextBox yearlyExpensesValue;
        private System.Windows.Forms.ListBox cumulativeProfitValues;
        private System.Windows.Forms.ErrorProvider inputError;
        private System.Windows.Forms.Label breakEvenYearValue;
    }
}

