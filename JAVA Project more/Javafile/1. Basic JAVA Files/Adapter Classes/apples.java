import javax.swing.JFrame;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class apples{
	public static void main(String[] args){
		
		Gui sam = new Gui();
		sam.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		sam.setSize(400, 290);
		sam.setVisible(true);
	}
}