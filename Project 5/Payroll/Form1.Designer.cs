namespace Payroll
{
    partial class mainForm
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
            this.formTitle = new System.Windows.Forms.Label();
            this.addPersonTitle = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.basicInfo = new System.Windows.Forms.GroupBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.aptNumLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.pZip = new System.Windows.Forms.TextBox();
            this.pState = new System.Windows.Forms.TextBox();
            this.pCity = new System.Windows.Forms.TextBox();
            this.pAptNum = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.addressInfo = new System.Windows.Forms.GroupBox();
            this.personList = new System.Windows.Forms.ListBox();
            this.hirePerson = new System.Windows.Forms.Button();
            this.employeeInfo = new System.Windows.Forms.GroupBox();
            this.payrollNo = new System.Windows.Forms.RadioButton();
            this.payrollYes = new System.Windows.Forms.RadioButton();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.empWage = new System.Windows.Forms.TextBox();
            this.wageLabel = new System.Windows.Forms.Label();
            this.empHours = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.payrolLabel = new System.Windows.Forms.Label();
            this.generateHuman = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.payEmployees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.basicInfo.SuspendLayout();
            this.addressInfo.SuspendLayout();
            this.employeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(16, 28);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(305, 46);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Payroll Machine";
            // 
            // addPersonTitle
            // 
            this.addPersonTitle.AutoSize = true;
            this.addPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonTitle.Location = new System.Drawing.Point(20, 108);
            this.addPersonTitle.Name = "addPersonTitle";
            this.addPersonTitle.Size = new System.Drawing.Size(911, 32);
            this.addPersonTitle.TabIndex = 2;
            this.addPersonTitle.Text = "Add people to the Payroll Machine database and pay them accordingly.";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(174, 65);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(224, 37);
            this.firstName.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(30, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(125, 26);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(30, 122);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(124, 26);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(174, 122);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(224, 37);
            this.lastName.TabIndex = 6;
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.Location = new System.Drawing.Point(30, 178);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(99, 26);
            this.phoneNumLabel.TabIndex = 7;
            this.phoneNumLabel.Text = "Phone #:";
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(174, 178);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(224, 37);
            this.phoneNum.TabIndex = 8;
            // 
            // basicInfo
            // 
            this.basicInfo.Controls.Add(this.firstNameLabel);
            this.basicInfo.Controls.Add(this.phoneNum);
            this.basicInfo.Controls.Add(this.firstName);
            this.basicInfo.Controls.Add(this.phoneNumLabel);
            this.basicInfo.Controls.Add(this.lastNameLabel);
            this.basicInfo.Controls.Add(this.lastName);
            this.basicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicInfo.Location = new System.Drawing.Point(38, 188);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Size = new System.Drawing.Size(430, 265);
            this.basicInfo.TabIndex = 9;
            this.basicInfo.TabStop = false;
            this.basicInfo.Text = "Basic Information";
            this.basicInfo.Enter += new System.EventHandler(this.basicInfo_Enter);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(39, 78);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(98, 26);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address:";
            // 
            // aptNumLabel
            // 
            this.aptNumLabel.AutoSize = true;
            this.aptNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptNumLabel.Location = new System.Drawing.Point(39, 132);
            this.aptNumLabel.Name = "aptNumLabel";
            this.aptNumLabel.Size = new System.Drawing.Size(137, 26);
            this.aptNumLabel.TabIndex = 11;
            this.aptNumLabel.Text = "Apartment #:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(39, 189);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(56, 26);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(39, 248);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(69, 26);
            this.stateLabel.TabIndex = 13;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(39, 303);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(48, 26);
            this.zipLabel.TabIndex = 14;
            this.zipLabel.Text = "Zip:";
            // 
            // pZip
            // 
            this.pZip.Location = new System.Drawing.Point(174, 305);
            this.pZip.Name = "pZip";
            this.pZip.Size = new System.Drawing.Size(224, 37);
            this.pZip.TabIndex = 15;
            // 
            // pState
            // 
            this.pState.Location = new System.Drawing.Point(174, 248);
            this.pState.Name = "pState";
            this.pState.Size = new System.Drawing.Size(224, 37);
            this.pState.TabIndex = 16;
            // 
            // pCity
            // 
            this.pCity.Location = new System.Drawing.Point(174, 188);
            this.pCity.Name = "pCity";
            this.pCity.Size = new System.Drawing.Size(224, 37);
            this.pCity.TabIndex = 17;
            // 
            // pAptNum
            // 
            this.pAptNum.Location = new System.Drawing.Point(174, 128);
            this.pAptNum.Name = "pAptNum";
            this.pAptNum.Size = new System.Drawing.Size(224, 37);
            this.pAptNum.TabIndex = 18;
            // 
            // pAddress
            // 
            this.pAddress.Location = new System.Drawing.Point(174, 71);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(224, 37);
            this.pAddress.TabIndex = 19;
            // 
            // addressInfo
            // 
            this.addressInfo.Controls.Add(this.pAddress);
            this.addressInfo.Controls.Add(this.addressLabel);
            this.addressInfo.Controls.Add(this.pAptNum);
            this.addressInfo.Controls.Add(this.aptNumLabel);
            this.addressInfo.Controls.Add(this.pCity);
            this.addressInfo.Controls.Add(this.pZip);
            this.addressInfo.Controls.Add(this.pState);
            this.addressInfo.Controls.Add(this.cityLabel);
            this.addressInfo.Controls.Add(this.stateLabel);
            this.addressInfo.Controls.Add(this.zipLabel);
            this.addressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInfo.Location = new System.Drawing.Point(32, 514);
            this.addressInfo.Name = "addressInfo";
            this.addressInfo.Size = new System.Drawing.Size(430, 383);
            this.addressInfo.TabIndex = 20;
            this.addressInfo.TabStop = false;
            this.addressInfo.Text = "Address Information";
            // 
            // personList
            // 
            this.personList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personList.FormattingEnabled = true;
            this.personList.ItemHeight = 25;
            this.personList.Location = new System.Drawing.Point(1010, 332);
            this.personList.Name = "personList";
            this.personList.ScrollAlwaysVisible = true;
            this.personList.Size = new System.Drawing.Size(319, 704);
            this.personList.TabIndex = 22;
            this.personList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personList_MouseDoubleClick);
            // 
            // hirePerson
            // 
            this.hirePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hirePerson.Location = new System.Drawing.Point(148, 935);
            this.hirePerson.Name = "hirePerson";
            this.hirePerson.Size = new System.Drawing.Size(170, 52);
            this.hirePerson.TabIndex = 23;
            this.hirePerson.Text = "Hire Person";
            this.hirePerson.UseVisualStyleBackColor = true;
            this.hirePerson.Click += new System.EventHandler(this.hirePerson_Click);
            // 
            // employeeInfo
            // 
            this.employeeInfo.Controls.Add(this.payrollNo);
            this.employeeInfo.Controls.Add(this.payrollYes);
            this.employeeInfo.Controls.Add(this.jobTitle);
            this.employeeInfo.Controls.Add(this.jobTitleLabel);
            this.employeeInfo.Controls.Add(this.empWage);
            this.employeeInfo.Controls.Add(this.wageLabel);
            this.employeeInfo.Controls.Add(this.empHours);
            this.employeeInfo.Controls.Add(this.hoursLabel);
            this.employeeInfo.Controls.Add(this.payrolLabel);
            this.employeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfo.Location = new System.Drawing.Point(518, 188);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Size = new System.Drawing.Size(430, 383);
            this.employeeInfo.TabIndex = 24;
            this.employeeInfo.TabStop = false;
            this.employeeInfo.Text = "Employee Info";
            // 
            // payrollNo
            // 
            this.payrollNo.AutoSize = true;
            this.payrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollNo.Location = new System.Drawing.Point(332, 248);
            this.payrollNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payrollNo.Name = "payrollNo";
            this.payrollNo.Size = new System.Drawing.Size(65, 30);
            this.payrollNo.TabIndex = 21;
            this.payrollNo.TabStop = true;
            this.payrollNo.Text = "No";
            this.payrollNo.UseVisualStyleBackColor = true;
            // 
            // payrollYes
            // 
            this.payrollYes.AutoSize = true;
            this.payrollYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollYes.Location = new System.Drawing.Point(174, 248);
            this.payrollYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payrollYes.Name = "payrollYes";
            this.payrollYes.Size = new System.Drawing.Size(76, 30);
            this.payrollYes.TabIndex = 20;
            this.payrollYes.TabStop = true;
            this.payrollYes.Text = "Yes";
            this.payrollYes.UseVisualStyleBackColor = true;
            // 
            // jobTitle
            // 
            this.jobTitle.Location = new System.Drawing.Point(174, 71);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(224, 37);
            this.jobTitle.TabIndex = 19;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(39, 78);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(99, 26);
            this.jobTitleLabel.TabIndex = 10;
            this.jobTitleLabel.Text = "Job Title:";
            // 
            // empWage
            // 
            this.empWage.Location = new System.Drawing.Point(174, 128);
            this.empWage.Name = "empWage";
            this.empWage.Size = new System.Drawing.Size(224, 37);
            this.empWage.TabIndex = 18;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wageLabel.Location = new System.Drawing.Point(39, 134);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(75, 26);
            this.wageLabel.TabIndex = 11;
            this.wageLabel.Text = "Wage:";
            // 
            // empHours
            // 
            this.empHours.Location = new System.Drawing.Point(174, 188);
            this.empHours.Name = "empHours";
            this.empHours.Size = new System.Drawing.Size(224, 37);
            this.empHours.TabIndex = 17;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(39, 189);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(76, 26);
            this.hoursLabel.TabIndex = 12;
            this.hoursLabel.Text = "Hours:";
            // 
            // payrolLabel
            // 
            this.payrolLabel.AutoSize = true;
            this.payrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolLabel.Location = new System.Drawing.Point(39, 245);
            this.payrolLabel.Name = "payrolLabel";
            this.payrolLabel.Size = new System.Drawing.Size(85, 26);
            this.payrolLabel.TabIndex = 13;
            this.payrolLabel.Text = "Payroll:";
            // 
            // generateHuman
            // 
            this.generateHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateHuman.Location = new System.Drawing.Point(1083, 191);
            this.generateHuman.Name = "generateHuman";
            this.generateHuman.Size = new System.Drawing.Size(170, 52);
            this.generateHuman.TabIndex = 25;
            this.generateHuman.Text = "Generate";
            this.generateHuman.UseVisualStyleBackColor = true;
            this.generateHuman.Click += new System.EventHandler(this.generateHuman_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 675);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(428, 376);
            this.textBox1.TabIndex = 26;
            // 
            // payEmployees
            // 
            this.payEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payEmployees.Location = new System.Drawing.Point(645, 597);
            this.payEmployees.Name = "payEmployees";
            this.payEmployees.Size = new System.Drawing.Size(170, 52);
            this.payEmployees.TabIndex = 27;
            this.payEmployees.Text = "Payroll";
            this.payEmployees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1010, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee List";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 1094);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payEmployees);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generateHuman);
            this.Controls.Add(this.employeeInfo);
            this.Controls.Add(this.hirePerson);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.addressInfo);
            this.Controls.Add(this.basicInfo);
            this.Controls.Add(this.addPersonTitle);
            this.Controls.Add(this.formTitle);
            this.Name = "mainForm";
            this.Text = "Payroll Machine";
            this.basicInfo.ResumeLayout(false);
            this.basicInfo.PerformLayout();
            this.addressInfo.ResumeLayout(false);
            this.addressInfo.PerformLayout();
            this.employeeInfo.ResumeLayout(false);
            this.employeeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label addPersonTitle;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.GroupBox basicInfo;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label aptNumLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox pZip;
        private System.Windows.Forms.TextBox pState;
        private System.Windows.Forms.TextBox pCity;
        private System.Windows.Forms.TextBox pAptNum;
        private System.Windows.Forms.TextBox pAddress;
        private System.Windows.Forms.GroupBox addressInfo;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Button hirePerson;
        private System.Windows.Forms.GroupBox employeeInfo;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox empWage;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.TextBox empHours;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label payrolLabel;
        private System.Windows.Forms.RadioButton payrollNo;
        private System.Windows.Forms.RadioButton payrollYes;
        private System.Windows.Forms.Button generateHuman;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button payEmployees;
        private System.Windows.Forms.Label label1;
    }
}

