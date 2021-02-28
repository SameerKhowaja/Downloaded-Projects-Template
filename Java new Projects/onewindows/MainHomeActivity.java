package com.app.onewindows;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;

import org.json.JSONArray;
import org.json.JSONObject;

import com.app.onewindows.R;
import com.app.onewindows.adapters.AllAdapterSubCat;
import com.app.onewindows.adapters.VendorAdapter;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.TimePicker;

public class MainHomeActivity extends Activity {

	
	String selectedDes;
	TextView regtxt;
	ArrayList<String>nameLs=new ArrayList<String>();
	ArrayList<String>subcatdes=new ArrayList<String>();
	ArrayList<String>catIdLs=new ArrayList<String>();
	ListView subls;
String catSelected;
String CurrectArr[];
	ArrayList<String>namOfsub=new ArrayList<String>();
	int index;
	ArrayList<Integer>imgnamOfsub;
	int ArrImage[];
	MyApp obj;
	//int[] ArrImage = new int[10];
	String str[]={"dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs","dfs"};
	@SuppressLint("NewApi")
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.main_home);
		ImageView menuopt=(ImageView)findViewById(R.id.menuopt);
		menuopt.setVisibility(View.GONE);
		
		subls=(ListView)findViewById(R.id.subls);
		obj=(MyApp)getApplicationContext();
		
		
		
		namOfsub=obj.getSubCatname();
		 ArrImage=obj.getArrImgName();
		 CurrectArr=obj.getSelectedArry();
		 
		/*AllAdapterSubCat adapter1=new AllAdapterSubCat(MainHomeActivity.this,ArrImage,str,namOfsub);
		subls.setAdapter(adapter1);*/
		 
		 Intent i = getIntent();
		//The second parameter below is the default string returned if the value is not there. 
		String subId = i.getExtras().getString("id","");
		new SubCatagory(subId).execute();
		 
		subls.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int pos,
					long arg3) {
				
				obj.setSubCatgorieName(nameLs.get(pos));
				
				//obj.setSubCatDes(subcatdes.get(pos));
				//int sele=subcatdes.size();
//				if(sele>pos)
//				{
//				selectedDes=subcatdes.get(pos);
//				}
//				else{
//					selectedDes="No Descripation for this service";
//				}
				//getstarted();
				helpPopup();
				
				
				/*
				
				
				
				
				
				
				index=obj.getCatIndex();
			        String monthString;
			        switch (index) {
			            case 0: 
			            	
			            	

				    		if(CurrectArr[0].toString().equals("AC Repair"))
							{
								
								
								oppup();
								obj.setSubCatName(namOfsub.get(pos));
								
								
							}
							else if(CurrectArr[1].toString().equals("Apple Product"))
							{
								oppup1("Which device need to repair","iPhone","iPad","Mcbookpro","iPhone6s");
								obj.setSubCatName(namOfsub.get(pos));
								
							}
							else if(CurrectArr[2].toString().equals("Architect"))
							{
								
								
								obj.setSubCatName(namOfsub.get(pos));
								
							}
							else if(CurrectArr[3].toString().equals("Baby and kids Photographer"))
							{
								obj.setSubCatName(namOfsub.get(pos));
							}
							else if(CurrectArr[4].toString().equals("Bartender"))
							{
								
								obj.setSubCatName(namOfsub.get(pos));
								
							}
							else if(CurrectArr[5].toString().equals("Bathroom cleaning"))
							{
								oppup2("How many bothrooms need to cleaning?","1(Rs300)","2 (Rs 200)","3(Rs 430)","4 (Rs 500)");
								obj.setSubCatName(namOfsub.get(pos));
							}
							else if(CurrectArr[6].toString().equals("Birthday Party Cateres"))
							{
								birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[7].toString().equals("Birthday Party Decorator"))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[8].toString().equals("Birthday Party Planner"))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[9].toString().equals("Birthday Party Planner"))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[10].toString().equals("Bollywood Dance Classes"))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[11].toString().equals("AC Repair"))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							else if(CurrectArr[12].toString().equals(" "))
							{
								//birthdaypartypopu("How many People Here?","50-80","100-200");
							}
							
			            	
			                     break;
			            case 1:  
			            	
			            	
			            	
			                     break;
			            case 2: 
			            	
			            	
			            	
			                     break;
			            case 3:  
			            	
			            	
			            	
			                     break;
			            case 4:  
			            	
			            	
			            	
			                     break;
			            case 5:  
			            	
			            	
			            	
			                     break;
			            case 6:  
			            	
			            	
			            	
			                     break;
			            case 7:  
			            	
			            	
	                             break;
			            case 8:  
			            	
			            	
			            	
	                            break;
			        }
				
				
				
				catSelected=obj.getCatName();
			       if(catSelected.equals("All Services"))
			       {
			    		if(pos==0)
						{
							
							
							oppup();
							obj.setSubCatName(namOfsub.get(pos));
							
							
						}
						else if(pos==1)
						{
							oppup1("Which device need to repair","iPhone","iPad","Mcbookpro","iPhone6s");
							obj.setSubCatName(namOfsub.get(pos));
							
						}
						else if(pos==2)
						{
							
							
							obj.setSubCatName(namOfsub.get(pos));
							
						}
						else if(pos==3)
						{
							obj.setSubCatName(namOfsub.get(pos));
						}
						else if(pos==4)
						{
							
							obj.setSubCatName(namOfsub.get(pos));
							
						}
						else if(pos==5)
						{
							oppup2("How many bothrooms need to cleaning?","1(Rs300)","2 (Rs 200)","3(Rs 430)","4 (Rs 500)");
							obj.setSubCatName(namOfsub.get(pos));
						}
						else if(pos==6)
						{
							birthdaypartypopu("How many People Here?","50-80","100-200");
						}
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
			       else if(catSelected.equals(""))
			       {
			    	   
			       }
				
				
				// TODO Auto-generated method stub
			
			*/}
		});
		TextView regtxt=(TextView)findViewById(R.id.regtxt);
		regtxt.setText(obj.getHeadretitlename());
		TextView regtxt1=(TextView)findViewById(R.id.regtxt1);
		regtxt1.setText(obj.getLocaOrder());
		
		
		Typeface reg1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt.setTypeface(reg1);
		
		Typeface reg2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt1.setTypeface(reg2);
		
           regtxt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
			MainHomeActivity.this.finish();
			}
		});
           
           
          /* subls.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				// TODO Auto-generated method stub
				oppup();
			}
		});*/
		
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
	
	public void oppup()
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		r3.setVisibility(View.GONE);
		r4.setVisibility(View.GONE);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
