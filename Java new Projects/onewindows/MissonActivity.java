package com.app.onewindows;


import android.app.Activity;
import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.graphics.Typeface;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.ImageView;
import android.widget.TextView;

public class MissonActivity  extends Activity{
	ImageView one1,threed,four,second,five;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.misson);
		ImageView menuopt=(ImageView)findViewById(R.id.menuopt);
		menuopt.setVisibility(View.GONE);
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		
		regtxt.setText("OurMission");
		
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg);
		threed=(ImageView)findViewById(R.id.threed);
		four=(ImageView)findViewById(R.id.four);
		one1=(ImageView)findViewById(R.id.one1);
		second=(ImageView)findViewById(R.id.second);
		five=(ImageView)findViewById(R.id.five);
		five.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
//				second.setBackgroundResource(R.drawable.consul);
//				threed.setBackgroundResource(R.drawable.howitworks);
//				four.setBackgroundResource(R.drawable.profes);
//				one1.setBackgroundResource(R.drawable.own);
//				five.setBackgroundResource(R.drawable.howitworks_at);
				
				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.own));
				second.setImageDrawable(v.getResources().getDrawable(R.drawable.consul));
				threed.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks));
				four.setImageDrawable(v.getResources().getDrawable(R.drawable.profes));
				five.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks_at));
				
				
				
				Tabs5();
			}
		});
one1.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
//				second.setBackgroundResource(R.drawable.consul);
//				threed.setBackgroundResource(R.drawable.howitworks);
//				four.setBackgroundResource(R.drawable.profes);
//				five.setBackgroundResource(R.drawable.why);
//				one1.setBackgroundResource(R.drawable.owner_icons);
				
				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.owner_icons));
				second.setImageDrawable(v.getResources().getDrawable(R.drawable.consul));
				threed.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks));
				four.setImageDrawable(v.getResources().getDrawable(R.drawable.profes));
				five.setImageDrawable(v.getResources().getDrawable(R.drawable.why));
				
				
				
				CallmissonFrg();
				
			}
		});
		second.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
//				second.setBackgroundResource(R.drawable.con_act);
//				threed.setBackgroundResource(R.drawable.howitworks);
//				four.setBackgroundResource(R.drawable.profes);
//				five.setBackgroundResource(R.drawable.why);
//				one1.setBackgroundResource(R.drawable.owner_icons);
				
				
				

				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.own));
				second.setImageDrawable(v.getResources().getDrawable(R.drawable.consul_at));
				threed.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks));
				four.setImageDrawable(v.getResources().getDrawable(R.drawable.profes));
				five.setImageDrawable(v.getResources().getDrawable(R.drawable.why));
				
				
				Tabs2();
				
			}
		});
		four.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
//				second.setBackgroundResource(R.drawable.consul);
//				threed.setBackgroundResource(R.drawable.howitworks);
//				four.setBackgroundResource(R.drawable.prof_act);
//				five.setBackgroundResource(R.drawable.why);
//				one1.setBackgroundResource(R.drawable.owner_icons);
//				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.owner_icons));
				
				
				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.own));
				second.setImageDrawable(v.getResources().getDrawable(R.drawable.consul));
				threed.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks));
				four.setImageDrawable(v.getResources().getDrawable(R.drawable.profes_at));
				five.setImageDrawable(v.getResources().getDrawable(R.drawable.why));
				
				
				
				Tabs4();
				
			}
		});
		threed.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
//				second.setBackgroundResource(R.drawable.consul);
//				threed.setBackgroundResource(R.drawable.how_act);
//				four.setBackgroundResource(R.drawable.profes);
//				five.setBackgroundResource(R.drawable.why);
				
				one1.setImageDrawable(v.getResources().getDrawable(R.drawable.own));
				second.setImageDrawable(v.getResources().getDrawable(R.drawable.consul));
				threed.setImageDrawable(v.getResources().getDrawable(R.drawable.howitworks_at));
				four.setImageDrawable(v.getResources().getDrawable(R.drawable.profes));
				five.setImageDrawable(v.getResources().getDrawable(R.drawable.why));
				
				
				//one1.setBackgroundResource(R.drawable.owner_icons);
				Tabs3();
			}
		});
regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
				MissonActivity.this.finish();
			}
		});
		CallmissonFrg();
	}
	
	private void CallmissonFrg() {

		Fragment fragment = new MissionFragment();
		FragmentManager fm = getFragmentManager();
		FragmentTransaction ft = fm.beginTransaction();
		ft.replace(R.id.container, fragment);
		ft.commit();
		
		

	}
	
	
	private void Tabs2() {

		Fragment fragment = new ConsultantFragment();
		FragmentManager fm = getFragmentManager();
		FragmentTransaction ft = fm.beginTransaction();
		ft.replace(R.id.container, fragment);
		ft.commit();

	}
	private void Tabs3() {

		Fragment fragment = new HowItWorkFragment();
		FragmentManager fm = getFragmentManager();
		FragmentTransaction ft = fm.beginTransaction();
		ft.replace(R.id.container, fragment);
		ft.commit();

	}
	private void Tabs4() {

		Fragment fragment = new ProfessionalFragment();
		FragmentManager fm = getFragmentManager();
		FragmentTransaction ft = fm.beginTransaction();
		ft.replace(R.id.container, fragment);
		ft.commit();

	}
	private void Tabs5() {

		Fragment fragment = new WhyOneWindowSolutionFragment();
		FragmentManager fm = getFragmentManager();
		FragmentTransaction ft = fm.beginTransaction();
		ft.replace(R.id.container, fragment);
		ft.commit();

	}
	
	

}
