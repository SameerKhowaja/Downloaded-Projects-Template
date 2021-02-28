package com.example.alermservice;

import java.util.Calendar;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.view.Menu;
import android.widget.ImageView;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
	    	Intent i=new Intent(this,Myservice.class);
	    	
			PendingIntent	  pendingIntent = PendingIntent.getService(this, 0, i, 0);
			final Calendar time = Calendar.getInstance();
		//	time.set(Calendar.MINUTE, 0);
			//time.set(Calendar.SECOND, 0);
			//time.set(Calendar.MILLISECOND, 0);
			AlarmManager alarmManager = (AlarmManager)this.getSystemService(Context.ALARM_SERVICE);
			//alarmManager.set(AlarmManager.RTC, 1000,pendingIntent );
			alarmManager.setRepeating(AlarmManager.RTC, time.getTime().getTime()
	                , 60000, pendingIntent);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}
