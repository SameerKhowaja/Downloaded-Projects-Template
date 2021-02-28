package com.app.onewindows.adapters;

import java.util.ArrayList;

import com.app.onewindows.R;


import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Context;
import android.graphics.Typeface;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class VendorAdapter extends ArrayAdapter<String> {
	private final Activity context;
	ImageView image1,image2;
	int arrint[];
	int img[] = { R.drawable.all, R.drawable.onwwindow,
			R.drawable.wedding, R.drawable.events1,
			R.drawable.health_and_fitness_apps, R.drawable.guitar,
			R.drawable.interior, R.drawable.trvl, R.drawable.computerservice, R.drawable.advt, R.drawable.finacial, R.drawable.tax, R.drawable.education, R.drawable.onwwindow, R.drawable.business };
	LinearLayout lay;
	String arrStr[];
	ArrayList<String>nm;
	TextView name,name2;
	//String name2[]={"Event Service","Home Services"};
	public VendorAdapter(Activity context,ArrayList<String>nameLs) {
		super(context, R.layout.mylist,nameLs);
		// TODO Auto-generated constructor stub
		this.context=context;
		
		this.nm=nameLs;
		
		

		}
@SuppressLint("NewApi")
@Override
public View getView(int position, View convertView, ViewGroup parent) {
	LayoutInflater inflater=context.getLayoutInflater();
	View rowView=inflater.inflate(R.layout.image_row, null,true);
	
	//lay=(LinearLayout)rowView.findViewById(R.id.imaglay);
	image1=(ImageView)rowView.findViewById(R.id.image1);
	//image2=(ImageView)rowView.findViewById(R.id.image2);
	name=(TextView)rowView.findViewById(R.id.nameservices);
	//name2=(TextView)rowView.findViewById(R.id.nameservices1);
	name.setText(nm.get(position));
	Typeface myTypeface3 = Typeface.createFromAsset(context.getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

	name.setTypeface(myTypeface3);
//	name2.setText(arrStr[position].toString());
	image1.setImageResource(img[position]);
	
//	final int sdk = android.os.Build.VERSION.SDK_INT;
//	if(sdk < android.os.Build.VERSION_CODES.JELLY_BEAN) {
//		lay.setBackgroundDrawable( context.getDrawable(arrint[position]) );
//	} else {
//		lay.setBackground( context.getDrawable(arrint[position]));
//	}
	/*if(position/2==0)
	{
		image1.setImageResource(arrint[position]);
	}
	else
	{
	image2.setImageResource(arrint[position]);
	}*/
	
	
	return rowView;
}
}
