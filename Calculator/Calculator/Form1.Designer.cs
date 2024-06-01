
namespace Calculator
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
            this.back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ce = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.pm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkCyan;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(7, 105);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 60);
            this.back.TabIndex = 0;
            this.back.Text = "⌫";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 64);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.DarkCyan;
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(98, 105);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(85, 60);
            this.ce.TabIndex = 11;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.DarkCyan;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(189, 105);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(85, 60);
            this.c.TabIndex = 12;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.DarkCyan;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(284, 171);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(85, 60);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operators);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.DarkCyan;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(189, 171);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(85, 60);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.NumericValue);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.DarkCyan;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(7, 237);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(85, 60);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.NumericValue);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.DarkCyan;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(98, 237);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(85, 60);
            this.five.TabIndex = 17;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.NumericValue);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.DarkCyan;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(284, 237);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(85, 60);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operators);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.DarkCyan;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(98, 171);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(85, 60);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.NumericValue);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.DarkCyan;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(7, 171);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(85, 60);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.NumericValue);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.DarkCyan;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(189, 237);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(85, 60);
            this.six.TabIndex = 21;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.NumericValue);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.DarkCyan;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(7, 303);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(85, 60);
            this.one.TabIndex = 22;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.NumericValue);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.DarkCyan;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(189, 303);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(85, 60);
            this.three.TabIndex = 23;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.NumericValue);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.DarkCyan;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(284, 369);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(85, 60);
            this.divide.TabIndex = 24;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operators);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.DarkCyan;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(98, 369);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(85, 60);
            this.point.TabIndex = 25;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.NumericValue);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.DarkCyan;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(284, 303);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(85, 60);
            this.mul.TabIndex = 26;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.operators);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.DarkCyan;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(98, 303);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(85, 60);
            this.two.TabIndex = 27;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.NumericValue);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.DarkCyan;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(193, 369);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(85, 60);
            this.equal.TabIndex = 28;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.DarkCyan;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(7, 369);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(85, 60);
            this.zero.TabIndex = 29;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.NumericValue);
            // 
            // pm
            // 
            this.pm.BackColor = System.Drawing.Color.DarkCyan;
            this.pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm.Location = new System.Drawing.Point(280, 105);
            this.pm.Name = "pm";
            this.pm.Size = new System.Drawing.Size(85, 60);
            this.pm.TabIndex = 30;
            this.pm.Text = "±";
            this.pm.UseVisualStyleBackColor = false;
            this.pm.Click += new System.EventHandler(this.pm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 439);
            this.Controls.Add(this.pm);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.two);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.point);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.c);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button pm;
    }
}

