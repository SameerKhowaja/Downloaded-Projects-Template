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

public class HomeServices extends ArrayAdapter<String> {
	private final Activity context;
	ImageView image1,image2;
	int arrint[];
	LinearLayout lay;
	String arrStr[];
	TextView name,name2;
	//String name2[]={"Event Service","Home Services"};
	public HomeServices(Activity context,int arr[],String arrtr[]) {
		super(context, R.layout.mylist,arrtr);
		// TODO Auto-generated constructor stub
		this.context=context;
		
		this.arrint=arr;
		this.arrStr=arrtr;
		
		

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
	name2=(TextView)rowView.findViewById(R.id.nameservices1);
	name.setText(arrStr[position].toString());
	name2.setText(arrStr[position].toString());
	image1.setImageResource(arrint[position]);
	
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
