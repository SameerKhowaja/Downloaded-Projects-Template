package com.example.alermservice;



import java.util.Calendar;

import android.os.Bundle;
import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TimePicker;
import android.widget.Toast;

public class SettingAlermMainActivity extends Activity {
  ImageView cbk;
  Spinner sp;
  Button dt,tm,sv;
  RadioGroup typ;
  String spiner_txt,radioType;
  String custome_txt=" ";
  SQLiteDatabase sqldb;
  private int mYear, mMonth, mDay, mHour, mMinute;
  String []text={"--Select--","office Jana hai","Walking pe jana hai","Date pe jana hai"};
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_setting_alerm_main);
		generateID();
		db();
		
		ArrayAdapter aa = new ArrayAdapter(getApplicationContext(), android.R.layout.simple_expandable_list_item_1, text);
		//ArrayAdapter aa = new ArrayAdapter<T>(getApplicationContext(), resource, objects)
        aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);  
        //Setting the ArrayAdapter data on the Spinner  
        sp.setAdapter(aa);
		
		
		cbk=(ImageView)findViewById(R.id.normal_cbk);
		
		cbk.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i=new Intent(getApplicationContext(), Thank.class);
				startActivity(i);
				overridePendingTransition(R.anim.slid, R.anim.slid);
			}
		});
		
		sp.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

			@Override
			public void onItemSelected(AdapterView<?> arg0, View arg1,
					int arg2, long arg3) {
				// TODO Auto-generated method stub
				Toast.makeText(getApplicationContext(), spiner_txt=arg0.getItemAtPosition(arg2).toString(),1000).show();
			}

			@Override
			public void onNothingSelected(AdapterView<?> arg0) {
				// TODO Auto-generated method stub
				
			}
		});
		typ.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
			
			@Override
			public void onCheckedChanged(RadioGroup arg0, int checkedId) {
				// TODO Auto-generated method stub
				switch (checkedId) {
				case R.id.daily_alerm:
					radioType="daily";
					
				break;
				case R.id.manual_alerm:
					radioType="alternet";
				break;
				
				
			}
			}
		});
		sv.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				savertAlerm_Setting();
			}
		});
		
	}
	public void dt_set(View v)
	{
		 final Calendar c = Calendar.getInstance();
         mYear = c.get(Calendar.YEAR);
         mMonth = c.get(Calendar.MONTH);
         mDay = c.get(Calendar.DAY_OF_MONTH);

         // Launch Date Picker Dialog
         DatePickerDialog dpd = new DatePickerDialog(this,
                 new DatePickerDialog.OnDateSetListener() {

                     public void onDateSet(DatePicker view, int year,
                             int monthOfYear, int dayOfMonth) {
                    	   
                    		  dt.setText( (monthOfYear + 1) +"/" +dayOfMonth + "/" + year);
                    	  
                     }
                 }, mYear, mMonth, mDay);
         dpd.show(); 
	}
	public void tm_set(View v)
	{
		 final Calendar c = Calendar.getInstance();
         mHour = c.get(Calendar.HOUR_OF_DAY);
         mMinute = c.get(Calendar.MINUTE);

         // Launch Time Picker Dialog
         TimePickerDialog tpd = new TimePickerDialog( this,
                 new TimePickerDialog.OnTimeSetListener() {
  
					public void onTimeSet(TimePicker view, int hourOfDay, int minute) {
						// TODO Auto-generated method stub
						 
						//String am_pm="";
						//t4.setText(""+hourOfDay);
							
						tm.setText(hourOfDay + ":" + minute);
						
					}

						
                 }, mHour, mMinute, true);
        
         tpd.show();
	}
	public void generateID()
	{
		sp=(Spinner)findViewById(R.id.sound);
		dt=(Button)findViewById(R.id.dt);
		tm=(Button)findViewById(R.id.tm);
		sv=(Button)findViewById(R.id.sv);
		typ=(RadioGroup)findViewById(R.id.type1);
	}
	public void db()
	{
		sqldb=openOrCreateDatabase("alermService.db", SQLiteDatabase.CREATE_IF_NECESSARY, null);
	}
	public void savertAlerm_Setting()
	{
		sqldb.execSQL("insert into alerm_setting values('"+spiner_txt+"','"+custome_txt+"','"+dt.getText().toString()+"','"+tm.getText().toString()+"','"+radioType+"')");
    	Toast.makeText(getApplicationContext(), "Alerm Set succussfully", 1000).show();
	}


	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.setting_alerm_main, menu);
		return true;
	}

}
