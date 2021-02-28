package com.app.onewindows;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;

import org.json.JSONArray;
import org.json.JSONObject;

import com.app.onewindows.R;
import com.app.onewindows.adapters.VendorAdapter;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.Intent;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Environment;
import android.os.Handler;
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

public class SignupUserActivity extends Activity {

	
	ArrayList<String>nameLs=new ArrayList<String>();
	ArrayList<String>contacts=new ArrayList<String>();
	ArrayList<String>catIdLs=new ArrayList<String>();
	ArrayList<String>catDesLs=new ArrayList<String>();
	ArrayList<String>imgLs=new ArrayList<String>();
	ArrayList<String> ArrLs = new ArrayList<String>();
	ArrayList<String> ArrLslocaty = new ArrayList<String>();
	private TextView lognbtn;
	TextView details;
	String conts;
	ImageView menubtn;
	String otpstr="7845";
	Button signup_btn;
	String rendomOtp;
	MyApp obj;
	EditText name,mob,mail;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.signup1);
		
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		regtxt.setText("Sign Up");
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg);
		Calendar cal = Calendar.getInstance();
		otpstr="one window "+cal.getTimeInMillis();
		name=(EditText)findViewById(R.id.name);
		mob=(EditText)findViewById(R.id.mobileno);
		mail=(EditText)findViewById(R.id.mail);
		obj=(MyApp)getApplicationContext();
		signup_btn=(Button)findViewById(R.id.signup_btn);
		Typeface btn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		signup_btn.setTypeface(btn);
		signup_btn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				conts=mob.getText().toString();
				
				rendomOtp=rendo();
				//new Vendorinfo().execute();
				new OTP(mob.getText().toString(),rendomOtp).execute();
				
				
				
			}
		});
           regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				finish();
			}
		});
		/*lognbtn=(TextView)findViewById(R.id.lognbtn);
		
		lognbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				 
			}
		});*/
		
		details=(TextView)findViewById(R.id.details);
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		details.setTypeface(myTypeface3);
		
		

