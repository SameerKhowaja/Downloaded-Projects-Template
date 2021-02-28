import javax.swing.JOptionPane;
class a{

public static void main(String args[]){


Thread thread1 = new Thread () {
  public void run () {
    
	
	for(int a=1; a<=10; a++){
	
	try{
	
	System.out.println("Thread 1 Start");
	
	
	Thread.sleep(7000);
	
	
	if(a==10){
	
	JOptionPane.showMessageDialog(null,"One Complete");
	
	
	}
	
	}catch(Exception e){}
	
	
	}
	
	
	
  }
};
Thread thread2 = new Thread () {
  public void run () {
    for(int a=1; a<=10; a++){
	
	try{
	
	System.out.println("Thread 2 Start");
	
	
	Thread.sleep(4000);
	
	if(a==10){
	
	JOptionPane.showMessageDialog(null,"Two Complete");
	
	
	}
	}catch(Exception e){}
	
	
	}
  }
};


Thread thread3 = new Thread () {
  public void run () {
    for(int a=1; a<=10; a++){
	
	try{
	
	System.out.println("Thread 3 Start");
	
	
	Thread.sleep(1000);
	if(a==10){
	
	JOptionPane.showMessageDialog(null,"Three Complete");
	
	
	}
	}catch(Exception e){}
	
	
	}
  }
};

thread1.start();
thread2.start();
thread3.start();
}
}