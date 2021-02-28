package formapplication;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.JOptionPane;



public class form extends Frame implements ActionListener{

     private Label fname,lname,dob,mo,email,addr,city;
     private TextField txtfname,txtlname,txtdob,txtmo,txtemail,txtaddr,txtcity;
     private Button save,clear,exit,submit,New;
     private TextArea txtdisplay;
     
    public form(){

        setLayout(null);
        setTitle("FORM APPLICATION");
        setSize(950,650);
        setLocation(600,600);
        setBackground(Color.ORANGE);
      
        
        fname = new Label("First Name:");
        fname.setBounds(50, 100,90, 60);
        fname.setFont(new Font("Algerian",Font.BOLD,16));
        fname.setForeground(Color.RED);
        add(fname);

        lname = new Label("Last Name:");
        lname.setBounds(50, 150,90, 60);
        lname.setFont(new Font("Algerian",Font.BOLD,16));
        add(lname);

        dob = new Label("Date Of Birth:");
        dob.setBounds(50, 200, 110, 60);
        dob.setFont(new Font("Algerian",Font.BOLD,16));
        dob.setForeground(Color.RED);
        add(dob);

        mo = new Label("Mobile No:");
        mo.setBounds(50, 250, 90, 60);
        mo.setFont(new Font("Algerian",Font.BOLD,16));
        add(mo);

        email = new Label("Email");
        email.setBounds(50, 300, 90, 60);
        email.setFont(new Font("Algerian",Font.BOLD,16));
        email.setForeground(Color.RED);
        add(email);

        addr = new Label("Address:");
        addr.setBounds(50,350,90, 60);
        addr.setFont(new Font("Algerian",Font.BOLD,16));
        add(addr);

        city = new Label("City:");
        city.setBounds(50,400,90, 60);
        city.setFont(new Font("Algerian",Font.BOLD,16));
        city.setForeground(Color.RED);
        add(city);

        txtfname = new TextField();
        txtfname.setBounds(160, 115, 220,25);
        txtfname.setFont(new Font("Algerian",Font.BOLD,16));
        txtfname.setBackground(Color.pink);
        add(txtfname);

        txtlname = new TextField();
        txtlname.setBounds(160,165, 220, 25);
        txtlname.setFont(new Font("Algerian",Font.BOLD,16));
        txtlname.setBackground(Color.pink);
        add(txtlname);

        txtdob = new TextField();
        txtdob.setBounds(160, 215, 220, 25);
        txtdob.setFont(new Font("Algerian",Font.BOLD,16));
        txtdob.setBackground(Color.pink);
        add(txtdob);

        txtmo = new TextField();
        txtmo.setBounds(160, 265, 220, 25);
        txtmo.setFont(new Font("Algerian",Font.BOLD,16));
        txtmo.setBackground(Color.pink);
        add(txtmo);

        txtemail = new TextField();
        txtemail.setBounds(160, 315, 220, 25);
        txtemail.setFont(new Font("Algerian",Font.BOLD,16));
        txtemail.setBackground(Color.pink);
        add(txtemail);

        txtaddr = new TextField();
        txtaddr.setBounds(160, 365, 220, 25);
        txtaddr.setFont(new Font("Algerian",Font.BOLD,16));
        txtaddr.setBackground(Color.pink);
        add(txtaddr);

        txtcity = new TextField();
        txtcity.setBounds(160, 415, 220, 25);
        txtcity.setFont(new Font("Algerian",Font.BOLD,16));
        txtcity.setBackground(Color.pink);
        add(txtcity);

        
        submit = new Button("Submit");
        submit.setBounds(40, 500, 80, 40);
        submit.addActionListener(this);
        submit.setFont(new Font("Algerian",Font.BOLD,16));
        submit.setBackground(Color.GREEN);
        add(submit);
        
        save = new Button("Save");
        save.setBounds(140, 500, 80, 40);
        save.addActionListener(this);
        save.setFont(new Font("Algerian",Font.BOLD,16));
        save.setBackground(Color.GREEN);
        add(save);

        New = new Button("New");
        New.setBounds(240,500,80,40);
        New.addActionListener(this);
        New.setFont(new Font("Algerian",Font.BOLD,16));
        New.setBackground(Color.GREEN);
        add(New);

        clear = new Button("Clear");
        clear.setBounds(340,500,80,40);
        clear.addActionListener(this);
        clear.setFont(new Font("Algerian",Font.BOLD,16));
        clear.setBackground(Color.GREEN);
        add(clear);

        exit = new Button("Exit");
        exit.setBounds(440,500,80,40);
        exit.addActionListener(this);
        exit.setFont(new Font("Algerian",Font.BOLD,16));
        exit.setBackground(Color.GREEN);
        add(exit);

        txtdisplay = new TextArea();
        txtdisplay.setBounds(580,110,350,400);
        txtdisplay.setFont(new Font("Algerian",Font.BOLD,16));
        txtdisplay.setBackground(Color.PINK);
        add(txtdisplay);

        addWindowListener(new WindowAdapter(){
            public void windowClosing(WindowEvent e){

                System.exit(0);
            }

        });
    }

    public void paint(Graphics g){

        g.setFont(new Font("Comic Sans MS",Font.BOLD,30));
        g.setColor(Color.BLUE);
        g.drawString("Form Application", 80,80);
        
        g.setFont(new Font("Comic Sans MS",Font.BOLD,30));
        g.setColor(Color.BLUE);
        g.drawString("Form Data", 650,80);

        g.drawLine(550, 100, 550, 550);
        g.drawLine(530, 100, 530, 550);

        g.drawString("Developed By :Bhaumik Mistry", 100, 600);
    }
    public void actionPerformed(ActionEvent e){

        if(e.getSource()== New){

            txtfname.setText(" ");
            txtlname.setText(" ");
            txtdob.setText(" ");
            txtmo.setText(" ");
            txtemail.setText(" ");
            txtaddr.setText(" ");
            txtcity.setText(" ");

            txtdisplay.setText(" ");
        }
        else if(e.getSource()== submit){

                String strfname = txtfname.getText();
                String strlname = txtlname.getText();
                String strdob = txtdob.getText();
                String strmo = txtmo.getText();
                String stremail = txtemail.getText();
                String straddr = txtaddr.getText();
                String strcity = txtcity.getText();

                txtdisplay.setText("\n\n"+"First Name :"+strfname+"\n\n"+"Last Name :"+strlname+"\n\n"+"Date Of Birth"+strdob+"\n\n"+"Mobile No:"+strmo+"\n\n"+"Email :"+stremail+"\n\n"+"Address :"+straddr+"\n\n"+"City :"+strcity+"\n\n");
                
        }
         else if(e.getSource()== exit){

           System.exit(0);
        }
        else if(e.getSource()== save){
            
           try{
                FileOutputStream fos = new FileOutputStream("Bhaumik.txt",true);
                DataOutputStream dos = new DataOutputStream(fos);
                String str2 = "\n\n";
                String str1 = txtdisplay.getText();
                dos.writeChars(str1+str2);
                dos.close();

                 JOptionPane.showMessageDialog(null, "Record Saved..");
           }catch(Exception ex){

             
           }
        }
        else if(e.getSource()== clear){

            txtfname.setText(" ");
            txtlname.setText(" ");
            txtdob.setText(" ");
            txtmo.setText(" ");
            txtemail.setText(" ");
            txtaddr.setText(" ");
            txtcity.setText(" ");

            txtdisplay.setText(" ");
        }
       
    }

 
    public static void main(String[] args) {
       new form().setVisible(true);
    }

   
}
