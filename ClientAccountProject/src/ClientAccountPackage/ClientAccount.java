/*
 Student Name: Tajwane Campbell
 Student ID: 29085001 
 
 Student Name: Kevin K. Kennedy
 Student ID: 26100087
 
 Course: Advanced Application Development (CPTR465)
 Instructor: Mr. Damion R. Mitchell (Assistant Professor, M.Sc.)
 University: Northern Caribbean University
 Department: Computer and Information Sciences
 Programming Assignment #: 3
 Assignment Interoperability
 Due Date: Monday, June 9, 2014 
 
 */


package ClientAccountPackage;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;




public class ClientAccount {
	
	private String TRN;
	private String FirstName;
	private String LastName;
	private String Branch;
	private String AccountType;
	private double CurrentBalance;
	
	
	public String getTRN() {
		return TRN;
	}
	public void setTRN(String TRN) {
		this.TRN = TRN;
    	
	}
	public String getFirstName() {
		return FirstName;
	}
	public void setFirstName(String FirstName) {
    	this.FirstName = FirstName;
    
	}
	public String getLastName() {
		return LastName;
	}
	public void setLastName(String LastName) {
		this.LastName = LastName;	
	}
	
	
	public String getBranch() {
		return Branch;
	}
	public void setBranch(String Branch) {
		this.Branch = Branch;	
	}
	public String getAccountType() {
		return AccountType;
	}
	public void setAccountType(String AccountType) {
    	this.AccountType = AccountType;
    	
    	
	}
	public double getCurrentBalance() {
		return CurrentBalance;
	}
	public void setCurrentBalance(double CurrentBalance) {
		this.CurrentBalance = CurrentBalance;
	}


