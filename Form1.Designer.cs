namespace PizzaProjectNew
{
    partial class Pizza4You
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizza4You));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbCorn = new System.Windows.Forms.CheckBox();
            this.cbPaper = new System.Windows.Forms.CheckBox();
            this.cbOlivs = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomato = new System.Windows.Forms.CheckBox();
            this.cbChees = new System.Windows.Forms.CheckBox();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.rbInhouse = new System.Windows.Forms.RadioButton();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.gbSummery = new System.Windows.Forms.GroupBox();
            this.summeryTotal = new System.Windows.Forms.Label();
            this.summeryEat = new System.Windows.Forms.Label();
            this.summeryCrust = new System.Windows.Forms.Label();
            this.summeryToppings = new System.Windows.Forms.Label();
            this.summerySize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bOrder = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.gbSummery.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(12, 64);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 118);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(18, 85);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rb_size_changed);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(18, 53);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rb_size_changed);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(18, 21);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rb_size_changed);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.ForeColor = System.Drawing.Color.White;
            this.gbCrust.Location = new System.Drawing.Point(12, 234);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(200, 105);
            this.gbCrust.TabIndex = 1;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(18, 61);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(61, 20);
            this.rbThick.TabIndex = 1;
            this.rbThick.Tag = "5";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rb_crust_changed);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(18, 35);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(54, 20);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rb_crust_changed);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.cbCorn);
            this.gbToppings.Controls.Add(this.cbPaper);
            this.gbToppings.Controls.Add(this.cbOlivs);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbTomato);
            this.gbToppings.Controls.Add(this.cbChees);
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(240, 64);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(313, 118);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // cbCorn
            // 
            this.cbCorn.AutoSize = true;
            this.cbCorn.Location = new System.Drawing.Point(242, 22);
            this.cbCorn.Name = "cbCorn";
            this.cbCorn.Size = new System.Drawing.Size(57, 20);
            this.cbCorn.TabIndex = 5;
            this.cbCorn.Tag = "5";
            this.cbCorn.Text = "Corn";
            this.cbCorn.UseVisualStyleBackColor = true;
            this.cbCorn.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbPaper
            // 
            this.cbPaper.AutoSize = true;
            this.cbPaper.Location = new System.Drawing.Point(242, 74);
            this.cbPaper.Name = "cbPaper";
            this.cbPaper.Size = new System.Drawing.Size(65, 20);
            this.cbPaper.TabIndex = 4;
            this.cbPaper.Tag = "8";
            this.cbPaper.Text = "paper";
            this.cbPaper.UseVisualStyleBackColor = true;
            this.cbPaper.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbOlivs
            // 
            this.cbOlivs.AutoSize = true;
            this.cbOlivs.Location = new System.Drawing.Point(20, 74);
            this.cbOlivs.Name = "cbOlivs";
            this.cbOlivs.Size = new System.Drawing.Size(67, 20);
            this.cbOlivs.TabIndex = 3;
            this.cbOlivs.Tag = "6";
            this.cbOlivs.Text = "Olives";
            this.cbOlivs.UseVisualStyleBackColor = true;
            this.cbOlivs.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(138, 21);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(64, 20);
            this.cbOnion.TabIndex = 2;
            this.cbOnion.Tag = "4";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbTomato
            // 
            this.cbTomato.AutoSize = true;
            this.cbTomato.Location = new System.Drawing.Point(138, 74);
            this.cbTomato.Name = "cbTomato";
            this.cbTomato.Size = new System.Drawing.Size(76, 20);
            this.cbTomato.TabIndex = 1;
            this.cbTomato.Tag = "7";
            this.cbTomato.Text = "Tomato";
            this.cbTomato.UseVisualStyleBackColor = true;
            this.cbTomato.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // cbChees
            // 
            this.cbChees.AutoSize = true;
            this.cbChees.Checked = true;
            this.cbChees.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChees.Location = new System.Drawing.Point(20, 22);
            this.cbChees.Name = "cbChees";
            this.cbChees.Size = new System.Drawing.Size(68, 20);
            this.cbChees.TabIndex = 0;
            this.cbChees.Tag = "3";
            this.cbChees.Text = "Chees";
            this.cbChees.UseVisualStyleBackColor = true;
            this.cbChees.CheckedChanged += new System.EventHandler(this.cbTopping_CheckedChanged);
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.Transparent;
            this.gbEat.Controls.Add(this.rbInhouse);
            this.gbEat.Controls.Add(this.rbOut);
            this.gbEat.ForeColor = System.Drawing.Color.White;
            this.gbEat.Location = new System.Drawing.Point(240, 234);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(313, 105);
            this.gbEat.TabIndex = 3;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where To Eat";
            // 
            // rbInhouse
            // 
            this.rbInhouse.AutoSize = true;
            this.rbInhouse.Checked = true;
            this.rbInhouse.Location = new System.Drawing.Point(26, 51);
            this.rbInhouse.Name = "rbInhouse";
            this.rbInhouse.Size = new System.Drawing.Size(81, 20);
            this.rbInhouse.TabIndex = 2;
            this.rbInhouse.TabStop = true;
            this.rbInhouse.Tag = "2";
            this.rbInhouse.Text = "In House";
            this.rbInhouse.UseVisualStyleBackColor = true;
            this.rbInhouse.CheckedChanged += new System.EventHandler(this.rb_eat_changed);
            // 
            // rbOut
            // 
            this.rbOut.AutoSize = true;
            this.rbOut.Location = new System.Drawing.Point(201, 51);
            this.rbOut.Name = "rbOut";
            this.rbOut.Size = new System.Drawing.Size(96, 20);
            this.rbOut.TabIndex = 1;
            this.rbOut.Tag = "0";
            this.rbOut.Text = "Take Away";
            this.rbOut.UseVisualStyleBackColor = true;
            this.rbOut.CheckedChanged += new System.EventHandler(this.rb_eat_changed);
            // 
            // gbSummery
            // 
            this.gbSummery.BackColor = System.Drawing.Color.Transparent;
            this.gbSummery.Controls.Add(this.summeryTotal);
            this.gbSummery.Controls.Add(this.summeryEat);
            this.gbSummery.Controls.Add(this.summeryCrust);
            this.gbSummery.Controls.Add(this.summeryToppings);
            this.gbSummery.Controls.Add(this.summerySize);
            this.gbSummery.Controls.Add(this.label5);
            this.gbSummery.Controls.Add(this.label4);
            this.gbSummery.Controls.Add(this.label3);
            this.gbSummery.Controls.Add(this.label2);
            this.gbSummery.Controls.Add(this.label1);
            this.gbSummery.ForeColor = System.Drawing.Color.White;
            this.gbSummery.Location = new System.Drawing.Point(568, 64);
            this.gbSummery.Name = "gbSummery";
            this.gbSummery.Size = new System.Drawing.Size(252, 355);
            this.gbSummery.TabIndex = 4;
            this.gbSummery.TabStop = false;
            this.gbSummery.Text = "Summery";
            // 
            // summeryTotal
            // 
            this.summeryTotal.AutoSize = true;
            this.summeryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summeryTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.summeryTotal.Location = new System.Drawing.Point(61, 305);
            this.summeryTotal.Name = "summeryTotal";
            this.summeryTotal.Size = new System.Drawing.Size(69, 32);
            this.summeryTotal.TabIndex = 12;
            this.summeryTotal.Text = "25 $";
            // 
            // summeryEat
            // 
            this.summeryEat.AutoSize = true;
            this.summeryEat.Location = new System.Drawing.Point(123, 207);
            this.summeryEat.Name = "summeryEat";
            this.summeryEat.Size = new System.Drawing.Size(60, 16);
            this.summeryEat.TabIndex = 11;
            this.summeryEat.Text = "In House";
            // 
            // summeryCrust
            // 
            this.summeryCrust.AutoSize = true;
            this.summeryCrust.Location = new System.Drawing.Point(123, 149);
            this.summeryCrust.Name = "summeryCrust";
            this.summeryCrust.Size = new System.Drawing.Size(33, 16);
            this.summeryCrust.TabIndex = 10;
            this.summeryCrust.Text = "Thin";
            // 
            // summeryToppings
            // 
            this.summeryToppings.AutoSize = true;
            this.summeryToppings.Location = new System.Drawing.Point(123, 89);
            this.summeryToppings.Name = "summeryToppings";
            this.summeryToppings.Size = new System.Drawing.Size(86, 16);
            this.summeryToppings.TabIndex = 9;
            this.summeryToppings.Text = "No Toppings";
            // 
            // summerySize
            // 
            this.summerySize.AutoSize = true;
            this.summerySize.Location = new System.Drawing.Point(123, 29);
            this.summerySize.Name = "summerySize";
            this.summerySize.Size = new System.Drawing.Size(55, 16);
            this.summerySize.TabIndex = 8;
            this.summerySize.Text = "Medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crust :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toppings :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size :";
            // 
            // bOrder
            // 
            this.bOrder.BackColor = System.Drawing.Color.Transparent;
            this.bOrder.Location = new System.Drawing.Point(393, 384);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(106, 35);
            this.bOrder.TabIndex = 5;
            this.bOrder.Text = "Order Pizza";
            this.bOrder.UseVisualStyleBackColor = false;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.Transparent;
            this.bReset.Location = new System.Drawing.Point(260, 384);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(106, 35);
            this.bReset.TabIndex = 6;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Pizza4You
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.gbSummery);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.Name = "Pizza4You";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.gbSummery.ResumeLayout(false);
            this.gbSummery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.GroupBox gbSummery;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.CheckBox cbCorn;
        private System.Windows.Forms.CheckBox cbPaper;
        private System.Windows.Forms.CheckBox cbOlivs;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomato;
        private System.Windows.Forms.CheckBox cbChees;
        private System.Windows.Forms.RadioButton rbInhouse;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.Label summerySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label summeryTotal;
        private System.Windows.Forms.Label summeryEat;
        private System.Windows.Forms.Label summeryCrust;
        private System.Windows.Forms.Label summeryToppings;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Button bReset;
    }
}

