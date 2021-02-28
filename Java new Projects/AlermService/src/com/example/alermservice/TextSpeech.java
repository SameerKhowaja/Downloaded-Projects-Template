package com.example.alermservice;

import java.util.Calendar;

import android.os.AsyncTask;
import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.ProgressDialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.speech.tts.TextToSpeech;
import android.speech.tts.TextToSpeech.OnInitListener;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TimePicker;
import android.widget.Toast;

public class TextSpeech extends Activity {

	private int mYear, mMonth, mDay, mHour, mMinute;
	Spinner text_speech_select;
	EditText custome_text_speech_alerm;
	RadioGroup type_alerm;
	ImageView bck;
	Button time_select, save_alerm, date_set, test_speech;
	String selected_txt;
	String radioType;
	SQLiteDatabase sqldb;
	
	String[] text = { "--Select--", "office Jana hai", "Walking pe jana hai",
			"Date pe jana hai" };

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_text_speech);
		id_generater();
		db();
		
		
			
			
		ArrayAdapter aa = new ArrayAdapter(getApplicationContext(),
				android.R.layout.simple_expandable_list_item_1, text);
		// ArrayAdapter aa = new ArrayAdapter<T>(getApplicationContext(),
		// resource, objects)
		aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		// Setting the ArrayAdapter data on the Spinner
		text_speech_select.setAdapter(aa);

		bck.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent i = new Intent(getApplicationContext(), Thank.class);
				startActivity(i);
				overridePendingTransition(R.anim.slid, R.anim.slid);
			}
		});

		text_speech_select
				.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

					@Override
					public void onItemSelected(AdapterView<?> arg0, View arg1,
							int arg2, long arg3) {
						selected_txt = arg0.getItemAtPosition(arg2).toString();
					}

					@Override
					public void onNothingSelected(AdapterView<?> arg0) {
						// TODO Auto-generated method stub

					}
				});
		save_alerm.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Call saveAlerm methode to a set Alerm
				savertAlerm_Setting();
				Intent transfr = new Intent(getApplicationContext(),
						SettingMainActivity.class);
				startActivity(transfr);
				overridePendingTransition(R.anim.right, R.anim.right);
			}
		});
		type_alerm
				.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {

					@Override
					public void onCheckedChanged(RadioGroup arg0, int checkedId) {
						// TODO Auto-generated method stub

						switch (checkedId) {
						case R.id.daily:
							radioType = "daily";

							break;
						case R.id.normal:
							radioType = "alternet";
							break;

						}
					}
				});
		test_speech.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				String st=custome_text_speech_alerm.getText().toString();
				Intent i=new Intent(getApplicationContext(), Speak.class);
				i.putExtra("txt",st );
				startActivity(i);
			}
		});
	}

	public void dateSet(View v) {
		final Calendar c = Calendar.getInstance();
		mYear = c.get(Calendar.YEAR);
		mMonth = c.get(Calendar.MONTH);
		mDay = c.get(Calendar.DAY_OF_MONTH);

		// Launch Date Picker Dialog
		DatePickerDialog dpd = new DatePickerDialog(this,
				new DatePickerDialog.OnDateSetListener() {

					public void onDateSet(DatePicker view, int year,
							int monthOfYear, int dayOfMonth) {

						date_set.setText((monthOfYear + 1) + "/" + dayOfMonth
								+ "/" + year);

					}
				}, mYear, mMonth, mDay);
		dpd.show();
	}

	public void db() {

		try {

			String qry = "create table if not exists alerm_setting(alerm_text text,custome_text text,dt text,tm text,alerm_type text)";
			sqldb = openOrCreateDatabase("alermService.db",
					SQLiteDatabase.CREATE_IF_NECESSARY, null);
			sqldb.execSQL(qry);
			
		} catch (Exception e) {
			
		}
	}

	public void speak() {

	}

	public void timeSet(View v) {
		final Calendar c = Calendar.getInstance();
		mHour = c.get(Calendar.HOUR_OF_DAY);
		mMinute = c.get(Calendar.MINUTE);

		// Launch Time Picker Dialog
		TimePickerDialog tpd = new TimePickerDialog(this,
				new TimePickerDialog.OnTimeSetListener() {

					public void onTimeSet(TimePicker view, int hourOfDay,
							int minute) {
						// TODO Auto-generated method stub

						// String am_pm="";
						// t4.setText(""+hourOfDay);

						time_select.setText(hourOfDay + ":" + minute);

					}

				}, mHour, mMinute, true);

		tpd.show();
	}

	public void id_generater() {
		text_speech_select = (Spinner) findViewById(R.id.sound);
		custome_text_speech_alerm = (EditText) findViewById(R.id.custome_text);
		type_alerm = (RadioGroup) findViewById(R.id.type);
		time_select = (Button) findViewById(R.id.time_selecter);
		save_alerm = (Button) findViewById(R.id.save_alerm);
		date_set = (Button) findViewById(R.id.date_setting);
		test_speech = (Button) findViewById(R.id.speech_text);
		bck = (ImageView) findViewById(R.id.left_bt);

	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.text_speech, menu);
		return true;
	}

	public void savertAlerm_Setting() {
		sqldb.execSQL("insert into alerm_setting values('" + selected_txt
				+ "','" + custome_text_speech_alerm.getText().toString()
				+ "','" + date_set.getText().toString() + "','"
				+ time_select.getText().toString() + "','" + radioType + "')");
		Toast.makeText(getApplicationContext(), "Alerm Set succussfully", 1000)
				.show();
	}
	
	

}
