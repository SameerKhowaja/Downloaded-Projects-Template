import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Gui extends JFrame{
    
    private JComboBox box;
    private JLabel picture;
    
    private static String[] filename = {"s.png", "a.png", "m.png", "e1.png", "e2.png", "r.png"};
    private Icon[] pics = {new ImageIcon(getClass().getResource(filename[0])), 
                            new ImageIcon(getClass().getResource(filename[1])), 
                                new ImageIcon(getClass().getResource(filename[2])), 
                                    new ImageIcon(getClass().getResource(filename[3])), 
                                        new ImageIcon(getClass().getResource(filename[4])), 
                                            new ImageIcon(getClass().getResource(filename[5]))};
    public Gui(){
        super("JComboBox");
        setLayout(new FlowLayout());
        
        box = new JComboBox(filename);
        
        box.addItemListener(
            new ItemListener(){
                public void itemStateChanged(ItemEvent event){
                    if(event.getStateChange()==ItemEvent.SELECTED)
                        picture.setIcon(pics[box.getSelectedIndex()]);
                     
                }
            }
            
        );
        add(box);
            picture = new JLabel(pics[0]);
            add(picture);
    }
}
