using System;
using System.ComponentModel.DataAnnotations;
namespace Airport_assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings");
            Console.WriteLine(" ");
            Console.WriteLine("If you are interested for One way trip, press the button:one");
            Console.WriteLine("If you are interested for a round trip, press the button:round");
            string trip_choice = Console.ReadLine();
            do
            {
                if (trip_choice == "one")
                {
                    Console.WriteLine("Please Choose an airport as your departure airport");
                    string airport_Departure = Console.ReadLine();
                    Console.WriteLine("Choose one airway, you want to travel:AGEAN OR OLYMPIAKI");
                    string airway = Console.ReadLine();
                    Console.WriteLine("Choose one hour you want to travel");
                    Console.WriteLine("The hours_of the Departure are:07:00, 09:00, 12:00, 16:00, 20:00");
                    string hour_Departure = Console.ReadLine();
                    string call_Departure = Departure(airport_Departure, hour_Departure, airway);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the Date you wish to travel");
                    int Date_Departure = Int32.Parse(Console.ReadLine());
                    int call_Date = Date(Date_Departure);
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the month you want to travel");
                    int month_Departure = Int32.Parse(Console.ReadLine());
                    int call_month = Month(month_Departure);
                    Console.WriteLine("Choose the year you want to travel");
                    int year_Departure = Int32.Parse(Console.ReadLine());
                    int call_year = Year(year_Departure);
                    Console.WriteLine(" ");
                    Console.WriteLine("Do you Prefer a low cost ticket or a buisness class ticket");
                    Console.WriteLine("For Low cost ticket Press l");
                    Console.WriteLine("For Buisness ticket Press b");
                    Console.WriteLine("We have to inform you, that in low cost tickets the suitcase is charged +20€");
                    string choice_Dticket = Console.ReadLine();
                    if (choice_Dticket == "l")
                    {
                        Console.WriteLine("The cost of the ticket you will choοse, is interconnected with the ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Hour of the Departure you have chosen, for instance the ticket, for the flight which Departs at 07:00 costs 40€");
                        Console.WriteLine(" ");
                        Console.WriteLine("So choose wisely!!! The cost of the ticket, will be formed based on the hour");
                        int L_cost_Departure = Int32.Parse(Console.ReadLine());
                        int call_cost = Law_Cost(L_cost_Departure);
                        Console.WriteLine("The total cost of the ticyjdvs ket is:"+(call_cost+20)+ "€");
                    }
                    else
                    {
                        Console.WriteLine("The tickets Prices are interconnected with the hour Departures");
                        Console.WriteLine(" ");
                        Console.WriteLine("For instance 07:00-100€ 09:00-150€ 12:00-250€ 16:00-400€");
                        Console.WriteLine("Choose the cost of the ticket");
                        int B_cost_Departure= Int32.Parse(Console.ReadLine());
                        int call_cost = Buisness_Cost(B_cost_Departure);
                        Console.WriteLine("The cost of the ticket is:" + call_cost);
                    }
                    Console.WriteLine("Choose a seat on which you want to travel");
                    Console.WriteLine("The avaluable seats are:");
                    Console.WriteLine("1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F");
                    string Seat_Departure = Console.ReadLine();
                    string call_seats = seats(Seat_Departure);
                    string call_information = Personal_info();
                    Console.WriteLine("Your First and Last name is:"+call_information);
                    string call_email = email();
                    Console.WriteLine("Your" + call_email);
                    string call_credit = credit();
                    Console.WriteLine("The information about the payment and your Credit_card is:" + call_credit);
                }
                else// The USER CHOSE A ROUND TRIP//
                {
                    //------DEPARTURE-DEPARTURE-DEPARTURE_DEPARTURE-----//
                    Console.WriteLine("DEPARTURE_DEPARTURE_DEPARTURE");
                    Console.WriteLine("Please Choose an airport as your departure airport");
                    string airport_Departure = Console.ReadLine();
                    Console.WriteLine("Choose one airway, you want to travel");
                    string airway = Console.ReadLine();
                    Console.WriteLine("Choose one hour you want to travel");
                    Console.WriteLine("The hours_of the Departure are:07:00, 09:00, 12:00, 16:00, 20:00");
                    string hour_Departure = Console.ReadLine();
                    string call_Departure = Departure(airport_Departure, hour_Departure, airway);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the Date you wish to travel");
                    int Date_Departure = Int32.Parse(Console.ReadLine());
                    int call_Date = Date(Date_Departure);
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the month you want to travel");
                    int month_Departure = Int32.Parse(Console.ReadLine());
                    int call_month = Month(month_Departure);
                    Console.WriteLine("Choose the year you want to travel");
                    int year_Departure = Int32.Parse(Console.ReadLine());
                    int call_year = Year(year_Departure);
                    Console.WriteLine(" ");
                    Console.WriteLine("Do you Prefer a low cost ticket or a buisness class ticket");
                    Console.WriteLine("For Low cost ticket Press L");
                    Console.WriteLine("For Buisness Ticket Press B");
                    Console.WriteLine("We have to inform you, that in low cost tickets the suitcase is charged +20€");
                    string choice_Dticket = Console.ReadLine();
                    if (choice_Dticket == "l")
                    {
                        Console.WriteLine("The cost of the ticket you will choοse, is interconnected with the ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Hour of the Departure you have chosen, for instance the ticket, for the flight which Departs at 07:00 costs 40€");
                        Console.WriteLine(" ");
                        Console.WriteLine("So choose wisely!!! The cost of the ticket, will be formed based on the hour");
                        int L_cost_Departure = Int32.Parse(Console.ReadLine());
                        int call_cost = Law_Cost(L_cost_Departure);
                        Console.WriteLine("The total cost of the ticket is:" + (call_cost + 20) + "€");
                    }
                    else
                    {
                        Console.WriteLine("The tickets Prices are interconnected with the hour Departures");
                        Console.WriteLine(" ");
                        Console.WriteLine("For instance 07:00-100€ 09:00-150€ 12:00-250€ 16:00-400€");
                        Console.WriteLine("Choose the cost of the ticket");
                        int B_cost_Departure = Int32.Parse(Console.ReadLine());
                        int call_cost = Buisness_Cost(B_cost_Departure);
                        Console.WriteLine("The cost of the ticket is:" + call_cost);
                    }
                    Console.WriteLine("Choose a seat on which you want to travel");
                    Console.WriteLine("The avaluable seats are:");
                    Console.WriteLine("1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F");
                    string Seat_Departure = Console.ReadLine();
                    string call_seats = seats(Seat_Departure);
                    //ARRIVAL--ARRIVAL--ARRIVAL--ARRIVAL
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("RETURN TRIP-RETURN-TRIP-RETURN-TRIP");
                    Console.WriteLine(" ");
                    Console.WriteLine("Please Choose an airport as your departure airport");
                    string airport_Departure_0 = Console.ReadLine();
                    Console.WriteLine("Choose one airway, you want to travel");
                    string airway_0 = Console.ReadLine();
                    Console.WriteLine("Choose one hour you want to travel");
                    Console.WriteLine("The hours_of the Departure are:05:30, 08:15, 14:20, 18:15, 22:00");
                    string hour_Departure_0 = Console.ReadLine();
                    string call_Departure_0 = Arrival(airport_Departure_0, hour_Departure_0, airway_0);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the Date you wish to travel");
                    int Date_Departure_0 = Int32.Parse(Console.ReadLine());
                    int call_Date_0 = Date(Date_Departure_0);
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the month you want to travel");
                    int month_Departure_0 = Int32.Parse(Console.ReadLine());
                    int call_month_0 = Month(month_Departure_0);
                    Console.WriteLine("Choose the year you want to travel");
                    int year_Departure_0 = Int32.Parse(Console.ReadLine());
                    int call_year_0 = Year(year_Departure_0);
                    Console.WriteLine(" ");
                    Console.WriteLine("Do you Prefer a low cost ticket or a buisness class ticket");
                    Console.WriteLine("For Low cost ticket Press L");
                    Console.WriteLine("For Buisness Ticket Press B");
                    Console.WriteLine("We have to inform you, that in low cost tickets the suitcase is charged +20€");
                    string choice_Dticket_0 = Console.ReadLine();
                    if (choice_Dticket_0 == "l")
                    {
                        Console.WriteLine("The cost of the ticket you will choοse, is interconnected with the ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Hour of the Departure you have chosen, for instance the ticket, for the flight which Departs at 07:00 costs 40€");
                        Console.WriteLine(" ");
                        Console.WriteLine("So choose wisely!!! The cost of the ticket, will be formed based on the hour");
                        int L_cost_Departure_0 = Int32.Parse(Console.ReadLine());
                        int call_cost_0 = Law_Cost(L_cost_Departure_0);
                        Console.WriteLine("The total cost of the ticket is:" + (call_cost_0 + 20) + "€");
                    }
                    else
                    {
                        Console.WriteLine("The tickets Prices are interconnected with the hour Departures");
                        Console.WriteLine(" ");
                        Console.WriteLine("For instance 07:00-100€ 09:00-150€ 12:00-250€ 16:00-400€");
                        Console.WriteLine("Choose the cost of the ticket");
                        int B_cost_Departure_0 = Int32.Parse(Console.ReadLine());
                        int call_cost_0 = Buisness_Cost(B_cost_Departure_0);
                        Console.WriteLine("The cost of the ticket is:" + call_cost_0);
                    }
                    Console.WriteLine("Choose a seat on which you want to travel");
                    Console.WriteLine("The avaluable seats are:");
                    Console.WriteLine("1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F");
                    string Seat_Departure_0 = Console.ReadLine();
                    string call_seats_0 = seats(Seat_Departure_0);
                    string call_information = Personal_info();
                    Console.WriteLine("Your First and Last name is:" + call_information);
                    string call_email = email();
                    Console.WriteLine("Your" + call_email);
                    string call_credit = credit();
                    Console.WriteLine("The information about the payment and your Credit_card is:" + call_credit);
                }
            } while (("call_Departure")!=("call_Departure_0"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cD"></param>
        /// <param name="hD"></param>
        /// <param name="pD"></param>
        /// <returns></returns>
        static string Departure(string cD, string hD, string pD)
        {
            //I Define three arrays: The array D gives the user the Departure options
            //The array HD=Hours Departure gives the user a restricted time-line, of the departure hours
            //The array PD=Plane Departure gives the user the choice between two main airways.
            string[] D = new string[5] { "ALEXANDROUPOLI", "KAVALA", "THESALLONIKI", "ATHENS", "HERACLIO" };
            string[] HD = new string[5] { "  07:00", "  09:00", "  12:00", "  16:00", "  20:00" };
            string[] PD = new string[2] { "AGEAN", "OLYMPIAKI" };
            // Ι asign the variable choice to be equal with the parameter cD, in which i use the methoD:ToUpper
            //which gives me the advance
            string choice = cD.ToUpper();
            string choice_0 = hD;
            string choice_1 = pD.ToUpper();
            string result_0 = "you have to choose one the hours which is given to you";
            string result_1;
            int found = 0;
            //erietta 29/11/2021 start
            bool foundVariable_choice = false;
            for (int i = 0; i < 5; i++)
            {
                if (choice == D[i])
                {
                    foundVariable_choice = true;
                }
            }
            if (foundVariable_choice == false)
            {
                Console.WriteLine("Λαθος departure. Τελος εκτελεσης του προγραμματος");
                Environment.Exit(0) ; //exit
            }
            //erietta 29/11/2021 end
            if (choice_1 == PD[0])
            {
                choice_1 = PD[0];
            }
            else if (choice_1 == PD[1])
            {
                choice_1 = PD[1];
            }
            else
            {
                choice_1 = "WRONG airway";
            }
            string result = "You have to choose one of the options, which is given in the list";
            Console.WriteLine("The Departure options are displayed in the List below");
            for (int i = 0; i < D.Length; i++)
            {
                Console.WriteLine(D[i] + "-->" + choice_1);
                for (int j = 0; j < HD.Length; j++)
                {
                    Console.WriteLine(HD[j]);
                    for (int k = 0; k < PD.Length; k++)
                    {
                        if (choice == D[i] && found == 0)
                        {
                            result = D[i];
                            found = 1;
                            if (choice_0 == HD[j])
                            {
                                result_0 = HD[j];
                            }
                            if (choice_1 == PD[k])
                            {
                                result_1 = PD[k];
                            }
                        }
                    }
                }
            }
            return result;
        }
        //SECOND FUNCTION//
        static string Arrival(string cA, string hA, string pA)
        {
            string[] HA = new string[5] { "05:30", "08:15", "14:20", "18:15", "22:00" };
            string[] A = new string[5] { "ALEXANDROUPOLI", "KAVALA", "THESALLONIKI", "ATHENS", "HERACLIO" };
            string[] PA = new string[2] { "Ellinair", "Skyexpress" };
            string choice = cA.ToUpper();
            string choice_0 = hA;
            string choice_1 = pA.ToUpper();
            string result = "You have to choose one of the options, which is given in the list";
            string result_0 = "You have to choose one of the  hour options, which is given in the list";
            string result_1;
            bool found = false;
            if (choice_1 == PA[0])
            {
                choice_1 = PA[0];
            }
            else if (choice_1 == PA[1])
            {
                choice_1 = PA[1];
            }
            else
            {
                choice_1 = "WRONG airway";
            }
            Console.WriteLine("The Departure options are displayed in the List below");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
                for (int j = 0; j < HA.Length; j++)
                {
                    Console.WriteLine(HA[j]);
                    for (int a = 0; a < PA.Length; a++)
                    {
                        if (choice == A[i] && found == false)
                        {
                            result = A[i];
                            found = true;
                            if (choice_0 == HA[j])
                            {
                                result_0 = HA[j];
                            }
                            if (choice_1 == PA[a])
                            {
                                result_1 = PA[a];
                            }
                        }
                    }
                }
            }
            return result;
        }
        //THIRD FUNCTION//
        static int Date(int date)
        {
            int[] DATE = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int choice = date;
            bool found = false;
            int result = 0;
            //Console.WriteLine("The days of the month can be seen below");
            for (int i = 0; i < DATE.Length; i++)
            {
                if (choice == DATE[i] && found == false)
                {
                    Console.WriteLine(DATE[i]);
                    found = true;
                    result = DATE[i];
                }
            }
            return result;
        }
        //FOURTH FUNCTION//
        static int Month(int month)
        {
            int[] MONTH = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int choice = month;
            bool found = false;
            int result = 0;
            //Console.WriteLine("The months can be seen below");
            for (int i = 0; i < MONTH.Length; i++)
            {
                if (choice == MONTH[i] && found == false)
                {
                    Console.WriteLine(MONTH[i]);
                    found = true;
                    result = MONTH[i];
                }
            }
            return result;
        }
        //FIFTH FUNCTION//
        static int Year(int year)
        {
            int[] YEAR = new int[] { 2021, 2022 };
            int choice = year;
            bool found = false;
            int result = 0;
            Console.WriteLine("The years you can choose to travel is:2021 and 2022");
            for (int i = 0; i < YEAR.Length; i++)
            {
                if (choice == YEAR[i] && found == false)
                {
                    Console.WriteLine(YEAR[i]);
                    found = true;
                    result = YEAR[i];
                }
            }
            return result;
        }
        //SIXTH FUNCTION//
        static string seats(string seat)
        {
            string[] SEAT = new string[12] { "1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F" };
            string choice = seat.ToUpper();
            bool found = false;
            string result = "The seat you have chosen, is not avaluable";
            for (int i = 0; i < SEAT.Length; i++)
            {
                if (choice == SEAT[i] && found == false)
                {
                    found = true;
                    result = SEAT[i];
                }
            }
            return result;
        }
        //SEVENTH FUNCTION//
        static int Law_Cost(int cost)
        {
            int[] L_COST = new int[] { 40, 50, 80, 120 };
            int choice = cost;
            bool found = false;
            int result = 0;
            Console.WriteLine("The cost of the tickets are being shown, just below.");
            for (int i = 0; i < L_COST.Length; i++)
            {
                if (choice == L_COST[i] && found == false)
                {
                    Console.WriteLine(L_COST[i]);
                    found = true;
                    result = L_COST[i];
                }
            }
            return result;
        }
        //8- FUNCTION//
        static int Buisness_Cost(int cost)
        {
            int[] B_COST = new int[] { 100, 150, 250, 450 };
            int choice = cost;
            bool found = false;
            int result = 0;
            Console.WriteLine("The cost of the tickets are being shown, just below.");
            for (int i = 0; i < B_COST.Length; i++)
            {
                if (choice == B_COST[i] && found == false)
                {
                    Console.WriteLine(B_COST[i]);
                    found = true;
                    result = B_COST[i];
                }
            }
            return result;
        }
        //9 FUNCTION//
        static string Personal_info()
        {
            string result_1, result_2;
            Console.WriteLine("Which is your First name?");
            string name_0 = Console.ReadLine();
            int boom = name_0.Length;
            if (boom <= 3 || boom >= 11)
            {
                result_1 = "ERROR-First Name,";
            }
            else
            {
                result_1 = name_0 + ",";
            }
            Console.WriteLine("Which is your Last name?");
            string Last_0 = Console.ReadLine();
            int kou_kou = Last_0.Length;
            if (kou_kou <= 3 || kou_kou >= 11)
            {
                result_2 = "ERROR-Last Name.";
            }
            else
            {
                result_2 = Last_0 + ".";
            }
            return (result_1 + result_2);
        }
        //10- FUNCTION//
        static string email()
        {
            Console.WriteLine("Give me your Email Adress");
            string email = Console.ReadLine();
            bool isValidEmail_check1 = email.Contains(".");
            bool isValidEmail_check2 = email.Contains("@");
            if (isValidEmail_check1 == false || isValidEmail_check2 == false)
            {
                if (isValidEmail_check1 == false && isValidEmail_check2 == true)
                {
                    return ("WRONG- you haven't included the dot, in your email");
                }
                else if (isValidEmail_check1 == true && isValidEmail_check2 == false)
                {
                    return ("WRONG-no @ char");
                }
                else
                {
                    return "WRONG-email";
                }
            }
            else
            {
                return (" email is:" + email);
            }
        }
        //11- FUNCTION//
        static string credit()
        {
            int card_balance = 1000;// εστω οτι εχει καρτα 1000 ευρω//
            Console.WriteLine("Give me the amount you will pay:");
            int card_payment = Int32.Parse(Console.ReadLine());
            if (card_balance >= card_payment && card_payment > 0)
            {
                card_balance = card_balance - card_payment;
                return ("The transaction has been completed, the amount of money in your credit is=" + card_balance);
            }
            else
            {
                if (card_payment < 0)
                {
                    return "Failed: pay amount is negative";
                }
                else if (card_payment == 0)
                {
                    return "Failed: pay amount is zero";
                }
                else if (card_balance < card_payment)
                {
                    return "Failed: Your card_balance is lower of the cost";
                }
                else
                {
                    return "Failed";
                }
            }
        }
    }
}