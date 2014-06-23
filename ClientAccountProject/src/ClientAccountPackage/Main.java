package ClientAccountPackage;


public class Main {

	/**
	 * @param args
	 * @throws Exception 
	 */
	public static void main(String[] args) throws Exception {
	    
		System.out.println("createTable() Invoked" + "\n");
		
		ClientAccount  bankAccount  = new ClientAccount();
		bankAccount.createTable();
		
/*_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________*/
		
		System.out.println("addClient() Invoked" + "\n");
		bankAccount.addClient("123-234-456", "Peter", "Smith", "Mandeville", "Debit", 785343.75);
		bankAccount.addClient("678-898-123", "Samantha", "Jones", "Kingston", "Credit", 561245.70);
		bankAccount.addClient("876-543-989", "Rebecca", "Lyn", "Montego Bay", "Credit", 907653.20);
		bankAccount.addClient("434-768-453", "Amanda", "Jackson", "Kingston", "Debit", 413543.80);
		bankAccount.addClient("976-788-234", "Jessica", "Campbell", "Mandeville", "Credit", 26120.50);
		
/*_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________*/
		
		System.out.println("getAllClients() Invoked" + "\n");
		
		ClientAccount[] ClientsArray = new ClientAccount[bankAccount.getAllClients().length];
		
		ClientsArray = bankAccount.getAllClients();
		for (int count = 0; count < bankAccount.getAllClients().length; count++)
		System.out.println("TRN #:" + ClientsArray[count].getTRN() + " First Name: " + ClientsArray[count].getFirstName()  + " Last Name: " + ClientsArray[count].getLastName()  + " Branch: " + ClientsArray[count].getBranch()  + " Account Type: " + ClientsArray[count].getAccountType() + " Current Balance: " + ClientsArray[count].getCurrentBalance() + "\n" );
		

/*__________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________*/
		System.out.println("getClient() Invoked" + "\n");
		
		ClientAccount[] ClientArray = new ClientAccount[1];
		ClientArray = bankAccount.getClient("678-898-123");
		System.out.println("TRN #:" + ClientArray[0].getTRN() + " First Name:" + ClientArray[0].getFirstName()  + " Last Name: " + ClientArray[0].getLastName()  + " Branch: " + ClientArray[0].getBranch()  + " Account Type: " + ClientArray[0].getAccountType() + " Current Balance: " + ClientArray[0].getCurrentBalance() + "\n" );
		
	    
/*_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________*/
		
		System.out.println("deleteClient() Invoked" + "\n");
		bankAccount.deleteClient("123-234-456");
	
	
	}
/*_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________*/
}