/*		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent signup=new Intent(MainHomeActivity.this, SignupActivity.class);
				startActivity(signup);
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	public void oppup1(String q1,String q11,String q22,String q33,String q44)
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		q.setText(q1);
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		
		
		r1.setText(q11);
		r2.setText(q22);
		r3.setText(q33);
		r4.setText(q44);
		
		
		
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		/*Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stubthis
				oppup4("Software related Problen?","OS installation","Updated New feature","App related Problm","All this");
				
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	public void oppup2(String q2,String q11,String q22,String q33,String q44)
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		q.setText(q2);
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		
		r1.setText(q11);
		r2.setText(q22);
		r3.setText(q33);
		r4.setText(q44);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		/*Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				Intent signup=new Intent(MainHomeActivity.this, SignupActivity.class);
				startActivity(signup);
				
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	
	public void oppup4(String q2,String q11,String q22,String q33,String q44)
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		q.setText(q2);
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		
		r1.setText(q11);
		r2.setText(q22);
		r3.setText(q33);
		r4.setText(q44);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		/*Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				oppup5("Hardware related Problen?","Power Supply","Body repair","Not Sure");
				Intent signup=new Intent(MainHomeActivity.this, SignupActivity.class);
				startActivity(signup);
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	
	public void oppup5(String q2,String q11,String q22,String q33)
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		q.setText(q2);
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		r4.setVisibility(View.GONE);
		r1.setText(q11);
		r2.setText(q22);
		r3.setText(q33);
		//r4.setText(q44);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		/*Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent signup=new Intent(MainHomeActivity.this, SignupActivity.class);
				startActivity(signup);
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	
	
	public void birthdaypartypopu(String q2,String q11,String q22)
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.popup);
		pop.setCancelable(false);
		
		//
		
		Button next=(Button)pop.findViewById(R.id.next);
		TextView q=(TextView)pop.findViewById(R.id.q1);
		q.setText(q2);
		RadioButton r1=(RadioButton)pop.findViewById(R.id.opt1);
		RadioButton r2=(RadioButton)pop.findViewById(R.id.opt2);
		RadioButton r3=(RadioButton)pop.findViewById(R.id.opt3);
		RadioButton r4=(RadioButton)pop.findViewById(R.id.opt4);
		r4.setVisibility(View.GONE);
		r3.setVisibility(View.GONE);
		r1.setText(q11);
		r2.setText(q22);
		//r3.setText(q33);
		//r4.setText(q44);
		
		Typeface myTypeface3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		q.setTypeface(myTypeface3);
		
		Typeface rd1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r1.setTypeface(myTypeface3);
		
		Typeface rd2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r2.setTypeface(myTypeface3);
		
		Typeface rd3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r3.setTypeface(myTypeface3);
		
		
		Typeface rd4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r4.setTypeface(myTypeface3);
		
		/*Typeface rd5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		r5.setTypeface(myTypeface3);*/
		
		
		next.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent signup=new Intent(MainHomeActivity.this, SignupActivity.class);
				startActivity(signup);
				pop.dismiss();
			}
		});
		pop.show();
	}
	
	
	
	class SubCatagory extends AsyncTask<String, String, String>
	{
		ProgressDialog pd;
		String resp;
		String cd;
		SubCatagory(String cid)
		{
			cd=cid;
		}
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(MainHomeActivity.this);
	pd.setTitle("Please wait");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			
			String url=obj.getSubcatService();
			String parm=url+"catid="+cd+"&status=Active";
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
					
					ArrayList<String>catIdLs=new ArrayList<String>();
					ArrayList<String>catDesLs=new ArrayList<String>();
					ArrayList<String>imgLs=new ArrayList<String>();
					String sb=result.substring(0, result.length()-4);
					String resp=sb+"]}";
					JSONObject jobj=new JSONObject(resp);
					JSONArray jArr=jobj.getJSONArray("vendor");
					for(int i=0;i<jArr.length();i++)
					{
						//ActiveRequestedModel itm=new ActiveRequestedModel();
						JSONObject c = jArr.getJSONObject(i);
						String catnaem=jArr.getJSONObject(i).getString("cat_name");
						String ca_id=jArr.getJSONObject(i).getString("cat_id");
						String catDes=jArr.getJSONObject(i).getString("des");
						String img=jArr.getJSONObject(i).getString("img");
						nameLs.add(catnaem);
					}
					 AllAdapterSubCat adapter1=new AllAdapterSubCat(MainHomeActivity.this,nameLs);
						subls.setAdapter(adapter1);
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				}
	}


	
	
	/*public void getstarted()
	{
		final Dialog pop1=new Dialog(MainHomeActivity.this);
		pop1.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop1.setContentView(R.layout.getstratedpopup);
		pop1.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
		TextView regtxtpopup=(TextView)pop1.findViewById(R.id.regtxtpopup);
		regtxtpopup.setText("Let's get started?");
		
		Typeface popuhr = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxtpopup.setTypeface(popuhr);
		
		
		Button nextbtn=(Button)pop1.findViewById(R.id.nextbtn);
		Typeface bakbtn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		nextbtn.setTypeface(bakbtn);
		
		
		nextbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				helpPopup();
				pop1.dismiss();
			}
		});
		
		pop1.show();
	}
	
	*/
	
	public void helpPopup()
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.helppopup);
		pop.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
		Button nextbtn=(Button)pop.findViewById(R.id.nextbtn1);
		Button backbtn=(Button)pop.findViewById(R.id.backbtn);
		
		TextView l1=(TextView)pop.findViewById(R.id.l1);
		TextView l2=(TextView)pop.findViewById(R.id.l2);
		TextView l3=(TextView)pop.findViewById(R.id.l3);
		TextView l4=(TextView)pop.findViewById(R.id.l4);
		TextView l5=(TextView)pop.findViewById(R.id.l5);
		TextView l6=(TextView)pop.findViewById(R.id.l6);
		TextView l7=(TextView)pop.findViewById(R.id.l7);
		TextView l8=(TextView)pop.findViewById(R.id.l8);
		TextView l10=(TextView)pop.findViewById(R.id.l10);
		TextView l11=(TextView)pop.findViewById(R.id.l11);
		TextView l12=(TextView)pop.findViewById(R.id.l12);
		
		l2.setText(selectedDes);
		
		Typeface bakbtn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		backbtn.setTypeface(bakbtn);
		
		
		
		Typeface lbl1 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l1.setTypeface(lbl1);
		Typeface lbl2 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l2.setTypeface(lbl2);
		Typeface lbl3 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l3.setTypeface(lbl3);
		Typeface lbl4 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l4.setTypeface(lbl4);
		Typeface lbl5 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l5.setTypeface(lbl5);
		Typeface lbl6 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l6.setTypeface(lbl6);
		Typeface lbl7 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l7.setTypeface(lbl7);
		Typeface lbl8 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l8.setTypeface(lbl8);
		Typeface lbl10 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l10.setTypeface(lbl10);
		Typeface lbl11 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l11.setTypeface(lbl11);
		
		Typeface lbl12 = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		l12.setTypeface(lbl12);
		
		
		Typeface nxt = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		nextbtn.setTypeface(nxt);
		
		
		TextView regtxtpopup=(TextView)pop.findViewById(R.id.regtxtpopup);
		regtxtpopup.setText("What do you need help with?");
		
		Typeface popuhr = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxtpopup.setTypeface(popuhr);
		
	
		nextbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Servicepopup();
				
				pop.dismiss();
			}
		});
backbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				//getstarted();
				//helpPopup();
				pop.dismiss();
			}
		});
		
		pop.show();
	}
	
	
	
	
	public void Servicepopup()
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.dateforservicepopup);
		pop.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
		TextView regtxtpopup=(TextView)pop.findViewById(R.id.regtxtpopup);
		final EditText setdt=(EditText)pop.findViewById(R.id.setdt);
		final EditText settm=(EditText)pop.findViewById(R.id.settm);
		final EditText othr=(EditText)pop.findViewById(R.id.othr);
		
		
		
		
		
		setdt.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				int mYear,mMonth,mDay;
				 // Process to get Current Date
		        final Calendar c = Calendar.getInstance();
		        mYear = c.get(Calendar.YEAR);
		        mMonth = c.get(Calendar.MONTH);
		        mDay = c.get(Calendar.DAY_OF_MONTH);

		        // Launch Date Picker Dialog
		        DatePickerDialog dpd = new DatePickerDialog(MainHomeActivity.this,
		                new DatePickerDialog.OnDateSetListener() {

		                    @Override
		                    public void onDateSet(DatePicker view, int year,
		                            int monthOfYear, int dayOfMonth) {
		                        // Display Selected date in textbox
		                        setdt.setText(dayOfMonth + "/"
		                                + (monthOfYear + 1) + "/" + year);

		                    }
		                }, mYear, mMonth, mDay);
		        dpd.show();
			}
		});
		
		