menubtn = (ImageView) findViewById(R.id.menuopt);  
menubtn.setOnClickListener(new OnClickListener() {  
 
 @SuppressLint("NewApi")
@Override  
 public void onClick(View v) {  
	  //Creating the instance of PopupMenu  
	  PopupMenu popup = new PopupMenu(SignupUserActivity.this, menubtn);  
	  //Inflating the Popup using xml file  
	  popup.getMenuInflater().inflate(R.menu.homemenu, popup.getMenu());  
	 
	  //registering popup with OnMenuItemClickListener  
	  popup.setOnMenuItemClickListener(new PopupMenu.OnMenuItemClickListener() {  
	   public boolean onMenuItemClick(MenuItem item) { 
		   
		   if(item.getTitle().equals("Login"))
		   {
			   Intent home=new Intent(SignupUserActivity.this, LoginActivity.class);
					startActivity(home);
		   }
		   else if(item.getTitle().equals("About"))
		   {
			   Intent home=new Intent(SignupUserActivity.this, About.class);
				startActivity(home);
		   }
		   else if(item.getTitle().equals("Our Mission"))
		   {
			   Intent mission=new Intent(SignupUserActivity.this, MissonActivity.class);
			   startActivity(mission);
		   }
		   
		   else if (item.getTitle().equals("Feedback")) {
				Intent fd=new Intent(SignupUserActivity.this, Feedback.class);
				   startActivity(fd);
			}
		   
		   else if(item.getTitle().equals("Call OneWindow"))
		   {
			   
		   }
		   else if(item.getTitle().equals("Share OneWindow"))
		   {
			   shareTextUrl();
		   }
		   
	    Toast.makeText(SignupUserActivity.this,"You Clicked : " + item.getTitle(),Toast.LENGTH_SHORT).show();  
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
		String url;
		String res;
		ProgressDialog pd;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(SignupUserActivity.this);
	pd.setTitle("Please wait...");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			try{
				//http://1window.globalscope.in/onewindowapi/bookingappointment.php?cat=homeservice&subcat=plumber&dt12/1/2016&tm=2:00&othertm=56&landmark=atm&des=hi&cname=noirbhayyy&cmail=nn@hmail&ccontact=62388884&loca=delhi&address=noida&houseno=12&pin=276738
			url=MyApp.signupurl+"onewindowapi/bookingappointment.php?cat="+obj.getCatagorieName()+"&subcat="+obj.getSubCatgorieName()+"&dt="+obj.getDt()+"&tm="+obj.getTm()+"&othertm="+obj.getOthertm()+"&landmark="+obj.getLandmark()+"&des="+obj.getDes()+"&cname="+name.getText().toString()+"&cmail="+mail.getText().toString()+"&ccontact="+mob.getText().toString()+"&loca="+obj.getAddress()+"&houseno="+obj.getHouseno()+"&pin="+obj.getPinno()+"";
			
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
				Toast.makeText(SignupUserActivity.this, "Succesfully", 1000).show();
				otpHttp();
			}
				else
				{
					Toast.makeText(SignupUserActivity.this, ""+success, 1000).show();
				}
				name.setText("");
				mob.setText("");
				mail.setText("");
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
			
				}
		
	}
	
	public String rendo()
	{
		int randomPIN = (int)(Math.random()*9000)+1000;
		String val = ""+randomPIN;
		return val;
	}
	
	class OTP extends AsyncTask<String, String, String>
	{
		String url;
		String res;
		String no;
		String otpmsg;
		ProgressDialog pd;
		OTP(String n,String m)
		{
			no=n;
			otpmsg=m;
		}
		@Override
				protected void onPreExecute() {
					pd=new ProgressDialog(SignupUserActivity.this);
					pd.setTitle("Please wait...");
					pd.show();
				}

		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			url="http://www.bulksmsapps.com/apisms.aspx?user=DELINF&password=WGRS5&genkey=805307791&sender=SMSAPP&number="+no+"&message=Onewindow OTP "+otpmsg+" ";
			res=CustomHttpClient.urlincoding(url);
			
		
			return res;
		}
		@Override
		protected void onPostExecute(String result) {
			pd.dismiss();
			

			final Dialog otp=new Dialog(SignupUserActivity.this);
			otp.setContentView(R.layout.otppopup);
			TextView regtxtpopup=(TextView)otp.findViewById(R.id.regtxtpopup);
			regtxtpopup.setText("OTP");
			
			otp.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
			 
			Button otpbtn=(Button)otp.findViewById(R.id.otpbtn);
			Button backbtn=(Button)otp.findViewById(R.id.generate);
			final EditText otptxt=(EditText)otp.findViewById(R.id.otptxt);
			  



			otpbtn.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
					
					if(rendomOtp.equals(otptxt.getText().toString()))
					{
						new SignupAsync().execute();
						otp.dismiss();
					}
					else{
						Toast.makeText(SignupUserActivity.this, "Exp OTP ", 1000).show();
						//otp.dismiss();
					}
					
			        
					
				}
			});
	backbtn.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
					//new OTP(mob.getText().toString(),otpstr);
					//new OTP(mob.getText().toString(), otpstr);
					otp.dismiss();
					
			        
					
				}
			});
			
			
			//new SignupAsync().execute();
			otp.show();
			
			
		
			
		}
		
	}
	
	
	public void otpHttp()
	{
		final Dialog otp=new Dialog(SignupUserActivity.this);
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
		        new Vendorinfo().execute();
				
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
	pd=new ProgressDialog(SignupUserActivity.this);
	pd.setTitle("Please wait Sending SMS to Vendor");
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
						String vendarAd="Address:"+obj.getAddress()+",landmark:"+obj.getLandmark()+",mobile:"+conts+",houseNo:"+obj.getHouseno()+",Service"+obj.getSubCatgorieName();
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
					pd=new ProgressDialog(SignupUserActivity.this);
					pd.setTitle("Please wait...");
					pd.show();
				}

		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			url="http://www.bulksmsapps.com/apisms.aspx?user=DELINF&password=WGRS5&genkey=805307791&sender=SMSAPP&number="+no+"&message="+otpmsg+" ";
			res=CustomHttpClient.urlincoding(url);
			
		
			return res;
		}
		@Override
		protected void onPostExecute(String result) {
			pd.dismiss();
			

			final Dialog otp=new Dialog(SignupUserActivity.this);
			otp.setContentView(R.layout.otppopup);
			TextView regtxtpopup=(TextView)otp.findViewById(R.id.regtxtpopup);
			regtxtpopup.setText("OTP");
			
			otp.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
			 
			Button otpbtn=(Button)otp.findViewById(R.id.otpbtn);
			Button backbtn=(Button)otp.findViewById(R.id.generate);
			final EditText otptxt=(EditText)otp.findViewById(R.id.otptxt);
			  



			otpbtn.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
					
					if(rendomOtp.equals(otptxt.getText().toString()))
					{
						new SignupAsync().execute();
						otp.dismiss();
					}
					else{
						Toast.makeText(SignupUserActivity.this, "Exp OTP ", 1000).show();
						//otp.dismiss();
					}
					
			        
					
				}
			});
	backbtn.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View arg0) {
					// TODO Auto-generated method stub
					//new OTP(mob.getText().toString(),otpstr);
					//new OTP(mob.getText().toString(), otpstr);
					otp.dismiss();
					
			        
					
				}
			});
			
			
			//new SignupAsync().execute();
			otp.show();
			
			
		
			
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
					pd=new ProgressDialog(SignupUserActivity.this);
					pd.setTitle("Please wait.sending mail..");
					pd.show();
				}

		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			//url="http://www.bulksmsapps.com/apisms.aspx?user=DELINF&password=WGRS5&genkey=805307791&sender=SMSAPP&number="+no+"&message="+otpmsg+" ";
			
		 url="http://1window.globalscope.in/onewindowapi/mail.php?name=onewindowCustomer&email=nirbhayiise@gmail.com&to="+Mail+"&phone="+mob.getText().toString()+"&message=Hi i need "+obj.getSubCatgorieName()+" "+" for Location"+obj.getLocaOrder()+" Near By "+obj.getLandmark()+" "+"my Address is "+obj.getAddress()+" &Subject=Requrest for "+obj.getSubCatgorieName()+" service";
			
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
