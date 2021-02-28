package com.app.onewindows;

import com.app.onewindows.R;

import android.app.Activity;
import android.app.Fragment;
import android.graphics.Typeface;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.TextView;

public class MissionFragment extends Fragment {

	//owner_fragment
	TextView t1,t2,t3,t4,t5,t6,t7,t8;
	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View root = inflater.inflate(R.layout.owner_fragment, null);
		TextView t1=(TextView)root.findViewById(R.id.text1);
		TextView t2=(TextView)root.findViewById(R.id.text2);
		TextView t3=(TextView)root.findViewById(R.id.text3);
		TextView t4=(TextView)root.findViewById(R.id.text4);
		TextView t5=(TextView)root.findViewById(R.id.text5);
		TextView t6=(TextView)root.findViewById(R.id.text6);
		TextView t7=(TextView)root.findViewById(R.id.text7);
		TextView t8=(TextView)root.findViewById(R.id.text8);
		
		
		Typeface txtfont1 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t1.setTypeface(txtfont1);
		Typeface txtfont2 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t2.setTypeface(txtfont2);
		Typeface txtfont3 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t3.setTypeface(txtfont3);
		Typeface txtfont4 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t4.setTypeface(txtfont4);
		Typeface txtfont5 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t5.setTypeface(txtfont5);
		Typeface txtfont6 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t6.setTypeface(txtfont6);
		Typeface txtfont7 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t7.setTypeface(txtfont7);
		Typeface txtfont8 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t8.setTypeface(txtfont8);
		
		return root;
	}
}
