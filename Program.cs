using System;
using System.IO;
using recordIem.EmailGenerator.Exceptions;

namespace recorditem.EmailGenerator
{
public class Program {

    private static int totalEmails = 0;
    private static string domainName = String.Empty;
    public static void Main(string[] args) {
    
    bool result = false;
    
    try {
        if(args.Length > 3) {

            if ((args[0] == "-c" && args[2] == "-d") || (args[0] == "-d" && args[2] == "-c"))
            {
                
                if(args[0] == "-c") {
                    
                    result = Int32.TryParse(args[1],out totalEmails);

                        if(!result) {
                            throw new InvalidArgumentException("An integer value is expected for the total records e.g. -c 100");
                        }
                }
                
            
                if (args[2] == "-d") {
                    domainName = args[3];    
                } 
                
                if(args[0] == "-d") {
                    domainName = args[1];
                }
                
                if (args[2] == "-c") {
                   
                   result =  Int32.TryParse(args[3],out totalEmails);

                   if(!result) {
                       throw new InvalidArgumentException("An integer value is expected for the total records e.g. -c 100");

                   }

                } 

        } else {

            throw new InvalidAmountArgumentsException("Too few arguments supplied to run the application");

        } 
    }
#if DEBUG

        Console.WriteLine($"Total arguments are {args.Length}");

        Console.WriteLine($"Email domain is {domainName}");

        Console.WriteLine($"Total record items is {totalEmails}");

#endif
    } catch (InvalidArgumentException ex) {

        Console.WriteLine(ex.Message);

        writeErrorMessage();

    } catch (InvalidAmountArgumentsException ex) {

        Console.WriteLine(ex.Message);

        writeErrorMessage();

    }  
        
}

    private static void writeErrorMessage() {
        Console.WriteLine("Email Phishing Report Generator - Usage .\\EmailGenerator -c <total emails> -d <domain name>");
    }
    
}}
