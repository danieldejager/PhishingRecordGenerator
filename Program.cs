using System;
using System.IO;
using System.Text.RegularExpressions;
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
                    if(isValidDomain(args[3])) {
                            
                            domainName = args[3];

                    } else {

                        throw new InvalidDomainException("The domain name supplied is not valid");
                    }
                } 
                
                if(args[0] == "-d") {
                    if(isValidDomain(args[1])) {
                            
                            domainName = args[1];

                    } else {

                       throw new InvalidDomainException("The domain name supplied is not valid");         

                    }
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

    } catch (InvalidAmountArgumentsException ex) {

        Console.WriteLine(ex.Message);

    }  catch (InvalidDomainException ex) {

        Console.WriteLine(ex.Message);

    } finally {

        writeErrorMessage();

    }
        
}

    private static void writeErrorMessage() {
        Console.WriteLine("Email Phishing Report Generator - Usage .\\EmailGenerator -c <total emails> -d <domain name>");
    }

    private static bool isValidDomain(String domainName) {
        
        bool result = false;
        
        Regex regex = new Regex(@"^[a-zA-Z0-9][a-zA-Z0-9-_]{0,61}[a-zA-Z0-9]{0,1}\.([a-zA-Z]{1,6}|[a-zA-Z0-9-]{1,30}\.[a-zA-Z]{2,3})$"); 
                        
        result = regex.IsMatch(domainName);

        return result;

    }
    
}}