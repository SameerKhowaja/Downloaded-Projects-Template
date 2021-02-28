import java.util.Scanner;

public class Program
{
	
	/* PLEASE READ THIS BEFORE TESTING AND CLASSIFYING
	 * 
	 * Do not run in SoloLearn's Code Playground. Compile and run it with java/javac.
	 * Try all commands. They are very fun. 
	 * You can also enter as root typing 'su' or 'sudo -s'
	 * If you are root your directory is '/', otherwise it is '/home/SoloLearn'
	 * 
	 * Distributed under GPLv3 Open Source License.
	 * 
	 */
	
	
	
    public static boolean root = false;
    public static Scanner s;
	public static void main(String[] args) {
	    
	    
	    System.out.println("Mini-Linux Simulation // BASH\n\nWelcome to the Fake Linux (made in Java by Rocco T - RoccoDeveloping)\nType 'help' to see a list of available commands");
	    
	    System.out.print("\n\nSoloLearn@sololearn.com:~$ ");
	 loopCmd();
	    
	    return;
	    
		
	}
	
	
	private static void loopCmd(){
	    s = new Scanner(System.in);
	    
	    if(s.hasNext()){
	    checkCmd(s.next());
	    }
	}
	
	
	public static void checkCmd(String cmd){
	    if(cmd.equalsIgnoreCase("su") || cmd.equalsIgnoreCase("sudo -s")){
	        
	     System.out.print("\nroot@sololearn.com:~# ");
	     root = true;
	     loopCmd();
	        
	    }
	    else if (cmd.equalsIgnoreCase("exit")){
	        System.exit(0);
	    }
	    else if(cmd.equalsIgnoreCase("pwd")){
			if(root){
				
	        System.out.println("\n/");
		}
		else{
			 System.out.println("\n/home/SoloLearn");
	    }
	}
	    else if(cmd.equalsIgnoreCase("help")){
			
			System.out.println("Available commands:\nhelp -- shows this message\nsu -- enters as root\nexit -- exits the program\npwd -- prints actual directory\n\n(C) 2016 - Rocco T");
		}
	    else{
			
			System.out.println(cmd + ": command not found [ERROR] -- Type 'help' to see a list of available commands");
		}
	    if(root){
			System.out.print("\nroot@sololearn.com:~# " );
		}
		else{
			System.out.print("\nSoloLearn@sololearn.com:~$ ");
		}
	    loopCmd();
	}
}
