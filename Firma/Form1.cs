using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma
{
	public partial class Form1 : Form
	{
		private int i, selected;
		private string addEmploy = "";
		private string selectDepartment = "";
		private string firstName, lastName;
		private bool validEmploy = true;
		private bool showRedText = false;

		/*
		
		použito 4x ve Form1.cs pro připojení k DB, určeno pouze pro DEBUG,
		pro spuštění RELEASE nutno nahradit číslo 10 číslem 12

		"Data Source=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=\" + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + \"Firma.mdf;Integrated Security=True"
		
		 */

		public Form1()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedDialog;
			ZobrazTabulku();
			lblAddEmploy.Text = addEmploy;
			lblDepartment.Text = selectDepartment;
		}

		private void btnAddEmploy_Click(object sender, EventArgs e)
		{
			showRedText = true;
			if (IsEmployValid())
			{
				using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Firma.mdf;Integrated Security=True"))
				{
					using (SqlCommand sqlCommand = new SqlCommand("uspNewEmploy", connection))
					{
						sqlCommand.CommandType = CommandType.StoredProcedure;

						sqlCommand.Parameters.Add(new SqlParameter("@KrestniJmeno", SqlDbType.NVarChar, 50));
						sqlCommand.Parameters["@KrestniJmeno"].Value = firstName;
						sqlCommand.Parameters.Add(new SqlParameter("@Prijmeni", SqlDbType.NVarChar, 50));
						sqlCommand.Parameters["@Prijmeni"].Value = lastName;
						sqlCommand.Parameters.Add(new SqlParameter("@DatumNastupu", SqlDbType.Date));
						sqlCommand.Parameters["@DatumNastupu"].Value = dtpDate.Value;
						sqlCommand.Parameters.Add(new SqlParameter("@OddeleniID", SqlDbType.Int));
						sqlCommand.Parameters["@OddeleniID"].Value = cbDepartment.SelectedIndex + 1;

						try
						{
							connection.Open();
							sqlCommand.ExecuteNonQuery();
							ClearForm();
							lblAddEmploy.ForeColor = System.Drawing.Color.Green;
							lblAddEmploy.Padding = new Padding(0, 5, 0, 0);
							lblAddEmploy.Text = "Zaměstnanec přidán";
							ZobrazTabulku();
							showRedText = false;
							selected = dgvEmployees.RowCount - 1;
							dgvEmployees.Rows[selected].Selected = true;
							dgvEmployees.CurrentCell = dgvEmployees.Rows[selected].Cells[0];
						}
						catch (Exception)
						{
							MessageBox.Show("Chyba při přidávání zaměstnance.");
						}
						finally { connection.Close(); }
					}
				}
			}
		}

		private bool IsEmployValid()
		{
			addEmploy = "";
			selectDepartment = "";
			validEmploy = true;

			firstName = txtFirstName.Text.Trim();
			lastName = txtLastName.Text.Trim();

			if (firstName == "")
			{
				addEmploy = "Zadejte jméno";
				validEmploy = false;
			}
			if (lastName == "")
			{
				addEmploy = (firstName == "") ? "Zadejte jméno a příjmení" : "Zadejte příjmení";
				validEmploy = false;
			}
			if (cbDepartment.SelectedIndex == -1)
			{
				selectDepartment = "Vyberte oddělení";
				validEmploy = false;
			}
			if (!cbDepartment.Items.Contains(cbDepartment.Text))
			{
				selectDepartment = "Vyberte oddělení";
				validEmploy = false;
			}

			lblAddEmploy.Padding = new Padding(0);
			lblAddEmploy.ForeColor = System.Drawing.Color.Red;
			lblAddEmploy.Text = addEmploy;
			lblDepartment.Text = selectDepartment;

			return validEmploy;
		}

		private void btnClearForm_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void ClearForm()
		{
			showRedText = false;
			txtFirstName.Clear();
			txtLastName.Clear();
			dtpDate.Value = DateTime.Today;
			cbDepartment.Text = "";
			cbDepartment.SelectedIndex = -1;
			selectDepartment = "";
			addEmploy = "";
			lblAddEmploy.Text = "";
			lblDepartment.Text = "";
		}

		private void ZobrazTabulku()
		{
			using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Firma.mdf;Integrated Security=True"))
			{
				const string sql = "SELECT Zamestnanci.Id, KrestniJmeno AS Jméno, Prijmeni AS Příjmení, DatumNastupu AS Nástup, Nazev AS [Oddělení]" +
					"FROM Zamestnanci, Oddeleni WHERE Zamestnanci.OddeleniID=Oddeleni.Id";
				using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
				{
					try
					{
						connection.Open();
						using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
						{
							DataTable dataTable = new DataTable();
							dataTable.Load(dataReader);
							this.dgvEmployees.DataSource = dataTable;
							DataGridViewColumn column = dgvEmployees.Columns[0];
							column.Width = 60;
							this.dgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							this.dgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							this.dgvEmployees.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							this.dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							dataReader.Close();
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Chyba, tabulku nelze zobrazit.");
					}
					finally { connection.Close(); }
				}
			}
		}

		private void btnClearRow_Click(object sender, EventArgs e)
		{
			DelAddOK();
			if (dgvEmployees.RowCount > 0 && dgvEmployees.SelectedCells[0].Value != null)
			{
				i = (int)dgvEmployees.SelectedCells[0].Value;

				using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Firma.mdf;Integrated Security=True"))
				{
					string sql = "DELETE FROM Zamestnanci WHERE Id=@id";
					using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
					{
						try
						{
							connection.Open();
							sqlCommand.Parameters.AddWithValue("@id", i);
							sqlCommand.ExecuteNonQuery();
							ZobrazTabulku();
						}
						catch (Exception)
						{
							MessageBox.Show("Chyba při mazání řádku.");
						}
						finally { connection.Close(); }
					}
				}
			}
		}

		private void txtFirstName_Changed(object sender, EventArgs e)
		{
			DelAddOK();
			if (showRedText)
			{
				IsEmployValid();
			}
		}

		private void txtLastName_Changed(object sender, EventArgs e)
		{
			DelAddOK();
			if (showRedText)
			{
				IsEmployValid();
			}
		}

		private void cbSelectedIndex_Changed(object sender, EventArgs e)
		{
			DelAddOK();
			if (showRedText)
			{
				IsEmployValid();
			}
		}

		private void cbDepartment_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void form_Click(object sender, MouseEventArgs e)
		{
			DelAddOK();
		}

		private void DelAddOK()
		{
			if (lblAddEmploy.Text == "Zaměstnanec přidán")
			{
				lblAddEmploy.Text = "";
			}
		}

		private void cbDepartment_TextChanged(object sender, EventArgs e)
		{
			DelAddOK();
			if (showRedText)
			{
				IsEmployValid();
			}
		}

		private void dgvEmployees_Click(object sender, EventArgs e)
		{
			DelAddOK();
		}

		private void dtpDate_MouseDown(object sender, MouseEventArgs e)
		{
			DelAddOK();
		}

		private void txtFirstName_MouseDown(object sender, MouseEventArgs e)
		{
			DelAddOK();
		}

		private void txtLastName_MouseDown(object sender, MouseEventArgs e)
		{
			DelAddOK();
		}

		private void cbDepartment_MouseDown(object sender, MouseEventArgs e)
		{
			DelAddOK();
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			DelAddOK();
		}

		private void btnDefaultTable_Click(object sender, EventArgs e)
		{
			DelAddOK();
			using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Firma.mdf;Integrated Security=True"))
			{
				using (SqlCommand sqlCommand = new SqlCommand("uspResetTable", connection))
				{
					try
					{
						connection.Open();
						sqlCommand.ExecuteNonQuery();
						ZobrazTabulku();
					}
					catch (Exception)
					{
						MessageBox.Show("Chyba při resetu tabulky.");
					}
					finally { connection.Close(); }
				}
			}
		}
	}
}
