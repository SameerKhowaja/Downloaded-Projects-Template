import java.util.Scanner;

class RayyanFibonacci{

	public static void main(String[] args){
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		
		
		
			try{
				//Takes in number of Fibonaccis
				System.out.println("Enter number of Fibonaccis to be printed");
				int n = s.nextInt();
				fibonacci(n);
				System.out.println(".");
				System.out.println(".");
				System.out.println(".");
				System.out.println("Created By Rayyan");
				
			}
			catch(Exception e){
				System.out.println("ERROR");
			}
		
	}
	
	public static void fibonacci(int n){
		if (n == 0){
			System.out.println("0");
		}
		if (n == 1){
			System.out.println("0");
			System.out.println("1");
		}
		else{
			System.out.println("0");
			System.out.println("1");
			
			int a = 0;
			int b = 1;
			for(int i =1;i<n;i++){
				int c = a + b;
				System.out.println(c + " ");
				
				a = b;
				b = c;
			}
		}
	}

}
