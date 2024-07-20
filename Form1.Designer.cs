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
            this.rd_large = new System.Windows.Forms.RadioButton();
            this.rd_medium = new System.Windows.Forms.RadioButton();
            this.rd_small = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rd_thick = new System.Windows.Forms.RadioButton();
            this.rd_thin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chPapers = new System.Windows.Forms.CheckBox();
            this.chTomatos = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chMush = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rd_takeaway = new System.Windows.Forms.RadioButton();
            this.rd_inouse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_eat = new System.Windows.Forms.Label();
            this.lb_crust = new System.Windows.Forms.Label();
            this.lb_toppings = new System.Windows.Forms.Label();
            this.lb_size = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rd_large);
            this.gbSize.Controls.Add(this.rd_medium);
            this.gbSize.Controls.Add(this.rd_small);
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
            // rd_large
            // 
            this.rd_large.AutoSize = true;
            this.rd_large.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_large.ForeColor = System.Drawing.Color.White;
            this.rd_large.Location = new System.Drawing.Point(17, 83);
            this.rd_large.Name = "rd_large";
            this.rd_large.Size = new System.Drawing.Size(57, 17);
            this.rd_large.TabIndex = 2;
            this.rd_large.Text = "Large";
            this.rd_large.UseVisualStyleBackColor = true;
            this.rd_large.CheckedChanged += new System.EventHandler(this.rd_large_CheckedChanged);
            // 
            // rd_medium
            // 
            this.rd_medium.AutoSize = true;
            this.rd_medium.Checked = true;
            this.rd_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_medium.ForeColor = System.Drawing.Color.White;
            this.rd_medium.Location = new System.Drawing.Point(17, 50);
            this.rd_medium.Name = "rd_medium";
            this.rd_medium.Size = new System.Drawing.Size(68, 17);
            this.rd_medium.TabIndex = 1;
            this.rd_medium.TabStop = true;
            this.rd_medium.Text = "Medium";
            this.rd_medium.UseVisualStyleBackColor = true;
            this.rd_medium.CheckedChanged += new System.EventHandler(this.rd_medium_CheckedChanged);
            // 
            // rd_small
            // 
            this.rd_small.AutoSize = true;
            this.rd_small.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_small.ForeColor = System.Drawing.Color.White;
            this.rd_small.Location = new System.Drawing.Point(17, 18);
            this.rd_small.Name = "rd_small";
            this.rd_small.Size = new System.Drawing.Size(55, 17);
            this.rd_small.TabIndex = 0;
            this.rd_small.Text = "Small";
            this.rd_small.UseVisualStyleBackColor = true;
            this.rd_small.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rd_thick);
            this.gbCrustType.Controls.Add(this.rd_thin);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.White;
            this.gbCrustType.Location = new System.Drawing.Point(20, 212);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(2);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Padding = new System.Windows.Forms.Padding(2);
            this.gbCrustType.Size = new System.Drawing.Size(150, 81);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rd_thick
            // 
            this.rd_thick.AutoSize = true;
            this.rd_thick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_thick.ForeColor = System.Drawing.Color.White;
            this.rd_thick.Location = new System.Drawing.Point(17, 55);
            this.rd_thick.Name = "rd_thick";
            this.rd_thick.Size = new System.Drawing.Size(57, 17);
            this.rd_thick.TabIndex = 2;
            this.rd_thick.Text = "Thick";
            this.rd_thick.UseVisualStyleBackColor = true;
            this.rd_thick.CheckedChanged += new System.EventHandler(this.rd_thick_CheckedChanged);
            // 
            // rd_thin
            // 
            this.rd_thin.AutoSize = true;
            this.rd_thin.Checked = true;
            this.rd_thin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_thin.ForeColor = System.Drawing.Color.White;
            this.rd_thin.Location = new System.Drawing.Point(17, 18);
            this.rd_thin.Name = "rd_thin";
            this.rd_thin.Size = new System.Drawing.Size(50, 17);
            this.rd_thin.TabIndex = 1;
            this.rd_thin.TabStop = true;
            this.rd_thin.Text = "Thin";
            this.rd_thin.UseVisualStyleBackColor = true;
            this.rd_thin.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chPapers);
            this.gbToppings.Controls.Add(this.chTomatos);
            this.gbToppings.Controls.Add(this.chOlives);
            this.gbToppings.Controls.Add(this.chMush);
            this.gbToppings.Controls.Add(this.chOnion);
            this.gbToppings.Controls.Add(this.chChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(211, 73);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(2);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(2);
            this.gbToppings.Size = new System.Drawing.Size(315, 105);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
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
            this.chPapers.Text = "Green Papers";
            this.chPapers.UseVisualStyleBackColor = true;
            this.chPapers.CheckedChanged += new System.EventHandler(this.chPapers_CheckedChanged);
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
            this.chTomatos.Text = "Tomatos";
            this.chTomatos.UseVisualStyleBackColor = true;
            this.chTomatos.CheckedChanged += new System.EventHandler(this.chTomatos_CheckedChanged);
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
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
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
            this.chMush.Text = "Mushrooms";
            this.chMush.UseVisualStyleBackColor = true;
            this.chMush.CheckedChanged += new System.EventHandler(this.chMush_CheckedChanged);
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
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chChees
            // 
            this.chChees.AutoSize = true;
            this.chChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chChees.ForeColor = System.Drawing.Color.White;
            this.chChees.Location = new System.Drawing.Point(17, 20);
            this.chChees.Name = "chChees";
            this.chChees.Size = new System.Drawing.Size(94, 17);
            this.chChees.TabIndex = 0;
            this.chChees.Text = "Extra Chees";
            this.chChees.UseVisualStyleBackColor = true;
            this.chChees.CheckedChanged += new System.EventHandler(this.chChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rd_takeaway);
            this.gbWhereToEat.Controls.Add(this.rd_inouse);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Location = new System.Drawing.Point(211, 212);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(2);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(2);
            this.gbWhereToEat.Size = new System.Drawing.Size(315, 81);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rd_takeaway
            // 
            this.rd_takeaway.AutoSize = true;
            this.rd_takeaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_takeaway.ForeColor = System.Drawing.Color.White;
            this.rd_takeaway.Location = new System.Drawing.Point(17, 55);
            this.rd_takeaway.Name = "rd_takeaway";
            this.rd_takeaway.Size = new System.Drawing.Size(88, 17);
            this.rd_takeaway.TabIndex = 3;
            this.rd_takeaway.Text = "Take Away";
            this.rd_takeaway.UseVisualStyleBackColor = true;
            this.rd_takeaway.CheckedChanged += new System.EventHandler(this.rd_takeaway_CheckedChanged);
            // 
            // rd_inouse
            // 
            this.rd_inouse.AutoSize = true;
            this.rd_inouse.Checked = true;
            this.rd_inouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_inouse.ForeColor = System.Drawing.Color.White;
            this.rd_inouse.Location = new System.Drawing.Point(17, 18);
            this.rd_inouse.Name = "rd_inouse";
            this.rd_inouse.Size = new System.Drawing.Size(76, 17);
            this.rd_inouse.TabIndex = 2;
            this.rd_inouse.TabStop = true;
            this.rd_inouse.Text = "In House";
            this.rd_inouse.UseVisualStyleBackColor = true;
            this.rd_inouse.CheckedChanged += new System.EventHandler(this.rd_inouse_CheckedChanged);
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
            this.btnOrderPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(415, 316);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(111, 38);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Buttons";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lb_total);
            this.groupBox5.Controls.Add(this.lb_eat);
            this.groupBox5.Controls.Add(this.lb_crust);
            this.groupBox5.Controls.Add(this.lb_toppings);
            this.groupBox5.Controls.Add(this.lb_size);
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
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_total.Location = new System.Drawing.Point(77, 254);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(48, 25);
            this.lb_total.TabIndex = 9;
            this.lb_total.Text = "$30";
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
            // lb_crust
            // 
            this.lb_crust.AutoSize = true;
            this.lb_crust.Location = new System.Drawing.Point(65, 157);
            this.lb_crust.Name = "lb_crust";
            this.lb_crust.Size = new System.Drawing.Size(66, 16);
            this.lb_crust.TabIndex = 7;
            this.lb_crust.Text = "Thin Crust";
            // 
            // lb_toppings
            // 
            this.lb_toppings.AutoSize = true;
            this.lb_toppings.Location = new System.Drawing.Point(65, 82);
            this.lb_toppings.MaximumSize = new System.Drawing.Size(86, 0);
            this.lb_toppings.Name = "lb_toppings";
            this.lb_toppings.Size = new System.Drawing.Size(86, 16);
            this.lb_toppings.TabIndex = 6;
            this.lb_toppings.Text = "No Toppings";
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Location = new System.Drawing.Point(65, 39);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(55, 16);
            this.lb_size.TabIndex = 5;
            this.lb_size.Text = "Medium";
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
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pizza4You";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rd_large;
        private System.Windows.Forms.RadioButton rd_medium;
        private System.Windows.Forms.RadioButton rd_small;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_thick;
        private System.Windows.Forms.RadioButton rd_thin;
        private System.Windows.Forms.CheckBox chChees;
        private System.Windows.Forms.CheckBox chPapers;
        private System.Windows.Forms.CheckBox chTomatos;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chMush;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.RadioButton rd_takeaway;
        private System.Windows.Forms.RadioButton rd_inouse;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_eat;
        private System.Windows.Forms.Label lb_crust;
        private System.Windows.Forms.Label lb_toppings;
        private System.Windows.Forms.Label lb_size;
    }
}

