using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace IpChecker
{
	partial class Form1
	{
		// Global app fore color
		public Color AppForeColor = Color.Lime;

		/// <summary>
		///  Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.titleLabel = new Label();
			this.ipLabel = new Label();
			this.ipTextBox = new TextBox();
			this.checkIpButton = new Button();
			this.googleMapsButton = new Button();
			this.randomIpButton = new Button();
			this.continentLabel = new Label();
			this.continentValue = new Label();
			this.countryLabel = new Label();
			this.countryValue = new Label();
			this.regionLabel = new Label();
			this.regionValue = new Label();
			this.cityLabel = new Label();
			this.cityValue = new Label();
			this.currencyLabel = new Label();
			this.currencyValue = new Label();
			this.timeZoneLabel = new Label();
			this.timeZoneValue = new Label();
			this.providerLabel = new Label();
			this.providerValue = new Label();
			this.mobileLabel = new Label();
			this.mobileValue = new Label();
			this.proxyLabel = new Label();
			this.proxyValue = new Label();
			this.hostingLabel = new Label();
			this.hostingValue = new Label();
			this.SuspendLayout();
			// 
			// checkIpButton
			// 
			this.checkIpButton.FlatStyle = FlatStyle.Flat;
			this.checkIpButton.BackColor = Color.Black;
			this.checkIpButton.ForeColor = AppForeColor;
			this.checkIpButton.Location = new Point(20, 370);
			this.checkIpButton.Size = new Size(150, 36);
			this.checkIpButton.Text = "Check IP";
			this.checkIpButton.Click += new EventHandler(this.checkIpButton_Click);
			this.checkIpButton.Paint += new PaintEventHandler(this.EnabledPaint);
			// 
			// googleMapsButton
			// 
			this.googleMapsButton.Enabled = false;
			this.googleMapsButton.FlatStyle = FlatStyle.Flat;
			this.googleMapsButton.BackColor = Color.Black;
			this.googleMapsButton.ForeColor = AppForeColor;
			this.googleMapsButton.Location = new Point(190, 370);
			this.googleMapsButton.Size = new Size(150, 36);
			this.googleMapsButton.Text = "Open google maps";
			this.googleMapsButton.Click += new EventHandler(this.googleMapsButton_Click);
			this.googleMapsButton.Paint += new PaintEventHandler(this.EnabledPaint);
			// 
			// continentLabel
			// 
			this.continentLabel.ForeColor = AppForeColor;
			this.continentLabel.AutoSize = true;
			this.continentLabel.Location = new Point(20, 110);
			this.continentLabel.Text = "Continent: ";
			//
			// continentValue
			//
			this.continentValue.ForeColor = AppForeColor;
			this.continentValue.AutoSize = true;
			this.continentValue.Location = new Point(145, 110);
			this.continentValue.Text = "--";
			// 
			// countryLabel
			// 
			this.countryLabel.ForeColor = AppForeColor;
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new Point(20, 135);
			this.countryLabel.Text = "Country: ";
			// 
			// countryValue
			// 
			this.countryValue.ForeColor = AppForeColor;
			this.countryLabel.AutoSize = true;
			this.countryValue.Location = new Point(145, 135);
			this.countryValue.Text = "--";
			// 
			// regionLabel
			// 
			this.regionLabel.ForeColor = AppForeColor;
			this.regionLabel.AutoSize = true;
			this.regionLabel.Location = new Point(20, 160);
			this.regionLabel.Text = "Region: ";
			// 
			// regionValue
			//
			this.regionValue.ForeColor = AppForeColor;
			this.regionValue.AutoSize = true;
			this.regionValue.Location = new Point(145, 160);
			this.regionValue.Text = "--";
			// 
			// cityLabel
			// 
			this.cityLabel.ForeColor = AppForeColor;
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new Point(20, 185);
			this.cityLabel.Text = "City:";
			// 
			// cityValue
			// 
			this.cityValue.ForeColor = AppForeColor;
			this.cityValue.AutoSize = true;
			this.cityValue.Location = new Point(145, 185);
			this.cityValue.Text = "--";
			// 
			// currencyLabel
			// 
			this.currencyLabel.ForeColor = AppForeColor;
			this.currencyLabel.AutoSize = true;
			this.currencyLabel.Location = new Point(20, 210);
			this.currencyLabel.Text = "Currency:";
			// 
			// currencyValue
			// 
			this.currencyValue.ForeColor = AppForeColor;
			this.currencyValue.AutoSize = true;
			this.currencyValue.Location = new Point(145, 210);
			this.currencyValue.Text = "--";
			// 
			// timeZoneLabel
			// 
			this.timeZoneLabel.ForeColor = AppForeColor;
			this.timeZoneLabel.AutoSize = true;
			this.timeZoneLabel.Location = new Point(20, 235);
			this.timeZoneLabel.Text = "Time zone: ";
			// 
			// timeZoneValue
			//
			this.timeZoneValue.ForeColor = AppForeColor;
			this.timeZoneValue.AutoSize = true;
			this.timeZoneValue.Location = new Point(145, 235);
			this.timeZoneValue.Text = "--";
			// 
			// providerLabel
			// 
			this.providerLabel.ForeColor = AppForeColor;
			this.providerLabel.AutoSize = true;
			this.providerLabel.Location = new Point(20, 260);
			this.providerLabel.Text = "Internet Provider: ";
			// 
			// providerValue
			// 
			this.providerValue.ForeColor = AppForeColor;
			this.providerValue.AutoSize = true;
			this.providerValue.Location = new Point(145, 260);
			this.providerValue.Text = "--";
			// 
			// mobileLabel
			// 
			this.mobileLabel.ForeColor = AppForeColor;
			this.mobileLabel.AutoSize = true;
			this.mobileLabel.Location = new Point(20, 285);
			this.mobileLabel.Text = "Mobile: ";
			// 
			// mobileValue
			// 
			this.mobileValue.ForeColor = AppForeColor;
			this.mobileValue.AutoSize = true;
			this.mobileValue.Location = new Point(145, 285);
			this.mobileValue.Text = "--";
			// 
			// proxyLabel
			// 
			this.proxyLabel.ForeColor = AppForeColor;
			this.proxyLabel.AutoSize = true;
			this.proxyLabel.Location = new Point(20, 310);
			this.proxyLabel.Text = "Proxy: ";
			// 
			// proxyValue
			// 
			this.proxyValue.ForeColor = AppForeColor;
			this.proxyValue.AutoSize = true;
			this.proxyValue.Location = new Point(145, 310);
			this.proxyValue.Text = "--";
			// 
			// hostingLabel
			// 
			this.hostingLabel.ForeColor = AppForeColor;
			this.hostingLabel.AutoSize = true;
			this.hostingLabel.Location = new Point(20, 335);
			this.hostingLabel.Text = "Hosting: ";
			// 
			// hostingValue
			// 
			this.hostingValue.ForeColor = AppForeColor;
			this.hostingValue.AutoSize = true;
			this.hostingValue.Location = new Point(145, 335);
			this.hostingValue.Text = "--";
			// 
			// ipLabel
			// 
			this.ipLabel.ForeColor = AppForeColor;
			this.ipLabel.AutoSize = true;
			this.ipLabel.Location = new Point(20, 70);
			this.ipLabel.Text = "IP Adress:";
			// 
			// ipTextBox
			// 
			this.ipTextBox.BorderStyle = BorderStyle.FixedSingle;
			this.ipTextBox.BackColor = Color.Black;
			this.ipTextBox.ForeColor = AppForeColor;
			this.ipTextBox.Location = new Point(148, 67);
			this.ipTextBox.Size = new Size(165, 20);
			this.ipTextBox.TabIndex = 8;
			//
			// randomIpButton
			//
			this.randomIpButton.FlatStyle = FlatStyle.Flat;
			this.randomIpButton.BackColor = Color.Black;
			this.randomIpButton.ForeColor = AppForeColor;
			this.randomIpButton.Location = new Point(313, 67);
			this.randomIpButton.Size = new Size(20, 20);
			this.randomIpButton.Text = "R";
			this.randomIpButton.Click += new EventHandler(this.randomIpButton_Click);
			this.randomIpButton.Paint += new PaintEventHandler(this.EnabledPaint);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = false;
			this.titleLabel.ForeColor = AppForeColor;
			this.titleLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.titleLabel.Font = new Font("Segoe ui", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel.Location = new Point(120, 15);
			this.titleLabel.Size = new Size(125, 26);
			this.titleLabel.TabIndex = 9;
			this.titleLabel.Text = "IP Checker";
			// 
			// Form1
			// 
			this.Text = "IP Checker";
			this.ClientSize = new Size(360, 420);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.BackColor = Color.Black;
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.ipLabel);
			this.Controls.Add(this.ipTextBox);
			this.Controls.Add(this.checkIpButton);
			this.Controls.Add(this.googleMapsButton);
			this.Controls.Add(this.randomIpButton);
			this.Controls.Add(this.continentLabel);
			this.Controls.Add(this.continentValue);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.countryValue);
			this.Controls.Add(this.regionLabel);
			this.Controls.Add(this.regionValue);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.cityValue);
			this.Controls.Add(this.currencyLabel);
			this.Controls.Add(this.currencyValue);
			this.Controls.Add(this.timeZoneLabel);
			this.Controls.Add(this.timeZoneValue);
			this.Controls.Add(this.providerLabel);
			this.Controls.Add(this.providerValue);
			this.Controls.Add(this.mobileLabel);
			this.Controls.Add(this.mobileValue);
			this.Controls.Add(this.proxyLabel);
			this.Controls.Add(this.proxyValue);
			this.Controls.Add(this.hostingLabel);
			this.Controls.Add(this.hostingValue);
			
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
		
		private Label titleLabel;
		private Label ipLabel;
		private TextBox ipTextBox;
		private Button checkIpButton;
		private Button googleMapsButton;
		private Button randomIpButton;
		private Label continentLabel;
		private Label continentValue;
		private Label countryLabel;
		private Label countryValue;
		private Label regionLabel;
		private Label regionValue;
		private Label cityLabel;
		private Label cityValue;
		private Label currencyLabel;
		private Label currencyValue;
		private Label timeZoneLabel;
		private Label timeZoneValue;
		private Label providerLabel;
		private Label providerValue;
		private Label mobileLabel;
		private Label mobileValue;
		private Label proxyLabel;
		private Label proxyValue;
		private Label hostingLabel;
		private Label hostingValue;
	}
}