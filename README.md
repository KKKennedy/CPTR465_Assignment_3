CPTR465_Assignment_3
====================
Northern Caribbean University
Department of Computer & Information Sciences
CPTR465-Advanced Application Development
Assignment #3 (30pts / 10%)
Due Date: June 8, 2014 by 11:59PM (DEMO AT START OF CLASS on June 9)

Instruction: Write the program for the problem below. This assignment must be submitted via http://lms.ncu.edu.jm and also presented in class.

Prerequisites (The students will need to have access to):
1.	JNBrigderPro Trial Version: http://www.jnbridge.com/bin/downloads.php?pr=1&id=0
2.	Visual Studio 2010/2012 (.NET)
3.	Eclipse or Net Beans (.J2EE)

Additional Readings:
•	http://www.jnbridge.com/BooksDemo.pdf
•	http://msdn.microsoft.com/en-us/library/ff650279.aspx

Interoperability
You are charged with the responsibility to develop a banking system for Mitchell’s Commercial Bank, using the power of interoperability. You have been told to use the bridge (JNBrigdePro toolkit) technique to connect the .NET and .J2EE frameworks. That is, you will be using the JNBridgePro to construct a .NET windows application that calls JAVA classes. 

The presentation tier of your application must be built using either C#.NET or VB.NET, while the business logic tier must be implemented using JAVA. It is recommended that you use either MYSQL or SQLSERVER to persist the data.

The following class should be implemented using JAVA:

CLIENT CLASS:
	Attributes:
TRN#
FirstName
		LastName
		Branch
		Account Type (Savings or Credit) *Allowed only one account
		Current Balance
	Behaviors:
		**returns all the details for the client with the given TRN# stored in the database
getClients(string)

**returns all the clients currently enrolled at the bank stored in the database
		getAllClients()

**Adds a new client to the database
		addClient(string, string, string, string)
		
**deletes a given client from the database based on the TRN#
deleteClient(string)


Using either C#.NET or VB.NET, create the following tabbed form:



N.B.: Please use detailed comments as a documentation methodology to clearly explain each section of your code. Each function should have the following function description:

Description              		== e.g.: Function to count the number of vowels in a given string
(Arguments)  return type 	== e.g.: (string, int)  int
Precondition                        	== e.g.: String must not be NULL or Empty
Postcondition			== e.g.: The number of vowels contained in the given string is returned
Example (s)			== e.g.: string x = “Hello”; Function(x) = 2


Rubric
Correct Implementation of Client Class				10pts
Tabbed GUI Implementation						3pts
Generated .NET proxies that called the Java classes			3pts
Created .NET code that called the proxies				6pts
Comments								3pts
Demonstration							5pts
Total										30pts
