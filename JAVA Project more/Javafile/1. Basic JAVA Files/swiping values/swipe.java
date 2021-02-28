public class swipe{
	public static void main(String[] args){
		int a = 4;
		int b = 8;
		int c;
		
		//Transfering value of "a" to "b" & value of "b" to "a", using variable "c".
		
		c = a;
		
		a = b;		//a = 8
		System.out.println("A = " + a);
		
		b = c;		//b = 4
		System.out.println("B = " + b);
	}
}