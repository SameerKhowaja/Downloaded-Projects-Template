import java.net.*;
public class ad
{
	public static void main(String []args)
	{
		try{
		InetAddress a=InetAddress.getLocalHost();
		System.out.println("ip address "+a.getHostAddress());
	}
	
	catch(Exception w)
	{
		System.out.println(e);
	}
	}
}