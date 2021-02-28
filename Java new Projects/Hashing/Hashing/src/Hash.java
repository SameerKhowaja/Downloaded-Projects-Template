/*
 * Hashing & Salting using MD5 and SHA-1
 * 
 * Developed by Ny Aina Erick RANDRIANJAFY
 * (c) 06/04/2015
 * Java SE
 * 
 * e-mail : ainaerik@gmail.com
 * 
 */



import java.math.BigInteger;
import java.security.MessageDigest;


public class Hash {
 
	public static String md5(String input) {
		String md5 = null;
		
		if(input==null)
			return null;
		
		try {
			MessageDigest digest = MessageDigest.getInstance("MD5");
			digest.update(input.getBytes(), 0, input.length() );
			md5 = new BigInteger(1, digest.digest()).toString(16);
		}
		catch(Exception e){
			e.printStackTrace();
		}
		return md5;
	}
	
	public static String sha1(String input){
		String sha = null;
		
		if( input==null )
			return null;
		
		try {
			MessageDigest dig = MessageDigest.getInstance("SHA1");
			dig.update(input.getBytes(), 0, input.length());
			sha = new BigInteger(1,dig.digest()).toString();
		}catch(Exception e){
			e.printStackTrace();
		}
		return sha;
		
	}
	

}
