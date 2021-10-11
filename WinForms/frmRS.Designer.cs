namespace Q09_3_WinForms
{
    partial class frmRS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNumberOfSeats = new System.Windows.Forms.ComboBox();
            this.btnPlaceReservation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPricePerSeat = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNumberOfSeats);
            this.groupBox1.Controls.Add(this.btnPlaceReservation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPricePerSeat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Details";
            // 
            // cboNumberOfSeats
            // 
            this.cboNumberOfSeats.FormattingEnabled = true;
            this.cboNumberOfSeats.Items.AddRange(new object[] {
            "Please Select",
            "Table for One",
            "Table for Two",
            "Table for Three",
            "Table for Four",
            "Table for Five"});
            this.cboNumberOfSeats.Location = new System.Drawing.Point(127, 42);
            this.cboNumberOfSeats.Name = "cboNumberOfSeats";
            this.cboNumberOfSeats.Size = new System.Drawing.Size(100, 21);
            this.cboNumberOfSeats.TabIndex = 7;
            // 
            // btnPlaceReservation
            // 
            this.btnPlaceReservation.Location = new System.Drawing.Point(127, 131);
            this.btnPlaceReservation.Name = "btnPlaceReservation";
            this.btnPlaceReservation.Size = new System.Drawing.Size(100, 40);
            this.btnPlaceReservation.TabIndex = 6;
            this.btnPlaceReservation.Text = "Place Reservation";
            this.btnPlaceReservation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price Per Seat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Seats:";
            // 
            // txtPricePerSeat
            // 
            this.txtPricePerSeat.Location = new System.Drawing.Point(127, 86);
            this.txtPricePerSeat.Name = "txtPricePerSeat";
            this.txtPricePerSeat.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerSeat.TabIndex = 2;
            // 
            // frmRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRS";
            this.Text = "Reservation System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPricePerSeat;
        private System.Windows.Forms.Button btnPlaceReservation;
        private System.Windows.Forms.ComboBox cboNumberOfSeats;
    }
}

