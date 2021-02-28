import javax.swing.JOptionPane;
import java.util.Random;

class table{
		
			public static void main(String args[]){
			int j=0;
			Random ra=new Random();
			
			
			int pick;
			
			
			
			for(int count=1; count<=10; count++){
			
			
			pick=ra.nextInt(7);
			
			if(pick==0){
			
			j=pick+1;
			
			
			}
			
			else if(pick==7){
			
			j=pick-1;
			
			
			}
			else {
			
			j=pick;
			
			
			}
			
			
			
			
			
			System.out.println(j);
			}
			
			
			}	
		



}