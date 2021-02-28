package com.app.onewindows;


import com.app.onewindows.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.Window;

public class SplashActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_splash);
		
		Thread background = new Thread() {
            public void run() {
                 
                try {
                	
                	
                    // Thread will sleep for 5 seconds
                    sleep(3*1000);
                    
//                getUserPass=getSharedPreferences("rember", MODE_PRIVATE);
//                	
//                	String userName=getUserPass.getString("user", " ");
//                	String pass=getUserPass.getString("pass", " ");
//                	if(!userName.equalsIgnoreCase("")&& !pass.equalsIgnoreCase("")){
//                		new LoginAsync1(userName,pass).execute();
//                	}
//                	else{
                    
                    // After 5 seconds redirect to another intent
                    Intent i=new Intent(getBaseContext(),HomeActivity.class);
                    startActivity(i);
                     
                    //Remove activity
                    finish();
              //  	}
                     
                } catch (Exception e) {
                 e.printStackTrace();
                }
            }
        };
         
        // start thread
        background.start();
	}
	

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.splash, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}
}
