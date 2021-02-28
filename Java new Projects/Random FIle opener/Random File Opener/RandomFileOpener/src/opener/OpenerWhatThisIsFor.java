package opener;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Toolkit;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JPanel;
import javax.swing.UIManager;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

@SuppressWarnings("serial")
public class OpenerWhatThisIsFor extends JDialog {

	private final JPanel contentPanel = new JPanel();

	/**
	 * Launch the application.
	 */
	//public static void main(String[] args) {
		//try {
			//OpenerWhatThisIsFor dialog = new OpenerWhatThisIsFor();
			//dialog.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
			//dialog.setVisible(true);
		//} catch (Exception e) {
			//e.printStackTrace();
		//}
	//}

	/**
	 * Create the dialog.
	 */
	public OpenerWhatThisIsFor() {
		setTitle("What's this for you say?");
		setModalityType(ModalityType.APPLICATION_MODAL);
		
		try{
			UIManager.setLookAndFeel("javax.swing.plaf.nimbus.NimbusLookAndFeel");
		}catch(Exception e){
			e.printStackTrace();
		}
		
		setBounds(100, 100, 516, 224);
		getContentPane().setLayout(new BorderLayout());
		contentPanel.setBorder(new EmptyBorder(5, 5, 5, 5));
		getContentPane().add(contentPanel, BorderLayout.CENTER);
		contentPanel.setLayout(new BorderLayout(0, 0));
		{
			JPanel panel = new JPanel();
			contentPanel.add(panel, BorderLayout.CENTER);
			panel.setLayout(null);
			
			JLabel lblWell = new JLabel("Well, this program is exactly what its name suggests.");
			lblWell.setHorizontalAlignment(SwingConstants.CENTER);
			lblWell.setBounds(6, 6, 478, 16);
			panel.add(lblWell);
			
			JLabel lblNewLabel = new JLabel("just browse for a directory and run it");
			lblNewLabel.setHorizontalAlignment(SwingConstants.CENTER);
			lblNewLabel.setBounds(6, 34, 478, 16);
			panel.add(lblNewLabel);
			
			JLabel lblNewLabel_1 = new JLabel("its gonna select a random file from the directory and open it for you");
			lblNewLabel_1.setHorizontalAlignment(SwingConstants.CENTER);
			lblNewLabel_1.setBounds(6, 62, 478, 16);
			panel.add(lblNewLabel_1);
			
			JLabel lblThisWorksIf = new JLabel("this works if you have a folder full of movies and ");
			lblThisWorksIf.setHorizontalAlignment(SwingConstants.CENTER);
			lblThisWorksIf.setBounds(6, 90, 478, 16);
			panel.add(lblThisWorksIf);
			
			JLabel lblYouDontKnow = new JLabel("you don't know which one to watch and etc...");
			lblYouDontKnow.setHorizontalAlignment(SwingConstants.CENTER);
			lblYouDontKnow.setBounds(6, 118, 478, 16);
			panel.add(lblYouDontKnow);
		}
		{
			JPanel buttonPane = new JPanel();
			buttonPane.setLayout(new FlowLayout(FlowLayout.RIGHT));
			getContentPane().add(buttonPane, BorderLayout.SOUTH);
			{
				JButton okButton = new JButton("OK");
				okButton.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						setVisible(false);
					}
				});
				okButton.setActionCommand("OK");
				buttonPane.add(okButton);
				getRootPane().setDefaultButton(okButton);
			}
		}
		
		
		Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
		int x = (int) ((dim.getWidth() - this.getWidth()) / 2);
		int y = (int) ((dim.getHeight() - this.getHeight()) / 2);
		this.setLocation(x, y);
	}
}
