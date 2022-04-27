/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 27.04.2022
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Zeugnis_G3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Zeugnismanagement-Programm 'RaaPrint'");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine();
			Console.WriteLine("+ Prozessschritt: Relevante Daten einlesen +");
			Console.WriteLine();
			
			string[] faecher = {"Mathe", "Deutsch", "Englisch", "Biologie", "Sport", "Kunst", "Geschichte", "Informatik"};
			int[] noten = new int[faecher.Length];
			
			//Möglichkeit (Regex) um ungültige Benutzereingaben abzufangen. (Mächtige Methode, aber komplex & schwer verständlich)
			Regex rgxName = new Regex("^[A-Z a-z]+$");
			String name;
			bool validName = true;
			do
			{
				Console.WriteLine("Geben Sie den Namen des Schülers an: ");
				name = Console.ReadLine();
				validName = rgxName.IsMatch(name);
				if (!validName)
				{
					Console.WriteLine();
					Console.WriteLine("Hinweis: Das Namensfeld darf nur Buchstaben der Form [a-z] u. [A-Z] enthalten,");
					Console.WriteLine("Sonderzeichen und Kommas sind nicht zulässig!");
					Console.WriteLine();
				}
			} while (!validName);
			Console.WriteLine();

			//Möglichkeit (Regex) um ungültige Benutzereingaben abzufangen. (Mächtige Methode, aber komplex & schwer verständlich)
			Regex regexDatum = new Regex(@"^(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})$");
			String datum = "";
			bool validDatum = true;
			do
			{
				Console.WriteLine("Geben Sie das Ausstellungsdatum ein (Leer lassen, für heutiges Datum): ");
				datum = Console.ReadLine();
				if (datum.Length == 0)
				{
					datum = DateTime.Now.Date.ToString("dd.MM.yyyy");
				}

				validDatum = regexDatum.IsMatch(datum);
				if (!validDatum)
				{
					Console.WriteLine("Sie müssen ein korrektes Datumsformat tt.mm.jjjj angeben!");
					Console.WriteLine();
				}
			} while (!validDatum);
			Console.WriteLine();

			bool validLeistungskurse = false;
			int leistungskursIndex1 = 0;
			int leistungskursIndex2 = 0;
			do
			{	
				Console.WriteLine("Angebotene Schulfächer:");
				Console.WriteLine("-----------------------");
				
				for (int i = 0; i < faecher.Length; i++)
				{
					Console.WriteLine("{0} - {1}", i + 1, faecher[i]);
				}
				Console.WriteLine();

				// 2. Möglichkeit (try - catch) um ungültige Benutzereingaben abzufangen. (Einfachere Methode, die leichter verständlich ist)
				try
				{
					Console.Write("Geben Sie Ihren 1. belegten Leistungskurs an: ");
					leistungskursIndex1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Geben Sie Ihren 2. belegten Leistungskurs an: ");
					leistungskursIndex2 = Convert.ToInt32(Console.ReadLine());
					if (leistungskursIndex1 >= 9 || leistungskursIndex1 <= 0 || leistungskursIndex2 >= 9 ||
					    leistungskursIndex2 <= 0)
					{
						validLeistungskurse = false;
					}
					else
					{
						validLeistungskurse = true;
					}

					if (leistungskursIndex1 == leistungskursIndex2)
					{
						Console.WriteLine("Sie müssen zwei unterschiedliche Leistungskurse wählen!");
						validLeistungskurse = false;
					}
				}
				catch (FormatException ex)
				{
					Console.WriteLine("{0} Sie müssen eine Zahl von 1-8 eingeben!", ex.Message);
				}
			} while (!validLeistungskurse);
			Console.WriteLine();

			faecher[leistungskursIndex1 - 1] += "(LK)";
			faecher[leistungskursIndex2 - 1] += "(LK)";

			bool validNotepunkte;
			int notenpunkte;
			for (int i = 0; i < faecher.Length; i++)
			{
				do
				{
					validNotepunkte = false;
					notenpunkte = 0;
					try
					{
						Console.Write("Geben Sie Ihre Notenpunkte für das Fach {0} an: ", faecher[i]);
						notenpunkte = Convert.ToInt32(Console.ReadLine());
						if (notenpunkte <= 15 && notenpunkte >= 0)
						{
							validNotepunkte = true;
						}
						else
						{
							Console.WriteLine("Sie müssen eine Zahl von 0-15 eingeben!");
						}
					}
					catch (FormatException ex)
					{
						Console.WriteLine("{0} Sie müssen eine Zahl von 0-15 eingeben!", ex.Message);
					}
				} while (!validNotepunkte);

				noten[i] = notenpunkte;
			}
		
			Console.WriteLine();
			
			
			int fehltage;
			Console.Write("Fehltage angeben:");
			fehltage = Convert.ToInt32(Console.ReadLine());
			int unentschuldigteFehltage;
			Console.Write("Davon unentschuldigt:");
			unentschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			
			
			printZeugnis(name, datum, faecher, noten, fehltage, unentschuldigteFehltage, durchschnittBerechnen(noten, leistungskursIndex1, leistungskursIndex2));
			
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey(true);
		
		}
		

		public static void printZeugnis(String name, String datum, string[] faecher, int[] noten, int fehltage, int unentschuldigteFehltage, double durchschnitt)
		{
			Console.WriteLine("Prozessschritt: Zeugnis in Konsole ausgeben:");
			Console.WriteLine();
			Console.WriteLine("===============Zeugnis===============");
			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Datum: {0}", datum);
			Console.WriteLine("=====================================");
			Console.WriteLine();
			for (int i = 0; i < 8; i++)
			{
				Console.WriteLine("{0, -15}: {1,4}", faecher[i], noten[i]);
				
				
				
				
				
			}
			Console.WriteLine();
			Console.WriteLine("Durchschnittsnote: {0:f1}", durchschnitt);
			Console.WriteLine();
			Console.WriteLine("=====================================");
			Console.WriteLine("Fehltage: {0}", fehltage);
			Console.WriteLine("Davon unentschuldigt: {0}", unentschuldigteFehltage);
			Console.WriteLine();
			
			
			if (fehltage <30)
				Console.WriteLine("Der Schüler wird versetzt");
					
			if (unentschuldigteFehltage >30)
				Console.WriteLine("Der Schüler wird nicht versetzt");
		}
			
			public static double durchschnittBerechnen(int[] noten, int leistungskursIndex1, int leistungskursIndex2) {
			
			int gesamtwert = 0 ;
			for (int i = 0; i<noten.Length;i++){
				gesamtwert += noten[i];	
			}
			
	        double durchschnitt = (double)gesamtwert / (double)noten.Length;
			
			double Notendurchschnitt = (17-durchschnitt)/3;
			
			return Notendurchschnitt;
			
		}
			
			
			
		}
	}

		

	
