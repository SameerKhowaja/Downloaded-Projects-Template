package com.example.alermservice;

import java.util.Calendar;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.widget.ImageView;
import android.widget.LinearLayout;

public class SettingMainActivity extends Activity {
	 LinearLayout l1,l2,l3,l4;
	 ImageView left;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_setting_main);
        l1=(LinearLayout)findViewById(R.id.clock_bt);
        l2=(LinearLayout)findViewById(R.id.txtspeech_bt);
        l3=(LinearLayout)findViewById(R.id.setting);
        l4=(LinearLayout)findViewById(R.id.normalsetting);
        left=(ImageView)findViewById(R.id.left_bt);
        left.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i=new Intent(getApplicationContext(), Thank.class);
				startActivity(i);finish();
			    overridePendingTransition(R.anim.custm6,R.anim.custm6);
			}
		});
        
		l1.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i=new Intent(getApplicationContext(), ClockMainActivity.class);
				startActivity(i);finish();
			overridePendingTransition(R.anim.custm7,R.anim.custm7);
			}
		});
		l2.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i=new Intent(getApplicationContext(), TextSpeech.class);
				startActivity(i);finish();
			overridePendingTransition(R.anim.move,R.anim.move);
			}
		});
l3.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i=new Intent(getApplicationContext(), SettingAlermMainActivity.class);
				startActivity(i);finish();
			overridePendingTransition(R.anim.custm4,R.anim.custm4);
			}
		});
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
        getMenuInflater().inflate(R.menu.setting_main, menu);
        return true;
    }
    
}
