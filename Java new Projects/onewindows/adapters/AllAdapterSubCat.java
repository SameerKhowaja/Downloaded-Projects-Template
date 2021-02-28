package com.app.onewindows.adapters;

import java.util.ArrayList;

import com.app.onewindows.MyApp;
import com.app.onewindows.R;


import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Context;
import android.graphics.Typeface;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class AllAdapterSubCat extends ArrayAdapter<String> {
	private final Activity context;
	ImageView image1,image2;
	int arrint[];
	LinearLayout lay;
	MyApp onj;
	int catIndex;
	
	String arrStr[];
	TextView name,name2;
	ArrayList<String>subnm=new ArrayList<String>();
	ArrayList<Integer>subimgnm;
	//String name2[]={"Event Service","Home Services"};
	public AllAdapterSubCat(Activity context,ArrayList<String>nm) {
		super(context, R.layout.mylist,nm);
		// TODO Auto-generated constructor stub
		this.context=context;
	//	int[] array = new int[ESTIMATED_SIZE];
		//this.arrint=   new int[arr.length];  //arr;
		
		
		this.subnm=nm;
		
		
		onj=(MyApp)context.getApplicationContext();
		catIndex=onj.getCatIndex();

		//this.subimgnm=imgnm;
		
		

		}
@SuppressLint("NewApi")
@Override
public View getView(int position, View convertView, ViewGroup parent) {
	LayoutInflater inflater=context.getLayoutInflater();
	View rowView=inflater.inflate(R.layout.sub_itms, null,true);
	LinearLayout lay=(LinearLayout)rowView.findViewById(R.id.lay);
	
	Animation slideUp = AnimationUtils.loadAnimation(context, R.anim.slide_right);
	
	
	lay.setAnimation(slideUp);
	lay.startAnimation(slideUp);
	//lay=(LinearLayout)rowView.findViewById(R.id.imaglay);
	image1=(ImageView)rowView.findViewById(R.id.img);
	//image2=(ImageView)rowView.findViewById(R.id.image2);
	name=(TextView)rowView.findViewById(R.id.subname);
//	image1.setImageResource(homeServiceIcons[position]);
	name.setText(subnm.get(position));

	Typeface myTypeface3 = Typeface.createFromAsset(context.getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

	name.setTypeface(myTypeface3);
	
	switch (catIndex) {
	 case 0: 
		 int homeServiceIcons[]={R.drawable.plumber,R.drawable.ac,R.drawable.carpenters,R.drawable.appliance_repaire_amc,R.drawable.home_cleaning,R.drawable.electrician,
					R.drawable.pest_control, R.drawable.sofa_cleaning,R.drawable.bathroom_cleaning, R.drawable.car_cleaning,R.drawable.kitchen_cleaning,R.drawable.car_cleaning,R.drawable.packers_movers,R.drawable.laundry_drycleaning,R.drawable.driver_on_demand,R.drawable.property_dealers};
		 image1.setImageResource(homeServiceIcons[position]);
		 break;
    case 1: 
    	
    	int homeServiceIcons1[]={R.drawable.salon_at_home,R.drawable.party_makeup_artist,R.drawable.baby_photograpers,R.drawable.maternity_photography,R.drawable.dog_trainers,R.drawable.driver_daily_basis,
				R.drawable.tiffine_services, R.drawable.drivers_monthly_hire,R.drawable.astrologers, R.drawable.tattoo_artist, R.drawable.pet_supplies, R.drawable.caprtcleaning};
	 image1.setImageResource(homeServiceIcons1[position]);
    	
             break;
    case 2:  
    	int homeServiceIcons2[]={R.drawable.weading_photographers,R.drawable.pre_weading_shoot,R.drawable.bridal_makeup_artist,R.drawable.djs,R.drawable.weading_cateres,R.drawable.valet_parking,
				R.drawable.weading_planners, R.drawable.weading_venu,R.drawable.party_makeup_artist, R.drawable.bachelors_spinster_party,R.drawable.tent_house,R.drawable.periest,R.drawable.hotel_guest_house,R.drawable.pre_weading_function,R.drawable.enterainment_group,R.drawable.enterainment_group};
	 image1.setImageResource(homeServiceIcons2[position]);
             break;
    case 3:  
    	
    	int homeServiceIcons3[]={R.drawable.camera131,R.drawable.businessman270,R.drawable.bridal,R.drawable.clapperboard6,R.drawable.winner13,R.drawable.businessman269,
				R.drawable.office38, R.drawable.broken28,R.drawable.partymakeup, R.drawable.celebration11,R.drawable.house117,R.drawable.crutch,R.drawable.man428,R.drawable.video11,R.drawable.dvd9,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons3[position]);
    	
             break;
    case 4:  
    	int homeServiceIcons4[]={R.drawable.yoga_at_home,R.drawable.online_detication,R.drawable.yoga_classess,R.drawable.physiotherapy,R.drawable.weight_loss_trainers,R.drawable.dietician_nuritionists,
				R.drawable.fitness_trainer_at_home, R.drawable.gym_spa,R.drawable.aerobic_classes, R.drawable.caprtcleaning,R.drawable.kithcen,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons4[position]);
             break;
    case 5:  
    	int homeServiceIcons5[]={R.drawable.dance_classes,R.drawable.dance_class_at_home,R.drawable.musical_insturments_trainer,R.drawable.foreign_language,R.drawable.cooking_classes,R.drawable.singing_classes,
				R.drawable.chocolate_making, R.drawable.weightlifter2,R.drawable.meter7, R.drawable.caprtcleaning,R.drawable.kithcen,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons5[position]);
             break;
    case 6:  
    	
    	int homeServiceIcons6[]={R.drawable.interior_designer,R.drawable.civil_work,R.drawable.marbal_stone_tiles,R.drawable.wall_treatment,R.drawable.flooring,R.drawable.wood_work,
				R.drawable.customized_furniture, R.drawable.masonary_work,R.drawable.electical_work, R.drawable.paint_work,R.drawable.home_interior,R.drawable.office_interior,R.drawable.room_interior,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons6[position]);
             break;
    case 7:  
    	
    	
    	int homeServiceIcons7[]={R.drawable.air_ticket_domestic,R.drawable.air_ticket_international,R.drawable.rail_ticket,R.drawable.car_bus_rental,R.drawable.hotel_booking,R.drawable.group_tours,
				R.drawable.school_excur_pack, R.drawable.passport_application_services,R.drawable.visa_assistance, R.drawable.caprtcleaning,R.drawable.kithcen,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons7[position]);
             break;
    case 8:  
    	
    	
    	int homeServiceIcons8[]={R.drawable.purchase_new_old,R.drawable.repairs_upgradation,R.drawable.amc,R.drawable.software_support,R.drawable.plate17,R.drawable.traffic24,
				R.drawable.teaching, R.drawable.passport,R.drawable.passport, R.drawable.caprtcleaning,R.drawable.kithcen,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons8[position]);
             break;
    case 9:  
    	
    	
    	int homeServiceIcons9[]={R.drawable.board_horadings,R.drawable.pamphlets,R.drawable.office_stationary,R.drawable.corporate_gift,R.drawable.calender,R.drawable.outdoor_publicty,
				R.drawable.radio_publictiy, R.drawable.newspaper_adds,R.drawable.shoping_bags, R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons9[position]);
             break;
    case 10: 
    	
    	int homeServiceIcons10[]={R.drawable.life_insurance,R.drawable.accident_insurance,R.drawable.home_office_insurance,R.drawable.car_insurance,R.drawable.loans_finances,R.drawable.investment_planning,
				R.drawable.medicals_insurances, R.drawable.group_insurance,R.drawable.logo, R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons10[position]);
             break;
    case 11: 
    	
    	
    	int homeServiceIcons11[]={R.drawable.income_tax,R.drawable.sales_tax,R.drawable.servicestax,R.drawable.chatedaccountent,R.drawable.incorporation_company,R.drawable.pan_tan,
				R.drawable.trade_mark_copyright, R.drawable.brand_registration,R.drawable.iso, R.drawable.ngo_trust,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons11[position]);
             break;
    case 12: 
    	
    	
    	int homeServiceIcons12[]={R.drawable.home_titune,R.drawable.tution_classes,R.drawable.competive_exam,R.drawable.logo,R.drawable.bothroomcleaning,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons12[position]);
             break;
    case 13: 
    	
    	int homeServiceIcons13[]={R.drawable.pathology_lab,R.drawable.flowers_delivery,R.drawable.restaurant,R.drawable.grocery,R.drawable.doctor,R.drawable.logo};
	 image1.setImageResource(homeServiceIcons13[position]);
             break;
    case 14: 
    	
    	
    	int homeServiceIcons14[]={R.drawable.plumber1,R.drawable.ac,R.drawable.carpenter,R.drawable.logo,R.drawable.bothroomcleaning,R.drawable.hospital,R.drawable.logo
				};
	 image1.setImageResource(homeServiceIcons14[position]);
             break;
    default: 
             break;
}


	
	
	return rowView;
}

}
