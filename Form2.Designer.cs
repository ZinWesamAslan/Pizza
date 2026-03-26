namespace Make_Your_Pizza
{
    partial class Frm2
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
            this.btnMakeAnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeAnOrder
            // 
            this.btnMakeAnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMakeAnOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMakeAnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMakeAnOrder.FlatAppearance.BorderSize = 2;
            this.btnMakeAnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMakeAnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnMakeAnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAnOrder.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnMakeAnOrder.Location = new System.Drawing.Point(27, 97);
            this.btnMakeAnOrder.Name = "btnMakeAnOrder";
            this.btnMakeAnOrder.Size = new System.Drawing.Size(209, 76);
            this.btnMakeAnOrder.TabIndex = 0;
            this.btnMakeAnOrder.Text = "Make An Order";
            this.btnMakeAnOrder.UseVisualStyleBackColor = false;
            this.btnMakeAnOrder.Click += new System.EventHandler(this.btnMakeAnOrder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Image = global::Make_Your_Pizza.Properties.Resources.photo_4_2025_02_20_07_12_14;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Aslan";
            // 
            // labTel
            // 
            this.labTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labTel.AutoSize = true;
            this.labTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTel.ForeColor = System.Drawing.Color.HotPink;
            this.labTel.Image = global::Make_Your_Pizza.Properties.Resources.photo_4_2025_02_20_07_12_14;
            this.labTel.Location = new System.Drawing.Point(19, 49);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(215, 16);
            this.labTel.TabIndex = 2;
            this.labTel.Text = "Tel : 0938736766 / 0932551395";
            // 
            // labAddress
            // 
            this.labAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labAddress.AutoSize = true;
            this.labAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labAddress.Font = new System.Drawing.Font("Centaur", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.ForeColor = System.Drawing.Color.Lime;
            this.labAddress.Location = new System.Drawing.Point(16, 459);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(300, 16);
            this.labAddress.TabIndex = 3;
            this.labAddress.Text = "Address : Jablah , Alfroah street , front of downtown";
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Make_Your_Pizza.Properties.Resources.photo_4_2025_02_20_07_12_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(333, 495);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeAnOrder);
            this.Controls.Add(this.labTel);
            this.Name = "Frm2";
            this.Text = "Make Pizza With Aslan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeAnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.Label labAddress;
    }
}