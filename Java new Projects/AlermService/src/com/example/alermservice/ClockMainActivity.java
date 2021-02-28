package com.example.alermservice;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.widget.AnalogClock;
import android.widget.Toast;

public class ClockMainActivity extends Activity {
	AnalogClock clk;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_clock_main); 
        clk = (AnalogClock) findViewById(R.id.analogClock1);
        
        clk.setOnClickListener(new View.OnClickListener() {
			
		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
				
			Toast.makeText(getBaseContext(), "This is Static AnalogClock",
				Toast.LENGTH_SHORT).show();
		}
	});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.clock_main, menu);
		return true;
	}
	

}
