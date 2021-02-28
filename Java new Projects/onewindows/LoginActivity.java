package com.app.onewindows;

import org.json.JSONArray;
import org.json.JSONObject;

import com.app.onewindows.R;
import com.app.onewindows.SignupUserActivity.SendSMS;
import com.app.onewindows.SignupUserActivity.SignupAsync;
import com.app.onewindows.SignupUserActivity.Vendorinfo;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.Intent;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.PopupMenu;
import android.widget.TextView;
import android.widget.Toast;

public class LoginActivity extends Activity {
Button logn;
ImageView menubtn;
String mobileno;
EditText iduser;
String user;
MyApp obj;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.login);
		
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		regtxt.setText("Login");
		obj=(MyApp)getApplicationContext();
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg);
		
		regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				finish();
			}
		});
		Button onj=(Button)findViewById(R.id.logn);
		onj.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				
				// TODO Auto-generated method stub
//				new SignupAsync(iduser.getText().toString()).execute();
			}
		});
		
		TextView msg=(TextView)findViewById(R.id.msg);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		msg.setTypeface(myTypeface3);
		
		
		logn=(Button)findViewById(R.id.logn);
		Typeface reg2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		logn.setTypeface(reg2);
		logn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				iduser=(EditText)findViewById(R.id.iduser);
				mobileno=iduser.getText().toString();
				new SignupAsync(iduser.getText().toString()).execute();
				
			}
		});
		
		
		
		menubtn = (ImageView) findViewById(R.id.menuopt);  
		menubtn.setOnClickListener(new OnClickListener() {  
		 
		 @SuppressLint("NewApi")
		@Override  
		 public void onClick(View v) {  
		  //Creating the instance of PopupMenu  
		  PopupMenu popup = new PopupMenu(LoginActivity.this, menubtn);  
		  //Inflating the Popup using xml file  
		  popup.getMenuInflater().inflate(R.menu.homemenu, popup.getMenu());  
		 
		  //registering popup with OnMenuItemClickListener  
		  popup.setOnMenuItemClickListener(new PopupMenu.OnMenuItemClickListener() {  
		   public boolean onMenuItemClick(MenuItem item) { 
			   
			   if(item.getTitle().equals("Login"))
			   {
				   
			   }
			   else if(item.getTitle().equals("About"))
			   {
				   Intent home=new Intent(LoginActivity.this, About.class);
					startActivity(home);
			   }
			   else if(item.getTitle().equals("Our Mission"))
			   {
				   Intent mission=new Intent(LoginActivity.this, MissonActivity.class);
				   startActivity(mission);
			   }
			   
			   else if (item.getTitle().equals("Feedback")) {
					Intent fd=new Intent(LoginActivity.this, Feedback.class);
					   startActivity(fd);
				}
			   else if(item.getTitle().equals("Call OneWindow"))
			   {
				   
			   }
			   else if(item.getTitle().equals("Share OneWindow"))
			   {
				   shareTextUrl();
			   }
			   
		    Toast.makeText(LoginActivity.this,"You Clicked : " + item.getTitle(),Toast.LENGTH_SHORT).show();  
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
	
	
	
	class SignupAsync extends AsyncTask<String, String, String>
	{
		String loginurl;
		SignupAsync(String u)
		{
			loginurl=u;
		}
		String url;
		String res;
		ProgressDialog pd;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(LoginActivity.this);
	pd.setTitle("Please wait...");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			try{
				//http://1window.globalscope.in/onewindowapi/bookingappointment.php?cat=homeservice&subcat=plumber&dt12/1/2016&tm=2:00&othertm=56&landmark=atm&des=hi&cname=noirbhayyy&cmail=nn@hmail&ccontact=62388884&loca=delhi&address=noida&houseno=12&pin=276738
			//url=MyApp.signupurl+"onewindowapi/bookingappointment.php?cat="+obj.getCatagorieName()+"&subcat="+obj.getSubCatgorieName()+"&dt="+obj.getDt()+"&tm="+obj.getTm()+"&othertm="+obj.getOthertm()+"&landmark="+obj.getLandmark()+"&des="+obj.getDes()+"&cname="+""+"&cmail="+""+"&ccontact="+mob.getText().toString()+"&loca="+obj.getAddress()+"&houseno="+obj.getHouseno()+"&pin="+obj.getPinno()+"";
			String url=obj.getLoginapi();
			String parm=url+"mob="+loginurl+"";
			res=CustomHttpClient.urlincoding(parm);
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
			
			return res;
		}
		@Override
				protected void onPostExecute(String result) {
			pd.dismiss();
			try{
				JSONObject jsonobj=new JSONObject(result);
				String success=jsonobj.getString("success");
				if(success.equals("1"))
				{
				Toast.makeText(LoginActivity.this, "Succesfully", 1000).show();
				//otpHttp();
				new Vendorinfo().execute();
				
			}
				else
				{
					Toast.makeText(LoginActivity.this, ""+success, 1000).show();
				}
				
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
			
				}
		
	}
	
	
	
	class LoginRegister extends AsyncTask<String, String, String>
	{
		String url;
		String res;
		ProgressDialog pd;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(LoginActivity.this);
	pd.setTitle("Please wait...");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			try{
				//http://1window.globalscope.in/onewindowapi/bookingappointment.php?cat=homeservice&subcat=plumber&dt12/1/2016&tm=2:00&othertm=56&landmark=atm&des=hi&cname=noirbhayyy&cmail=nn@hmail&ccontact=62388884&loca=delhi&address=noida&houseno=12&pin=276738
			url=MyApp.signupurl+"onewindowapi/bookingappointment.php?cat="+obj.getCatagorieName()+"&subcat="+obj.getSubCatgorieName()+"&dt="+obj.getDt()+"&tm="+obj.getTm()+"&othertm="+obj.getOthertm()+"&landmark="+obj.getLandmark()+"&des="+obj.getDes()+"&cname="+""+"&cmail="+""+"&ccontact="+mobileno+"&loca="+obj.getAddress()+"&houseno="+obj.getHouseno()+"&pin="+obj.getPinno()+"";
			//http://1window.globalscope.in/onewindowapi/mail.php?name=onewindow&email=nirbhayiise@gmail.com&to=nirbhayiise@gmail.com&phone=8285672453&message=hi%20onewindow&Subject=test
			res=CustomHttpClient.urlincoding(url);
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
			
			return res;
		}
		@Override
				protected void onPostExecute(String result) {
			pd.dismiss();
			try{
				JSONObject jsonobj=new JSONObject(result);
				String success=jsonobj.getString("success");
				if(!success.equals("User Already Exist"))
				{
				Toast.makeText(LoginActivity.this, "Succesfully", 1000).show();
				//otpHttp();
			}
				else
				{
					Toast.makeText(LoginActivity.this, ""+success, 1000).show();
				}
				
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
			
				}
		
	}
	public void otpHttp()
	{
		final Dialog otp=new Dialog(LoginActivity.this);
		otp.setContentView(R.layout.thank);
		TextView regtxtpopup=(TextView)otp.findViewById(R.id.regtxtpopup);
		regtxtpopup.setText("Thanks");
		
		otp.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
		 
		Button otpbtn=(Button)otp.findViewById(R.id.tnaks);
		
		final EditText otptxt=(EditText)otp.findViewById(R.id.otptxt);
		  



		otpbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				
				
		        otp.dismiss();
//		        Intent home=new Intent(SignupUserActivity.this, HomeActivity.class);
//		        startActivity(home);
//		        finish();
		       
				
			}
		});

		
		
		//new SignupAsync().execute();
		otp.show();
		
		
	}
	class Vendorinfo extends AsyncTask<String, String, String>
	{
		ProgressDialog pd;
		String resp;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(LoginActivity.this);
	pd.setTitle(" Sending request to Vendor");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			
			String url=obj.getVendorContacts();
			String parm=url+"service="+obj.getSubCatgorieName()+"&pin="+obj.getPinno()+"";
			try {
				resp=CustomHttpClient.executeHttpGet(parm);
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			return resp;
		}
		@Override
				protected void onPostExecute(String result) {
				try {
					pd.dismiss();
					
					String sb=result.substring(0, result.length()-4);
					String resp=sb+"]}";
					JSONObject jobj=new JSONObject(resp);
					JSONArray jArr=jobj.getJSONArray("vendor");
					for(int i=0;i<jArr.length();i++)
					{
						String vendarAd="Address:"+obj.getAddress()+",landmark:"+obj.getLandmark()+",mobile:"+iduser.getText().toString()+",houseNo:"+obj.getHouseno()+",Service"+obj.getSubCatgorieName();
						//ActiveRequestedModel itm=new ActiveRequestedModel();
						JSONObject c = jArr.getJSONObject(i);
						String catnaem=jArr.getJSONObject(i).getString("mail");
						
						String cont=jArr.getJSONObject(i).getString("contacts");
						new SendSMS(cont,vendarAd).execute();
						new MailSend(catnaem).execute();
//						nameLs.add(catnaem);
//						contacts.add(cont);
//						
					}
//					obj.setCatIdLs(catIdLs);
//					VendorAdapter adapter1 = new VendorAdapter(SignupUserActivity.this, 
//							nameLs);
//					servicesls.setAdapter(adapter1);
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				}
	}
	
	
	
	
	
	
	class SendSMS extends AsyncTask<String, String, String>
	{
		String url;
		String res;
		String no;
		String otpmsg;
		ProgressDialog pd;
		SendSMS(String n,String m)
		{
			no=n;
			otpmsg=m;
		}
		@Override
				protected void onPreExecute() {
					pd=new ProgressDialog(LoginActivity.this);
					pd.setTitle("Please wait...");
					pd.show();
				}

		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			url="http://www.bulksmsapps.com/apisms.aspx?user=DELINF&password=WGRS5&genkey=805307791&sender=SMSAPP&number="+no+"&message="+otpmsg+" ";
			
		//String url2="http://1window.globalscope.in/onewindowapi/mail.php?name=onewindow&email=nirbhayiise@gmail.com&to=nirbhayiise@gmail.com&phone=8285672453&message=hi%20onewindow&Subject=test";
			
			res=CustomHttpClient.urlincoding(url);
			
		
			return res;
		}
		@Override
		protected void onPostExecute(String result) {
			pd.dismiss();
			
			otpHttp();
			
			
			
			//new SignupAsync().execute();
			
			
			
		
			
		}
		
	}
	
	class MailSend extends AsyncTask<String, String, String>
	{
		String url;
		String res;
		String no;
		String Mail;
		ProgressDialog pd;
		MailSend(String mailID)
		{
			Mail=mailID;
			
		}
		@Override
				protected void onPreExecute() {
					pd=new ProgressDialog(LoginActivity.this);
					pd.setTitle("Please wait...");
					pd.show();
				}

		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			//url="http://www.bulksmsapps.com/apisms.aspx?user=DELINF&password=WGRS5&genkey=805307791&sender=SMSAPP&number="+no+"&message="+otpmsg+" ";
			
		 url="http://1window.globalscope.in/onewindowapi/mail.php?name=onewindowCustomer&email=nirbhayiise@gmail.com&to="+Mail+"&phone="+mobileno+"&message=Hi i need "+obj.getSubCatgorieName()+" "+" for Location"+obj.getLocaOrder()+" Near By "+obj.getLandmark()+" "+"my Address is "+obj.getAddress()+" &Subject=Requrest for "+obj.getSubCatgorieName()+" service";
			
			res=CustomHttpClient.urlincoding(url);
			
		
			return res;
		}
		@Override
		protected void onPostExecute(String result) {
			pd.dismiss();
			
			otpHttp();
			
			
			
			//new SignupAsync().execute();
			
			
			
		
			
		}
		
	}
	
	
	
	
}
