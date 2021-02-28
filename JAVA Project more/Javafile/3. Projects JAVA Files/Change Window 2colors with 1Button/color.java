import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
  
public class color extends JFrame implements ActionListener
{
private JButton button;
private Color[] colors = new Color[] {Color.BLACK, Color.WHITE};
private int index;
private JLabel label;
  
public color(){
super("Window Color Change");

initialize();
}
  
private void initialize(){
index = 0;
 
label = new JLabel("Click on the button to change the window color: \n");
label.setForeground(Color.RED);
add(label);
 
button = new JButton("Click Me");
button.addActionListener(this);
setLayout(new FlowLayout());
add(button);
}
  
public void actionPerformed(ActionEvent e){
if(index < (colors.length - 1)){
index++;
}
else{
index = 0;
}
getContentPane().setBackground(colors[index]);
}
  
public static void main(String[] p){
color thisFrame = new color();
thisFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
thisFrame.setSize(350,350);
thisFrame.setVisible(true);
}
}