namespace RectangleCalculator {
    partial class frmRectangleCalculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblLengthOfRectangle = new System.Windows.Forms.Label();
            this.lblWidthOfRectangle = new System.Windows.Forms.Label();
            this.txtLengthOfRectangle = new System.Windows.Forms.TextBox();
            this.txtWidthOfRectangle = new System.Windows.Forms.TextBox();
            this.lblOutputPerimeter = new System.Windows.Forms.Label();
            this.lblOutputArea = new System.Windows.Forms.Label();
            this.lblOuputDiagonalLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLengthInCentimeters = new System.Windows.Forms.Label();
            this.lblWidthInCentimeters = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblDiagonalLength = new System.Windows.Forms.Label();
            this.lblAreaInCentimeters = new System.Windows.Forms.Label();
            this.lblPerimeterInCentimeters = new System.Windows.Forms.Label();
            this.lblDiagonalLengthInCentimeters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLengthOfRectangle
            // 
            this.lblLengthOfRectangle.AutoSize = true;
            this.lblLengthOfRectangle.Location = new System.Drawing.Point(91, 30);
            this.lblLengthOfRectangle.Name = "lblLengthOfRectangle";
            this.lblLengthOfRectangle.Size = new System.Drawing.Size(43, 13);
            this.lblLengthOfRectangle.TabIndex = 0;
            this.lblLengthOfRectangle.Text = "Length:";
            this.lblLengthOfRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidthOfRectangle
            // 
            this.lblWidthOfRectangle.AutoSize = true;
            this.lblWidthOfRectangle.Location = new System.Drawing.Point(97, 63);
            this.lblWidthOfRectangle.Name = "lblWidthOfRectangle";
            this.lblWidthOfRectangle.Size = new System.Drawing.Size(38, 13);
            this.lblWidthOfRectangle.TabIndex = 1;
            this.lblWidthOfRectangle.Text = "Width:";
            this.lblWidthOfRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLengthOfRectangle
            // 
            this.txtLengthOfRectangle.Location = new System.Drawing.Point(145, 27);
            this.txtLengthOfRectangle.Name = "txtLengthOfRectangle";
            this.txtLengthOfRectangle.Size = new System.Drawing.Size(142, 20);
            this.txtLengthOfRectangle.TabIndex = 2;
            // 
            // txtWidthOfRectangle
            // 
            this.txtWidthOfRectangle.Location = new System.Drawing.Point(145, 60);
            this.txtWidthOfRectangle.Name = "txtWidthOfRectangle";
            this.txtWidthOfRectangle.Size = new System.Drawing.Size(142, 20);
            this.txtWidthOfRectangle.TabIndex = 3;
            // 
            // lblOutputPerimeter
            // 
            this.lblOutputPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputPerimeter.Location = new System.Drawing.Point(142, 172);
            this.lblOutputPerimeter.Name = "lblOutputPerimeter";
            this.lblOutputPerimeter.Size = new System.Drawing.Size(142, 20);
            this.lblOutputPerimeter.TabIndex = 4;
            this.lblOutputPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputArea
            // 
            this.lblOutputArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputArea.Location = new System.Drawing.Point(145, 135);
            this.lblOutputArea.Name = "lblOutputArea";
            this.lblOutputArea.Size = new System.Drawing.Size(142, 20);
            this.lblOutputArea.TabIndex = 5;
            this.lblOutputArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOuputDiagonalLength
            // 
            this.lblOuputDiagonalLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOuputDiagonalLength.Location = new System.Drawing.Point(142, 210);
            this.lblOuputDiagonalLength.Name = "lblOuputDiagonalLength";
            this.lblOuputDiagonalLength.Size = new System.Drawing.Size(142, 20);
            this.lblOuputDiagonalLength.TabIndex = 6;
            this.lblOuputDiagonalLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(142, 97);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 20);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnStartCalculator_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 20);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(42, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 20);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLengthInCentimeters
            // 
            this.lblLengthInCentimeters.AutoSize = true;
            this.lblLengthInCentimeters.Location = new System.Drawing.Point(301, 27);
            this.lblLengthInCentimeters.Name = "lblLengthInCentimeters";
            this.lblLengthInCentimeters.Size = new System.Drawing.Size(21, 13);
            this.lblLengthInCentimeters.TabIndex = 10;
            this.lblLengthInCentimeters.Text = "cm";
            // 
            // lblWidthInCentimeters
            // 
            this.lblWidthInCentimeters.AutoSize = true;
            this.lblWidthInCentimeters.Location = new System.Drawing.Point(301, 67);
            this.lblWidthInCentimeters.Name = "lblWidthInCentimeters";
            this.lblWidthInCentimeters.Size = new System.Drawing.Size(21, 13);
            this.lblWidthInCentimeters.TabIndex = 11;
            this.lblWidthInCentimeters.Text = "cm";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(97, 139);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Area:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(75, 176);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
            this.lblPerimeter.TabIndex = 13;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiagonalLength
            // 
            this.lblDiagonalLength.AutoSize = true;
            this.lblDiagonalLength.Location = new System.Drawing.Point(41, 210);
            this.lblDiagonalLength.Name = "lblDiagonalLength";
            this.lblDiagonalLength.Size = new System.Drawing.Size(88, 13);
            this.lblDiagonalLength.TabIndex = 14;
            this.lblDiagonalLength.Text = "Diagonal Length:";
            this.lblDiagonalLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreaInCentimeters
            // 
            this.lblAreaInCentimeters.AutoSize = true;
            this.lblAreaInCentimeters.Location = new System.Drawing.Point(301, 139);
            this.lblAreaInCentimeters.Name = "lblAreaInCentimeters";
            this.lblAreaInCentimeters.Size = new System.Drawing.Size(0, 13);
            this.lblAreaInCentimeters.TabIndex = 15;
            // 
            // lblPerimeterInCentimeters
            // 
            this.lblPerimeterInCentimeters.AutoSize = true;
            this.lblPerimeterInCentimeters.Location = new System.Drawing.Point(301, 176);
            this.lblPerimeterInCentimeters.Name = "lblPerimeterInCentimeters";
            this.lblPerimeterInCentimeters.Size = new System.Drawing.Size(21, 13);
            this.lblPerimeterInCentimeters.TabIndex = 16;
            this.lblPerimeterInCentimeters.Text = "cm";
            // 
            // lblDiagonalLengthInCentimeters
            // 
            this.lblDiagonalLengthInCentimeters.AutoSize = true;
            this.lblDiagonalLengthInCentimeters.Location = new System.Drawing.Point(301, 210);
            this.lblDiagonalLengthInCentimeters.Name = "lblDiagonalLengthInCentimeters";
            this.lblDiagonalLengthInCentimeters.Size = new System.Drawing.Size(21, 13);
            this.lblDiagonalLengthInCentimeters.TabIndex = 17;
            this.lblDiagonalLengthInCentimeters.Text = "cm";
            // 
            // frmRectangleCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.lblDiagonalLengthInCentimeters);
            this.Controls.Add(this.lblPerimeterInCentimeters);
            this.Controls.Add(this.lblAreaInCentimeters);
            this.Controls.Add(this.lblDiagonalLength);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidthInCentimeters);
            this.Controls.Add(this.lblLengthInCentimeters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOuputDiagonalLength);
            this.Controls.Add(this.lblOutputArea);
            this.Controls.Add(this.lblOutputPerimeter);
            this.Controls.Add(this.txtWidthOfRectangle);
            this.Controls.Add(this.txtLengthOfRectangle);
            this.Controls.Add(this.lblWidthOfRectangle);
            this.Controls.Add(this.lblLengthOfRectangle);
            this.Name = "frmRectangleCalculator";
            this.Text = "Rectangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLengthOfRectangle;
        private System.Windows.Forms.Label lblWidthOfRectangle;
        private System.Windows.Forms.TextBox txtLengthOfRectangle;
        private System.Windows.Forms.TextBox txtWidthOfRectangle;
        private System.Windows.Forms.Label lblOutputPerimeter;
        private System.Windows.Forms.Label lblOutputArea;
        private System.Windows.Forms.Label lblOuputDiagonalLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLengthInCentimeters;
        private System.Windows.Forms.Label lblWidthInCentimeters;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblDiagonalLength;
        private System.Windows.Forms.Label lblAreaInCentimeters;
        private System.Windows.Forms.Label lblPerimeterInCentimeters;
        private System.Windows.Forms.Label lblDiagonalLengthInCentimeters;
    }
}

