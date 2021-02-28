
class apples{
	public static void main(String[] args){
		
		createfile c = new createfile();
		c.openFile();
		c.addRecords();
		c.closeFile();
	}
}