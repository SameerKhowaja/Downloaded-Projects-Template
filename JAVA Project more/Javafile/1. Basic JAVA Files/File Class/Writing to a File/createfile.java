import java.util.*;
import java.lang.*;
import java.io.*;

class createfile{
	
	private Formatter x;
		
	public void openFile(){
		try{
			x = new Formatter("sam.txt");
			System.out.println("You created a file");
		}
		catch(Exception e){
			System.out.println("You got an Error");
		}
	}
	
	public void addRecords(){
		x.format("%s%s%s", "20 ", "Sameer ", "Khowaja");
	}
	
	public void closeFile(){
		x.close();
	}
	
}