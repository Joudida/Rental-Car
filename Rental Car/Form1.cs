using System.Net.Http;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace Rental_Car
{
    public partial class Form1 : Form

    {

        string userType = "";
        string savedUsername = "";
        string savedPassword = "";
        private readonly HttpClient client = new HttpClient();
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            if (username == "admin" && password == "123")
            {
                userType = "Admin";
                MessageBox.Show("Welcome Admin");
                txtLoginUsername.Clear();
                txtLoginPassword.Clear();

                tabControl1.SelectedTab = tabpageCar;
                await LoadCarsFromApi();

                btn_addcar.Visible = true;
                btn_updatecar.Visible = true;
                btn_deletecar.Visible = true;

                await LoadCarsFromApi();
                return;
            }

            var loginData = new
            {
                id = 0,
                fullName = "",
                username = username,
                password = password,
                role = ""
            };

            string json = JsonSerializer.Serialize(loginData);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync(
                "http://localhost:5051/api/Users/login",
                content
            );

            if (response.IsSuccessStatusCode)
            {
                userType = "Customer";
                MessageBox.Show("Welcome Customer " + username);
                txtLoginUsername.Clear();
                txtLoginPassword.Clear();
                tabControl1.SelectedTab = tabpageCar;
                await LoadCarsFromApi();
                btn_addcar.Visible = false;
                btn_updatecar.Visible = false;
                btn_deletecar.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private async Task LoadCarsFromApi()
        {
            try
            {
                HttpResponseMessage response =
                    await client.GetAsync("http://localhost:5051/api/Cars");

                string json = await response.Content.ReadAsStringAsync();

               

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Failed to load cars");
                    return;
                }

                List<CarDto> cars =
                    JsonSerializer.Deserialize<List<CarDto>>(
                        json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

               

                dataGridViewCars.Rows.Clear();
                txt_Search.Clear();

                foreach (var car in cars)
                {
                    int rowIndex = dataGridViewCars.Rows.Add(
                        car.Id,
                        car.Brand,
                        car.Model,
                        car.Color,
                        car.Price,
                        car.Status
                    );

                    dataGridViewCars.Rows[rowIndex].Visible = true;
                }

                LoadCarsToCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public class CarDto
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public decimal Price { get; set; }
            public string Status { get; set; }
        }


        private async void Form1_Load(object sender, EventArgs e)

        {
            dataGridViewCars.Columns.Clear();
            dataGridViewCars.ColumnCount = 6;

            dataGridViewCars.Columns[0].Name = "Id";
            dataGridViewCars.Columns[1].Name = "Brand";
            dataGridViewCars.Columns[2].Name = "Model";
            dataGridViewCars.Columns[3].Name = "Color";
            dataGridViewCars.Columns[4].Name = "Price";
            dataGridViewCars.Columns[5].Name = "Status";

            dataGridViewCars.Columns[0].Visible = false;

            await LoadCarsFromApi();
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                if (row.IsNewRow) continue;

                string brand = row.Cells[1].Value?.ToString().ToLower();

                if (string.IsNullOrWhiteSpace(search))
                {
                    row.Visible = true;
                }
                else if (brand != null && brand.Contains(search))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private async void btn_addcar_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string color = txtColor.Text;
            string priceText = txtPrice.Text;

            if (brand == "" || model == "" || color == "" || priceText == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            decimal price = decimal.Parse(priceText);

            var carData = new
            {
                id = 0,
                brand = brand,
                model = model,
                color = color,
                price = price,
                status = "Available"
            };

            string json = JsonSerializer.Serialize(carData);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync(
                "http://localhost:5051/api/Cars",
                content
            );

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Car added successfully");

                txtBrand.Clear();
                txtModel.Clear();
                txtColor.Clear();
                txtPrice.Clear();

                await LoadCarsFromApi();
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Add car failed: " + error);
            }
        }

        private async void btn_deletecar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null ||
                dataGridViewCars.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a car");
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewCars.CurrentRow.Cells[0].Value
            );

            HttpResponseMessage response =
                await client.DeleteAsync(
                    "http://localhost:5051/api/Cars/" + id
                );

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Car deleted successfully");

                await LoadCarsFromApi();
                txtBrand.Clear();
                txtModel.Clear();
                txtColor.Clear();
                txtPrice.Clear();
            }
            else
            {
                string error =
                    await response.Content.ReadAsStringAsync();

                MessageBox.Show("Delete failed: " + error);
            }
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCars.Rows[e.RowIndex];

                txtBrand.Text = row.Cells[1].Value.ToString();
                txtModel.Text = row.Cells[2].Value.ToString();
                txtColor.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
            }


        }

        private async void btn_updatecar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null || dataGridViewCars.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a car");
                return;
            }

            int id = Convert.ToInt32(dataGridViewCars.CurrentRow.Cells[0].Value);

            var carData = new
            {
                id = id,
                brand = txtBrand.Text,
                model = txtModel.Text,
                color = txtColor.Text,
                price = decimal.Parse(txtPrice.Text),
                status = dataGridViewCars.CurrentRow.Cells[5].Value.ToString()
            };

            string json = JsonSerializer.Serialize(carData);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PutAsync(
                "http://localhost:5051/api/Cars/" + id,
                content
            );

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Car updated successfully");

                await LoadCarsFromApi();
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Update failed: " + error);
            }
        }

        private async void btn_Book_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null)
            {
                MessageBox.Show("Please select a car");
                return;
            }

            string selectedCar = cmbCars.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                if (row.IsNewRow) continue;

                int carId = Convert.ToInt32(row.Cells[0].Value);
                string brand = row.Cells[1].Value?.ToString();
                string model = row.Cells[2].Value?.ToString();
                string status = row.Cells[5].Value?.ToString();

                string carName = brand + " " + model;

                if (carName == selectedCar)
                {
                    if (status == "Booked")
                    {
                        MessageBox.Show("This car is already booked");
                        return;
                    }

                    if (dtEnd.Value <= dtStart.Value)
                    {
                        MessageBox.Show("End date must be after start date");
                        return;
                    }

                    var bookingData = new
                    {
                        id = 0,
                        userId = 1,
                        carId = carId,
                        startDate = dtStart.Value,
                        endDate = dtEnd.Value,
                    };

                    string json = JsonSerializer.Serialize(bookingData);

                    var content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json"
                    );

                    HttpResponseMessage response = await client.PostAsync(
                        "http://localhost:5051/api/Bookings",
                        content
                    );

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Car booked successfully");

                        await LoadCarsFromApi();
                        LoadCarsToCombo();
                        cmbCars.SelectedIndex = -1;

                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Booking failed: " + error);
                    }

                    return;
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

                string brand = row.Cells[1].Value?.ToString();
                string model = row.Cells[2].Value?.ToString();
                string status = row.Cells[5].Value?.ToString();

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

        private async void btn_Register_Click(object sender, EventArgs e)
        {
            string fullname = txt_FullName.Text;
            string username = txt_RegisterUsername.Text;
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

            var userData = new
            {
                id = 0,
                fullName = fullname,
                username = username,
                password = password,
                role = "Customer"
            };

            string json = JsonSerializer.Serialize(userData);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync(
                "http://localhost:5051/api/Users/register",
                content
            );

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registered successfully");

                txt_FullName.Clear();
                txt_RegisterUsername.Clear();
                txt_RegisterPassword.Clear();
                txt_ConfirmPassword.Clear();

                tabControl1.SelectedTab = tab_Login;
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Register failed: " + error);
            }
        }
    }
}