settm.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				int mHour,mMinute;

				 // Process to get Current Time
		        final Calendar c = Calendar.getInstance();
		        mHour = c.get(Calendar.HOUR_OF_DAY);
		        mMinute = c.get(Calendar.MINUTE);

		        // Launch Time Picker Dialog
		        TimePickerDialog tpd = new TimePickerDialog(MainHomeActivity.this,
		                new TimePickerDialog.OnTimeSetListener() {

		                    @Override
		                    public void onTimeSet(TimePicker view, int hourOfDay,
		                            int minute) {
		                        // Display Selected time in textbox
		                        settm.setText(hourOfDay + ":" + minute);
		                    }
		                }, mHour, mMinute, false);
		        tpd.show();
				
			}
		});
		
		regtxtpopup.setText("When do you need the services?");
		
		Typeface popuhr = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxtpopup.setTypeface(popuhr);
		
		Button nextbtn=(Button)pop.findViewById(R.id.nextbtn2);
		Button btnback=(Button)pop.findViewById(R.id.backbtn);
		
		TextView tm=(TextView)pop.findViewById(R.id.tm);
		TextView dt=(TextView)pop.findViewById(R.id.dt);
		TextView oth=(TextView)pop.findViewById(R.id.other);
		

		Typeface tmfont = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		tm.setTypeface(tmfont);
		
		Typeface dtfont = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		dt.setTypeface(dtfont);
		Typeface othont = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		oth.setTypeface(othont);
		
		
		Typeface bakbtn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		btnback.setTypeface(bakbtn);
		
		Typeface nxt = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		nextbtn.setTypeface(nxt);
		
		btnback.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				helpPopup();
				pop.dismiss();
			}
		});
		nextbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				if(settm.getText().toString().equalsIgnoreCase(""))
				{
					settm.setError("Mandatory fields");
				}
				else if(setdt.getText().toString().equalsIgnoreCase(""))
				{
					setdt.setError("Mandatory fields");
				}
				
				else{
					

					obj.setDt(setdt.getText().toString());
					obj.setTm(settm.getText().toString());
					obj.setOthertm(othr.getText().toString());
					locationPopup();
					pop.dismiss();
				
				}
				
				
				
			}
		});
		
		pop.show();
	}
	
	
	public void locationPopup()
	{
		final Dialog pop=new Dialog(MainHomeActivity.this);
		pop.requestWindowFeature(Window.FEATURE_NO_TITLE);
		pop.setContentView(R.layout.locationdetailspopup);
		pop.getWindow().setBackgroundDrawable(new ColorDrawable(android.graphics.Color.TRANSPARENT));
		TextView regtxtpopup=(TextView)pop.findViewById(R.id.regtxtpopup);
		final EditText pst=(EditText)pop.findViewById(R.id.post);
		final EditText land=(EditText)pop.findViewById(R.id.land);
		final EditText ad=(EditText)pop.findViewById(R.id.address);
		final EditText house=(EditText)pop.findViewById(R.id.houseno);
		final EditText des=(EditText)pop.findViewById(R.id.des);
		pst.setText(obj.getPinno());
		ad.setText(obj.getLocaOrder());
		regtxtpopup.setText("Where are you located?");
		
		Typeface popuhr = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxtpopup.setTypeface(popuhr);
		
		Button nextbtn=(Button)pop.findViewById(R.id.nextbtn3);
		Button backbtn=(Button)pop.findViewById(R.id.backbtn);
		Typeface bakbtn = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		backbtn.setTypeface(bakbtn);
		
		Typeface nxt = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		nextbtn.setTypeface(nxt);
		
		
		backbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Servicepopup();
				pop.dismiss();
			}
		});
		nextbtn.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				
				if(pst.getText().toString().equalsIgnoreCase(""))
				{
					pst.setError("Mandatory fields");
				}
				else if(land.getText().toString().equalsIgnoreCase(""))
				{
					land.setError("Mandatory fields");
				}
				else if(ad.getText().toString().equalsIgnoreCase(""))
				{
					ad.setError("Mandatory fields");
				}
				else if(house.getText().toString().equalsIgnoreCase(""))
				{
					house.setError("Mandatory fields");
				}
				else
				{
					obj.setPostcode(pst.getText().toString());
					obj.setLandmark(land.getText().toString());
					obj.setAddress(ad.getText().toString());
					obj.setHouseno(house.getText().toString());
					obj.setDes(des.getText().toString());
					Intent signupActivity=new Intent(MainHomeActivity.this, SignupActivity.class);
					startActivity(signupActivity);
					pop.dismiss();
				}
				
				
				
				
				
				
			}
		});
		
		pop.show();
	}
	
	class Catagory extends AsyncTask<String, String, String>
	{
		ProgressDialog pd;
		String resp;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(MainHomeActivity.this);
	pd.setTitle("Please wait");
	pd.show();
}
		@Override
		protected String doInBackground(String... params) {
			// TODO Auto-generated method stub
			
			String url=obj.getCatService();
			String parm=url+"status=Active";
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
						//ActiveRequestedModel itm=new ActiveRequestedModel();
						JSONObject c = jArr.getJSONObject(i);
						String catnaem=jArr.getJSONObject(i).getString("cat_name");
						String ca_id=jArr.getJSONObject(i).getString("cat_id");
						String catDes=jArr.getJSONObject(i).getString("des");
						String img=jArr.getJSONObject(i).getString("img");
						nameLs.add(catnaem);
						catIdLs.add(ca_id);
						if(!catDes.equalsIgnoreCase(" "))
						{
							subcatdes.add(catDes);
						}
						
					}
					obj.setCatIdLs(catIdLs);
					obj.setSubcatdes(subcatdes);
//					VendorAdapter adapter1 = new VendorAdapter(MainHomeActivity.this, 
//							nameLs);
//					servicesls.setAdapter(adapter1);
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				}
	}
	
	
}
