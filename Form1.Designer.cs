namespace Make_Your_Pizza
{
    partial class Frm1
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkCorn = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labAnsToppings = new System.Windows.Forms.Label();
            this.labAnsPrice = new System.Windows.Forms.Label();
            this.labAnsWhereToEat = new System.Windows.Forms.Label();
            this.labAnsCrustType = new System.Windows.Forms.Label();
            this.labAnsSize = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.labMakeYourPizzaWithAslan = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSize.BackColor = System.Drawing.Color.Sienna;
            this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(136, 122);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(181, 108);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.Sienna;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(83, 53);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(81, 21);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = " Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Sienna;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(6, 64);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 21);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = " Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Sienna;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(6, 37);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(64, 21);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = " Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCrustType.BackColor = System.Drawing.Color.Sienna;
            this.gbCrustType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(340, 122);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(181, 108);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.BackColor = System.Drawing.Color.Sienna;
            this.rbThinkCrust.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkCrust.Location = new System.Drawing.Point(6, 64);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(97, 21);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = false;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.Color.Sienna;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(6, 37);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(90, 21);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbToppings.BackColor = System.Drawing.Color.Sienna;
            this.gbToppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbToppings.Controls.Add(this.chkCorn);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushroom);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(544, 122);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(181, 108);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkCorn
            // 
            this.chkCorn.AutoSize = true;
            this.chkCorn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCorn.Location = new System.Drawing.Point(101, 80);
            this.chkCorn.Name = "chkCorn";
            this.chkCorn.Size = new System.Drawing.Size(57, 21);
            this.chkCorn.TabIndex = 5;
            this.chkCorn.Text = "Corn";
            this.chkCorn.UseVisualStyleBackColor = true;
            this.chkCorn.CheckedChanged += new System.EventHandler(this.chkCorn_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(101, 53);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(66, 21);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(101, 28);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(66, 21);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(5, 80);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(88, 21);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(5, 53);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(95, 21);
            this.chkMushroom.TabIndex = 2;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(5, 28);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(98, 21);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbWhereToEat.BackColor = System.Drawing.Color.Sienna;
            this.gbWhereToEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(748, 122);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(181, 108);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.BackColor = System.Drawing.Color.Sienna;
            this.rbEatOut.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatOut.Location = new System.Drawing.Point(6, 64);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(72, 21);
            this.rbEatOut.TabIndex = 1;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = false;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.Sienna;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(6, 37);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(60, 21);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOrderSummary.BackColor = System.Drawing.Color.Sienna;
            this.gbOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbOrderSummary.Controls.Add(this.labAnsToppings);
            this.gbOrderSummary.Controls.Add(this.labAnsPrice);
            this.gbOrderSummary.Controls.Add(this.labAnsWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labAnsCrustType);
            this.gbOrderSummary.Controls.Add(this.labAnsSize);
            this.gbOrderSummary.Controls.Add(this.labPrice);
            this.gbOrderSummary.Controls.Add(this.labWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labToppings);
            this.gbOrderSummary.Controls.Add(this.labCrustType);
            this.gbOrderSummary.Controls.Add(this.labSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(136, 250);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(795, 141);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // labAnsToppings
            // 
            this.labAnsToppings.AutoSize = true;
            this.labAnsToppings.ForeColor = System.Drawing.SystemColors.Control;
            this.labAnsToppings.Location = new System.Drawing.Point(107, 77);
            this.labAnsToppings.Name = "labAnsToppings";
            this.labAnsToppings.Size = new System.Drawing.Size(0, 25);
            this.labAnsToppings.TabIndex = 9;
            // 
            // labAnsPrice
            // 
            this.labAnsPrice.AutoSize = true;
            this.labAnsPrice.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAnsPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labAnsPrice.Location = new System.Drawing.Point(662, 54);
            this.labAnsPrice.Name = "labAnsPrice";
            this.labAnsPrice.Size = new System.Drawing.Size(65, 54);
            this.labAnsPrice.TabIndex = 8;
            this.labAnsPrice.Text = " 0";
            this.labAnsPrice.Click += new System.EventHandler(this.labAnsPrice_Click);
            // 
            // labAnsWhereToEat
            // 
            this.labAnsWhereToEat.AutoSize = true;
            this.labAnsWhereToEat.ForeColor = System.Drawing.SystemColors.Control;
            this.labAnsWhereToEat.Location = new System.Drawing.Point(517, 34);
            this.labAnsWhereToEat.Name = "labAnsWhereToEat";
            this.labAnsWhereToEat.Size = new System.Drawing.Size(17, 25);
            this.labAnsWhereToEat.TabIndex = 7;
            this.labAnsWhereToEat.Text = " ";
            // 
            // labAnsCrustType
            // 
            this.labAnsCrustType.AutoSize = true;
            this.labAnsCrustType.ForeColor = System.Drawing.SystemColors.Control;
            this.labAnsCrustType.Location = new System.Drawing.Point(237, 34);
            this.labAnsCrustType.Name = "labAnsCrustType";
            this.labAnsCrustType.Size = new System.Drawing.Size(0, 25);
            this.labAnsCrustType.TabIndex = 6;
            // 
            // labAnsSize
            // 
            this.labAnsSize.AutoSize = true;
            this.labAnsSize.ForeColor = System.Drawing.SystemColors.Control;
            this.labAnsSize.Location = new System.Drawing.Point(72, 34);
            this.labAnsSize.Name = "labAnsSize";
            this.labAnsSize.Size = new System.Drawing.Size(0, 25);
            this.labAnsSize.TabIndex = 5;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(587, 34);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(69, 25);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Price :";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(366, 34);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(145, 25);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "Where To Eat :";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Location = new System.Drawing.Point(6, 77);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(108, 25);
            this.labToppings.TabIndex = 2;
            this.labToppings.Text = "Toppings :";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Location = new System.Drawing.Point(165, 34);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(72, 25);
            this.labCrustType.TabIndex = 1;
            this.labCrustType.Text = "Crust :";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(6, 34);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(60, 25);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size :";
            // 
            // labMakeYourPizzaWithAslan
            // 
            this.labMakeYourPizzaWithAslan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMakeYourPizzaWithAslan.AutoSize = true;
            this.labMakeYourPizzaWithAslan.BackColor = System.Drawing.Color.Chocolate;
            this.labMakeYourPizzaWithAslan.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMakeYourPizzaWithAslan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labMakeYourPizzaWithAslan.Location = new System.Drawing.Point(189, 41);
            this.labMakeYourPizzaWithAslan.Name = "labMakeYourPizzaWithAslan";
            this.labMakeYourPizzaWithAslan.Size = new System.Drawing.Size(682, 55);
            this.labMakeYourPizzaWithAslan.TabIndex = 6;
            this.labMakeYourPizzaWithAslan.Text = "Make Your Pizza With Aslan";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrderPizza.BackColor = System.Drawing.Color.Orange;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatAppearance.BorderSize = 2;
            this.btnOrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(856, 410);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(71, 62);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetOrder.BackColor = System.Drawing.Color.Linen;
            this.btnResetOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetOrder.FlatAppearance.BorderSize = 2;
            this.btnResetOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrder.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.Location = new System.Drawing.Point(754, 410);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(71, 62);
            this.btnResetOrder.TabIndex = 0;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = false;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Make_Your_Pizza.Properties.Resources.photo_3_2025_02_20_07_12_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 620);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.labMakeYourPizzaWithAslan);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Aslan Pizza";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label labMakeYourPizzaWithAslan;
        private System.Windows.Forms.CheckBox chkCorn;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label labAnsCrustType;
        private System.Windows.Forms.Label labAnsSize;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label labAnsToppings;
        private System.Windows.Forms.Label labAnsPrice;
        private System.Windows.Forms.Label labAnsWhereToEat;
    }
}

