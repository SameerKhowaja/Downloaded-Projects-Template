package com.app.onewindows.adapters;

public class SelectedProvidersModel {

	private String name;
	private String category;
	private String type;
	private String location;
	private String price;
	private boolean selected;
	public SelectedProvidersModel(String n,String cat,String typ,String loca,String prie)	{
		name=n;
		category=cat;
		type=typ;
		location=loca;
		price=prie;
		
	}
	public String getName() {
		return name;
	}
	public String getCategory() {
		return category;
	}
	public String getType() {
		return type;
	}
	public String getLocation() {
		return location;
	}
	public String getPrice() {
		return price;
	}
	public boolean isSelected() {
		return selected;
	}
	
	 public void setSelected(boolean selected) {
	        this.selected = selected;
	    }
}
