import javax.swing.*;

public class apples{
	public static void main(String[] args){
		
		JFrame f = new JFrame();
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		graphics go = new graphics();
		f.add(go);
		f.setSize(300,300);
		f.setTitle("Graphics in JAVA");
		f.setVisible(true);
	}
}