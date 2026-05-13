using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rental_Car
{
    public partial class Form1 : Form

    {
        string userType = "";
        string savedUsername = "";
        string savedPassword = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRegister;
        }

        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tab_Login;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            if (username == "admin" && password == "123")
            {
                userType = "Admin";
                MessageBox.Show("Welcome Admin");
                tabControl1.SelectedTab = tabpageCar;

                btn_addcar.Visible = true;
                btn_updatecar.Visible = true;
                btn_deletecar.Visible = true;

                dataGridViewCars.Rows.Clear();

            }
            else if (username == savedUsername && password == savedPassword)
            {
                userType = "Customer";
                MessageBox.Show("Welcome Customer" + username);
                tabControl1.SelectedTab = tabpageCar;

                btn_addcar.Visible = false;
                btn_updatecar.Visible = false;
                btn_deletecar.Visible = false;
               

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewCars.ColumnCount = 5;
            dataGridViewCars.Columns[0].Name = "Brand";
            dataGridViewCars.Columns[1].Name = "Model";
            dataGridViewCars.Columns[2].Name = "Color";
            dataGridViewCars.Columns[3].Name = "Price";
            dataGridViewCars.Columns[4].Name = "Status";

            dataGridViewCars.Rows.Add("Toyota", "Corolla", "White", "50$", "Available");
            dataGridViewCars.Rows.Add("Honda", "Civic", "Black", "60$", "Available");
            dataGridViewCars.Rows.Add("BMW", "X5", "Gray", "120$", "Booked");

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string brand = row.Cells[0].Value.ToString().ToLower();

                    if (brand.Contains(search))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string color = txtColor.Text;
            string price = txtPrice.Text;


            if (brand == "" || model == "" || color == "" || price == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                dataGridViewCars.Rows.Add(brand, model, color, price + "$", "Available");

                MessageBox.Show("Car added successfully");


                txtBrand.Clear();
                txtModel.Clear();
                txtColor.Clear();
                txtPrice.Clear();
            }
            LoadCarsToCombo();
        }

        private void btn_deletecar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow != null && !dataGridViewCars.CurrentRow.IsNewRow)
            {
                dataGridViewCars.Rows.RemoveAt(dataGridViewCars.CurrentRow.Index);
                MessageBox.Show("Car deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select a car to delete");
            }
            LoadCarsToCombo();
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCars.Rows[e.RowIndex];

                txtBrand.Text = row.Cells[0].Value.ToString();
                txtModel.Text = row.Cells[1].Value.ToString();
                txtColor.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString().Replace("$", "");
            }


        }

        private void btn_updatecar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count != null && !dataGridViewCars.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridViewCars.CurrentRow;

                row.Cells[0].Value = txtBrand.Text;
                row.Cells[1].Value = txtModel.Text;
                row.Cells[2].Value = txtColor.Text;
                row.Cells[3].Value = txtPrice.Text + "$";

                MessageBox.Show("Car updated successfully");
            }
            else
            {
                MessageBox.Show("Please select a car");
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null)
            {
                MessageBox.Show("Please select a car");
            }
            else
            {
                string selectedCar = cmbCars.SelectedItem.ToString();

                foreach (DataGridViewRow row in dataGridViewCars.Rows)
                {
                    string brand = row.Cells[0].Value?.ToString();
                    string model = row.Cells[1].Value?.ToString();

                    if (brand != null && model != null)
                    {
                        string carName = brand + " " + model;

                        if (carName == selectedCar)
                        {
                            string status = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString();

                            if (status == "Booked")
                            {
                                MessageBox.Show("This car is already booked");
                                return;
                            }

                            row.Cells[4].Value = "Booked";

                            MessageBox.Show("Car booked successfully");

                            LoadCarsToCombo();

                            return;
                        }
                    }
                }
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            cmbCars.SelectedIndex = -1;
            MessageBox.Show("Booking cancelled");
        }


        void LoadCarsToCombo()
        {
            cmbCars.Items.Clear();

            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                if (row.IsNewRow) continue;

                string brand = row.Cells[0].Value?.ToString();
                string model = row.Cells[1].Value?.ToString();
                string status = row.Cells[4].Value?.ToString();

                if (brand != null && model != null && status == "Available")
                {
                    cmbCars.Items.Add(brand + " " + model);
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadCarsToCombo();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            LoadCarsToCombo();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
       
            string fullname = txt_FullName.Text;
            string username =txt_RegisterUsername.Text;
            string password = txt_RegisterPassword.Text;
            string confirm = txt_ConfirmPassword.Text;

            
            if (fullname == "" || username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            
            savedUsername = username;
            savedPassword = password;

            MessageBox.Show("Registered successfully");

           
            txt_FullName.Clear();
            txt_RegisterUsername.Clear();
            txt_RegisterPassword.Clear();
            txt_ConfirmPassword.Clear();

         
            tabControl1.SelectedTab = tab_Login;
        }

    }
    }


