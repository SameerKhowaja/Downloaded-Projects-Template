package com.app.onewindows;

import com.app.onewindows.R;

import android.app.Activity;
import android.graphics.Typeface;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.widget.ImageView;
import android.widget.TextView;

public class CareerActivity extends Activity {

	TextView regtxt1;
	View underline;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.aboutus1);
		ImageView menuopt=(ImageView)findViewById(R.id.menuopt);
		menuopt.setVisibility(View.GONE);
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		regtxt.setText("Career");
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg);
regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
//				Intent home=new Intent(About.this, SignupActivity.class);
//				startActivity(home);
				CareerActivity.this.finish();
			}
		});
//		underline=(View)findViewById(R.id.underline2);
//		underline.setVisibility(View.GONE);
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
