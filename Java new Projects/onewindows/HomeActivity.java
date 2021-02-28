package com.app.onewindows;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URI;
import java.net.URL;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.ResponseHandler;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.BasicResponseHandler;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.app.onewindows.R;
import com.app.onewindows.adapters.AdapterPopulatCity;
import com.app.onewindows.adapters.AllAdapterSubCat;
import com.app.onewindows.adapters.VendorAdapter;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.graphics.Typeface;
import android.location.Location;
import android.location.LocationManager;
import android.opengl.Visibility;
import android.os.AsyncTask;
import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.text.Editable;
import android.text.TextWatcher;
import android.text.method.HideReturnsTransformationMethod;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.PopupMenu;
import android.widget.RadioButton;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class HomeActivity extends Activity {
	ArrayList<String>nameLs=new ArrayList<String>();
	ArrayList<String>catIdLs=new ArrayList<String>();
	ArrayList<String>catDesLs=new ArrayList<String>();
	ArrayList<String>imgLs=new ArrayList<String>();
	ArrayList<String> ArrLs = new ArrayList<String>();
	ArrayList<String> ArrLslocaty = new ArrayList<String>();
	AppLocationService appLocationService;
	
	ArrayList<String>CatIdList;
	String particularCatId;
	String citydata[];
	String citydata1[];
	String pol_type;
	
	ListView servicesls;
	TextView regtxt1;
	View underline;
	ImageView menubtn;
	// int
	// img[]={R.drawable.events1,R.drawable.pb,R.drawable.personalservice,R.drawable.weddingmanag,R.drawable.plumber};

	
	// Catagories Image here.
	int homeServiceIcons[]={R.drawable.plumber1,R.drawable.ac,R.drawable.carpenter,R.drawable.bothroomcleaning,R.drawable.electrician,R.drawable.pest,
			R.drawable.pest, R.drawable.sofa,R.drawable.bathroomclr, R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	//int personalservice[]={R.drawable.logo};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	//int personalservice[]={R.drawable.plumber1};
	
	
	
	
	
	
	
	
	
	
	int img[] = { R.drawable.all, R.drawable.health_and_fitness_apps,
			R.drawable.service_industry, R.drawable.guitar,
			R.drawable.personalservicessub, R.drawable.personalservicessub,
			R.drawable.wedding, R.drawable.wedingmakeup, R.drawable.business };
	// int imag[]={R.drawable.events1,R.drawable.pb};

	// String
	// namestr[]={"Event Service","Home Services","Personal Services","Wedding Services","Blumber Services"};

	String namestr[] = { "All Services", "Health and Services",
			"Home Services & Repairs", "Hobbies and Interests",
			"Personal Services", "Academic Tutors", "Wedding & Events",
			"Beauty", "Business Services" };
	MyApp obj;
	Spinner localty;
	EditText edtpin;
	int selected;
	String SelectedLoca;
TextView currentloc;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.home);
		regtxt1 = (TextView) findViewById(R.id.regtxt1);
		Typeface reg = Typeface.createFromAsset(getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		regtxt1.setTypeface(reg);
		edtpin = (EditText) findViewById(R.id.pin);
		underline = (View) findViewById(R.id.underline2);
		localty = (Spinner) findViewById(R.id.cotry_ls);
		currentloc=(TextView)findViewById(R.id.currentloc);
		localty.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

			@Override
			public void onItemSelected(AdapterView<?> arg0, View arg1, int pos,
					long arg3) {
				// TODO Auto-generated method stub
				SelectedLoca = citydata[pos].toString() + "("
						+ citydata1[pos].toLowerCase() + ")";
			}

			@Override
			public void onNothingSelected(AdapterView<?> arg0) {
				// TODO Auto-generated method stub

			}
		});
		appLocationService = new AppLocationService(
				HomeActivity.this);
		underline.setVisibility(View.GONE);
		servicesls = (ListView) findViewById(R.id.servicesls);
		obj = (MyApp) getApplicationContext();
		new Catagory().execute();
		/*VendorAdapter adapter1 = new VendorAdapter(HomeActivity.this, img,
				namestr);
		servicesls.setAdapter(adapter1);*/
		servicesls
				.setOnItemClickListener(new AdapterView.OnItemClickListener() {

					@Override
					public void onItemClick(AdapterView<?> arg0, View arg1,
							int pos, long arg3) {
						try{
							if (edtpin.length() == 6) {
								
								particularCatId=catIdLs.get(pos);
								
								Intent sub=new Intent(HomeActivity.this, MainHomeActivity.class);
								sub.putExtra("id", particularCatId);
								startActivity(sub);
								obj.setCatIndex(pos);
								
								obj.setCatagorieName(nameLs.get(pos));
								//obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(nameLs.get(pos));
								obj.setLocaOrder(ArrLs.get(pos)+"("+ArrLslocaty.get(pos)+")");
								obj.setPinno(edtpin.getText().toString());
								}
								else
								{
									Toast.makeText(HomeActivity.this, "Select Location", 1000).show();
								}
						}
						catch(Exception e)
						{
							e.printStackTrace();
						}
						
						
						
						
						
						/*
						// TODO Auto-generated method stub

						if (pos == 0) {

							
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.ac,
										R.drawable.health, R.drawable.homeeye,
										R.drawable.physioth, R.drawable.tiffin,
										R.drawable.yogatrainer,
										R.drawable.both,
										R.drawable.birthdays, R.drawable.birthdays,
										R.drawable.bolly, R.drawable.bridal,
										R.drawable.carclening, R.drawable.carpenter,
										R.drawable.carpenter, R.drawable.cctv,
										R.drawable.chatedaccountent, R.drawable.homeeye,
										R.drawable.construction, R.drawable.contemparydance,
										R.drawable.corporateevent, R.drawable.corporate,
										R.drawable.corporate, R.drawable.health,
										R.drawable.lawyer, R.drawable.dj1,
										R.drawable.doorstep, R.drawable.plug,
										R.drawable.t, R.drawable.familyphoto,
										R.drawable.fitness, R.drawable.folkdance,
										R.drawable.frenchlesson, R.drawable.frenchlesson,
										R.drawable.germanlesson, R.drawable.germanlesson,
										R.drawable.geyser, R.drawable.gitarclass,
										R.drawable.hiphop, R.drawable.homeeye,
										R.drawable.housepainting, R.drawable.interi,
										R.drawable.jazz, R.drawable.kathak,
										R.drawable.keyboard, R.drawable.keyboard,
										R.drawable.leptop, R.drawable.lawyer,
										R.drawable.liveband, R.drawable.materinty,
										R.drawable.methnmetics, R.drawable.mehedi,
										R.drawable.mircowave, R.drawable.mobile,
										R.drawable.packers, R.drawable.pan,
										R.drawable.partymakeup, R.drawable.corporateevent,
										R.drawable.pest, R.drawable.physioth,
										R.drawable.piano, R.drawable.plumber1,
										R.drawable.prewedding, R.drawable.professonal,
										R.drawable.refrigerator, R.drawable.relationship,
										R.drawable.rowater, R.drawable.salon,
										R.drawable.sciencehome, R.drawable.sofa1,
										R.drawable.tv, R.drawable.tiffin,
										R.drawable.washing, R.drawable.web,
										R.drawable.weddingcard, R.drawable.weddingcake,
										R.drawable.yoga, R.drawable.yoga,
										R.drawable.yoga, R.drawable.homeeye,
										R.drawable.zumbbafitness };
								String[] ArraName = { "AC Repair",
										"Apple Product", "Architect",
										"Baby and kids Photographer",
										"Bartender", "Bathroom cleaning",
										"Birthday Party Cateres",
										"Birthday Party Decorator",
										"Birthday Party Planner",
										"Bollywood Dance Classes",
										"Bridal Makeup Artist", "Car Cleaning",
										"Carpenter", "Carpent Cleaning",
										"CCTV Dealer", "Chartered Accountant",
										"Construction and Renovation",
										"Contemporary Dance Classes",
										"Corporat Party Caterers", "Dietician",
										"Divorce Lawyer",
										"DJ for Wedding and Events",
										"Doorstep Laundry", "Driver on Demand",
										"Drum Classes", "Dry Cleaning ",
										"Electrician", "English  Home Tutor",
										"Family photographer",
										"Fitness Trainer at home",
										"Folk Dance Class", "French Lessons",
										"French Lesson at Home",
										"German Lessons at Home",
										"Geyser/Water Health repair",
										"Guitar at Home for Kids & Treens",
										"Hip Hop Dance", "home Eye Check-up",
										"House Painters", "house Party Chef",
										"Interior Designing",
										"Jazz Dance Classes",
										"Kathak Dance Classes",
										"Keyboard Lessons at Home",
										"Kitchen Deep Cleaning",
										"Laptop Repair", "Lawyer", "Live Band",
										"Maternity Photographer",
										"Mathematices Home Tutor",
										"Mehendi for Wedding and Events",
										"Mcrowave Repair", "Mobile Repair",
										"Packers and Movers", "PAN Card",
										"Party MakeUp Artist",
										"Peraonal Party Photographer",
										"Pest Control", "Physotherapist",
										"Piano Lessons", "Plumber",
										"Pre-Wedding Shoot", "Refrigerator",
										"RO Water purifier Repair",
										"Salon at Home for Women",
										"Science Home tutor", "Sofa Cleaning",
										"Television Repair", "Tiffin Services",
										"Washing machine Repair",
										"Web Designer & developments",
										"Wedding Card at Home",
										"Wedding Caterers",
										"Wedding Choreographer",
										"Wedding photographer",
										"Wedding Planner",
										"Yoga Classes at Studio",
										"Yoga Classes at Home",
										"Zumba Fitness Dance" };
								obj.setSelectedArry(ArraName);
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));

								// ArrayList<String> lsName =
								// (ArrayList<String>) Arrays.asList(ArraName);

								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setCatIndex(pos);
								obj.setPinno(edtpin.getText().toString());
								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							} else {
								Toast.makeText(HomeActivity.this,
										"Empty Location", 1000).show();
							}

						}

						if (pos == 1) {
							if (edtpin.length() == 6) {
								obj.setCatIndex(pos);
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.health,
										R.drawable.fitness, R.drawable.homeeye,
										R.drawable.physioth, R.drawable.tiffin,
										R.drawable.yogatrainer,
										R.drawable.yogatrainer };
								String[] ArraName = { "Dietician",
										"Fitness Trainer at Home",
										"Home Eye Check Up", "Physiotherapist",
										"Tiffin Services",
										"Yoga classes at Studio",
										"Yoga classes at Home" };
								obj.setSelectedArry(ArraName);
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));

								// ArrayList<String> lsName =
								// (ArrayList<String>) Arrays.asList(ArraName);

								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());

								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							}
						} else if (pos == 2) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.ac,
										R.drawable.appleppro, R.drawable.engle,
										R.drawable.bothroomcleaning,
										R.drawable.carclening,
										R.drawable.carpenter, R.drawable.cctv,
										R.drawable.construction,
										R.drawable.construction, };
								String ArraName[] = { "AC Repair",
										"Apple Product Repair", "Architect",
										"Bathroom cleaning", "Car Cleaning",
										"Carpenter", "CCTV Dealer",
										"Construction" };
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));
								obj.setSelectedArry(ArraName);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());
								obj.setCatIndex(pos);
								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							}
						} else if (pos == 3) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.bolly,
										R.drawable.contemparydance,
										R.drawable.dramclass,
										R.drawable.folkdance,
										R.drawable.frenchlesson,
										R.drawable.frenchlesson,
										R.drawable.germanlesson,
										R.drawable.gitarathomeforkids,
										R.drawable.gitarclass,
										R.drawable.hiphop, R.drawable.jazz,
										R.drawable.kathak, R.drawable.keyboard,
										R.drawable.keyboard, R.drawable.piano,
										R.drawable.salsadance,
										R.drawable.zumbbafitness };
								String ArraName[] = {
										"Bollywood Dance Classes",
										"Contemporary Dance Classes",
										"Drum Classes", "Folk Dance Classes",
										"French Lesson",
										"French Lesson at Home",
										"German Lesson",
										"Guitar at Home for Kids & Teens",
										"Guitar Class for Kids Teens",
										"Hip Hop Dance Classes",
										"jazz Dance Classes",
										"Kathak Dance Classes",
										"Keyboard Lesson",
										"Keyboard Lesson at Home",
										"Piano Lesson", "Salan Dance Classes",
										"Zumba Fitness Dance" };
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));
								obj.setSelectedArry(ArraName);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());
								obj.setCatIndex(pos);

								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							}
						} else if (pos == 4) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.cctv,
										R.drawable.chartedacountent,
										R.drawable.divorce,
										R.drawable.doorstep,
										R.drawable.doorstep,
										R.drawable.familyphotographer,
										R.drawable.housepty,
										R.drawable.keyboard, R.drawable.lawyer,
										R.drawable.mehedi, R.drawable.lawyer,
										R.drawable.partymakeup,
										R.drawable.lawyer,
										R.drawable.corporateevent,
										R.drawable.astol, R.drawable.salon,
										R.drawable.tiffin,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent,
										R.drawable.chartedacountent };
								String ArraName[] = { "CCTV Dealer",
										"Chartered Accountant",
										"Divorce Lawyer", "Doorstep Laundry",
										"Driver on Demand", "Dry Cleaning",
										"Family Photographer",
										"House Party Chef",
										"Interior Designing", "Lawyer",
										"Maternity Photographer",
										"Mehendi for Wedding and Events",
										"Packer and Movers", "PAN Card Agent",
										"Party Makeup Artist",
										"Passport Agent",
										"Personal Party Photographer",
										"Relationship and MarriageCounselors",
										"Salon at home for Wemen",
										"Tiffine Services",
										"Web Designing & developments" };

								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));
								obj.setSelectedArry(ArraName);

								obj.setCatIndex(pos);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());
								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							}
						} else if (pos == 5) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.englishhome,
										R.drawable.englishhome,
										R.drawable.germanless,
										R.drawable.germanless,
										R.drawable.methnmetics,
										R.drawable.sciencehome };
								
								
							

								String ArraName[] = { "English Home Tutor",
										"French Lesson",
										"French Lessons at Home",
										"German Lessons",
										"Mathematics Home Tutor",
										"Science Tutor" };

								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));
								obj.setSelectedArry(ArraName);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());
								obj.setCatIndex(pos);

								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);
							}
						} else if (pos == 6) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());

								int ArrImg[] = { R.drawable.astol,
										R.drawable.homeeye,
										R.drawable.birthdaydecorated,
										R.drawable.birthdaydecorated,
										R.drawable.birthdaydecorated,
										R.drawable.partymakeup,
										R.drawable.corporateevent,
										R.drawable.corporate,
										R.drawable.partymakeup, };
								String ArraName[] = { "Astrologer",
										"Bartender", "Birthday Party Caterers",
										"Birthdayparty Decorator",
										"Birthday Party Planner",
										"Bridal Makeup Artist",
										"Corporate Event Photographer",
										"Corporate Event Planner",
										"Corporate _Party Cateres" };
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));
								obj.setSelectedArry(ArraName);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);

								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setCatIndex(pos);
								obj.setPinno(edtpin.getText().toString());
								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);

							}
						}

						else if (pos == 7) {
							if (edtpin.length() == 6) {
								obj.setCatName(namestr[pos].toString());
								int ArrImg[] = { R.drawable.partymakeup,
										R.drawable.mehedi,
										R.drawable.partymakeup,
										R.drawable.physioth, R.drawable.salun };
								String ArraName[] = { "Bridal Makeup Artist",
										"Mehendi for Wedding ",
										"Party Makeup Artist",
										"Salon at Home for Women" };
								ArrayList<String> lsName = new ArrayList<String>(
										Arrays.asList(ArraName));

								obj.setSelectedArry(ArraName);
								obj.setSubCatname(lsName);
								obj.setArrImgName(ArrImg);
								obj.setHeadretitlename(namestr[pos].toString());
								obj.setLocaOrder(SelectedLoca);
								obj.setPinno(edtpin.getText().toString());
								obj.setCatIndex(pos);
								Intent home = new Intent(HomeActivity.this,
										MainHomeActivity.class);
								startActivity(home);

								
								 * int
								 * ArrImg[]={R.drawable.partymakeup,R.drawable
								 * .mehedi
								 * ,R.drawable.partymakeup,R.drawable.physioth
								 * ,R.drawable.salun}; String
								 * ArraName[]={"Bridal Makeup Artist"
								 * ,"Mehendi for Wedding "
								 * ,"Party Makeup Artist",
								 * "Salon at Home for Women"}; ArrayList<String>
								 * lsName= new
								 * ArrayList<String>(Arrays.asList(ArraName));
								 * 
								 * obj.setSubCatname(lsName);
								 * obj.setArrImgName(ArrImg);
								 * obj.setHeadretitlename
								 * (namestr[pos].toString());
								 * obj.setLocaOrder(SelectedLoca); Intent
								 * home=new Intent(HomeActivity.this,
								 * MainHomeActivity.class); startActivity(home);
								 
							}
						} else if (pos == 8) {
							

							obj.setCatName(namestr[pos].toString());

							int ArrImg[] = { R.drawable.cctv,
									R.drawable.chatedaccountent,
									R.drawable.construction,
									R.drawable.corporate,
									R.drawable.corporateevent,
									R.drawable.corporateevent,
									R.drawable.lawyer,
									R.drawable.corporate,
									R.drawable.packers,R.drawable.pan,R.drawable.passport, R.drawable.web};
							String ArraName[] = { "CCTV",
									"Chartered Accountant", "Construction and Renovation",
									"Corporate Event Photographer",
									"Crporate Event Planner",
									"Corporate Party Caterers",
									"Lawyer",
									"Packers and Movers",
									"PAN Card Agent","Passport Agent","Web Designer and Developer"};
							ArrayList<String> lsName = new ArrayList<String>(
									Arrays.asList(ArraName));
							obj.setSelectedArry(ArraName);
							obj.setSubCatname(lsName);
							obj.setArrImgName(ArrImg);

							obj.setHeadretitlename(namestr[pos].toString());
							obj.setLocaOrder(SelectedLoca);
							obj.setCatIndex(pos);
							obj.setPinno(edtpin.getText().toString());
							Intent home = new Intent(HomeActivity.this,
									MainHomeActivity.class);
							startActivity(home);

								

						} else if (pos == 9) {
							// int
							// ArrImg[]={R.drawable.health,R.drawable.fitness,R.drawable.homeeye,R.drawable.physioth,R.drawable.tiffin,R.drawable.yoga,R.drawable.yogatrainer,};
							// String
							// ArraName[]={"Dietician","Fitness Trainer at Home","Home Eye Check Up","Physiotherapist","Tiffin Services","Yoga classes at Studio","Yoga classes at Home"};
							// Intent home=new Intent(HomeActivity.this,
							// MainHomeActivity.class);
							// startActivity(home);
						} else if (pos == 12) {
							// int
							// ArrImg[]={R.drawable.health,R.drawable.fitness,R.drawable.homeeye,R.drawable.physioth,R.drawable.tiffin,R.drawable.yoga,R.drawable.yogatrainer,};
							// String
							// ArraName[]={"Dietician","Fitness Trainer at Home","Home Eye Check Up","Physiotherapist","Tiffin Services","Yoga classes at Studio","Yoga classes at Home"};
							// Intent home=new Intent(HomeActivity.this,
							// MainHomeActivity.class);
							// startActivity(home);
						}

					*/}
				});

		menubtn = (ImageView) findViewById(R.id.menuopt);
		menubtn.setOnClickListener(new OnClickListener() {

			@SuppressLint("NewApi")
			@Override
			public void onClick(View v) {
				// Creating the instance of PopupMenu
				PopupMenu popup = new PopupMenu(HomeActivity.this, menubtn);
				// Inflating the Popup using xml file
				popup.getMenuInflater().inflate(R.menu.homemenu,
						popup.getMenu());

				// registering popup with OnMenuItemClickListener
				popup.setOnMenuItemClickListener(new PopupMenu.OnMenuItemClickListener() {
					public boolean onMenuItemClick(MenuItem item) {

						if (item.getTitle().equals("Login")) {
							Intent home = new Intent(HomeActivity.this,
									LoginActivity.class);
							startActivity(home);
						} else if (item.getTitle().equals("About")) {
							Intent home = new Intent(HomeActivity.this,
									About.class);
							startActivity(home);
						} else if (item.getTitle().equals("Our Mission")) {
							Intent mission=new Intent(HomeActivity.this, MissonActivity.class);
							   startActivity(mission);
						}
						else if (item.getTitle().equals("Feedback")) {
							Intent fd=new Intent(HomeActivity.this, Feedback.class);
							   startActivity(fd);
						}
						
						else if (item.getTitle().equals("Feedback")) {
							Intent fd=new Intent(HomeActivity.this, Feedback.class);
							   startActivity(fd);
						}
						
						else if (item.getTitle().equals("Call OneWindow")) {

						} else if (item.getTitle().equals("Share OneWindow")) {
							shareTextUrl();
						}

						Toast.makeText(HomeActivity.this,
								"You Clicked : " + item.getTitle(),
								Toast.LENGTH_SHORT).show();
						return true;
					}
				});

				popup.show();// showing popup menu
			}
		});// closing the setOnClickListener method

		// oppup();

		edtpin.addTextChangedListener(watch);
		gpsloca();
	}

	TextWatcher watch = new TextWatcher() {

		@Override
		public void afterTextChanged(Editable arg0) {
			// TODO Auto-generated method stub

		}

		@Override
		public void beforeTextChanged(CharSequence arg0, int arg1, int arg2,
				int arg3) {
			// TODO Auto-generated method stub

		}

		@Override
		public void onTextChanged(CharSequence s, int a, int b, int c) {
			// TODO Auto-generated method stub
			if (s.length() == 6) {
				new Asyntaskfilter(edtpin.getText().toString()).execute();
				// Toast.makeText(getApplicationContext(),
				// "Maximum Limit Reached", Toast.LENGTH_SHORT).show();
			}
			// output.setText(s);

		}
	};

	public void Req(View v) {
		underline.setVisibility(View.GONE);
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

	public static String urlincoding(String param) {
		String resp = "";
		try {

			HttpClient Client = new DefaultHttpClient();
			URL url1 = new URL(param);
			URI uri = new URI(url1.getProtocol(), url1.getUserInfo(),
					url1.getHost(), url1.getPort(), url1.getPath(),
					url1.getQuery(), url1.getRef());
			url1 = uri.toURL();
			HttpGet httpget = new HttpGet(url1.toString());
			String s = url1.toString();
			ResponseHandler<String> responseHandler = new BasicResponseHandler();
			resp = Client.execute(httpget, responseHandler);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return resp;
	}

	class Asyntaskfilter extends AsyncTask<String, String, String> {
		String resp;
		ProgressDialog pd;
		String str;

		Asyntaskfilter(String s) {
			str = s;
		}

		@Override
		protected void onPreExecute() {
			pd = new ProgressDialog(HomeActivity.this);
			pd.setTitle("Please wait...");
			pd.show();
		}

		@Override
		protected String doInBackground(String... params) {
			try {
				// TODO Auto-generated method stub
				String url = obj.getLocationAndLocatilityAPI() + "&pin=" + str
						+ "";
				resp = urlincoding(url);
			} catch (Exception e) {
				e.printStackTrace();
			}
			return resp;
		}

		@Override
		protected void onPostExecute(String result) {
			try {
				pd.dismiss();
				
				JSONObject jObj = new JSONObject(result);
				JSONArray jArr = jObj.getJSONArray("Data");
				for (int i = 0; i < jArr.length(); i++) {
					JSONObject ob = jArr.getJSONObject(i);
					String cty = ob.getString("City");
					String adds = ob.getString("Address");
					ArrLslocaty.add(adds);
					ArrLs.add(cty);
				}
				// AdapterPopulatCity adapter1=new
				// AdapterPopulatCity(HomeActivity.this,ArrLs,ArrLslocaty);
				// localty.setAdapter(adapter1);

				// Spinner mySpinner = (Spinner)findViewById(R.id.spinner1);
				citydata = ArrLslocaty.toArray(new String[ArrLslocaty.size()]);
				citydata1 = ArrLs.toArray(new String[ArrLs.size()]);

				localty.setAdapter(new MyAdapter(HomeActivity.this,
						R.layout.populatcity, citydata, citydata1, citydata1));

			} catch (Exception e) {
				e.printStackTrace();
			}
		}

	}

	public class MyAdapter extends ArrayAdapter<String> {
		String namcity[];
		String addres[];

		public MyAdapter(Context context, int textViewResourceId, String nam[],
				String ct[], String[] citydata1) {
			super(context, textViewResourceId, nam);
			namcity = nam;
			addres = ct;
		}

		@Override
		public View getDropDownView(int position, View convertView,
				ViewGroup parent) {
			return getCustomView(position, convertView, parent);
		}

		@Override
		public View getView(int position, View convertView, ViewGroup parent) {
			return getCustomView(position, convertView, parent);
		}

		public View getCustomView(int position, View convertView,
				ViewGroup parent) {

			LayoutInflater inflater = getLayoutInflater();
			View row = inflater.inflate(R.layout.populatcity, parent, false);
			TextView label = (TextView) row.findViewById(R.id.distt);
			label.setText(namcity[position].toString() + "("
					+ addres[position].toString() + ")");
			return row;
		}

	}
	
	class Catagory extends AsyncTask<String, String, String>
	{
		ProgressDialog pd;
		String resp;
@Override
protected void onPreExecute() {
	pd=new ProgressDialog(HomeActivity.this);
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
						
					}
					obj.setCatIdLs(catIdLs);
					VendorAdapter adapter1 = new VendorAdapter(HomeActivity.this, 
							nameLs);
					servicesls.setAdapter(adapter1);
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				}
	}
	private class GeocoderHandler extends Handler {
	     @Override
	     public void handleMessage(Message message) {
	         String locationAddress;
	         switch (message.what) {
	             case 1:
	                 Bundle bundle = message.getData();
	                 locationAddress = bundle.getString("address");
	                 currentloc.setText(obj.getCurrentlocaton());
	                 break;
	             default:
	                 locationAddress = null;
	         }
	        // tvAddress.setText(locationAddress);
	        // Toast.makeText(Currentlocation.this, " "+locationAddress, 1000).show();
	     }
	 }
	public void gpsloca()
	{
		Location gpsLocation = appLocationService
				.getLocation(LocationManager.NETWORK_PROVIDER);

		if (gpsLocation != null) {
			double latitude = gpsLocation.getLatitude();
			double longitude = gpsLocation.getLongitude();
			
			 LocationAddress locationAddress = new LocationAddress();
             locationAddress.getAddressFromLocation(latitude, longitude,
                     getApplicationContext(), new GeocoderHandler());
			
//			Toast.makeText(
//					getApplicationContext(),
//					"Mobile Location (GPS): \nLatitude: " + latitude
//							+ "\nLongitude: " + longitude,
//					Toast.LENGTH_LONG).show();
		} else {
			//showSettingsAlert("GPS");
		}
		
	}
	
	
}
