namespace Firma
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnClearForm = new System.Windows.Forms.Button();
			this.btnAddEmploy = new System.Windows.Forms.Button();
			this.cbDepartment = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDefaultTable = new System.Windows.Forms.Button();
			this.btnClearRow = new System.Windows.Forms.Button();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblAddEmploy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClearForm
			// 
			this.btnClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.btnClearForm.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnClearForm.Location = new System.Drawing.Point(30, 118);
			this.btnClearForm.Name = "btnClearForm";
			this.btnClearForm.Size = new System.Drawing.Size(206, 42);
			this.btnClearForm.TabIndex = 4;
			this.btnClearForm.Text = "Vymazat formulář";
			this.btnClearForm.UseVisualStyleBackColor = false;
			this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
			// 
			// btnAddEmploy
			// 
			this.btnAddEmploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
			this.btnAddEmploy.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnAddEmploy.Location = new System.Drawing.Point(568, 118);
			this.btnAddEmploy.Name = "btnAddEmploy";
			this.btnAddEmploy.Size = new System.Drawing.Size(206, 42);
			this.btnAddEmploy.TabIndex = 5;
			this.btnAddEmploy.Text = "Přidat zaměstnance";
			this.btnAddEmploy.UseVisualStyleBackColor = false;
			this.btnAddEmploy.Click += new System.EventHandler(this.btnAddEmploy_Click);
			// 
			// cbDepartment
			// 
			this.cbDepartment.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbDepartment.FormattingEnabled = true;
			this.cbDepartment.Items.AddRange(new object[] {
            "Obchodní",
            "Účtárna",
            "Sklad"});
			this.cbDepartment.Location = new System.Drawing.Point(626, 62);
			this.cbDepartment.Name = "cbDepartment";
			this.cbDepartment.Size = new System.Drawing.Size(149, 24);
			this.cbDepartment.TabIndex = 3;
			this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbSelectedIndex_Changed);
			this.cbDepartment.TextChanged += new System.EventHandler(this.cbDepartment_TextChanged);
			this.cbDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDepartment_KeyPress);
			this.cbDepartment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbDepartment_MouseDown);
			// 
			// dtpDate
			// 
			this.dtpDate.CalendarFont = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dtpDate.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(427, 62);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(149, 23);
			this.dtpDate.TabIndex = 2;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			this.dtpDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDate_MouseDown);
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtLastName.Location = new System.Drawing.Point(229, 62);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(149, 23);
			this.txtLastName.TabIndex = 1;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_Changed);
			this.txtLastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLastName_MouseDown);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtFirstName.Location = new System.Drawing.Point(30, 62);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(149, 23);
			this.txtFirstName.TabIndex = 0;
			this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_Changed);
			this.txtFirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_MouseDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(661, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "Oddělení";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(436, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Datum nástupu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(272, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 17);
			this.label3.TabIndex = 16;
			this.label3.Text = "Příjmení";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(79, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Jméno";
			// 
			// btnDefaultTable
			// 
			this.btnDefaultTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.btnDefaultTable.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDefaultTable.Location = new System.Drawing.Point(582, 431);
			this.btnDefaultTable.Name = "btnDefaultTable";
			this.btnDefaultTable.Size = new System.Drawing.Size(206, 47);
			this.btnDefaultTable.TabIndex = 2;
			this.btnDefaultTable.Text = "Resetovat tabulku";
			this.btnDefaultTable.UseVisualStyleBackColor = false;
			this.btnDefaultTable.Click += new System.EventHandler(this.btnDefaultTable_Click);
			// 
			// btnClearRow
			// 
			this.btnClearRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.btnClearRow.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnClearRow.Location = new System.Drawing.Point(44, 431);
			this.btnClearRow.Name = "btnClearRow";
			this.btnClearRow.Size = new System.Drawing.Size(206, 47);
			this.btnClearRow.TabIndex = 1;
			this.btnClearRow.Text = "Vymazat vybraný řádek";
			this.btnClearRow.UseVisualStyleBackColor = false;
			this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.AllowUserToAddRows = false;
			this.dgvEmployees.AllowUserToDeleteRows = false;
			this.dgvEmployees.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
			this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvEmployees.EnableHeadersVisualStyles = false;
			this.dgvEmployees.Location = new System.Drawing.Point(14, 197);
			this.dgvEmployees.Margin = new System.Windows.Forms.Padding(2);
			this.dgvEmployees.MultiSelect = false;
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.RowHeadersVisible = false;
			this.dgvEmployees.RowHeadersWidth = 72;
			this.dgvEmployees.RowTemplate.Height = 28;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(807, 221);
			this.dgvEmployees.TabIndex = 0;
			this.dgvEmployees.Click += new System.EventHandler(this.dgvEmployees_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDepartment);
			this.groupBox1.Controls.Add(this.lblAddEmploy);
			this.groupBox1.Controls.Add(this.btnClearForm);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnAddEmploy);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.cbDepartment);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.dtpDate);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(14, 5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(807, 175);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Přidání nového zaměstnance";
			// 
			// lblDepartment
			// 
			this.lblDepartment.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDepartment.ForeColor = System.Drawing.Color.Red;
			this.lblDepartment.Location = new System.Drawing.Point(263, 142);
			this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(279, 27);
			this.lblDepartment.TabIndex = 26;
			this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblAddEmploy
			// 
			this.lblAddEmploy.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAddEmploy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblAddEmploy.ForeColor = System.Drawing.Color.Red;
			this.lblAddEmploy.Location = new System.Drawing.Point(263, 116);
			this.lblAddEmploy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAddEmploy.Name = "lblAddEmploy";
			this.lblAddEmploy.Size = new System.Drawing.Size(279, 27);
			this.lblAddEmploy.TabIndex = 25;
			this.lblAddEmploy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 493);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.btnDefaultTable);
			this.Controls.Add(this.btnClearRow);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Evidence zaměstnanců";
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClearForm;
		private System.Windows.Forms.Button btnAddEmploy;
		private System.Windows.Forms.ComboBox cbDepartment;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDefaultTable;
		private System.Windows.Forms.Button btnClearRow;
		private System.Windows.Forms.DataGridView dgvEmployees;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblAddEmploy;
	}
}

