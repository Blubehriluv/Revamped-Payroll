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
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.empWage = new System.Windows.Forms.TextBox();
            this.wageLabel = new System.Windows.Forms.Label();
            this.empHours = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.payrolLabel = new System.Windows.Forms.Label();
            this.payrollYes = new System.Windows.Forms.RadioButton();
            this.payrollNo = new System.Windows.Forms.RadioButton();
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
            this.formTitle.Location = new System.Drawing.Point(11, 18);
            this.formTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(206, 31);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Payroll Machine";
            // 
            // addPersonTitle
            // 
            this.addPersonTitle.AutoSize = true;
            this.addPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonTitle.Location = new System.Drawing.Point(13, 70);
            this.addPersonTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPersonTitle.Name = "addPersonTitle";
            this.addPersonTitle.Size = new System.Drawing.Size(110, 24);
            this.addPersonTitle.TabIndex = 2;
            this.addPersonTitle.Text = "Add Person";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(116, 42);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(151, 27);
            this.firstName.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(20, 42);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 18);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(20, 79);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(116, 79);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(151, 27);
            this.lastName.TabIndex = 6;
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.Location = new System.Drawing.Point(20, 116);
            this.phoneNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(67, 18);
            this.phoneNumLabel.TabIndex = 7;
            this.phoneNumLabel.Text = "Phone #:";
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(116, 116);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(151, 27);
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
            this.basicInfo.Location = new System.Drawing.Point(17, 122);
            this.basicInfo.Margin = new System.Windows.Forms.Padding(2);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Padding = new System.Windows.Forms.Padding(2);
            this.basicInfo.Size = new System.Drawing.Size(287, 172);
            this.basicInfo.TabIndex = 9;
            this.basicInfo.TabStop = false;
            this.basicInfo.Text = "Basic Information";
            this.basicInfo.Enter += new System.EventHandler(this.basicInfo_Enter);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(26, 51);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 18);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address:";
            // 
            // aptNumLabel
            // 
            this.aptNumLabel.AutoSize = true;
            this.aptNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptNumLabel.Location = new System.Drawing.Point(26, 86);
            this.aptNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aptNumLabel.Name = "aptNumLabel";
            this.aptNumLabel.Size = new System.Drawing.Size(91, 18);
            this.aptNumLabel.TabIndex = 11;
            this.aptNumLabel.Text = "Apartment #:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(26, 123);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 18);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(26, 161);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 18);
            this.stateLabel.TabIndex = 13;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(26, 197);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 18);
            this.zipLabel.TabIndex = 14;
            this.zipLabel.Text = "Zip:";
            // 
            // pZip
            // 
            this.pZip.Location = new System.Drawing.Point(116, 198);
            this.pZip.Margin = new System.Windows.Forms.Padding(2);
            this.pZip.Name = "pZip";
            this.pZip.Size = new System.Drawing.Size(151, 27);
            this.pZip.TabIndex = 15;
            // 
            // pState
            // 
            this.pState.Location = new System.Drawing.Point(116, 161);
            this.pState.Margin = new System.Windows.Forms.Padding(2);
            this.pState.Name = "pState";
            this.pState.Size = new System.Drawing.Size(151, 27);
            this.pState.TabIndex = 16;
            // 
            // pCity
            // 
            this.pCity.Location = new System.Drawing.Point(116, 122);
            this.pCity.Margin = new System.Windows.Forms.Padding(2);
            this.pCity.Name = "pCity";
            this.pCity.Size = new System.Drawing.Size(151, 27);
            this.pCity.TabIndex = 17;
            // 
            // pAptNum
            // 
            this.pAptNum.Location = new System.Drawing.Point(116, 83);
            this.pAptNum.Margin = new System.Windows.Forms.Padding(2);
            this.pAptNum.Name = "pAptNum";
            this.pAptNum.Size = new System.Drawing.Size(151, 27);
            this.pAptNum.TabIndex = 18;
            // 
            // pAddress
            // 
            this.pAddress.Location = new System.Drawing.Point(116, 46);
            this.pAddress.Margin = new System.Windows.Forms.Padding(2);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(151, 27);
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
            this.addressInfo.Location = new System.Drawing.Point(13, 334);
            this.addressInfo.Margin = new System.Windows.Forms.Padding(2);
            this.addressInfo.Name = "addressInfo";
            this.addressInfo.Padding = new System.Windows.Forms.Padding(2);
            this.addressInfo.Size = new System.Drawing.Size(287, 249);
            this.addressInfo.TabIndex = 20;
            this.addressInfo.TabStop = false;
            this.addressInfo.Text = "Address Information";
            // 
            // personList
            // 
            this.personList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personList.FormattingEnabled = true;
            this.personList.ItemHeight = 16;
            this.personList.Location = new System.Drawing.Point(692, 216);
            this.personList.Margin = new System.Windows.Forms.Padding(2);
            this.personList.Name = "personList";
            this.personList.ScrollAlwaysVisible = true;
            this.personList.Size = new System.Drawing.Size(214, 468);
            this.personList.TabIndex = 22;
            this.personList.SelectedIndexChanged += new System.EventHandler(this.personList_SelectedIndexChanged);
            // 
            // hirePerson
            // 
            this.hirePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hirePerson.Location = new System.Drawing.Point(91, 608);
            this.hirePerson.Margin = new System.Windows.Forms.Padding(2);
            this.hirePerson.Name = "hirePerson";
            this.hirePerson.Size = new System.Drawing.Size(113, 34);
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
            this.employeeInfo.Location = new System.Drawing.Point(334, 117);
            this.employeeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Padding = new System.Windows.Forms.Padding(2);
            this.employeeInfo.Size = new System.Drawing.Size(287, 249);
            this.employeeInfo.TabIndex = 24;
            this.employeeInfo.TabStop = false;
            this.employeeInfo.Text = "Employee Info";
            // 
            // jobTitle
            // 
            this.jobTitle.Location = new System.Drawing.Point(116, 46);
            this.jobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(151, 27);
            this.jobTitle.TabIndex = 19;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(26, 51);
            this.jobTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(68, 18);
            this.jobTitleLabel.TabIndex = 10;
            this.jobTitleLabel.Text = "Job Title:";
            // 
            // empWage
            // 
            this.empWage.Location = new System.Drawing.Point(116, 83);
            this.empWage.Margin = new System.Windows.Forms.Padding(2);
            this.empWage.Name = "empWage";
            this.empWage.Size = new System.Drawing.Size(151, 27);
            this.empWage.TabIndex = 18;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wageLabel.Location = new System.Drawing.Point(26, 87);
            this.wageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(51, 18);
            this.wageLabel.TabIndex = 11;
            this.wageLabel.Text = "Wage:";
            // 
            // empHours
            // 
            this.empHours.Location = new System.Drawing.Point(116, 122);
            this.empHours.Margin = new System.Windows.Forms.Padding(2);
            this.empHours.Name = "empHours";
            this.empHours.Size = new System.Drawing.Size(151, 27);
            this.empHours.TabIndex = 17;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(26, 123);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(53, 18);
            this.hoursLabel.TabIndex = 12;
            this.hoursLabel.Text = "Hours:";
            // 
            // payrolLabel
            // 
            this.payrolLabel.AutoSize = true;
            this.payrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrolLabel.Location = new System.Drawing.Point(26, 159);
            this.payrolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.payrolLabel.Name = "payrolLabel";
            this.payrolLabel.Size = new System.Drawing.Size(57, 18);
            this.payrolLabel.TabIndex = 13;
            this.payrolLabel.Text = "Payroll:";
            // 
            // payrollYes
            // 
            this.payrollYes.AutoSize = true;
            this.payrollYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollYes.Location = new System.Drawing.Point(116, 161);
            this.payrollYes.Name = "payrollYes";
            this.payrollYes.Size = new System.Drawing.Size(51, 22);
            this.payrollYes.TabIndex = 20;
            this.payrollYes.TabStop = true;
            this.payrollYes.Text = "Yes";
            this.payrollYes.UseVisualStyleBackColor = true;
            // 
            // payrollNo
            // 
            this.payrollNo.AutoSize = true;
            this.payrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollNo.Location = new System.Drawing.Point(221, 161);
            this.payrollNo.Name = "payrollNo";
            this.payrollNo.Size = new System.Drawing.Size(46, 22);
            this.payrollNo.TabIndex = 21;
            this.payrollNo.TabStop = true;
            this.payrollNo.Text = "No";
            this.payrollNo.UseVisualStyleBackColor = true;
            // 
            // generateHuman
            // 
            this.generateHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateHuman.Location = new System.Drawing.Point(421, 385);
            this.generateHuman.Margin = new System.Windows.Forms.Padding(2);
            this.generateHuman.Name = "generateHuman";
            this.generateHuman.Size = new System.Drawing.Size(113, 34);
            this.generateHuman.TabIndex = 25;
            this.generateHuman.Text = "Generate";
            this.generateHuman.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 439);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(287, 246);
            this.textBox1.TabIndex = 26;
            // 
            // payEmployees
            // 
            this.payEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payEmployees.Location = new System.Drawing.Point(739, 122);
            this.payEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.payEmployees.Name = "payEmployees";
            this.payEmployees.Size = new System.Drawing.Size(113, 34);
            this.payEmployees.TabIndex = 27;
            this.payEmployees.Text = "Payroll";
            this.payEmployees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee List";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 711);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

