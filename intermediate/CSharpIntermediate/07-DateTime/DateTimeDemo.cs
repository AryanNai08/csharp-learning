using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._07_DateTime
{
    internal class DateTimeDemo
    {
        public static void Run()
        {
            // ----------------------------------
            // 1. CURRENT DATE & TIME
            // ----------------------------------
            DateTime now = DateTime.Now;        // Current local date & time
            DateTime today = DateTime.Today;    // Today with time = 00:00:00
            DateTime utcNow = DateTime.UtcNow;  // Coordinated Universal Time

            Console.WriteLine("Now      : " + now);
            Console.WriteLine("Today    : " + today);
            Console.WriteLine("UTC Now  : " + utcNow);

            // ----------------------------------
            // 2. DATE FORMATTING (VERY IMPORTANT)
            // ----------------------------------
            // Common formats used in reports, logs, UI
            Console.WriteLine("\nFormatted Dates:");
            Console.WriteLine(now.ToString("dd/MM/yyyy"));        // 01/02/2026
            Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm")); // 01-02-2026 14:30
            Console.WriteLine(now.ToString("yyyy-MM-dd"));       // ISO format (APIs)

            // ----------------------------------
            // 3. PARSING DATE FROM STRING
            // ----------------------------------
            // User input / DB / API usually comes as string
            string inputDate = "15/08/2002";

            // Exact parsing (safe & recommended)
            DateTime dob = DateTime.ParseExact(
                inputDate,
                "dd/MM/yyyy",
                null
            );

            Console.WriteLine("\nParsed DOB: " + dob.ToString("dd MMM yyyy"));

            // ----------------------------------
            // 4. TIMESPAN (DIFFERENCE BETWEEN DATES)
            // ----------------------------------
            // Calculate age using TimeSpan
            TimeSpan ageSpan = DateTime.Now - dob;

            int ageInYears = ageSpan.Days / 365; // Approximate age
            Console.WriteLine("Age (years approx): " + ageInYears);

            // ----------------------------------
            // 5. ADDING / SUBTRACTING TIME
            // ----------------------------------
            DateTime after7Days = now.AddDays(7);
            DateTime before1Hour = now.AddHours(-1);

            Console.WriteLine("\nAfter 7 days : " + after7Days);
            Console.WriteLine("Before 1 hour: " + before1Hour);

            // ----------------------------------
            // 6. REAL-WORLD EXAMPLE 1: LOGIN SYSTEM
            // ----------------------------------
            DateTime loginTime = DateTime.Now;
            Console.WriteLine("\nUser logged in at: " + loginTime);

            // Simulate user staying logged in
            DateTime logoutTime = loginTime.AddMinutes(45);

            TimeSpan sessionDuration = logoutTime - loginTime;
            Console.WriteLine("Session duration (minutes): " + sessionDuration.TotalMinutes);

            // ----------------------------------
            // 7. REAL-WORLD EXAMPLE 2: BILLING / DURATION
            // ----------------------------------
            // Example: Parking system
            DateTime parkingIn = DateTime.Now.AddHours(-3).AddMinutes(-20);
            DateTime parkingOut = DateTime.Now;

            TimeSpan parkedFor = parkingOut - parkingIn;

            Console.WriteLine("\nParking duration:");
            Console.WriteLine("Hours : " + parkedFor.Hours);
            Console.WriteLine("Minutes: " + parkedFor.Minutes);

            // ----------------------------------
            // 8. REAL-WORLD EXAMPLE 3: EXPIRY CHECK
            // ----------------------------------
            DateTime expiryDate = new DateTime(2026, 12, 31);

            if (DateTime.Now > expiryDate)
                Console.WriteLine("\nProduct expired");
            else
                Console.WriteLine("\nProduct valid till: " + expiryDate.ToString("dd MMM yyyy"));

            // ----------------------------------
            // END
            // ----------------------------------
            Console.WriteLine("\nDate & Time demo completed");
        }
    }
}
