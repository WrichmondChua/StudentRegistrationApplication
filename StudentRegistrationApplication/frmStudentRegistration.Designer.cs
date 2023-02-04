
namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelStudentRegistrationForm = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TxtboxLastName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TxtboxFirstName = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.TxtboxMiddleName = new System.Windows.Forms.TextBox();
            this.LabelGender = new System.Windows.Forms.Label();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxDay = new System.Windows.Forms.ComboBox();
            this.ComboBoxMonth = new System.Windows.Forms.ComboBox();
            this.ComboBoxYear = new System.Windows.Forms.ComboBox();
            this.BtnRegisterStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelStudentRegistrationForm
            // 
            this.LabelStudentRegistrationForm.AutoSize = true;
            this.LabelStudentRegistrationForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelStudentRegistrationForm.Location = new System.Drawing.Point(62, 9);
            this.LabelStudentRegistrationForm.Name = "LabelStudentRegistrationForm";
            this.LabelStudentRegistrationForm.Size = new System.Drawing.Size(210, 21);
            this.LabelStudentRegistrationForm.TabIndex = 0;
            this.LabelStudentRegistrationForm.Text = "Student Registration Form";
            this.LabelStudentRegistrationForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLastName.Location = new System.Drawing.Point(8, 42);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(101, 21);
            this.LabelLastName.TabIndex = 1;
            this.LabelLastName.Text = "Last Name *";
            // 
            // TxtboxLastName
            // 
            this.TxtboxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtboxLastName.Location = new System.Drawing.Point(12, 66);
            this.TxtboxLastName.Name = "TxtboxLastName";
            this.TxtboxLastName.Size = new System.Drawing.Size(297, 29);
            this.TxtboxLastName.TabIndex = 2;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFirstName.Location = new System.Drawing.Point(8, 98);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(103, 21);
            this.LabelFirstName.TabIndex = 3;
            this.LabelFirstName.Text = "First Name *";
            // 
            // TxtboxFirstName
            // 
            this.TxtboxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtboxFirstName.Location = new System.Drawing.Point(12, 122);
            this.TxtboxFirstName.Name = "TxtboxFirstName";
            this.TxtboxFirstName.Size = new System.Drawing.Size(297, 29);
            this.TxtboxFirstName.TabIndex = 4;
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMiddleName.Location = new System.Drawing.Point(8, 154);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(125, 21);
            this.LabelMiddleName.TabIndex = 5;
            this.LabelMiddleName.Text = "Middle Name *";
            // 
            // TxtboxMiddleName
            // 
            this.TxtboxMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtboxMiddleName.Location = new System.Drawing.Point(12, 178);
            this.TxtboxMiddleName.Name = "TxtboxMiddleName";
            this.TxtboxMiddleName.Size = new System.Drawing.Size(297, 29);
            this.TxtboxMiddleName.TabIndex = 6;
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelGender.Location = new System.Drawing.Point(8, 210);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(76, 21);
            this.LabelGender.TabIndex = 7;
            this.LabelGender.Text = "Gender *";
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonMale.Location = new System.Drawing.Point(86, 208);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(62, 25);
            this.RadioButtonMale.TabIndex = 8;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonFemale.Location = new System.Drawing.Point(154, 208);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(78, 25);
            this.RadioButtonFemale.TabIndex = 9;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date of Birth *";
            // 
            // ComboBoxDay
            // 
            this.ComboBoxDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxDay.FormattingEnabled = true;
            this.ComboBoxDay.Location = new System.Drawing.Point(11, 260);
            this.ComboBoxDay.Name = "ComboBoxDay";
            this.ComboBoxDay.Size = new System.Drawing.Size(120, 29);
            this.ComboBoxDay.TabIndex = 11;
            this.ComboBoxDay.Text = "-Day-";
            // 
            // ComboBoxMonth
            // 
            this.ComboBoxMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxMonth.FormattingEnabled = true;
            this.ComboBoxMonth.Location = new System.Drawing.Point(137, 260);
            this.ComboBoxMonth.Name = "ComboBoxMonth";
            this.ComboBoxMonth.Size = new System.Drawing.Size(84, 29);
            this.ComboBoxMonth.TabIndex = 12;
            this.ComboBoxMonth.Text = "-Month-";
            // 
            // ComboBoxYear
            // 
            this.ComboBoxYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxYear.FormattingEnabled = true;
            this.ComboBoxYear.Location = new System.Drawing.Point(239, 260);
            this.ComboBoxYear.Name = "ComboBoxYear";
            this.ComboBoxYear.Size = new System.Drawing.Size(114, 29);
            this.ComboBoxYear.TabIndex = 13;
            this.ComboBoxYear.Text = "-Year-";
            // 
            // BtnRegisterStudent
            // 
            this.BtnRegisterStudent.BackColor = System.Drawing.Color.Crimson;
            this.BtnRegisterStudent.ForeColor = System.Drawing.Color.White;
            this.BtnRegisterStudent.Location = new System.Drawing.Point(8, 295);
            this.BtnRegisterStudent.Name = "BtnRegisterStudent";
            this.BtnRegisterStudent.Size = new System.Drawing.Size(131, 32);
            this.BtnRegisterStudent.TabIndex = 14;
            this.BtnRegisterStudent.Text = "Register Student";
            this.BtnRegisterStudent.UseVisualStyleBackColor = false;
            this.BtnRegisterStudent.Click += new System.EventHandler(this.BtnRegisterStudent_Click);
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 330);
            this.Controls.Add(this.BtnRegisterStudent);
            this.Controls.Add(this.ComboBoxYear);
            this.Controls.Add(this.ComboBoxMonth);
            this.Controls.Add(this.ComboBoxDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.TxtboxMiddleName);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.TxtboxFirstName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.TxtboxLastName);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelStudentRegistrationForm);
            this.Name = "frmStudentRegistration";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStudentRegistrationForm;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TxtboxLastName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox TxtboxFirstName;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox TxtboxMiddleName;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxDay;
        private System.Windows.Forms.ComboBox ComboBoxMonth;
        private System.Windows.Forms.ComboBox ComboxBoxYear;
        private System.Windows.Forms.Button BtnRegisterStudent;
        private System.Windows.Forms.ComboBox ComboBoxYear;
    }
}

