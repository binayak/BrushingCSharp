// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TryCatchFinally.cs" company="home">
//   This is just to practice.
//  - end user experience : Weird message
//  - Security: Exception information contains valuable information to a hacker.
//  - Resource freeing: Streamreader will never close, resouce is occupied. 
// </copyright>
// <summary>
//   Defines the TryCatchFinally type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BrushingOffCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;

    using Microsoft.Win32.SafeHandles;

    /// <summary>
    /// The try catch finally.
    /// Exception is nothing but an object of System.Exception class.
    /// </summary>
    public class TryCatchFinally
    {

        /// <summary>
        /// Main for this class, called from Program.cs
        /// Ctrl + Alt + E shows all the exceptions available in Dot NET Framework. 
        /// </summary>
        public static void MainForTryCatch()
        {
            StreamReader sm = null;
            try
            {
                sm = new StreamReader(@"c:\testFiles\data.txt"); // Change the path to get exceptions.
                Console.WriteLine(sm.ReadToEnd());
            }
            catch (DirectoryNotFoundException d) 
            {
                // Specific Exception dealing with directory
                Console.WriteLine("Directory not found exception **************************");
                Console.WriteLine(d.Message);
                Console.WriteLine("*************************************************");

            }
            catch (FileNotFoundException ex)
            {
                // Specific exception catch dealing with file
                Console.WriteLine("Details on the File not found Exception are: ");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception MessagE: " + ex.Message);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception InnterException: " + ex.InnerException);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception Source: " + ex.Source);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception Stack Trace: " + ex.StackTrace);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception Target Site: " + ex.TargetSite);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception Help Link :" + ex.HelpLink);
                Console.WriteLine("*************************************************");
                Console.WriteLine("The file name that we couldnt find is : " + ex.FileName);
                Console.WriteLine("*************************************************");
                //throw;
            }
            catch (Exception e)
            {
                // Most basic or generalized exception which will catch all execption.
                Console.WriteLine(
                    "This is base exception type, gets executed if non of the catch block catches the exception. Exception stack trace is: "
                    + e.StackTrace);
                Console.WriteLine("*************************************************");
                Console.WriteLine("Exception MessagE: " + e.Message);

            }
            finally
            {
                // Cleaning resources.
                Console.WriteLine("\nThis is finally block executing");
                if (sm != null)
                {
                    sm.Close(); // Releasing resources
                }
            }

            // Following is high level try catch to avoid any exception thrown by, any finally methods in following method.
            try
            {
                Console.WriteLine("Here a method is called, where exception is being thrown by finally block.");
                ExceptionHappenningInFinallyBlock();
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The caught exception message: "+ e.Message);
            }
        }

        /// <summary>
        /// The exception happening in finally block.
        /// </summary>
        /// <exception cref="Exception">
        /// Just to check levels of exceptions
        /// </exception>
        public static void ExceptionHappenningInFinallyBlock()
        {
            try
            {
                Console.WriteLine("The try block*************************");
                throw new Exception("This is thrown from Try Block at lower level method");
            }
            catch (Exception e)
            {
                // If this catch block in not present here, then the exception thrown by try block will be lost. When control catches exception from the called method.
                Console.WriteLine("The catch block*************************");
                Console.WriteLine("The try block exception at lower level is caught by this catch block.");
                Console.WriteLine("Exception Error Message is: " + e.Message);
            }
            finally
            {
                Console.WriteLine("The finally block*************************");
                throw new Exception("This is exception thrown from the finally block.");
            }
        }




    }
}
