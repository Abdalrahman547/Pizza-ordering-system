namespace Pizza_Project
{
    partial class OrderForm
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
            System.Windows.Forms.GroupBox gbWhereToEat;
            this.rdoTakeaway = new System.Windows.Forms.RadioButton();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkPickledCucumber = new System.Windows.Forms.CheckBox();
            this.chkolives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoos = new System.Windows.Forms.CheckBox();
            this.chkMashrom = new System.Windows.Forms.CheckBox();
            this.chkExtreaCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWhereToeat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.btnReserOrder = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            gbWhereToEat = new System.Windows.Forms.GroupBox();
            gbWhereToEat.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWhereToEat
            // 
            gbWhereToEat.BackColor = System.Drawing.Color.Firebrick;
            gbWhereToEat.Controls.Add(this.rdoTakeaway);
            gbWhereToEat.Controls.Add(this.rdoEatIn);
            gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbWhereToEat.ForeColor = System.Drawing.Color.Black;
            gbWhereToEat.Location = new System.Drawing.Point(364, 428);
            gbWhereToEat.Name = "gbWhereToEat";
            gbWhereToEat.Size = new System.Drawing.Size(300, 146);
            gbWhereToEat.TabIndex = 1;
            gbWhereToEat.TabStop = false;
            gbWhereToEat.Text = "Where To Eat";
            gbWhereToEat.Enter += new System.EventHandler(this.gbWhereToEat_Enter);
            // 
            // rdoTakeaway
            // 
            this.rdoTakeaway.AutoSize = true;
            this.rdoTakeaway.Location = new System.Drawing.Point(169, 62);
            this.rdoTakeaway.Name = "rdoTakeaway";
            this.rdoTakeaway.Size = new System.Drawing.Size(98, 24);
            this.rdoTakeaway.TabIndex = 2;
            this.rdoTakeaway.TabStop = true;
            this.rdoTakeaway.Tag = "0";
            this.rdoTakeaway.Text = "Takeaway";
            this.rdoTakeaway.UseVisualStyleBackColor = true;
            this.rdoTakeaway.CheckedChanged += new System.EventHandler(this.rdoTakeaway_CheckedChanged);
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(34, 62);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(70, 24);
            this.rdoEatIn.TabIndex = 1;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Tag = "2";
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Firebrick;
            this.gbSize.Controls.Add(this.rdoLarge);
            this.gbSize.Controls.Add(this.rdoMedium);
            this.gbSize.Controls.Add(this.rdoSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Black;
            this.gbSize.Location = new System.Drawing.Point(69, 157);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(231, 215);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(19, 141);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(68, 24);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Tag = "35";
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(19, 95);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(83, 24);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Tag = "30";
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(19, 49);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(66, 24);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Tag = "20";
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Firebrick;
            this.gbTopping.Controls.Add(this.chkPickledCucumber);
            this.gbTopping.Controls.Add(this.chkolives);
            this.gbTopping.Controls.Add(this.chkOnion);
            this.gbTopping.Controls.Add(this.chkTomatoos);
            this.gbTopping.Controls.Add(this.chkMashrom);
            this.gbTopping.Controls.Add(this.chkExtreaCheese);
            this.gbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.ForeColor = System.Drawing.Color.Black;
            this.gbTopping.Location = new System.Drawing.Point(364, 157);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(300, 215);
            this.gbTopping.TabIndex = 1;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // chkPickledCucumber
            // 
            this.chkPickledCucumber.AutoSize = true;
            this.chkPickledCucumber.Location = new System.Drawing.Point(169, 141);
            this.chkPickledCucumber.Name = "chkPickledCucumber";
            this.chkPickledCucumber.Size = new System.Drawing.Size(155, 24);
            this.chkPickledCucumber.TabIndex = 12;
            this.chkPickledCucumber.Tag = "5";
            this.chkPickledCucumber.Text = "Pickled Cucumber";
            this.chkPickledCucumber.UseVisualStyleBackColor = true;
            this.chkPickledCucumber.CheckedChanged += new System.EventHandler(this.chkPickledCucumber_CheckedChanged);
            // 
            // chkolives
            // 
            this.chkolives.AutoSize = true;
            this.chkolives.Location = new System.Drawing.Point(169, 95);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(70, 24);
            this.chkolives.TabIndex = 11;
            this.chkolives.Tag = "5";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(169, 49);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(70, 24);
            this.chkOnion.TabIndex = 10;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoos
            // 
            this.chkTomatoos.AutoSize = true;
            this.chkTomatoos.Location = new System.Drawing.Point(18, 141);
            this.chkTomatoos.Name = "chkTomatoos";
            this.chkTomatoos.Size = new System.Drawing.Size(99, 24);
            this.chkTomatoos.TabIndex = 9;
            this.chkTomatoos.Tag = "5";
            this.chkTomatoos.Text = "Tomatoos";
            this.chkTomatoos.UseVisualStyleBackColor = true;
            this.chkTomatoos.CheckedChanged += new System.EventHandler(this.chkTomatoos_CheckedChanged);
            // 
            // chkMashrom
            // 
            this.chkMashrom.AutoSize = true;
            this.chkMashrom.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkMashrom.Location = new System.Drawing.Point(18, 95);
            this.chkMashrom.Name = "chkMashrom";
            this.chkMashrom.Size = new System.Drawing.Size(94, 24);
            this.chkMashrom.TabIndex = 8;
            this.chkMashrom.Tag = "5";
            this.chkMashrom.Text = "Mashrom";
            this.chkMashrom.UseVisualStyleBackColor = true;
            this.chkMashrom.CheckedChanged += new System.EventHandler(this.chkMashrom_CheckedChanged);
            // 
            // chkExtreaCheese
            // 
            this.chkExtreaCheese.AutoSize = true;
            this.chkExtreaCheese.Location = new System.Drawing.Point(18, 49);
            this.chkExtreaCheese.Name = "chkExtreaCheese";
            this.chkExtreaCheese.Size = new System.Drawing.Size(124, 24);
            this.chkExtreaCheese.TabIndex = 7;
            this.chkExtreaCheese.Tag = "5";
            this.chkExtreaCheese.Text = "Extra Cheese";
            this.chkExtreaCheese.UseVisualStyleBackColor = true;
            this.chkExtreaCheese.CheckedChanged += new System.EventHandler(this.chkExtreaCheese_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Firebrick;
            this.gbCrustType.Controls.Add(this.rdoThick);
            this.gbCrustType.Controls.Add(this.rdoThin);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.Black;
            this.gbCrustType.Location = new System.Drawing.Point(69, 428);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(231, 146);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(119, 69);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(106, 24);
            this.rdoThick.TabIndex = 2;
            this.rdoThick.TabStop = true;
            this.rdoThick.Tag = "10";
            this.rdoThick.Text = "Thick Crust";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(19, 69);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(99, 24);
            this.rdoThin.TabIndex = 1;
            this.rdoThin.TabStop = true;
            this.rdoThin.Tag = "0";
            this.rdoThin.Text = "Thin Crust";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gpOrderSummary.Controls.Add(this.label1);
            this.gpOrderSummary.Controls.Add(this.lblWhereToeat);
            this.gpOrderSummary.Controls.Add(this.lblCrustType);
            this.gpOrderSummary.Controls.Add(this.lblTopping);
            this.gpOrderSummary.Controls.Add(this.lblSize);
            this.gpOrderSummary.Controls.Add(this.label4);
            this.gpOrderSummary.Controls.Add(this.label3);
            this.gpOrderSummary.Controls.Add(this.label2);
            this.gpOrderSummary.Controls.Add(this.lable1);
            this.gpOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpOrderSummary.ForeColor = System.Drawing.Color.Firebrick;
            this.gpOrderSummary.Location = new System.Drawing.Point(788, 29);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Size = new System.Drawing.Size(331, 429);
            this.gpOrderSummary.TabIndex = 2;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(206, 377);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(51, 48);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Price:";
            // 
            // lblWhereToeat
            // 
            this.lblWhereToeat.AutoSize = true;
            this.lblWhereToeat.Location = new System.Drawing.Point(229, 315);
            this.lblWhereToeat.Name = "lblWhereToeat";
            this.lblWhereToeat.Size = new System.Drawing.Size(52, 20);
            this.lblWhereToeat.TabIndex = 7;
            this.lblWhereToeat.Text = "Eat In";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(32, 315);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(39, 20);
            this.lblCrustType.TabIndex = 6;
            this.lblCrustType.Text = "Thin";
            // 
            // lblTopping
            // 
            this.lblTopping.Location = new System.Drawing.Point(45, 159);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(247, 78);
            this.lblTopping.TabIndex = 5;
            this.lblTopping.Text = "Topping";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Location = new System.Drawing.Point(96, 76);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(65, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eat Place:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crust Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toppings:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Firebrick;
            this.lable1.Location = new System.Drawing.Point(22, 72);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(56, 24);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Size:";
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.Color.Firebrick;
            this.btnOrderNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.Location = new System.Drawing.Point(788, 506);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(139, 68);
            this.btnOrderNow.TabIndex = 3;
            this.btnOrderNow.Text = "Order Now!";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // btnReserOrder
            // 
            this.btnReserOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnReserOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserOrder.Location = new System.Drawing.Point(980, 506);
            this.btnReserOrder.Name = "btnReserOrder";
            this.btnReserOrder.Size = new System.Drawing.Size(139, 68);
            this.btnReserOrder.TabIndex = 4;
            this.btnReserOrder.Text = "Reset Order";
            this.btnReserOrder.UseVisualStyleBackColor = false;
            this.btnReserOrder.Click += new System.EventHandler(this.btnReserOrder_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTitle.Location = new System.Drawing.Point(74, 29);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(631, 82);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Make your pizza";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.Order21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 669);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnReserOrder);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.gpOrderSummary);
            this.Controls.Add(gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbSize);
            this.Name = "OrderForm";
            this.Text = "Pizza Hut";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            gbWhereToEat.ResumeLayout(false);
            gbWhereToEat.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoTakeaway;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Button btnReserOrder;
        private System.Windows.Forms.CheckBox chkPickledCucumber;
        private System.Windows.Forms.CheckBox chkolives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoos;
        private System.Windows.Forms.CheckBox chkMashrom;
        private System.Windows.Forms.CheckBox chkExtreaCheese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblWhereToeat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
    }
}