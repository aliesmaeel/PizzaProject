namespace PizzaProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSizeLarg = new System.Windows.Forms.RadioButton();
            this.rbSizeMeduim = new System.Windows.Forms.RadioButton();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbCrustThick = new System.Windows.Forms.RadioButton();
            this.rbCrustThin = new System.Windows.Forms.RadioButton();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chPapers = new System.Windows.Forms.CheckBox();
            this.chTomatos = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chMush = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.cbToppingChees = new System.Windows.Forms.CheckBox();
            this.gbEatPlace = new System.Windows.Forms.GroupBox();
            this.rbEatPlaceOut = new System.Windows.Forms.RadioButton();
            this.rbEatPlaceIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbTotalPriceValue = new System.Windows.Forms.Label();
            this.lb_eat = new System.Windows.Forms.Label();
            this.lbSummaryCrustValue = new System.Windows.Forms.Label();
            this.lbSummaryEatPlaceValue = new System.Windows.Forms.Label();
            this.lbSizeSummaryValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbEatPlace.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbSizeLarg);
            this.gbSize.Controls.Add(this.rbSizeMeduim);
            this.gbSize.Controls.Add(this.rbSizeSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(20, 73);
            this.gbSize.Margin = new System.Windows.Forms.Padding(2);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(2);
            this.gbSize.Size = new System.Drawing.Size(150, 105);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbSizeLarg
            // 
            this.rbSizeLarg.AutoSize = true;
            this.rbSizeLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeLarg.ForeColor = System.Drawing.Color.White;
            this.rbSizeLarg.Location = new System.Drawing.Point(17, 83);
            this.rbSizeLarg.Name = "rbSizeLarg";
            this.rbSizeLarg.Size = new System.Drawing.Size(57, 17);
            this.rbSizeLarg.TabIndex = 2;
            this.rbSizeLarg.Tag = "30";
            this.rbSizeLarg.Text = "Large";
            this.rbSizeLarg.UseVisualStyleBackColor = true;
            this.rbSizeLarg.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbSizeMeduim
            // 
            this.rbSizeMeduim.AutoSize = true;
            this.rbSizeMeduim.Checked = true;
            this.rbSizeMeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeMeduim.ForeColor = System.Drawing.Color.White;
            this.rbSizeMeduim.Location = new System.Drawing.Point(17, 50);
            this.rbSizeMeduim.Name = "rbSizeMeduim";
            this.rbSizeMeduim.Size = new System.Drawing.Size(68, 17);
            this.rbSizeMeduim.TabIndex = 1;
            this.rbSizeMeduim.TabStop = true;
            this.rbSizeMeduim.Tag = "20";
            this.rbSizeMeduim.Text = "Medium";
            this.rbSizeMeduim.UseVisualStyleBackColor = true;
            this.rbSizeMeduim.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeSmall.ForeColor = System.Drawing.Color.White;
            this.rbSizeSmall.Location = new System.Drawing.Point(17, 18);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(55, 17);
            this.rbSizeSmall.TabIndex = 0;
            this.rbSizeSmall.Tag = "10";
            this.rbSizeSmall.Text = "Small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            this.rbSizeSmall.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbCrustThick);
            this.gbCrust.Controls.Add(this.rbCrustThin);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.White;
            this.gbCrust.Location = new System.Drawing.Point(20, 212);
            this.gbCrust.Margin = new System.Windows.Forms.Padding(2);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Padding = new System.Windows.Forms.Padding(2);
            this.gbCrust.Size = new System.Drawing.Size(150, 81);
            this.gbCrust.TabIndex = 1;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbCrustThick
            // 
            this.rbCrustThick.AutoSize = true;
            this.rbCrustThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrustThick.ForeColor = System.Drawing.Color.White;
            this.rbCrustThick.Location = new System.Drawing.Point(17, 55);
            this.rbCrustThick.Name = "rbCrustThick";
            this.rbCrustThick.Size = new System.Drawing.Size(57, 17);
            this.rbCrustThick.TabIndex = 2;
            this.rbCrustThick.Tag = "10";
            this.rbCrustThick.Text = "Thick";
            this.rbCrustThick.UseVisualStyleBackColor = true;
            this.rbCrustThick.CheckedChanged += new System.EventHandler(this.rbCrust_CheckedChanged);
            // 
            // rbCrustThin
            // 
            this.rbCrustThin.AutoSize = true;
            this.rbCrustThin.Checked = true;
            this.rbCrustThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrustThin.ForeColor = System.Drawing.Color.White;
            this.rbCrustThin.Location = new System.Drawing.Point(17, 18);
            this.rbCrustThin.Name = "rbCrustThin";
            this.rbCrustThin.Size = new System.Drawing.Size(50, 17);
            this.rbCrustThin.TabIndex = 1;
            this.rbCrustThin.TabStop = true;
            this.rbCrustThin.Tag = "5";
            this.rbCrustThin.Text = "Thin";
            this.rbCrustThin.UseVisualStyleBackColor = true;
            this.rbCrustThin.CheckedChanged += new System.EventHandler(this.rbCrust_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.chPapers);
            this.gbTopping.Controls.Add(this.chTomatos);
            this.gbTopping.Controls.Add(this.chOlives);
            this.gbTopping.Controls.Add(this.chMush);
            this.gbTopping.Controls.Add(this.chOnion);
            this.gbTopping.Controls.Add(this.cbToppingChees);
            this.gbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.ForeColor = System.Drawing.Color.White;
            this.gbTopping.Location = new System.Drawing.Point(211, 73);
            this.gbTopping.Margin = new System.Windows.Forms.Padding(2);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Padding = new System.Windows.Forms.Padding(2);
            this.gbTopping.Size = new System.Drawing.Size(315, 105);
            this.gbTopping.TabIndex = 2;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Toppings";
            // 
            // chPapers
            // 
            this.chPapers.AutoSize = true;
            this.chPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPapers.ForeColor = System.Drawing.Color.White;
            this.chPapers.Location = new System.Drawing.Point(207, 84);
            this.chPapers.Name = "chPapers";
            this.chPapers.Size = new System.Drawing.Size(103, 17);
            this.chPapers.TabIndex = 5;
            this.chPapers.Tag = "9";
            this.chPapers.Text = "Green Papers";
            this.chPapers.UseVisualStyleBackColor = true;
            this.chPapers.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // chTomatos
            // 
            this.chTomatos.AutoSize = true;
            this.chTomatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatos.ForeColor = System.Drawing.Color.White;
            this.chTomatos.Location = new System.Drawing.Point(119, 83);
            this.chTomatos.Name = "chTomatos";
            this.chTomatos.Size = new System.Drawing.Size(74, 17);
            this.chTomatos.TabIndex = 4;
            this.chTomatos.Tag = "8";
            this.chTomatos.Text = "Tomatos";
            this.chTomatos.UseVisualStyleBackColor = true;
            this.chTomatos.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOlives.ForeColor = System.Drawing.Color.White;
            this.chOlives.Location = new System.Drawing.Point(17, 83);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(61, 17);
            this.chOlives.TabIndex = 3;
            this.chOlives.Tag = "7";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // chMush
            // 
            this.chMush.AutoSize = true;
            this.chMush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMush.ForeColor = System.Drawing.Color.White;
            this.chMush.Location = new System.Drawing.Point(207, 18);
            this.chMush.Name = "chMush";
            this.chMush.Size = new System.Drawing.Size(89, 17);
            this.chMush.TabIndex = 2;
            this.chMush.Tag = "6";
            this.chMush.Text = "Mushrooms";
            this.chMush.UseVisualStyleBackColor = true;
            this.chMush.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOnion.ForeColor = System.Drawing.Color.White;
            this.chOnion.Location = new System.Drawing.Point(119, 19);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(59, 17);
            this.chOnion.TabIndex = 1;
            this.chOnion.Tag = "5";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbToppingChees
            // 
            this.cbToppingChees.AutoSize = true;
            this.cbToppingChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToppingChees.ForeColor = System.Drawing.Color.White;
            this.cbToppingChees.Location = new System.Drawing.Point(17, 20);
            this.cbToppingChees.Name = "cbToppingChees";
            this.cbToppingChees.Size = new System.Drawing.Size(94, 17);
            this.cbToppingChees.TabIndex = 0;
            this.cbToppingChees.Tag = "4";
            this.cbToppingChees.Text = "Extra Chees";
            this.cbToppingChees.UseVisualStyleBackColor = true;
            this.cbToppingChees.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // gbEatPlace
            // 
            this.gbEatPlace.BackColor = System.Drawing.Color.Transparent;
            this.gbEatPlace.Controls.Add(this.rbEatPlaceOut);
            this.gbEatPlace.Controls.Add(this.rbEatPlaceIn);
            this.gbEatPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEatPlace.ForeColor = System.Drawing.Color.White;
            this.gbEatPlace.Location = new System.Drawing.Point(211, 212);
            this.gbEatPlace.Margin = new System.Windows.Forms.Padding(2);
            this.gbEatPlace.Name = "gbEatPlace";
            this.gbEatPlace.Padding = new System.Windows.Forms.Padding(2);
            this.gbEatPlace.Size = new System.Drawing.Size(315, 81);
            this.gbEatPlace.TabIndex = 3;
            this.gbEatPlace.TabStop = false;
            this.gbEatPlace.Text = "Where To Eat";
            // 
            // rbEatPlaceOut
            // 
            this.rbEatPlaceOut.AutoSize = true;
            this.rbEatPlaceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatPlaceOut.ForeColor = System.Drawing.Color.White;
            this.rbEatPlaceOut.Location = new System.Drawing.Point(17, 55);
            this.rbEatPlaceOut.Name = "rbEatPlaceOut";
            this.rbEatPlaceOut.Size = new System.Drawing.Size(88, 17);
            this.rbEatPlaceOut.TabIndex = 3;
            this.rbEatPlaceOut.Tag = "0";
            this.rbEatPlaceOut.Text = "Take Away";
            this.rbEatPlaceOut.UseVisualStyleBackColor = true;
            this.rbEatPlaceOut.CheckedChanged += new System.EventHandler(this.rbEatPlace_CheckedChanged);
            // 
            // rbEatPlaceIn
            // 
            this.rbEatPlaceIn.AutoSize = true;
            this.rbEatPlaceIn.Checked = true;
            this.rbEatPlaceIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatPlaceIn.ForeColor = System.Drawing.Color.White;
            this.rbEatPlaceIn.Location = new System.Drawing.Point(17, 18);
            this.rbEatPlaceIn.Name = "rbEatPlaceIn";
            this.rbEatPlaceIn.Size = new System.Drawing.Size(76, 17);
            this.rbEatPlaceIn.TabIndex = 2;
            this.rbEatPlaceIn.TabStop = true;
            this.rbEatPlaceIn.Tag = "1";
            this.rbEatPlaceIn.Text = "In House";
            this.rbEatPlaceIn.UseVisualStyleBackColor = true;
            this.rbEatPlaceIn.CheckedChanged += new System.EventHandler(this.rbEatPlace_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make Your Pizza";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(211, 316);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(111, 38);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(415, 316);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(111, 38);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Buttons";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lbTotalPriceValue);
            this.groupBox5.Controls.Add(this.lb_eat);
            this.groupBox5.Controls.Add(this.lbSummaryCrustValue);
            this.groupBox5.Controls.Add(this.lbSummaryEatPlaceValue);
            this.groupBox5.Controls.Add(this.lbSizeSummaryValue);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(560, 73);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(159, 281);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summery";
            // 
            // lbTotalPriceValue
            // 
            this.lbTotalPriceValue.AutoSize = true;
            this.lbTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalPriceValue.Location = new System.Drawing.Point(77, 254);
            this.lbTotalPriceValue.Name = "lbTotalPriceValue";
            this.lbTotalPriceValue.Size = new System.Drawing.Size(48, 25);
            this.lbTotalPriceValue.TabIndex = 9;
            this.lbTotalPriceValue.Text = "$30";
            // 
            // lb_eat
            // 
            this.lb_eat.AutoSize = true;
            this.lb_eat.Location = new System.Drawing.Point(65, 204);
            this.lb_eat.Name = "lb_eat";
            this.lb_eat.Size = new System.Drawing.Size(60, 16);
            this.lb_eat.TabIndex = 8;
            this.lb_eat.Text = "In House";
            // 
            // lbSummaryCrustValue
            // 
            this.lbSummaryCrustValue.AutoSize = true;
            this.lbSummaryCrustValue.Location = new System.Drawing.Point(65, 157);
            this.lbSummaryCrustValue.Name = "lbSummaryCrustValue";
            this.lbSummaryCrustValue.Size = new System.Drawing.Size(66, 16);
            this.lbSummaryCrustValue.TabIndex = 7;
            this.lbSummaryCrustValue.Text = "Thin Crust";
            // 
            // lbSummaryEatPlaceValue
            // 
            this.lbSummaryEatPlaceValue.AutoSize = true;
            this.lbSummaryEatPlaceValue.Location = new System.Drawing.Point(65, 82);
            this.lbSummaryEatPlaceValue.MaximumSize = new System.Drawing.Size(86, 0);
            this.lbSummaryEatPlaceValue.Name = "lbSummaryEatPlaceValue";
            this.lbSummaryEatPlaceValue.Size = new System.Drawing.Size(86, 16);
            this.lbSummaryEatPlaceValue.TabIndex = 6;
            this.lbSummaryEatPlaceValue.Text = "No Toppings";
            // 
            // lbSizeSummaryValue
            // 
            this.lbSizeSummaryValue.AutoSize = true;
            this.lbSizeSummaryValue.Location = new System.Drawing.Point(65, 39);
            this.lbSizeSummaryValue.Name = "lbSizeSummaryValue";
            this.lbSizeSummaryValue.Size = new System.Drawing.Size(55, 16);
            this.lbSizeSummaryValue.TabIndex = 5;
            this.lbSizeSummaryValue.Text = "Medium";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where To Eat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 366);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbEatPlace);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pizza4You";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbEatPlace.ResumeLayout(false);
            this.gbEatPlace.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbSizeLarg;
        private System.Windows.Forms.RadioButton rbSizeMeduim;
        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.GroupBox gbEatPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCrustThick;
        private System.Windows.Forms.RadioButton rbCrustThin;
        private System.Windows.Forms.CheckBox cbToppingChees;
        private System.Windows.Forms.CheckBox chPapers;
        private System.Windows.Forms.CheckBox chTomatos;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chMush;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.RadioButton rbEatPlaceOut;
        private System.Windows.Forms.RadioButton rbEatPlaceIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalPriceValue;
        private System.Windows.Forms.Label lb_eat;
        private System.Windows.Forms.Label lbSummaryCrustValue;
        private System.Windows.Forms.Label lbSummaryEatPlaceValue;
        private System.Windows.Forms.Label lbSizeSummaryValue;
    }
}

