using System;
using System.Net;

using SimpleJSON;

namespace IpChecker
{
	public static class Program
	{
		private static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			string ipAddress = string.Empty;
			bool queryAnyKey = false;

			try
			{ 
				// If an IP address is provided as a command line argument
				ipAddress = args[0];
			}
			catch
			{
				queryAnyKey = true;

				Console.Write("\n[?] Enter the ip address\n>>> ");
				ipAddress = Console.ReadLine();
			}

			dynamic ip = ParseLink(@"http://ip-api.com/json/" + ipAddress + "?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,lat,lon,timezone,offset,currency,isp,org,as,asname,reverse,mobile,proxy,hosting,query");

			if (ip["status"] == "fail")
				Console.WriteLine("\n[x] Invalid ip address");

			else if (ip["status"] == "noInternet")
				Console.WriteLine("\n[x] No internet connection");

			else
			{
				Console.WriteLine
				(
					"\nIp: " + ip["query"] +
					"\nContinent: " + ip["continent"] + " " + ip["continentCode"] +
					"\nCountry: " + ip["country"] + " " + ip["countryCode"] +
					"\nCity: " + ip["city"] +
					"\nCurrency: " + ip["currency"] +
					"\nRegion: " + ip["regionName"] +
					"\nTime zone: " + ip["timezone"] +
					"\nOffset: " + ip["offset"] +
					"\nProvider: " + ip["isp"] +
					"\nAs: " + ip["as"] +
					"\nAs name: " + ip["asname"] +
					"\nReverse: " + ip["reverse"] +
					"\nOrganization: " + ip["org"] +
					"\nDistrict: " + ip["district"] +
					"\nZip: " + ip["zip"] +
					"\nLatitude: " + ip["lat"] +
					"\nLongitude: " + ip["lon"] +
					"\nMobile: " + ip["mobile"] +
					"\nProxy: " + ip["proxy"] +
					"\nHosting: " + ip["hosting"] +
					"\nGoogle maps: https://www.google.com/maps/search/?api=1&query=" + ip["lat"] + "," + ip["lon"]
				);
			}

			if (queryAnyKey == true)
			{
				Console.Write("\n[+] Press any key to continue...");
				Console.ReadKey();
				Console.WriteLine("");
			}
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