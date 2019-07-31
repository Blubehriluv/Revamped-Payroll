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
            this.personList = new System.Windows.Forms.ListView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.basicInfo.SuspendLayout();
            this.addressInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(31, 35);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(305, 46);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Payroll Machine";
            // 
            // personList
            // 
            this.personList.Location = new System.Drawing.Point(888, 157);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(235, 808);
            this.personList.TabIndex = 1;
            this.personList.UseCompatibleStateImageBehavior = false;
            // 
            // addPersonTitle
            // 
            this.addPersonTitle.AutoSize = true;
            this.addPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonTitle.Location = new System.Drawing.Point(33, 129);
            this.addPersonTitle.Name = "addPersonTitle";
            this.addPersonTitle.Size = new System.Drawing.Size(163, 32);
            this.addPersonTitle.TabIndex = 2;
            this.addPersonTitle.Text = "Add Person";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(174, 64);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(224, 37);
            this.firstName.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(30, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(125, 26);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(30, 121);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(124, 26);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(174, 121);
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
            this.basicInfo.Location = new System.Drawing.Point(68, 185);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Size = new System.Drawing.Size(430, 264);
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
            this.aptNumLabel.Location = new System.Drawing.Point(39, 133);
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
            this.stateLabel.Location = new System.Drawing.Point(39, 247);
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
            this.pZip.Location = new System.Drawing.Point(174, 304);
            this.pZip.Name = "pZip";
            this.pZip.Size = new System.Drawing.Size(224, 37);
            this.pZip.TabIndex = 15;
            // 
            // pState
            // 
            this.pState.Location = new System.Drawing.Point(174, 247);
            this.pState.Name = "pState";
            this.pState.Size = new System.Drawing.Size(224, 37);
            this.pState.TabIndex = 16;
            // 
            // pCity
            // 
            this.pCity.Location = new System.Drawing.Point(174, 187);
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
            this.addressInfo.Location = new System.Drawing.Point(68, 469);
            this.addressInfo.Name = "addressInfo";
            this.addressInfo.Size = new System.Drawing.Size(430, 383);
            this.addressInfo.TabIndex = 20;
            this.addressInfo.TabStop = false;
            this.addressInfo.Text = "Address Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 894);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 1002);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressInfo);
            this.Controls.Add(this.basicInfo);
            this.Controls.Add(this.addPersonTitle);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.formTitle);
            this.Name = "mainForm";
            this.Text = "Payroll Machine";
            this.basicInfo.ResumeLayout(false);
            this.basicInfo.PerformLayout();
            this.addressInfo.ResumeLayout(false);
            this.addressInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.ListView personList;
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
        private System.Windows.Forms.Button button1;
    }
}

