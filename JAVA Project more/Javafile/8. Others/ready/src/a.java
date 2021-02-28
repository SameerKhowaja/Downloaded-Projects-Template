import java.util.*;
class a
{

a()
{

Random ra=new Random();

	int pick=1+ra.nextInt(3);
	
	if(pick==1)
	{
	met();
	}
	
	else if(pick==2)
	{
	met1();
	}
	
	else if(pick==3)
	{
	met2();
	}

}
	
	
	
public void met()
{

System.out.println("Shadab");



}	

public void met1()
{

System.out.println("alui");



}	

public void met2()
{


System.out.println("sssss");


}	

public static void main(String args[])
{
	a tb=new a();

	
}
}