using System;

namespace structure_airport
{

	class MainClass
	{

		class ayush:MainClass

		{
			public void name()
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine ("\t\t\t   ___________________________\n");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine ("\t\t        AllRightsReserved TheThinkingOshi ");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine ("\t\t\t     ______________________");
				Console.ForegroundColor = ConsoleColor.White;
			}

		}
		struct cabs
			{
				public string name;
				public string cabNo;
				public string routcodeM;
		     	public string typeOc;
			};

			public static class GlobalData   // global value declearation
			{
		   		 //	public static cabs [] tr= new tr[10];
		    	   public static string routcode;
		   	       public static int icab;
					public static int delcabG;
			};
			
		public static void Main (string[] args)
		{
			
			{
				
				ayush logo = new ayush ();
				int i;
				string passwo = "oc";
				string SUV = "SUV";
				String SEDAN ="SEDAN";
				int flag = 0;
				Console.Clear ();
				Console.ForegroundColor = ConsoleColor.White;
			    Console.WriteLine("\t\t____________________________________________________________________________________________________________________________\n\n");
				Console.WriteLine ("\t              Welcome to NEW DELHI AIRPORT CAB services                      ");
				Console.WriteLine("\t\t\t____________________________________________________________________________________________________________________________\n");
				Console.WriteLine ("\t                    * Thought for the day *  \n                      ");
				Console.WriteLine ("\t\t\t    i hate you i love you\n\n");
				Console.WriteLine("");
				Console.WriteLine ("\n\t\t\t  press any  key to continue\n\n\n");

				logo.name ();

				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("enter the password");
				string pass = Console.ReadLine ();
				if (passwo == pass)
					goto x;
				else
					goto y;
				
				    x:

					Console.Clear ();
					Console.WriteLine ("\n\n\t\t   PLEASE FILL DETAILS OF AVAILABLE CABS \n");
					Console.WriteLine ("\t\t\t_________________________"               );
					Console.WriteLine ("\nenter the total number ofcab\n\n");

					int max = Convert.ToInt16 (Console.ReadLine ());
					cabs[] todays = new cabs[max];
					cabs[] custumer = new cabs[max];
					cabs[] temp = new cabs[max];
					cabs[] custum_cancil = new cabs[max]; 
					cabs[] todays_new = new cabs[max];
					cabs[] todays_temp = new cabs[max];
					Console.Clear ();
					Console.WriteLine ("Enter name cab_No and rote\n\n");
					for (i = 0; i < max; i++)
				{
						Console.Write ("Name of driver: ");
						todays [i].name = Console.ReadLine (); 
						Console.WriteLine ();
						Console.Write ("Enter cab number: ");
						todays [i].cabNo = Console.ReadLine ();
						Console.WriteLine ();
						Console.Write ("Available on rout: ");
						todays [i].routcodeM = Console.ReadLine ();
						Console.WriteLine ();
						Console.Write ("Class of cab: ");
						todays [i].typeOc = Console.ReadLine ();
						Console.WriteLine ();
						Console.WriteLine ("");
					Console.WriteLine ("\n\t\t\t_________________________\n\n");
				}
					Console.Clear ();
					Console.WriteLine ("\ndatabase of the cab according to the entry is\n");
					Console.WriteLine ("---------------------------------------------------------------------");
					Console.WriteLine ("NAME \t CAB NO. \t ROUTE  \t  TYPE ");
					Console.WriteLine ("---------------------------------------------------------------------");
					for (i = 0; i < max; i++) {
						Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc);
					}

					Console.WriteLine ("_____________________________________________________________________");
					Console.ReadKey ();
					Console.Clear ();
					
			    b:
			     
				Console.Clear ();
				Console.WriteLine("\t\t____________________________________________________________________________________________________________________________\n\n");
				Console.WriteLine ("\t                Welcome to Cab Booking System                     \n");
				Console.WriteLine ("\t\t\t____________________________________________________________________________________________________________________________\n");
				Console.WriteLine ("\t        * WELCOME TO CUSTOMER CAB BOOKING DATABASE  *  \n                      ");
				Console.WriteLine ("\t\t\t    i hate you i love you\n\n");
				if (flag == 1) 
				{
					Console.WriteLine ("\n\n          PRESS 1 IF YOU WANT TO CANCIL YOUR CURRENT CAB BOOKING\n ");
					Console.WriteLine ("\n\n             PRESS 2 IF YOU WANT TO GO TO ADMINISTRATOR MENU ");
					Console.WriteLine ("\n\n                        PRESS ANY KEY TO CONTINUE");

					char cancilOP = Convert.ToChar (Console.ReadLine ());
					if (cancilOP == '1')
						goto f;
					else if (cancilOP == '2')
						goto z;
					else
						goto e;
				}
				else 
				{
					Console.WriteLine ("\n\n               PRESS 1 IF YOU WANT TO GO TO ADMINISTRATOR MENU ");
					Console.WriteLine ("\n\n                          PRESS ANY KEY TO CONTINUE");
					char canc = Convert.ToChar (Console.ReadLine());
					if (canc == '1')
						goto z;
					else 
						goto e;
				}
			
				e:

				Console.Clear ();
				Console.WriteLine ("_______________________________________________________________________\n\n");
				Console.WriteLine ("\t\t\tCHOSE YOUR LOCATION.\n");
				Console.WriteLine ("_______________________________________________________________________\n\n");
				Console.WriteLine ("\n1.AIRPORT\t\n\n2.NEW DELHI\t\n\n3.GURGAO\t\n\n4.NOIDA\n\n");			
				int start = Convert.ToInt16 (Console.ReadLine ());
				Console.Clear ();
				Console.WriteLine ("_______________________________________________________________________\n\n");
				Console.WriteLine ("\t\t\tCHOSE YOUR DESTINATION.\n");
				Console.WriteLine ("_______________________________________________________________________\n\n");
				Console.WriteLine ("\n1.AIRPORT\t\n\n2.NEW DELHI\t\n\n3.GURGAO\t\n\n4.NOIDA\n\n");	
				int end = Convert.ToInt16 (Console.ReadLine ());
				Console.Clear ();
				if (start == 1 && end == 2)
					GlobalData.routcode = "-white lane";
				else if (start == 1 && end == 3)
					GlobalData.routcode = "-yellow lane";
				else if (start == 1 && end == 4)
					GlobalData.routcode = "-blue lane";
				else if (start == 2 && end == 1)
					GlobalData.routcode = "+white lane";
				else if (start == 3 && end == 1)
					GlobalData.routcode = "+yellow lane";
				else if (start == 4 && end == 1)
					GlobalData.routcode = "+blue lane";
				else
				{
					Console.WriteLine ("--------------------------------------------------------------------------\n");
					Console.WriteLine ("\t\tSORRY , Airport Cab Serices doesnot provide service for this rout. \n");
					Console.WriteLine ("--------------------------------------------------------------------------");
					Console.ReadLine ();
					goto b;
				}
				Console.Clear ();
				Console.WriteLine ("Cabs available for your your route are.\n\n");
				Console.WriteLine ("---------------------------------------------------------------------");
				Console.WriteLine ("NAME \t CAB NO. \t ROUTE  \t  TYPE ");
				Console.WriteLine ("---------------------------------------------------------------------");
			for (i = 0; i < max; i++)
				{
					if (GlobalData.routcode == todays [i].routcodeM)
						Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc);
				}   
				Console.WriteLine ("_________________________________________________________________________\n\n");
				Console.Write ("Enter the cab number you  want to book.: ");
				string temp_cbno = Console.ReadLine ();
				Console.Clear ();
				Console.WriteLine ("\t\t\t\tYOUR SELECTED CAB DETAIL : \n\n");
				Console.WriteLine ("------------------------------------------------------------------------------\n");
				Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t  CLASS ");
				Console.WriteLine ("------------------------------------------------------------------------------\n");
				for (i = 0; i < max; i++) 
				{
					if (todays [i].cabNo == temp_cbno)
					{
						Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc);
						GlobalData.icab = i;
						//Console.WriteLine(GlobalData.icab );
						Console.WriteLine ("___________________________________________________________________________");
					}
				}
				Console.ReadKey ();
				Console.Clear ();
				int ab = GlobalData.icab;
				for (i = 0; i < max; i++)
				{
					if (i == GlobalData.icab)
						custumer [i] = todays [i];
					else
						continue;
				}
				Console.WriteLine ("You have selected : \n\n");
				Console.WriteLine ("-----------------------------------------------------------------------------");
				Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t   CLASS ");
				Console.WriteLine ("-----------------------------------------------------------------------------");
				Console.WriteLine ("_____________________________________________________________________________");
				for (i = 0; i < max; i++) 
				{
					Console.WriteLine (custumer [i].name + "\t  " + custumer [i].cabNo + "\t      " + custumer [i].routcodeM + "\t  " + custumer [i].typeOc);
				}Console.WriteLine ("_____________________________________________________________________________\n\n\n");

				if (SUV == custumer [ab].typeOc)
					Console.WriteLine ("\t\tCost of booking is 789 Rupees Inc of all taxex.\n");
				else if (SEDAN == custumer [ab].typeOc)
					Console.WriteLine ("\t\tCost of booking is 599 Rupee Inc of all taxes. \n");
				else
					Console.WriteLine ("\t\tCost of booking id 399 Rupee Inc of all taxex.\n ");

				d:

				Console.WriteLine ("\n\t\t    If you want to continue booking. \n");
				Console.WriteLine ("\t\t     Press 'Y' to conform \n\n\t\t    Press 'N' to ReBook your cab\n\n\t\t     Or press any key to exit.\n");
				char option = Convert.ToChar (Console.ReadLine ());
				string pr1 = "FIRSTRIDE" ;
				string pr2 = "GIRLSDAY";
				String pr3 = "BLACKRIDE";
			
				if (option == 'y' ||option == 'Y')
				{
					Console.Clear ();
					Console.WriteLine ("\n\n\t\t   For promotional coad press 1.\n\n\t\t To conform your booking press 2.\n\n\t\tOr press any key to go to main menu. \n");					
					int book = Convert.ToInt16 (Console.ReadLine ());
					if (book == 1)
					{   Console.Clear ();
						Console.WriteLine ("\n\n\n\t\tDo you have any PURMOTIONAL/REFERENCE code\n");
						Console.WriteLine ("\n\tIf yes then press 1.\n\tPress 2 to continue your booking. \n\tPress any key to Re-book your cab  \n\n");
						int lastloop = Convert.ToInt16 (Console.ReadLine ());
						Console.WriteLine ();
						Console.Write ("Enter the PROMAOTIONA COAD : ");
						if (lastloop == 1) 
						{
							string purop = Console.ReadLine ();
							if (purop == pr1)
								Console.WriteLine ("\nYou have requested for FIRSTRIDE. \nYou can book any cab for 300 Rupee Inc of all taxes. \n");
							else if (purop == pr2)
								Console.WriteLine ("\nYou have requested for GIRLSDAY. \nYou can book any cab for 200 Rupee Inc of all taxes. \n");
							else if (purop == pr3)
								Console.WriteLine ("\nYou have requested for BLACKRIDE.\nYou will get first 20 KM free service. \n ");
							else {
								Console.WriteLine ("THIS COAD IS INVALID OR EXPIRED");
								Console.WriteLine ("Press enter to continue your booking ");
								Console.ReadKey ();
								goto d;
							}
						} 
						else if (lastloop == 2)
						  {
							Console.ReadKey ();
							Console.Clear ();
							goto c;
						  }
						else
							goto d; 
					}
					else if (book== 2)
						goto c;
					else
						goto x;
					c:
					//Console.Clear ();
					Console.WriteLine ("\n\n\n\n\n\t\tCongurlations you have sucessfully booked your cab.");
					goto a;
				}
				else if (option == 'n' ||option== 'N')
				{
					Console.WriteLine ("\nPlease Re-enter your details");
				    Console.ReadKey ();
					Console.Clear ();
					goto b;
				}
				else
				{
					goto x;
				}

				//Console.WriteLine ("____________________________________________________________________");

				a:

				Console.ReadKey();
				Console.Clear ();
				 //  Console.WriteLine ("Current database of cabs");
				for(i=0;i<max;i++)
				{
					if(i<GlobalData.icab)
						temp[i]= todays[i];
					else if (i == GlobalData.icab)
						continue;
					else if (i>GlobalData.icab)
						temp [i-1] = todays[i];
				}
				max--;
				for (i = 0; i < max; i++)
				{
					todays [i] = temp [i]; 
				}
				Console.WriteLine ("-----------------------------------------------------------------------------");
				Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t  CLASS");
				Console.WriteLine ("-----------------------------------------------------------------------------\n");
				for (i = 0; i < max; i++) 
				{
					Console.WriteLine (todays [i].name + "\t" + todays [i].cabNo + "\t" + todays [i].routcodeM+ "\t  "+ todays [i].typeOc);
				}
				Console.WriteLine ("__________________________________________________________________________");
				Console.Clear ();
				Console.WriteLine ("\n\n Press ENTER to go to main menue");
				Console.ReadKey();
				flag=1;

				goto b;

				//CANCILATION OF BOOKED CAB 

				f:

				Console.WriteLine("\n\n\n\t\t     TO CONFORM CANCILATION PRESS 1  \n\n \t\t     OR PRESS ANY KEY TO GO TO BACK .");
				char cbook = Convert.ToChar (Console.ReadLine());
				if (cbook == '1')
				{
				Console.Clear ();
				int abc = GlobalData.icab;
				for (i = 0; i <max+1 ; i++) 
				{
					custum_cancil [i] = custumer [i];
				}
				for (i = 0; i < max+1; i++) 
				{
					custum_cancil [max] = custumer [abc]; 
				}
					Console.WriteLine ("-----------------------------------------------------------------------------");
					Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t  CLASS");
					Console.WriteLine ("-----------------------------------------------------------------------------\n");
					for (i = 0; i < max; i++) {
						Console.WriteLine (custum_cancil [i].name + "\t  " + custum_cancil [i].cabNo + "\t      " + custum_cancil [i].routcodeM + "\t  " + custum_cancil [i].typeOc);
					}
				//Console.WriteLine ("current value of max" + max);
				max++;
				//Console.WriteLine ("the final max"+max);
				for (i = 0; i < max; i++) 
				{
					todays [max-1] = custum_cancil [max-1];
				}
				flag = 0;
				Console.WriteLine ("\n\n           YOU HAVE SUCESFULLY CANCELED YOUR BOOKING \n ");
				Console.ReadKey ();
				goto b;
				}
				else
				{
					goto b;
				}
					
				// 	ENTRY OF NEW CABS TO THE DATABASE

				z:

				string paswo_adm = "d";
				Console.Clear ();
				Console.WriteLine("\t\t____________________________________________________________________________________________________________________________\n\n");
				Console.WriteLine ("\t                Welcome to NEW DELHI AIRPORT cab services                      ");
				Console.WriteLine("\t\t\t____________________________________________________________________________________________________________________________\n");
				Console.WriteLine ("\t                    * Thought for the day *  \n                      ");
				Console.WriteLine ("\t\t\t    i hate you i love you\n\n");
				Console.WriteLine("");
				Console.WriteLine ("\n\n\n\t\t\t  press any  key to continue");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("enter the password");
				string pass1 = Console.ReadLine ();
				if (paswo_adm == pass1)
					goto i;
				else
				{
					Console.WriteLine ("INCORRCT PASSWORD");
					Console.ReadKey ();
					goto b;
				}

				i:

				Console.Clear ();
				Console.WriteLine ("\n\n\t\t       WELCOME TO CAB DATABASE MENU \n");
				Console.WriteLine ("\t\t\t_________________________"               );
				Console.WriteLine ("\n\n\t\t     PRESS 1 TO VIEW THE CURRENT DATABASE ");
				Console.WriteLine ("\n\n\t\t     PRESS 2 TO UPDATE ALL THE DATABASE ");
				Console.WriteLine ("\n\n\t\t     PRESS 3 TO DELET CABS FROM DATABASE  \n");
				Console.WriteLine ("\n\n\t\t           ENTER PASSWORD TO EXIT");
				Console.WriteLine ("\n\n\t\t      PRESS ANY KEY TO GO TO MAIN MENU");
				Console.WriteLine ("\t\t\t  _________________________"   );  
				char data = Convert.ToChar (Console.ReadLine ());
				if (data == '1')
				{			
					Console.Clear ();
					Console.WriteLine ("-----------------------------------------------------------------------------");
					Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t    CLASS ");
					Console.WriteLine ("-----------------------------------------------------------------------------");
					Console.WriteLine ("_____________________________________________________________________________");
				 
					for (i = 0; i < max; i++) 
					{
						Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc);
					}
					Console.ReadKey ();
					goto i;
				}
				if (data == '3')
     	{	
					Console.WriteLine ("Current databse");
				Console.Clear ();
				Console.WriteLine ("-----------------------------------------------------------------------------");
				Console.WriteLine ("NAME \t CAB NO. \t ROUTE \t    CLASS ");
				Console.WriteLine ("-----------------------------------------------------------------------------");
				Console.WriteLine ("_____________________________________________________________________________");
				for (i = 0; i < max; i++) 
				{
					Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc+"\n\n");
				}
				Console.WriteLine ("_____________________________________________________________________________");
					{
						Console.WriteLine ("\n\nEnter the cab no yu want to deleate");
						Console.WriteLine ("\nPress 'N' to go back");
						string delcab = Console.ReadLine ();
						if (delcab == "n" || delcab == "N")
							goto i;
						else {
							for (i = 0; i < max; i++)
								if (todays [i].cabNo == delcab)
									GlobalData.delcabG = i; 
				
							for (i = 0; i < max; i++) {
								if (i < GlobalData.delcabG)
									todays_temp [i] = todays [i];
								else if (i == GlobalData.delcabG)
									continue;
								else
									todays_temp [i - 1] = todays [i];
							}
							max--;
							for (i = 0; i < max; i++) {
								todays [i] = todays_temp [i];
							}
							Console.WriteLine ("\t\t\\t  ______________________");
							Console.WriteLine ("\n\n\t         CAB IS DELATED FROM THE DATABASE");
							/*for (i = 0; i < max; i++) {
								Console.WriteLine (todays [i].name + "\t  " + todays [i].cabNo + "\t      " + todays [i].routcodeM + "\t  " + todays [i].typeOc);
							}*/
							Console.ReadKey ();
							goto i;

						}
					}
				}

				else if (data == 'd')
					goto y;
				else if (data == '2')
					goto x;
				else
					goto b;
				}
				y: 

				Console.ReadKey ();

			}

		}
	}