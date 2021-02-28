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
import android.widget.TextView;

public class ProfessionalFragment extends Fragment {

	TextView t1,t2;
	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View root = inflater.inflate(R.layout.profe, null);
		t1=(TextView)root.findViewById(R.id.t1);
		t2=(TextView)root.findViewById(R.id.t2);
		Typeface myTypeface3 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t2.setTypeface(myTypeface3);
		Typeface myTypeface4 = Typeface.createFromAsset(getActivity().getAssets(), "fonts/AlexandriaFLF_Bold.ttf");

		t1.setTypeface(myTypeface4);
		return root;
	}
}
