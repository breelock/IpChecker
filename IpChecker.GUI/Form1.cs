using System;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

using SimpleJSON;

namespace IpChecker
{
	public partial class Form1 : Form
	{
		private Random r = new Random();
		private dynamic ipData = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void EnabledPaint(object sender, PaintEventArgs e)
		{
			Button button = (Button)sender;
			string text = button.Text;

			if (button.Enabled)
				button.ForeColor = AppForeColor;

			else
			{
				button.ForeColor = Color.FromArgb(100, 100, 100);
				TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
				TextRenderer.DrawText(e.Graphics, text, button.Font, e.ClipRectangle, Color.FromArgb(100, 100, 100), flags);
			}
		}

		// Generate random ip address
		private void randomIpButton_Click(object sender, EventArgs e)
		{
			ipTextBox.Text = r.Next(1, 255) + "." + r.Next(0, 255) + "." + r.Next(0, 255) + "." + r.Next(0, 255);
		}

		// Show location in google maps
		private async void googleMapsButton_Click(object sender, EventArgs e)
		{
			if (ipData != null && !string.IsNullOrEmpty(ipData["lat"]) && !string.IsNullOrEmpty(ipData["lon"]))
			{
				string url = "https://www.google.com/maps/search/?api=1&query=" + ipData["lat"] + "," + ipData["lon"];
				await Task.Run(() => Process.Start(url));
			}
		}

		private async void checkIpButton_Click(object sender, EventArgs e)
		{
			string ipAddress = Convert.ToString(ipTextBox.Text).Trim();

			googleMapsButton.Enabled = false;
			checkIpButton.Enabled = false;
			ipTextBox.Enabled = false;
			randomIpButton.Enabled = false;

			await Task.Run(() => 
			{
				ipData = ParseLink(@"http://ip-api.com/json/" + ipAddress + "?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,lat,lon,timezone,offset,currency,isp,org,as,asname,reverse,mobile,proxy,hosting,query");

				if (ipData["status"] == "fail")
					MessageBox.Show("Invalid ip address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				else if (ipData["status"] == "noInternet")
					MessageBox.Show("No internet connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				else
				{
					ipTextBox.Text = ipData["query"];
					continentValue.Text = ipData["continent"] + " (" + ipData["continentCode"] + ")";
					countryValue.Text = ipData["country"] + " (" + ipData["countryCode"] + ")";
					regionValue.Text = ipData["regionName"];
					cityValue.Text = ipData["city"];
					currencyValue.Text = ipData["currency"];
					timeZoneValue.Text = ipData["timezone"];
					providerValue.Text = ipData["isp"];
					mobileValue.Text = ipData["mobile"];
					proxyValue.Text = ipData["proxy"];
					hostingValue.Text = ipData["hosting"];
				}

				checkIpButton.Enabled = true;
				ipTextBox.Enabled = true;
				randomIpButton.Enabled = true;

				if (!(string.IsNullOrEmpty(ipData["lat"]) && string.IsNullOrEmpty(ipData["lon"])))
					googleMapsButton.Enabled = true;
			});
		}

		private static dynamic ParseLink(string link)
		{
			try
			{
				using (WebClient ipClient = new WebClient())
				{
					string response = ipClient.DownloadString(link);
					dynamic result = JSON.Parse(response);

					return result;
				}
			}
			catch
			{
				return JSON.Parse("{\"status\":\"noInternet\"}");
			}
		}
	}
}