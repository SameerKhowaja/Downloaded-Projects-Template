import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class color extends JPanel implements ActionListener {

  private JButton yellowButton = new JButton("Yellow");

  private JButton blueButton = new JButton("Blue");

  private JButton redButton = new JButton("Red");

  public color() {
    add(yellowButton);
    add(blueButton);
    add(redButton);

    yellowButton.addActionListener(this);
    blueButton.addActionListener(this);
    redButton.addActionListener(this);
  }

  public void actionPerformed(ActionEvent evt) {
    Object source = evt.getSource();
    Color color = getBackground();
    if (source == yellowButton)
      color = Color.yellow;
    else if (source == blueButton)
      color = Color.blue;
    else if (source == redButton)
      color = Color.red;
    setBackground(color);
    repaint();
  }

  public static void main(String[] args) {
    JFrame frame = new JFrame("ButtonTest");
    frame.setSize(300, 200);
    frame.addWindowListener(new WindowAdapter() {
      public void windowClosing(WindowEvent e) {
        System.exit(0);
      }
    });

    Container contentPane = frame.getContentPane();
    contentPane.add(new color());

    frame.show();
  }
}
           
         