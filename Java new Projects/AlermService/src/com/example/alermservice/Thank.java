package com.example.alermservice;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;

public class Thank extends Activity {
ImageView home,cmp;
Button ok;

Animation  animFadeOut;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_thank);
		cmp=(ImageView)findViewById(R.id.cmpny);
		
		animFadeOut=AnimationUtils.loadAnimation(getApplicationContext(), R.anim.seq);
		cmp.startAnimation(animFadeOut);
		ok=(Button)findViewById(R.id.thank);
		home=(ImageView)findViewById(R.id.home);
		home.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent transfr=new Intent(getApplicationContext(), SettingMainActivity.class);
				startActivity(transfr);
				overridePendingTransition(R.anim.up, R.anim.up);
			}
		});
		ok.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent transfr=new Intent(getApplicationContext(), SettingMainActivity.class);
				startActivity(transfr);
				overridePendingTransition(R.anim.slid, R.anim.slid);
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.thank, menu);
		return true;
	}

}
