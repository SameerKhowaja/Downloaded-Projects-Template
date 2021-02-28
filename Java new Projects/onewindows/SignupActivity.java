package com.app.onewindows;

import com.app.onewindows.R;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.graphics.Typeface;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.View.OnClickListener;
import android.widget.ImageView;
import android.widget.PopupMenu;
import android.widget.TextView;
import android.widget.Toast;

public class SignupActivity extends Activity {

	private TextView lognbtn;
	private TextView signupUser,ms;
	ImageView menubtn;
	ImageView fb;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.signup);
		fb=(ImageView)findViewById(R.id.fb);
		fb.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent i=new Intent(getBaseContext(),AndroidExampleFacebookActivity.class);
//                startActivity(i);
			}
		});
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		ms=(TextView)findViewById(R.id.ms);
		
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		ms.setTypeface(myTypeface3);
		
		regtxt.setText("Connect with us");
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg);
regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				finish();			}
		});
		lognbtn=(TextView)findViewById(R.id.lognbtn);
		
		Typeface btn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		lognbtn.setTypeface(btn);
		
		lognbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				 Intent i=new Intent(getBaseContext(),LoginActivity.class);
                 startActivity(i);
                  
                 //Remove activity
                 finish();
			}
		});
		signupUser=(TextView)findViewById(R.id.signupUser);
		
		Typeface btn1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		signupUser.setTypeface(btn1);
		TextView or=(TextView)findViewById(R.id.or);
		Typeface btn2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		or.setTypeface(btn2);
signupUser.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				 Intent i=new Intent(getBaseContext(),SignupUserActivity.class);
                 startActivity(i);
                  
                 //Remove activity
                 finish();
			}
		});



menubtn = (ImageView) findViewById(R.id.menuopt);  
menubtn.setOnClickListener(new OnClickListener() {  
 
 @SuppressLint("NewApi")
@Override  
 public void onClick(View v) {  
	  //Creating the instance of PopupMenu  
	  PopupMenu popup = new PopupMenu(SignupActivity.this, menubtn);  
	  //Inflating the Popup using xml file  
	  popup.getMenuInflater().inflate(R.menu.homemenu, popup.getMenu());  
	 
	  //registering popup with OnMenuItemClickListener  
	  popup.setOnMenuItemClickListener(new PopupMenu.OnMenuItemClickListener() {  
	   public boolean onMenuItemClick(MenuItem item) { 
		   
		   if(item.getTitle().equals("Login"))
		   {
			   Intent home=new Intent(SignupActivity.this, LoginActivity.class);
					startActivity(home);
			   
		   }
		   else if(item.getTitle().equals("About"))
		   {
			   Intent home=new Intent(SignupActivity.this, About.class);
				startActivity(home);
		   }
		   else if(item.getTitle().equals("Our Mission"))
		   {
			   Intent mission=new Intent(SignupActivity.this, MissonActivity.class);
			   startActivity(mission);
		   }
		   else if (item.getTitle().equals("Feedback")) {
				Intent fd=new Intent(SignupActivity.this, Feedback.class);
				   startActivity(fd);
			}
		   
		   else if(item.getTitle().equals("Call OneWindow"))
		   {
			   
		   }
		   else if(item.getTitle().equals("Share OneWindow"))
		   {
			   shareTextUrl();
		   }
		   
	    Toast.makeText(SignupActivity.this,"You Clicked : " + item.getTitle(),Toast.LENGTH_SHORT).show();  
	    return true;  
	   }  
	  });  

	  popup.show();//showing popup menu  
	 }  
});//closing the setOnClickListener method  
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
	
	private void shareTextUrl() {
	    Intent share = new Intent(android.content.Intent.ACTION_SEND);
	    share.setType("text/plain");
	    share.addFlags(Intent.FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET);
	 
	    // Add data to the intent, the receiving app will decide
	    // what to do with it.
	    share.putExtra(Intent.EXTRA_SUBJECT, "Title Of The Post");
	    share.putExtra(Intent.EXTRA_TEXT, "https://www.onewindow.com");
	 
	    startActivity(Intent.createChooser(share, "Share link!"));
	}
}
