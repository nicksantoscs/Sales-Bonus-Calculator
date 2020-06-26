namespace A1_COMP1098
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeName_Label = new System.Windows.Forms.Label();
            this.employeeName_Textbox = new System.Windows.Forms.TextBox();
            this.employeeId_Textbox = new System.Windows.Forms.TextBox();
            this.hoursWorked_Textbox = new System.Windows.Forms.TextBox();
            this.employeeId_Label = new System.Windows.Forms.Label();
            this.hoursWorked_Label = new System.Windows.Forms.Label();
            this.totalSales_Label = new System.Windows.Forms.Label();
            this.totalSales_Textbox = new System.Windows.Forms.TextBox();
            this.salesBonus_Textbox = new System.Windows.Forms.TextBox();
            this.salesBonus_Label = new System.Windows.Forms.Label();
            this.print_Button = new System.Windows.Forms.Button();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.language_Groupbox = new System.Windows.Forms.GroupBox();
            this.portuguese_RadioButton = new System.Windows.Forms.RadioButton();
            this.french_RadioButton = new System.Windows.Forms.RadioButton();
            this.english_RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.language_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // employeeName_Label
            // 
            resources.ApplyResources(this.employeeName_Label, "employeeName_Label");
            this.employeeName_Label.Name = "employeeName_Label";
            // 
            // employeeName_Textbox
            // 
            resources.ApplyResources(this.employeeName_Textbox, "employeeName_Textbox");
            this.employeeName_Textbox.Name = "employeeName_Textbox";
            // 
            // employeeId_Textbox
            // 
            resources.ApplyResources(this.employeeId_Textbox, "employeeId_Textbox");
            this.employeeId_Textbox.Name = "employeeId_Textbox";
            // 
            // hoursWorked_Textbox
            // 
            resources.ApplyResources(this.hoursWorked_Textbox, "hoursWorked_Textbox");
            this.hoursWorked_Textbox.Name = "hoursWorked_Textbox";
            this.hoursWorked_Textbox.Validating += new System.ComponentModel.CancelEventHandler(this.hoursWorked_Textbox_Validating);
            // 
            // employeeId_Label
            // 
            resources.ApplyResources(this.employeeId_Label, "employeeId_Label");
            this.employeeId_Label.Name = "employeeId_Label";
            // 
            // hoursWorked_Label
            // 
            resources.ApplyResources(this.hoursWorked_Label, "hoursWorked_Label");
            this.hoursWorked_Label.Name = "hoursWorked_Label";
            // 
            // totalSales_Label
            // 
            resources.ApplyResources(this.totalSales_Label, "totalSales_Label");
            this.totalSales_Label.Name = "totalSales_Label";
            // 
            // totalSales_Textbox
            // 
            resources.ApplyResources(this.totalSales_Textbox, "totalSales_Textbox");
            this.totalSales_Textbox.Name = "totalSales_Textbox";
            this.totalSales_Textbox.Validating += new System.ComponentModel.CancelEventHandler(this.totalSales_Textbox_Validating);
            // 
            // salesBonus_Textbox
            // 
            resources.ApplyResources(this.salesBonus_Textbox, "salesBonus_Textbox");
            this.salesBonus_Textbox.Name = "salesBonus_Textbox";
            this.salesBonus_Textbox.ReadOnly = true;
            // 
            // salesBonus_Label
            // 
            resources.ApplyResources(this.salesBonus_Label, "salesBonus_Label");
            this.salesBonus_Label.Name = "salesBonus_Label";
            // 
            // print_Button
            // 
            resources.ApplyResources(this.print_Button, "print_Button");
            this.print_Button.Name = "print_Button";
            this.print_Button.UseVisualStyleBackColor = true;
            this.print_Button.Click += new System.EventHandler(this.print_Button_Click);
            // 
            // calculate_Button
            // 
            resources.ApplyResources(this.calculate_Button, "calculate_Button");
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            resources.ApplyResources(this.clear_Button, "clear_Button");
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // language_Groupbox
            // 
            this.language_Groupbox.Controls.Add(this.portuguese_RadioButton);
            this.language_Groupbox.Controls.Add(this.french_RadioButton);
            this.language_Groupbox.Controls.Add(this.english_RadioButton);
            resources.ApplyResources(this.language_Groupbox, "language_Groupbox");
            this.language_Groupbox.Name = "language_Groupbox";
            this.language_Groupbox.TabStop = false;
            // 
            // portuguese_RadioButton
            // 
            resources.ApplyResources(this.portuguese_RadioButton, "portuguese_RadioButton");
            this.portuguese_RadioButton.Name = "portuguese_RadioButton";
            this.portuguese_RadioButton.TabStop = true;
            this.portuguese_RadioButton.UseVisualStyleBackColor = true;
            this.portuguese_RadioButton.CheckedChanged += new System.EventHandler(this.portuguese_RadioButton_CheckedChanged);
            // 
            // french_RadioButton
            // 
            resources.ApplyResources(this.french_RadioButton, "french_RadioButton");
            this.french_RadioButton.Name = "french_RadioButton";
            this.french_RadioButton.TabStop = true;
            this.french_RadioButton.UseVisualStyleBackColor = true;
            this.french_RadioButton.CheckedChanged += new System.EventHandler(this.french_RadioButton_CheckedChanged);
            // 
            // english_RadioButton
            // 
            resources.ApplyResources(this.english_RadioButton, "english_RadioButton");
            this.english_RadioButton.Name = "english_RadioButton";
            this.english_RadioButton.TabStop = true;
            this.english_RadioButton.UseVisualStyleBackColor = true;
            this.english_RadioButton.CheckedChanged += new System.EventHandler(this.english_RadioButton_CheckedChanged);
            // 
            // MailOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.language_Groupbox);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.print_Button);
            this.Controls.Add(this.salesBonus_Label);
            this.Controls.Add(this.salesBonus_Textbox);
            this.Controls.Add(this.totalSales_Label);
            this.Controls.Add(this.hoursWorked_Label);
            this.Controls.Add(this.employeeId_Label);
            this.Controls.Add(this.totalSales_Textbox);
            this.Controls.Add(this.hoursWorked_Textbox);
            this.Controls.Add(this.employeeId_Textbox);
            this.Controls.Add(this.employeeName_Textbox);
            this.Controls.Add(this.employeeName_Label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MailOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.language_Groupbox.ResumeLayout(false);
            this.language_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label employeeName_Label;
        private System.Windows.Forms.TextBox employeeName_Textbox;
        private System.Windows.Forms.TextBox employeeId_Textbox;
        private System.Windows.Forms.TextBox hoursWorked_Textbox;
        private System.Windows.Forms.Label employeeId_Label;
        private System.Windows.Forms.Label hoursWorked_Label;
        private System.Windows.Forms.Label totalSales_Label;
        private System.Windows.Forms.TextBox totalSales_Textbox;
        private System.Windows.Forms.TextBox salesBonus_Textbox;
        private System.Windows.Forms.Label salesBonus_Label;
        private System.Windows.Forms.Button print_Button;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.GroupBox language_Groupbox;
        private System.Windows.Forms.RadioButton portuguese_RadioButton;
        private System.Windows.Forms.RadioButton french_RadioButton;
        private System.Windows.Forms.RadioButton english_RadioButton;
    }
}

