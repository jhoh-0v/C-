using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230921_practice_2{

    class Astrological_Sign_Determiner{

        static void Main(string[] args){

            Console.WriteLine("This is Astrological Sign Determiner.");
            Console.WriteLine("Enter your Birthdate(day month): ");
            string day_input = Console.ReadLine();
            string month_input = Console.ReadLine();

            string month = Month_Alliases(month_input);

            string day_error = Day_Error(day_input, month);
            string month_error = Month_Error(month);

            if(day_error != null){
                Console.WriteLine(day_error);
            }

            if(month_error != null){
                Console.WriteLine(month_error);
            }

            else{
                try{
                    string sign = Astrological_Sign(int.Parse(day_input), month);
                    Console.WriteLine("Your Astrological Sign is " + sign);
                }

                catch(FormatException){
                    return;
                }
            }

            Console.ReadKey();
        }

        public static string Month_Alliases(string month_input){

            switch (month_input.ToLower()){
                case "jan":
                case "january":
                    return "Jan";

                case "feb":
                case "february":
                    return "Feb";

                case "mar":
                case "march":
                    return "Mar";

                case "apr":
                case "april":
                    return "Apr";

                case "may":
                    return "May";
                    
                case "jun":
                case "june":
                    return "Jun";

                case "jul":
                case "july":
                    return "Jul";

                case "aug":
                case "august":
                    return "Aug";
                    
                case "sep":
                case "september":
                    return "Sep";

                case "oct":
                case "october":
                    return "Oct";

                case "nov":
                case "november":
                    return "Nov";

                case "dec":
                case "december":
                    return "Dec";

                default:
                    return null;
            }
        }

        public static string Day_Error(string day_input, string month){

            string[] month_arr_30 = {"Apr", "Jun", "Sep", "Nov"};
            string[] month_arr_31 = {"Jan", "Mar", "May", "Jul", "Aug", "Oct", "Dec"};
            string feb = "Feb";
            
            if(int.TryParse(day_input, out int day)){
                if(day < 1 || day > 31){
                    return "ERROR: WRONG DAY";
               }

                if(month_arr_30.Contains(month)){
                    if(day < 1 || day > 30){
                        return "ERROR: WRONG DAY";
                    }
                }

                else if(month_arr_31.Contains(month)){
                    if(day < 1 || day > 31){
                        return "ERROR: WRONG DAY";
                    }
                }

                else if(month == feb){
                    if(day < 1 || day > 29){
                        return "ERROR: WRONG DAY";
                    }
                }
            }

            else{
                return "ERROR: WRONG DAY";
            }

            return null;
        }

        public static string Month_Error(string month){

            string[] month_arr_all = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

            if(month_arr_all.Contains(month) == false){
                return "ERROR: WRONG MONTH";
            }

            return null;
        }

        public static string Astrological_Sign(int day, string month){

            if(month == "Mar" && 21 <= day || month == "Apr" && day <= 19){
                return "Aries";
            }

            else if(month == "Apr" && 20 <= day || month == "May" && day <= 20){
                return "Taurus";
            }

            else if(month == "May" && 21 <= day || month == "Jun" && day <= 20){
                return "Gemini";
            }

            else if(month == "Jun" && 21 <= day || month == "Jul" && day <= 22){
                return "Cancer";
            }

            else if(month == "Jul" && 23 <= day || month == "Aug" && day <= 19){
                return "Leo";
            }

            else if(month == "Aug" && 23 <= day || month == "Sep" && day <= 22){
                return "Virgo";
            }

            else if(month == "Sep" && 23 <= day || month == "Oct" && day <= 22){
                return "Libra";
            }

            else if(month == "Oct" && 23 <= day || month == "Nov" && day <= 21){
                return "Scorpio";
            }

            else if(month == "Nov" && 22 <= day || month == "Dec" && day <= 21){
                return "Sagittarius";
            }

            else if(month == "Dec" && 22 <= day || month == "Jan" && day <= 19){
                return "Capricorn";
            }

            else if(month == "Jan" && 20 <= day || month == "Feb" && day <= 18){
                return "Aquarius";
            }

            else if(month == "Feb" && 19 <= day || month == "Mar" && day <= 20){
                return "Pisces";
            }

            else{
                return "ERROR: CAN NOT DETERMINE";
            }      
        }
    }
}