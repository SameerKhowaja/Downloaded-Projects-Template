import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class PeriodicTable extends JFrame implements MouseListener{
    
    JTextField first;
    JLabel L1,L2,L3,L4;
    JButton b1,b2,b3,b4,b5,b6;
    JFrame frm;
    JFrame frm2;
    
    PeriodicTable(){
    	
    	int style=1;
    	int style2=8;
    	
        frm=new JFrame();
        frm.setBounds(20, 20, 500, 500);
        frm.setDefaultCloseOperation(3);
        frm.setLayout(null);
        frm.setTitle("Periodic Table Program");
        frm.getContentPane().setBackground(Color.BLACK);
        
        //bg
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("bg.jpg")));
     
        pan.add(jlb);

        frm.setContentPane(jlb);
        frm.setResizable(false);
        frm.pack();
        frm.setVisible(true);
        
        
        //assigning
        L1=new JLabel("Element Name/Symbol : ");
        L1.setBounds(100,25,2000,20);
        L1.setFont(new Font("Gill Sans", style, 21));
        frm.add(L1);
        
        first=new JTextField();
        first.setBounds(120,55,260,40);
        first.setFont(new Font("Gill Sans", style2, 20));
        frm.add(first);
        
        b1=new JButton("Data of Element");
        b1.setBounds(120,125,270,50);
        b1.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b1);
        
        b2=new JButton("Clear");
        b2.setBounds(120,305,130,50);
        b2.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b2);

        b3=new JButton("About");
        b3.setBounds(260,305,130,50);
        b3.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b3);

        b4=new JButton("Exit");
        b4.setBounds(120,365,270,50);
        b4.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b4);
        
        b5=new JButton("History & Uses");
        b5.setBounds(120,185,270,50);
        b5.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b5);
        
        b6=new JButton("Periodic Table");
        b6.setBounds(120,245,270,50);
        b6.setFont(new Font("Gill Sans", style2, 20));
        frm.add(b6);
        
        frm.setVisible(true);
            b1.addMouseListener(this);
            b2.addMouseListener(this);
            b3.addMouseListener(this);
            b4.addMouseListener(this);
            b5.addMouseListener(this);
            b6.addMouseListener(this);
         
        first.setBackground(Color.GREEN);
        L1.setForeground(Color.WHITE);
        b1.setBackground(Color.YELLOW);
        b2.setBackground(Color.YELLOW);
        b3.setBackground(Color.YELLOW);
        b4.setBackground(Color.YELLOW);
        b5.setBackground(Color.YELLOW);
        b6.setBackground(Color.YELLOW);
        
    }
    
    //Not in Use
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        
        //Information of Element Button
        if(ob==b1){
        	
            //Hydrogen   1
            if(first.getText().equals("H") || first.getText().equals("hydrogen") || first.getText().equals("Hydrogen")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek words hydro and genes, which \n"
                    +"                                     together mean \"water forming.\" \n" 
                    +"Say what?  Hydrogen is pronounced as HI-dreh-jen. \n"
                            
                    +"\n Classification:                   Hydrogen is a nonmetal. It can become \n"
                    +"                                               metallic at very high pressures. "
                    +"\n Atomic Number:                1 " 
                    +"\n Atomic Weight:                  1.00798 " 
                    +"\n Melting Point:                     13.81 K (-259.34°C or -434.81°F) " 
                    +"\n Boiling Point:                      20.28 K (-252.87°C or -423.17°F) " 
                    +"\n Density:                               0.0000899 g/cm3 " 
                    +"\n State:                                   Gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 1     "
                    +"\n Group Number:                  1    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             13.598 eV" 
                    +"\n Oxidation States:             +1, -1"
                    +"\n Electrons:                           1 "
                    +"\n Protons:                              1 "
                    +"\n Electron shells:                 1 "
                    +"\n Electron configuration:    1s1"
                        , "Hydrogen", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Helium   2
            if(first.getText().equals("He") || first.getText().equals("helium") || first.getText().equals("Helium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  For the Greek god of the sun, Helios. \n" 
                    +"Say what?  Helium is pronounced as HEE-lee-em. \n"
                            
                    +"\n Classification:                   Helium is a noble gas and a nonmetal "
                    +"\n Atomic Number:                2 " 
                    +"\n Atomic Weight:                  4.002602 " 
                    +"\n Melting Point:                     0.95 K (-272.2°C or -458.0°F) " 
                    +"\n Boiling Point:                      4.22 K (-268.93°C or -452.07°F) " 
                    +"\n Density:                               0.0001785 g/cm3 " 
                    +"\n State:                                   Gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 1     "
                    +"\n Group Number:                  18    "
                    +"\n Group Name:                      Noble Gas "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             24.587 eV" 
                    +"\n Oxidation States:             0"
                    +"\n Electrons:                           2 "
                    +"\n Protons:                              2 "
                    +"\n Electron shells:                 2 "
                    +"\n Electron configuration:    1s2"
                        , "Helium", JOptionPane.INFORMATION_MESSAGE);
        	}

            //Lithium   3
            if(first.getText().equals("Li") || first.getText().equals("lithium") || first.getText().equals("Lithium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for stone, lithos. \n" 
                    +"Say what?  Lithium is pronounced as LITH-ee-em. \n"
                            
                    +"\n Classification:                   Lithium is an alkali metal "
                    +"\n Atomic Number:                3 " 
                    +"\n Atomic Weight:                  6.968 " 
                    +"\n Melting Point:                     453.65 K (180.50°C or 356.90°F) " 
                    +"\n Boiling Point:                      1615 K (1342°C or 2448°F) " 
                    +"\n Density:                               0.534 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  1    "
                    +"\n Group Name:                      Alkali Metal "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             5.392 eV" 
                    +"\n Oxidation States:             +1"
                    +"\n Electrons:                           3 "
                    +"\n Protons:                              3 "
                    +"\n Electron shells:                 4 "
                    +"\n Electron configuration:    1s2 2s1"
                        , "Lithium", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Beryllium     4
            if(first.getText().equals("Be") || first.getText().equals("beryllium") || first.getText().equals("Beryllium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word beryl, a type of mineral. \n" 
                    +"Say what?  Beryllium is pronounced as beh-RIL-ee-em. \n"
                            
                    +"\n Classification:                   Beryllium is an alkali earth metal "
                    +"\n Atomic Number:                4 " 
                    +"\n Atomic Weight:                  9.0121831 " 
                    +"\n Melting Point:                     1560 K (1287°C or 2349°F) " 
                    +"\n Boiling Point:                      2744 K (2471°C or 4480°F) " 
                    +"\n Density:                               1.85 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   steel gray " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  2    "
                    +"\n Group Name:                      Alkaline Earth Metal "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             9.323 eV " 
                    +"\n Oxidation States:             +2"
                    +"\n Electrons:                           4 "
                    +"\n Protons:                              4 "
                    +"\n Electron shells:                 2,2 "
                    +"\n Electron configuration:    1s2 2s2"
                        , "Beryllium", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Boron     5
            if(first.getText().equals("B") || first.getText().equals("boron") || first.getText().equals("Boron")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Arabic word Buraq and the \n"
                    +"                                     Persian word Burah, which are both \n"
                    +"                                     words for the material \"borax.\" \n" 
                    +"Say what?  Boron is pronounced as BO-ron. \n"
                            
                    +"\n Classification:                   Boron is a metalloid "
                    +"\n Atomic Number:                5 " 
                    +"\n Atomic Weight:                  10.81 " 
                    +"\n Melting Point:                     2348 K (2075°C or 3767°F) " 
                    +"\n Boiling Point:                      4273 K (4000°C or 7232°F) " 
                    +"\n Density:                               2.37 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   black " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  13    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             8.298 eV " 
                    +"\n Oxidation States:             +3 "
                    +"\n Electrons:                           5 "
                    +"\n Protons:                              5 "
                    +"\n Electron shells:                 2,3 "
                    +"\n Electron configuration:    1s2 2s2 2p1"
                        , "Boron", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Carbon       6
            if(first.getText().equals("C") || first.getText().equals("carbon") || first.getText().equals("Carbon")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin word for charcoal, carbo. \n" 
                    +"Say what?  Carbon is pronounced as KAR-ben. \n"
                            
                    +"\n Classification:                   Carbon is a nonmetal "
                    +"\n Atomic Number:                6 " 
                    +"\n Atomic Weight:                  12.011 " 
                    +"\n Melting Point:                     3823 K (3550°C or 6422°F) " 
                    +"\n Boiling Point:                      4098 K (3825°C or 6917°F) " 
                    +"\n Density:                               2.2670 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   black (graphite), transparent (diamond) " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  14    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             11.260 eV " 
                    +"\n Oxidation States:             +4, +2, -4 "
                    +"\n Electrons:                           6 "
                    +"\n Protons:                              6 "
                    +"\n Electron shells:                 2,4 "
                    +"\n Electron configuration:    1s2 2s2 2p2"
                        , "Carbon", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Nitrogen       7
            if(first.getText().equals("N") || first.getText().equals("nitrogen") || first.getText().equals("Nitrogen")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek words nitron and genes, \n"
                             + "                                     which together mean \"saltpetre forming.\" \n" 
                    +"Say what?  Nitrogen is pronounced as NYE-treh-gen. \n"
                            
                    +"\n Classification:                   Nitrogen is a gas and a nonmetal "
                    +"\n Atomic Number:                7 " 
                    +"\n Atomic Weight:                  14.0067 " 
                    +"\n Melting Point:                     63.15 K (-210.00°C or -346.00°F) " 
                    +"\n Boiling Point:                      77.36 K (-195.79°C or -320.44°F) " 
                    +"\n Density:                               0.0012506 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  15    "
                    +"\n Group Name:                      Pnictogen "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             14.534 eV " 
                    +"\n Oxidation States:             +5, +4, +3, +2, +1, -1, -2, -3 "
                    +"\n Electrons:                           7 "
                    +"\n Protons:                              7 "
                    +"\n Electron shells:                 2,5 "
                    +"\n Electron configuration:    1s2 2s2 2p3 "
                        , "Nitrogen", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Oxygen       8
            if(first.getText().equals("O") || first.getText().equals("oxygen") || first.getText().equals("Oxygen")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the greek words oxys and genes, \n"
                             + "                                     which together mean \"acid forming..\" \n" 
                    +"Say what?  Oxygen is pronounced as OK-si-jen. \n"
                            
                    +"\n Classification:                   Oxygen is a chalcogen and a nonmetal "
                    +"\n Atomic Number:                8 " 
                    +"\n Atomic Weight:                  15.9994 " 
                    +"\n Melting Point:                     54.36 K (-218.79°C or -361.82°F) " 
                    +"\n Boiling Point:                      90.20 K (-182.95°C or -297.31°F) " 
                    +"\n Density:                               0.001429 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  16    "
                    +"\n Group Name:                      Chalcogen "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             13.618 eV " 
                    +"\n Oxidation States:             -2 "
                    +"\n Electrons:                           8 "
                    +"\n Protons:                              8 "
                    +"\n Electron shells:                 2,6 "
                    +"\n Electron configuration:    1s2 2s2 2p4 "
                        , "Oxygen", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Fluorine       9
            if(first.getText().equals("F") || first.getText().equals("fluorine") || first.getText().equals("Fluorine")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin and French words for flow, fluere. \n" 
                    +"Say what?  Fluorine is pronounced as FLU-eh-reen or as FLU-eh-rin. \n"
                            
                    +"\n Classification:                   Fluorine is a halogen and a nonmetal "
                    +"\n Atomic Number:                9 " 
                    +"\n Atomic Weight:                  18.998403 " 
                    +"\n Melting Point:                     53.53 K (-219.62°C or -363.32°F) " 
                    +"\n Boiling Point:                      85.03 K (-188.12°C or -306.62°F) " 
                    +"\n Density:                               0.001696 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   pale yellow " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  17    "
                    +"\n Group Name:                      Halogen "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             17.423 eV " 
                    +"\n Oxidation States:             -1 "
                    +"\n Electrons:                           9 "
                    +"\n Protons:                              9 "
                    +"\n Electron shells:                 2,7 "
                    +"\n Electron configuration:    1s2 2s2 2p5 "
                        , "Fluorine", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Neon       10
            if(first.getText().equals("Ne") || first.getText().equals("neon") || first.getText().equals("Neon")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for new, neos. \n" 
                    +"Say what?  Neon is pronounced as NEE-on. \n"
                            
                    +"\n Classification:                   Neon is a noble gas and a nonmetal "
                    +"\n Atomic Number:                10 " 
                    +"\n Atomic Weight:                  20.1797 " 
                    +"\n Melting Point:                     24.56 K (-248.59°C or -415.46°F) " 
                    +"\n Boiling Point:                      27.07 K (-246.08°C or -410.94°F) " 
                    +"\n Density:                               0.0008999 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 2     "
                    +"\n Group Number:                  18    "
                    +"\n Group Name:                      Noble Gas "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             21.565 eV " 
                    +"\n Oxidation States:             0 "
                    +"\n Electrons:                           10 "
                    +"\n Protons:                              10 "
                    +"\n Electron shells:                 2,8 "
                    +"\n Electron configuration:    1s2 2s2 2p6 "
                        , "Neon", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            //Sodium       11
            if(first.getText().equals("Na") || first.getText().equals("sodium") || first.getText().equals("Sodium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the English word soda and from \n"
                    +"                                     the Medieval Latin word sodanum, \n"
                    +"                                     which means 'headache remedy.' \n"
                    +"                                     Sodium's chemical symbol comes \n"
                    +"                                     from the Latin word for sodium \n"
                    +"                                     carbonate, natrium. \n" 
                    +"Say what?  Sodium is pronounced as SO-dee-em. \n"
                            
                    +"\n Classification:                   Sodium is an alkali metal "
                    +"\n Atomic Number:                11 " 
                    +"\n Atomic Weight:                  22.98977 " 
                    +"\n Melting Point:                     370.95 K (97.80°C or 208.04°F) " 
                    +"\n Boiling Point:                      1156 K (883°C or 1621°F) " 
                    +"\n Density:                               0.97 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-white " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  1    "
                    +"\n Group Name:                      Alkali Metal "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             5.139 eV " 
                    +"\n Oxidation States:             +1 "
                    +"\n Electrons:                           11 "
                    +"\n Protons:                              11 "
                    +"\n Electron shells:                 2,8,1 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s1 "
                        , "Sodium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Magnesium       12
            if(first.getText().equals("Mg") || first.getText().equals("magnesium") || first.getText().equals("Magnesium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  For Magnesia, a district in the region \n"
                             + "                                     of Thessaly, Greece. \n"
                    +"Say what?  Magnesium is pronounced as mag-NEE-zhi-em. \n"
                            
                    +"\n Classification:                   Magnesium is an alkali earth metal "
                    +"\n Atomic Number:                12 " 
                    +"\n Atomic Weight:                  24.306 " 
                    +"\n Melting Point:                     923 K (650°C or 1202°F) " 
                    +"\n Boiling Point:                      1363 K (1090°C or 1994°F) " 
                    +"\n Density:                               1.74 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-white " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  2    "
                    +"\n Group Name:                      Alkaline Earth Metal "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             7.646 eV " 
                    +"\n Oxidation States:             +2 "
                    +"\n Electrons:                           12 "
                    +"\n Protons:                              12 "
                    +"\n Electron shells:                 2,8,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 "
                        , "Magnesium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Aluminum       13
            if(first.getText().equals("Al") || first.getText().equals("aluminum") || first.getText().equals("Aluminum")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin word for alum, alumen. \n"
                    +"Say what?  Aluminum is pronounced as ah-LOO-men-em. \n"
                            
                    +"\n Classification:                   Aluminum is an ‘other metal’ "
                    +"\n Atomic Number:                13 " 
                    +"\n Atomic Weight:                  26.98154 " 
                    +"\n Melting Point:                     933.437 K (660.323°C or 1220.581°F) " 
                    +"\n Boiling Point:                      2792 K (2519°C or 4566°F) " 
                    +"\n Density:                               2.702 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  13    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             5.986 eV " 
                    +"\n Oxidation States:             +3 "
                    +"\n Electrons:                           13 "
                    +"\n Protons:                              13 "
                    +"\n Electron shells:                 2,8,3 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p1 "
                        , "Aluminum", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
            //Silicon	  14
            if(first.getText().equals("Si") || first.getText().equals("silicon") || first.getText().equals("Silicon")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin word for flint, silex. \n"
                    +"Say what?  Silicon is pronounced as SIL-ee-ken. \n"
                            
                    +"\n Classification:                   Silicon is a metalloid "
                    +"\n Atomic Number:                14 " 
                    +"\n Atomic Weight:                  28.085 " 
                    +"\n Melting Point:                     1687 K (1414°C or 2577°F) " 
                    +"\n Boiling Point:                      3538 K (3265°C or 5909°F) " 
                    +"\n Density:                               2.3296 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  14    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             8.15 eV " 
                    +"\n Oxidation States:             +4, +2, -4 "
                    +"\n Electrons:                           14 "
                    +"\n Protons:                              14 "
                    +"\n Electron shells:                 2,8,4 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p2 "
                        , "Silicon", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
            //Phosphorus	15
            if(first.getText().equals("P") || first.getText().equals("phosphorus") || first.getText().equals("Phosphorus")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for light bearing, phosphoros. \n"
                    +"Say what?  Phosphorus is pronounced as FOS-fer-es. \n"
                            
                    +"\n Classification:                   Phosphorus is a nonmetal "
                    +"\n Atomic Number:                15 " 
                    +"\n Atomic Weight:                  30.973761998 " 
                    +"\n Melting Point:                     317.30 K (44.15°C or 111.47°F) " 
                    +"\n Boiling Point:                      553.65 K (280.5°C or 536.9°F) " 
                    +"\n Density:                               1.82 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   White phosphorus is usually pale yellow " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  15    "
                    +"\n Group Name:                      Pnictogen "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             10.487 eV " 
                    +"\n Oxidation States:             +5, +3, -3 "
                    +"\n Electrons:                           15 "
                    +"\n Protons:                              15 "
                    +"\n Electron shells:                 2,8,5 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p3 "
                        , "Phosphorus", JOptionPane.INFORMATION_MESSAGE);
        	}
            
            
            //Sulfur	16
            if(first.getText().equals("S") || first.getText().equals("sulfur") || first.getText().equals("Sulfur")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Sanskrit word sulvere and \n"
                             + "                                     the Latin word sulphurium. \n"
                    +"Say what?  Sulfur is pronounced as SUL-fer. \n"
                            
                    +"\n Classification:                   Sulfur is a chalcogen and a nonmetal "
                    +"\n Atomic Number:                16 " 
                    +"\n Atomic Weight:                  32.068 " 
                    +"\n Melting Point:                     388.36 K (115.21°C or 239.38°F) " 
                    +"\n Boiling Point:                      717.75 K (444.60°C or 832.28°F) " 
                    +"\n Density:                               2.067 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   yellow " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  16    "
                    +"\n Group Name:                      Chalcogen "
                    +"\n Stable Isotopes:                4   " 
                    +"\n Ionization Energy:             10.360 eV " 
                    +"\n Oxidation States:             +6, +4, -2 "
                    +"\n Electrons:                           16 "
                    +"\n Protons:                              16 "
                    +"\n Electron shells:                 2,8,6 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p4 "
                        , "Sulfur", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
            //Chlorine		17
            if(first.getText().equals("Cl") || first.getText().equals("chlorine") || first.getText().equals("Chlorine")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for greenish yellow, chloros. \n"
                    +"Say what?  Chlorine is pronounced as KLOR-een or as KLOR-in. \n"
                            
                    +"\n Classification:                   Chlorine is a halogen and a nonmetal "
                    +"\n Atomic Number:                17 " 
                    +"\n Atomic Weight:                  35.453 " 
                    +"\n Melting Point:                     171.65 K (-101.5°C or -150.7°F) " 
                    +"\n Boiling Point:                      239.11 K (-34.04°C or -29.27°F) " 
                    +"\n Density:                               0.003214 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   greenish-yellow " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  17    "
                    +"\n Group Name:                      Halogen "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             12.968 eV " 
                    +"\n Oxidation States:             +7, +5, +1, -1 "
                    +"\n Electrons:                           17 "
                    +"\n Protons:                              17 "
                    +"\n Electron shells:                 2,8,7 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p5 "
                        , "Chlorine", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Argon		18
            if(first.getText().equals("Ar") || first.getText().equals("argon") || first.getText().equals("Argon")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for inactive, argos. \n"
                    +"Say what?  Argon is pronounced as AR-gon. \n"
                            
                    +"\n Classification:                   Argon is a noble gas and a nonmetal "
                    +"\n Atomic Number:                18 " 
                    +"\n Atomic Weight:                  39.948 " 
                    +"\n Melting Point:                     83.80 K (-189.35°C or -308.83°F) " 
                    +"\n Boiling Point:                      87.30 K (-185.85°C or -302.53°F) " 
                    +"\n Density:                               0.003214 g/cm3 " 
                    +"\n State:                                   gas "
                    +"\n Color:                                   colorless " 
                    +"\n Period Number:                 3     "
                    +"\n Group Number:                  18    "
                    +"\n Group Name:                      Noble Gas "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             15.760 eV " 
                    +"\n Oxidation States:             0 "
                    +"\n Electrons:                           18 "
                    +"\n Protons:                              18 "
                    +"\n Electron shells:                 2,8,8 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 "
                        , "Argon", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Potassium		19
            if(first.getText().equals("K") || first.getText().equals("potassium") || first.getText().equals("Potassium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the English word potash. Potassium's \n"
                    +"                                     chemical symbol comes from the Latin \n"
                    +"                                     word for alkali, kalium. \n"
                    +"Say what?  Potassium is pronounced as poh-TASS-ee-em. \n"
                            
                    +"\n Classification:                   Potassium is an alkali metal "
                    +"\n Atomic Number:                19 " 
                    +"\n Atomic Weight:                  39.0983 " 
                    +"\n Melting Point:                     336.53 K (63.38°C or 146.08°F) " 
                    +"\n Boiling Point:                      1032 K (759°C or 1398°F) " 
                    +"\n Density:                               0.862 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-white " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  1    "
                    +"\n Group Name:                      Alkali Metal "
                    +"\n Stable Isotopes:                2   " 
                    +"\n Ionization Energy:             4.341 eV " 
                    +"\n Oxidation States:             +1 "
                    +"\n Electrons:                           19 "
                    +"\n Protons:                              19 "
                    +"\n Electron shells:                 2,8,8,1 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 4s1 "
                        , "Potassium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
            //Calcium		20
            if(first.getText().equals("Ca") || first.getText().equals("calcium") || first.getText().equals("Calcium")){
        	JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin word for lime, calx. \n"
                    +"Say what?  Calcium is pronounced as KAL-see-em. \n"
                            
                    +"\n Classification:                   Calcium is an alkali earth metal "
                    +"\n Atomic Number:                20 " 
                    +"\n Atomic Weight:                  40.078 " 
                    +"\n Melting Point:                     1115 K (842°C or 1548°F) " 
                    +"\n Boiling Point:                      1757 K (1484°C or 2703°F) " 
                    +"\n Density:                               1.54 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-gray " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  2    "
                    +"\n Group Name:                      Alkaline Earth Metal "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             6.113 eV " 
                    +"\n Oxidation States:             +2 "
                    +"\n Electrons:                           20 "
                    +"\n Protons:                              20 "
                    +"\n Electron shells:                 2,8,8,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 4s2 "
                        , "Calcium", JOptionPane.INFORMATION_MESSAGE);
        	}
		
            
		//Scandium		21
		if(first.getText().equals("Sc") || first.getText().equals("scandium") || first.getText().equals("Scandium")){
			JOptionPane.showMessageDialog(null,  
                     "What's in a name?  Named for Scandinavia. \n"
                    +"Say what?  Scandium is pronounced as SKAN-dee-em. \n"
                            
                    +"\n Classification:                   Scandium is a transition metal and rare earth. "
                    +"\n Atomic Number:                21 " 
                    +"\n Atomic Weight:                  44.9559 " 
                    +"\n Melting Point:                     1814 K (1541°C or 2806°F) " 
                    +"\n Boiling Point:                      3109 K (2836°C or 5137°F) " 
                    +"\n Density:                               2.99 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-white " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  3    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             6.561 eV " 
                    +"\n Oxidation States:             +3 "
                    +"\n Electrons:                           21 "
                    +"\n Protons:                              21 "
                    +"\n Electron shells:                 2,8,9,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d1 4s2 "
                        , "Scandium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Titanium		22
		if(first.getText().equals("Ti") || first.getText().equals("titanium") || first.getText().equals("Titanium")){
			JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word Titans, the \n"
                    +"                                     mythological 'first sons of the Earth.' \n"
                    +"Say what?  Titanium is pronounced as tie-TAY-nee-em. \n"
                            
                    +"\n Classification:                   Titanium is a transition metal "
                    +"\n Atomic Number:                22 " 
                    +"\n Atomic Weight:                  47.87 " 
                    +"\n Melting Point:                     1941 K (1668°C or 3034°F) " 
                    +"\n Boiling Point:                      3560 K (3287°C or 5949°F) " 
                    +"\n Density:                               4.5 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery-white " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  4    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                5   " 
                    +"\n Ionization Energy:             6.828 eV " 
                    +"\n Oxidation States:             +4, +3, +2 "
                    +"\n Electrons:                           22 "
                    +"\n Protons:                              22 "
                    +"\n Electron shells:                 2,8,10,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d2 4s2 "
                        , "Titanium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Vanadium		23
		if(first.getText().equals("V") || first.getText().equals("vanadium") || first.getText().equals("Vanadium")){
			JOptionPane.showMessageDialog(null,  
                     "What's in a name?  Named for the Scandinavian goddess Vanadis. \n"
                    +"Say what?  Vanadium is pronounced as veh-NAY-dee-em. \n"
                            
                    +"\n Classification:                   Vanadium is a transition metal "
                    +"\n Atomic Number:                23 " 
                    +"\n Atomic Weight:                  47.87 " 
                    +"\n Melting Point:                     2183 K (1910°C or 3470°F) " 
                    +"\n Boiling Point:                      3680 K (3407°C or 6165°F) " 
                    +"\n Density:                               6.0 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silvery " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  5    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             6.746 eV " 
                    +"\n Oxidation States:             +5, +4, +3, +2 "
                    +"\n Electrons:                           23 "
                    +"\n Protons:                              23 "
                    +"\n Electron shells:                 2,8,11,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d3 4s2 "
                        , "Vanadium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Chromium		24
		if(first.getText().equals("Cr") || first.getText().equals("chromium") || first.getText().equals("Chromium")){
			JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Greek word for color, chroma. \n"
                    +"Say what?  Chromium is pronounced as KROH-mee-em. \n"
                            
                    +"\n Classification:                   Chromium is a transition metal "
                    +"\n Atomic Number:                24 " 
                    +"\n Atomic Weight:                  51.996 " 
                    +"\n Melting Point:                     2180 K (1907°C or 3465°F) " 
                    +"\n Boiling Point:                      2944 K (2671°C or 4840°F) " 
                    +"\n Density:                               7.15 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   silver-gray " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  6    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                3   " 
                    +"\n Ionization Energy:             6.767 eV " 
                    +"\n Oxidation States:             +6, +3, +2 "
                    +"\n Electrons:                           24 "
                    +"\n Protons:                              24 "
                    +"\n Electron shells:                 2,8,13,1 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d5 4s1 "
                        , "Chromium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Manganese		25
		if(first.getText().equals("Mn") || first.getText().equals("manganese") || first.getText().equals("Manganese")){
			JOptionPane.showMessageDialog(null,  
                     "What's in a name?  From the Latin word for magnet, magnes. \n"
                    +"Say what?  Manganese is pronounced as MAN-ge-nees. \n"
                            
                    +"\n Classification:                   Manganese is a transition metal "
                    +"\n Atomic Number:                25 " 
                    +"\n Atomic Weight:                  54.9380 " 
                    +"\n Melting Point:                     1519 K (1246°C or 2275°F) " 
                    +"\n Boiling Point:                      2334 K (2061°C or 3742°F) " 
                    +"\n Density:                               7.3 g/cm3 " 
                    +"\n State:                                   solid "
                    +"\n Color:                                   gray-white " 
                    +"\n Period Number:                 4     "
                    +"\n Group Number:                  7    "
                    +"\n Group Name:                      none "
                    +"\n Stable Isotopes:                1   " 
                    +"\n Ionization Energy:             7.434 eV " 
                    +"\n Oxidation States:             +7, +4, +3, +2 "
                    +"\n Electrons:                           25 "
                    +"\n Protons:                              25 "
                    +"\n Electron shells:                 2,8,13,2 "
                    +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d5 4s2 "
                        , "Manganese", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                	
		//Iron		26
		if(first.getText().equals("Fe") || first.getText().equals("iron") || first.getText().equals("Iron")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Anglo-Saxon word iron. Iron's chemical \n"
                +"                                     symbol comes from the Latin word for iron, ferrum \n"
                +"Say what?  Iron is pronounced as EYE-ern. \n"
                            
                +"\n Classification:                   Iron is a transition metal "
                +"\n Atomic Number:                26 " 
                +"\n Atomic Weight:                  55.847 " 
                +"\n Melting Point:                     1811 K (1538°C or 2800°F) " 
                +"\n Boiling Point:                      3134 K (2861°C or 5182°F) " 
                +"\n Density:                               7.874 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   silvery-gray " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  8    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                4   " 
                +"\n Ionization Energy:             7.902 eV" 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           26 "
                +"\n Protons:                              26 "
                +"\n Electron shells:                 2,8,14,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d6 4s2 "
                        , "Iron", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Cobalt		27
		if(first.getText().equals("Co") || first.getText().equals("cobalt") || first.getText().equals("Cobalt")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the German word for goblin or evil spirit, \n"
                + "                                     kobald and the Greek word for mine, cobalos. \n"
                +"Say what?  Cobalt is pronounced as KO-bolt. \n"
                            
                +"\n Classification:                   Cobalt is a transition metal "
                +"\n Atomic Number:                27 " 
                +"\n Atomic Weight:                  58.9332 " 
                +"\n Melting Point:                     1768 K (1495°C or 2723°F) " 
                +"\n Boiling Point:                      3200 K (2927°C or 5301°F) " 
                +"\n Density:                               8.86 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   bluish-white " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  9    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1   " 
                +"\n Ionization Energy:             7.881 eV" 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           27 "
                +"\n Protons:                              27 "
                +"\n Electron shells:                 2,8,15,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d7 4s2 "
                        , "Cobalt", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Nickel		28
		if(first.getText().equals("Ni") || first.getText().equals("nickel") || first.getText().equals("Nickel")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the German word Nickel, which means \n"
                +"                                     'Old Nick,' a name for the devil. Also from the \n"
                +"                                     German word for the mineral niccolite, kupfernickel,\n"
                +"                                     which means 'Old Nick's copper.' \n"
                +"Say what?  Nickel is pronounced as NIK-'l. \n"
                            
                +"\n Classification:                   Nickel is a transition metal "
                +"\n Atomic Number:                28 " 
                +"\n Atomic Weight:                  58.6934 " 
                +"\n Melting Point:                     1728 K (1455°C or 2651°F) " 
                +"\n Boiling Point:                      3186 K (2913°C or 5275°F) " 
                +"\n Density:                               8.86 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   silvery-white " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  10    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                5   " 
                +"\n Ionization Energy:             7.640 eV" 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           28 "
                +"\n Protons:                              28 "
                +"\n Electron shells:                 2,8,16,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d8 4s2 "
                        , "Nickel", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Copper		29
		if(first.getText().equals("Cu") || first.getText().equals("copper") || first.getText().equals("Copper")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word cuprum, which means 'from the island of Cyprus.' \n"
                +"Say what?  Copper is pronounced as KOP-er. \n"
                            
                +"\n Classification:                   Copper is a transition metal "
                +"\n Atomic Number:                29 " 
                +"\n Atomic Weight:                  63.546 " 
                +"\n Melting Point:                     1357.77 K (1084.62°C or 1984.32°F) " 
                +"\n Boiling Point:                      2835 K (2562°C or 4644°F) " 
                +"\n Density:                               8.96 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   orange-red " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  11    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2   " 
                +"\n Ionization Energy:             7.726 eV" 
                +"\n Oxidation States:             +2, +1 "
                +"\n Electrons:                           29 "
                +"\n Protons:                              29 "
                +"\n Electron shells:                 2,8,18,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s1 "
                        , "Copper", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Zinc		30
		if(first.getText().equals("Zn") || first.getText().equals("zinc") || first.getText().equals("Zinc")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the German word zink. \n"
                +"Say what?  Zinc is pronounced as ZINK. \n"
                            
                +"\n Classification:                   Zinc is a transition metal "
                +"\n Atomic Number:                30 " 
                +"\n Atomic Weight:                  65.38 " 
                +"\n Melting Point:                     692.68 K (419.53°C or 787.15°F) " 
                +"\n Boiling Point:                      1180 K (907°C or 1665°F) " 
                +"\n Density:                               7.134 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   bluish silver " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  12    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                3   " 
                +"\n Ionization Energy:             9.394 eV" 
                +"\n Oxidation States:             +2 "
                +"\n Electrons:                           30 "
                +"\n Protons:                              30 "
                +"\n Electron shells:                 2,8,18,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 "
                        , "Zinc", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		
		//Gallium		31
		if(first.getText().equals("Ga") || first.getText().equals("gallium") || first.getText().equals("Gallium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for France, Gallia. \n"
                +"Say what?  Gallium is pronounced as GAL-ee-em. \n"
                            
                +"\n Classification:                   Gallium is an ‘other metal' "
                +"\n Atomic Number:                31 " 
                +"\n Atomic Weight:                  69.723 " 
                +"\n Melting Point:                     302.91 K (29.76°C or 85.57°F) " 
                +"\n Boiling Point:                      2477 K (2204°C or 3999°F) " 
                +"\n Density:                               5.91 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   silvery-blue " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  13    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2   " 
                +"\n Ionization Energy:             5.999 eV" 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           31 "
                +"\n Protons:                              31 "
                +"\n Electron shells:                 2,8,18,3 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p1 "
                        , "Gallium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Germanium		32
		if(first.getText().equals("Ge") || first.getText().equals("germanium") || first.getText().equals("Germanium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the country of Germany. \n"
                +"Say what?  Germanium is pronounced as jer-MAY-ni-em. \n"
                            
                +"\n Classification:                   Germanium is a metalloid "
                +"\n Atomic Number:                32 " 
                +"\n Atomic Weight:                  72.630 " 
                +"\n Melting Point:                     1211.40 K (938.25°C or 1720.85°F) " 
                +"\n Boiling Point:                      3106 K (2833°C or 5131°F) " 
                +"\n Density:                               5.323 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   gray-white " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  14    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                5   " 
                +"\n Ionization Energy:             7.900 eV" 
                +"\n Oxidation States:             +4, +2 "
                +"\n Electrons:                           32 "
                +"\n Protons:                              32 "
                +"\n Electron shells:                 2,8,18,4 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p2 "
                        , "Germanium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Arsenic		33
		if(first.getText().equals("As") || first.getText().equals("arsenic") || first.getText().equals("Arsenic")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word arsenicum, the Greek word arsenikon and the Arabic word Az-zernikh. \n"
                +"Say what?  Arsenic is pronounced as AR-s'n-ik. \n"
                            
                +"\n Classification:                   Arsenic is a metalloid "
                +"\n Atomic Number:                33 " 
                +"\n Atomic Weight:                  74.921595 " 
                +"\n Melting Point:                     1090 K (817°C or 1503°F) " 
                +"\n Boiling Point:                      887 K (614°C or 1137°F) " 
                +"\n Density:                               5.776 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   gray " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  15    "
                +"\n Group Name:                      Pnictogen "
                +"\n Stable Isotopes:                1   " 
                +"\n Ionization Energy:             9.815 eV" 
                +"\n Oxidation States:             +5, +3, -3 "
                +"\n Electrons:                           33 "
                +"\n Protons:                              33 "
                +"\n Electron shells:                 2,8,18,5 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p3 "
                        , "Arsenic", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Selenium		34
		if(first.getText().equals("Se") || first.getText().equals("selenium") || first.getText().equals("Selenium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for the moon, selene. \n"
                +"Say what?  Selenium is pronounced as si-LEE-nee-em. \n"
                            
                +"\n Classification:                   Selenium is a chalcogen and a nonmetal "
                +"\n Atomic Number:                34 " 
                +"\n Atomic Weight:                  78.971 " 
                +"\n Melting Point:                     493.65 K (220.5°C or 428.9°F) " 
                +"\n Boiling Point:                      958 K (685°C or 1265°F) " 
                +"\n Density:                               4.809 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   gray or red (crystalline), black or red (amorphous)  " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  16    "
                +"\n Group Name:                      Chalcogen "
                +"\n Stable Isotopes:                6   " 
                +"\n Ionization Energy:             9.752 eV" 
                +"\n Oxidation States:             +6, +4, -2 "
                +"\n Electrons:                           34 "
                +"\n Protons:                              34 "
                +"\n Electron shells:                 2,8,18,6 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p4 "
                        , "Selenium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Bromine		35
		if(first.getText().equals("Br") || first.getText().equals("bromine") || first.getText().equals("Bromine")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for stench, bromos. \n"
                +"Say what?  Bromine is pronounced as BRO-meen. \n"
                            
                +"\n Classification:                   Bromine is a halogen and a nonmetal "
                +"\n Atomic Number:                35 " 
                +"\n Atomic Weight:                  79.904 " 
                +"\n Melting Point:                     265.95 K (-7.2°C or 19.0°F) " 
                +"\n Boiling Point:                      331.95 K (58.8°C or 137.8°F) " 
                +"\n Density:                               3.11 g/cm3 " 
                +"\n State:                                   Liquid "
                +"\n Color:                                   	red-brown  " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  17    "
                +"\n Group Name:                      Halogen "
                +"\n Stable Isotopes:                2   " 
                +"\n Ionization Energy:             11.814 eV" 
                +"\n Oxidation States:             +5, +1, -1"
                +"\n Electrons:                           35 "
                +"\n Protons:                              35 "
                +"\n Electron shells:                 2,8,18,7 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p5 "
                        , "Bromine", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                	
		//Krypton		36
		if(first.getText().equals("Kr") || first.getText().equals("krypton") || first.getText().equals("Krypton")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for hidden, kryptos. \n"
                +"Say what?  Krypton is pronounced as KRIP-ton. \n"
                            
                +"\n Classification:                   Krypton is a noble gas and a nonmetal "
                +"\n Atomic Number:                36 " 
                +"\n Atomic Weight:                  83.80 " 
                +"\n Melting Point:                     115.79 K (-157.36°C or -251.25°F) " 
                +"\n Boiling Point:                      119.93 K (-153.22°C or -243.80°F) " 
                +"\n Density:                               0.003733 g/cm3 " 
                +"\n State:                                   gas "
                +"\n Color:                                   	colorless  " 
                +"\n Period Number:                 4     "
                +"\n Group Number:                  18    "
                +"\n Group Name:                      Noble Gas "
                +"\n Stable Isotopes:                5   " 
                +"\n Ionization Energy:             14.000 eV " 
                +"\n Oxidation States:             0 "
                +"\n Electrons:                           36 "
                +"\n Protons:                              36 "
                +"\n Electron shells:                 2,8,18,8 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 "
                        , "Krypton", JOptionPane.INFORMATION_MESSAGE);
        	}

		//Rubidium		37
		if(first.getText().equals("Rb") || first.getText().equals("rubidium") || first.getText().equals("Rubidium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for deepest red, rubidus. \n"
                +"Say what?  Rubidium is pronounced as roo-BID-ee-em. \n"
                            
                +"\n Classification:                   Krypton is a noble gas and a nonmetal "
                +"\n Atomic Number:                37 " 
                +"\n Atomic Weight:                  85.4678 " 
                +"\n Melting Point:                     312.46 K (39.31°C or 102.76°F) " 
                +"\n Boiling Point:                      961 K (688°C or 1270°F) " 
                +"\n Density:                               1.53 g/cm3 " 
                +"\n State:                                   gas "
                +"\n Color:                                   	colorless  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  1    "
                +"\n Group Name:                      Alkali Metal "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:             4.177 eV " 
                +"\n Oxidation States:             +1 "
                +"\n Electrons:                           37 "
                +"\n Protons:                              37 "
                +"\n Electron shells:                 2,8,18,8,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 5s1 "
                        , "Rubidium", JOptionPane.INFORMATION_MESSAGE);
        	}

		//Strontium		38
		if(first.getText().equals("Sr") || first.getText().equals("strontium") || first.getText().equals("Strontium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the town of Strontian, Scotland. \n"
                +"Say what?  Strontium is pronounced as STRON-she-em. \n"
                            
                +"\n Classification:                   Strontium is an alkali earth metal "
                +"\n Atomic Number:                38 " 
                +"\n Atomic Weight:                  87.62 " 
                +"\n Melting Point:                     1050 K (777°C or 1431°F) " 
                +"\n Boiling Point:                      1655 K (1382°C or 2520°F) " 
                +"\n Density:                               2.64 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  2    "
                +"\n Group Name:                      Alkaline Earth Metal "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:             5.695 eV " 
                +"\n Oxidation States:             +2 "
                +"\n Electrons:                           38 "
                +"\n Protons:                              38 "
                +"\n Electron shells:                 2,8,18,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 5s2 "
                        , "Strontium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Yttrium		39
		if(first.getText().equals("Y") || first.getText().equals("yttrium") || first.getText().equals("Yttrium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the village of Ytterby, Sweden. \n"
                +"Say what?  Yttrium is pronounced as IT-ree-em. \n"
                            
                +"\n Classification:                   Yttrium is a transition metal & rare earth "
                +"\n Atomic Number:                39 " 
                +"\n Atomic Weight:                  88.9059 " 
                +"\n Melting Point:                     1795 K (1522°C or 2772°F) " 
                +"\n Boiling Point:                      3618 K (3345°C or 6053°F) " 
                +"\n Density:                               4.47 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  3    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:             6.217 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           39 "
                +"\n Protons:                              39 "
                +"\n Electron shells:                 2,8,18,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d1 5s2 "
                        , "Yttrium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Zirconium		40
		if(first.getText().equals("Zr") || first.getText().equals("zirconium") || first.getText().equals("Zirconium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the village of Ytterby, Sweden. \n"
                +"Say what?  Yttrium is pronounced as IT-ree-em. \n"
                            
                +"\n Classification:                   Zirconium is a transition metal "
                +"\n Atomic Number:                40 " 
                +"\n Atomic Weight:                  91.224 " 
                +"\n Melting Point:                     2128 K (1855°C or 3371°F) " 
                +"\n Boiling Point:                      4682 K (4409°C or 7968°F) " 
                +"\n Density:                               6.52 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  4    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                4 " 
                +"\n Ionization Energy:             6.634 eV " 
                +"\n Oxidation States:             +4 "
                +"\n Electrons:                           40 "
                +"\n Protons:                              40 "
                +"\n Electron shells:                 2,8,18,10,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d2 5s2 "
                        , "Zirconium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                //Niobium		41
		if(first.getText().equals("Nb") || first.getText().equals("niobium") || first.getText().equals("Niobium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Greek mythological figure Niobe. \n"
                +"Say what?  Niobium is pronounced as ni-OH-bee-um. \n"
                            
                +"\n Classification:                   Niobium is a transition metal "
                +"\n Atomic Number:                41 " 
                +"\n Atomic Weight:                  92.90637 " 
                +"\n Melting Point:                     2750 K (2477°C or 4491°F) " 
                +"\n Boiling Point:                      5017 K (4744°C or 8571°F) " 
                +"\n Density:                               8.57 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  5    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:             6.759 eV " 
                +"\n Oxidation States:             +5, +3 "
                +"\n Electrons:                           41 "
                +"\n Protons:                              41 "
                +"\n Electron shells:                 2,8,18,12,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d4 5s1 "
                        , "Niobium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                		
		//Molybdenum		42
		if(first.getText().equals("Mo") || first.getText().equals("molybdenum") || first.getText().equals("Molybdenum")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for lead, molybdos. \n"
                +"Say what?  Molybdenum is pronounced as meh-LIB-deh-nem. \n"
                            
                +"\n Classification:                   Molybdenum is a transition metal "
                +"\n Atomic Number:                42 " 
                +"\n Atomic Weight:                  95.94 " 
                +"\n Melting Point:                     2896 K (2623°C or 4753°F) " 
                +"\n Boiling Point:                      2896 K (2623°C or 4753°F) " 
                +"\n Density:                               10.2 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  6    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                6 " 
                +"\n Ionization Energy:             7.092 eV " 
                +"\n Oxidation States:             +6 "
                +"\n Electrons:                           42 "
                +"\n Protons:                              42 "
                +"\n Electron shells:                 2,8,18,13,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d5 5s1 "
                        , "Molybdenum", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Technetium		43
		if(first.getText().equals("Tc") || first.getText().equals("technetium") || first.getText().equals("Technetium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for artificial, technetos. \n"
                +"Say what?  Technetium is pronounced as tek-NEE-she-em. \n"
                            
                +"\n Classification:                   Molybdenum is a transition metal \n"
                        + "                                                (Radioactive and Artificially Produced)"
                +"\n Atomic Number:                43 " 
                +"\n Atomic Weight:                  98 " 
                +"\n Melting Point:                     2430 K (2157°C or 3915°F) " 
                +"\n Boiling Point:                      4538 K (4265°C or 7709°F) " 
                +"\n Density:                               11 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silver-gray  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  7    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:             7.28 eV " 
                +"\n Oxidation States:             +7, +6, +4 "
                +"\n Electrons:                           43 "
                +"\n Protons:                              43 "
                +"\n Electron shells:                 2,8,18,14,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d5 5s2 "
                        , "Technetium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Ruthenium		44
		if(first.getText().equals("Ru") || first.getText().equals("ruthenium") || first.getText().equals("Ruthenium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for the country of Russia, Ruthenia. \n"
                +"Say what?  Ruthenium is pronounced as roo-THE-nee-em. \n"
                            
                +"\n Classification:                   Ruthenium is a transition metal"
                +"\n Atomic Number:                44 " 
                +"\n Atomic Weight:                  101.07 " 
                +"\n Melting Point:                     2607 K (2334°C or 4233°F) " 
                +"\n Boiling Point:                      4423 K (4150°C or 7502°F) " 
                +"\n Density:                               12.1 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silver-gray  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  8    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                7 " 
                +"\n Ionization Energy:             7.361 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           44 "
                +"\n Protons:                              44 "
                +"\n Electron shells:                 2,8,18,15,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d7 5s1 "
                        , "Ruthenium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
                //Rhodium		45
		if(first.getText().equals("Rh") || first.getText().equals("rhodium") || first.getText().equals("Rhodium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for rose, rhodon. \n"
                +"Say what?  Rhodium is pronounced as RO-dee-em. \n"
                            
                +"\n Classification:                   Rhodium is a transition metal "
                +"\n Atomic Number:                45 " 
                +"\n Atomic Weight:                  102.90550 " 
                +"\n Melting Point:                     2237 K (1964°C or 3567°F) " 
                +"\n Boiling Point:                      3968 K (3695°C or 6683°F) " 
                +"\n Density:                               12.4 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  9    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:             7.459 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           45 "
                +"\n Protons:                              45 "
                +"\n Electron shells:                 2,8,18,16,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d8 5s1 "
                        , "Rhodium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                
		//Palladium		46
		if(first.getText().equals("Pd") || first.getText().equals("palladium") || first.getText().equals("Palladium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the asteroid Pallas and the Greek goddess of wisdom. \n"
                +"Say what?  Palladium is pronounced as peh-LAY-dee-em. \n"
                            
                +"\n Classification:                   Palladium is a transition metal "
                +"\n Atomic Number:                46 " 
                +"\n Atomic Weight:                  106.4 " 
                +"\n Melting Point:                     1828.05 K (1554.9°C or 2830.8°F) " 
                +"\n Boiling Point:                      3236 K (2963°C or 5365°F) " 
                +"\n Density:                               12.0 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  10    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                6 " 
                +"\n Ionization Energy:             8.337 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           46 "
                +"\n Protons:                              46 "
                +"\n Electron shells:                 2,8,18,18 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 "
                        , "Palladium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Silver		47
		if(first.getText().equals("Ag") || first.getText().equals("silver") || first.getText().equals("Silver")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Anglo-Saxon word seolfor. Silver's chemical \n"
                + "                                      symbol comes from the Latin word for silver, argentum. \n"
                +"Say what?  Silver is pronounced as SIL-ver. \n"
                            
                +"\n Classification:                   Silver is a transition metal "
                +"\n Atomic Number:                47 " 
                +"\n Atomic Weight:                  107.8682 " 
                +"\n Melting Point:                     1234.93 K (961.78°C or 1763.20°F) " 
                +"\n Boiling Point:                      2435 K (2162°C or 3924°F) " 
                +"\n Density:                               10.5 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  11    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2 " 
                +"\n Ionization Energy:             7.576 eV " 
                +"\n Oxidation States:             +1 "
                +"\n Electrons:                           47 "
                +"\n Protons:                              47 "
                +"\n Electron shells:                 2,8,18,18,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s1 "
                        , "Silver", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Cadmium		48
		if(first.getText().equals("Cd") || first.getText().equals("cadmium") || first.getText().equals("Cadmium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word cadmia and the Greek word kadmeia, \n"
                + "                                      which are ancient names for calamine (zinc carbonite). \n"
                +"Say what?  Cadmium is pronounced as KAD-mee-em. \n"
                            
                +"\n Classification:                   Cadmium is a transition metal "
                +"\n Atomic Number:                48 " 
                +"\n Atomic Weight:                  112.414 " 
                +"\n Melting Point:                     594.22 K (321.07°C or 609.93°F) " 
                +"\n Boiling Point:                      1040 K (767°C or 1413°F) " 
                +"\n Density:                               8.69 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	bluish-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  12    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                3 " 
                +"\n Ionization Energy:              8.994 eV " 
                +"\n Oxidation States:             +2 "
                +"\n Electrons:                           48 "
                +"\n Protons:                              48 "
                +"\n Electron shells:                 2,8,18,18,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s2 "
                        , "Cadmium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Indium		49
		if(first.getText().equals("In") || first.getText().equals("indium") || first.getText().equals("Indium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the bright indigo line in its spectrum. \n"
                +"Say what?  Indium is pronounced as IN-dee-em. \n"
                            
                +"\n Classification:                   Indium is an ‘other metal’ "
                +"\n Atomic Number:                49 " 
                +"\n Atomic Weight:                  114.82 " 
                +"\n Melting Point:                     429.75 K (156.60°C or 313.88°F) " 
                +"\n Boiling Point:                      2345 K (2072°C or 3762°F) " 
                +"\n Density:                               7.31 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  13    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.786 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           49 "
                +"\n Protons:                              49 "
                +"\n Electron shells:                 2,8,18,18,3 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s2 \n"
                        + "                                                5p1 "
                        , "Indium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Tin		50
		if(first.getText().equals("Sn") || first.getText().equals("tin") || first.getText().equals("Tin")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Anglo-Saxon word tin. Tin's atomic symbol comes \n"
                        + "                                     from the Latin word for tin, stannum. \n"
                +"Say what?  Tin is pronounced as TIN. \n"
                            
                +"\n Classification:                   Tin can behave as an ‘other metal’ (white tin) or a \n"
                        + "                                               nonmetal (gray tin). "
                +"\n Atomic Number:                50 " 
                +"\n Atomic Weight:                  118.710 " 
                +"\n Melting Point:                     505.08 K (231.93°C or 449.47°F) " 
                +"\n Boiling Point:                      2875 K (2602°C or 4715°F) " 
                +"\n Density:                               7.287 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  14    "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                8 " 
                +"\n Ionization Energy:              7.344 eV " 
                +"\n Oxidation States:             +4, +2 "
                +"\n Electrons:                           50 "
                +"\n Protons:                              50 "
                +"\n Electron shells:                 2,8,18,18,4 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s2 5p2 "
                        , "Tin", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                		
		//Antimony		51
		if(first.getText().equals("Sb") || first.getText().equals("antimony") || first.getText().equals("Antimony")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek words anti and monos, which together mean 'not alone'. \n"
                +"                                      Antimony's chemical symbol comes from its historic name, Stibium. \n"
                +"Say what?  Antimony is pronounced as AN-the-MOH-nee. \n"
                            
                +"\n Classification:                   Antimony is a metalloid or a nonmetal (gray tin). "
                +"\n Atomic Number:                51 " 
                +"\n Atomic Weight:                  121.760 " 
                +"\n Melting Point:                     903.78 K (630.63°C or 1167.13°F) " 
                +"\n Boiling Point:                      1860 K (1587°C or 2889°F) " 
                +"\n Density:                               6.685 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  15    "
                +"\n Group Name:                      Pnictogen "
                +"\n Stable Isotopes:                2 " 
                +"\n Ionization Energy:              8.64 eV " 
                +"\n Oxidation States:             +5, +3, -3 "
                +"\n Electrons:                           51 "
                +"\n Protons:                              51 "
                +"\n Electron shells:                 2,8,18,18,5 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s2 5p3 "
                        , "Antimony", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Tellurium		52
		if(first.getText().equals("Te") || first.getText().equals("tellurium") || first.getText().equals("Tellurium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for earth, tellus. \n"
                +"Say what?  Tellurium is pronounced as te-LOOR-ee-em. \n"
                            
                +"\n Classification:                   Tellurium is a chalcogen and a metalloid "
                +"\n Atomic Number:                52 " 
                +"\n Atomic Weight:                  127.60 " 
                +"\n Melting Point:                     722.66 K (449.51°C or 841.12°F) " 
                +"\n Boiling Point:                      1261 K (988°C or 1810°F) " 
                +"\n Density:                               6.232 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	silvery  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  16    "
                +"\n Group Name:                      Chalcogen "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              9.010 eV " 
                +"\n Oxidation States:             +6, +4, -2 "
                +"\n Electrons:                           52 "
                +"\n Protons:                              52 "
                +"\n Electron shells:                 2,8,18,18,6 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                5s2 5p4 "
                        , "Tellurium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Iodine		53
		if(first.getText().equals("I") || first.getText().equals("iodine") || first.getText().equals("Iodine")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for violet, iodes. \n"
                +"Say what?  Iodine is pronounced as EYE-eh-dine or as EYE-eh-din. \n"
                            
                +"\n Classification:                   Iodine is a halogen and a nonmetal "
                +"\n Atomic Number:                53 " 
                +"\n Atomic Weight:                  126.90447 " 
                +"\n Melting Point:                     386.85 K (113.7°C or 236.7°F) " 
                +"\n Boiling Point:                      457.55 K (184.4°C or 364.0°F) " 
                +"\n Density:                               4.93 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   	bluish-black solid, purple vapor  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  17    "
                +"\n Group Name:                      Halogen "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              10.451 eV " 
                +"\n Oxidation States:             +7, +5, +1, -1 "
                +"\n Electrons:                           53 "
                +"\n Protons:                              53 "
                +"\n Electron shells:                 2,8,18,18,7 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                5s2 5p5 "
                        , "Iodine", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Xenon		54
		if(first.getText().equals("Xe") || first.getText().equals("xenon") || first.getText().equals("Xenon")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for stranger, xenon. \n"
                +"Say what?  Xenon is pronounced as ZEE-non. \n"
                            
                +"\n Classification:                   	Xenon is a noble gas and a nonmetal "
                +"\n Atomic Number:                54 " 
                +"\n Atomic Weight:                  131.293 " 
                +"\n Melting Point:                     161.36 K (-111.79°C or -169.22°F) " 
                +"\n Boiling Point:                      165.03 K (-108.12°C or -162.62°F) " 
                +"\n Density:                               0.005887 g/cm3 " 
                +"\n State:                                   Gas "
                +"\n Color:                                   	colorless  " 
                +"\n Period Number:                 5     "
                +"\n Group Number:                  18    "
                +"\n Group Name:                      Noble Gas "
                +"\n Stable Isotopes:                6 " 
                +"\n Ionization Energy:              12.130 eV " 
                +"\n Oxidation States:             0 "
                +"\n Electrons:                           54 "
                +"\n Protons:                              54 "
                +"\n Electron shells:                 2,8,18,18,8 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 5s2 5p6 "
                        , "Xenon", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Cesium		55
		if(first.getText().equals("Cs") || first.getText().equals("cesium") || first.getText().equals("Cesium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for sky blue, caesius. \n"
                +"Say what?  Cesium is pronounced as SEE-zee-em. \n"
                            
                +"\n Classification:                   	Cesium is an alkali metal "
                +"\n Atomic Number:                55 " 
                +"\n Atomic Weight:                  132.90545196 " 
                +"\n Melting Point:                     301.59 K (28.44°C or 83.19°F) " 
                +"\n Boiling Point:                      944 K (671°C or 1240°F) " 
                +"\n Density:                               1.93 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	yellow/silvery  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  1    "
                +"\n Group Name:                      Alkali Metal "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              3.894 eV " 
                +"\n Oxidation States:             +1 "
                +"\n Electrons:                           55 "
                +"\n Protons:                              55 "
                +"\n Electron shells:                 2,8,18,18,8,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 5s2 5p6 6s1 "
                        , "Cesium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Barium		56
		if(first.getText().equals("Ba") || first.getText().equals("barium") || first.getText().equals("Barium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for heavy, barys. \n"
                +"Say what?  Barium is pronounced as BAR-ee-em. \n"
                            
                +"\n Classification:                   	Barium is an alkali earth metal "
                +"\n Atomic Number:                56 " 
                +"\n Atomic Weight:                  137.327 " 
                +"\n Melting Point:                     1000 K (727°C or 1341°F) " 
                +"\n Boiling Point:                      2170 K (1897°C or 3447°F) " 
                +"\n Density:                               3.62 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  2    "
                +"\n Group Name:                      Alkaline Earth Metal "
                +"\n Stable Isotopes:                6 " 
                +"\n Ionization Energy:              5.212 eV " 
                +"\n Oxidation States:             +2 "
                +"\n Electrons:                           56 "
                +"\n Protons:                              56 "
                +"\n Electron shells:                 2,8,18,18,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 5s2 5p6 6s2 "
                        , "Barium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Lanthanum		57
		if(first.getText().equals("La") || first.getText().equals("lanthanum") || first.getText().equals("Lanthanum")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word lanthaneia, which means 'to lie hidden.' \n"
                +"Say what?  Lanthanum is pronounced as LAN-the-nem. \n"
                            
                +"\n Classification:                   	Lanthanum is a lanthanide and rare earth metal "
                +"\n Atomic Number:                57 " 
                +"\n Atomic Weight:                  138.90547 " 
                +"\n Melting Point:                     1191 K (918°C or 1684°F) " 
                +"\n Boiling Point:                      3737 K (3464°C or 6267°F) " 
                +"\n Density:                               6.15 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.577 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           57 "
                +"\n Protons:                              57 "
                +"\n Electron shells:                 2,8,18,18,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 5s2 5p6 5d1 6s2 "
                        , "Lanthanum", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Lanthanum		58
		if(first.getText().equals("Ce") || first.getText().equals("cerium") || first.getText().equals("Cerium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the asteroid Ceres. \n"
                +"Say what?  Cerium is pronounced as SER-ee-em. \n"
                            
                +"\n Classification:                   	Cerium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                58 " 
                +"\n Atomic Weight:                  140.116 " 
                +"\n Melting Point:                     1071 K (798°C or 1468°F) " 
                +"\n Boiling Point:                      3697 K (3424°C or 6195°F) " 
                +"\n Density:                               6.770 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.539 eV " 
                +"\n Oxidation States:             +4, +3 "
                +"\n Electrons:                           58 "
                +"\n Protons:                              58 "
                +"\n Electron shells:                 2,8,18,20,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f1 5s2 5p6 5d1 6s2 "
                        , "Cerium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Praseodymium		59
		if(first.getText().equals("Pr") || first.getText().equals("praseodymium") || first.getText().equals("Praseodymium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek words prasios and didymos, which together mean 'green twin'. \n"
                +"Say what?  Praseodymium is pronounced as pra-see-oh-DIM-ee-em. \n"
                            
                +"\n Classification:                   	Praseodymium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                58 " 
                +"\n Atomic Weight:                  140.90766 " 
                +"\n Melting Point:                     1204 K (931°C or 1708°F) " 
                +"\n Boiling Point:                      3793 K (3520°C or 6368°F) " 
                +"\n Density:                               6.77 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.464 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           58 "
                +"\n Protons:                              58 "
                +"\n Electron shells:                 2,8,18,21,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f3 5s2 5p6 6s2 "
                        , "Praseodymium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Neodymium		60
		if(first.getText().equals("Nd") || first.getText().equals("neodymium") || first.getText().equals("Neodymium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named from the Greek words neos and didymos, which together mean 'new twin'. \n"
                +"Say what?  Neodymium is pronounced as nee-eh-DIM-ee-em. \n"
                            
                +"\n Classification:                   	Neodymium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                60 " 
                +"\n Atomic Weight:                  144.242 " 
                +"\n Melting Point:                     1294 K (1021°C or 1870°F) " 
                +"\n Boiling Point:                      3347 K (3074°C or 5565°F) " 
                +"\n Density:                               7.01 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              5.525 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           60 "
                +"\n Protons:                              60 "
                +"\n Electron shells:                 2,8,18,22,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f4 5s2 5p6 6s2 "
                        , "Neodymium", JOptionPane.INFORMATION_MESSAGE);
        	}	

			
		//Promethium		61
		if(first.getText().equals("Pm") || first.getText().equals("promethium") || first.getText().equals("Promethium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Greek mythological figure Prometheus.\n"
                +"Say what?  Neodymium is pronounced as nee-eh-DIM-ee-em. \n"
                            
                +"\n Classification:                   		Promethium is a lanthanide and rare earth metal \n"
                        + "                                                (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                61 " 
                +"\n Atomic Weight:                  145 " 
                +"\n Melting Point:                     1315 K (1042°C or 1908°F) " 
                +"\n Boiling Point:                      3273 K (3000°C or 5432°F) " 
                +"\n Density:                               7.26 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              5.55 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           61 "
                +"\n Protons:                              61 "
                +"\n Electron shells:                 2,8,18,23,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f5 5s2 5p6 6s2 "
                        , "Promethium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Samarium		62
		if(first.getText().equals("Sm") || first.getText().equals("samarium") || first.getText().equals("Samarium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the mineral samarskite. \n"
                +"Say what?  Samarium is pronounced as seh-MER-ee-em. \n"
                            
                +"\n Classification:                   		Samarium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                62 " 
                +"\n Atomic Weight:                  150.36 " 
                +"\n Melting Point:                     1347 K (1074°C or 1965°F) " 
                +"\n Boiling Point:                      2067 K (1794°C or 3261°F) " 
                +"\n Density:                               7.52 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              5.644 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           62 "
                +"\n Protons:                              62 "
                +"\n Electron shells:                 2,8,18,24,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f6 5s2 5p6 6s2 "
                        , "Samarium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Europium		63
		if(first.getText().equals("Eu") || first.getText().equals("europium") || first.getText().equals("Europium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the continent of Europe. \n"
                +"Say what?  Europium is pronounced as yoo-RO-pee-em. \n"
                            
                +"\n Classification:                   		Europium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                63 " 
                +"\n Atomic Weight:                  151.3964 " 
                +"\n Melting Point:                     1095 K (822°C or 1512°F) " 
                +"\n Boiling Point:                      1802 K (1529°C or 2784°F) " 
                +"\n Density:                               5.24 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.670 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           63 "
                +"\n Protons:                              63 "
                +"\n Electron shells:                 2,8,18,25,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f7 5s2 5p6 6s2 "
                        , "Europium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Gadolinium		64
		if(first.getText().equals("Gd") || first.getText().equals("gadolinium") || first.getText().equals("Gadolinium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the continent of Europe. \n"
                +"Say what?  Europium is pronounced as yoo-RO-pee-em. \n"
                            
                +"\n Classification:                   		Gadolinium is a rare earth metal "
                +"\n Atomic Number:                64 " 
                +"\n Atomic Weight:                  157.25 " 
                +"\n Melting Point:                     1586 K (1313°C or 2395°F) " 
                +"\n Boiling Point:                      3546 K (3273°C or 5923°F) " 
                +"\n Density:                               7.90 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              6.150 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           64 "
                +"\n Protons:                              64 "
                +"\n Electron shells:                 2,8,18,25,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f7 5s2 5p6 5d1 6s2 "
                        , "Gadolinium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Terbium		65
		if(first.getText().equals("Tb") || first.getText().equals("terbium") || first.getText().equals("Terbium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the village of Ytterby, Sweden. \n"
                +"Say what?  Terbium is pronounced as TUR-beeem. \n"
                            
                +"\n Classification:                   		Terbium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                65 " 
                +"\n Atomic Weight:                  158.92535 " 
                +"\n Melting Point:                     1629 K (1356°C or 2473°F) " 
                +"\n Boiling Point:                      3503 K (3230°C or 5846°F) " 
                +"\n Density:                               8.23 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.864 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           65 "
                +"\n Protons:                              65 "
                +"\n Electron shells:                 2,8,18,27,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f9 5s2 5p6 6s2 "
                        , "Terbium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                	
		//Dysprosium		66
		if(first.getText().equals("Dy") || first.getText().equals("dysprosium") || first.getText().equals("Dysprosium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word dysprositos, which means 'hard to get at'. \n"
                +"Say what?  Dysprosium is pronounced as dis-PRO-see-em or as dis-PRO-she-em. \n"
                            
                +"\n Classification:                   		Dysprosium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                66 " 
                +"\n Atomic Weight:                  162.500 " 
                +"\n Melting Point:                     1685 K (1412°C or 2574°F) " 
                +"\n Boiling Point:                      2840 K (2567°C or 4653°F) " 
                +"\n Density:                               8.55 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                7 " 
                +"\n Ionization Energy:              5.939 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           66 "
                +"\n Protons:                              66 "
                +"\n Electron shells:                 2,8,18,28,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f10 5s2 5p6 6s2 "
                        , "Dysprosium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
                //Holmium		67
		if(first.getText().equals("Ho") || first.getText().equals("holmium") || first.getText().equals("Holmium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for the city of Stockholm, Holmia. \n"
                +"Say what?  Holmium is pronounced as HOHL-mee-em. \n"
                            
                +"\n Classification:                   		Holmium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                67 " 
                +"\n Atomic Weight:                  164.93033 " 
                +"\n Melting Point:                     1747 K (1474°C or 2685°F) " 
                +"\n Boiling Point:                      2973 K (2700°C or 4892°F) " 
                +"\n Density:                               8.80 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              6.022 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           67 "
                +"\n Protons:                              67 "
                +"\n Electron shells:                 2,8,18,28,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f11 5s2 \n"
                        + "                                                5p6 6s2 "
                        , "Dysprosium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Erbium		68
		if(first.getText().equals("Er") || first.getText().equals("erbium") || first.getText().equals("Erbium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the village of Ytterby, Sweden. \n"
                +"Say what?  Erbium is pronounced as UR-bee-em. \n"
                            
                +"\n Classification:                   		Erbium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                68 " 
                +"\n Atomic Weight:                  167.259 " 
                +"\n Melting Point:                     1802 K (1529°C or 2784°F) " 
                +"\n Boiling Point:                      3141 K (2868°C or 5194°F) " 
                +"\n Density:                               9.07 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                6 " 
                +"\n Ionization Energy:              6.108 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           68 "
                +"\n Protons:                              68 "
                +"\n Electron shells:                 2,8,18,30,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f12 5s2 5p6 6s2 "
                        , "Erbium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Thulium		69
		if(first.getText().equals("Tm") || first.getText().equals("thulium") || first.getText().equals("Thulium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the earliest name for Scandinavia, Thule. \n"
                +"Say what?  Thulium is pronounced as THOO-lee-em. \n"
                            
                +"\n Classification:                   		Thulium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                69 " 
                +"\n Atomic Weight:                  168.93422 " 
                +"\n Melting Point:                     1818 K (1545°C or 2813°F) " 
                +"\n Boiling Point:                      2223 K (1950°C or 3542°F) " 
                +"\n Density:                               9.32 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              6.184 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           69 "
                +"\n Protons:                              69 "
                +"\n Electron shells:                 2,8,18,30,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f13 5s2 5p6 6s2 "
                        , "Thulium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Ytterbium		70
		if(first.getText().equals("Yb") || first.getText().equals("ytterbium") || first.getText().equals("Ytterbium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the village of Ytterby, Sweden. \n"
                +"Say what?  Ytterbium is pronounced as i-TUR-bee-em. \n"
                            
                +"\n Classification:                   		Ytterbium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                70 " 
                +"\n Atomic Weight:                  173.045 " 
                +"\n Melting Point:                     1092 K (819°C or 1506°F) " 
                +"\n Boiling Point:                      1469 K (1196°C or 2185°F) " 
                +"\n Density:                               6.90 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                7 " 
                +"\n Ionization Energy:              6.254 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           70 "
                +"\n Protons:                              70 "
                +"\n Electron shells:                 2,8,18,32,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f14 5s2 5p6 6s2 "
                        , "Ytterbium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Lutetium		71
		if(first.getText().equals("Lu") || first.getText().equals("lutetium") || first.getText().equals("Lutetium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From an ancient name for the city of Paris, Lutetia. \n"
                +"Say what?  Lutetium is pronounced as loo-TEE-shee-em. \n"
                            
                +"\n Classification:                   			Lutetium is a lanthanide and rare earth metal "
                +"\n Atomic Number:                71 " 
                +"\n Atomic Weight:                  174.9668 " 
                +"\n Melting Point:                     1936 K (1663°C or 3025°F) " 
                +"\n Boiling Point:                      3675 K (3402°C or 6156°F) " 
                +"\n Density:                               9.84 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Lanthanide "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              5.426 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           71 "
                +"\n Protons:                              71 "
                +"\n Electron shells:                 2,8,18,32,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 \n"
                        + "                                                5p6 5d1 6s2 "
                        , "Lutetium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Hafnium		72
		if(first.getText().equals("Hf") || first.getText().equals("hafnium") || first.getText().equals("Hafnium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for the city of Copenhagen, Hafnia. \n"
                +"Say what?  Hafnium is pronounced as HAF-neeem. \n"
                            
                +"\n Classification:                   			Hafnium is a transition metal "
                +"\n Atomic Number:                72 " 
                +"\n Atomic Weight:                  178.49 " 
                +"\n Melting Point:                     2506 K (2233°C or 4051°F) " 
                +"\n Boiling Point:                      4876 K (4603°C or 8317°F) " 
                +"\n Density:                               13.3 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   	silvery  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  4   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              6.825 eV " 
                +"\n Oxidation States:             +4 "
                +"\n Electrons:                           72 "
                +"\n Protons:                              72 "
                +"\n Electron shells:                 2,8,18,32,10,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 \n"
                        + "                                                5p6 5d2 6s2 "
                        , "Hafnium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
			
		//Tantalum		73
		if(first.getText().equals("Ta") || first.getText().equals("tantalum") || first.getText().equals("Tantalum")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Greek mythological figure Tantalus. \n"
                +"Say what?  Tantalum is pronounced as TAN-te-lem. \n"
                            
                +"\n Classification:                   			Tantalum is a transition metal "
                +"\n Atomic Number:                73 " 
                +"\n Atomic Weight:                  180.94788 " 
                +"\n Melting Point:                     3290 K (3017°C or 5463°F) " 
                +"\n Boiling Point:                      5731 K (5458°C or 9856°F) " 
                +"\n Density:                               16.4 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  5   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              7.89 eV " 
                +"\n Oxidation States:             +5 "
                +"\n Electrons:                           73 "
                +"\n Protons:                              73 "
                +"\n Electron shells:                 2,8,18,32,11,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                        + "                                                5s2 5p6 5d3 6s2 "
                        , "Tantalum", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
			
		//Tungsten		74
		if(first.getText().equals("W") || first.getText().equals("tungsten") || first.getText().equals("Tungsten")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Swedish words tung sten, which mean 'heavy stone'. \n"
                + "                                    Tungsten's chemical symbol comes from its eariler, Germanic \n"
                + "                                    name, Wolfram. The name Wolfram comes from the mineral \n"
                + "                                    wolframite, in which it was discovered. Wolframite means 'the \n"
                + "                                    devourer of tin' since the mineral interferes with the smelting \n"
                + "                                    of tin. \n"
                +"Say what?  Tungsten is pronounced as TUNG-sten. \n"
                            
                +"\n Classification:                   			Tungsten is a transition metal "
                +"\n Atomic Number:                74 " 
                +"\n Atomic Weight:                  183.84 " 
                +"\n Melting Point:                     3695 K (3422°C or 6192°F) " 
                +"\n Boiling Point:                      5828 K (5555°C or 10031°F) " 
                +"\n Density:                               19.3 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  6   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2 " 
                +"\n Ionization Energy:              7.98 eV " 
                +"\n Oxidation States:             +6 "
                +"\n Electrons:                           74 "
                +"\n Protons:                              74 "
                +"\n Electron shells:                 2,8,18,32,12,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d4 \n"
                        + "                                                6s2 "
                        , "Tungsten", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		
		//Rhenium		75
		if(first.getText().equals("Re") || first.getText().equals("rhenium") || first.getText().equals("Rhenium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for the Rhine River, Rhenus. \n"
                +"Say what?  Rhenium is pronounced as REE-nee-em. \n"
                            
                +"\n Classification:                   			Rhenium is a transition metal "
                +"\n Atomic Number:                75 " 
                +"\n Atomic Weight:                  186.207 " 
                +"\n Melting Point:                     3459 K (3186°C or 5767°F) " 
                +"\n Boiling Point:                      5869 K (5596°C or 10105°F) " 
                +"\n Density:                               20.8 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  7   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              7.88 eV " 
                +"\n Oxidation States:             +7, +6, +4 "
                +"\n Electrons:                           75 "
                +"\n Protons:                              75 "
                +"\n Electron shells:                 2,8,18,32,13,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f14 5s2 5p6 5d5 6s2 "
                        , "Rhenium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                
                //Osmium		76
		if(first.getText().equals("Os") || first.getText().equals("osmium") || first.getText().equals("Osmium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for a smell, osme. \n"
                +"Say what?  Osmium is pronounced as OZ-mee-em. \n"
                            
                +"\n Classification:                   			Osmium is a transition metal "
                +"\n Atomic Number:                76 " 
                +"\n Atomic Weight:                  190.23 " 
                +"\n Melting Point:                     3306 K (3033°C or 5491°F) " 
                +"\n Boiling Point:                      5285 K (5012°C or 9054°F) " 
                +"\n Density:                               22.57 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		bluish-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  8   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              8.7 eV " 
                +"\n Oxidation States:             +4, +3 "
                +"\n Electrons:                           76 "
                +"\n Protons:                              76 "
                +"\n Electron shells:                 2,8,18,32,14,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f14 5s2 5p6 5d6 6s2 "
                        , "Osmium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Iridium		77
		if(first.getText().equals("Ir") || first.getText().equals("iridium") || first.getText().equals("Iridium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for rainbow, iris. \n"
                +"Say what?  Iridium is pronounced as i-RID-ee-em. \n"
                            
                +"\n Classification:                   			Iridium is a transition metal "
                +"\n Atomic Number:                77 " 
                +"\n Atomic Weight:                  192.217 " 
                +"\n Melting Point:                     2719 K (2446°C or 4435°F) " 
                +"\n Boiling Point:                      4701 K (4428°C or 8002°F) " 
                +"\n Density:                               22.42 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  9   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2 " 
                +"\n Ionization Energy:              9.1 eV " 
                +"\n Oxidation States:             +4, +3 "
                +"\n Electrons:                           77 "
                +"\n Protons:                              77 "
                +"\n Electron shells:                 2,8,18,32,15,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f14 5s2 5p6 5d7 6s2 "
                        , "Iridium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Platinum		78
		if(first.getText().equals("Pt") || first.getText().equals("platinum") || first.getText().equals("Platinum")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Spainsh word for silver, platina. \n"
                +"Say what?  Platinum is pronounced as PLAT-en-em. \n"
                            
                +"\n Classification:                   			Platinum is a transition metal "
                +"\n Atomic Number:                78 " 
                +"\n Atomic Weight:                  195.084 " 
                +"\n Melting Point:                     2041.55 K (1768.4°C or 3215.1°F) " 
                +"\n Boiling Point:                      4098 K (3825°C or 6917°F) " 
                +"\n Density:                               21.46 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  10   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                5 " 
                +"\n Ionization Energy:              9 eV " 
                +"\n Oxidation States:             +4, +2 "
                +"\n Electrons:                           78 "
                +"\n Protons:                              78 "
                +"\n Electron shells:                 2,8,18,32,17,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 \n"
                        + "                                                4d10 4f14 5s2 5p6 5d9 6s1 "
                        , "Platinum", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Gold		79
		if(first.getText().equals("Au") || first.getText().equals("gold") || first.getText().equals("Gold")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Sanskrit word Jval and the Anglo-Saxon word gold. \n"
                +"                                    Gold's chemical symbol comes from the the latin word for gold, \n"
                +"                                    aurum. \n"
                +"Say what?  Gold is pronounced as GOLD. \n"
                            
                +"\n Classification:                   			Gold is a transition metal "
                +"\n Atomic Number:                79 " 
                +"\n Atomic Weight:                  196.966569 " 
                +"\n Melting Point:                     1337.33 K (1064.18°C or 1947.52°F) " 
                +"\n Boiling Point:                      3129 K (2856°C or 5173°F) " 
                +"\n Density:                               19.282 g/cm3 " 
                +"\n State:                                   Solid "
                +"\n Color:                                   		golden yellow  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  11   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                1 " 
                +"\n Ionization Energy:              9.226 eV " 
                +"\n Oxidation States:             +3, +1 "
                +"\n Electrons:                           79 "
                +"\n Protons:                              79 "
                +"\n Electron shells:                 2,8,18,32,18,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 6s1 "
                        , "Gold", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		//Mercury		80
		if(first.getText().equals("Hg") || first.getText().equals("mercury") || first.getText().equals("Mercury")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the planet Mercury. Mercury's chemical symbol comes \n"
                +"                                    from the Greek word hydrargyrum, which means 'liquid silver'. \n"
                +"Say what?  Mercury is pronounced as MER-kyoo-ree. \n"
                            
                +"\n Classification:                   			Mercury is a transition metal "
                +"\n Atomic Number:                80 " 
                +"\n Atomic Weight:                  200.592 " 
                +"\n Melting Point:                     234.32 K (-38.83°C or -37.89°F) " 
                +"\n Boiling Point:                      629.88 K (356.73°C or 674.11°F) " 
                +"\n Density:                               13.5336 g/cm3 " 
                +"\n State:                                   liquid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  12   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                7 " 
                +"\n Ionization Energy:              10.438 eV " 
                +"\n Oxidation States:             +2, +1 "
                +"\n Electrons:                           80 "
                +"\n Protons:                              80 "
                +"\n Electron shells:                 2,8,18,32,18,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 6s2 "
                        , "Mercury", JOptionPane.INFORMATION_MESSAGE);
        	}
			

		//Thallium		81
		if(first.getText().equals("Tl") || first.getText().equals("thallium") || first.getText().equals("Thallium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for a green shoot or twig, thallos. \n"
                +"Say what?  Thallium is pronounced as THAL-ee-em. \n"
                            
                +"\n Classification:                   			Thallium is an ‘other metal’ "
                +"\n Atomic Number:                81 " 
                +"\n Atomic Weight:                  204.384 " 
                +"\n Melting Point:                     577 K (304°C or 579°F) " 
                +"\n Boiling Point:                      1746 K (1473°C or 2683°F) " 
                +"\n Density:                               11.8 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  13   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                2 " 
                +"\n Ionization Energy:              6.108 eV " 
                +"\n Oxidation States:             +3, +1 "
                +"\n Electrons:                           81 "
                +"\n Protons:                              81 "
                +"\n Electron shells:                 2,8,18,32,18,3 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 \n"
                        + "                                                5p6 5d10 6s2 6p1 "
                        , "Thallium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Lead		82
		if(first.getText().equals("Pb") || first.getText().equals("lead") || first.getText().equals("Lead")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Anglo-Saxon word lead. Lead's chemical symbol comes from \n"
                +"                                    the Latin word for waterworks, plumbum. \n"
                +"Say what?  Lead is pronounced as LED. \n"
                            
                +"\n Classification:                   			Lead is an ‘other metal’ "
                +"\n Atomic Number:                82 " 
                +"\n Atomic Weight:                  207.2 " 
                +"\n Melting Point:                     600.61 K (327.46°C or 621.43°F) " 
                +"\n Boiling Point:                      2022 K (1749°C or 3180°F) " 
                +"\n Density:                               11.342 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		bluish gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  14   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                3 " 
                +"\n Ionization Energy:              7.417 eV " 
                +"\n Oxidation States:             +4, +2 "
                +"\n Electrons:                           82 "
                +"\n Protons:                              82 "
                +"\n Electron shells:                 2,8,18,32,18,4 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 \n"
                        + "                                                6s2 6p2 "
                        , "Lead", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Bismuth		83
		if(first.getText().equals("Bi") || first.getText().equals("bismuth") || first.getText().equals("Bismuth")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Anglo-Saxon word lead. Lead's chemical symbol comes from \n"
                +"                                    the Latin word for waterworks, plumbum. \n"
                +"Say what?  Lead is pronounced as LED. \n"
                            
                +"\n Classification:                   			Bismuth is an ‘other metal’ (Radioactive) "
                +"\n Atomic Number:                83 " 
                +"\n Atomic Weight:                  208.98040 " 
                +"\n Melting Point:                     544.55 K (271.40°C or 520.52°F) " 
                +"\n Boiling Point:                      1837 K (1564°C or 2847°F) " 
                +"\n Density:                               9.807 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silver-white  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  15   "
                +"\n Group Name:                      Pnictogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              7.289 eV " 
                +"\n Oxidation States:             +5, +3 "
                +"\n Electrons:                           83 "
                +"\n Protons:                              83 "
                +"\n Electron shells:                 2,8,18,32,18,5 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 \n"
                +"                                                6s2 6p3 "
                        , "Bismuth", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		
		//Bismuth		84
		if(first.getText().equals("Po") || first.getText().equals("polonium") || first.getText().equals("Polonium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the country of Poland. \n"
                +"Say what?  Polonium is pronounced as peh-LOW-nee-em. \n"
                            
                +"\n Classification:                   			Polonium is a chalcogen and a metalloid (Radioactive) "
                +"\n Atomic Number:                84 " 
                +"\n Atomic Weight:                  209 " 
                +"\n Melting Point:                     527 K (254°C or 489°F) " 
                +"\n Boiling Point:                      1235 K (962°C or 1764°F) " 
                +"\n Density:                               9.32 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-gray  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  16   "
                +"\n Group Name:                      Chalcogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              8.417 eV " 
                +"\n Oxidation States:             +4, +2 "
                +"\n Electrons:                           84 "
                +"\n Protons:                              84 "
                +"\n Electron shells:                 2,8,18,32,18,6 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p4 "
                        , "Polonium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Astatine		85
		if(first.getText().equals("At") || first.getText().equals("astatine") || first.getText().equals("Astatine")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for unstable, astatos. \n"
                +"Say what?  Astatine is pronounced as AS-teh-teen or as AS-teh-ten. \n"
                            
                +"\n Classification:                   			Astatine is a halogen and a nonmetal (Radioactive) "
                +"\n Atomic Number:                85 " 
                +"\n Atomic Weight:                  210 " 
                +"\n Melting Point:                     575 K (302°C or 576°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               about 7 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Presumed very dark  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  17   "
                +"\n Group Name:                      Halogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              9.5 eV " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           85 "
                +"\n Protons:                              85 "
                +"\n Electron shells:                 2,8,18,32,18,7 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p5 "
                        , "Astatine", JOptionPane.INFORMATION_MESSAGE);
        	}	
			
			
                
               	//Radon		86
		if(first.getText().equals("Rn") || first.getText().equals("radon") || first.getText().equals("Radon")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the element Radium. \n"
                +"Say what?  Radon is pronounced as RAY-don. \n"
                            
                +"\n Classification:                   			Radon is a noble gas and a nonmetal (Radioactive) "
                +"\n Atomic Number:                86 " 
                +"\n Atomic Weight:                  222 " 
                +"\n Melting Point:                     202 K (-71°C or -96°F) " 
                +"\n Boiling Point:                      211.45 K (-61.7°C or -79.1°F) " 
                +"\n Density:                               0.00973 g/cm3 " 
                +"\n State:                                   gas "
                +"\n Color:                                   		colorless  " 
                +"\n Period Number:                 6     "
                +"\n Group Number:                  18   "
                +"\n Group Name:                      Noble Gas "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              10.745 eV " 
                +"\n Oxidation States:             0 "
                +"\n Electrons:                           86 "
                +"\n Protons:                              86 "
                +"\n Electron shells:                 2,8,18,32,18,8 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p6 "
                        , "Radon", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Francium		87
		if(first.getText().equals("Fr") || first.getText().equals("francium") || first.getText().equals("Francium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the country of France. \n"
                +"Say what?  Francium is pronounced as FRAN-see-em. \n"
                            
                +"\n Classification:                   			Francium is an alkali metal (Radioactive) "
                +"\n Atomic Number:                87 " 
                +"\n Atomic Weight:                  223 " 
                +"\n Melting Point:                     300 K (27°C or 81°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silver-gray-metallic (presumed)  " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  1   "
                +"\n Group Name:                      Alkali Metal "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              3.9 eV " 
                +"\n Oxidation States:             +1 "
                +"\n Electrons:                           87 "
                +"\n Protons:                              87 "
                +"\n Electron shells:                 2,8,18,32,18,8,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p6 7s1 "
                        , "Francium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Radium		88
		if(first.getText().equals("Ra") || first.getText().equals("radium") || first.getText().equals("Radium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for ray, radius. \n"
                +"Say what?  Radium is pronounced as RAY-dee-em. \n"
                            
                +"\n Classification:                   			Radium is an alkali earth metal (Radioactive) "
                +"\n Atomic Number:                88 " 
                +"\n Atomic Weight:                  226 " 
                +"\n Melting Point:                     973 K (700°C or 1292°F) " 
                +"\n Boiling Point:                      1413 K (1140°C or 2084°F) " 
                +"\n Density:                               5 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery white  " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  2   "
                +"\n Group Name:                      Alkaline Earth Metal "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              5.279 eV " 
                +"\n Oxidation States:             +2 "
                +"\n Electrons:                           88 "
                +"\n Protons:                              88 "
                +"\n Electron shells:                 2,8,18,32,18,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p6 7s2 "
                        , "Radium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Actinium		89
		if(first.getText().equals("Ac") || first.getText().equals("actinium") || first.getText().equals("Actinium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for a beam or ray, aktis. \n"
                +"Say what?  Actinium is pronounced as ak-TIN-ee-em. \n"
                            
                +"\n Classification:                   			Actinium is an actinide metal (Radioactive) "
                +"\n Atomic Number:                89 " 
                +"\n Atomic Weight:                  227 " 
                +"\n Melting Point:                     1324 K (1051°C or 1924°F) " 
                +"\n Boiling Point:                      3471 K (3198°C or 5788°F) " 
                +"\n Density:                               10.07 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white  " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              5.17 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           89 "
                +"\n Protons:                              89 "
                +"\n Electron shells:                 2,8,18,32,18,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p6 6d1 7s2 "
                        , "Actinium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Thorium		90
		if(first.getText().equals("Th") || first.getText().equals("thorium") || first.getText().equals("Thorium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Scandinavian god of war, Thor. \n"
                +"Say what?  Thorium is pronounced as THOR-ee-em or as THO-ree-em. \n"
                            
                +"\n Classification:                   			Thorium is an actinide metal (Radioactive) "
                +"\n Atomic Number:                90 " 
                +"\n Atomic Weight:                  232.0377 " 
                +"\n Melting Point:                     2023 K (1750°C or 3182°F) " 
                +"\n Boiling Point:                      5061 K (4788°C or 8650°F) " 
                +"\n Density:                               11.72 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.08 eV " 
                +"\n Oxidation States:             +4 "
                +"\n Electrons:                           90 "
                +"\n Protons:                              90 "
                +"\n Electron shells:                 2,8,18,32,18,10,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 6s2 6p6 6d2 7s2 "
                        , "Thorium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Protactinium		91
		if(first.getText().equals("Pa") || first.getText().equals("protactinium") || first.getText().equals("Protactinium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Greek word for first, protos, and the element actinium, \n"
                +"                                     which together mean 'the parent of actinium'. \n"
                +"Say what?  Protactinium is pronounced as PRO-tak-TIN-ee-em. \n"
                            
                +"\n Classification:                   			Protactinium is an actinide metal (Radioactive) "
                +"\n Atomic Number:                91 " 
                +"\n Atomic Weight:                  231.03588 " 
                +"\n Melting Point:                     1845 K (1572°C or 2862°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               15.37 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              5.89 eV " 
                +"\n Oxidation States:             +5, +4 "
                +"\n Electrons:                           91 "
                +"\n Protons:                              91 "
                +"\n Electron shells:                 2,8,18,32,20,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 5f2 6s2 6p6 6d1 7s2 "
                        , "Protactinium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Uranium		92
		if(first.getText().equals("U") || first.getText().equals("uranium") || first.getText().equals("Uranium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the planet Uranus. \n"
                +"Say what?  Uranium is pronounced as you-RAY-nee-em. \n"
                            
                +"\n Classification:                   			Uranium is an actinide metal (Radioactive) "
                +"\n Atomic Number:                92 " 
                +"\n Atomic Weight:                  238.02891 " 
                +"\n Melting Point:                     1408 K (1135°C or 2075°F) " 
                +"\n Boiling Point:                      4404 K (4131°C or 7468°F) " 
                +"\n Density:                               18.95 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.194 eV " 
                +"\n Oxidation States:             +6, +5, +4, +3 "
                +"\n Electrons:                           92 "
                +"\n Protons:                              92 "
                +"\n Electron shells:                 2,8,18,32,21,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 \n"
                +"                                                5s2 5p6 5d10 5f3 6s2 6p6 6d1 7s2 "
                        , "Uranium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Neptunium		93
		if(first.getText().equals("Np") || first.getText().equals("neptunium") || first.getText().equals("Neptunium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the planet Neptune. \n"
                +"Say what?  Neptunium is pronounced as nep-TOO-nee-em. \n"
                            
                +"\n Classification:                   			Neptunium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                93 " 
                +"\n Atomic Weight:                  237 " 
                +"\n Melting Point:                     917 K (644°C or 1191°F) " 
                +"\n Boiling Point:                      4175 K (3902°C or 7056°F) " 
                +"\n Density:                               20.25 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.266 eV " 
                +"\n Oxidation States:             +6, +5, +4, +3 "
                +"\n Electrons:                           93 "
                +"\n Protons:                              93 "
                +"\n Electron shells:                 2,8,18,32,23,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f4 6s2 \n"
                +"                                                6p6 6d1 7s2 "
                        , "Neptunium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Plutonium		94
		if(first.getText().equals("Pu") || first.getText().equals("plutonium") || first.getText().equals("Plutonium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the dwarf planet Pluto. \n"
                +"Say what?  Plutonium is pronounced as ploo-TOE-nee-em. \n"
                            
                +"\n Classification:                   			Plutonium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                94 " 
                +"\n Atomic Weight:                  244 " 
                +"\n Melting Point:                     913 K (640°C or 1184°F) " 
                +"\n Boiling Point:                      3501 K (3228°C or 5842°F) " 
                +"\n Density:                               19.84 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.06 eV " 
                +"\n Oxidation States:             +6, +5, +4, +3 "
                +"\n Electrons:                           94 "
                +"\n Protons:                              94 "
                +"\n Electron shells:                 2,8,18,32,24,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f6 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Plutonium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Americium		95
		if(first.getText().equals("Am") || first.getText().equals("americium") || first.getText().equals("Americium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Americas. \n"
                +"Say what?  Americium is pronounced as am-er-ISH-ee-em. \n"
                            
                +"\n Classification:                   			Americium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                95 " 
                +"\n Atomic Weight:                  243 " 
                +"\n Melting Point:                     1449 K (1176°C or 2149°F) " 
                +"\n Boiling Point:                      2284 K (2011°C or 3652°F) " 
                +"\n Density:                               13.69 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              5.993 eV " 
                +"\n Oxidation States:             +6, +5, +4, +3 "
                +"\n Electrons:                           95 "
                +"\n Protons:                              95 "
                +"\n Electron shells:                 2,8,18,32,25,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f7 \n"
                +"                                                6s2 6p6 7s2 "
                        , "Americium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		 
		//Curium		96
		if(first.getText().equals("Cm") || first.getText().equals("curium") || first.getText().equals("Curium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientists Pierre and Marie Curie. \n"
                +"Say what?  Curium is pronounced as KYOOR-ee-em. \n"
                            
                +"\n Classification:                   			Curium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                96 " 
                +"\n Atomic Weight:                  247 " 
                +"\n Melting Point:                     1618 K (1345°C or 2453°F) " 
                +"\n Boiling Point:                      ~3400 K (~3100°C or ~5600°F) " 
                +"\n Density:                               13.51 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.02 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           96 "
                +"\n Protons:                              96 "
                +"\n Electron shells:                 2,8,18,32,25,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f7 6s2 \n"
                +"                                                6p6 6d1 7s2 "
                        , "Curium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Berkelium		97
		if(first.getText().equals("Bk") || first.getText().equals("berkelium") || first.getText().equals("Berkelium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the city of Berkeley, California. \n"
                +"Say what?  Berkelium is pronounced as BURK-lee-em. \n"
                            
                +"\n Classification:                   			Berkelium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                97 " 
                +"\n Atomic Weight:                  247 " 
                +"\n Melting Point:                     1323 K (1050°C or 1922°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               14 g/cm3 " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.23 eV " 
                +"\n Oxidation States:             +4, +3 "
                +"\n Electrons:                           97 "
                +"\n Protons:                              97 "
                +"\n Electron shells:                 2,8,18,32,27,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f9 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Berkelium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Californium		98
		if(first.getText().equals("Cf") || first.getText().equals("californium") || first.getText().equals("Californium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the state and University of California. \n"
                +"Say what?  Californium is pronounced as kal-eh-FOR-nee-em. \n"
                            
                +"\n Classification:                   			Californium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                98 " 
                +"\n Atomic Weight:                  251 " 
                +"\n Melting Point:                     1173 K (900°C or 1652°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		silvery-white " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.30 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           98 "
                +"\n Protons:                              98 "
                +"\n Electron shells:                 2,8,18,32,28,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f10 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Californium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Einsteinium		99
		if(first.getText().equals("Es") || first.getText().equals("einsteinium") || first.getText().equals("Einsteinium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Albert Einstein. \n"
                +"Say what?  Einsteinium is pronounced as ine-STINE-ee-em. \n"
                            
                +"\n Classification:                   			Einsteinium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                99 " 
                +"\n Atomic Weight:                  252 " 
                +"\n Melting Point:                     1133 K (860°C or 1580°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.42 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           99 "
                +"\n Protons:                              99 "
                +"\n Electron shells:                 2,8,18,32,29,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f11 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Einsteinium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Fermium		100
		if(first.getText().equals("Fm") || first.getText().equals("fermium") || first.getText().equals("Fermium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Enrico Fermi. \n"
                +"Say what?  Fermium is pronounced as FER-mee-em. \n"
                            
                +"\n Classification:                   			Fermium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                100 " 
                +"\n Atomic Weight:                  257 " 
                +"\n Melting Point:                     1800 K (1527°C or 2781°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.50 eV " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           100 "
                +"\n Protons:                              100 "
                +"\n Electron shells:                 2,8,18,32,30,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f12 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Fermium", JOptionPane.INFORMATION_MESSAGE);
        	}		
			
			
			
		//Mendelevium		101
		if(first.getText().equals("Md") || first.getText().equals("mendelevium") || first.getText().equals("Mendelevium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the Russian chemist Dmitri Mendeleyev. \n"
                +"Say what?  Mendelevium is pronounced as men-deh-LEE-vee-em. \n"
                            
                +"\n Classification:                   			Mendelevium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                101 " 
                +"\n Atomic Weight:                  258 " 
                +"\n Melting Point:                     1100 K (827°C or 1521°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.58 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           101 "
                +"\n Protons:                              101 "
                +"\n Electron shells:                 2,8,18,32,31,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f13 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Mendelevium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Nobelium		102
		if(first.getText().equals("No") || first.getText().equals("nobelium") || first.getText().equals("Nobelium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Alfred Nobel. \n"
                +"Say what?  Nobelium is pronounced as no-BELL-ee-em. \n"
                            
                +"\n Classification:                   			Nobelium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                102 " 
                +"\n Atomic Weight:                  259 " 
                +"\n Melting Point:                     1100 K (827°C or 1520°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  none   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              6.65 eV " 
                +"\n Oxidation States:             +3, +2 "
                +"\n Electrons:                           102 "
                +"\n Protons:                              102 "
                +"\n Electron shells:                 2,8,18,32,32,8,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 6s2 \n"
                +"                                                6p6 7s2 "
                        , "Nobelium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
		
		//Lawrencium		103
		if(first.getText().equals("Lr") || first.getText().equals("lawrencium") || first.getText().equals("Lawrencium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Ernest O. Lawrence. \n"
                +"Say what?  Lawrencium is pronounced as lor-ENS-ee-em. \n"
                            
                +"\n Classification:                   			Lawrencium is an actinide metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                103 " 
                +"\n Atomic Weight:                  262 " 
                +"\n Melting Point:                     1900 K (1627°C or 2961°F) " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  3   "
                +"\n Group Name:                      Actinide "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             +3 "
                +"\n Electrons:                           103 "
                +"\n Protons:                              103 "
                +"\n Electron shells:                 2,8,18,32,32,9,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 6s2 \n"
                +"                                                6p6 6d1 7s2 "
                        , "Lawrencium", JOptionPane.INFORMATION_MESSAGE);
        	}	
			
			
		//Rutherfordium		104
		if(first.getText().equals("Rf") || first.getText().equals("rutherfordium") || first.getText().equals("Rutherfordium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Ernest Rutherford. \n"
                +"Say what?  Rutherfordium is pronounced as ruth-er-FORD-ee-em. \n"
                            
                +"\n Classification:                   			Rutherfordium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                104 " 
                +"\n Atomic Weight:                  263 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  4   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             +4 "
                +"\n Electrons:                           104 "
                +"\n Protons:                              104 "
                +"\n Electron shells:                 2,8,18,32,32,10,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 6s2 \n"
                        + "                                                6p6 6d2 7s2 "
                        , "Rutherfordium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Dubnium		105
		if(first.getText().equals("Db") || first.getText().equals("dubnium") || first.getText().equals("Dubnium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Joint Institute for Nuclear Research at Dubna, Russia. \n"
                +"Say what?  Dubnium is pronounced as DUB-nee-em. \n"
                            
                +"\n Classification:                   			Dubnium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                105 " 
                +"\n Atomic Weight:                  268 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  5   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           105 "
                +"\n Protons:                              105 "
                +"\n Electron shells:                 2,8,18,32,32,11,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 \n"
                        + "                                                6s2 6p6 6d3 7s2 "
                        , "Dubnium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Seaborgium		106
		if(first.getText().equals("Sg") || first.getText().equals("seaborgium") || first.getText().equals("Seaborgium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Joint Institute for Nuclear Research at Dubna, Russia. \n"
                +"Say what?  Dubnium is pronounced as DUB-nee-em. \n"
                            
                +"\n Classification:                   			Seaborgium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                106 " 
                +"\n Atomic Weight:                  271 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  6   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           106 "
                +"\n Protons:                              106 "
                +"\n Electron shells:                 2,8,18,32,32,12,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 \n"
                        + "                                                6s2 6p6 6d4 7s2 "
                        , "Seaborgium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Seaborgium		107
		if(first.getText().equals("Bh") || first.getText().equals("bohrium") || first.getText().equals("Bohrium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Niels Bohr. \n"
                +"Say what?  Bohrium is pronounced as BORE-ee-em. \n"
                            
                +"\n Classification:                   			Bohrium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                107 " 
                +"\n Atomic Weight:                  270 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		steel gray presumed " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  7   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           107 "
                +"\n Protons:                              107 "
                +"\n Electron shells:                 2,8,18,32,32,13,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 \n"
                        + "                                                6s2 6p6 6d5 7s2 "
                        , "Bohrium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Hassium		108
		if(first.getText().equals("Hs") || first.getText().equals("hassium") || first.getText().equals("Hassium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  From the Latin word for the German state of Hessen, Hassias. \n"
                +"Say what?  Hassium is pronounced as HAS-ee-em. \n"
                            
                +"\n Classification:                   			Hassium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                108 " 
                +"\n Atomic Weight:                  270 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  8   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           108 "
                +"\n Protons:                              108 "
                +"\n Electron shells:                 2,8,18,32,32,14,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 \n"
                        + "                                                6s2 6p6 6d6 7s2 "
                        , "Hassium", JOptionPane.INFORMATION_MESSAGE);
        	}	
			
		
                //Meitnerium		109
		if(first.getText().equals("Mt") || first.getText().equals("meitnerium") || first.getText().equals("Meitnerium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Lise Meitner. \n"
                +"Say what?  Meitnerium is pronounced as met-NEAR-ee-um. \n"
                            
                +"\n Classification:                   			Meitnerium is a transition metal \n"
                + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                109 " 
                +"\n Atomic Weight:                  278 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  9   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           109 "
                +"\n Protons:                              109 "
                +"\n Electron shells:                 2,8,18,32,32,14,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f14 5s2 5p6 5d10 5f14 6s2 6p6 6d7 7s2 "
                        , "Meitnerium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Darmstadtium		110
		if(first.getText().equals("Ds") || first.getText().equals("darmstadtium") || first.getText().equals("Darmstadtium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the city of Darmstadt, Germany. \n"
                +"Say what?  Darmstadtium is pronounced as darm-STADT-ee-em. \n"
                            
                +"\n Classification:                   			Darmstadtium is a transition metal \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                110 " 
                +"\n Atomic Weight:                  281 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  10   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           110 "
                +"\n Protons:                              110 "
                +"\n Electron shells:                 2,8,18,32,32,17,1 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f14 5s2 5p6 5d10 5f14 6s2 6p6 6d9 7s1 "
                        , "Darmstadtium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Roentgenium		111
		if(first.getText().equals("Rg") || first.getText().equals("roentgenium") || first.getText().equals("Roentgenium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Wilhelm Conrad Röentgen. \n"
                +"Say what?  Roentgenium is pronounced as RENT-ghen-ee-em. \n"
                            
                +"\n Classification:                   			Roentgenium is a transition metal \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                111 " 
                +"\n Atomic Weight:                  281 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  11   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           111 "
                +"\n Protons:                              111 "
                +"\n Electron shells:                 2,8,18,32,32,17,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 \n"
                        + "                                                4f14 5s2 5p6 5d10 5f14 6s2 6p6 6d10 7s1 "
                        , "Roentgenium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Copernicium		112
		if(first.getText().equals("Cn") || first.getText().equals("copernicium") || first.getText().equals("Copernicium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the astronomer and mathematician Nicolaus Copernicus. \n"
                +"Say what?  Copernicium is pronounced as kogh-per-NEE-see-em. \n"
                            
                +"\n Classification:                   			Copernicium is a transition metal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                112 " 
                +"\n Atomic Weight:                  285 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  12   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           112 "
                +"\n Protons:                              112 "
                +"\n Electron shells:                 2,8,18,32,32,18,2 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 5d10 5f14 6s2 \n"
                        + "                                                6p6 6d10 7s2 "
                        , "Copernicium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Nihonium / Ununtrium		113
		if(first.getText().equals("Nh") || first.getText().equals("nihonium") || first.getText().equals("Nihonium") || first.getText().equals("Uut") || first.getText().equals("ununtrium") || first.getText().equals("Ununtrium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the country of Japan. \n"
                +"Say what?  Nihonium is pronounced as nee-hone-ee-em. \n"
                            
                +"\n Classification:                   			Nihonium / Ununtrium is an ‘other metal’ (presumed) \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                113 " 
                +"\n Atomic Weight:                  286 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  13   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           113 "
                +"\n Protons:                              113 "
                +"\n Electron shells:                 2,8,18,32,32,18,3 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 5f14 6s2 6p6 6d10 7s2 7p1 "
                        , "Nihonium / Ununtrium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Flerovium		114
		if(first.getText().equals("Fl") || first.getText().equals("flerovium") || first.getText().equals("Flerovium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named in honor of the Flerov Laboratory of Nuclear Reactions. \n"
                +"Say what?  Flerovium is pronounced as flee-ROVE-ee-em. \n"
                            
                +"\n Classification:                   			Flerovium is an ‘other metal’ (presumed) \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                114 " 
                +"\n Atomic Weight:                  289 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  14   "
                +"\n Group Name:                      none "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           114 "
                +"\n Protons:                              114 "
                +"\n Electron shells:                 2,8,18,32,32,18,4 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 5f14 6s2 6p6 6d10 7s2 7p2 "
                        , "Flerovium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
	
		//Moscovium / Ununpentium		115
		if(first.getText().equals("Mc") || first.getText().equals("moscovium") || first.getText().equals("Moscovium") || first.getText().equals("Uup") || first.getText().equals("ununpentium") || first.getText().equals("Ununpentium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the Moscow region of Russia. \n"
                +"Say what?  Moscovium is pronounced as moss-KO-vee-um. \n"
                            
                +"\n Classification:                   			Moscovium / Ununpentium is an ‘other metal’ (presumed) \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                115 " 
                +"\n Atomic Weight:                  289 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  15   "
                +"\n Group Name:                      Pnictogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           115 "
                +"\n Protons:                              115 "
                +"\n Electron shells:                 2,8,18,32,32,18,5 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 5f14 6s2 6p6 6d10 7s2 7p3 "
                        , "Moscovium / Ununpentium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Livermorium		116
		if(first.getText().equals("Lv") || first.getText().equals("livermorium") || first.getText().equals("Livermorium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named in honor of the Lawrence Livermore National Laboratory. \n"
                +"Say what?  Livermorium is pronounced as liv-er-MORE-ee-em. \n"
                            
                +"\n Classification:                   			Livermorium is an ‘other metal’ (presumed) \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                116 " 
                +"\n Atomic Weight:                  293 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  16   "
                +"\n Group Name:                      Chalcogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           116 "
                +"\n Protons:                              116 "
                +"\n Electron shells:                 2,8,18,32,32,18,6 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 5f14 6s2 6p6 6d10 7s2 7p4 "
                        , "Livermorium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
		//Tennessine / Ununseptium		117
		if(first.getText().equals("Ts") || first.getText().equals("tennessine") || first.getText().equals("Tennessine") || first.getText().equals("Uus") || first.getText().equals("ununseptium") || first.getText().equals("Ununseptium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named for the state of Tennessee. \n"
                +"Say what?  Tennessine is pronounced as TEN-ess-een. \n"
                            
                +"\n Classification:                   			Tennessine / Ununseptium is a halogen (presumed) \n"
                        + "                                               (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                117" 
                +"\n Atomic Weight:                  294 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Solid "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  17   "
                +"\n Group Name:                      Halogen "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           117 "
                +"\n Protons:                              117 "
                +"\n Electron shells:                 2,8,18,32,32,18,7 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 \n"
                        + "                                                5p6 5d10 5f14 6s2 6p6 6d10 7s2 7p5 "
                        , "Tennessine / Ununseptium", JOptionPane.INFORMATION_MESSAGE);
        	}
			
			
			
		//Oganesson / Ununoctium		118
		if(first.getText().equals("Og") || first.getText().equals("oganesson") || first.getText().equals("Oganesson") || first.getText().equals("Uuo") || first.getText().equals("ununoctium") || first.getText().equals("Ununoctium")){
			JOptionPane.showMessageDialog(null,  
                "What's in a name?  Named after the scientist Yuri Oganessian. \n"
                +"Say what?  Oganesson is pronounced as oh-gan-ess-on. \n"
                            
                +"\n Classification:                   			Oganesson / Ununoctium is a noble gas (or a noble solid?) \n"
                        + "                                               and a nonmetal (Radioactive and Artificially Produced) "
                +"\n Atomic Number:                118" 
                +"\n Atomic Weight:                  294 " 
                +"\n Melting Point:                     Unknown " 
                +"\n Boiling Point:                      Unknown " 
                +"\n Density:                               Unknown " 
                +"\n State:                                   Expected to be a Gas "
                +"\n Color:                                   		Unknown " 
                +"\n Period Number:                 7     "
                +"\n Group Number:                  18   "
                +"\n Group Name:                      Noble Gas "
                +"\n Stable Isotopes:                0 " 
                +"\n Ionization Energy:              Unknown " 
                +"\n Oxidation States:             Unknown "
                +"\n Electrons:                           118 "
                +"\n Protons:                              118 "
                +"\n Electron shells:                 2,8,18,32,32,18,8 "
                +"\n Electron configuration:    1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 4d10 4f14 5s2 5p6 \n"
                        + "                                                5d10 5f14 6s2 6p6 6d10 7s2 7p6 "
                        , "Oganesson / Ununoctium", JOptionPane.INFORMATION_MESSAGE);
        	}
                
                //END....................................................!
                
        }
        
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
          
        //History of Element Button
        if(ob==b5){
        	
        	//Hydrogen      1
        	if(first.getText().equals("H") || first.getText().equals("hydrogen") || first.getText().equals("Hydrogen")){
        		JOptionPane.showMessageDialog(null,
        				   "        Scientists had been producing hydrogen for years before it was recognized as an element. \n "
        				  + "Written records indicate that Robert Boyle produced hydrogen gas as early as 1671 while \n "
        				  + "experimenting with iron and acids. Hydrogen was first recognized as a distinct element \n"
        				  + " by Henry Cavendish in 1766. \n"
        				  + "Composed of a single proton and a single electron, hydrogen is the simplest and most \n "
        				  + "abundant element in the universe. It is estimated that 90% of the visible universe is \n"
        				  + " composed of hydrogen. \n"
        				  + "Hydrogen is the raw fuel that most stars 'burn' to produce energy. The same process, \n "
        				  + "known as fusion, is being studied as a possible power source for use on earth. The sun's \n "
        				  + "supply of hydrogen is expected to last another 5 billion years. \n"
        				  + "Hydrogen is a commercially important element. Large amounts of hydrogen are combined with \n"
        				  + " nitrogen from the air to produce ammonia (NH3) through a process called the Haber process. \n"
        				  + " Hydrogen is also added to fats and oils, such as peanut oil, through a process called \n "
        				  + "hydrogenation. Liquid hydrogen is used in the study of superconductors and, when combined \n "
        				  + "with liquid oxygen, makes an excellent rocket fuel. \n"
        				  + "Hydrogen combines with other elements to form numerous compounds. Some of the common ones \n"
        				  + " are: water (H2O), ammonia (NH3), methane (CH4), table sugar (C12H22O11), hydrogen peroxide (H2O2) \n "
        				  + "and hydrochloric acid (HCl). \n"
        				  + "Hydrogen has three common isotopes. The simplest isotope, called protium, is just ordinary \n "
        				  + "hydrogen. The second, a stable isotope called deuterium, was discovered in 1932. The third \n"
        				  + "isotope, tritium, was discovered in 1934. \n"
        				, "History & Uses of Hydrogen", JOptionPane.INFORMATION_MESSAGE);
        	}

        	//Helium        2
        	if(first.getText().equals("He") || first.getText().equals("helium") || first.getText().equals("Helium")){
        		JOptionPane.showMessageDialog(null,
        				    "         Helium, the second most abundant element in the universe, was discovered on the sun before it was  \n "
        				  + "found on the earth. Pierre-Jules-CÃ©sar Janssen, a French astronomer, noticed a yellow line in the sun's \n"
        				  + " spectrum while studying a total solar eclipse in 1868. Sir Norman Lockyer, an English astronomer, \n"
        				  + " realized that this line, with a wavelength of 587.49 nanometers, could not be produced by any element \n"
        				  + " known at the time. It was hypothesized that a new element on the sun was responsible for this mysterious \n"
        				  + " yellow emission. This unknown element was named helium by Lockyer.The hunt to find helium on earth ended \n "
        				  + "in 1895. Sir William Ramsay, a Scottish chemist, conducted an experiment with a mineral containing \n "
        				  + "uranium called clevite. He exposed the clevite to mineral acids and collected the gases that were produced.\n "
        				  + " He then sent a sample of these gases to two scientists, Lockyer and Sir William Crookes, who were able to \n"
        				  + " identify the helium within it. Two Swedish chemists, Nils Langlet and Per Theodor Cleve, independently \n "
        				  + "found helium in clevite at about the same time as Ramsay. \n"
        				  + "Helium makes up about 0.0005% of the earth's atmosphere. This trace amount of helium is not gravitationally \n"
        				  + " bound to the earth and is constantly lost to space. The earth's atmospheric helium is replaced by the decay \n "
        				  + "of radioactive elements in the earth's crust. Alpha decay, one type of radioactive decay, produces particles \n "
        				  + "called alpha particles. An alpha particle can become a helium atom once it captures two electrons from its \n"
        				  + " surroundings. This newly formed helium can eventually work its way to the atmosphere through cracks in the crust. \n"
        				  + ""
        				  + "Helium is commercially recovered from natural gas deposits, mostly from Texas, Oklahoma and Kansas. Helium gas \n "
        				  + " is used to inflate blimps, scientific balloons and party balloons. It is used as an inert shield for arc welding,\n "
        				  + "to pressurize the fuel tanks of liquid fueled rockets and in supersonic windtunnels. Helium is combined with \n"
        				  + " oxygen to create a nitrogen free atmosphere for deep sea divers so that they will not suffer from a condition \n"
        				  + " known as nitrogen narcosis. Liquid helium is an important cryogenic material and is used to study \n "
        				  + "superconductivity and to create superconductive magnets. The Department of Energy's Jefferson Lab uses large \n"
        				  + " amounts of liquid helium to operate its superconductive electron accelerator. \n"
        				  + "Helium is an inert gas and does not easily combine with other elements. There are no known compounds that \n "
        				  + "contain helium, although attempts are being made to produce helium diflouride (HeF2). \n"
        				  , "History & Uses of Helium", JOptionPane.INFORMATION_MESSAGE);
        	}

                //Lithium       3
                if(first.getText().equals("Li") || first.getText().equals("lithium") || first.getText().equals("Lithium")){
        		JOptionPane.showMessageDialog(null,
        				    "           Lithium was discovered in the mineral petalite (LiAl(Si2O5)2) by Johann August Arfvedson in 1817. \n"
                                                    + " It was first isolated by William Thomas Brande and Sir Humphrey Davy through the electrolysis of lithium oxide (Li2O). \n"
                                                    + " Today, larger amounts of the metal are obtained through the electrolysis of lithium chloride (LiCl). Lithium is not \n "
                                                    + "found free in nature and makes up only 0.0007% of the earth's crust. \n" 
                                                    +"Many uses have been found for lithium and its compounds. Lithium has the highest specific heat of any solid element \n "
                                                    + "and is used in heat transfer applications. It is used to make special glasses and ceramics, including the Mount \n "
                                                    + "Palomar telescope's 200 inch mirror. Lithium is the lightest known metal and can be alloyed with aluminium, copper, \n "
                                                    + "manganese, and cadmium to make strong, lightweight metals for aircraft. Lithium hydroxide (LiOH) is used to remove \n "
                                                    + "carbon dioxide from the atmosphere of spacecraft. Lithium stearate (LiC18H35O2) is used as a general purpose and high \n "
                                                    + "temperature lubricant. Lithium carbonate (Li2CO3) is used as a drug to treat manic depression disorder.\n" 
                                                    +"Lithium reacts with water, but not as violently as sodium. \n"
        				  , "History & Uses of Lithium", JOptionPane.INFORMATION_MESSAGE);
        	}

                //Beryllium         4
                if(first.getText().equals("Be") || first.getText().equals("beryllium") || first.getText().equals("Beryllium")){
        		JOptionPane.showMessageDialog(null,
        				    "            Although emeralds and beryl were known to ancient civilizations, they were first recognized as the same mineral (Be3Al2(SiO3)6) \n"
                                                    + " by Abbé Haüy in 1798. Later that year, Louis-Nicholas Vauquelin, a French chemist, discovered that an unknown element was present \n"
                                                    + " in emeralds and beryl. Attempts to isolate the new element finally succeeded in 1828 when two chemists, Friedrich Wölhler of \n "
                                                    + "Germany and A. Bussy of France, independently produced beryllium by reducing beryllium chloride (BeCl2) with potassium in a platinum \n"
                                                    + " crucible. Today, beryllium is primarily obtained from the minerals beryl (Be3Al2(SiO3)6) and bertrandite (4BeO·2SiO2·H2O) through a \n"
                                                    + " chemical process or through the electrolysis of a mixture of molten beryllium chloride (BeCl2) and sodium chloride (NaCl).\n" 
                                                    +"Beryllium is relatively transparent to X-rays and is used to make windows for X-ray tubes. When exposed to alpha particles, such as \n "
                                                    + "those emitted by radium or polonium, beryllium emits neutrons and is used as a neutron source. Beryllium is also used as a moderator \n "
                                                    + "in nuclear reactors.\n" 
                                                    +"Beryllium is alloyed with copper (2% beryllium, 98% copper) to form a wear resistant material, known as beryllium bronze, used in \n "
                                                    + "gyroscopes and other devices where wear resistance is important. Beryllium is alloyed with nickel (2% beryllium, 98% nickel) to \n "
                                                    + "make springs, spot-welding electrodes and non-sparking tools. Other beryllium alloys are used in the windshield, brake disks and \n "
                                                    + "other structural components of the space shuttle.\n" 
                                                    +"Beryllium oxide (BeO), a compound of beryllium, is used in the nuclear industry and in ceramics.\n" 
                                                    +"Beryllium was once known as glucinum, which means sweet, since beryllium and many of its compounds have a sugary taste. \n "
                                                    + "Unfortunately for the chemists that discovered this particular property, beryllium and many of its compounds are poisonous and \n "
                                                    + "should never be tasted or ingested. \n"
        				  , "History & Uses of Beryllium", JOptionPane.INFORMATION_MESSAGE);
        	}

                //Boron     5
                if(first.getText().equals("B") || first.getText().equals("boron") || first.getText().equals("Boron")){
        		JOptionPane.showMessageDialog(null,
        				    "            Boron was discovered by Joseph-Louis Gay-Lussac and Louis-Jaques Thénard, French chemists, and independently by Sir Humphry Davy, \n"
                                                    + " an English chemist, in 1808. They all isolated boron by combining boric acid (H3BO3) with potassium. Today, boron is obtained by \n "
                                                    + "heating borax (Na2B4O7·10H2O) with carbon, although other methods are used if high-purity boron is required.\n" 
                                                    +"Boron is used in pyrotechnics and flares to produce a green color. Boron has also been used in some rockets as an ignition source. \n"
                                                    + " Boron-10, one of the naturally occurring isotopes of boron, is a good absorber of neutrons and is used in the control rods of \n "
                                                    + "nuclear reactors, as a radiation shield and as a neutron detector. Boron filaments are used in the aerospace industry because of \n "
                                                    + "their high-strength and lightweight.\n" 
                                                    +"Boron forms several commercially important compounds. The most important boron compound is sodium borate pentahydrate (Na2B4O7·5H2O). \n"
                                                    + " Large amounts of this compound are used in the manufacture of fiberglass insulation and sodium perborate bleach. The second most \n"
                                                    + " important compound is boric acid (H3BO3), which is used to manufacture textile fiberglass and is used in cellulose insulation \n "
                                                    + "as a flame retardant. Sodium borate decahydrate (Na2B4O7·10H2O), better known as borax, is the third most important boron compound. \n "
                                                    + "Borax is used in laundry products and as a mild antiseptic. Borax is also a key ingredient in a substance known as Oobleck, a \n"
                                                    + " strange material 6th grade students experiment with while participating in Jefferson Lab's BEAMS program. Other boron compounds \n "
                                                    + "are used to make borosilicate glasses, enamels for covering steel and as a potential medicine for treating arthritis. \n"
        				  , "History & Uses of Boron", JOptionPane.INFORMATION_MESSAGE);
                }

                //Carbon        6
                if(first.getText().equals("C") || first.getText().equals("carbon") || first.getText().equals("Carbon")){
        		JOptionPane.showMessageDialog(null,
        				"             Carbon, the sixth most abundant element in the universe, has been known since ancient times. Carbon is most commonly obtained from coal deposits, although it usually \n"
                                                + " must be processed into a form suitable for commercial use. Three naturally occurring allotropes of carbon are known to exist: amorphous, graphite and diamond.\n" 
                                                + "Amorphous carbon is formed when a material containing carbon is burned without enough oxygen for it to burn completely. This black soot, also known as lampblack, gas black, \n"
                                                + " channel black or carbon black, is used to make inks, paints and rubber products. It can also be pressed into shapes and is used to form the cores of most dry cell batteries, \n"
                                                + " among other things.\n" 
                                                + "Graphite, one of the softest materials known, is a form of carbon that is primarily used as a lubricant. Although it does occur naturally, most commercial graphite is produced \n"
                                                + " by treating petroleum coke, a black tar residue remaining after the refinement of crude oil, in an oxygen-free oven. Naturally occurring graphite occurs in two forms, alpha \n "
                                                + "and beta. These two forms have identical physical properties but different crystal structures. All artificially produced graphite is of the alpha type. In addition to its use \n "
                                                + "as a lubricant, graphite, in a form known as coke, is used in large amounts in the production of steel. Coke is made by heating soft coal in an oven without allowing oxygen to \n"
                                                + " mix with it. Although commonly called lead, the black material used in pencils is actually graphite.\n" 
                                                + "Diamond, the third naturally occurring form of carbon, is one of the hardest substances known. Although naturally occurring diamond is typically used for jewelry, most commercial \n"
                                                + " quality diamonds are artificially produced. These small diamonds are made by squeezing graphite under high temperatures and pressures for several days or weeks and are primarily \n"
                                                + " used to make things like diamond tipped saw blades. Although they posses very different physical properties, graphite and diamond differ only in their crystal structure.\n" 
                                                + "A fourth allotrope of carbon, known as white carbon, was produced in 1969. It is a transparent material that can split a single beam of light into two beams, a property known as \n "
                                                + "birefringence. Very little is known about this form of carbon.\n" 
                                                + "Large molecules consisting only of carbon, known as buckminsterfullerenes, or buckyballs, have recently been discovered and are currently the subject of much scientific interest. \n"
                                                + " A single buckyball consists of 60 or 70 carbon atoms (C60 or C70) linked together in a structure that looks like a soccer ball. They can trap other atoms within their framework, \n "
                                                + "appear to be capable of withstanding great pressures and have magnetic and superconductive properties.\n" 
                                                + "Carbon-14, a radioactive isotope of carbon with a half-life of 5,730 years, is used to find the age of formerly living things through a process known as radiocarbon dating. The \n "
                                                + "theory behind carbon dating is fairly simple. Scientists know that a small amount of naturally occurring carbon is carbon-14. Although carbon-14 decays into nitrogen-14 through \n "
                                                + "beta decay, the amount of carbon-14 in the environment remains constant because new carbon-14 is always being created in the upper atmosphere by cosmic rays. Living things tend \n "
                                                + "to ingest materials that contain carbon, so the percentage of carbon-14 within living things is the same as the percentage of carbon-14 in the environment. Once an organism dies, \n "
                                                + "it no longer ingests much of anything. The carbon-14 within that organism is no longer replaced and the percentage of carbon-14 begins to decrease as it decays. By measuring the \n "
                                                + "percentage of carbon-14 in the remains of an organism, and by assuming that the natural abundance of carbon-14 has remained constant over time, scientists can estimate when that\n "
                                                + " organism died. For example, if the concentration of carbon-14 in the remains of an organism is half of the natural concentration of carbon-14, a scientist would estimate that \n "
                                                + "the organism died about 5,730 years ago, the half-life of carbon-14.\n" 
                                                + "There are nearly ten million known carbon compounds and an entire branch of chemistry, known as organic chemistry, is devoted to their study. Many carbon compounds are essential \n "
                                                + "for life as we know it. Some of the most common carbon compounds are: carbon dioxide (CO2), carbon monoxide (CO), carbon disulfide (CS2), chloroform (CHCl3), carbon tetrachloride \n "
                                                + "(CCl4), methane (CH4), ethylene (C2H4), acetylene (C2H2), benzene (C6H6), ethyl alcohol (C2H5OH) and acetic acid (CH3COOH). \n"
        				  , "History & Uses of Carbon", JOptionPane.INFORMATION_MESSAGE);
                }

                //Nitrogen      7
        	if(first.getText().equals("N") || first.getText().equals("nitrogen") || first.getText().equals("Nitrogen")){
        		JOptionPane.showMessageDialog(null,
                                             "           Nitrogen was discovered by the Scottish physician Daniel Rutherford in 1772. It is the fifth most abundant element in the \n "
                                                     + "universe and makes up about 78% of the earth's atmosphere, which contains an estimated 4,000 trillion tons of the gas. \n"
                                                     + " Nitrogen is obtained from liquefied air through a process known as fractional distillation.\n" 
                                                     + "The largest use of nitrogen is for the production of ammonia (NH3). Large amounts of nitrogen are combined with hydrogen \n"
                                                     + " to produce ammonia in a method known as the Haber process. Large amounts of ammonia are then used to create fertilizers, \n"
                                                     + " explosives and, through a process known as the Ostwald process, nitric acid (HNO3).\n" 
                                                     +"Nitrogen gas is largely inert and is used as a protective shield in the semiconductor industry and during certain types of \n"
                                                     + " welding and soldering operations. Oil companies use high pressure nitrogen to help force crude oil to the surface. \n"
                                                     + " Liquid nitrogen is an inexpensive cryogenic liquid used for refrigeration, preservation of biological samples and for \n "
                                                     + "low temperature scientific experimentation. \n"     
        				  , "History & Uses of Nitrogen", JOptionPane.INFORMATION_MESSAGE);
                }

                //Oxygen        8
                if(first.getText().equals("O") || first.getText().equals("oxygen") || first.getText().equals("Oxygen")){
        		JOptionPane.showMessageDialog(null,
                                             "           Oxygen had been produced by several chemists prior to its discovery in 1774, but they failed to recognize it as a \n "
                                                     + "distinct element. Joseph Priestley and Carl Wilhelm Scheele both independently discovered oxygen, but Priestly is \n "
                                                     + "usually given credit for the discovery. They were both able to produce oxygen by heating mercuric oxide (HgO). \n "
                                                     + "Priestley called the gas produced in his experiments 'dephlogisticated air' and Scheele called his 'fire air'. \n "
                                                     + "The name oxygen was created by Antoine Lavoisier who incorrectly believed that oxygen was necessary to \n "
                                                     + "form all acids.\n" 
                                                     + "Oxygen is the third most abundant element in the universe and makes up nearly 21% of the earth's atmosphere. \n"
                                                     + " Oxygen accounts for nearly half of the mass of the earth's crust, two thirds of the mass of the human body \n "
                                                     + "and nine tenths of the mass of water. Large amounts of oxygen can be extracted from liquefied air through a \n "
                                                     + "process known as fractional distillation. Oxygen can also be produced through the electrolysis of water or \n"
                                                     + " by heating potassium chlorate (KClO3).\n" 
                                                     + "Oxygen is a highly reactive element and is capable of combining with most other elements. It is required \n"
                                                     + " by most living organisms and for most forms of combustion. Impurities in molten pig iron are burned away \n"
                                                     + " with streams of high pressure oxygen to produce steel. Oxygen can also be combined with acetylene (C2H2) \n"
                                                     + " to produce an extremely hot flame used for welding. Liquid oxygen, when combined with liquid hydrogen, \n "
                                                     + "makes an excellent rocket fuel. Ozone (O3) forms a thin, protective layer around the earth that shields \n "
                                                     + "the surface from the sun's ultraviolet radiation. Oxygen is also a component of hundreds of thousands \n "
                                                     + "of organic compounds. \n"  
        				  , "History & Uses of Oxygen", JOptionPane.INFORMATION_MESSAGE);
                }

            //Fluorine      9
            if(first.getText().equals("F") || first.getText().equals("fluorine") || first.getText().equals("Fluorine")){
                    JOptionPane.showMessageDialog(null,
                                         "            Fluorine is the most reactive of all elements and no chemical substance is capable of freeing \n "
                                                 + "fluorine from any of its compounds. For this reason, fluorine does not occur free in nature and \n"
                                                 + " was extremely difficult for scientists to isolate. The first recorded use of a fluorine \n "
                                                 + "compound dates to around 1670 to a set of instructions for etching glass that called for \n "
                                                 + "Bohemian emerald (CaF2). Chemists attempted to identify the material that was capable of \n "
                                                 + "etching glass and George Gore was able to produce a small amount of fluorine through an \n"
                                                 + " electrolytic process in 1869. Unknown to Gore, fluorine gas explosively combines with \n "
                                                 + "hydrogen gas. That is exactly what happened in Gore's experiment when the fluorine gas that \n "
                                                 + "formed on one electrode combined with the hydrogen gas that formed on the other electrode. \n "
                                                 + "Ferdinand Frederic Henri Moissan, a French chemist, was the first to successfully isolate \n "
                                                 + "fluorine in 1886. He did this through the electrolysis of potassium fluoride (KF) and \n "
                                                 + "hydrofluoric acid (HF). He also completely isolated the fluorine gas from the hydrogen gas \n"
                                                 + " and he built his electrolysis device completely from platinum. His work was so impressive \n"
                                                 + " that he was awarded the Nobel Prize for chemistry in 1906. Today, fluorine is still produced \n"
                                                 + "through the electrolysis of potassium fluoride and hydrofluoric acid as well as through the \n"
                                                 + " electrolysis of molten potassium acid fluoride (KHF2).\n" 
                                                 + "Fluorine is added to city water supplies in the proportion of about one part per million to \n "
                                                 + "help prevent tooth decay. Sodium fluoride (NaF), stannous(II) fluoride (SnF2) and sodium \n "
                                                 + "monofluorophosphate (Na2PO3F) are all fluorine compounds added to toothpaste, also to help \n "
                                                 + "prevent tooth decay. Hydrofluoric acid (HF) is used to etch glass, including most of the \n "
                                                 + "glass used in light bulbs. Uranium hexafluoride (UF6) is used to separate isotopes of uranium. \n"
                                                 + " Crystals of calcium fluoride (CaF2), also known as fluorite and fluorspar, are used to make \n"
                                                 + " lenses to focus infrared light. Fluorine joins with carbon to form a class of compounds known \n"
                                                 + " as fluorocarbons. Some of these compounds, such as dichlorodifluoromethane (CF2Cl2), were \n "
                                                 + "widely used in air conditioning and refrigeration systems and in aerosol spray cans, but \n "
                                                 + "have been phased out due to the damage they were causing to the earth's ozone layer. \n"
        				  , "History & Uses of Fluorine", JOptionPane.INFORMATION_MESSAGE);
                }

                //Neon      10
                if(first.getText().equals("Ne") || first.getText().equals("neon") || first.getText().equals("Neon")){
                    JOptionPane.showMessageDialog(null,
                                         "             Neon was discovered by Sir William Ramsay, a Scottish chemist, and Morris M. Travers, \n"
                                                 + " an English chemist, shortly after their discovery of the element krypton in 1898. \n"
                                                 + " Like krypton, neon was discovered through the study of liquefied air. Although neon \n"
                                                 + " is the fourth most abundant element in the universe, only 0.0018% of the earth's \n"
                                                 + " atmosphere is neon.\n" 
                                                 + "The largest use for neon gas is in advertising signs. Neon is also used to make  \n "
                                                 + "high voltage indicators and is combined with helium to make helium-neon lasers. \n"
                                                 + " Liquid neon is used as a cryogenic refrigerant. Neon is highly inert and forms \n"
                                                 + " no known compounds, although there is some evidence that it could form a \n "
                                                 + "compound with fluorine. \n"
        				  , "History & Uses of Neon", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Sodium        11
                if(first.getText().equals("Na") || first.getText().equals("sodium") || first.getText().equals("Sodium")){
                    JOptionPane.showMessageDialog(null,
                                         "       Although sodium is the sixth most abundant element on earth and comprises about 2.6% \n"
                                         + " of the earth's crust, it is a very reactive element and is never found free in nature. Pure \n "
                                         + "sodium was first isolated by Sir Humphry Davy in 1807 through the electrolysis of caustic soda (NaOH).\n"
                                         + " Since sodium can ignite on contact with water, it must be stored in a moisture free environment. \n "
                                         + "Sodium is used in the production of titanium, sodamide, sodium cyanide, sodium peroxide, and \n "
                                         + "sodium hydride. Liquid sodium has been used as a coolant for nuclear reactors. Sodium vapor is used \n"
                                         + " in streetlights and produces a brilliant yellow light. \n"
                                         + "Sodium also forms many useful compounds. Some of the most common are: table salt (NaCl), \n"
                                         + " soda ash (Na2CO3), baking soda (NaHCO3), caustic soda (NaOH), Chile saltpeter (NaNO3) \n "
                                         + "and borax (Na2B4O7·10H2O). \n"
        				  , "History & Uses of Sodium", JOptionPane.INFORMATION_MESSAGE);
                }

                //Magnesium     12
                if(first.getText().equals("Mg") || first.getText().equals("magnesium") || first.getText().equals("Magnesium")){
                    JOptionPane.showMessageDialog(null,
                                         "        Although it is the eighth most abundant element in the universe and the seventh most \n"
                                         + " abundant element in the earth's crust, magnesium is never found free in nature. Magnesium was \n"
                                         + " first isolated by Sir Humphry Davy, an English chemist, through the electrolysis of a mixture \n "
                                         + "of magnesium oxide (MgO) and mercuric oxide (HgO) in 1808. Today, magnesium can be extracted \n "
                                         + "from the minerals dolomite (CaCO3·MgCO3) and carnallite (KCl·MgCl2·6H2O), but is most often \n "
                                         + "obtained from seawater. Every cubic kilometer of seawater contains about 1.3 billion kilograms \n "
                                         + "of magnesium (12 billion pounds per cubic mile). \n"
                                         + "Magnesium burns with a brilliant white light and is used in pyrotechnics, flares and photographic \n"
                                         + " flashbulbs. Magnesium is the lightest metal that can be used to build things, although its use \n"
                                         + " as a structural material is limited since it burns at relatively low temperatures. Magnesium is \n "
                                         + "frequently alloyed with aluminum, which makes aluminum easier to roll, extrude and weld. \n "
                                         + "Magnesium-aluminum alloys are used where strong, lightweight materials are required, such as in \n "
                                         + "airplanes, missiles and rockets. Cameras, horseshoes, baseball catchers' masks and snowshoes are \n "
                                         + "other items that are made from magnesium alloys. \n"
                                         + "Magnesium oxide (MgO), also known as magnesia, is the second most abundant compound in the \n "
                                         + "earth's crust. Magnesium oxide is used in some antacids, in making crucibles and insulating \n "
                                         + "materials, in refining some metals from their ores and in some types of cements. When combined \n"
                                         + " with water (H2O), magnesia forms magnesium hydroxide (Mg(OH)2), better known as milk of magnesia,\n"
                                         + " which is commonly used as an antacid and as a laxative. \n"
                                         + "Hydrated magnesium sulphate (MgSO4·7H2O), better known as Epsom salt, was discovered in 1618 by \n"
                                         + " a farmer in Epsom, England, when his cows refused to drink the water from a certain mineral well. \n"
                                         + " He tasted the water and found that it tasted very bitter. He also noticed that it helped heal \n "
                                         + "scratches and rashes on his skin. Epsom salt is still used today to treat minor skin abrasions. \n"
                                         + "Other magnesium compounds include magnesium carbonate (MgCO3) and magnesium fluoride (MgF2).\n"
                                         + " Magnesium carbonate is used to make some types of paints and inks and is added to table salt \n "
                                         + "to prevent caking. A thin film of magnesium fluoride is applied to optical lenses to help \n "
                                         + "reduce glare and reflections. \n"
        				  , "History & Uses of Magnesium", JOptionPane.INFORMATION_MESSAGE);
                }

                //Aluminum      13
                if(first.getText().equals("Al") || first.getText().equals("aluminum") || first.getText().equals("Aluminum")){
                    JOptionPane.showMessageDialog(null,
                                         "         Although aluminum is the most abundant metal in the earth's crust, it is never found \n"
                                         + " free in nature. All of the earth's aluminum has combined with other elements to form compounds. \n"
                                         + " Two of the most common compounds are alum, such as potassium aluminum sulfate (KAl(SO4)2·12H2O), \n "
                                         + "and aluminum oxide (Al2O3). About 8.2% of the earth's crust is composed of aluminum. \n"
                                         + "Scientists suspected than an unknown metal existed in alum as early as 1787, but they did not \n"
                                         + " have a way to extract it until 1825. Hans Christian Oersted, a Danish chemist, was the first to \n"
                                         + " produce tiny amounts of aluminum. Two years later, Friedrich Wöhler, a German chemist, developed \n"
                                         + " a different way to obtain aluminum. By 1845, he was able to produce samples large enough to \n"
                                         + " determine some of aluminum's basic properties. Wöhler's method was improved in 1854 by Henri \n "
                                         + "Étienne Sainte-Claire Deville, a French chemist. Deville's process allowed for the commercial \n"
                                         + " production of aluminum. As a result, the price of aluminum dropped from around $1200 per kilogram \n"
                                         + " in 1852 to around $40 per kilogram in 1859. Unfortunately, aluminum remained too expensive to be \n"
                                         + " widely used. \n"
                                         + "Two important developments in the 1880s greatly increased the availability of aluminum. The first \n"
                                         + " was the invention of a new process for obtaining aluminum from aluminum oxide. Charles Martin Hall, \n"
                                         + " an American chemist, and Paul L. T. Héroult, a French chemist, each invented this process \n"
                                         + " independently in 1886. The second was the invention of a new process that could cheaply obtain \n "
                                         + "aluminum oxide from bauxite. Bauxite is an ore that contains a large amount of aluminum hydroxide \n "
                                         + "(Al2O3·3H2O), along with other compounds. Karl Joseph Bayer, an Austrian chemist, developed this \n "
                                         + "process in 1888. The Hall-Héroult and Bayer processes are still used today to produce nearly all \n "
                                         + "of the world's aluminum. \n"
                                         + "With an easy way to extract aluminum from aluminum oxide and an easy way to extract large amounts \n"
                                         + " of aluminum oxide from bauxite, the era of inexpensive aluminum had begun. In 1888, Hall formed \n "
                                         + "the Pittsburgh Reduction Company, which is now known as the Aluminum Company of America, or Alcoa. \n"
                                         + " When it opened, his company could produce about 25 kilograms of aluminum a day. By 1909, his company \n"
                                         + " was producing about 41,000 kilograms of aluminum a day. As a result of this huge increase of supply, \n"
                                         + " the price of aluminum fell rapidly to about $0.60 per kilogram. \n"
                                         + "Today, aluminum and aluminum alloys are used in a wide variety of products: cans, foils and kitchen \n"
                                         + " utensils, as well as parts of airplanes, rockets and other items that require a strong, light material. \n "
                                         + "Although it doesn't conduct electricity as well as copper, it is used in electrical transmission lines \n "
                                         + "because of its light weight. It can be deposited on the surface of glass to make mirrors, where a thin  \n "
                                         + "layer of aluminum oxide quickly forms that acts as a protective coating. Aluminum oxide is also used to \n "
                                         + "make synthetic rubies and sapphires for lasers. \n"
        				  , "History & Uses of Aluminum", JOptionPane.INFORMATION_MESSAGE);
                }

                //Silicon       14
                if(first.getText().equals("Si") || first.getText().equals("silicon") || first.getText().equals("Silicon")){
                    JOptionPane.showMessageDialog(null,
                                         "          Silicon was discovered by Jöns Jacob Berzelius, a Swedish chemist, in 1824 by heating chips of \n"
                                         + " potassium in a silica container and then carefully washing away the residual by-products. Silicon is \n "
                                         + "the seventh most abundant element in the universe and the second most abundant element in the earth's \n "
                                         + "crust. Today, silicon is produced by heating sand (SiO2) with carbon to temperatures approaching 2200°C. \n"
                                         + "Two allotropes of silicon exist at room temperature: amorphous and crystalline. Amorphous appears as \n "
                                         + "a brown powder while crystalline silicon has a metallic luster and a grayish color. Single crystals of \n"
                                         + " crystalline silicon can be grown with a process known as the Czochralski process. These crystals, when \n"
                                         + " doped with elements such as boron, gallium, germanium, phosphorus or arsenic, are used in the manufacture \n"
                                         + " of solid-state electronic devices, such as transistors, solar cells, rectifiers and microchips. \n"
                                         + "Silicon dioxide (SiO2), silicon's most common compound, is the most abundant compound in the earth's \n"
                                         + " crust. It commonly takes the form of ordinary sand, but also exists as quartz, rock crystal, amethyst, \n"
                                         + " agate, flint, jasper and opal. Silicon dioxide is extensively used in the manufacture of glass and bricks. \n"
                                         + " Silica gel, a colloidal form of silicon dioxide, easily absorbs moisture and is used as a desiccant. \n"
                                         + "Silicon forms other useful compounds. Silicon carbide (SiC) is nearly as hard as diamond and is used as \n "
                                         + "an abrasive. Sodium silicate (Na2SiO3), also known as water glass, is used in the production of soaps, \n "
                                         + "adhesives and as an egg preservative. Silicon tetrachloride (SiCl4) is used to create smoke screens.  \n"
                                         + "Silicon is also an important ingredient in silicone, a class of material that is used for such things as \n"
                                         + " lubricants, polishing agents, electrical insulators and medical implants. \n"
        				  , "History & Uses of Silicon", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Phosphorus        15
                if(first.getText().equals("P") || first.getText().equals("phosphorus") || first.getText().equals("Phosphorus")){
                    JOptionPane.showMessageDialog(null,
                                         "            In what is perhaps the most disgusting method of discovering an element, phosphorus was first \n"
                                         + " isolated in 1669 by Hennig Brand, a German physician and alchemist, by boiling, filtering and otherwise \n "
                                         + "processing as many as 60 buckets of urine. Thankfully, phosphorus is now primarily obtained from phosphate \n"
                                         + " rock (Ca3(PO4)2). \n"
                                         + "Phosphorus has three main allotropes: white, red and black. White phosphorus is poisonous and can  \n"
                                         + "spontaneously ignite when it comes in contact with air. For this reason, white phosphorus must be stored \n "
                                         + "under water and is usually used to produce phosphorus compounds. Red phosphorus is formed by heating \n "
                                         + "white phosphorus to 250°C (482°F) or by exposing white phosphorus to sunlight. Red phosphorus is not \n"
                                         + " poisonous and is not as dangerous as white phosphorus, although frictional heating is enough to change \n "
                                         + "it back to white phosphorus. Red phosphorus is used in safety matches, fireworks, smoke bombs and \n "
                                         + "pesticides. Black phosphorus is also formed by heating white phosphorus, but a mercury catalyst and a \n "
                                         + "seed crystal of black phosphorus are required. Black phosphorus is the least reactive form of phosphorus \n"
                                         + " and has no significant commercial uses. \n"
                                         + "Phosphoric acid (H3PO4) is used in soft drinks and to create many phosphate compounds, such as triple \n"
                                         + " superphosphate fertilizer (Ca(H2PO4)2·H2O). Trisodium phosphate (Na3PO4) is used as a cleaning agent \n"
                                         + " and as a water softener. Calcium phosphate (Ca3(PO4)2) is used to make china and in the production of \n "
                                         + "baking powder. Some phosphorus compounds glow in the dark or emit light in response to absorbing  \n"
                                         + "radiation and are used in fluorescent light bulbs and television sets. \n"
        				  , "History & Uses of Phosphorus", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Sulfur        16
                if(first.getText().equals("S") || first.getText().equals("sulfur") || first.getText().equals("Sulfur")){
                    JOptionPane.showMessageDialog(null,
                                         "           Sulfur, the tenth most abundant element in the universe, has been known since ancient times. \n"
                                         + " Sometime around 1777, Antoine Lavoisier convinced the rest of the scientific community that sulfur was \n"
                                         + " an element. Sulfur is a component of many common minerals, such as galena (PbS), gypsum (CaSO4·2(H2O), \n "
                                         + "pyrite (FeS2), sphalerite (ZnS or FeS), cinnabar (HgS), stibnite (Sb2S3), epsomite (MgSO4·7(H2O)), \n "
                                         + "celestite (SrSO4) and barite (BaSO4). Nearly 25% of the sulfur produced today is recovered from petroleum \n"
                                         + " refining operations and as a byproduct of extracting other materials from sulfur containing ores. \n"
                                         + " The majority of the sulfur produced today is obtained from underground deposits, usually found in \n"
                                         + " conjunction with salt deposits, with a process known as the Frasch process. \n"
                                         + "Sulfur is a pale yellow, odorless and brittle material. It displays three allotropic forms: orthorhombic, \n"
                                         + " monoclinic and amorphous. The orthorhombic form is the most stable form of sulfur. Monoclinic sulfur \n "
                                         + "exists between the temperatures of 96°C and 119°C and reverts back to the orthorhombic form when cooled. \n"
                                         + " Amorphous sulfur is formed when molten sulfur is quickly cooled. Amorphous sulfur is soft and elastic \n "
                                         + "and eventually reverts back to the orthorhombic form. \n"
                                         + "Most of the sulfur that is produced is used in the manufacture of sulfuric acid (H2SO4). Large amounts \n"
                                         + " of sulfuric acid, nearly 40 million tons, are used each year to make fertilizers, lead-acid batteries, \n"
                                         + " and in many industrial processes. Smaller amounts of sulfur are used to vulcanize natural rubbers, as an \n"
                                         + " insecticide (the Greek poet Homer mentioned (pest-averting sulphur) nearly 2,800 years ago!), in the \n "
                                         + "manufacture of gunpowder and as a dying agent. \n"
                                         + "In addition to sulfuric acid, sulfur forms other interesting compounds. Hydrogen sulfide (H2S) is a gas \n"
                                         + " that smells like rotten eggs. Sulfur dioxide (SO2), formed by burning sulfur in air, is used as a  \n "
                                         + "bleaching agent, solvent, disinfectant and as a refrigerant. When combined with water (H2O), sulfur dioxide \n"
                                         + " forms sulfurous acid (H2SO3), a weak acid that is a major component of acid rain.\n "
        				  , "History & Uses of Sulfur", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Chlorine      17
                if(first.getText().equals("Cl") || first.getText().equals("chlorine") || first.getText().equals("Chlorine")){
                    JOptionPane.showMessageDialog(null,
                                         "          Since it combines directly with nearly every element, chlorine is never found free in nature. \n"
                                         + " Chlorine was first produced by Carl Wilhelm Scheele, a Swedish chemist, when he combined the mineral \n "
                                         + "pyrolusite (MnO2) with hydrochloric acid (HCl) in 1774. Although Scheele thought the gas produced in \n "
                                         + "his experiment contained oxygen, Sir Humphry Davy proved in 1810 that it was actually a distinct element. \n"
                                         + " Today, most chlorine is produced through the electrolysis of aqueous sodium chloride (NaCl).Chlorine is \n "
                                         + "commonly used as an antiseptic and is used to make drinking water safe and to treat swimming pools. Large \n"
                                         + " amounts of chlorine are used in many industrial processes, such as in the production of paper products, \n"
                                         + "plastics, dyes, textiles, medicines, antiseptics, insecticides, solvents and paints.\n"
                                         + "Two of the most familiar chlorine compounds are sodium chloride (NaCl) and hydrogen chloride (HCl). \n "
                                         + "Sodium chloride, commonly known as table salt, is used to season food and in some industrial processes. \n"
                                         + " Hydrogen chloride, when mixed with water (H2O), forms hydrochloric acid, a strong and commercially \n "
                                         + "important acid. Other chlorine compounds include: chloroform (CHCl3), carbon tetrachloride (CCl4), \n "
                                         + "potassium chloride (KCl), lithium chloride (LiCl), magnesium chloride (MgCl2) and chlorine dioxide (ClO2). \n"
                                         + "Chlorine is a very dangerous material. Liquid chlorine burns the skin and gaseous chlorine irritates \n"
                                         + " the mucus membranes. Concentrations of the gas as low as 3.5 parts per million can be detected by \n"
                                         + " smell while concentrations of 1000 parts per million can be fatal after a few deep breaths. \n"
        				  , "History & Uses of Chlorine", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Argon     18
                if(first.getText().equals("Ar") || first.getText().equals("argon") || first.getText().equals("Argon")){
                    JOptionPane.showMessageDialog(null,
                                         "          Argon was discovered by Sir William Ramsay, a Scottish chemist, and Lord Rayleigh, an \n "
                                         + "English chemist, in 1894. Argon makes up 0.93% of the earth's atmosphere, making it the third \n "
                                         + "most abundant gas. Argon is obtained from the air as a byproduct of the production of oxygen \n"
                                         + " and nitrogen. \n"
                                         + "Argon is frequently used when an inert atmosphere is needed. It is used to fill incandescent \n "
                                         + "and fluorescent light bulbs to prevent oxygen from corroding the hot filament. Argon is also \n "
                                         + "used to form inert atmospheres for arc welding, growing semiconductor crystals and processes \n "
                                         + "that require shielding from other atmospheric gases. \n"
                                         + "Once thought to be completely inert, argon is known to form at least one compound. The synthesis \n "
                                         + "of argon fluorohydride (HArF) was reported by Leonid Khriachtchev, Mika Pettersson, Nino Runeberg, \n"
                                         + " Jan Lundell and Markku Räsänen in August of 2000. Stable only at very low temperatures, argon \n "
                                         + "fluorohydride begins to decompose once it warms above -246°C (-411°F). Because of this limitation, \n"
                                         + " argon fluorohydride has no uses outside of basic scientific research. \n"
        				  , "History & Uses of Argon", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Potassium     19
                if(first.getText().equals("K") || first.getText().equals("potassium") || first.getText().equals("Potassium")){
                    JOptionPane.showMessageDialog(null,
                                         "          Although potassium is the eighth most abundant element on earth and comprises about 2.1% \n "
                                         + "of the earth's crust, it is a very reactive element and is never found free in nature. Metallic \n"
                                         + " potassium was first isolated by Sir Humphry Davy in 1807 through the electrolysis of molten caustic \n"
                                         + " potash (KOH). A few months after discovering potassium, Davy used the same method to isolate sodium. \n"
                                         + " Potassium can be obtained from the minerals sylvite (KCl), carnallite (KCl·MgCl2·6H2O), langbeinite \n "
                                         + "(K2Mg2(SO4)3) and polyhalite (K2Ca2Mg(SO4)4·2H2O). These minerals are often found in ancient lake and \n"
                                         + " sea beds. Caustic potash, another important source of potassium, is primarily mined in Germany, New \n "
                                         + "Mexico, California and Utah. \n"
                                         + "Pure potassium is a soft, waxy metal that can be easily cut with a knife. It reacts with oxygen to \n "
                                         + "form potassium superoxide (KO2) and with water to form potassium hydroxide (KOH), hydrogen gas and \n"
                                         + " heat. Enough heat is produced to ignite the hydrogen gas. To prevent it from reacting with the oxygen \n"
                                         + " and water in the air, samples of metallic potassium are usually stored submerged in mineral oil. \n"
                                         + "Potassium forms an alloy with sodium (NaK) that is used as a heat transfer medium in some types of \n "
                                         + "nuclear reactors. \n"
                                         + "Potassium forms many important compounds. Potassium chloride (KCl) is the most common potassium compound. \n"
                                         + " It is used in fertilizers, as a salt substitute and to produce other chemicals. Potassium hydroxide (KOH) \n"
                                         + " is used to make soaps, detergents and drain cleaners. Potassium carbonate (KHCO3), also known as pearl ash, \n"
                                         + " is used to make some types of glass and soaps and is obtained commercially as a byproduct of the production \n"
                                         + " of ammonia. Potassium superoxide (KO2) can create oxygen from water vapor (H2O) and carbon dioxide (CO2) \n "
                                         + "through the following reaction: 2KO2 + H2O + 2CO2 => 2KHCO3 + O2. It is used in respiratory equipment and is \n"
                                         + " produced by burning potassium metal in dry air. Potassium nitrate (KNO3), also known as saltpeter or nitre, \n "
                                         + "is used in fertilizers, match heads and pyrotechnics. \n"
        				  , "History & Uses of Potassium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Calcium       20
                if(first.getText().equals("Ca") || first.getText().equals("calcium") || first.getText().equals("Calcium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Although calcium is the fifth most abundant element in the earth's crust, it is never found free in \n"
                                         + " nature since it easily forms compounds by reacting with oxygen and water. Metallic calcium was first isolated by \n"
                                         + " Sir Humphry Davy in 1808 through the electrolysis of a mixture of lime (CaO) and mercuric oxide (HgO). Today, \n "
                                         + "metallic calcium is obtained by displacing calcium atoms in lime with atoms of aluminum in hot, low-pressure \n "
                                         + "containers. About 4.2% of the earth's crust is composed of calcium. \n"
                                         + "Due to its high reactivity with common materials, there is very little demand for metallic calcium. It is used \n "
                                         + "in some chemical processes to refine thorium, uranium and zirconium. Calcium is also used to remove oxygen, sulfur \n"
                                         + " and carbon from certain alloys. Calcium can be alloyed with aluminum, beryllium, copper, lead and magnesium. \n "
                                         + "Calcium is also used in vacuum tubes as a getter, a material that combines with and removes trace gases from \n "
                                         + "vacuum tubes. \n"
                                         + "Calcium carbonate (CaCO3) is one of the common compounds of calcium. It is heated to form quicklime (CaO) which \n"
                                         + " is then added to water (H2O). This forms another material known as slaked lime (Ca(OH)2) which is an inexpensive \n"
                                         + " base material used throughout the chemical industry. Chalk, marble and limestone are all forms of calcium carbonate. \n"
                                         + " Calcium carbonate is used to make white paint, cleaning powder, toothpaste and stomach antacids, among other things. \n "
                                         + "Other common compounds of calcium include: calcium sulfate (CaSO4), also known as gypsum, which is used to make dry \n "
                                         + "wall and plaster of Paris, calcium nitrate (Ca(NO3)2), a naturally occurring fertilizer and calcium phosphate (Ca3(PO4)2), \n"
                                         + " the main material found in bones and teeth. \n"
        				  , "History & Uses of Calcium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Scandium      21
                if(first.getText().equals("Sc") || first.getText().equals("scandium") || first.getText().equals("Scandium")){
                    JOptionPane.showMessageDialog(null,
                                         "           Scandium was discovered by Lars Fredrik Nilson, a Swedish chemist, in 1879 while attempting to produce a sample \n"
                                                 + "of pure ytterbia from 10 kilograms of the mineral euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6). Scandium \n"
                                                 + "can be obtained from the minerals thortveitite ((Sc, Y)2Si2O7), bazzite (Be3(Sc, Al)2Si6O18) and wiikite, but is \n"
                                                 + "usually obtained as a byproduct of refining uranium.\n" 
                                                 +"Metallic scandium was first produced in 1937 and the first pound (0.45 kilograms) of pure scandium was produced in \n"
                                                 + "1960. Scandium is a soft, light metal that might have applications in the aerospace industry. With a cost of $270 \n"
                                                 + "per gram ($122,500 per pound), scandium is too expensive for widespread use.\n" 
                                                 +"Alloys of scandium and aluminum are used in some kinds of athletic equipment, such as aluminum baseball bats, bicycle \n"
                                                 + "frames and lacrosse sticks. It is expected that scandium-aluminum alloys will be important in the manufacture of \n"
                                                 + "fuel cells.\n" 
                                                 +"Scientists have only studied a few compounds of scandium. About 20 kilograms (44 pounds) of scandium oxide (Sc2O3), \n"
                                                 + "also known as scandia, are used each year in the United States in the production of high intensity lights. Scandium \n"
                                                 + "iodide (ScI3) is added to mercury vapor lamps so that they will emit light that closely resembles sunlight. \n"
        				  , "History & Uses of Scandium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Titanium      22
                if(first.getText().equals("Ti") || first.getText().equals("titanium") || first.getText().equals("Titanium")){
                    JOptionPane.showMessageDialog(null,
                                         "            Titanium was discovered in 1791 by the Reverend William Gregor, an English pastor. Pure titanium was first produced by Matthew A. \n"
                                                 + "Hunter, an American metallurgist, in 1910. Titanium is the ninth most abundant element in the earth's crust and is primarily \n"
                                                 + "found in the minerals rutile (TiO2), ilmenite (FeTiO3) and sphene (CaTiSiO5). Titanium makes up about 0.57% of the earth's \n"
                                                 + "crust.\n" 
                                                 +"Titanium is a strong, light metal. It is as strong as steel and twice as strong as aluminum, but is 45% lighter than steel \n"
                                                 + "and only 60% heavier than aluminum. Titanium is not easily corroded by sea water and is used in propeller shafts, rigging \n"
                                                 + "and other parts of boats that are exposed to sea water. Titanium and titanium alloys are used in airplanes, missiles and \n"
                                                 + "rockets where strength, low weight and resistance to high temperatures are important. Since titanium does not react within \n"
                                                 + "the human body, it is used to create artificial hips, pins for setting bones and for other biological implants. Unfortunately, \n"
                                                 + "the high cost of titanium has limited its widespread use.\n" 
                                                 +"Titanium oxide (TiO2) is used as a pigment to create white paint and accounts for the largest use of the element. Pure \n"
                                                 + "titanium oxide is relatively clear and is used to create titania, an artificial gemstone. Titanium tetrachloride (TiCl4), \n"
                                                 + "another titanium compound, has been used to make smoke screens.\n" 
                                                 +"A final bit of titanium trivia -- titanium is the only element that will burn in an atmosphere of pure nitrogen. \n"
        				  , "History & Uses of Titanium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Vanadium      23
                if(first.getText().equals("V") || first.getText().equals("vanadium") || first.getText().equals("Vanadium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Vanadium was discovered by Andrés Manuel del Rio, a Mexican chemist, in 1801. Rio sent samples of vanadium ore and a letter \n"
                                                 + "describing his methods to the Institute de France in Paris, France, for analysis and confirmation. Unfortunately for \n"
                                                 + "Rio, his letter was lost in a shipwreck and the Institute only received his samples, which contained a brief note \n"
                                                 + "describing how much this new element, which Rio had named erythronium, resembled chromium. Rio withdrew his claim \n"
                                                 + "when he received a letter from Paris disputing his discovery. Vanadium was rediscovered by Nils Gabriel Sefstrôm, \n"
                                                 + "a Swedish chemist, in 1830 while analyzing samples of iron from a mine in Sweden. Vanadium was isolated by Sir Henry \n"
                                                 + "Enfield Roscoe, an English chemist, in 1867 by combining vanadium trichloride (VCl3) with hydrogen gas (H2). Today, \n"
                                                 + "vanadium is primarily obtained from the minerals vanadinite (Pb5(VO)3Cl) and carnotite (K2(UO2)2VO4·1-3H2O) by heating \n"
                                                 + "crushed ore in the presence of carbon and chlorine to produce vanadium trichloride. The vanadium trichloride is then \n"
                                                 + "heated with magnesium in an argon atmosphere.\n" 
                                                 +"Vanadium is corrosion resistant and is sometimes used to make special tubes and pipes for the chemical industry. \n"
                                                 + "Vanadium also does not easily absorb neutrons and has some applications in the nuclear power industry. A thin layer \n"
                                                 + "of vanadium is used to bond titanium to steel.\n" 
                                                 +"Nearly 80% of the vanadium produced is used to make ferrovanadium or as an additive to steel. Ferrovanadium is a strong, \n"
                                                 + "shock resistant and corrosion resistant alloy of iron containing between 1% and 6% vanadium. Ferrovanadium and \n"
                                                 + "vanadium-steel alloys are used to make such things as axles, crankshafts and gears for cars, parts of jet engines, \n"
                                                 + "springs and cutting tools.\n" 
                                                 +"Vanadium pentoxide (V2O5) is perhaps vanadium's most useful compound. It is used as a mordant, a material which \n"
                                                 + "permanently fixes dyes to fabrics. Vanadium pentoxide is also used as a catalyst in certain chemical reactions and \n"
                                                 + "in the manufacture of ceramics. Vanadium pentoxide can also be mixed with gallium to form superconductive magnets. \n"
        				  , "History & Uses of Vanadium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Chromium      24
                if(first.getText().equals("Cr") || first.getText().equals("chromium") || first.getText().equals("Chromium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Chromium was discovered by Louis-Nicholas Vauquelin while experimenting with a material known as Siberian red \n"
                                                 + "lead, also known as the mineral crocoite (PbCrO4), in 1797. He produced chromium oxide (CrO3) by mixing crocoite \n"
                                                 + "with hydrochloric acid (HCl). Although he believed a method for isolating chromium didn't yet exist, Vauquelin was \n"
                                                 + "pleasantly surprised in 1798 to discover that he was able to obtain metallic chromium by simply heating chromium oxide \n"
                                                 + "in a charcoal oven. Today, chromium is primarily obtained by heating the mineral chromite (FeCr2O4) in the presence \n"
                                                 + "of aluminum or silicon.\n" 
                                                 +"Chromium is a blue-white metal that is hard, brittle and very corrosion resistant. Chromium can be polished to form a \n"
                                                 + "very shiny surface and is often plated to other metals to form a protective and attractive covering. Chromium is added \n"
                                                 + "to steel to harden it and to form stainless steel, a steel alloy that contains at least 10% chromium. Other chromium-steel \n"
                                                 + "alloys are used to make armor plate, safes, ball bearings and cutting tools.\n" 
                                                 +"Chromium forms many colorful compounds that have industrial uses. Lead chromate (PbCrO4), also known as chrome yellow, \n"
                                                 + "has been used as a yellow pigment in paints. Chromic oxide (Cr2O3), also known as chrome green, is the ninth most \n"
                                                 + "abundant compound in the earth's crust and is a widely used green pigment. Rubies and emeralds also owe their colors \n"
                                                 + "to chromium compounds. Potassium dichromate (K2Cr2O7) is used in the tanning of leather while other chromium compounds \n"
                                                 + "are used as mordants, materials which permanently fix dyes to fabrics. Chromium compounds are also used to anodize \n"
                                                 + "aluminum, a process which coats aluminum with a thick, protective layer of oxide. Chromite, chromium's primary ore, \n"
                                                 + "is used to make molds for the firing of bricks because of its high melting point, moderate thermal expansion and \n"
                                                 + "stable crystal structure.\n"
        				  , "History & Uses of Chromium", JOptionPane.INFORMATION_MESSAGE);
                }

                
                //Manganese     25
                if(first.getText().equals("Mn") || first.getText().equals("manganese") || first.getText().equals("Manganese")){
                    JOptionPane.showMessageDialog(null,
                                         "               Proposed to be an element by Carl Wilhelm Scheele in 1774, manganese was discovered by Johan Gottlieb Gahn, \n"
                                                 + "a Swedish chemist, by heating the mineral pyrolusite (MnO2) in the presence of charcoal later that year. Today, \n"
                                                 + "most manganese is still obtained from pyrolusite, although it is usually burned in a furnace with powdered aluminum \n"
                                                 + "or is treated with sulfuric acid (H2SO4) to form manganese sulfate (MnSO4), which is then electrolyzed.\n" 
                                                 +"Nearly 90% of all of the manganese produced each year is used in the production of steel. Manganese is added to \n"
                                                 + "molten steel to remove oxygen and sulfur and is alloyed with steel to make it easier to form and work with and \n"
                                                 + "to increase steel's strength and resistance to impact. Railroad tracks, for example, are made with steel that \n"
                                                 + "contains as much as 1.2% manganese. Manganese is also used to give glass an amethyst color and is responsible \n"
                                                 + "for the color of amethyst gemstones.\n" 
                                                 +"Manganese dioxide (MnO2), the most common compound of manganese, makes up about 0.14% of the Earth's crust. It \n"
                                                 + "is used in dry cell batteries to prevent the formation of hydrogen, to remove the green color in glass that is \n"
                                                 + "caused by the presence of iron contaminants, and as a drying agent in black paints.\n"
        				  , "History & Uses of Manganese", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Iron      26
                if(first.getText().equals("Fe") || first.getText().equals("iron") || first.getText().equals("Iron")){
                    JOptionPane.showMessageDialog(null,
                                         "              Archaeological evidence suggests that people have been using iron for at least 5000 years. Iron is the cheapest \nand one"
                                                 + "of the most abundant of all metals, comprising nearly 5.6% of the earth's crust and nearly all of the earth's \n"
                                                 + "core. Iron is primarily obtained from the minerals hematite (Fe2O3) and magnetite (Fe3O4). The minerals taconite, \n"
                                                 + "limonite (FeO(OH)·nH2O) and siderite (FeCO3) are other important sources.\n" 
                                                 +"Huge amounts of iron are used to make steel, an alloy of iron and carbon. Steel typically contains between 0.3% \n"
                                                 + "and 1.5% carbon, depending on the desired characteristics. The addition of other elements can give steel other \n"
                                                 + "useful properties. Small amounts of chromium improves durability and prevents rust (stainless steel); nickel \n"
                                                 + "increases durability and resistance to heat and acids; manganese increases strength and resistance to wear; \n"
                                                 + "molybdenum increases strength and resistance to heat; tungsten retains hardness at high temperatures; and vanadium \n"
                                                 + "increases strength and springiness. Steel is used to make paper clips, skyscrapers and everything in between.\n" 
                                                 +"In addition to helping build the world around us, iron helps keep plants and animals alive. Iron plays a role in \n"
                                                 + "the creation of chlorophyll in plants and is an essential part of hemoglobin, the substance that carries oxygen \n"
                                                 + "within red blood cells. Iron sulfate (FeSO4) is used to treat the blood disease anemia. \n"
        				  , "History & Uses of Iron", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Cobalt        27
                if(first.getText().equals("Co") || first.getText().equals("cobalt") || first.getText().equals("Cobalt")){
                    JOptionPane.showMessageDialog(null,
                                         "            Cobalt was discovered by Georg Brandt, a Swedish chemist, in 1739. Brandt was attempting to prove that \n"
                                                 + "the ability of certain minerals to color glass blue was due to an unknown element and not to bismuth, as \n"
                                                 + "was commonly believed at the time. Cobalt's primary ores are cobaltite (CoAsS) and erythrite (Co3(AsO4)2). \n"
                                                 + "Cobalt is usually recovered as a byproduct of mining and refining nickel, silver, lead, copper and iron.\n" 
                                                 +"Although cobalt is used in electroplating to give objects an attractive surface that resists oxidation, it \n"
                                                 + "is more widely used to form alloys. Alnico, an alloy consisting of aluminum, nickel and cobalt is used to \n"
                                                 + "make powerful permanent magnets. Stellite alloys, which contain cobalt, chromium and tungsten, are used to \n"
                                                 + "make high-speed and high temperature cutting tools and dyes. Cobalt is also used to make alloys for jet \n"
                                                 + "engines and gas turbines, magnetic steels and some types of stainless steels.\n" 
                                                 +"Cobalt-60, a radioactive isotope of cobalt, is an important source of gamma rays and is used to treat some \n"
                                                 + "forms of cancer and as a medical tracer. Cobalt-60 has a half-life of 5.27 years and decays into nickel-60 \n"
                                                 + "through beta decay.\n" 
                                                 +"Cobalt compounds have been used for centuries to color porcelain, glass, pottery, tile and enamel. Some of \n"
                                                 + "these compounds are known as: cobalt blue, ceruleum, new blue, smalt, cobalt yellow and cobalt green. \n"
                                                 + "In addition to being used as a dye, cobalt is also important to human nutrition as it is an essential part \n"
                                                 + "of vitamin B12. \n"
        				  , "History & Uses of Cobalt", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Nickel        28
                if(first.getText().equals("Ni") || first.getText().equals("nickel") || first.getText().equals("Nickel")){
                    JOptionPane.showMessageDialog(null,
                                         "           Nickel was discovered by the Swedish chemist Axel Fredrik Cronstedt in the mineral niccolite (NiAs) in 1751. \n"
                                                 + "Today, most nickel is obtained from the mineral pentlandite (NiS·2FeS). Most of the world's supply of nickel \n"
                                                 + "is mined in the Sudbury region of Ontario, Canada. It is believed that this large deposit of nickel ore is a \n"
                                                 + "result of an ancient meteor impact.\n" 
                                                 +"Nickel is a hard, corrosion resistant metal. It can be electroplated onto other metals to form a protective \n"
                                                 + "coating. Finely divided nickel is used as a catalyst for the hydrogenation of vegetable oils. Adding nickel \n"
                                                 + "to glass gives it a green color. A single kilogram of nickel can be drawn into 300 kilometers of wire. Nickel \n"
                                                 + "is also used to manufacture some types of coins and batteries.\n" 
                                                 +"Nickel is alloyed with other metals to improve their strength and resistance to corrosion. Nickel is alloyed \n"
                                                 + "with steel to make armor plate, vaults and machine parts. It is alloyed with copper to make pipes that are used \n"
                                                 + "in desalination plants. Very powerful permanent magnets, known as Alnico magnets, can be made from an alloy of \n"
                                                 + "aluminum, nickel, cobalt and iron. \n"
        				  , "History & Uses of Nickel", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Copper        29
                if(first.getText().equals("Cu") || first.getText().equals("copper") || first.getText().equals("Copper")){
                    JOptionPane.showMessageDialog(null,
                                         "            Archaeological evidence suggests that people have been using copper for at least 11,000 years. Relatively \n"
                                                 + "easy to mine and refine, people discovered methods for extracting copper from its ores at least 7,000 years \n"
                                                 + "ago. The Roman Empire obtained most of its copper from the island of Cyprus, which is where copper's name \n"
                                                 + "originated. Today, copper is primarily obtained from the ores cuprite (CuO2), tenorite (CuO), malachite \n"
                                                 + "(CuO3·Cu(OH)2), chalcocite (Cu2S), covellite (CuS) and bornite (Cu6FeS4). Large deposits of copper ore are \n"
                                                 + "located in the United States, Chile, Zambia, Zaire, Peru and Canada.\n" 
                                                 +"Used in large amounts by the electrical industry in the form of wire, copper is second only to silver in \n"
                                                 + "electrical conductance. Since it resists corrosion from the air, moisture and seawater, copper has been \n"
                                                 + "widely used in coins. Although once made nearly entirely from copper, American pennies are now made from \n"
                                                 + "zinc that has been coated with copper. Copper is also used to make water pipes and jewelry, as well as \n"
                                                 + "other items.\n" 
                                                 +"Pure copper is usually too soft for most uses. People first learned about 5,000 years ago that copper can \n"
                                                 + "be strengthened if it is mixed with other metals. The two most familiar alloys of copper are bronze and \n"
                                                 + "brass. Bronze, the first alloy created by people, is a mix of copper that contains as much as 25% tin. \n"
                                                 + "Early people used bronze to make tools, weaponry, containers and ornamental items. Brass, a mix of copper \n"
                                                 + "that contains between 5% and 45% zinc, was first used about 2,500 years ago. The Romans were the first to \n"
                                                 + "make extensive use of brass, using it to make such things as coins, kettles and ornamental objects. Today, \n"
                                                 + "brass is also used in some musical instruments, screws and other hardware that must resist corrosion.\n" 
                                                 +"Hydrated copper sulfate (CuSO4·H2O), also known as blue vitriol, is the best known copper compound. It is \n"
                                                 + "used as an agricultural poison, as an algicide in water purification and as a blue pigment for inks. \n"
                                                 + "Cuperic chloride (CuCl2), another copper compound, is used to fix dyes to fabrics. Cuprous chloride (CuCl) \n"
                                                 + "is a poisonous white powder that is chiefly used to absorb carbon dioxide (CO2). Copper cyanide (CuCN) is \n"
                                                 + "commonly used in electroplating. \n"
        				  , "History & Uses of Copper", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Zinc      30
                if(first.getText().equals("Zn") || first.getText().equals("zinc") || first.getText().equals("Zinc")){
                    JOptionPane.showMessageDialog(null,
                                         "             Although zinc compounds have been used for at least 2,500 years in the production of brass, zinc wasn't \n"
                                                 + "recognized as a distinct element until much later. Metallic zinc was first produced in India sometime in \n"
                                                 + "the 1400s by heating the mineral calamine (ZnCO3) with wool. Zinc was rediscovered by Andreas Sigismund \n"
                                                 + "Marggraf in 1746 by heating calamine with charcoal. Today, most zinc is produced through the electrolysis \n"
                                                 + "of aqueous zinc sulfate (ZnSO4).\n" 
                                                 +"Roughly one third of all metallic zinc produced today is used in a process known as galvanization. During \n"
                                                 + "galvanization, an object that is subject to corrosion, such as an iron nail, is given a protective coating \n"
                                                 + "of zinc. The zinc can be applied to an object by dipping it in a pool of molten zinc, but it is most often \n"
                                                 + "applied through an electroplating process. Sacrificial zinc anodes are used in cathodic protection systems \n"
                                                 + "to protect exposed iron from corrosion. Metallic zinc is also used to make dry cell batteries, roof cladding \n"
                                                 + "and die castings.\n" 
                                                 +"Zinc is used to make many useful alloys. Brass, an alloy of zinc that contains between 55% and 95% copper, \n"
                                                 + "is probably the best known zinc alloy. Brass was first used about 2,500 years ago and was widely used by \n"
                                                 + "the ancient Romans, who used it to make such things as coins, kettles and decorative items. Brass is still \n"
                                                 + "used today, particularly in musical instruments, screws and other hardware that must resist corrosion. Zinc \n"
                                                 + "is alloyed with lead and tin to make solder, a metal with a relatively low melting point used to join \n"
                                                 + "electrical components, pipes and other metallic items. Prestal®, an alloy containing 78% zinc and 22% \n"
                                                 + "aluminum, is a strange material that is nearly as strong as steel but is molded as easily as plastic. \n"
                                                 + "Nickel silver, typewriter metal, spring brass and German silver are other common zinc alloys.\n" 
                                                 +"Zinc oxide (ZnO), a common zinc compound, forms when metallic zinc is exposed to the air and forms a \n"
                                                 + "protective coating that protects the rest of the metal. Zinc oxide is used in paints, some rubber products, \n"
                                                 + "cosmetics, pharmaceuticals, plastics, printing inks, soap and batteries, among other things. Zinc sulfide \n"
                                                 + "(ZnS), another zinc compound, glows when it is exposed to ultraviolet light, X-rays or electrons and is used \n"
                                                 + "to make luminous watch dials, television screens and fluorescent light bulbs. Zinc chloride (ZnCl2) is another \n"
                                                 + "zinc compound that is used to protect wood from decay and insects. \n"
        				  , "History & Uses of Zinc", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Gallium       31
                if(first.getText().equals("Ga") || first.getText().equals("gallium") || first.getText().equals("Gallium")){
                    JOptionPane.showMessageDialog(null,
                                         "             First proposed to exist by Dmitri Mendeleyev in 1871 based on gaps in his newly created \n"
                                                 + "Periodic Table of Elements, gallium was discovered spectroscopically by the French chemist \n"
                                                 + "Paul-Émile Lecoq de Boisbaudran in 1875. Later that same year, Lecoq was able to obtain \n"
                                                 + "pure gallium through the electrolysis of a solution of gallium hydroxide (Ga(OH)3) in \n"
                                                 + "potassium hydroxide (KOH). Trace amounts of gallium are found in diaspore, sphalerite, \n"
                                                 + "germanite and bauxite as well as in the byproducts of burning coal.\n" 
                                                 +"Gallium melts near room temperature and has one of the largest liquid ranges of any metal, \n"
                                                 + "so it has found use in high temperature thermometers. Gallium easily forms alloys with \n"
                                                 + "most metals and has been used to create low melting alloys. Gallium is used as a doping \n"
                                                 + "material for semiconductors and has been used to produce solid-state items like transistors \n"
                                                 + "and light emitting diodes. Gallium arsenide (GaAs) can produce laser light directly from \n"
                                                 + "electricity. Large amounts of gallium trichloride (GaCl3) have been gathered to build the \n"
                                                 + "Gallium Neutrino Observatory, an observatory located in Italy built to study particles \n"
                                                 + "called neutrinos which are produced inside the sun during the process of nuclear fusion. \n"
        				  , "History & Uses of Gallium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Germanium     32
                if(first.getText().equals("Ge") || first.getText().equals("germanium") || first.getText().equals("Germanium")){
                    JOptionPane.showMessageDialog(null,
                                         "            First proposed to exist by Dmitri Mendeleyev in 1871 based on gaps in his newly created \n "
                                                 + "Periodic Table of Elements, germanium was discovered by the German chemist Clemens Winkler \n"
                                                 + "in the mineral argyrodite (Ag8GeS6) in 1886. Today, germanium is primarily obtained from \n"
                                                 + "the smelting of zinc ores and from the byproducts of burning certain types of coal.\n" 
                                                 +"The largest use of germanium is in the semiconductor industry. When doped with small \n"
                                                 + "amounts of arsenic, gallium, indium, antimony or phosphorus, germanium is used to make \n"
                                                 + "transistors for use in electronic devices. Germanium is also used to create alloys and \n"
                                                 + "as a phosphor in fluorescent lamps. Both germanium and germanium oxide (GeO) are \n"
                                                 + "transparent to infrared radiation and are used in infrared optical instruments and \n"
                                                 + "infrared detectors. Some germanium compounds seem to be effective in killing some \n"
                                                 + "types of bacteria and are currently being studied for use in chemotherapy. \n"
        				  , "History & Uses of Germanium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Arsenic       33
                if(first.getText().equals("As") || first.getText().equals("arsenic") || first.getText().equals("Arsenic")){
                    JOptionPane.showMessageDialog(null,
                                         "             Although arsenic compounds were mined by the early Chinese, Greek and \n"
                                                 + "Egyptian civilizations, it is believed that arsenic itself was first \n"
                                                 + "identified by Albertus Magnus, a German alchemist, in 1250. Arsenic \n"
                                                 + "occurs free in nature, but is most often found in the minerals arsenopyrite \n"
                                                 + "(FeAsS), realgar (AsS) and orpiment (As2S3). Today, most commercial \n"
                                                 + "arsenic is obtained by heating arsenopyrite.\n" 
                                                 +"Arsenic and its compounds are poisonous. They have been used to make \n"
                                                 + "rat poison and some insecticides. Small amounts of arsenic are added \n"
                                                 + "to germanium to make transistors. Gallium arsenide (GaAs) can produce \n"
                                                 + "laser light directly from electricity.\n" 
                                                 +"If you were paying careful attention to the physical data listed above, \n"
                                                 + "you may have noticed that arsenic's boiling point is lower than its \n"
                                                 + "melting point. This occurs because these two temperatures are measured \n"
                                                 + "at different atmospheric pressures. When heated at standard atmospheric \n"
                                                 + "pressure, arsenic changes directly from a solid to a gas, or sublimates, \n"
                                                 + "at a temperature of 887 K. In order to form liquid arsenic, the atmospheric \n"
                                                 + "pressure must be increased. At 28 times standard atmospheric pressure, \n"
                                                 + "arsenic melts at a temperature of 1090 K. If it were also measured at a \n"
                                                 + "pressure of 28 atmospheres, arsenic's boiling point would be higher than \n"
                                                 + "its melting point, as you would expect. \n"
        				  , "History & Uses of Arsenic", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Selenium      34
                if(first.getText().equals("Se") || first.getText().equals("selenium") || first.getText().equals("Selenium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Selenium was discovered by Jöns Jacob Berzelius, a Swedish chemist, in \n"
                                                 + "1817 after analyzing an impurity that was contaminating the sulfuric acid \n"
                                                 + "(H2SO4) being produced at a particular factory in Sweden. Originally \n"
                                                 + "believing the material was tellurium, Berzelius eventually realized that \n"
                                                 + "it was actually a previously unknown element. Selenium occurs in minerals \n"
                                                 + "such as eucairite (CuAgSe), crooksite (CuThSe) and clausthalite (PbSe), \n"
                                                 + "but these minerals are too rare to use as a major source of selenium. \n"
                                                 + "Today, most selenium is obtained as a byproduct of refining copper.\n" 
                                                 +"Selenium's resistance to the flow of electricity is greatly affected by \n"
                                                 + "the amount of light shining on it. The brighter the light, the better \n"
                                                 + "selenium conducts electricity. This property has made selenium useful \n"
                                                 + "in devices that respond to the intensity of light, such as electric eyes, \n"
                                                 + "photo cells, light meters for cameras and copiers. Selenium can also \n"
                                                 + "produce electricity directly from sunlight and is used in solar cells. \n"
                                                 + "Selenium is also a semiconductor and is used in some types of solid-state \n"
                                                 + "electronics as well as in rectifiers, devices which convert alternating \n"
                                                 + "current electricity into direct current electricity. In addition to its \n"
                                                 + "use in electrical devices, selenium is also used to make a ruby-red color \n"
                                                 + "in glasses and enamels, as a photographic toner and as an additive to \n"
                                                 + "stainless steel.\n" 
                                                 +"Selenium forms few inorganic compounds, none of which are commercially \n"
                                                 + "important. They include selenious acid (H2SeO3), selenium dichloride \n"
                                                 + "(SeCl2) and selenium oxychloride (SeOCl2). \n"
        				  , "History & Uses of Selenium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Bromine       35
                if(first.getText().equals("Br") || first.getText().equals("bromine") || first.getText().equals("Bromine")){
                    JOptionPane.showMessageDialog(null,
                                         "            The only nonmetallic element that is a liquid at normal room temperatures, bromine \nwas "
                                                 + "produced by Carl Löwig, a young chemistry student, the summer before starting \n"
                                                 + "his freshman year at Heidelberg. When he showed his professor, Leopold Gmelin, \n"
                                                 + "the red, smelly liquid he had produced, Gmelin realized that this was an unknown \n"
                                                 + "substance and encouraged Löwig to produce more of it so they could study it in \n"
                                                 + "detail. Unfortunately, winter exams and the holidays delayed Löwig's work long \n"
                                                 + "enough for another chemist, Antoine-Jérôme Balard, to publish a paper in 1826 \n"
                                                 + "describing the new element. Balard was credited with the discovery and named it \n"
                                                 + "after the greek word for stench, bromos. Today, bromine is primarily obtained \n"
                                                 + "by treating brines from wells in Michigan and Arkansas with chlorine.\n" 
                                                 +"Elemental bromine is a hazardous material. It causes severe burns when it comes \n"
                                                 + "in contact with the skin and its vapor irritates the eyes, nose and throat. Most \n"
                                                 + "of the bromine produced in the United States was used in the manufacture of \n"
                                                 + "ethylene dibromide(C2H4Br2), a chemical added to leaded gasolines that prevented \n"
                                                 + "the accumulation of lead compounds within the engine. With the discontinuation \n"
                                                 + "of leaded gasolines in favor of unleaded gasolines, the demand for bromine has \n"
                                                 + "been greatly reduced. Silver bromide (AgBr), a chemical used in photography, \n"
                                                 + "now accounts for the largest use of bromine. Other bromine compounds are used \n"
                                                 + "in fumigants, in flameproofing agents and in some compounds used to purify water. \n"
                                                 + "Tyrian purple, an expensive purple dye known to ancient civilizations, was \n"
                                                 + "produced from an organic bromine compound secreted from a sea mussel known as \n"
                                                 + "the murex. \n"
        				  , "History & Uses of Bromine", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Krypton       36
                if(first.getText().equals("Kr") || first.getText().equals("krypton") || first.getText().equals("Krypton")){
                    JOptionPane.showMessageDialog(null,
                                         "             Krypton was discovered on May 30, 1898 by Sir William Ramsay, a Scottish chemist, /n"
                                                 + "and Morris M. Travers, an English chemist, while studying liquefied air. Small amounts /n"
                                                 + "of liquid krypton remained behind after the more volatile components of liquid air had /n"
                                                 + "boiled away. The earth's atmosphere is about 0.0001% krypton.\n" 
                                                 +"The high cost of obtaining krypton from the air has limited its practical applications. /n"
                                                 + "Krypton is used in some types of photographic flashes used in high speed photography. /n"
                                                 + "Some fluorescent light bulbs are filled with a mixture of krypton and argon gases. /n"
                                                 + "Krypton gas is also combined with other gases to make luminous signs that glow with a /n"
                                                 + "greenish-yellow light. In 1960, the length of the meter was defined in terms of the /n"
                                                 + "orange-red spectral line of krypton-86, an isotope of krypton.\n" 
                                                 +"Once thought to be completely inert, krypton is known to form a few compounds. Krypton /n"
                                                 + "difluoride (KrF2) is the easiest krypton compound to make and gram amounts of it have /n"
                                                 + "been produced. /n"
        				  , "History & Uses of Krypton", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Rubidium      37
                if(first.getText().equals("Rb") || first.getText().equals("rubidium") || first.getText().equals("Rubidium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Rubidium was discovered by the German chemists Robert Bunsen and Gustav Kirchhoff in 1861 while \n"
                                                 + "analyzing samples of the mineral lepidolite (KLi2Al(Al, Si)3O10(F, OH)2) with a device called a \n"
                                                 + "spectroscope. The sample produced a set of deep red spectral lines they had never seen before. \n"
                                                 + "Bunsen was eventually able to isolate samples of rubidium metal. Today, most rubidium is obtained \n"
                                                 + "as a byproduct of refining lithium.\n" 
                                                 +"Rubidium is used in vacuum tubes as a getter, a material that combines with and removes trace gases \n"
                                                 + "from vacuum tubes. It is also used in the manufacture of photocells and in special glasses. Since \n"
                                                 + "it is easily ionized, it might be used as a propellant in ion engines on spacecraft. Recent \n"
                                                 + "discoveries of large deposits of rubidium suggest that its usefulness will increase as its properties \n"
                                                 + "become better understood.\n" 
                                                 +"Rubidium forms a large number of compounds, although none of them has any significant commercial \n"
                                                 + "application. Some of the common rubidium compounds are: rubidium chloride (RbCl), rubidium monoxide \n"
                                                 + "(Rb2O) and rubidium copper sulfate Rb2SO4·CuSO4·6H20). A compound of rubidium, silver and iodine, \n"
                                                 + "RbAg4I5, has interesting electrical characteristics and might be useful in thin film batteries. \n"
        				  , "History & Uses of Rubidium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Strontium     38
                if(first.getText().equals("Sr") || first.getText().equals("strontium") || first.getText().equals("Strontium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Strontium was discovered by Adair Crawford, an Irish chemist, in 1790 while studying the mineral \n"
                                                 + "witherite (BaCO3). When he mixed witherite with hydrochloric acid (HCl) he did not get the results he \n"
                                                 + "expected. He assumed that his sample of witherite was contaminated with an unknown mineral, a mineral \n"
                                                 + "he named strontianite (SrCO3). Strontium was first isolated by Sir Humphry Davy, an English chemist, in \n"
                                                 + "1808 through the electrolysis of a mixture of strontium chloride (SrCl2) and mercuric oxide (HgO). \n"
                                                 + "Today, strontium is obtained from two of its most common ores, celestite (SrSO4) and strontianite \n"
                                                 + "(SrCO3), by treating them with hydrochloric acid, forming strontium chloride. The strontium chloride, \n"
                                                 + "usually mixed with potassium chloride (KCl), is then melted and electrolyzed, forming strontium and \n"
                                                 + "chlorine gas (Cl2).\n" 
                                                 +"Most of the strontium produced today is used in the manufacture of color television picture tubes. It is \n"
                                                 + "also used to refine zinc and is combined with iron to make magnets.\n" 
                                                 +"Two strontium compounds, strontium carbonate (SrCO3) and strontium nitrate (Sr(NO3)2), burn with a \n"
                                                 + "bright, red flame and are used in fireworks and signal flares. Strontium carbonate is also used to \n"
                                                 + "make certain kinds of glass and is the base material for making most other strontium compounds.\n" 
                                                 +"Strontium-90, a radioactive isotope of strontium, is a common product of nuclear explosions. It has \n"
                                                 + "a half-life of about 28.8 years and decays into yttrium-90 through beta decay. Strontium-90 is \n"
                                                 + "especially deadly since it has a relatively long half-life, is strongly radioactive and is absorbed \n"
                                                 + "by the body, where it accumulates in the skeletal system. The radiation affects the production of \n"
                                                 + "new blood cells, which eventually leads to death. \n"
        				  , "History & Uses of Strontium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Yttrium       39
                if(first.getText().equals("Y") || first.getText().equals("yttrium") || first.getText().equals("Yttrium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Yttrium was discovered by Johan Gadolin, a Finnish chemist, while analyzing the composition \n"
                                                 + "of the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) in 1789. Gadolinite, which was named for \n"
                                                 + "Johan Gadolin, was discovered several years earlier in a quarry near the town of Ytterby, Sweden. \n"
                                                 + "Today, yttrium is primarily obtained through an ion exchange process from monazite sand ((Ce, La, \n"
                                                 + "Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Although metallic yttrium is not widely used, several of its compounds are. Yttrium oxide (Y2O3) \n"
                                                 + "and yttrium orthovanadate (YVO4) are both combined with europium to produce the red phosphor used \n"
                                                 + "in color televisions. Garnets made from yttrium and iron (Y3Fe5O12) are used as microwave filters \n"
                                                 + "in microwave communications equipment. Garnets made from yttrium and aluminum (Y3Al5O12) are used \n"
                                                 + "in jewelry as simulated diamond. \n"
        				  , "History & Uses of Yttrium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Zirconium     40
                if(first.getText().equals("Zr") || first.getText().equals("zirconium") || first.getText().equals("Zirconium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Zirconium was discovered by Martin Heinrich Klaproth, a German chemist, while analyzing the \n"
                                                 + "composition of the mineral jargon (ZrSiO4) in 1789. Zirconium was isolated by Jöns Jacob Berzelius, \n"
                                                 + "a Swedish chemist, in 1824 and finally prepared in a pure form in 1914. Obtaining pure zirconium \n"
                                                 + "is very difficult because it is chemically similar to hafnium, an element which is always found \n"
                                                 + "mixed with deposits of zirconium. Today, most zirconium is obtained from the minerals zircon \n"
                                                 + "(ZrSiO4) and baddeleyite (ZrO2) through a process known as the Kroll Process.\n" 
                                                 +"Zirconium is a corrosion resistant metal that is used in high performance pumps and valves. Since \n"
                                                 + "it also does not easily absorb neutrons, zirconium is widely used in nuclear reactors. The nuclear \n"
                                                 + "power industry uses nearly 90% of the zirconium produced each year, which must be nearly free of \n"
                                                 + "hafnium. Zirconium is also used as an alloying agent in steel, to make some types of surgical \n"
                                                 + "equipment and as a getter, a material that combines with and removes trace gases from vacuum \n"
                                                 + "tubes.\n" 
                                                 +"Zircon (ZrSiO4) is a zirconium compound that can take many different forms, the most popular of \n"
                                                 + "which is a clear, transparent gemstone that can be cut to look like diamond and is frequently \n"
                                                 + "used in jewelry. Zirconium dioxide (ZrO2) can withstand very high temperatures and is used to \n"
                                                 + "make crucibles and to line the walls of high temperature furnaces. Zirconium carbonate \n"
                                                 + "(3ZrO2·CO2·H2O) is used in lotions to treat poison ivy. \n"
        				  , "History & Uses of Zirconium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Niobium       41
                if(first.getText().equals("Nb") || first.getText().equals("niobium") || first.getText().equals("Niobium")){
                    JOptionPane.showMessageDialog(null,
                                         "                The story of niobium's discovery is a bit confusing. The first governor of Connecticut, John Winthrop the Younger, \n"
                                                 + "discovered a new mineral around 1734. He named the mineral columbite ((Fe, Mn, Mg)(Nb, Ta)2O6) and sent a sample of it to \n"
                                                 + "the British Museum in London, England. The columbite sat in the museum's mineral collection for years until it was analyzed \n"
                                                 + "by Charles Hatchett in 1801. Hatchett could tell that there was an unknown element in the columbite, but he was not able \n"
                                                 + "to isolate it. He named the new element columbium.\n" 
                                                 +"The fate of columbium took a drastic turn in 1809 when William Hyde Wollaston, an English chemist and physicist, compared \n"
                                                 + "the minerals columbite and tantalite ((Fe, Mn)(Ta, Nb)2O6) and declared that columbium was actually the element tantalum. \n"
                                                 + "This confusion arose because tantalum and niobium are similar metals, are always found together and are very difficult to \n"
                                                 + "isolate.\n" 
                                                 +"Niobium was rediscovered and renamed by Heinrich Rose in 1844 when he produced two new acids, niobic acid and pelopic acid, \n"
                                                 + "from samples of columbite and tantalite. These acids are very similar to each other and it took another twenty-two years \n"
                                                 + "and a Swiss chemist named Jean Charles Galissard de Marignac to prove that these were two distinct chemicals produced from \n"
                                                 + "two different elements. Metallic niobium was finally isolated by the Swedish chemist Christian Wilhelm Blomstrand in 1864. \n"
                                                 + "Today, niobium is primarily obtained from the minerals columbite and pyrochlore ((Ca, Na)2Nb2O6(O, OH, F)).\n" 
                                                 +"Niobium is used as an alloying agent and for jewelry, but perhaps its most interesting applications are in the field of \n"
                                                 + "superconductivity. Superconductive wire can be made from an alloy of niobium and titanium which can then be used to make \n"
                                                 + "superconductive magnets. Other alloys of niobium, such as those with tin and aluminum, are superconductive as well. Pure \n"
                                                 + "niobium is itself a superconductor when it is cooled below 9.25 K (-442.75°F). Superconductive niobium cavities are at the \n"
                                                 + "heart of a machine built at the Thomas Jefferson National Accelerator Facility. This machine, called an electron accelerator, \n"
                                                 + "is used by scientists to study the quark structure of matter. The accelerator's 338 niobium cavities are bathed in liquid \n"
                                                 + "helium and accelerate electrons to nearly the speed of light. \n"
        				  , "History & Uses of Niobium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Molybdenum        42
                if(first.getText().equals("Mo") || first.getText().equals("molybdenum") || first.getText().equals("Molybdenum")){
                    JOptionPane.showMessageDialog(null,
                                         "              Molybdenum was discovered by Carl Welhelm Scheele, a Swedish chemist, in 1778 in a mineral known as molybdenite (MoS2) which \n"
                                                 + "had been confused as a lead compound. Molybdenum was isolated by Peter Jacob Hjelm in 1781. Today, most molybdenum is obtained \n"
                                                 + "from molybdenite, wulfenite (PbMoO4) and powellite (CaMoO4). These ores typically occur in conjunction with ores of tin and tungsten. \n"
                                                 + "Molybdenum is also obtained as a byproduct of mining and processing tungsten and copper.\n" 
                                                 +"Molybdenum has a high melting point and is used to make the electrodes of electrically heated glass furnaces. Some electrical \n"
                                                 + "filaments are also made from molybdenum. The metal is used to make some missile and aircraft parts and is used in the nuclear \n"
                                                 + "power industry. Molybdenum is also used as a catalyst in the refining of petroleum.\n" 
                                                 +"Molybdenum is primarily used as an alloying agent in steel. When added to steel in concentrations between 0.25% and 8%, molybdenum \n"
                                                 + "forms ultra-high strength steels that can withstand pressures up to 300,000 pounds per square inch. Molybdenum also improves the \n"
                                                 + "strength of steel at high temperatures. When alloyed with nickel, molybdenum forms heat and corrosion resistant materials used in \n"
                                                 + "the chemical industry.\n" 
                                                 +"Molybdenum disulphide (MoS2), one of molybdenum's compounds, is used as a high temperature lubricant. Molybdenum trioxide (MoO3), \n"
                                                 + "another molybdenum compound, is used to adhere enamels to metals. Other molybdenum compounds include: molybdic acid (H2MoO4), \n"
                                                 + "molybdenum hexafluoride (MoF6) and molybdenum phosphide (MoP2). \n"
        				  , "History & Uses of Molybdenum", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Technetium        43
                if(first.getText().equals("Tc") || first.getText().equals("technetium") || first.getText().equals("Technetium")){
                    JOptionPane.showMessageDialog(null,
                                         "               Technetium was the first artificially produced element. It was isolated by Carlo Perrier and Emilio Segrè in 1937. \n"
                                                 + "Technetium was created by bombarding molybdenum atoms with deuterons that had been accelerated by a device called a \n"
                                                 + "cyclotron.\n" 
                                                 +"Today, technetium is produced by bombarding molybdenum-98 with neutrons. Molybdenum-98 becomes molybdenum-99 when it \n"
                                                 + "captures a neutron. Molybdenum-99, with a half-life of 65.94 hours, decays into technetium-99 through beta decay. \n"
                                                 + "While technetium has never been found to occur naturally on earth, its spectral lines have been observed in S-, M- \n"
                                                 + "and N-type stars.\n" 
                                                 +"Technetium's most stable isotope, technetium-98, has a half-life of about 4,200,000 years. It decays into ruthenium-98 \n"
                                                 + "through beta decay.\n" 
                                                 +"Small amounts of technetium can retard the corrosion of steel, although this protection can only be applied to closed \n"
                                                 + "systems due to technetium's radioactivity. Technetium can also be used as a medical tracer and to calibrate particle \n"
                                                 + "detectors."
        				  , "History & Uses of Technetium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Ruthenium     44
                if(first.getText().equals("Ru") || first.getText().equals("ruthenium") || first.getText().equals("Ruthenium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Ruthenium was discovered by Karl Karlovich Klaus, a Russian chemist, in 1844 while analyzing the residue of a \n"
                                                 + "sample of platinum ore obtained from the Ural mountains. Apparently, Jedrzej Sniadecki, a Polish chemist, had \n"
                                                 + "produced ruthenium in 1807 but he withdrew his claim of discovery after other scientists failed to replicate his \n"
                                                 + "results. Ruthenium tends to occur along with deposits of platinum and is primarily obtained as a byproduct of \n"
                                                 + "mining and refining platinum. Ruthenium is also obtained as a byproduct of the nickel mining operation in the \n"
                                                 + "Sudbury region of Ontario, Canada.\n" 
                                                 +"Ruthenium is primarily used as an alloying agent. Adding 0.1% ruthenium to titanium makes titanium 100 times more \n"
                                                 + "resistant to corrosion. Small amounts of ruthenium are added to platinum and palladium to strengthen them. These \n"
                                                 + "alloys are used in jewelry and in electrical contacts that must resist wear. \n"
        				  , "History & Uses of Ruthenium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Rhodium       45
                if(first.getText().equals("Rh") || first.getText().equals("rhodium") || first.getText().equals("Rhodium")){
                    JOptionPane.showMessageDialog(null,
                                         "               Rhodium was discovered by William Hyde Wollaston, an English chemist, in 1803 shortly after his \n"
                                                 + "discovery of the element palladium. He obtained rhodium from a sample of platinum ore that was \n"
                                                 + "obtained from South America. After removing the platinum and palladium from the sample, he was \n"
                                                 + "left with a dark red powder. The powder turned out to be sodium rhodium chloride (Na3RhCl6·12H2O). \n"
                                                 + "Wollaston obtained rhodium from the powder by treating it with hydrogen gas (H2). Rhodium tends to \n"
                                                 + "occur along with deposits of platinum and is primarily obtained as a byproduct of mining and \n"
                                                 + "refining platinum. Rhodium is also obtained as a byproduct of the nickel mining operation in the \n"
                                                 + "Sudbury region of Ontario, Canada.\n" 
                                                 +"Rhodium is used to make electrical contacts, as jewelry and in catalytic converters, but is most \n"
                                                 + "frequently used as an alloying agent in other materials, such as platinum and palladium. These \n"
                                                 + "alloys are used to make such things as furnace coils, electrodes for aircraft spark plugs and \n"
                                                 + "laboratory crucibles. \n"
        				  , "History & Uses of Rhodium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Palladium     46
                if(first.getText().equals("Pd") || first.getText().equals("palladium") || first.getText().equals("Palladium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Palladium was discovered by William Hyde Wollaston, an English chemist, in 1803 while analyzing \n"
                                                 + "samples of platinum ore that were obtained from South America. Although it is a rare element,  \n"
                                                 + "palladium tends to occur along with deposits of platinum, nickel, copper, silver and gold and is \n"
                                                 + "recovered as a byproduct of mining these other metals.\n" 
                                                 +"Palladium is used to make springs for watches, surgical instruments, electrical contacts and dental \n"
                                                 + "fillings and crowns. Finely divided palladium acts as a catalyst and is used in hydrogenation and \n"
                                                 + "dehydrogenation processes. Palladium at room temperature can absorb up to 900 times its own volume \n"
                                                 + "of hydrogen. Hydrogen will easily pass through heated palladium, a property that allows for the \n"
                                                 + "easy purification of hydrogen. Palladium alloys are used to make jewelry and, when alloyed with \n"
                                                 + "gold, forms a material known as white gold.\n" 
                                                 +"Palladium dichloride (PdCl2), a palladium compound, can absorb large amounts of carbon monoxide \n"
                                                 + "(CO) gas and is used in carbon monoxide detectors. \n"
        				  , "History & Uses of Palladium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Silver        47
                if(first.getText().equals("Ag") || first.getText().equals("silver") || first.getText().equals("Silver")){
                    JOptionPane.showMessageDialog(null,
                                         "             Archaeological evidence suggests that people have been using silver for at \n"
                                                 + "least 5000 years. Silver can be obtained from pure deposits, from silver ores \n"
                                                 + "such as argentite (Ag2S) and horn silver (AgCl), and in conjunction with deposits \n"
                                                 + "of ores containing lead, gold or copper.\n" 
                                                 +"Silver and silver compounds have many uses. Pure silver is the best conductor \n"
                                                 + "of heat and electricity of all known metals, so it is sometimes used in making \n"
                                                 + "solder, electrical contacts and printed circuit boards. Silver is also the best \n"
                                                 + "reflector of visible light known, but silver mirrors must be given a protective \n"
                                                 + "coating to prevent them from tarnishing. Silver has also been used to create \n"
                                                 + "coins, although today other metals are typically used in its place. Sterling \n"
                                                 + "silver, an alloy containing 92.5% silver, is used to make silverware, jewelry \n"
                                                 + "and other decorative items. High capacity batteries can be made with silver and \n"
                                                 + "zinc and silver and cadmium. Sliver nitrate (AgNO3) is light sensitive and is used \n"
                                                 + "to make photographic films and papers. Silver iodide (AgI) is used to seed clouds \n"
                                                 + "to produce rain. \n"
        				  , "History & Uses of Silver", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Cadmium       48
                if(first.getText().equals("Cd") || first.getText().equals("cadmium") || first.getText().equals("Cadmium")){
                    JOptionPane.showMessageDialog(null,
                                         "               Cadmium was discovered by Friedrich Strohmeyer, a German chemist, in 1817 while studying \n"
                                                 + "samples of calamine (ZnCO3). When heated, Strohmeyer noticed that some samples of calamine \n"
                                                 + "glowed with a yellow color while other samples did not. After further examination, he determined \n"
                                                 + "that the calamine that changed color when heated contained trace amounts of a new element. \n"
                                                 + "There is only one mineral that contains significant amounts of cadmium, greenockite (CdS), \n"
                                                 + "but it is not common enough to mine profitably. Fortunately, small amounts of cadmium are \n"
                                                 + "found in zinc ores and most of the cadmium produced today is obtained as a byproduct of mining \n"
                                                 + "and refining zinc.\n" 
                                                 +"Cadmium is a poisonous metal and its use is somewhat limited for this reason. Like zinc, cadmium \n"
                                                 + "can be electroplated to other materials to protect them from corrosion. Cadmium easily absorbs \n"
                                                 + "neutrons and is used to make control rods for nuclear reactors. Cadmium is also used in \n"
                                                 + "rechargeable nickel-cadmium batteries.\n" 
                                                 +"Cadmium is alloyed with silver to form solder, a metal with a relatively low melting point used \n"
                                                 + "to join electrical components, pipes and other metallic items. Cadmium based solders must be \n"
                                                 + "handled with care to prevent cadmium poisoning. Cadmium alloys are also used to make low friction \n"
                                                 + "bearings that are highly resistant to fatigue.\n" 
                                                 +"Hydrated cadmium sulfate (3CdSO4·5H2O), one of cadmium's compounds, is used in a device called a \n"
                                                 + "Weston cell, a type of battery that produces a precise voltage used to calibrate medical and \n"
                                                 + "laboratory equipment. Cadmium sulfide (CdS), another cadmium compound, is a yellow powder that \n"
                                                 + "is used as a pigment. Other cadmium compounds are used in the phosphors of black and white \n"
                                                 + "television sets and in the blue and green phosphors in color television sets. \n"
        				  , "History & Uses of Cadmium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Indium        49
                if(first.getText().equals("In") || first.getText().equals("indium") || first.getText().equals("Indium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Indium was discovered by the German chemists Ferdinand Reich and \n"
                                                 + "Hieronymus Theodor Richter in 1863. Reich and Richter had been looking \n"
                                                 + "for traces of the element thallium in samples of zinc ores. A brilliant \n"
                                                 + "indigo line in the sample's spectrum revealed the existence of indium. \n"
                                                 + "Indium is about as abundant as silver but is much easier to recover \n"
                                                 + "since it typically occurs along with zinc, iron, lead and copper ores.\n" 
                                                 +"Indium is used to coat the bearings of high speed motors since it allows \n"
                                                 + "for the even distribution of lubricating oil. Indium is used to dope \n"
                                                 + "germanium to make transistors. It is also used to make other electrical \n"
                                                 + "components such as rectifiers, thermistors and photoconductors. Indium \n"
                                                 + "can be used to make mirrors that are as reflective as silver mirrors but \n"
                                                 + "do not tarnish as quickly. Indium is also used to make low melting \n"
                                                 + "alloys. An alloy of 24% indium and 76% gallium is a liquid at room \n"
                                                 + "temperature. \n"
        				  , "History & Uses of Indium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Tin       50
                if(first.getText().equals("Sn") || first.getText().equals("tin") || first.getText().equals("Tin")){
                    JOptionPane.showMessageDialog(null,
                                         "             Archaeological evidence suggests that people have been using tin for at least 5500 years. \n"
                                                 + "Tin is primarily obtained from the mineral cassiterite (SnO2) and is extracted by roasting \n"
                                                 + "cassiterite in a furnace with carbon. Tin makes up only about 0.001% of the earth's crust and \n"
                                                 + "is chiefly mined in Malaysia.\n" 
                                                 +"Two allotropes of tin occur near room temperature. The first form of tin is called gray tin \n"
                                                 + "and is stable at temperatures below 13.2°C (55.76°F). There are few, if any, uses for gray tin. \n"
                                                 + "At temperatures above 13.2°C, gray tin slowly turns into tin's second form, white tin. White \n"
                                                 + "tin is the normal form of the metal and has many uses. Unfortunately, white tin will turn into \n"
                                                 + "gray tin if its temperature falls below 13.2°C. This change can be prevented if small amounts \n"
                                                 + "of antimony or bismuth are added to white tin.\n" 
                                                 +"Tin resists corrosion and is used as a protective coating on other metals. Tin cans are probably \n"
                                                 + "the most familiar example of this application. A tin can is actually made from steel. A thin \n"
                                                 + "layer of tin is applied to the inside and outside of the can to keep the steel from rusting. \n"
                                                 + "Once widely used, tin cans have largely been replaced with plastic and aluminum containers.\n" 
                                                 +"Tin is used in the Pilkington process to produce window glass. In the Pilkington process, molten \n"
                                                 + "glass is poured onto a pool of molten tin. The glass floats on the surface of the tin and cools, \n"
                                                 + "forming solid glass with flat, parallel surfaces. Most of the window glass produced today is \n"
                                                 + "made this way.\n" 
                                                 +"Tin is used to form many useful alloys. Bronze is an alloy of tin and copper. Tin and lead are \n"
                                                 + "alloyed to make pewter and solder. An alloy of tin and niobium is used to make superconductive \n"
                                                 + "wire. Type metal, fusible metal, bell metal and Babbitt metal are other examples of tin alloys.\n" 
                                                 +"Tin salts can be sprayed onto glass to make electrically conductive coatings. These can then be \n"
                                                 + "used to make panel lighting and frost-free windshields. Stannous fluoride (SnF2) is used in \n"
                                                 + "some types of toothpaste. \n"
        				  , "History & Uses of Tin", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Antimony      51
                if(first.getText().equals("Sb") || first.getText().equals("antimony") || first.getText().equals("Antimony")){
                    JOptionPane.showMessageDialog(null,
                                         "               Antimony has been known since ancient times. It is sometimes found free in nature, \n"
                                                 + "but is usually obtained from the ores stibnite (Sb2S3) and valentinite (Sb2O3). Nicolas \n"
                                                 + "Lémery, a French chemist, was the first person to scientifically study antimony and its \n"
                                                 + "compounds. He published his findings in 1707. Antimony makes up about 0.00002% of the \n"
                                                 + "earth's crust.\n" 
                                                 +"Antimony is a brittle metal and is a poor conductor of heat and electricity. Very pure \n"
                                                 + "antimony is used to make certain types of semiconductor devices, such as diodes and \n"
                                                 + "infrared detectors. Antimony is alloyed with lead to increase lead's durability. \n"
                                                 + "Antimony alloys are also used in batteries, low friction metals, type metal and cable \n"
                                                 + "sheathing, among other products. Antimony compounds are used to make flame-proofing \n"
                                                 + "materials, paints, ceramic enamels, glass and pottery. The ancient Egyptians used \n"
                                                 + "antimony, in the form of stibnite, for black eye make-up. \n"
        				  , "History & Uses of Antimony", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Tellurium     52
                if(first.getText().equals("Te") || first.getText().equals("tellurium") || first.getText().equals("Tellurium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Tellurium was discovered by Franz Joseph Müller von Reichenstein, a Romanian mining official, \n"
                                                 + "in 1782. Reichenstein was the chief inspector of all mines, smelters and saltworks in Transylvania. \n"
                                                 + "He also had an interest in chemistry and extracted a new metal from an ore of gold, known as aurum \n"
                                                 + "album, which he believed was antinomy. He shortly realized that the metal he had produced wasn't \n"
                                                 + "antimony at all, but a previously unknown element. Reichenstein's work was forgotten until 1798 when \n"
                                                 + "Martin Heinrich Klaproth, a German chemist, mentioned the substance in a paper. Klaproth named the \n"
                                                 + "new element tellurium but gave full credit for its discovery to Reichenstein. Tellurium is found free \n"
                                                 + "in nature, but is most often found in the ores sylvanite (AgAuTe4), calaverite (AuTe2) and krennerite \n"
                                                 + "(AuTe2). Today, most tellurium is obtained as a byproduct of mining and refining copper.\n" 
                                                 +"Tellurium is a semiconductor and is frequently doped with copper, tin, gold or silver. Tellurium is \n"
                                                 + "also used to color glass and ceramics and is one of the primary ingredients in blasting caps.\n" 
                                                 +"Tellurium is primarily used as an alloying agent. Small amounts of tellurium are added to copper and \n"
                                                 + "stainless steel to make them easier to machine and mill. Tellurium is also added to lead to increase \n"
                                                 + "its strength and resistance to sulfuric acid (H2SO4).\n" 
                                                 +"Tellurium forms many compounds, but none that are commercially important. They include: tellourous \n"
                                                 + "acid (H2TeO2), tellurium tetrachloride (TeCl4), tellurium dichloride (TeCl2), tellurium trioxide \n"
                                                 + "(TeO3), tellurium monoxide (TeO) and sodium telluride (Na2Te). \n"
        				  , "History & Uses of Tellurium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Iodine        53
                if(first.getText().equals("I") || first.getText().equals("iodine") || first.getText().equals("Iodine")){
                    JOptionPane.showMessageDialog(null,
                                         "               Iodine was discovered by the French chemist Barnard Courtois in 1811. Courtois was extracting \n"
                                                 + "sodium and potassium compounds from seaweed ash. Once these compounds were removed, he added sulfuric \n"
                                                 + "acid (H2SO4) to further process the ash. He accidentally added too much acid and a violet colored \n"
                                                 + "cloud erupted from the mass. The gas condensed on metal objects in the room, creating solid iodine. \n"
                                                 + "Today, iodine is chiefly obtained from deposits of sodium iodate (NaIO3) and sodium periodate (NaIO4) \n"
                                                 + "in Chile and Bolivia.\n" 
                                                 +"Trace amounts of iodine are required by the human body. Iodine is part of thyroxin, a hormone produced \n"
                                                 + "by the thyroid gland that controls the body's rate of physical and mental development. A lack of \n"
                                                 + "iodine can also cause a goiter, a swelling of the thyroid gland. Iodine is added to salt (iodized salt) \n"
                                                 + "to prevent these diseases.\n" 
                                                 +"Iodine is used as a test for starch and turns a deep blue when it comes in contact with it. Potassium \n"
                                                 + "iodide (KI) is used to make photographic film and, when mixed with iodine in alcohol, as an antiseptic \n"
                                                 + "for external wounds. A radioactive isotope of iodine, iodine-131, is used to treat some diseases of \n"
                                                 + "the thyroid gland.\n" 
                                                 +"Care should be taken in handling and using iodine. It can burn the skin and damage the eyes and mucous \n"
                                                 + "membranes. Pure iodine is poisonous if ingested. \n"
        				  , "History & Uses of Iodine", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Xenon     54
                if(first.getText().equals("Xe") || first.getText().equals("xenon") || first.getText().equals("Xenon")){
                    JOptionPane.showMessageDialog(null,
                                         "               Xenon was discovered by Sir William Ramsay, a Scottish chemist, and \n"
                                                 + "Morris M. Travers, an English chemist, on July 12, 1898, shortly after \n"
                                                 + "their discovery of the elements krypton and neon. Like krypton and neon, \n"
                                                 + "xenon was discovered through the study of liquefied air. The earth's \n"
                                                 + "atmosphere is about 0.0000087% xenon.\n" 
                                                 +"Xenon produces a brilliant white flash of light when it is excited \n"
                                                 + "electrically and is widely used in strobe lights. The light emitted \n"
                                                 + "from xenon lamps is also used to kill bacteria and to power ruby lasers.\n" 
                                                 +"Due to its high atomic weight, xenon ions were used as a fuel in an \n"
                                                 + "experimental ion engine aboard the space probe Deep Space 1.\n" 
                                                 +"Once thought to be completely inert, xenon will form compounds, usually \n"
                                                 + "with fluorine, oxygen and platinum. XePtF6, XeF2, XeF4, XeF6 and XeO4 \n"
                                                 + "are some of the xenon compounds that have been formed. \n"
        				  , "History & Uses of Xenon", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Cesium        55
                if(first.getText().equals("Cs") || first.getText().equals("cesium") || first.getText().equals("Cesium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Cesium was discovered by Robert Wilhelm Bunsen and Gustav Robert Kirchhoff, \n"
                                                 + "German chemists, in 1860 through the spectroscopic analysis of Durkheim mineral \n"
                                                 + "water. They named cesium after the blue lines they observed in its spectrum. Today, \n"
                                                 + "cesium is primarily obtained from the mineral pollucite (CsAlSi2O6). Obtaining \n"
                                                 + "pure cesium is difficult since cesium ores are frequently contaminated with \n"
                                                 + "rubidium, an element that is chemically similar to cesium. To obtain pure cesium, \n"
                                                 + "cesium and rubidium ores are crushed and heated with sodium metal to 650°C, \n"
                                                 + "forming an alloy that can then be separated with a process known as fractional \n"
                                                 + "distillation. Metallic cesium is too reactive to easily handle and is usually \n"
                                                 + "sold in the form of cesium azide (CsN3). Cesium is recovered from cesium azide \n"
                                                 + "by heating it.\n" 
                                                 +"Cesium has the second lowest melting point of all metallic elements, which limits \n"
                                                 + "its uses. Cesium readily combines with oxygen and is used as a getter, a material \n"
                                                 + "that combines with and removes trace gases from vacuum tubes. Cesium is also used \n"
                                                 + "in atomic clocks, in photoelectric cells and as a catalyst in the hydrogenation of \n"
                                                 + "certain organic compounds. Since it is easily ionized and has a high mass, cesium \n"
                                                 + "ions may one day be used as a propellant in ion engines on spacecraft.\n" 
                                                 +"Cesium reacts violently with water and ice, forming cesium hydroxide (CsOH). Cesium \n"
                                                 + "hydroxide is the strongest base known and will attack glass. Cesium chloride (CsCl) \n"
                                                 + "and cesium nitrate (CsNO3) are cesium's most common compounds and are primarily used \n"
                                                 + "in the production of other chemicals. \n"
        				  , "History & Uses of Cesium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Barium        56
                if(first.getText().equals("Ba") || first.getText().equals("barium") || first.getText().equals("Barium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Barium was first isolated by Sir Humphry Davy, an English chemist, in 1808 through the \n"
                                                 + "electrolysis of molten baryta (BaO). Barium is never found free in nature since it reacts \n"
                                                 + "with oxygen in the air, forming barium oxide (BaO), and with water, forming barium hydroxide \n"
                                                 + "(Ba(OH)2) and hydrogen gas (H2). Barium is most commonly found as the mineral barite (BaSO4) \n"
                                                 + "and witherite (BaCO3) and is primarily produced through the electrolysis of barium chloride \n"
                                                 + "(BaCl2).\n" 
                                                 +"Barium is used as a getter, a material that combines with and removes trace gases from \n"
                                                 + "vacuum tubes.\n" 
                                                 +"Barium sulfate (BaSO4), a common barium compound, is used as a filler for rubber, plastics \n"
                                                 + "and resins. It can be combined with zinc oxide (ZnO) to make a white pigment known as \n"
                                                 + "lithophone or with sodium sulfate (Na2SO4) to make another white pigment known as blanc \n"
                                                 + "fixe. Stones made from impure barium sulfate glow when exposed to light and will glow \n"
                                                 + "in the dark for up to six years if intensely heated in the presence of charcoal. These \n"
                                                 + "stones, known as Bologna stones, were discovered near Bologna, Italy in the early 1500s \n"
                                                 + "and were thought to possess magical properties by alchemists. Although all barium compounds \n"
                                                 + "are poisonous, barium sulfate can be safely ingested since it does not dissolve in water. \n"
                                                 + "It is also a good absorber of X-rays and, when swallowed, can be used to produce X-ray \n"
                                                 + "images of the intestinal tract.\n" 
                                                 +"Barium carbonate (BaCO3), another common barium compound, is used in the manufacture of \n"
                                                 + "ceramics and some types of glass. It is a component in clay slurries used in drilling oil \n"
                                                 + "wells. Barium carbonate is used to purify some chemical solutions and is the primary base \n"
                                                 + "material for the manufacture of other barium compounds.\n" 
                                                 +"Barium forms several other useful compounds. Barium nitrate (Ba(NO3)2) burns with a bright \n"
                                                 + "green color and is used in signal flares and fireworks. Barium chloride (BaCl) is used as \n"
                                                 + "a water softener. Barium oxide (BaO) easily absorbs moisture and is used as a desiccant. \n"
                                                 + "Barium peroxide (BaO2) forms hydrogen peroxide (H2O2) when it is mixed with water and is \n"
                                                 + "used as a bleaching agent that activates when wet. Barium titanate (BaTiO3) is used as a \n"
                                                 + "dielectric material in capacitors. Barium ferrite (BaO·6Fe2O3) is used to make magnets.\n" 
                                                 +"Barium-137m, a radioactive form of barium produced by the decay of cesium-137, has a \n"
                                                 + "relatively short half-life and is commonly used in high school and college physics \n"
                                                 + "half-life determination experiments. \n"
        				  , "History & Uses of Barium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Lanthanum     57
                if(first.getText().equals("La") || first.getText().equals("lanthanum") || first.getText().equals("Lanthanum")){
                    JOptionPane.showMessageDialog(null,
                                         "               Lanthanum was discovered by Carl Gustaf Mosander, a Swedish chemist, in 1839. \n"
                                                 + "Mosander was searching for impurities he believed existed within samples of cerium. \n"
                                                 + "He treated cerium nitrate (Ce(NO3)3) with dilute nitric acid (HNO3) and found a new \n"
                                                 + "substance he named lanthana (La2O3). Roughly 0.0018% of the earth's crust is composed \n"
                                                 + "of lanthanum. Today, lanthanum is primarily obtained through an ion exchange process \n"
                                                 + "from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements \n"
                                                 + "that can contain as much as 25% lanthanum.\n" 
                                                 +"Lanthanum is one of the rare earth elements used to make carbon arc lights which are \n"
                                                 + "used in the motion picture industry for studio lighting and projector lights. \n"
                                                 + "Lanthanum also makes up about 25% of Misch metal, a material that is used to make \n"
                                                 + "flints for lighters. Lanthana (La2O3) is used to make the glass used in camera \n"
                                                 + "lenses and in other special glasses. \n"
        				  , "History & Uses of Lanthanum", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Cerium        58
                if(first.getText().equals("Ce") || first.getText().equals("cerium") || first.getText().equals("Cerium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Cerium was discovered by Jöns Jacob Berzelius and Wilhelm von Hisinger, Swedish \n"
                                                 + "chemists, and independently by Martin Heinrich Klaproth, a German chemist, in 1803. \n"
                                                 + "Cerium is the most abundant of the rare earth elements and makes up about 0.0046% of \n"
                                                 + "the earth's crust. Today, cerium is primarily obtained through an ion exchange process \n"
                                                 + "from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Pure cerium will ignite if it is scratched with a sharp object, but can be safely used \n"
                                                 + "if combined with other materials. Cerium is one of the rare earth elements used to \n"
                                                 + "make carbon arc lights which are used in the motion picture industry for studio \n"
                                                 + "lighting and projector lights. Cerium is also a component of Misch metal, a material \n"
                                                 + "that is used to make flints for lighters. Cerium is also used as a catalyst to refine \n"
                                                 + "petroleum and as an alloying agent to make special metals.\n" 
                                                 +"Cerium oxide (Ce2O3 and CeO2) is a component of the walls of self cleaning ovens and \n"
                                                 + "of incandescent lantern mantles. Cerium oxide is also used to polish glass surfaces. \n"
                                                 + "Ceric sulfate (Ce(So4)2) is used in some chemical analysis processes. Other cerium \n"
                                                 + "compounds are used to make some types of glass as well as to remove color from glass. \n"
        				  , "History & Uses of Cerium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Praseodymium      59
                if(first.getText().equals("Pr") || first.getText().equals("praseodymium") || first.getText().equals("Praseodymium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Praseodymium was discovered by Carl F. Auer von Welsbach, a German chemist, in 1885. \n"
                                                 + "He separated praseodymium, as well as the element neodymium, from a material known as didymium. \n"
                                                 + "Today, praseodymium is primarily obtained through an ion exchange process from monazite sand \n"
                                                 + "((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Praseodymium's primary use is as an alloying agent with magnesium to create high-strength \n"
                                                 + "metals that are used in aircraft engines. Praseodymium also makes up about 5% of Misch metal, \n"
                                                 + "a material that is used to make flints for lighters. Praseodymium forms the core of carbon \n"
                                                 + "arc lights which are used in the motion picture industry for studio lighting and projector \n"
                                                 + "lights. Praseodymium is added to fiber optic cables as a doping agent where it is used as a \n"
                                                 + "signal amplifier. Praseodymium salts are used to give glasses and enamels a yellow color. \n"
                                                 + "Praseodymium is also a component of didymium glass, which is used to make certain types of \n"
                                                 + "welder's and glass blower's goggles. \n"
        				  , "History & Uses of Praseodymium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Neodymium     60
                if(first.getText().equals("Nd") || first.getText().equals("neodymium") || first.getText().equals("Neodymium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Neodymium was discovered by Carl F. Auer von Welsbach, a German chemist, in 1885. \n"
                                                 + "He separated neodymium, as well as the element praseodymium, from a material known as \n"
                                                 + "didymium. Today, neodymium is primarily obtained from through an ion exchange process \n"
                                                 + "monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Neodymium makes up about 18% of Misch metal, a material that is used to make flints for \n"
                                                 + "lighters. Neodymium is also a component of didymium glass, which is used to make certain \n"
                                                 + "types of welder's and glass blower's goggles. Neodymium is added to glass to remove the \n"
                                                 + "green color caused by iron contaminants. It can also be added to glass to create violet, \n"
                                                 + "red or gray colors. Some types of glass containing neodymium are used by astronomers to \n"
                                                 + "calibrate devices called spectrometers and other types are used to create artificial \n"
                                                 + "rubies for lasers. Some neodymium salts are used to color enamels and glazes. \n"
        				  , "History & Uses of Neodymium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Promethium        61
                if(first.getText().equals("Pm") || first.getText().equals("promethium") || first.getText().equals("Promethium")){
                    JOptionPane.showMessageDialog(null,
                                         "             The existence of promethium was predicted by Bohuslav Brauner, a Czech chemist, in 1902. \n"
                                                 + "Several groups claimed to have produced the element, but they could not confirm their \n"
                                                 + "discoveries because of the difficulty of separating promethium from other elements. Proof \n"
                                                 + "of the existence of promethium was obtained by Jacob A. Marinsky, Lawrence E. Glendenin and \n"
                                                 + "Charles D. Coryell in 1944. Too busy with defense related research in World War II, they \n"
                                                 + "did not claim their discovery until 1946. They discovered promethium while analyzing the \n"
                                                 + "byproducts of uranium fission that were produced in a nuclear reactor located at Clinton \n"
                                                 + "Laboratories in Oak Ridge, Tennessee. Today, Clinton Laboratories is known as Oak Ridge \n"
                                                 + "National Laboratory.\n" 
                                                 +"Today, promethium is still recovered from the byproducts of uranium fission. It can also be \n"
                                                 + "produced by bombarding neodymium-146 with neutrons. Neodymium-146 becomes neodymium-147 \n"
                                                 + "when it captures a neutron. Neodymium-147, with a half-life of 11 days, decays into \n"
                                                 + "promethium-147 through beta decay. Promethium does not occur naturally on earth, although \n"
                                                 + "it has been detected in the spectrum of a star in the constellation Andromeda.\n" 
                                                 +"Promethium's most stable isotope, promethium-145, has a half-life of 17.7 years. It decays \n"
                                                 + "into neodymium-145 through electron capture.\n" 
                                                 +"Promethium could be used to make a nuclear powered battery. This type of battery would use \n"
                                                 + "the beta particles emitted by the decay of promethium to make a phosphor give off light. \n"
                                                 + "This light would then be converted into electricity by a device similar to a solar cell. \n"
                                                 + "It is expected that this type of battery could provide power for five years.\n" 
                                                 +"Promethium could also be used as a portable X-ray source, in radioisotope thermoelectric \n"
                                                 + "generators to provide electricity for space probes and satellites, as a source of \n"
                                                 + "radioactivity for gauges that measure thickness and to make lasers that can be used to \n"
                                                 + "communicate with submerged submarines.\n"
        				  , "History & Uses of Promethium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Samarium        62
                if(first.getText().equals("Sm") || first.getText().equals("samarium") || first.getText().equals("Samarium")){
                    JOptionPane.showMessageDialog(null,
                                         "            Samarium was observed spectroscopically by Jean Charles Galissard de Marignac, a \n"
                                                 + "Swiss chemist, in a material known as dydimia in 1853. Paul-Émile Lecoq de Boisbaudran, \n"
                                                 + "a French chemist, was the first to isolate samarium from the mineral samarskite \n"
                                                 + "((Y, Ce, U, Fe)3(Nb, Ta, Ti)5O16) in 1879. Today, samarium is primarily obtained through \n"
                                                 + "an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich \n"
                                                 + "in rare earth elements that can contain as much as 2.8% samarium.\n" 
                                                 +"Samarium is one of the rare earth elements used to make carbon arc lights which are \n"
                                                 + "used in the motion picture industry for studio lighting and projector lights. Samarium \n"
                                                 + "also makes up about 1% of Misch metal, a material that is used to make flints for \n"
                                                 + "lighters.\n" 
                                                 +"Samarium forms a compound with cobalt (SmCo5) which is a powerful permanent magnet with \n"
                                                 + "the highest resistance to demagnetization of any material known. Samarium oxide (Sm2O3) \n"
                                                 + "is added to glass to absorb infrared radiation and acts as a catalyst for the \n"
                                                 + "dehydration and dehydrogenation of ethanol (C2H6O).\n"
        				  , "History & Uses of Samarium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Europium        63
                if(first.getText().equals("Eu") || first.getText().equals("europium") || first.getText().equals("Europium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Europium was discovered by Eugène-Antole Demarçay, a French chemist, in 1896. \n"
                                                 + "Demarçay suspected that samples of a recently discovered element, samarium, were \n"
                                                 + "contaminated with an unknown element. He was able to produce reasonably pure \n"
                                                 + "europium in 1901. Today, europium is primarily obtained through an ion exchange \n"
                                                 + "process from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare \n"
                                                 + "earth elements.\n" 
                                                 +"Europium is the most reactive of the rare earth elements. There are no commercial \n"
                                                 + "applications for europium metal, although it has been used to dope some types of \n"
                                                 + "plastics to make lasers. Since it is a good absorber of neutrons, europium is \n"
                                                 + "being studied for use in nuclear reactors.\n" 
                                                 +"Europium oxide (Eu2O3), one of europium's compounds, is widely used as a red \n"
                                                 + "phosphor in television sets and as an activator for yttrium-based phosphors.\n"
        				  , "History & Uses of Europium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Gadolinium        64
                if(first.getText().equals("Gd") || first.getText().equals("gadolinium") || first.getText().equals("Gadolinium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Spectroscopic evidence for the existence of gadolinium was first observed by \n"
                                                 + "the Swiss chemist Jean Charles Galissard de Marignac in the minerals didymia and \n"
                                                 + "gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) in 1880. Today, gadolinium is primarily \n"
                                                 + "obtained from the minerals monazite ((Ce, La, Th, Nd, Y)PO4) and bastnasite \n"
                                                 + "((Ce,La,Y)CO3F).\n" 
                                                 +"Gadolinium has the greatest ability to capture thermal neutrons of all known \n"
                                                 + "elements and can be used as control rods for nuclear reactors. Unfortunately, \n"
                                                 + "the two isotopes best suited for neutron capture, gadolinium-155 and gadolinium-157,\n"
                                                 + "are present in gadolinium in small amounts. As a result, gadolinium control rods \n"
                                                 + "quickly lose their effectiveness.\n" 
                                                 +"Gadolinium can be combined with yttrium to form garnets that have applications in \n"
                                                 + "microwave technology. Gadolinium can be alloyed with iron, chromium and other \n"
                                                 + "metals to improve their workability and their resistance to high temperatures and \n"
                                                 + "oxidation. Gadolinium compounds are used to make phosphors for color televisions.\n"
        				  , "History & Uses of Gadolinium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Terbium        65
                if(first.getText().equals("Tb") || first.getText().equals("terbium") || first.getText().equals("Terbium")){
                    JOptionPane.showMessageDialog(null,
                                         "             The mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10), discovered in a quarry near the town \n"
                                                 + "of Ytterby, Sweden, has been the source of a great number of rare earth elements. In 1843, Carl \n"
                                                 + "Gustaf Mosander, a Swedish chemist, was able to separate gadolinite into three materials, which \n"
                                                 + "he named yttria, erbia and terbia. As might be expected considering the similarities between \n"
                                                 + "their names and properties, scientists soon confused erbia and terbia and, by 1877, had reversed \n"
                                                 + "their names. What Mosander called erbia is now called terbia and visa versa. From these two \n"
                                                 + "substances, Mosander discovered two new elements, terbium and erbium. Today, terbium can be \n"
                                                 + "obtained from the minerals xenotime (YPO4) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6),\n"
                                                 + " but is primarily obtained through an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4),\n"
                                                 + " a material rich in rare earth elements that typically contains as much as 0.03% terbium.\n" 
                                                 +"Terbium is used to dope some types of solid-state devices and, along with zirconium dioxide (ZrO2), \n"
                                                 + "as a crystal stabilizer in fuel cells that operate at high temperatures.\n" 
                                                 +"Terbia, the renamed material that Mosander discovered in 1843, is terbium oxide (Tb2O3), one of \n"
                                                 + "terbium's compounds. Terbia can potentially be used as an activator for green phosphors in television \n"
                                                 + "tubes. Sodium terbium borate, another terbium compound, is used to make laser light.\n"
        				  , "History & Uses of Terbium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Dysprosium        66
                if(first.getText().equals("Dy") || first.getText().equals("dysprosium") || first.getText().equals("Dysprosium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Dysprosium was discovered by Paul-Émile Lecoq de Boisbaudran, a French chemist, in 1886 as an \n"
                                                 + "impurity in erbia, the oxide of erbium. The metal was isolated by Georges Urbain, another French \n"
                                                 + "chemist, in 1906. Pure samples of dysprosium were first produced in the 1950s. Today, dysprosium \n"
                                                 + "is primarily obtained through an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4), \n"
                                                 + "a material rich in rare earth elements.\n" 
                                                 +"There are no commercial applications for dysprosium. Since it easily absorbs neutrons and has a high \n"
                                                 + "melting point, dysprosium might be alloyed with steel for use in nuclear reactors. When combined \n"
                                                 + "with vanadium and other rare earth elements, dysprosium is used as a laser material.\n" 
                                                 +"Dysprosium oxide (Dy2O3), also known as dysprosia, is combined with nickel and added to a special \n"
                                                 + "cement used to cool nuclear reactor rods. Other dysprosium compounds include: dysprosium fluoride \n"
                                                 + "(DyF3), dysprosium iodide (DyI3) and dysprosium sulfate (Dy2(SO4)3).\n"
        				  , "History & Uses of Dysprosium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Holmium        67
                if(first.getText().equals("Ho") || first.getText().equals("holmium") || first.getText().equals("Holmium")){
                    JOptionPane.showMessageDialog(null,
                                         "             Holmium was discovered by Per Theodor Cleve, a Swedish chemist, in 1879. Cleve used the same method \n"
                                                 + "Carl Gustaf Mosander used to discover lanthanum, erbium and terbium, he looked for impurities in the \n"
                                                 + "oxides of other rare earth elements. He started with erbia, the oxide of erbium (Er2O3), and removed \n"
                                                 + "all of the known contaminants. After further processing, he obtained two new materials, one brown and \n"
                                                 + "the other green. Cleve named the brown material holmia and the green material thulia. Holmia is the \n"
                                                 + "oxide of the element holmium and thulia is the oxide of the element thulium. Holmium's absorption \n"
                                                 + "spectrum was observed earlier that year by J. L. Soret and M. Delafontaine, Swiss chemists. Today, \n"
                                                 + "holmium is primarily obtained through an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4), \n"
                                                 + "a material rich in rare earth elements that can contain as much as 0.05% holmium.\n" 
                                                 +"Holmium has no commercial applications, although it has unusual magnetic properties that could be \n"
                                                 + "exploited in the future.\n" 
                                                 +"Holmium forms no commercially important compounds. Some of holmium's compounds include: holmium oxide \n"
                                                 + "(Ho2O3), holmium fluoride (HoF3) and holmium iodide (HoI3).\n"
        				  , "History & Uses of Holmium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Erbium        68
                if(first.getText().equals("Er") || first.getText().equals("erbium") || first.getText().equals("Erbium")){
                    JOptionPane.showMessageDialog(null,
                                         "            The mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10), discovered in a quarry near the town of Ytterby, \n"
                                                 + "Sweden, has been the source of a great number of rare earth elements. In 1843, Carl Gustaf Mosander, a \n"
                                                 + "Swedish chemist, was able to separate gadolinite into three materials, which he named yttria, erbia and \n"
                                                 + "terbia. As might be expected considering the similarities between their names and properties, scientists \n"
                                                 + "soon confused erbia and terbia and, by 1877, had reversed their names. What Mosander called erbia is now \n"
                                                 + "called terbia and visa versa. From these two substances, Mosander discovered two new elements, terbium \n"
                                                 + "and erbium. Today, erbium is primarily obtained through an ion exchange process from the minerals xenotime \n"
                                                 + "(YPO4) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6).\n" 
                                                 +"Erbium is alloyed with vanadium to make it softer and easier to shape. Erbium is added to fiber optic cables \n"
                                                 + "as a doping agent where it is used as a signal amplifier. Erbium also has some uses in the nuclear power \n"
                                                 + "industry.\n" 
                                                 +"Erbia, the renamed material that Mosander discovered in 1843, is erbium oxide (Er2O3), one of erbium's \n"
                                                 + "compounds. Erbia has a pink color and is used to color glass and glazes. Other erbium compounds include: \n"
                                                 + "erbium fluoride (ErF3, erbium chloride (ErCl3 and erbium iodide (ErI3).\n"
        				  , "History & Uses of Erbium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Thulium        69
                if(first.getText().equals("Tm") || first.getText().equals("thulium") || first.getText().equals("Thulium")){
                    JOptionPane.showMessageDialog(null,
                                         "        Thulium was discovered by Per Theodor Cleve, a Swedish chemist, in 1879. Cleve used the same method Carl Gustaf \n"
                                                 + "Mosanderused to discover lanthanum, erbium and terbium, he looked for impurities in the oxides of other rare earth \n"
                                                 + "elements. He started with erbia, the oxide of erbium (Er2O3), and removed all of the known contaminants. After \n"
                                                 + "further processing, he obtained two new materials, one brown and the other green. Cleve named the brown material \n"
                                                 + "holmia and the green material thulia. Holmia is the oxide of the element holmium and thulia is the oxide of the \n"
                                                 + "element thulium. Today, thulium is primarily obtained through an ion exchange process from monazite sand \n"
                                                 + "((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements that can contain as much as 0.007% thulium.\n" 
                                                 +"Thulium is the least abundant of the naturally occurring rare earth elements. Metallic thulium is relatively \n"
                                                 + "expensive and has only recently become available. It currently has no commercial applications, although one of \n"
                                                 + "its isotopes, thulium-169, could be used as a radiation source for portable X-ray machines.\n" 
                                                 +"Thulium forms no commercially important compounds. Some of thulium's compounds include: thulium oxide (Tm2O3), \n"
                                                 + "thulium fluoride (TmF3) and thulium iodide (TmI3).\n"
        				  , "History & Uses of Thulium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Ytterbium        70
                if(first.getText().equals("Yb") || first.getText().equals("ytterbium") || first.getText().equals("Ytterbium")){
                    JOptionPane.showMessageDialog(null,
                                         "              The mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10), discovered in a quarry near the town of Ytterby, \n"
                                                 + "Sweden, has been the source of a great number of rare earth elements. In 1843, Carl Gustaf Mosander, a Swedish \n"
                                                 + "chemist, was able to separate gadolinite into three materials, which he named yttria, erbia and terbia. As \n"
                                                 + "might be expected considering the similarities between their names and properties, scientists soon confused \n"
                                                 + "erbia and terbia and, by 1877, had reversed their names. What Mosander called erbia is now called terbia and \n"
                                                 + "visa versa. In 1878 Jean Charles Galissard de Marignac, a Swiss chemist, discovered that erbia was itself \n"
                                                 + "consisted of two components. One component was named ytterbia by Marignac while the other component retained \n"
                                                 + "the name erbia.\n" 
                                                 +"Marignac believed that ytterbia was a compound of a new element, which he named ytterbium. Other chemists \n"
                                                 + "produced and experimented with ytterbium in an attempt to determine some of it's properties. Unfortunately, \n"
                                                 + "different scientists obtained different results from the same experiments. While some scientists believed \n"
                                                 + "that these inconsistent results were caused by poor procedures or faulty equipment, Georges Urbain, a French \n"
                                                 + "chemist, believed that ytterbium wasn't an element at all, but a mixture of two elements. In 1907, Urbain was \n"
                                                 + "able to separate ytterbium into two elements. Urbain named one of the elements neoytterbium (new ytterbium) \n"
                                                 + "and the other element lutecium. Chemists eventually changed the name neoytterbium back to ytterbium and changed \n"
                                                 + "the spelling of lutecium to lutetium. Due to his original belief of the composition of ytterbia, Marignac is \n"
                                                 + "credited with the discovery of ytterbium. Today, ytterbium is primarily obtained through an ion exchange \n"
                                                 + "process from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Ytterbium has few uses. It can be alloyed with stainless steel to improve some of its mechanical properties \n"
                                                 + "and used as a doping agent in fiber optic cable where it can be used as an amplifier. One of ytterbium's \n"
                                                 + "isotopes is being considered as a radiation source for portable X-ray machines.\n"
        				  , "History & Uses of Ytterbium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Lutetium        71
                if(first.getText().equals("Lu") || first.getText().equals("lutetium") || first.getText().equals("Lutetium")){
                    JOptionPane.showMessageDialog(null,
                                         "           The mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10), discovered in a quarry near the town of Ytterby, Sweden, \n"
                                                 + "has been the source of a great number of rare earth elements. In 1843, Carl Gustaf Mosander, a Swedish chemist, \n"
                                                 + "was able to separate gadolinite into three materials, which he named yttria, erbia and terbia. As might be \n"
                                                 + "expected considering the similarities between their names and properties, scientists soon confused erbia and  \n"
                                                 + "terbia and, by 1877, had reversed their names. What Mosander called erbia is now called terbia and visa versa. \n"
                                                 + "In 1878 Jean  Charles Galissard de Marignac, a Swiss chemist, discovered that erbia was itself composed of two \n"
                                                 + "components. One component was named ytterbia by Marignac while the other component retained the name erbia.\n" 
                                                 +"Marignac believed that ytterbia was a compound of a new element, which he named ytterbium. Other chemists produced \n"
                                                 + "and experimented with ytterbium in an attempt to determine some of it's properties. Unfortunately, different \n"
                                                 + "scientists obtained different results from the same experiments. While some scientists believed that these \n"
                                                 + "inconsistent results were caused by poor procedures or faulty equipment, Georges Urbain, a French chemist, \n"
                                                 + "believed that ytterbium wasn't an element at all, but a mixture of two elements. In 1907, Urbain was able to \n"
                                                 + "separate ytterbium into two elements. Urbain named one of the elements neoytterbium (new ytterbium) and the \n"
                                                 + "other element lutecium. Carl Auer von Welsbach, a German chemist working independently of Urbain, reached \n"
                                                 + "the same conclusions at nearly the same time. Welsbach chose the names albebaranium and cassiopium for these \n"
                                                 + "elements. Urbain was eventually credited with the discovery of the elements and won the right to name them, \n"
                                                 + "although chemists later changed the name neoytterbium back to ytterbium and changed the spelling of lutecium \n"
                                                 + "to lutetium. Today, lutetium is primarily obtained through an ion exchange process from monazite sand \n"
                                                 + "((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n" 
                                                 +"Lutetium is one of the most difficult elements to prepare and has no large scale practical uses, although some \n"
                                                 + "of its radioactive isotopes can be used as a catalyst in the cracking of petroleum products and a catalyst in \n"
                                                 + "some hydrogenation and polymerization processes.\n"
        				  , "History & Uses of Lutetium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Hafnium        72
                if(first.getText().equals("Hf") || first.getText().equals("hafnium") || first.getText().equals("Hafnium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Hafnium was discovered by Dirk Coster, a Danish chemist, and Charles de Hevesy, a Hungarian chemist, in 1923. \n"
                                                 + "They used a method known as X-ray spectroscopy to study the arrangement of the outer electrons of atoms in samples \n"
                                                 + "of zirconium ore. The electron structure of hafnium had been predicted by Niels Bohr and Coster and Hevesy found a \n"
                                                 + "pattern that matched. Hafnium is difficult to separate from zirconium and is present in all of its ores. \n"
                                                 + "It is nobtained with the same methods used to extract zirconium.\n" 
                                                 +"Hafnium is a good absorber of neutrons and is used in the control rods of nuclear reactors. Hafnium is also used in \n"
                                                 + "vacuum tubes as a getter, a material that combines with and removes trace gases from vacuum tubes. Hafnium has been \n"
                                                 + "used as an alloying agent in iron, titanium, niobium and other metals.\n" 
                                                 +"Melting near 3890°C, hafnium carbide (HfC) has the highest melting point of any known two-element compound. Hafnium \n"
                                                 + "nitride (HfN) also has a high melting point, around 3305°C. Other hafnium compounds include: hafnium chloride (HfCl4), \n"
                                                 + "hafnium fluoride (HfF4) and hafnium oxide (HfO2).\n"
        				  , "History & Uses of Hafnium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Tantalum        73
                if(first.getText().equals("Ta") || first.getText().equals("tantalum") || first.getText().equals("Tantalum")){
                    JOptionPane.showMessageDialog(null,
                                         "              Tantalum was discovered by Anders Gustaf Ekenberg, a Swedish chemist, in 1802 in minerals obtained from Ytterby, \n"
                                                 + "Sweden. Many scientists believed that he had only discovered an allotrope of niobium, an element that is chemically \n"
                                                 + "similar to tantalum. The issue was finally settled in 1866 when, Jean Charles Galissard de Marignac, a Swiss chemist, \n"
                                                 + "proved that tantalum and niobium were two distinct elements. The first relatively pure samples of tantalum were first \n"
                                                 + "produced in 1907. Today, tantalum is primarily obtained from the minerals columbite ((Fe, Mn, Mg)(Nb, Ta)2O6), tantalite \n"
                                                 + "((Fe, Mn)(Ta, Nb)2O6) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6).\n" 
                                                 +"Tantalum is a strong, ductile metal that is nearly immune to chemical attack at room temperatures. It can be drawn into \n"
                                                 + "a fine wire that is used to evaporate metals, such as aluminum. It has a high melting point and is frequently used as a \n"
                                                 + "substitute for platinum, which is more expensive. Tantalum is used to make components for chemical plants, nuclear power \n"
                                                 + "plants, airplanes and missiles. Tantalum does not react with bodily fluids and is used to make surgical equipment. \n"
                                                 + "Tantalum also does not irritate the body and is used to make surgical sutures as well as implants, such as artificial \n"
                                                 + "joints and cranial plates. Tantalum is alloyed with steel to increase steel's ductility, strength and melting point.\n" 
                                                 +"Tantalum pentoxide (Ta2O5), one of tantalum's compounds, is a dielectric material and is used to make capacitors. It is \n"
                                                 + "also used to make a glass with a high index of refraction that is used in camera lenses. A composite consisting of \n"
                                                 + "tantalum carbide (TaC) and graphite is one of the hardest materials known and is used on the cutting edges of high-speed \n"
                                                 + "machine tools.\n"
        				  , "History & Uses of Tantalum", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Tungsten        74
                if(first.getText().equals("W") || first.getText().equals("tungsten") || first.getText().equals("Tungsten")){
                    JOptionPane.showMessageDialog(null,
                                         "              Tungsten was discovered by Juan José and Fausto Elhuyar, Spanish chemists and brothers, in 1783 in samples of the \n"
                                                 + "mineral wolframite ((Fe, Mn)WO4). Today, tungsten is primarily obtained from wolframite and scheelite (CaWO4) using the \n"
                                                 + "same basic method developed by José and Elhuyar. Tungsten ores are crushed, cleaned and treated with alkalis to form \n"
                                                 + "tungsten trioxide (WO3). Tungsten trioxide is then heated with carbon or hydrogen gas (H2), forming tungsten metal and \n"
                                                 + "carbon dioxide (CO2) or tungsten metal and water vapor (H2O).\n" 
                                                 +"Pure tungsten is a light gray or whitish metal that is soft enough to be cut with a hacksaw and ductile enough to be \n"
                                                 + "drawn into wire or extruded into various shapes. If contaminated with other materials, tungsten becomes brittle and \n"
                                                 + "difficult to work with. Tungsten has the highest melting point of all metallic elements and is used to make filaments \n"
                                                 + "for incandescent light bulbs, fluorescent light bulbs and television tubes. Tungsten expands at nearly the same rate as \n"
                                                 + "borosilicate glass and is used to make metal to glass seals. Tungsten is also used as a target for X-ray production, as \n"
                                                 + "heating elements in electric furnaces and for parts of spacecraft and missiles which must withstand high temperatures.\n" 
                                                 +"Tungsten is alloyed with steel to form tough metals that are stable at high temperatures. Tungsten-steel alloys are used \n"
                                                 + "to make such things as high speed cutting tools and rocket engine nozzles.\n" 
                                                 +"Tungsten carbide (WC) is an extremely hard tungsten compound. It is used in the tips of drill bits, high speed cutting \n"
                                                 + "tools and in mining machinery. Tungsten disulfide (WS2) is a dry lubricant that can be used to temperatures as high as \n"
                                                 + "500°C. Tungsten forms compounds with calcium and magnesium that have phosphorescent properties and are used in fluorescent\n"
                                                 + "light bulbs.\n"
        				  , "History & Uses of Tungsten", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Rhenium        75
                if(first.getText().equals("Re") || first.getText().equals("rhenium") || first.getText().equals("Rhenium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Rhenium was discovered by the German chemists Ida Tacke-Noddack, Walter Noddack and Otto Carl Berg in 1925. \n"
                                                 + "They detected rhenium spectroscopically in platinum ores and in the minerals columbite ((Fe, Mn, Mg)(Nb, Ta)2O6), \n"
                                                 + "gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) and molybdenite (MoS2). Rhenium is present in these materials only in \n"
                                                 + "trace amounts. In 1928, Noddack and Berg were able to extract 1 gram of rhenium from 660 kilograms of molybdenite. \n"
                                                 + "Today, rhenium is obtained as a byproduct of refining molybdenum and copper.\n" 
                                                 +"Rhenium is used in flash lamps for photography and for filaments in mass spectrographs and ion gages, but is most \n"
                                                 + "frequently used as an alloying agent in tungsten and molybdenum and as a catalyst for performing certain reactions \n"
                                                 + "to a type of hydrocarbon known as an olefin.\n"
        				  , "History & Uses of Rhenium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Osmium        76
                if(first.getText().equals("Os") || first.getText().equals("osmium") || first.getText().equals("Osmium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Osmium and iridium were discovered at the same time by the British chemist Smithson Tennant in 1803. \n"
                                                 + "Osmium and iridium were identified in the black residue remaining after dissolving platinum ore with aqua \n"
                                                 + "regia, a mixture of 25% nitric acid (HNO3) and 75% hydrochloric acid (HCl). Today, osmium is primarily \n"
                                                 + "recovered during the processing of platinum and nickel ores.\n" 
                                                 +"Metallic osmium is hard, brittle and very difficult to make. Powdered osmium is easier to make but emits \n"
                                                 + "osmium tetroxide (OsO4) when it is exposed to the air. Unfortunately, osmium tetroxide smells bad and is \n"
                                                 + "very poisonous. Because of these problems, osmium is primarily used to make very hard alloys. Osmium alloys \n"
                                                 + "can be found in ball point pen tips, fountain pen tips, record player needles, electrical contacts and \n"
                                                 + "other devices where frictional wear must be minimized.\n"
        				  , "History & Uses of Osmium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Iridium        77
                if(first.getText().equals("Ir") || first.getText().equals("iridium") || first.getText().equals("Iridium")){
                    JOptionPane.showMessageDialog(null,
                                         "              Iridium and osmium were discovered at the same time by the British chemist Smithson Tennant in 1803. \n"
                                                 + "Iridium and osmium were identified in the black residue remaining after dissolving platinum ore with aqua \n"
                                                 + "regia, a mixture of 25% nitric acid (HNO3) and 75% hydrochloric acid (HCl). Today, iridium is still \n"
                                                 + "obtained from platinum ores and as a by-product of mining nickel.\n" 
                                                 +"Pure iridium is very brittle and is nearly impossible to machine. It is primarily used as a hardening \n"
                                                 + "agent for platinum. Platinum-iridium alloys are used to make crucibles and other high temperature equipment. \n"
                                                 + "Iridium is also alloyed with osmium to make the tips of fountain pens and compass bearings.\n" 
                                                 +"Iridium is the most corrosive resistant metal known. For this reason, the standard meter bar was created \n"
                                                 + "from an alloy of 90% platinum and 10% iridium. This bar was replaced as the definition of the meter in 1960 \n"
                                                 + "when the meter was redefined in terms of the orange-red spectral line of krypton-86.\n" 
                                                 +"A thin, worldwide layer of iridium exists in a layer of sediment that was put down at the end of the \n"
                                                 + "Cretaceous period. Since meteors and asteroids contain a higher percentage of iridium than the earth's crust, \n"
                                                 + "this iridium enriched layer is seen as evidence that the earth was struck by a large meteor or asteroid at \n"
                                                 + "that time. Dust from the impact would have spread around the globe, depositing the iridium. The dust also \n"
                                                 + "would have blocked the sun for a time, resulting in the extinction of many plant and animal species, \n"
                                                 + "including the dinosaurs.\n"
        				  , "History & Uses of Iridium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Platinum        78
                if(first.getText().equals("Pt") || first.getText().equals("platinum") || first.getText().equals("Platinum")){
                    JOptionPane.showMessageDialog(null,
                                         "              Used by the pre-Columbian Indians of South America, platinum wasn't noticed by western scientists until \n"
                                                 + "1735. Platinum can occur free in nature and is sometimes found in deposits of gold-bearing sands, primarily \n"
                                                 + "those found in the Ural mountains, Columbia and the western United States. Platinum, in the form of the mineral \n"
                                                 + "sperrylite (PtAs2), is also obtained as a byproduct of the nickel mining operation in the Sudbury region of \n"
                                                 + "Ontario, Canada. Credit for the modern rediscovery of platinum is usually given to Antonio de Ulloa.\n" 
                                                 +"Platinum is a soft, dense, ductile metal that is very resistant to corrosion. It is used to make jewelry, wire, \n"
                                                 + "electrical contacts and laboratory vessels. Platinum expands at nearly the same rate as soda-lime-silica glass, \n"
                                                 + "so it is used to make sealed electrodes in glass systems. Platinum is used to coat missile nose cones, jet engine \n"
                                                 + "fuel nozzles and other devices that must operate reliably for long periods of time at high temperatures. \n"
                                                 + "Platinum resistance wires are used in high temperature electric furnaces. Platinum anodes are used in cathodic \n"
                                                 + "protection systems to prevent ships, pipelines and steel piers from corroding in salt water.\n" 
                                                 +"Platinum is widely used as a catalyst. It will convert methyl alcohol vapors (CH4O) into formaldehyde (CH2O) \n"
                                                 + "on contact, glowing red hot in the process. This effect is used to make small hand warmers. Platinum is also \n"
                                                 + "used in a device called a catalytic converter, a device found in the exhaust systems of most cars. Catalytic \n"
                                                 + "converters combine carbon monoxide (CO) and unburned fuel from a car's exhaust with oxygen from the air, \n"
                                                 + "forming carbon dioxide (CO2) and water vapor (H2O). Platinum is also used as a catalyst in the production of \n"
                                                 + "sulfuric acid (H2SO4) and in the cracking of petroleum products. Fuel cells, devices that combine hydrogen and \n"
                                                 + "oxygen to produce electricity and water, also use platinum as a catalyst.\n"
        				  , "History & Uses of Platinum", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Gold        78
                if(first.getText().equals("Au") || first.getText().equals("gold") || first.getText().equals("Gold")){
                    JOptionPane.showMessageDialog(null,
                                         "              An attractive and highly valued metal, gold has been known for at least 5500 years. \n"
                                                 + "Gold is sometimes found free in nature but it is usually found in conjunction with silver, \n"
                                                 + "quartz (SiO2), calcite (CaCO3), lead, tellurium, zinc or copper. There is roughly 1 milligram \n"
                                                 + "of gold dissolved in every ton of seawater, although extracting it currently costs more than \n"
                                                 + "the gold is worth. It has been estimated that all of the gold that has currently been refined \n"
                                                 + "could be placed in a cube measuring 20 meters on a side.\n" 
                                                 +"Gold is the most malleable and ductile of all known metals. A single ounce of gold can be \n"
                                                 + "beaten into a sheet measuring roughly 5 meters on a side. Thin sheets of gold, known as gold \n"
                                                 + "leaf, are primarily used in arts and crafts for gilding. One sheet of gold leaf can be as \n"
                                                 + "thin as 0.000127 millimeters, or about 400 times thinner than a human hair.\n" 
                                                 +"Pure gold is soft and is usually alloyed with other metals, such as silver, copper, platinum or \n"
                                                 + "palladium, to increase its strength. Gold alloys are used to make jewelry, decorative items, \n"
                                                 + "dental fillings and coins. The amount of gold in an alloy is measured with a unit called a karat.\n"
                                                 + "One karat is equal to one part in twenty-four, so an 18 karat gold ring contains 18 parts pure \n"
                                                 + "gold and 6 parts alloy material.\n" 
                                                 +"Gold is a good conductor of heat and electricity and does not tarnish when it is exposed to the \n"
                                                 + "air, so it can be used to make electrical connectors and printed circuit boards. Gold is also \n"
                                                 + "a good reflector of infrared radiation and can be used to help shield spacecraft and skyscrapers \n"
                                                 + "from the sun's heat. Gold coated mirrors can be used to make telescopes that are sensitive to \n"
                                                 + "infrared light.\n" 
                                                 +"A radioactive isotope of gold, gold-198, is used for treating cancer. Gold sodium thiosulfate \n"
                                                 + "(AuNa3O6S4) is used as a treatment for arthritis. Chlorauric acid (HAuCl4) is used to preserve \n"
                                                 + "photographs by replacing the silver atoms present in an image.\n"
        				  , "History & Uses of Gold", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Mercury        80
                if(first.getText().equals("Hg") || first.getText().equals("mercury") || first.getText().equals("Mercury")){
                    JOptionPane.showMessageDialog(null,
                                         "              Mercury was known to the ancient Chinese and Hindus and has been found in 3500 year old Egyptian tombs. \n"
                                                 + "Mercury is not usually found free in nature and is primarily obtained from the mineral cinnabar (HgS). Spain \n"
                                                 + "and Italy produce about half of the world's supply of Mercury.\n" 
                                                 +"Mercury can be used to make thermometers, barometers and other scientific instruments. Mercury conducts \n"
                                                 + "electricity and is used to make silent, position dependent switches. Mercury vapor is used in streetlights, \n"
                                                 + "fluorescent lamps and advertising signs.\n" 
                                                 +"Mercury easily forms alloys with other metals, such as gold, silver, zinc and cadmium. These alloys are called \n"
                                                 + "amalgams. Amalgams are used to help extract gold from its ores, create dental fillings (in the case of silver) \n"
                                                 + "and help extend the life of dry cell batteries (in the case of zinc and cadmium).\n" 
                                                 +"Mercury forms useful compounds with other elements. Mercuric chloride (HgCl2) is a very poisonous salt and was \n"
                                                 + "once used to disinfect wounds. Mercurous chloride (Hg2Cl2), also called calomel, is an antiseptic used to kill \n"
                                                 + "bacteria. Mercuric sulfide (HgS) is used to make a red paint pigment called vermilion. Mercuric oxide (HgO) is \n"
                                                 + "used to make mercury batteries.\n" 
                                                 +"Mercury is poisonous and can enter the body through the respiratory tract, the digestive tract or directly \n"
                                                 + "through the skin. It accumulates in the body, eventually causing severe illness or death.\n"
        				  , "History & Uses of Mercury", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Thallium        81
                if(first.getText().equals("Tl") || first.getText().equals("thallium") || first.getText().equals("Thallium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Thallium was discovered spectroscopically by Sir William Crookes, an English chemist, in 1861. \n"
                                                 + "Crooks had obtained the sludge left over from the production of sulfuric acid (H2SO4) from a friend. \n"
                                                 + "After removing all of the selenium from the sludge, he inspected it with a device known as a \n"
                                                 + "spectroscope to look for signs of tellurium. Rather than seeing the yellow spectral lines produced \n"
                                                 + "by tellurium, he observed a bright green line that no one had ever seen before. He named the new \n"
                                                 + "element that was producing the green line thallium, after the greek word for 'green twig', thallos. \n"
                                                 + "He isolated samples of thallium the next year. Thallium is found in the minerals crooksite (CuThSe), \n"
                                                 + "lorandite (TlAsS2) and hutchinsonite ((Pb, Tl)2As5S9), but is usually obtained as a byproduct of the \n"
                                                 + "production of sulfuric acid or as a byproduct of refining zinc or lead.\n" 
                                                 +"There are no uses for metallic thallium since pure thallium quickly combines with oxygen and water \n"
                                                 + "vapor from the atmosphere, forming a black, powdery substance. Thallium, used in conjunction with \n"
                                                 + "sulfur or selenium and arsenic, forms low melting glass. Thallium sulfate (Tl2SO4), an odorless, \n"
                                                 + "tasteless thallium compound, was once used as a rat and ant poison, although it has been banned \n"
                                                 + "from household use in the United States since 1974. Thallium sulfide (Tl2S), thallium iodide (TlI) \n"
                                                 + "and thallium bromide (TlBr) are all compounds used in devices to detect infrared radiation.\n"
        				  , "History & Uses of Thallium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Lead        82
                if(first.getText().equals("Pb") || first.getText().equals("lead") || first.getText().equals("Lead")){
                    JOptionPane.showMessageDialog(null,
                                         "                Lead has been known since ancient times. It is sometimes found free in nature, but is usually obtained from the ores galena (PbS), \n"
                                                 + "anglesite (PbSO4), cerussite (PbCO3) and minum (Pb3O4). Although lead makes up only about 0.0013% of the earth's crust, it is not considered \n"
                                                 + "to be a rare element since it is easily mined and refined. Most lead is obtained by roasting galena in hot air, although nearly one third of \n"
                                                 + "the lead used in the United States is obtained through recycling efforts.\n" 
                                                 +"Lead is a soft, malleable and corrosion resistant material. The ancient Romans used lead to make water pipes, some of which are still in use \n"
                                                 + "today. Unfortunately for the ancient Romans, lead is a cumulative poison and the decline of the Roman empire has been blamed, in part, on \n"
                                                 + "lead in the water supply. Lead is used to line tanks that store corrosive liquids, such as sulfuric acid (H2SO4). Lead's high density makes \n"
                                                 + "it useful as a shield against X-ray and gamma-ray radiation and is used in X-ray machines and nuclear reactors. Lead is also used as a \n"
                                                 + "covering on some wires and cables to protect them from corrosion, as a material to absorb vibrations and sounds and in the manufacture of \n"
                                                 + "ammunition. Most of the lead used today is used in the production on lead-acid storage batteries, such as the batteries found in automobiles.\n" 
                                                 +"Several lead alloys are widely used. Solder, an alloy that is nearly half lead and half tin, is a material with a relatively low melting \n"
                                                 + "point that is used to join electrical components, pipes and other metallic items. Type metal, an alloy of lead, tin and antimony, is a \n"
                                                 + "material used to make the type used in printing presses and plates. Babbit metal, another lead alloy, is used to reduce friction in bearings.\n" 
                                                 +"Lead forms many useful compounds. Lead monoxide (PbO), also known as litharge, is a yellow solid that is used to make some types of glass, \n"
                                                 + "such as lead crystal and flint glass, in the vulcanizing of rubber and as a paint pigment. Lead dioxide (PbO2) is a brown material that \n"
                                                 + "is used in lead-acid storage batteries. Trilead tetraoxide (Pb3O4), also known as red lead, is used to make a reddish-brown paint that \n"
                                                 + "prevents rust on outdoor steel structures. Lead arsenate (Pb3(AsO4)2) has been used as an insecticide although other, less harmful, \n"
                                                 + "substances have now largely replaced it. Lead carbonate (PbCO3), also known as cerussite, is a white, poisonous substance that was once \n"
                                                 + "widely used as a pigment for white paint. Use of lead carbonate in paints has largely been stopped in favor of titanium oxide (TiO2). \n"
                                                 + "Lead sulfate (PbSO4), also known as anglesite, is used in a paint pigment known as sublimed white lead. Lead chromate (PbCrO4), also \n"
                                                 + "known as crocoite, is used to produce chrome yellow paint. Lead nitrate (Pb(NO3)2) is used to make fireworks and other pyrotechnics. \n"
                                                 + "Lead silicate (PbSiO3) is used to make some types of glass and in the production of rubber and paints.\n"
        				  , "History & Uses of Lead", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Bismuth        83
                if(first.getText().equals("Bi") || first.getText().equals("bismuth") || first.getText().equals("Bismuth")){
                    JOptionPane.showMessageDialog(null,
                                         "                Bismuth, which has been known since ancient times, was often confused with lead and tin. Bismuth was first shown to \n"
                                                 + "be a distinct element in 1753 by Claude Geoffroy the Younger. Bismuth does occur free in nature and in such minerals as \n"
                                                 + "bismuthinite (Bi2S3) and bismite (Bi2O3). The largest deposits of bismuth are found in Bolivia, although bismuth is usually \n"
                                                 + "obtained as a by-product of mining and refining lead, copper, tin, silver and gold.\n" 
                                                 +"Pure bismuth is a white, brittle metal with a slight pink color. Bismuth is usually mixed with other metals, such as lead, \n"
                                                 + "tin, iron or cadmium to form low-melting alloys. These alloys are used in such things as automatic fire sprinkler systems, \n"
                                                 + "fire detection systems and electrical fuses.\n" 
                                                 +"Bismuth oxide (Bi2O3), a bismuth compound, is used as a yellow pigment in paints and cosmetics. Bismuth oxychloride (BiOCl) \n"
                                                 + "is used to make a pigment known as bismuth white. Bismuth carbonate (Bi2(CO3)3) is used to treat diarrhea and gastric ulcers.\n" 
                                                 +"Once thought to be the heaviest stable isotope to exist in nature, experiments conducted in 2002 showed that bismuth-209 is \n"
                                                 + "unstable and decays into thallium-205 through alpha decay. Bismuth-209 has a half-life of roughly 19,000,000,000,000,000,000 \n"
                                                 + "years.\n"
        				  , "History & Uses of Bismuth", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Polonium        84
                if(first.getText().equals("Po") || first.getText().equals("polonium") || first.getText().equals("Polonium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Polonium was discovered by Marie Sklodowska Curie, a Polish chemist, in 1898. She obtained polonium from pitchblende, \n"
                                                 + "a material that contains uranium, after noticing that unrefined pitchblende was more radioactive than the uranium that was \n"
                                                 + "separated from it. She reasoned that pitchblende must contain at least one other radioactive element. Curie needed to refine \n"
                                                 + "several tons of pitchblende in order to obtain tiny amounts of polonium and radium, another radioactive element discovered by \n"
                                                 + "Curie. One ton of uranium ore contains only about 100 micrograms (0.0001 grams) of polonium.\n" 
                                                 +"Due to its scarcity, polonium is usually produced by bombarding bismuth-209 with neutrons in a nuclear reactor. This forms \n"
                                                 + "bismuth-210, which has a half-life of 5 days. Bismuth-210 decays into polonium-210 through beta decay. Milligram amounts of \n"
                                                 + "polonium-210 have been produced by this method.\n" 
                                                 +"Polonium-210 is a very strong emitter of alpha particles. A single gram of polonium-210 creates 140 Watts of heat energy and \n"
                                                 + "is being considered as a lightweight heat source for thermoelectric power for spacecraft. Polonium-210 has a half-life of \n"
                                                 + "138.39 days.\n" 
                                                 +"Polonium's most stable isotope, polonium-209, has a half-life of 102 years. It decays into lead-205 through alpha decay. \n"
                                                 + "Polonium-209 is available from Oak Ridge National Laboratory at the cost of about $3200 per microcurie.\n" 
                                                 +"Polonium can be used to eliminate static electricity in machinery that is caused by processes such as the rolling of paper, \n"
                                                 + "wire or sheet metal, although other materials which emit beta particles are more commonly used for this purpose. Polonium is \n"
                                                 + "also used in brushes for removing dust from photographic films, although the polonium must be carefully sealed to protect the \n"
                                                 + "user from contamination. Polonium is also combined with beryllium to form neutron sources.\n"
        				  , "History & Uses of Polonium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Astatine        85
                if(first.getText().equals("At") || first.getText().equals("astatine") || first.getText().equals("Astatine")){
                    JOptionPane.showMessageDialog(null,
                                         "                Astatine was produced by Dale R. Carson, K.R. MacKenzie and Emilio Segrè by bombarding an \n"
                                                 + "isotope of bismuth, bismuth-209, with alpha particles that had been accelerated in a device called \n"
                                                 + "a cyclotron. This created astatine-211 and two free neutrons. This work was conducted at the \n"
                                                 + "University of California in 1940.\n" 
                                                 +"Small amounts of astatine exist in nature as a result of the decay of uranium and thorium, although \n"
                                                 + "the total amount of astatine in the earth's crust at any particular time is less than 30 grams. \n"
                                                 + "Due to its scarcity, astatine is produced when it is needed. A total of 0.05 micrograms (0.00000005 \n"
                                                 + "grams) of astatine have been produced to date.\n" 
                                                 +"Astatine's most stable isotope, astatine-210, has a half-life of 8.1 hours. It decays into bismuth-206 \n"
                                                 + "through alpha decay or into polonium-210 through electron capture.\n" 
                                                 +"Due to the small amounts produced and its short half-life, there are currently no uses for astatine \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Astatine", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Radon        86
                if(first.getText().equals("Rn") || first.getText().equals("radon") || first.getText().equals("Radon")){
                    JOptionPane.showMessageDialog(null,
                                         "                Radon was discovered by Friedrich Ernst Dorn, a German chemist, in 1900 while studying radium's decay chain. \n"
                                                 + "Originally named niton after the Latin word for shining, nitens, radon has been known as radon since 1923. Today, \n"
                                                 + "radon is still primarily obtained through the decay of radium.\n" 
                                                 +"At normal room temperatures, radon is a colorless, odorless, radioactive gas. The most common forms of radon decay \n"
                                                 + "through alpha decay. Alpha decay usually isn't considered to be a great radiological hazard since the alpha particles \n"
                                                 + "produced by the decay are easily stopped. However, since radon is a gas, it is easily inhaled and living tissue is \n"
                                                 + "directly exposed to the radiation. Although it has a relatively short half-life, radon decays into longer lived, \n"
                                                 + "solid, radioactive elements which can collect on dust particles and be inhaled as well. For these reasons, there is \n"
                                                 + "some concern as to the amount of radon present within homes. Radon seeps into houses as a result of the decay of \n"
                                                 + "radium, thorium or uranium ores underground and varies greatly from location to location. On average, the earth's \n"
                                                 + "atmosphere is 0.0000000000000000001% radon.\n" 
                                                 +"When cooled to its solid state, radon glows yellow. The glow becomes orange-red as the temperature is lowered.\n" 
                                                 +"Radon's most stable isotope, radon-222, has a half-life of about 3.8 days. It decays into polonium-218 through alpha \n"
                                                 + "decay.\n" 
                                                 +"Small amounts of radon are sometimes used by hospitals to treat some forms of cancer. Radon fluoride (RnF) is the only \n"
                                                 + "confirmed compound of radon.\n"
        				  , "History & Uses of Radon", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Francium        87
                if(first.getText().equals("Fr") || first.getText().equals("francium") || first.getText().equals("Francium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Francium was discovered by Marguerite Catherine Perey, a French chemist, \n"
                                                 + "in 1939 while analyzing actinium's decay sequence. Although considered a natural \n"
                                                 + "element, scientists estimate that there is no more than one ounce of francium in \n"
                                                 + "the earth's crust at one time. Since there is so little naturally occurring \n"
                                                 + "francium on earth, scientists must produce francium in order to study it. Francium \n"
                                                 + "can be produced by bombarding thorium with protons or by bombarding radium with \n"
                                                 + "neutrons.\n" 
                                                 +"Francium's most stable isotope, francium-223, has a half-life of about 22 minutes. \n"
                                                 + "It decays into radium-223 through beta decay or into astatine-219 through alpha \n"
                                                 + "decay.\n" 
                                                 +"Due to the small amounts produced and its short half-life, there are currently no \n"
                                                 + "uses for francium outside of basic scientific research.\n"
        				  , "History & Uses of Francium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Radium        88
                if(first.getText().equals("Ra") || first.getText().equals("radium") || first.getText().equals("Radium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Radium was discovered by Marie Sklodowska Curie, a Polish chemist, and Pierre Curie, a French chemist, in 1898. \n"
                                                 + "Marie Curie obtained radium from pitchblende, a material that contains uranium, after noticing that unrefined pitchblende \n"
                                                 + "was more radioactive than the uranium that was separated from it. She reasoned that pitchblende must contain at least \n"
                                                 + "one other radioactive element. Curie needed to refine several tons of pitchblende in order to obtain tiny amounts of \n"
                                                 + "radium and polonium, another radioactive element discovered by Curie. One ton of uranium ore contains only about 0.14 \n"
                                                 + "grams of radium. Today, radium can be obtained as a byproduct of refining uranium and is usually sold as radium chloride \n"
                                                 + "(RaCl2) or radium bromide (RaBr2) and not as a pure material.\n" 
                                                 +"Radium's most stable isotope, radium-226, has a half-life of about 1600 years. It decays into radon-222 through alpha \n"
                                                 + "decay or into lead-212 by ejecting a carbon-14 nucleus.\n" 
                                                 +"The Curie, a unit used to describe the activity of a radioactive substance, is based on radium-226. It is equal to the \n"
                                                 + "number of atoms in a one gram sample of radium-226 that will decay in one second, or 37,000,000,000 decays per second.\n" 
                                                 +"Radium had been used to make self-luminous paints for watches, aircraft instrument dials and other instrumentation, but \n"
                                                 + "has largely been replaced by cobalt-60, a less dangerous radioactive source. A mixture of radium and beryllium will emit \n"
                                                 + "neutrons and is used as a neutron source. Radium is used to produce radon, a radioactive gas used to treat some types \n"
                                                 + "of cancer. A single gram of radium-226 will produce 0.000l milliliters of radon a day.\n" 
                                                 +"Radium is about one million times more active than uranium. The lab notebooks used by the Curies are too highly \n"
                                                 + "contaminated to be safely handled today.\n"
        				  , "History & Uses of Radium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Actinium        89
                if(first.getText().equals("Ac") || first.getText().equals("actinium") || first.getText().equals("Actinium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Actinium was discovered in 1899 by André-Louis Debierne, a French chemist, \n"
                                                 + "while experimenting with new methods of separating rare earth oxides. Friedrich \n"
                                                 + "Otto Giesel independently discovered actinium in 1902.\n" 
                                                 +"Actinium is a rare element that is present in uranium ores in tiny amounts, but it \n"
                                                 + "is usually cheaper and easier to create actinium when it is needed by bombarding \n"
                                                 + "radium with neutrons in a nuclear reactor.\n" 
                                                 +"Actinium's most stable isotope, actinium-227, has a half-life of 21.77 years. It \n"
                                                 + "decays into francium-223 through alpha decay or into thorium-227 through beta \n"
                                                 + "decay.\n" 
                                                 +"Actinium has no significant commercial applications, although it is used in the \n"
                                                 + "production of neutrons.\n"
        				  , "History & Uses of Actinium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Thorium        90
                if(first.getText().equals("Th") || first.getText().equals("thorium") || first.getText().equals("Thorium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Thorium was discovered by Jöns Jacob Berzelius, a Swedish chemist, in 1828. \n"
                                                 + "He discovered it in a sample of a mineral that was given to him by the Reverend Has \n"
                                                 + "Morten Thrane Esmark, who suspected that it contained an unknown substance. Esmark's \n"
                                                 + "mineral is now known as thorite (ThSiO4). Thorium makes up about 0.0007% of the \n"
                                                 + "earth's crust and is primarily obtained from thorite, thorianite (ThO2) and monazite \n"
                                                 + "((Ce, La, Th, Nd, Y)PO4).\n" 
                                                 +"Thorium is used as an alloying agent to improve magnesium's strength at high temperatures.\n"
                                                 + "Thorium is also used to coat tungsten filaments used in electronic devices, such at \n"
                                                 + "television sets. When bombarded with neutrons, thorium-232 becomes thorium-233, which \n"
                                                 + "eventually decays into uranium-233 through a series of beta decays. Uranium-233 is a \n"
                                                 + "fissionable material and can be used as a nuclear fuel.\n" 
                                                 +"Thorium oxide (ThO2), one of thorium's compounds, has many uses. It is primarily used in \n"
                                                 + "a type of lantern mantel known as a Welsbach mantle. This mantle, which also contains \n"
                                                 + "about 1% cerium oxide, glows with a bright white light when it is heated in a gas flame. \n"
                                                 + "Thorium oxide has a very high melting point, about 3300°C, and is used to make high \n"
                                                 + "temperature crucibles. Thorium oxide is also used to make glass with a high index of \n"
                                                 + "refraction that is used to make high quality camera lenses. Thorium oxide is used as \n"
                                                 + "a catalyst in the production of sulfuric acid (H2SO4), in the cracking of petroleum \n"
                                                 + "products and in the conversion of ammonia (NH3) to nitric acid (HNO3).\n" 
                                                 +"Thorium's most stable isotope, thorium-232, has a half-life of about 14,050,000,000 years. \n"
                                                 + "It decays into radium-228 through alpha decay or decays through spontaneous fission.\n"
        				  , "History & Uses of Thorium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Protactinium        91
                if(first.getText().equals("Pa") || first.getText().equals("protactinium") || first.getText().equals("Protactinium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Protactinium was first identified by Kasimir Fajans and O.H. Göhring in \n"
                                                 + "1913 while studying uranium's decay chain. The particular isotope they found, \n"
                                                 + "protactinium-234m, has a half-life of about 1.17 minutes. They named the element \n"
                                                 + "brevium, meaning brief, and then continued with their studies. Protactinium's \n"
                                                 + "existence was confirmed in 1918 when another isotope, protactinium-231, was \n"
                                                 + "independently discovered and studied by two groups of scientists, Otto Hahn and \n"
                                                 + "Lise Meitner of Germany and Frederick Soddy and John Cranston of Great Britain. \n"
                                                 + "Protactinium was first isolated by Aristid V. Grosse in 1934.\n" 
                                                 +"Protactinium is a rare, poisonous and expensive element that is present in uranium \n"
                                                 + "ores in very small amounts. In 1961, the Great Britain Atomic Energy Authority \n"
                                                 + "was able to produce 125 grams of 99.9% pure protactinium, although they had to \n"
                                                 + "process about 55,000 kilograms of ore and spend about $500,000 to get it.\n" 
                                                 +"Protactinium's most stable isotope, protactinium-231, has a half-life of about \n"
                                                 + "32,760 years. It decays into actinium-227 through alpha decay.\n" 
                                                 +"Due to its scarcity, high radioactivity and toxicity, there are currently no uses \n"
                                                 + "for protactinium outside of basic scientific research.\n"
        				  , "History & Uses of Protactinium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Uranium        92
                if(first.getText().equals("U") || first.getText().equals("uranium") || first.getText().equals("Uranium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Uranium was discovered by Martin Heinrich Klaproth, a German chemist, in the mineral pitchblende (primarily a mix of uranium oxides) in 1789. \n"
                                                 + "Although Klaproth, as well as the rest of the scientific community, believed that the substance he extracted from pitchblende was pure uranium, it \n"
                                                 + "was actually uranium dioxide (UO2). After noticing that 'pure' uranium reacted oddly with uranium tetrachloride (UCl4), Eugène-Melchoir Péligot, a \n"
                                                 + "French chemist isolated pure uranium by heating uranium dioxide with potassium in a platinum crucible. Radioactivity was first discovered in 1896 \n"
                                                 + "when Antoine Henri Becquerel, a French physicist, detected it from a sample of uranium. Today, uranium is obtained from uranium ores such as pitchblende, \n"
                                                 + "uraninite (UO2), carnotite (K2(UO2)2VO4·1-3H2O) and autunite (Ca(UO2)2(PO4)2·10H2O) as well as from phosphate rock (Ca3(PO4)2), lignite (brown coal) \n"
                                                 + "and monazite sand ((Ce, La, Th, Nd, Y)PO4). Since there is little demand for uranium metal, uranium is usually sold in the form of sodium diuranate \n"
                                                 + "(Na2U2O7·6H2O), also known as yellow cake, or triuranium octoxide (U3O8).\n" 
                                                 +"Since it is naturally radioactive, uranium, usually in the form of uranium dioxide (UO2), is most commonly used in the nuclear power industry to generate \n"
                                                 + "electricity. Naturally occurring uranium consists of three isotopes: uranium-234, uranium-235 and uranium-238. Although all three isotopes are radioactive, \n"
                                                 + "only uranium-235 is a fissionable material that can be used for nuclear power.\n" 
                                                 +"When a fissionable material is struck by a neutron, its nucleus can release energy by splitting into smaller fragments. If some of the fragments are other \n"
                                                 + "neutrons, they can strike other atoms and cause them to split as well. A fissionable material, such as uranium-235, is a material capable of producing \n"
                                                 + "enough free neutrons to sustain a nuclear chain reaction.\n" 
                                                 +"Only 0.7204% of naturally occurring uranium is uranium-235. This is too low a concentration to sustain a nuclear chain reaction without the help of a \n"
                                                 + "material known as a moderator. A moderator is a material that can slow down a neutron without absorbing it. Slow neutrons are more likely to react with \n"
                                                 + "uranium-235 and reactors using natural uranium can be made using graphite or heavy water as a moderator. Methods also exist for concentrating uranium-235. \n"
                                                 + "Once the levels of uranium-235 have been increased to about 3%, normal water can be used as a moderator.\n" 
                                                 +"Uranium-238, uranium's most common isotope, can be converted into plutonium-239, a fissionable material that can also be used as a fuel in nuclear reactors. \n"
                                                 + "To produce plutonium-239, atoms of uranium-238 are exposed to neutrons. Uranium-239 forms when uranium-238 absorbs a neutron. Uranium-239 has a half-life \n"
                                                 + "of about 23 minutes and decays into neptunium-239 through beta decay. Neptunium-239 has a half-life of about 2.4 days and decays into plutonium-239, also \n"
                                                 + "through beta decay.\n" 
                                                 +"Although it does not occur naturally, uranium-233 is also a fissionable material that can be used as a fuel in nuclear reactors. To produce uranium-233, \n"
                                                 + "atoms of thorium-232 are exposed to neutrons. Thorium-233 forms when thorium-232 absorbs a neutron. Thorium-233 has a half-life of about 22 minutes and \n"
                                                 + "decays into protactinium-233 through beta decay. Protactinium-233 has a half-life of about 27 days and decays into uranium-233, also through beta decay. \n"
                                                 + "If completely fissioned, one pound (0.45 kilograms) of uranium-233 will provide the same amount of energy as burning 1,500 tons (1,350,000 kilograms) of coal.\n" 
                                                 +"Uranium is a dense metal that has uses outside of the nuclear power industry. It is used as a target for X-ray production, as ammunition for some types of \n"
                                                 + "military weaponry, as a shield against radiation, as a counterweight for aircraft control surfaces and in the gyroscopes of inertial guidance systems.\n" 
                                                 +"Uranium compounds have been used for centuries to color glass. A 2,000 year old sample of yellow glass found near Naples, Italy contains uranium oxide. \n"
                                                 + "Uranium trioxide (UO3) is an orange powder and has been used in the manufacture of Fiestaware plates. Other uranium compounds have also been used to \n"
                                                 + "make vaseline glass and glazes. The uranium within these items is radioactive and should be treated with care.\n" 
                                                 +"Uranium's most stable isotope, uranium-238, has a half-life of about 4,468,000,000 years. It decays into thorium-234 through alpha decay or decays through \n"
                                                 + "spontaneous fission.\n"
        				  , "History & Uses of Uranium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Neptunium        93
                if(first.getText().equals("Np") || first.getText().equals("neptunium") || first.getText().equals("Neptunium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Neptunium was first produced by Edwin M. McMillian and Philip H. Abelson, working at the \n"
                                                 + "University of California, Berkeley, in 1940. They produced neptunium-239, an isotope of neptunium \n"
                                                 + "with a half-life of about 2.4 days, by bombarding uranium with slow moving neutrons.\n" 
                                                 +"Neptunium's most stable isotope, neptunium-237, has a half-life of about 2,144,000 years. It decays \n"
                                                 + "into protactinium-233 through alpha decay. Neptunium-237, which is produced in gram quantities as \n"
                                                 + "a by-product of the production of plutonium in nuclear reactors, is used in neutron detectors.\n" 
                                                 +"Once considered to be completely artificial, extremely small amounts of neptunium are produced \n"
                                                 + "naturally in uranium ores through the interaction of atoms of uranium in the ore with neutrons \n"
                                                 + "produced by the decay of other atoms of uranium in the ore.\n"
        				  , "History & Uses of Neptunium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Plutonium        94
                if(first.getText().equals("Pu") || first.getText().equals("plutonium") || first.getText().equals("Plutonium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Plutonium was first produced by Glenn T. Seaborg, Joseph W. Kennedy, \n"
                                                 + "Edward M. McMillan and Arthur C. Wohl by bombarding an isotope of uranium, \n"
                                                 + "uranium-238, with deuterons that had been accelerated in a device called a \n"
                                                 + "cyclotron. This created neptunium-238 and two free neutrons. Neptunium-238 \n"
                                                 + "has a half-life of 2.1 days and decays into plutonium-238 through beta decay. \n"
                                                 + "Although they conducted their work at the University of California in 1941, \n"
                                                 + "their discovery was not revealed to the rest of the scientific community \n"
                                                 + "until 1946 because of wartime security concerns.\n" 
                                                 +"Plutonium's most stable isotope, plutonium-244, has a half-life of about \n"
                                                 + "82,000,000 years. It decays into uranium-240 through alpha decay. Plutonium-244\n"
                                                 + "will also decay through spontaneous fission.\n" 
                                                 +"Only two of plutonium's isotopes, plutonium-238 and plutonium-239, have found \n"
                                                 + "uses outside of basic research. Plutonium-238 is used in radioisotope \n"
                                                 + "thermoelectric generators to provide electricity for space probes that venture \n"
                                                 + "too far from the sun to use solar power, such as the Cassini and Galileo probes. \n"
                                                 + "Plutonium-239 will undergo a fission chain reaction if enough of it is \n"
                                                 + "concentrated in one place, so it is used at the heart of modern day nuclear \n"
                                                 + "weapons and in some nuclear reactors.\n"
        				  , "History & Uses of Plutonium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Americium        95
                if(first.getText().equals("Am") || first.getText().equals("americium") || first.getText().equals("Americium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Americium was discovered in 1944 by the American scientists Glenn T. Seaborg, \n"
                                                 + "Ralph A. James, Leon O. Morgan and Albert Ghiorso. They produced americium by \n"
                                                 + "bombarding plutonium-239, an isotope of plutonium, with high energy neutrons. \n"
                                                 + "This formed plutonium-240, which was itself bombarded with neutrons. The plutonium-240 \n"
                                                 + "changed into plutonium-241, which then decayed into americium-241 through beta decay. \n"
                                                 + "This work was carried out at the University of Chicago's Metallurgical Laboratory, \n"
                                                 + "now known as Argonne National Laboratory.\n" 
                                                 +"Americium's most stable isotope, americium-243, has a half-life of about 7,370 years. \n"
                                                 + "It decays into neptunium-239 through alpha decay.\n" 
                                                 +"Americium can be produced in kilogram quantities and has a few practical uses. It is \n"
                                                 + "used in smoke detectors and can be used as a portable source of gamma rays. Americium-241, \n"
                                                 + "with a half-life of 432.2 years, is used in these products because it is easier to \n"
                                                 + "produce relatively pure samples of this isotope.\n"
        				  , "History & Uses of Americium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Curium        96
                if(first.getText().equals("Cm") || first.getText().equals("curium") || first.getText().equals("Curium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Curium was first produced by Glenn T. Seaborg, Ralph A. James and Albert Ghiorso, \n"
                                                 + "working at the University of California, Berkeley, in 1944. They bombarded atoms of \n"
                                                 + "plutonium-239, an isotope of plutonium, with alpha particles that had been accelerated \n"
                                                 + "in a device called a cyclotron. This produced atoms of curium-242 and one free neutron. \n"
                                                 + "Curium-242 has a half-life of about 163 days and decays into plutonium-238 through alpha \n"
                                                 + "decay or decays through spontaneous fission.\n" 
                                                 +"Curium's most stable isotope, curium-247, has a half-life of about 15,600,000 years. It \n"
                                                 + "decays into plutonium-243 through alpha decay.\n" 
                                                 +"Since only milligram amounts of curium have ever been produced, there are currently no \n"
                                                 + "commercial applications for it, although it might be used in radioisotope thermoelectric \n"
                                                 + "generators in the future. Curium is primarily used for basic scientific research.\n" 
                                                 +"Scientists have produced several curium compounds. They include: curium dioxide (CmO2), \n"
                                                 + "curium trioxide (Cm2O3), curium bromide (CmBr3), curium chloride (CmCl3), curium chloride \n"
                                                 + "(CmCl3), curium tetrafluoride (CmF4) and curium iodide (CmI3). As with the element, the \n"
                                                 + "compounds currently have no commercial applications and are primarily used for basic \n"
                                                 + "scientific research.\n"
        				  , "History & Uses of Curium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Berkelium        97
                if(first.getText().equals("Bk") || first.getText().equals("berkelium") || first.getText().equals("Berkelium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Berkelium was first produced by Stanley G. Thompson, Glenn T. Seaborg, Kenneth Street, \n"
                                                 + "Jr. and Albert Ghiorso working at the University of California, Berkeley, in December, 1949. \n"
                                                 + "They bombarded an isotope of americium, americium-241, with alpha particles with a device \n"
                                                 + "called a cyclotron. This created berkelium-243 and two free neutrons.\n" 
                                                 +"Berkelium's most stable isotope, berkelium-247, has a half-life of about 1,380 years. It decays \n"
                                                 + "into americium-243 through alpha decay.\n" 
                                                 +"The first visible amounts of a berkelium compound, berkelium chloride (BkCl3) was produced in \n"
                                                 + "1962 and weighed about 3 billionths of a gram (0.000000003 grams). Berkelium oxychloride \n"
                                                 + "(BkOCl), berkelium fluoride (BkF3), berkelium dioxide (BkO2) and berkelium trioxide (BkO3) \n"
                                                 + "have been identified and studied with a method known as X-ray diffraction.\n" 
                                                 +"Since only small amounts of berkelium have ever been produced, there are no known uses for \n"
                                                 + "berkelium and its compounds outside of basic scientific research.\n"
        				  , "History & Uses of Berkelium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Californium        98
                if(first.getText().equals("Cf") || first.getText().equals("californium") || first.getText().equals("Californium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Californium was first produced by Stanley G. Thompson, Glenn T. Seaborg, \n"
                                                 + "Kenneth Street, Jr. and Albert Ghiorso working at the University of California, \n"
                                                 + "Berkeley, in 1950. They bombarded atoms of curium-242 with helium ions using a \n"
                                                 + "device known as a cyclotron. This produced atoms of californium-245, an isotope \n"
                                                 + "with a half-life of about 45 minutes, and a free neutron.\n" 
                                                 +"Californium-252, an isotope with a half-life of about 2.6 years, is a very strong \n"
                                                 + "neutron source. One microgram (0.000001 grams) of californium-252 produces \n"
                                                 + "170,000,000 neutrons per minute. It is being used as a neutron source to identify \n"
                                                 + "gold and silver ores through a technique known as neutron activation. It is also \n"
                                                 + "being used in devices known as neutron moisture gauges that are used to find water \n"
                                                 + "and oil bearing layers in oil wells.\n" 
                                                 +"A few compounds of californium have been produced and studied. They include: \n"
                                                 + "californium oxide (CfO3), californium trichloride (CfCl3) and californium oxychloride\n"
                                                 + "(CfOCl).\n" 
                                                 +"Californium's most stable isotope, californium-251, has a half-life of about 898 \n"
                                                 + "years. It decays into curium-247 through alpha decay or decays through spontaneous \n"
                                                 + "fission.\n"
        				  , "History & Uses of Californium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Einsteinium        99
                if(first.getText().equals("Es") || first.getText().equals("einsteinium") || first.getText().equals("Einsteinium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Einsteinium was discovered by a team of scientists led by Albert \n"
                                                 + "Ghiorso in 1952 while studying the radioactive debris produced by the \n"
                                                 + "detonation of the first hydrogen bomb. The isotope they discovered, \n"
                                                 + "einsteinium-253, has a half-life of about 20 days and was produced by \n"
                                                 + "combining 15 neutrons with uranium-238, which then underwent seven beta \n"
                                                 + "decays. Today, einsteinium is produced though a lengthy chain of nuclear \n"
                                                 + "reactions that involves bombarding each isotope in the chain with neutrons \n"
                                                 + "and then allowing the resulting isotope to undergo beta decay.\n" 
                                                 +"Einsteinium's most stable isotope, einsteinium-252, has a half-life of \n"
                                                 + "about 471.7 days. It decays into berkelium-248 through alpha decay or \n"
                                                 + "into californium-252 through electron capture.\n" 
                                                 +"Since only small amounts of einsteinium have ever been produced, it \n"
                                                 + "currently has no uses outside of basic scientific research.\n"
        				  , "History & Uses of Einsteinium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Fermium        100
                if(first.getText().equals("Fm") || first.getText().equals("fermium") || first.getText().equals("Fermium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Fermium was discovered by a team of scientists led by Albert Ghiorso in \n"
                                                 + "1952 while studying the radioactive debris produced by the detonation of the \n"
                                                 + "first hydrogen bomb. The isotope they discovered, fermium-255, has a half-life \n"
                                                 + "of about 20 hours and was produced by combining 17 neutrons with uranium-238, \n"
                                                 + "which then underwent eight beta decays. Today, fermium is produced though a \n"
                                                 + "lengthy chain of nuclear reactions that involves bombarding each isotope in \n"
                                                 + "the chain with neutrons and then allowing the resulting isotope to undergo \n"
                                                 + "beta decay.\n" 
                                                 +"Fermium's most stable isotope, fermium-257, has a half-life of about 100.5 days. \n"
                                                 + "It decays into californium-253 through alpha decay or decays through spontaneous\n"
                                                 + "fission.\n" 
                                                 +"Due to the small amounts produced and its short half-life, there are currently \n"
                                                 + "no uses for fermium outside of basic scientific research.\n"
        				  , "History & Uses of Fermium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Mendelevium        101
                if(first.getText().equals("Md") || first.getText().equals("mendelevium") || first.getText().equals("Mendelevium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Mendelevium was first produced by Stanley G. Thompson, Glenn T. Seaborg, \n"
                                                 + "Bernard G. Harvey, Gregory R. Choppin and Albert Ghiorso working at the University \n"
                                                 + "of California, Berkeley, in 1955. They bombarded atoms of einsteinium-253 with \n"
                                                 + "helium ions using a device known as a cyclotron. This produced atoms of mendelevium-256,\n"
                                                 + "an isotope with a half-life of about 77 minutes, and a free neutron.\n" 
                                                 +"Mendelevium's most stable isotope, mendelevium-258, has a half-life of about 51.5 days. \n"
                                                 + "It decays into einsteinium-254 through alpha decay or decays through spontaneous fission.\n" 
                                                 +"Since only small amounts of mendelevium have ever been produced, it currently has no uses \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Mendelevium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Nobelium        102
                if(first.getText().equals("No") || first.getText().equals("nobelium") || first.getText().equals("Nobelium")){
                    JOptionPane.showMessageDialog(null,
                                         "                In 1957, a group of scientists working at the Nobel Institute of Physics in Stockhlom, \n"
                                                 + "Sweden, announced the discovery of a new element. They produced this new element, which they \n"
                                                 + "named nobelium, by bombarding a target of curium-244 with ions of carbon-13 with a device \n"
                                                 + "called a cyclotron. The isotope they created had a half-life of 10 minutes. In 1958, another \n"
                                                 + "group of scientists, Albert Ghiorso, Glenn T. Seaborg, Torbørn Sikkeland and John R. Walton, \n"
                                                 + "working at the Lawrence Radiation Laboratory in Berkeley, California, attempted to confirm the \n"
                                                 + "Nobel Institute's discovery. They were unable to produce any isotope of nobelium with a half-life \n"
                                                 + "of 10 minutes, but were able to produce nobelium-254, with a half-life of three seconds, by \n"
                                                 + "bombarding curium-246 with carbon-12. A third group, working at the Joint Institute for Nuclear \n"
                                                 + "Research in Dubna, Russia, also could not duplicate the Nobel Institute's work but were able to \n"
                                                 + "confirm the Berkeley group's work. Credit for discovering nobelium was eventually given to the \n"
                                                 + "scientists working at Lawrence Radiation Laboratory, who decided to keep the name nobelium. Today, \n"
                                                 + "the Lawrence Radiation Laboratory is known as the Lawrence Berkeley Laboratory.\n" 
                                                 +"Nobelium's most stable isotope, nobelium-259, has a half-life of about 58 minutes. It decays into \n"
                                                 + "fermium-255 through alpha decay, into mendelevium-259 through electron capture or through \n"
                                                 + "spontaneous fission.\n" 
                                                 +"Since only tiny amounts of nobelium have ever been produced, there are currently no uses for it \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Nobelium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Lawrencium        103
                if(first.getText().equals("Lr") || first.getText().equals("lawrencium") || first.getText().equals("Lawrencium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Lawrencium was created by four American scientists, Albert Ghiorso, Torbjørn Sikkeland, Almon E. \n"
                                                 + "Larsh and Robert M. Latimer, in March, 1961. Working at the Lawrence Radiation Laboratory in Berkeley, \n"
                                                 + "California, the scientists placed three micrograms (0.000003 grams) of californium in the target chamber \n"
                                                 + "of a device called a linear accelerator. The scientists used the accelerator to bombard the californium \n"
                                                 + "with boron ions. Several different isotopes of lawrencium were created and there is some confusion as \n"
                                                 + "to which isotope the group actually detected. Today, the Lawrence Radiation Laboratory is known as the \n"
                                                 + "Lawrence Berkeley Laboratory.\n" 
                                                 +"Lawrencium's most stable isotope, lawrencium-262, has a half-life of about 4 hours. It decays into \n"
                                                 + "nobelium-262 through electron capture, mendelevium-258 through alpha decay or through spontaneous fission.\n" 
                                                 +"Since only tiny amounts of lawrencium have ever been produced, there are currently no uses for it outside \n"
                                                 + "of basic scientific research.\n"
        				  , "History & Uses of Lawrencium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Rutherfordium        104
                if(first.getText().equals("Rf") || first.getText().equals("rutherfordium") || first.getText().equals("Rutherfordium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Scientists working at the Joint Institute for Nuclear Research in Dubna, Russia, first \n"
                                                 + "reported the production of rutherfordium in 1964. They bombarded atoms of plutonium-242 with \n"
                                                 + "ions of neon-22, forming what they believed to be atoms of rutherfordium-260 and four free \n"
                                                 + "neutrons. In 1969, a group of scientists working at the Lawrence Radiation Laboratory, now \n"
                                                 + "known as the Lawrence Berkeley Laboratory, in Berkeley, California, attempted to confirm the \n"
                                                 + "Dubna group's discovery. Lacking the equipment needed to accelerate neon ions, the Berkeley \n"
                                                 + "group, led by Albert Ghiorso, bombarded atoms of californium-248 and californium-249 with \n"
                                                 + "ions of carbon-12 and carbon-13, producing atoms of rutherfordium-257, rutherfordium-258, \n"
                                                 + "rutherfordium-259 and rutherfordium-261. They were, however, unable to produce the same \n"
                                                 + "isotope as the Dubna group. Credit for the discovery of rutherfordium is still under debate.\n" 
                                                 +"Rutherfordium's most stable isotope, rutherfordium-263, has a half-life of about 10 minutes \n"
                                                 + "and decays through spontaneous fission.\n" 
                                                 +"Due to the small amounts produced and its short half-life, there are currently no uses for \n"
                                                 + "rutherfordium outside of basic scientific research.\n"
        				  , "History & Uses of Rutherfordium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Dubnium        105
                if(first.getText().equals("Db") || first.getText().equals("dubnium") || first.getText().equals("Dubnium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Scientists working at the Joint Institute for Nuclear Research in Dubna, Russia, \n"
                                                 + "first reported the production of dubnium in 1967. They bombarded atoms of americium-243 \n"
                                                 + "with ions of neon-22, forming atoms of dubnium-260 and five free neutrons and atoms of \n"
                                                 + "dubnium-261 and four free neutrons. In 1970, a group of scientists working at the \n"
                                                 + "Lawrence Radiation Laboratory, now known as the Lawrence Berkeley Laboratory, in Berkeley, \n"
                                                 + "California, bombarded atoms of californium-249 with ions of nitrogen-15, forming atoms \n"
                                                 + "of dubnium-260 and 4 free neutrons. Credit for the discovery of dubnium is still under \n"
                                                 + "debate.\n" 
                                                 +"Dubnium's most stable isotope, dubnium-268, has a half-life of about 32 hours and decays \n"
                                                 + "through spontaneous fission.\n" 
                                                 +"Due to the small amounts produced and its short half-life, there are currently no uses \n"
                                                 + "for dubnium outside of basic scientific research.\n"
        				  , "History & Uses of Dubnium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Seaborgium        106
                if(first.getText().equals("Sg") || first.getText().equals("seaborgium") || first.getText().equals("Seaborgium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Seaborgium was first produced by a team of scientists led by Albert Ghiorso working \n"
                                                 + "at the Lawrence Berkeley Laboratory in Berkeley, California, in 1974. They created seaborgium \n"
                                                 + "by bombarding atoms of californium-249 with ions of oxygen-18 using a machine called the \n"
                                                 + "Super-Heavy Ion Linear Accelerator. The collision produced atoms of seaborgium-263 and four \n"
                                                 + "free neutrons. Seaborgium-263 is an isotope of seaborgium with a half-life of about 1 second. \n"
                                                 + "Three months before the Berkeley group announced their discovery, a team of scientists working \n"
                                                 + "at the Joint Institute for Nuclear Research in Dubna, Russia, claimed to have produced \n"
                                                 + "seaborgium. Their method involved bombarding atoms of lead-207 and lead-208 with ions of \n"
                                                 + "chromium-54 with a device called a cyclotron. They believed that they had produced atoms of \n"
                                                 + "seaborgium-259. The Berkeley group's work was confirmed in 1993 and they were credited with \n"
                                                 + "the discovery.\n" 
                                                 +"Seaborgium's most stable isotope, seaborgium-271, has a half-life of about 2.4 minutes. It decays \n"
                                                 + "into rutherfordium-267 through alpha decay or decays through spontaneous fission..\n" 
                                                 +"Since only a few atoms of seaborgium have ever been made, there are currently no uses for \n"
                                                 + "seaborgium outside of basic scientific research.\n"
        				  , "History & Uses of Seaborgium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Bohrium        107
                if(first.getText().equals("Bh") || first.getText().equals("bohrium") || first.getText().equals("Bohrium")){
                    JOptionPane.showMessageDialog(null,
                                         "                First produced in 1976 by scientists working at the Joint Institute for Nuclear \n"
                                                 + "Research in Dubna, Russia, and later confirmed in 1981 by Peter Armbruster, Gottfried \n"
                                                 + "Münzenber and their team working at the Gesellschaft für Schwerionenforschung in \n"
                                                 + "Darmstadt, Germany, bohrium was produced by bombarding a target of bismuth-209 with \n"
                                                 + "ions of chromium-54.\n" 
                                                 +"Bohrium's most stable isotope, bohrium-270, has a half-life of about 1 minute. It \n"
                                                 + "decays into dubnium-266 through alpha decay.\n" 
                                                 +"Since only a few atoms of bohrium have ever been made, there are currently no uses for \n"
                                                 + "bohrium outside of basic scientific research.\n"
        				  , "History & Uses of Bohrium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Hassium        108
                if(first.getText().equals("Hs") || first.getText().equals("hassium") || first.getText().equals("Hassium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Hassium was first produced by Peter Armbruster, Gottfried Münzenber and their \n"
                                                 + "team working at the Gesellschaft für Schwerionenforschung in Darmstadt, Germany in \n"
                                                 + "1984. They bombarded atoms of lead-208 with ions of iron-58 with a device known as a \n"
                                                 + "linear accelerator. This produced atoms of hassium-265, an isotope with a half-life \n"
                                                 + "of about 2 milliseconds (0.002 seconds), and a free neutron.\n" 
                                                 +"Hassium's most stable isotope, hassium-270, has a half-life of about 22 seconds. It \n"
                                                 + "decays into seaborgium-266 through alpha decay.\n" 
                                                 +"Since only small amounts of hassium have ever been produced, it currently has no uses \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Hassium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Meitnerium        109
                if(first.getText().equals("Mt") || first.getText().equals("meitnerium") || first.getText().equals("Meitnerium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Meitnerium was first produced by Peter Armbruster, Gottfried Münzenber and their team \n"
                                                 + "working at the Gesellschaft für Schwerionenforschung in Darmstadt, Germany in 1982. They \n"
                                                 + "bombarded atoms of bismuth-209 with ions of iron-58 with a device known as a linear \n"
                                                 + "accelerator. This produced atoms of meitnerium-266, an isotope with a half-life of about \n"
                                                 + "3.8 milliseconds (0.0038 seconds), and a free neutron.\n" 
                                                 +"Meitnerium's most stable isotope, meitnerium-278, has a half-life of about 8 seconds. It \n"
                                                 + "decays into bohrium-274 through alpha decay.\n" 
                                                 +"Since only small amounts of meitnerium have ever been produced, it currently has no uses \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Meitnerium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Darmstadtium        110
                if(first.getText().equals("Ds") || first.getText().equals("darmstadtium") || first.getText().equals("Darmstadtium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Darmstadtium was first produced by Peter Armbruster, Gottfried Münzenber and their team working \n"
                                                 + "at the Gesellschaft für Schwerionenforschung in Darmstadt, Germany on November 9th, 1994. They bombarded \n"
                                                 + "atoms of lead with ions of nickel with a device known as a linear accelerator. This produced one atom of \n"
                                                 + "darmstadtium-269, an isotope with a half-life of about 0.17 milliseconds (0.00017 seconds), after at least \n"
                                                 + "a billion billion (1,000,000,000,000,000,000) nickel ions were fired at the lead target over the course \n"
                                                 + "of a week.\n" 
                                                 +"Darmstadtium's most stable isotope, darmstadtium-281, has a half-life of about 20 seconds. About 15% of \n"
                                                 + "the time, it decays into hassium-277 through alpha decay. The remaining 85% of the time, it decays through \n"
                                                 + "spontaneous fission.\n" 
                                                 +"Since only a few atoms of darmstadtium have ever been produced, it currently has no uses outside of basic \n"
                                                 + "scientific research.\n"
        				  , "History & Uses of Darmstadtium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Roentgenium        111
                if(first.getText().equals("Rg") || first.getText().equals("roentgenium") || first.getText().equals("Roentgenium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Roentgenium was first produced by Peter Armbruster, Gottfried Münzenber and their team \n"
                                                 + "working at the Gesellschaft für Schwerionenforschung in Darmstadt, Germany in late 1994. They \n"
                                                 + "bombarded atoms of bismuth-209 with ions of nickel-64 with a device known as a linear accelerator. \n"
                                                 + "This produced three atoms of roentgenium-272, an isotope with a half-life of about 1.5 milliseconds \n"
                                                 + "(0.0015 seconds), and a free neutron.\n" 
                                                 +"Roentgenium's most stable isotope, roentgenium-281, has a half-life of about 26 seconds and \n"
                                                 + "decays through spontaneous fission.\n" 
                                                 +"Since only a few atoms of roentgenium have ever been produced, it currently has no uses outside \n"
                                                 + "of basic scientific research.\n"
        				  , "History & Uses of Roentgenium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Copernicium        112
                if(first.getText().equals("Cn") || first.getText().equals("copernicium") || first.getText().equals("Copernicium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Copernicium was first produced by Peter Armbruster, Gottfried Münzenber and their team \n"
                                                 + "working at the Gesellschaft für Schwerionenforschung in Darmstadt, Germany on February 9, 1996. \n"
                                                 + "They bombarded atoms of lead with ions of zinc with a device known as a linear accelerator. \n"
                                                 + "This produced atoms of copernicium-277, an isotope with a half-life of about 0.24 milliseconds \n"
                                                 + "(0.00024 seconds).\n" 
                                                 +"Copernicium's most stable isotope, copernicium-285, has a half-life of about 30 seconds. It \n"
                                                 + "decays into darmstadtium-281 through alpha decay.\n" 
                                                 +"Since only a few atoms of copernicium have ever been produced, it currently has no uses outside \n"
                                                 + "of basic scientific research.\n" 
                                                 +"Originally, the symbol Cp was recommended for Copernicium. That symbol was rejected because Cp \n"
                                                 + "had previously been used for the element lutetium which, prior to 1949, had cassiopeium as an \n"
                                                 + "alternative allowed name. Please see this file for additional details.\n"
        				  , "History & Uses of Copernicium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Nihonium        113
                if(first.getText().equals("Nh") || first.getText().equals("nihonium") || first.getText().equals("Nihonium") || first.getText().equals("Uut") || first.getText().equals("ununtrium") || first.getText().equals("Ununtrium")){
                    JOptionPane.showMessageDialog(null,
                                         "                On July 23, 2004, scientists working at the RIKEN Nishina Center for Accelerator-based \n"
                                                 + "Science in Wako, Japan, created the first two atoms of the element nihonium by accelerating \n"
                                                 + "zinc ions to 10 percent the speed of light and then impacting them onto a thin bismuth target. \n"
                                                 + "Both atoms quickly underwent a series of four alpha decays, forming dubnium-262, which then \n"
                                                 + "decayed by spontaneous fission.\n" 
                                                 +"Nihonium's most stable isotope, nihonium-286, has a half-life of about 20 seconds. It decays \n"
                                                 + "into roentgenium-282 through alpha decay.\n" 
                                                 +"Since only a few atoms of nihonium have ever been produced, it currently has no uses outside \n"
                                                 + "of basic scientific research.\n"
        				  , "History & Uses of Nihonium/Ununtrium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Flerovium        114
                if(first.getText().equals("Fl") || first.getText().equals("flerovium") || first.getText().equals("Flerovium")){
                    JOptionPane.showMessageDialog(null,
                                         "                Flerovium was first produced by scientists working at the Joint Institute for \n"
                                                 + "Nuclear Research in Dubna, Russia in 1998. They bombarded atoms of plutonium with \n"
                                                 + "ions of calcium. This produced a single atom of flerovium-289, an isotope with a \n"
                                                 + "half-life of about 21 seconds.\n" 
                                                 +"Flerovium's most stable isotope, flerovium-289, has a half-life of about 0.97 seconds.\n"
                                                 + "It decays into copernicium-285 through alpha decay.\n" 
                                                 +"Since only a few atoms of flerovium have ever been produced, it currently has no uses \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Flerovium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Moscovium        115
                if(first.getText().equals("Mc") || first.getText().equals("moscovium") || first.getText().equals("Moscovium") || first.getText().equals("Uup") || first.getText().equals("ununpentium") || first.getText().equals("Ununpentium")){
                    JOptionPane.showMessageDialog(null,
                                         "                On February 2, 2004, scientists working at the Joint Institute for Nuclear Research \n"
                                                 + "in Dubna, Russia, along with scientists from the U.S. Department of Energy's Lawrence \n"
                                                 + "Livermore National Laboratory and Oak Ridge National Laboratory, announced the creation \n"
                                                 + "of moscovium. In experiments performed between July 14, 2003 and August 10, 2003, atoms \n"
                                                 + "of americium-243 were bombarded with ions of calcium-48 using a device called a cyclotron.\n"
                                                 + "This produced one atom of moscovium-287 and three atoms of moscovium-288. All four atoms \n"
                                                 + "quickly decayed into other elements.\n" 
                                                 +"Moscovium's most stable isotope, moscovium-289, has a half-life of about 220 milliseconds. \n"
                                                 + "It decays into nihonium-285 through alpha decay.\n" 
                                                 +"Since only a few atoms of moscovium have ever been produced, it currently has no uses \n"
                                                 + "outside of basic scientific research.\n"
        				  , "History & Uses of Moscovium/Ununpentium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Livermorium        116
                if(first.getText().equals("Lv") || first.getText().equals("livermorium") || first.getText().equals("Livermorium")){
                    JOptionPane.showMessageDialog(null,
                                         "                On December 6, 2000, scientists working at the Joint Institute for Nuclear \n"
                                                 + "Research in Dubna, Russia, along with scientists from the U.S. Department of Energy's \n"
                                                 + "Lawrence Livermore National Laboratory, announced the creation of livermorium. \n"
                                                 + "They produced livermorium by bombarding atoms of curium-248 with ions of calcium-48. \n"
                                                 + "This produced livermorium-292, an isotope with a half-life of about 0.6 milliseconds \n"
                                                 + "(0.0006 seconds), and four free neutrons.\n" 
                                                 +"Livermorium's most stable isotope, livermorium-293, has a half-life of about 53 \n"
                                                 + "milliseconds. It decays into flerovium-289 through alpha decay.\n" 
                                                 +"Since only a few atoms of livermorium have ever been produced, it currently has no \n"
                                                 + "uses outside of basic scientific research.\n"
        				  , "History & Uses of Livermorium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                
                //Tennessine        117
                if(first.getText().equals("Ts") || first.getText().equals("tennessine") || first.getText().equals("Tennessine") || first.getText().equals("Uus") || first.getText().equals("ununseptium") || first.getText().equals("Ununseptium")){
                    JOptionPane.showMessageDialog(null,
                                         "                On April 5, 2010, scientists working at the Joint Institute for Nuclear \n"
                                                 + "Research in Dubna, Russia, along with scientists from the U.S. Department of \n"
                                                 + "Energy's Lawrence Livermore National Laboratory and Oak Ridge National Laboratory, \n"
                                                 + "announced the creation of tennessine. They produced tennessine by bombarding atoms \n"
                                                 + "of berkelium-249 with ions of calcium-48.\n" 
                                                 +"Tennessine's most stable isotope, tennessine-294, has a half-life of about 80 \n"
                                                 + "milliseconds. It decays into moscovium-290 through alpha decay.\n" 
                                                 +"Since only a few atoms of tennessine have ever been produced, it currently has \n"
                                                 + "no uses outside of basic scientific research.\n"
        				  , "History & Uses of Tennessine/Ununseptium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //Oganesson        118
                if(first.getText().equals("Og") || first.getText().equals("oganesson") || first.getText().equals("Oganesson") || first.getText().equals("Uuo") || first.getText().equals("ununoctium") || first.getText().equals("Ununoctium")){
                    JOptionPane.showMessageDialog(null,
                                         "                On October 16, 2006, scientists working at the Joint Institute for \n"
                                                 + "Nuclear Research in Dubna, Russia, along with scientists from the U.S. \n"
                                                 + "Department of Energy's Lawrence Livermore National Laboratory, announced \n"
                                                 + "the creation of oganesson. They produced oganesson by bombarding atoms of \n"
                                                 + "californium-249 with ions of calcium-48. This produced oganesson-294, an \n"
                                                 + "isotope with a half-life of about 0.89 milliseconds (0.00089 seconds), and \n"
                                                 + "three free neutrons. The californium target was irradiated with a total of \n"
                                                 + "1.6*1019 calcium ions over the course of 1080 hours, resulting in the \n"
                                                 + "production of three atoms of oganesson.\n" 
                                                 +"Oganesson's most stable isotope, oganesson-294, has a half-life of about \n"
                                                 + "0.89 milliseconds. It decays into livermorium-290 through alpha decay.\n" 
                                                 +"Since only a few atoms of oganesson have ever been produced, it currently \n"
                                                 + "has no uses outside of basic scientific research.\n"
        				  , "History & Uses of Oganesson/Ununoctium", JOptionPane.INFORMATION_MESSAGE);
                }
                
                //END....................................................!
                
        }
		
        
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     
    if(ob==b6){
        /*JOptionPane.showMessageDialog(null, "", "Elements List", JOptionPane.INFORMATION_MESSAGE);*/
        
        first.setText("");
        first.requestFocus();
        
        Test();
        }



//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
   
        //About Button
        if(ob==b3){
        //JOptionPane.showMessageDialog(null,"Made By : SAMEER KHOWAHA", "Author", JOptionPane.INFORMATION_MESSAGE);
        Test2();
        first.setText("");
        first.requestFocus();
        }
        
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Clear Button
        if(ob==b2){
        first.setText("");
        first.requestFocus();
        }
        
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //Exit Button
        if(ob==b4){
        System.exit(0);
        }
        
    }

    //Connect with Periodic Table Button
    public void Test(){
    this.setBounds(0,10,0,0);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("pt2.png")));
     
    pan.add(jlb);
	
	this.setTitle("Periodic Table");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    //Connect with About Button
    public void Test2(){
    this.setBounds(40,40,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("by.jpg")));
     
    pan.add(jlb);

    this.setTitle("Author");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    //Main Class
    public static void main(String[] args) {
    	PeriodicTable pt = new PeriodicTable();
    }
    
}