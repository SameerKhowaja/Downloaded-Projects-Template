public class tuna{
	private String first;
	private static int members = 0;
	
	public tuna(String fn){
		first = fn;
		members++;
		System.out.printf("Constructor for %s, member in th club: %d\n", first, members);
		
	}
}