namespace Rental_Car
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tab_Login = new TabPage();
            btn_GoRegister = new Button();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabRegister = new TabPage();
            btn_BackToLogin = new Button();
            btn_Register = new Button();
            txt_ConfirmPassword = new TextBox();
            txt_RegisterPassword = new TextBox();
            txt_RegisterUsername = new TextBox();
            txt_FullName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabpageCar = new TabPage();
            txtPrice = new TextBox();
            txtModel = new TextBox();
            txtColor = new TextBox();
            txtBrand = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btn_deletecar = new Button();
            btn_updatecar = new Button();
            btn_addcar = new Button();
            dataGridViewCars = new DataGridView();
            btn_Search = new Button();
            txt_Search = new TextBox();
            tabPage3 = new TabPage();
            btn_Cancel = new Button();
            btn_Book = new Button();
            label10 = new Label();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            label9 = new Label();
            cmbCars = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tab_Login.SuspendLayout();
            tabRegister.SuspendLayout();
            tabpageCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_Login);
            tabControl1.Controls.Add(tabRegister);
            tabControl1.Controls.Add(tabpageCar);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(50, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 279);
            tabControl1.TabIndex = 0;
            // 
            // tab_Login
            // 
            tab_Login.Controls.Add(btn_GoRegister);
            tab_Login.Controls.Add(btnLogin);
            tab_Login.Controls.Add(txtLoginPassword);
            tab_Login.Controls.Add(txtLoginUsername);
            tab_Login.Controls.Add(label2);
            tab_Login.Controls.Add(label1);
            tab_Login.Location = new Point(4, 24);
            tab_Login.Name = "tab_Login";
            tab_Login.Padding = new Padding(3);
            tab_Login.Size = new Size(721, 251);
            tab_Login.TabIndex = 0;
            tab_Login.Text = "Login";
            tab_Login.UseVisualStyleBackColor = true;
            // 
            // btn_GoRegister
            // 
            btn_GoRegister.Location = new Point(274, 181);
            btn_GoRegister.Name = "btn_GoRegister";
            btn_GoRegister.Size = new Size(98, 23);
            btn_GoRegister.TabIndex = 5;
            btn_GoRegister.Text = "Go to Register";
            btn_GoRegister.UseVisualStyleBackColor = true;
            btn_GoRegister.Click += btnGoRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(128, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(233, 114);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(100, 23);
            txtLoginPassword.TabIndex = 3;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(233, 50);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(100, 23);
            txtLoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 114);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 50);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tabRegister
            // 
            tabRegister.Controls.Add(btn_BackToLogin);
            tabRegister.Controls.Add(btn_Register);
            tabRegister.Controls.Add(txt_ConfirmPassword);
            tabRegister.Controls.Add(txt_RegisterPassword);
            tabRegister.Controls.Add(txt_RegisterUsername);
            tabRegister.Controls.Add(txt_FullName);
            tabRegister.Controls.Add(label6);
            tabRegister.Controls.Add(label5);
            tabRegister.Controls.Add(label4);
            tabRegister.Controls.Add(label3);
            tabRegister.Location = new Point(4, 24);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(721, 251);
            tabRegister.TabIndex = 1;
            tabRegister.Text = "Register";
            tabRegister.UseVisualStyleBackColor = true;
            tabRegister.Click += tabPage2_Click;
            // 
            // btn_BackToLogin
            // 
            btn_BackToLogin.Location = new Point(197, 193);
            btn_BackToLogin.Name = "btn_BackToLogin";
            btn_BackToLogin.Size = new Size(99, 23);
            btn_BackToLogin.TabIndex = 9;
            btn_BackToLogin.Text = "Back to login";
            btn_BackToLogin.UseVisualStyleBackColor = true;
            btn_BackToLogin.Click += btn_BackToLogin_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(76, 193);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(75, 23);
            btn_Register.TabIndex = 8;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Location = new Point(137, 120);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new Size(100, 23);
            txt_ConfirmPassword.TabIndex = 7;
            // 
            // txt_RegisterPassword
            // 
            txt_RegisterPassword.Location = new Point(137, 83);
            txt_RegisterPassword.Name = "txt_RegisterPassword";
            txt_RegisterPassword.Size = new Size(100, 23);
            txt_RegisterPassword.TabIndex = 6;
            // 
            // txt_RegisterUsername
            // 
            txt_RegisterUsername.Location = new Point(137, 48);
            txt_RegisterUsername.Name = "txt_RegisterUsername";
            txt_RegisterUsername.Size = new Size(100, 23);
            txt_RegisterUsername.TabIndex = 5;
            // 
            // txt_FullName
            // 
            txt_FullName.Location = new Point(137, 15);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(100, 23);
            txt_FullName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 123);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 3;
            label6.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 86);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 48);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 18);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // tabpageCar
            // 
            tabpageCar.Controls.Add(txtPrice);
            tabpageCar.Controls.Add(txtModel);
            tabpageCar.Controls.Add(txtColor);
            tabpageCar.Controls.Add(txtBrand);
            tabpageCar.Controls.Add(label14);
            tabpageCar.Controls.Add(label13);
            tabpageCar.Controls.Add(label12);
            tabpageCar.Controls.Add(label11);
            tabpageCar.Controls.Add(btn_deletecar);
            tabpageCar.Controls.Add(btn_updatecar);
            tabpageCar.Controls.Add(btn_addcar);
            tabpageCar.Controls.Add(dataGridViewCars);
            tabpageCar.Controls.Add(btn_Search);
            tabpageCar.Controls.Add(txt_Search);
            tabpageCar.Location = new Point(4, 24);
            tabpageCar.Name = "tabpageCar";
            tabpageCar.Padding = new Padding(3);
            tabpageCar.Size = new Size(721, 251);
            tabpageCar.TabIndex = 2;
            tabpageCar.Text = "Cars";
            tabpageCar.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(496, 168);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(496, 119);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(364, 168);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 11;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(364, 119);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(496, 149);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 9;
            label14.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(496, 101);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 8;
            label13.Text = "Model";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(364, 149);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 7;
            label12.Text = "Color";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 101);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 6;
            label11.Text = "Brand";
            // 
            // btn_deletecar
            // 
            btn_deletecar.Location = new Point(619, 186);
            btn_deletecar.Name = "btn_deletecar";
            btn_deletecar.Size = new Size(75, 23);
            btn_deletecar.TabIndex = 5;
            btn_deletecar.Text = "Delete Car";
            btn_deletecar.UseVisualStyleBackColor = true;
            btn_deletecar.Click += btn_deletecar_Click;
            // 
            // btn_updatecar
            // 
            btn_updatecar.Location = new Point(619, 141);
            btn_updatecar.Name = "btn_updatecar";
            btn_updatecar.Size = new Size(75, 23);
            btn_updatecar.TabIndex = 4;
            btn_updatecar.Text = "Update Car";
            btn_updatecar.UseVisualStyleBackColor = true;
            btn_updatecar.Click += btn_updatecar_Click;
            // 
            // btn_addcar
            // 
            btn_addcar.Location = new Point(619, 101);
            btn_addcar.Name = "btn_addcar";
            btn_addcar.Size = new Size(75, 23);
            btn_addcar.TabIndex = 3;
            btn_addcar.Text = "Add Car";
            btn_addcar.UseVisualStyleBackColor = true;
            btn_addcar.Click += btn_addcar_Click;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AllowUserToAddRows = false;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(20, 56);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCars.Size = new Size(283, 167);
            dataGridViewCars.TabIndex = 2;
            dataGridViewCars.CellContentClick += dataGridViewCars_CellContentClick;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(228, 27);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 1;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(20, 27);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(202, 23);
            txt_Search.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_Cancel);
            tabPage3.Controls.Add(btn_Book);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(dtEnd);
            tabPage3.Controls.Add(dtStart);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(cmbCars);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(721, 251);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Booking";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(188, 158);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(116, 23);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Cancel Booking";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Book
            // 
            btn_Book.Location = new Point(79, 158);
            btn_Book.Name = "btn_Book";
            btn_Book.Size = new Size(75, 23);
            btn_Book.TabIndex = 7;
            btn_Book.Text = "Book";
            btn_Book.UseVisualStyleBackColor = true;
            btn_Book.Click += btn_Book_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 131);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 6;
            label10.Text = "End Date";
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(104, 123);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(200, 23);
            dtEnd.TabIndex = 5;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(104, 81);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(200, 23);
            dtStart.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 87);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 3;
            label9.Text = "Start Date";
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(104, 39);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(121, 23);
            cmbCars.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 42);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 1;
            label8.Text = "Select Car";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(139, 12);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 0;
            label7.Text = "Book a Car";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tab_Login.ResumeLayout(false);
            tab_Login.PerformLayout();
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            tabpageCar.ResumeLayout(false);
            tabpageCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_Login;
        private Button btn_GoRegister;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private Label label2;
        private Label label1;
        private TabPage tabRegister;
        private Button btn_BackToLogin;
        private Button btn_Register;
        private TextBox txt_ConfirmPassword;
        private TextBox txt_RegisterPassword;
        private TextBox txt_RegisterUsername;
        private TextBox txt_FullName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabpageCar;
        private DataGridView dataGridViewCars;
        private Button btn_Search;
        private TextBox txt_Search;
        private TabPage tabPage3;
        private Button btn_deletecar;
        private Button btn_updatecar;
        private Button btn_addcar;
        private Label label10;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private Label label9;
        private ComboBox cmbCars;
        private Label label8;
        private Label label7;
        private Button btn_Cancel;
        private Button btn_Book;
        private TextBox txtPrice;
        private TextBox txtModel;
        private TextBox txtColor;
        private TextBox txtBrand;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}
