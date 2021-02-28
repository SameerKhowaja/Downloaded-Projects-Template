package com.codename1.demos.calculator;


import com.codename1.ui.Button;
import com.codename1.ui.Component;
import com.codename1.ui.Container;
import com.codename1.ui.Display;
import com.codename1.ui.Form;
import com.codename1.ui.TextField;
import com.codename1.ui.layouts.BorderLayout;
import com.codename1.ui.layouts.GridLayout;
import com.codename1.ui.plaf.UIManager;
import com.codename1.ui.util.Resources;
import java.io.IOException;

/**
 * This is a demo Calculator app that performs simple Math.  Its purpose
 * is to demonstrate how to create a simple yet functional GUI in a mobile
 * application that runs on iOS, Android, Javascript, 
 * @author shannah
 */
public class Calculator {

    private Form current;
    
    private Resources theme;
    
    /**
     * The current operation
     * '+', '-', '*', or '/'
     */
    private char op;
    
    /**
     * The current calculated value
     */
    private double currVal;
    
    /**
     * The input field
     */
    TextField inputField;
    
    /**
     * Flag to indicate that the value has just been reset
     */
    boolean reset = true;
    
    /**
     * Flag to indicate that input mode is to append digits.
     * If false, the next digit pressed will replace whatever
     * is in the input field.
     */
    boolean appendDigits = false;
    
    public void init(Object context) {
        try {
            theme = Resources.openLayered("/theme");
            UIManager.getInstance().setThemeProps(theme.getTheme(theme.getThemeResourceNames()[0]));
        } catch(IOException e){
            e.printStackTrace();
        }
        
    }
    
    /**
     * Clears the current calculation.
     */
    private void clear() {
        inputField.setText(String.valueOf(0));
        op = 0;
        currVal = 0;
        reset = true;
        appendDigits = false;
    }
    
    /**
     * Executes the calculation given the most recent operation that
     * was pressed and displays the value in the input field.
     */
    private void exec() {
        
        double a = Double.parseDouble(inputField.getText());
        if (reset) {
            currVal = a;
            return;
        } else {
            switch (op) {
                case '+': currVal +=  a; break;
                case '-': currVal -= a; break;
                case '*': currVal *= a; break;
                case '/': currVal /= a; break;
            }
        }
        inputField.setText(String.valueOf(currVal));
        appendDigits = true;
        
    }
    
    /**
     * Appends the given digit to the input field.
     * @param digit 
     */
    private void append(int digit) {
        String s = digit >= 0 ? String.valueOf(digit) : ".";
        if (appendDigits) {
            inputField.setText(inputField.getText()+s);
        } else {
            inputField.setText(s);
            appendDigits = true;
        }
    }
    
    /**
     * Sets the current operation, and executes it.
     * @param op 
     */
    private void setOp(char op) {
        exec();
        this.op = op;
        this.reset = false;
        
        appendDigits = false;
        
    }
    
    public void start() {
        if (current != null) {
            current.show();
            return;
        }
        // Create the calculator form
        Form f = new Form("Calculator");
        f.setLayout(new BorderLayout());
        
        // The input field placed in the north section
        inputField = new TextField();
        inputField.getDisabledStyle().setAlignment(Component.RIGHT);
        inputField.setEnabled(false);
        inputField.setText(String.valueOf(0));
        f.addComponent(BorderLayout.NORTH, inputField);
        
        
        // We place the numbers in a GridLayout with 4 rows and 3 columns.
        
        Container numbers = new Container();
        numbers.setLayout(new GridLayout(4,3));
        
        // We'll set up the digits as integers.  Only non-negative ints
        // will result in a button being placed for it.
        int digits[] = {1,2,3,4,5,6,7,8,9,-1,0};
        for (int i=0; i<digits.length; i++) {
            int digit = digits[i];
            if (digit >= 0) {
                Button digitButton = new Button(String.valueOf(digit));
                
                // Add action listener to digit button which appends
                // the current digit to the input.
                digitButton.addActionListener((e) -> {append(digit);});
                numbers.addComponent(digitButton);
            } else {
                // If the digit was negative, we just want an empty space in the
                // grid.
                Container c = new Container();
                numbers.addComponent(c);
            }
        }
        
        // Add a decimal button to the last position in the grid.
        Button decimalButton = new Button(".");
        
        // We adopt convention that appending -1 results in decimal
        // being placed in the input field.
        decimalButton.addActionListener((e) -> {append(-1);});
        numbers.addComponent(decimalButton);
        
        f.addComponent(BorderLayout.CENTER, numbers);
        
        // Set up container for the command buttons (+, -, *, etc..)
        // We will place this in the east section in a grid layout.
        Container commands = new Container();
        commands.setPreferredW(Display.getInstance().getDisplayWidth()/4);
        commands.setLayout(new GridLayout(4,1));
        Button clear = new Button("C");
        clear.addActionListener((e) -> {clear();});
        commands.addComponent(clear);
        
        Button plus = new Button("+");
        plus.addActionListener((e) -> {setOp('+');});
        commands.addComponent(plus);
        
        Button minus = new Button("-");
        minus.addActionListener((e) -> {setOp('-');});
        commands.addComponent(minus);
        
        Button mult = new Button("x");
        mult.addActionListener((e) -> {setOp('*');});
        commands.addComponent(mult);
        
        Button div = new Button("/");
        div.addActionListener((e) -> {setOp('/');});
        commands.addComponent(div);
        
        Button eq = new Button("=");
        eq.addActionListener((e) -> {setOp('=');});
        commands.addComponent(eq);
        
        
        f.addComponent(BorderLayout.EAST, commands);
        
        
        // Show the form.
        f.show();
        
                
    }

    public void stop() {
        current = Display.getInstance().getCurrent();
    }
    
    public void destroy() {
    }

}
