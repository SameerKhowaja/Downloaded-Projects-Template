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

public class AdapterPopulatCity extends ArrayAdapter<String> {
	private final Activity context;
	ImageView image1,image2;
	int arrint[];
	LinearLayout lay;
	String arrStr[];
	TextView name,name2;
	ArrayList<String>localitycityArea;
	ArrayList<String>dist;
	//String name2[]={"Event Service","Home Services"};
	public AdapterPopulatCity(Activity context,ArrayList<String>Dist,ArrayList<String>localitycity) {
		super(context, R.layout.populatcity,Dist);
		// TODO Auto-generated constructor stub
		this.context=context;
		
		//this.arrint=arr;
		//this.arrStr=arrtr;
		dist=Dist;
		localitycityArea=localitycity;
		
		

		}
@SuppressLint("NewApi")
@Override
public View getView(int position, View convertView, ViewGroup parent) {
	LayoutInflater inflater=context.getLayoutInflater();
	View rowView=inflater.inflate(R.layout.populatcity, null,true);
	try{
	//lay=(LinearLayout)rowView.findViewById(R.id.imaglay);
	
	//image2=(ImageView)rowView.findViewById(R.id.image2);
	
	name2=(TextView)rowView.findViewById(R.id.distt);
	
	name2.setText(dist.get(position)+"("+localitycityArea.get(position)+")");

	
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
	}catch(Exception e)
	{
		e.printStackTrace();
	}
	
	return rowView;
}
}
