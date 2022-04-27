/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 26.04.2022
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnismanagment_Software
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Fach1, Fach2, Fach3, Fach4, Fach5, Fach6, Leistungskurs1, Leistungskurs2;
			int Note1, Note2, Note3, Note4, Note5, Note6, Note7, Note8; 
			
			Console.WriteLine("Zeugnismanagment-Software");
			
			Console.WriteLine("-----------------------------------------");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Name [Mustermann, Max]:");
			
			string name = Console.ReadLine ();
			
			Console.Write("Austellungsdatum [TT.MM.JJJJ]:");
			
			string Austellungsdatum = Console.ReadLine ();
			
			Console.WriteLine("Fehltage");
			
			Console.Write("Unentschuldigte Fehltage:");
			int Fehltage;
			Fehltage = Convert.ToInt32(Console.ReadLine());
			

			
			
			Console.WriteLine("-----------------------------------------");
			
			Console.Write("Leistungskurs1:");
			Leistungskurs1 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note1 = Convert.ToInt32(Console.ReadLine());
			if (Note1 > 15)
				Console.WriteLine("Ungültige Notenunpunkte eingetragen");
			
			Console.Write("Leistungskurs 2:");
			Leistungskurs2 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 1:");
			Fach1 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note3 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 2:");
			Fach2 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note4 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 3:");
			Fach3 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note5 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 4:");
			Fach4 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note6 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 5:");
			Fach5 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note7 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fach 6:");
			Fach6 = Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]:");
			Note8 = Convert.ToInt32(Console.ReadLine());
				
			Console.WriteLine("-----------------------------------------");
			
			//---------------Check Notenpunkte---------------
			
			
			if (Fehltage < 30) 
				
				Console.WriteLine("Der Schüler wird versetzt");
					
					if (Fehltage > 30)
					
						Console.WriteLine("Der Schüler wird nicht versetzt");
			
				if (Note1 < 5)
						
								Console.WriteLine("Der Leistungskurs 1 ist ein Unterkurs");
			
				if (Note2 < 5)
					
								Console.WriteLine("Der Leistungskurs 2 ist ein Unterkurs");
				
				if (Note3 < 5)
					
								Console.WriteLine("Das Fach 1 ist ein Unterkurs");
				
				if (Note4 < 5)
					
					            Console.WriteLine("Das Fach 2 ist ein Unterkurs");

				if (Note5 < 5)
					
								Console.WriteLine("Das Fach 3 ist ein Unterkurs");
				
				if (Note6 < 5)
					
								Console.WriteLine("Das Fach 4 ist ein Unterkurs");	
				
				if (Note7 < 5)
					
								Console.WriteLine("Das Fach 5 ist ein Unterkurs");		
				
				if (Note8 < 5)
					
								Console.WriteLine("Das Fach 6 ist ein Unterkurs");
				
				
				
			Console.WriteLine("-----------------------------------------");	
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			

			
//Durschnitt berechnen
			
			/* int gesamtwert = Fach1+Fach2+Fach3+Fach4+Fach5+Fach6+Leistungskurs1+Leistungskurs2;
			string eingabe, anzahl;
			while(eingabe != "-1")
			{
				Console.WriteLine("Geben Sie -1 ein um den Durchschnitt zu berechnen");
				
				eingabe = Console.ReadLine();
				if(eingabe == "-1")
				{
					Console.WriteLine("--------------------------------------------------------------");
					double durchschnitt = (double)gesamtwert / (double)anzahl;
					Console.WriteLine("Der Durchschnitt ist " + durchschnitt);
					
					double Notendurchschnitt = (17-durchschnitt)/3;
					Console.WriteLine("Umgerechnet in Noten ist der Durchschnitt " + Notendurchschnitt);
				}
				
				if(Int32.TryParse(eingabe, out aktuelleZahl) && aktuelleZahl >0 && aktuelleZahl<16){
					gesamtwert=gesamtwert+aktuelleZahl;
				}
				else
				{
					if(!(eingabe=="-1"))
					{
						Console.WriteLine("Bitte geben Sie ganzzahlige Werte zwischen 1 und 15 ein!");
					}
					continue;
				}
				anzahl++;   */
			}
	}
	
}


		