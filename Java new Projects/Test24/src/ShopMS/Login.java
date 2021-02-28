package ShopMS;

import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import javax.swing.*;
/*User can access main frame by using this frame*/
public class Login extends JFrame implements ActionListener {

    JPanel panel = new JPanel();
    JLabel lbl_name = new JLabel("Name          : ");
    JLabel lbl_password = new JLabel("Password :  ");
    JTextField txt_name = new JTextField(15);
    JPasswordField txt_password = new JPasswordField(15);
    JButton lb = new JButton("Login");
    JButton cb = new JButton("Edit Password");
    Connection con;
    Statement st;
    ResultSet rs;

    Login() {
        super("User Login");
        panel.setLayout(null);
        add(panel);
        setSize(350, 280);
        setVisible(true);
        setLocation(480, 180);
        setResizable(false);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Add_Component();

    }

    void Add_Component() {////method of adding component with panel
        lbl_name.setBounds(30, 30, 70, 40);
        txt_name.setBounds(110, 30, 150, 40);

        txt_name.setForeground(Color.GREEN);
        panel.add(lbl_name);
        panel.add(txt_name);

        lbl_password.setBounds(30, 100, 70, 40);
        txt_password.setBounds(110, 100, 150, 40);
        panel.add(lbl_password);
        panel.add(txt_password);

        lb.setBounds(20, 180, 120, 40);
        lb.addActionListener(this);
        lb.setToolTipText("Login");
        lb.setMnemonic(KeyEvent.VK_L);
        panel.add(lb);

        cb.setBounds(160, 180, 130, 40);
        cb.setToolTipText("Change Password");
        cb.setMnemonic(KeyEvent.VK_E);
        cb.addActionListener(this);
        panel.add(cb);

    }

    public static void main(String[] args) {

        Login ob = new Login();

    }

    public void actionPerformed(ActionEvent e) {

        if (e.getSource() == lb) {
         
            if (txt_name.getText().equals("") || txt_password.getText().equals("")) {

                JOptionPane.showMessageDialog(null, "Please enter correct username or password", "Warning!!!", JOptionPane.ERROR_MESSAGE);

            }
            else 
            {
                ProductController.login(txt_name.getText(), txt_password.getText());
                Main ob=new Main();
                dispose();
            }

        }
       if (e.getSource() == cb)
       {
            UpdatePassword ob = new UpdatePassword();
            dispose();
       }

    }
}
