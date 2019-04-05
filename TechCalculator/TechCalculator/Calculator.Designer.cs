namespace TechCalculator
{
	partial class Calculator
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
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonInv = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonRoot = new System.Windows.Forms.Button();
            this.ButtonRoot3 = new System.Windows.Forms.Button();
            this.ValueInput = new System.Windows.Forms.TextBox();
            this.CurrentCalculation = new System.Windows.Forms.Label();
            this.Button_C = new System.Windows.Forms.Button();
            this.Button_CE = new System.Windows.Forms.Button();
            this.ErrorDisplay = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(158, 197);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(30, 53);
            this.ButtonEquals.TabIndex = 0;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(122, 227);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(30, 23);
            this.ButtonPlus.TabIndex = 1;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(122, 197);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(30, 23);
            this.ButtonMinus.TabIndex = 2;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // ButtonMult
            // 
            this.ButtonMult.Location = new System.Drawing.Point(122, 168);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(30, 23);
            this.ButtonMult.TabIndex = 3;
            this.ButtonMult.Text = "*";
            this.ButtonMult.UseVisualStyleBackColor = true;
            this.ButtonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(122, 139);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(30, 23);
            this.ButtonDiv.TabIndex = 4;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // ButtonInv
            // 
            this.ButtonInv.Location = new System.Drawing.Point(122, 110);
            this.ButtonInv.Name = "ButtonInv";
            this.ButtonInv.Size = new System.Drawing.Size(30, 23);
            this.ButtonInv.TabIndex = 5;
            this.ButtonInv.Text = "Inv";
            this.ButtonInv.UseVisualStyleBackColor = true;
            this.ButtonInv.Click += new System.EventHandler(this.buttonInv_Click);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Location = new System.Drawing.Point(86, 227);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(30, 23);
            this.ButtonDecimal.TabIndex = 6;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = true;
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(14, 227);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(66, 23);
            this.Button0.TabIndex = 8;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(86, 197);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(30, 23);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(50, 197);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(30, 23);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(14, 197);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(30, 23);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(14, 168);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(30, 23);
            this.Button4.TabIndex = 15;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(50, 168);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(30, 23);
            this.Button5.TabIndex = 14;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(86, 168);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(30, 23);
            this.Button6.TabIndex = 13;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(14, 139);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(30, 23);
            this.Button7.TabIndex = 18;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(50, 139);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(30, 23);
            this.Button8.TabIndex = 17;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(86, 139);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(30, 23);
            this.Button9.TabIndex = 16;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            // 
            // ButtonTan
            // 
            this.ButtonTan.Location = new System.Drawing.Point(158, 168);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(30, 23);
            this.ButtonTan.TabIndex = 19;
            this.ButtonTan.Text = "tan";
            this.ButtonTan.UseVisualStyleBackColor = true;
            this.ButtonTan.Click += new System.EventHandler(this.buttonTan_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCos.Location = new System.Drawing.Point(158, 139);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(30, 23);
            this.ButtonCos.TabIndex = 20;
            this.ButtonCos.Text = "cos";
            this.ButtonCos.UseVisualStyleBackColor = true;
            this.ButtonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.Location = new System.Drawing.Point(158, 110);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(30, 23);
            this.ButtonSin.TabIndex = 21;
            this.ButtonSin.Text = "sin";
            this.ButtonSin.UseVisualStyleBackColor = true;
            this.ButtonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // ButtonRoot
            // 
            this.ButtonRoot.Location = new System.Drawing.Point(86, 110);
            this.ButtonRoot.Name = "ButtonRoot";
            this.ButtonRoot.Size = new System.Drawing.Size(30, 23);
            this.ButtonRoot.TabIndex = 22;
            this.ButtonRoot.Text = "√";
            this.ButtonRoot.UseVisualStyleBackColor = true;
            this.ButtonRoot.Click += new System.EventHandler(this.buttonRoot_Click);
            // 
            // ButtonRoot3
            // 
            this.ButtonRoot3.Location = new System.Drawing.Point(50, 110);
            this.ButtonRoot3.Name = "ButtonRoot3";
            this.ButtonRoot3.Size = new System.Drawing.Size(30, 23);
            this.ButtonRoot3.TabIndex = 23;
            this.ButtonRoot3.Text = "∛";
            this.ButtonRoot3.UseVisualStyleBackColor = true;
            this.ButtonRoot3.Click += new System.EventHandler(this.buttonRoot3_Click);
            // 
            // ValueInput
            // 
            this.ValueInput.Location = new System.Drawing.Point(14, 43);
            this.ValueInput.Name = "ValueInput";
            this.ValueInput.ReadOnly = true;
            this.ValueInput.Size = new System.Drawing.Size(172, 20);
            this.ValueInput.TabIndex = 24;
            // 
            // CurrentCalculation
            // 
            this.CurrentCalculation.AutoSize = true;
            this.CurrentCalculation.Location = new System.Drawing.Point(14, 24);
            this.CurrentCalculation.Name = "CurrentCalculation";
            this.CurrentCalculation.Size = new System.Drawing.Size(0, 13);
            this.CurrentCalculation.TabIndex = 25;
            // 
            // Button_C
            // 
            this.Button_C.Location = new System.Drawing.Point(158, 81);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(28, 23);
            this.Button_C.TabIndex = 26;
            this.Button_C.Text = "C";
            this.Button_C.UseVisualStyleBackColor = true;
            this.Button_C.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // Button_CE
            // 
            this.Button_CE.Location = new System.Drawing.Point(122, 81);
            this.Button_CE.Name = "Button_CE";
            this.Button_CE.Size = new System.Drawing.Size(30, 23);
            this.Button_CE.TabIndex = 27;
            this.Button_CE.Text = "CE";
            this.Button_CE.UseVisualStyleBackColor = true;
            this.Button_CE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // ErrorDisplay
            // 
            this.ErrorDisplay.AutoSize = true;
            this.ErrorDisplay.Location = new System.Drawing.Point(3, 3);
            this.ErrorDisplay.Name = "ErrorDisplay";
            this.ErrorDisplay.Size = new System.Drawing.Size(0, 13);
            this.ErrorDisplay.TabIndex = 28;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(50, 81);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(66, 23);
            this.ButtonDelete.TabIndex = 29;
            this.ButtonDelete.Text = "<-";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 262);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ErrorDisplay);
            this.Controls.Add(this.Button_CE);
            this.Controls.Add(this.Button_C);
            this.Controls.Add(this.CurrentCalculation);
            this.Controls.Add(this.ValueInput);
            this.Controls.Add(this.ButtonRoot3);
            this.Controls.Add(this.ButtonRoot);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.ButtonInv);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonMult);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonEquals);
            this.Name = "Calculator";
            this.Text = "Calculator - P459018";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonEquals;
		private System.Windows.Forms.Button ButtonPlus;
		private System.Windows.Forms.Button ButtonMinus;
		private System.Windows.Forms.Button ButtonMult;
		private System.Windows.Forms.Button ButtonDiv;
		private System.Windows.Forms.Button ButtonInv;
		private System.Windows.Forms.Button ButtonDecimal;
		private System.Windows.Forms.Button Button0;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button Button5;
		private System.Windows.Forms.Button Button6;
		private System.Windows.Forms.Button Button7;
		private System.Windows.Forms.Button Button8;
		private System.Windows.Forms.Button Button9;
		private System.Windows.Forms.Button ButtonTan;
		private System.Windows.Forms.Button ButtonCos;
		private System.Windows.Forms.Button ButtonSin;
		private System.Windows.Forms.Button ButtonRoot;
		private System.Windows.Forms.Button ButtonRoot3;
		private System.Windows.Forms.TextBox ValueInput;
        private System.Windows.Forms.Label CurrentCalculation;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_CE;
        private System.Windows.Forms.Label ErrorDisplay;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

