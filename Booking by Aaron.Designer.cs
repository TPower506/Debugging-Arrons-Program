namespace MilburyLab4
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
            this.grpTripInfo = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.chkFlight = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblOutputPrice = new System.Windows.Forms.Label();
            this.grpTripInfo.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTripInfo
            // 
            this.grpTripInfo.BackColor = System.Drawing.SystemColors.Info;
            this.grpTripInfo.Controls.Add(this.lblDisplay);
            this.grpTripInfo.Controls.Add(this.btnConfirm);
            this.grpTripInfo.Location = new System.Drawing.Point(218, 12);
            this.grpTripInfo.Name = "grpTripInfo";
            this.grpTripInfo.Size = new System.Drawing.Size(264, 312);
            this.grpTripInfo.TabIndex = 1;
            this.grpTripInfo.TabStop = false;
            this.grpTripInfo.Text = "Trip Information";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(6, 22);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(252, 251);
            this.lblDisplay.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(89, 276);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 29);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblOutputPrice);
            this.grpBook.Controls.Add(this.grpLocation);
            this.grpBook.Controls.Add(this.radCredit);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.lblPeople);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(200, 312);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // grpLocation
            // 
            this.grpLocation.BackColor = System.Drawing.Color.Bisque;
            this.grpLocation.Controls.Add(this.chkFlight);
            this.grpLocation.Controls.Add(this.radMexico);
            this.grpLocation.Controls.Add(this.radFlorida);
            this.grpLocation.Controls.Add(this.radCuba);
            this.grpLocation.Location = new System.Drawing.Point(6, 58);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(188, 133);
            this.grpLocation.TabIndex = 1;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Select Location";
            // 
            // chkFlight
            // 
            this.chkFlight.AutoSize = true;
            this.chkFlight.Enabled = false;
            this.chkFlight.Location = new System.Drawing.Point(6, 108);
            this.chkFlight.Name = "chkFlight";
            this.chkFlight.Size = new System.Drawing.Size(154, 24);
            this.chkFlight.TabIndex = 3;
            this.chkFlight.Text = "Flight Included";
            this.chkFlight.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 83);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(88, 24);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(6, 58);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(88, 24);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(6, 33);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(74, 24);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(9, 197);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(127, 24);
            this.radCredit.TabIndex = 2;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(9, 222);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(72, 24);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(106, 277);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(85, 29);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 253);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(81, 22);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 26);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(6, 25);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(71, 20);
            this.lblPeople.TabIndex = 1;
            this.lblPeople.Text = "People:";
            // 
            // lblOutputPrice
            // 
            this.lblOutputPrice.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutputPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutputPrice.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPrice.Location = new System.Drawing.Point(64, 250);
            this.lblOutputPrice.Name = "lblOutputPrice";
            this.lblOutputPrice.Size = new System.Drawing.Size(127, 24);
            this.lblOutputPrice.TabIndex = 4;
            this.lblOutputPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTripInfo);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Aaron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTripInfo.ResumeLayout(false);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTripInfo;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.CheckBox chkFlight;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblOutputPrice;
    }
}

