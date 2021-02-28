package com.example.alermservice;

import android.os.Bundle;
import android.app.Activity;
import android.speech.tts.TextToSpeech;
import android.speech.tts.TextToSpeech.OnInitListener;
import android.view.Menu;

public class Speak extends Activity implements OnInitListener {
	TextToSpeech myTTS;
	String str;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_speak);
		myTTS = new TextToSpeech(this, this);
		Bundle b=this.getIntent().getExtras();
		str=b.getString("txt");
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.speak, menu);
		return true;
	}

	@Override
	public void onInit(int arg0) {
		// TODO Auto-generated method stub
		
	       myTTS.speak(str, TextToSpeech.QUEUE_FLUSH, null);
	       myTTS.speak(str, TextToSpeech.QUEUE_ADD, null);
	       myTTS.speak(str, TextToSpeech.LANG_COUNTRY_VAR_AVAILABLE, null);
	       
	       
	}

}