    public ClientAccount(){
    	
    	this.TRN = "";
    	this.FirstName = "";
    	this.LastName = "";
    	this.Branch = "";
    	this.AccountType = "";
    	this.CurrentBalance = 0.0;
    	
    }
    
    
    public ClientAccount(String TRN, String FirstName, String LastName, String Branch, String AccountType, double CurrentBalance ){
    	
    	this.TRN = TRN;
    	this.FirstName = FirstName;
    	this.LastName = LastName;
    	this.Branch = Branch;
    	this.AccountType = AccountType;
    	this.CurrentBalance = CurrentBalance;
    	
    	
    }
    
    
 /*--------------------------------------------------------------------------------------------------------------------------
    Method Name: getConnection
    Description: This method establishes and authenticates a connection to the MySQL database
    (Arguments) -> return type:  () -> Connection
    Precondition: MySQL database is open and working properly
    Postcondition: A established Connection to the specific MySQL database is returned
    Example (s): getConnection when invoked will return a Connection datatype consisting of the server, database name and authentication credentials

 ----------------------------------------------------------------------------------------------------------------------- */
    
public Connection getConnection() throws Exception{
		
		
		try{
			
			String driver = "com.mysql.jdbc.Driver";
			String URL = "jdbc:mysql://localhost:3306/database";
			String username = "root";
			String password = "";
			Class.forName(driver);
			
			Connection conn = DriverManager.getConnection(URL, username, password);
			return conn;
			
		}//end try
		
		catch (Exception e){
						
			System.out.println(e);
		}
		
		
		return null;
		
}//end getConnection

/*--------------------------------------------------------------------------------------------------------------------------
Method Name: createTable
Description: Creates a bankingTable if it does not exist with the required fields in the database.
(Arguments) -> return type:  () -> void
Precondition: A working database connection is established.
Postcondition: A bankingTable will be created within the database with the required fields.
Example (s): After the createTable() is invoked a table called bankingTable with the following fields: TRN , FirstName, LastName, 
Branch, AccountType, CurrentBalance, will be created
	

----------------------------------------------------------------------------------------------------------------------- */


public void createTable() throws Exception{
	
	try{
		
		Connection con = getConnection();
		PreparedStatement create = con.prepareStatement("CREATE TABLE IF NOT EXISTS BankingTable(TRN varchar(50) NOT NULL, FirstName varchar(50), LastName varchar(50), Branch varchar(50), AccountType varchar(50), CurrentBalance DOUBLE, PRIMARY KEY(TRN))");
		create.executeUpdate();
		
	} catch (Exception e){
		
		System.out.println(e);
		
	}
	
	finally{
		System.out.println("Table Creation Verified" + "\n");
	}
	
	
	
}// createTable()


/*--------------------------------------------------------------------------------------------------------------------------
Method Name: addClient
Description: This method inserts its accepted arguments into a MYSQL database
(Arguments) -> return type:  (String, String, String, String, String, double) -> void
Precondition: A database connection must be established with appropriate table created.
Postcondition: All the accepted argument will be inserted into the database
Example (s): addClient("434-221-455", "John", "Smith", "Mandeville", "Debit", 3000.0) all the arguments in the argument 
list will become a new record record in the bankingtable

----------------------------------------------------------------------------------------------------------------------- */


public void addClient(String TRN, String FirstName, String LastName, String Branch, String AccountType, double CurrentBalance )throws Exception{
	

	try{
		
		Connection con = getConnection();
		
		PreparedStatement addRecord = con.prepareStatement("INSERT INTO bankingtable(TRN, FirstName, LastName, Branch, AccountType, CurrentBalance)" + " VALUES (?,?,?,?,?,?)");
		addRecord.setString(1, TRN);
		addRecord.setString(2, FirstName);
		addRecord.setString(3, LastName);
		addRecord.setString(4, Branch);
		addRecord.setString(5, AccountType);
		addRecord.setDouble(6, CurrentBalance);
	
		addRecord.executeUpdate();
	}
	catch (Exception e){
		
		System.out.println(e);
	}
	
	finally{
		
		System.out.println("Insert Complete");
	}
	
	
}// end addClient()	

/*--------------------------------------------------------------------------------------------------------------------------
Method Name: deleteClient
Description: This method deletes a record from the bankingtable within the database base on an accepted string of the TRN
(Arguments) -> return type:  (String) -> void
Precondition:  A database connection must be established with appropriate table created and populated.
Postcondition: The record with the accepted TRN value will be erased from the database
Example (s): deleteClient("565-545-233"); The record 565-545-233 as the TRN will be deleted from the bankingtable
----------------------------------------------------------------------------------------------------------------------- */

public void deleteClient(String TRN) throws Exception{
	
	
	
	try{
		
		Connection con = getConnection();
		PreparedStatement deleteRecord = con.prepareStatement("DELETE FROM bankingtable WHERE TRN = ? ");
		deleteRecord.setString(1, TRN);
		deleteRecord.executeUpdate();
	}
	catch (Exception e){
		
		System.out.println(e);
	}
	
	finally{
		
		System.out.println("Delete Complete");
	}
	
	
}// end addClient()
	
	



/*--------------------------------------------------------------------------------------------------------------------------
Method Name: getAllClients
Description: This method returns an Class array of all the records in the database
(Arguments) -> return type:  () -> ClientAccount[]
Precondition: A database connection must be established with appropriate table created and populated.
Postcondition: A ClientAccount array will be returned with all the records in the database
Example (s): getAllClients() when invoked will return a ClientAccount array populated with all the records from the bankingtable

----------------------------------------------------------------------------------------------------------------------- */

public ClientAccount[] getAllClients() throws Exception{
	try{
		
		Connection conn = getConnection();
		
		
		Statement recordCount = conn.createStatement();
	
		
		ResultSet recordCountResult = recordCount.executeQuery("SELECT COUNT(*) AS RowCount FROM bankingTable");
		
		
		
		recordCountResult.next();
		int rowCount = recordCountResult.getInt("RowCount");
		recordCountResult.close();
		
	
		
		ClientAccount[] clientArray = new ClientAccount[rowCount];
		

	
		PreparedStatement statement = conn.prepareStatement("SELECT * FROM bankingtable");
		ResultSet allRecords =  statement.executeQuery();
		
		
		
		
		int count = 0;
		
		while(allRecords.next()){
			
			clientArray[count] = new ClientAccount();
			clientArray[count].setTRN(allRecords.getString("TRN"));
			clientArray[count].setFirstName(allRecords.getString("FirstName"));
			clientArray[count].setLastName(allRecords.getString("LastName"));
			clientArray[count].setBranch(allRecords.getString("Branch"));
			clientArray[count].setAccountType(allRecords.getString("AccountType"));
			clientArray[count].setCurrentBalance(allRecords.getDouble("CurrentBalance") );
			

			count++;
		   
		}
	
		
		return clientArray;
		
	}catch (Exception e){
		
		System.out.println(e);
	}
	return null;
	
		
}//end

/*--------------------------------------------------------------------------------------------------------------------------
Method Name: getClient
Description: This method returns a Class array of a record in the database, base on the accepted String argument of the method
(Arguments) -> return type:  (String) -> ClientAccount[]
Precondition: A database connection must be established with appropriate table created and populated.
Postcondition: A ClientAccount array will be returned with a record in the database, base on the accepted String argument of the method
Example (s): getClient("787-435-323") when invoked will return a ClientAccount array populated with a record from the bankingtable that 
has 787-435-323 as its TRN field.

----------------------------------------------------------------------------------------------------------------------- */


public ClientAccount[] getClient(String TRN) throws Exception{
	try{
		
		Connection conn = getConnection();
		
	
		PreparedStatement searchRecord = conn.prepareStatement("SELECT * FROM bankingtable WHERE TRN = ?");
		searchRecord.setString(1, TRN);
		ResultSet singleRecord =  searchRecord.executeQuery();
		
		
		ClientAccount[] clientArray = new ClientAccount[1];
		
		  while(singleRecord.next()){
			
			clientArray[0] = new ClientAccount();
			clientArray[0].setTRN(singleRecord.getString("TRN"));
			clientArray[0].setFirstName(singleRecord.getString("FirstName"));
			clientArray[0].setLastName(singleRecord.getString("LastName"));
			clientArray[0].setBranch(singleRecord.getString("Branch"));
			clientArray[0].setAccountType(singleRecord.getString("AccountType"));
			clientArray[0].setCurrentBalance(singleRecord.getDouble("CurrentBalance"));
		   
		}
		
		
		System.out.println("All records have been selected");
		return clientArray;
		
	}catch (Exception e){
		
		System.out.println(e);
	}
	return null;
	
		
}//end

		

}// end ClientAccount
