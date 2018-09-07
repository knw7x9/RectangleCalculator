// frmMRectangleCalculator.cs, RectangleCalculator.sln
// CS 1181
// Katherine Wilsdon
// 7 September 2018
// Dr. Cody Permann
/* Description - Create a rectangle calculator. The user provides the length and
 * width of the rectangle. The code calculates the perimeter, area, and diagonal 
 * length of the rectangle and displays the results on the form.*/
/* WOW:
 * 1. Implement a Try-Catch statement to account for users inputting non-integers.
 * 2. Implement an If--Elseif--Else statement to account for the user inputting zeros
 * into the textboxes which would create nothing or a line.
 * 3. Add a Clear button the clear the contents of the textboxes and output labels
 * and put a focus in the first textbox.
 * 4. Add a Exit button that closes the form.
 * 5. Displays a message when the rectangle is a square.
 * 6. The form starts the calculator when enter is pressed 
 * via the AcceptButton under the form's properties */
/* Works cited:
  * Make centimeters squared: https://www.codeproject.com/Questions/502124/canplussomeoneplustellplusmeplushowplustopluswrite 
  * AcceptButton: https://www.youtube.com/watch?v=seA5vjbKpxc 
  * PerformClick: https://stackoverflow.com/questions/20626608/a-button-click-event-in-if-else-loop 
  * Book, Chapters 3 and 4: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleCalculator {
    public partial class frmRectangleCalculator : Form {
        public frmRectangleCalculator() {
            InitializeComponent();
            // Make centimeter squared
            lblAreaInCentimeters.Text = "cm\u00b2";
        }

        private void btnStartCalculator_Click(object sender, EventArgs e) {

            try {
                // Declare the datatypes of a variable.
                int length; 
                int width; 
                int perimeter; 
                int area; 
                int line; 
                double diagonalLength; 

                //Store the inputs from the textboxes as length and width.
                length = int.Parse(txtLengthOfRectangle.Text);
                width = int.Parse(txtWidthOfRectangle.Text);
                
                // Displays a message to try again when length = width = 0 and clears the textboxes and putput labels.
                if (length == 0 && width == 0) {
                    MessageBox.Show("You have created nothing. Try again.");
                    btnClear.PerformClick();
                }
                // Displays a message to try again when length = 0 or width = 0 and clears the textboxes and putput labels.
                else if (length == 0 || width == 0) {
                    line = length + width;
                    MessageBox.Show("You have created a line that is " + line.ToString("n0") + " cm long. Try again.");
                    btnClear.PerformClick();
                }
                else {
                    // Calculates perimeter of the rectangle and displays the perimeter in the output label.
                    perimeter = 2 * (length + width);
                    lblOutputPerimeter.Text = perimeter.ToString("n0");

                    // Calculates the area of the rectangle and displays the area in the output label.
                    area = length * width;
                    lblOutputArea.Text = area.ToString("n0");

                    /* Calculates the diagonal length of a rectangle and displays the diagonal length 
                     * in the output label rounded to two decimal points. */
                    diagonalLength = Math.Pow(length, 2) + Math.Pow(width, 2);
                    diagonalLength = Math.Sqrt(diagonalLength);
                    lblOuputDiagonalLength.Text = diagonalLength.ToString("n2");

                    // Displays a message when the rectangle is a square.
                    if (length == width) {
                        MessageBox.Show("This rectangle is a square.");
                    }
                }

            }
            catch (Exception ex) {
                // Display the default error message and clears the textboxes and output labels. 
                MessageBox.Show(ex.Message);
                btnClear.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // Closes the form.
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            // Clears the text in the textboxes and output labels.
            txtLengthOfRectangle.Text = "";
            txtWidthOfRectangle.Text = "";
            lblOutputPerimeter.Text = "";
            lblOutputArea.Text = "";
            lblOuputDiagonalLength.Text = "";

            // Puts a focus in the txtLengthOfRectangle
            txtLengthOfRectangle.Focus();

        }
    }
}
