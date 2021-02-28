package b4a.example;

import anywheresoftware.b4a.B4AMenuItem;
import android.app.Activity;
import android.os.Bundle;
import anywheresoftware.b4a.BA;
import anywheresoftware.b4a.BALayout;
import anywheresoftware.b4a.B4AActivity;
import anywheresoftware.b4a.ObjectWrapper;
import anywheresoftware.b4a.objects.ActivityWrapper;
import java.lang.reflect.InvocationTargetException;
import anywheresoftware.b4a.B4AUncaughtException;
import anywheresoftware.b4a.debug.*;
import java.lang.ref.WeakReference;

public class main extends Activity implements B4AActivity{
	public static main mostCurrent;
	static boolean afterFirstLayout;
	static boolean isFirst = true;
    private static boolean processGlobalsRun = false;
	BALayout layout;
	public static BA processBA;
	BA activityBA;
    ActivityWrapper _activity;
    java.util.ArrayList<B4AMenuItem> menuItems;
	private static final boolean fullScreen = false;
	private static final boolean includeTitle = true;
    public static WeakReference<Activity> previousOne;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		if (isFirst) {
			processBA = new BA(this.getApplicationContext(), null, null, "b4a.example", "b4a.example.main");
			processBA.loadHtSubs(this.getClass());
	        float deviceScale = getApplicationContext().getResources().getDisplayMetrics().density;
	        BALayout.setDeviceScale(deviceScale);
		}
		else if (previousOne != null) {
			Activity p = previousOne.get();
			if (p != null && p != this) {
                anywheresoftware.b4a.keywords.Common.Log("Killing previous instance (main).");
				p.finish();
			}
		}
		if (!includeTitle) {
        	this.getWindow().requestFeature(android.view.Window.FEATURE_NO_TITLE);
        }
        if (fullScreen) {
        	getWindow().setFlags(android.view.WindowManager.LayoutParams.FLAG_FULLSCREEN,   
        			android.view.WindowManager.LayoutParams.FLAG_FULLSCREEN);
        }
		mostCurrent = this;
        processBA.sharedProcessBA.activityBA = null;
		layout = new BALayout(this);
		setContentView(layout);
		afterFirstLayout = false;
		BA.handler.postDelayed(new WaitForLayout(), 5);

	}
	private static class WaitForLayout implements Runnable {
		public void run() {
			if (afterFirstLayout)
				return;
			if (mostCurrent == null)
				return;
			if (mostCurrent.layout.getWidth() == 0) {
				BA.handler.postDelayed(this, 5);
				return;
			}
			mostCurrent.layout.getLayoutParams().height = mostCurrent.layout.getHeight();
			mostCurrent.layout.getLayoutParams().width = mostCurrent.layout.getWidth();
			afterFirstLayout = true;
			mostCurrent.afterFirstLayout();
		}
	}
	private void afterFirstLayout() {
        if (this != mostCurrent)
			return;
		activityBA = new BA(this, layout, processBA, "b4a.example", "b4a.example.main");
        processBA.sharedProcessBA.activityBA = new java.lang.ref.WeakReference<BA>(activityBA);
        anywheresoftware.b4a.objects.ViewWrapper.lastId = 0;
        _activity = new ActivityWrapper(activityBA, "activity");
        anywheresoftware.b4a.Msgbox.isDismissing = false;
        initializeProcessGlobals();		
        initializeGlobals();
        
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Create, isFirst = " + isFirst + " **");
        processBA.raiseEvent2(null, true, "activity_create", false, isFirst);
		isFirst = false;
		if (this != mostCurrent)
			return;
        processBA.setActivityPaused(false);
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Resume **");
        processBA.raiseEvent(null, "activity_resume");
        if (android.os.Build.VERSION.SDK_INT >= 11) {
			try {
				android.app.Activity.class.getMethod("invalidateOptionsMenu").invoke(this,(Object[]) null);
			} catch (Exception e) {
				e.printStackTrace();
			}
		}

	}
	public void addMenuItem(B4AMenuItem item) {
		if (menuItems == null)
			menuItems = new java.util.ArrayList<B4AMenuItem>();
		menuItems.add(item);
	}
	@Override
	public boolean onCreateOptionsMenu(android.view.Menu menu) {
		super.onCreateOptionsMenu(menu);
		if (menuItems == null)
			return false;
		for (B4AMenuItem bmi : menuItems) {
			android.view.MenuItem mi = menu.add(bmi.title);
			if (bmi.drawable != null)
				mi.setIcon(bmi.drawable);
            if (android.os.Build.VERSION.SDK_INT >= 11) {
				try {
                    if (bmi.addToBar) {
				        android.view.MenuItem.class.getMethod("setShowAsAction", int.class).invoke(mi, 1);
                    }
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
			mi.setOnMenuItemClickListener(new B4AMenuItemsClickListener(bmi.eventName.toLowerCase(BA.cul)));
		}
		return true;
	}
	private class B4AMenuItemsClickListener implements android.view.MenuItem.OnMenuItemClickListener {
		private final String eventName;
		public B4AMenuItemsClickListener(String eventName) {
			this.eventName = eventName;
		}
		public boolean onMenuItemClick(android.view.MenuItem item) {
			processBA.raiseEvent(item.getTitle(), eventName + "_click");
			return true;
		}
	}
    public static Class<?> getObject() {
		return main.class;
	}
    private Boolean onKeySubExist = null;
    private Boolean onKeyUpSubExist = null;
	@Override
	public boolean onKeyDown(int keyCode, android.view.KeyEvent event) {
		if (onKeySubExist == null)
			onKeySubExist = processBA.subExists("activity_keypress");
		if (onKeySubExist) {
			Boolean res =  (Boolean)processBA.raiseEvent2(_activity, false, "activity_keypress", false, keyCode);
			if (res == null || res == true)
				return true;
            else if (keyCode == anywheresoftware.b4a.keywords.constants.KeyCodes.KEYCODE_BACK) {
				finish();
				return true;
			}
		}
		return super.onKeyDown(keyCode, event);
	}
    @Override
	public boolean onKeyUp(int keyCode, android.view.KeyEvent event) {
		if (onKeyUpSubExist == null)
			onKeyUpSubExist = processBA.subExists("activity_keyup");
		if (onKeyUpSubExist) {
			Boolean res =  (Boolean)processBA.raiseEvent2(_activity, false, "activity_keyup", false, keyCode);
			if (res == null || res == true)
				return true;
		}
		return super.onKeyUp(keyCode, event);
	}
	@Override
	public void onNewIntent(android.content.Intent intent) {
		this.setIntent(intent);
	}
    @Override 
	public void onPause() {
		super.onPause();
        if (_activity == null) //workaround for emulator bug (Issue 2423)
            return;
		anywheresoftware.b4a.Msgbox.dismiss(true);
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Pause, UserClosed = " + activityBA.activity.isFinishing() + " **");
        processBA.raiseEvent2(_activity, true, "activity_pause", false, activityBA.activity.isFinishing());		
        processBA.setActivityPaused(true);
        mostCurrent = null;
        if (!activityBA.activity.isFinishing())
			previousOne = new WeakReference<Activity>(this);
        anywheresoftware.b4a.Msgbox.isDismissing = false;
	}

	@Override
	public void onDestroy() {
        super.onDestroy();
		previousOne = null;
	}
    @Override 
	public void onResume() {
		super.onResume();
        mostCurrent = this;
        anywheresoftware.b4a.Msgbox.isDismissing = false;
        if (activityBA != null) { //will be null during activity create (which waits for AfterLayout).
        	ResumeMessage rm = new ResumeMessage(mostCurrent);
        	BA.handler.post(rm);
        }
	}
    private static class ResumeMessage implements Runnable {
    	private final WeakReference<Activity> activity;
    	public ResumeMessage(Activity activity) {
    		this.activity = new WeakReference<Activity>(activity);
    	}
		public void run() {
			if (mostCurrent == null || mostCurrent != activity.get())
				return;
			processBA.setActivityPaused(false);
            anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Resume **");
		    processBA.raiseEvent(mostCurrent._activity, "activity_resume", (Object[])null);
		}
    }
	@Override
	protected void onActivityResult(int requestCode, int resultCode,
	      android.content.Intent data) {
		processBA.onActivityResult(requestCode, resultCode, data);
	}
	private static void initializeGlobals() {
		processBA.raiseEvent2(null, true, "globals", false, (Object[])null);
	}

public anywheresoftware.b4a.keywords.Common __c = null;
public static anywheresoftware.b4a.sql.SQL _sql1 = null;
public static anywheresoftware.b4a.sql.SQL.CursorWrapper _cursor1 = null;
public anywheresoftware.b4a.objects.Timer _timer1 = null;
public anywheresoftware.b4a.objects.ProgressBarWrapper _pgb1 = null;
public static int _num = 0;
public anywheresoftware.b4a.objects.LabelWrapper _lblpercent = null;
public anywheresoftware.b4a.objects.LabelWrapper _label1 = null;
public anywheresoftware.b4a.objects.SpinnerWrapper _spngender = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnsearch = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtguestname = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtaddress = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnaddguest = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnedit = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btndelete = null;
public anywheresoftware.b4a.objects.ListViewWrapper _listview1 = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtgender = null;
public anywheresoftware.b4a.objects.collections.List _list1 = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnguest = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnbanquet = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnmonitoring = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnreservation = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnexit = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btninquiry = null;
public static String[] _myarray = null;
public anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper _txtsearchguest = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnsearchguest = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnbackguest = null;
public anywheresoftware.b4a.objects.ListViewWrapper _lstbanquet = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnaddb = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btneditb = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnbackb = null;
public anywheresoftware.b4a.objects.EditTextWrapper _edittext1 = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtlocation = null;
public anywheresoftware.b4a.objects.SpinnerWrapper _spnstat = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtpersons = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtstatus = null;
public anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper _txtsearchbanquet = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btndeleteb = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnsearchb = null;
public anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper _txtgnamer = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtgenderr = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtaddressr = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btngback = null;
public anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper _txtbidr = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtblocationr = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtpersonsr = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnreserve = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnbackrr = null;
public anywheresoftware.b4a.objects.ListViewWrapper _lstreservation = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtidin = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtbidin = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btncancel = null;
public anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper _txtnamein = null;
public anywheresoftware.b4a.objects.ListViewWrapper _lvbm = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnbackbm = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnwowowee = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtoccupants = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtdate = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnlogin = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtuser = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtpass = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtfilterbm = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btnexitlog = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtvalid = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtcontact = null;
public anywheresoftware.b4a.objects.ButtonWrapper _btndate = null;
public static String  _activity_create(boolean _firsttime) throws Exception{
 //BA.debugLineNum = 95;BA.debugLine="Sub Activity_Create(FirstTime As Boolean)";
 //BA.debugLineNum = 97;BA.debugLine="Activity.LoadLayout(\"loading\")";
mostCurrent._activity.LoadLayout("loading",mostCurrent.activityBA);
 //BA.debugLineNum = 98;BA.debugLine="timer1.Initialize(\"timer1\",50)";
mostCurrent._timer1.Initialize(processBA,"timer1",(long)(50));
 //BA.debugLineNum = 99;BA.debugLine="timer1.Enabled=True";
mostCurrent._timer1.setEnabled(anywheresoftware.b4a.keywords.Common.True);
 //BA.debugLineNum = 100;BA.debugLine="Listview1.Initialize(\"Listview1\")";
mostCurrent._listview1.Initialize(mostCurrent.activityBA,"Listview1");
 //BA.debugLineNum = 101;BA.debugLine="lstReservation.Initialize(\"lstReservation\")";
mostCurrent._lstreservation.Initialize(mostCurrent.activityBA,"lstReservation");
 //BA.debugLineNum = 102;BA.debugLine="spnGender.Initialize(\"spnGender\")";
mostCurrent._spngender.Initialize(mostCurrent.activityBA,"spnGender");
 //BA.debugLineNum = 103;BA.debugLine="If File.Exists(File.DirInternal,\"ff6_2.sqlite\") = False Then";
if (anywheresoftware.b4a.keywords.Common.File.Exists(anywheresoftware.b4a.keywords.Common.File.getDirInternal(),"ff6_2.sqlite")==anywheresoftware.b4a.keywords.Common.False) { 
 //BA.debugLineNum = 104;BA.debugLine="File.Copy(File.DirAssets,\"ff6_2.sqlite\",File.DirInternal,\"ff6_2.sqlite\")";
anywheresoftware.b4a.keywords.Common.File.Copy(anywheresoftware.b4a.keywords.Common.File.getDirAssets(),"ff6_2.sqlite",anywheresoftware.b4a.keywords.Common.File.getDirInternal(),"ff6_2.sqlite");
 };
 //BA.debugLineNum = 107;BA.debugLine="If sql1.IsInitialized = False Then";
if (_sql1.IsInitialized()==anywheresoftware.b4a.keywords.Common.False) { 
 //BA.debugLineNum = 108;BA.debugLine="sql1.Initialize(File.DirInternal, \"ff6_2.sqlite\", False)";
_sql1.Initialize(anywheresoftware.b4a.keywords.Common.File.getDirInternal(),"ff6_2.sqlite",anywheresoftware.b4a.keywords.Common.False);
 };
 //BA.debugLineNum = 110;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 112;BA.debugLine="myArray(0)=\"Male\"";
mostCurrent._myarray[(int)(0)] = "Male";
 //BA.debugLineNum = 113;BA.debugLine="myArray(1)=\"Female\"";
mostCurrent._myarray[(int)(1)] = "Female";
 //BA.debugLineNum = 114;BA.debugLine="spnGender.Prompt=\"Select Gender\"";
mostCurrent._spngender.setPrompt("Select Gender");
 //BA.debugLineNum = 115;BA.debugLine="spnGender.AddAll(myArray)";
mostCurrent._spngender.AddAll(anywheresoftware.b4a.keywords.Common.ArrayToList(mostCurrent._myarray));
 //BA.debugLineNum = 116;BA.debugLine="txtSearchBanquet.Initialize(\"txtSearchBanquet\")";
mostCurrent._txtsearchbanquet.Initialize(processBA,"txtSearchBanquet");
 //BA.debugLineNum = 118;BA.debugLine="End Sub";
return "";
}
public static String  _activity_pause(boolean _userclosed) throws Exception{
 //BA.debugLineNum = 139;BA.debugLine="Sub Activity_Pause (UserClosed As Boolean)";
 //BA.debugLineNum = 141;BA.debugLine="End Sub";
return "";
}
public static String  _activity_resume() throws Exception{
 //BA.debugLineNum = 134;BA.debugLine="Sub Activity_Resume";
 //BA.debugLineNum = 135;BA.debugLine="Activity.LoadLayout(\"loading\")";
mostCurrent._activity.LoadLayout("loading",mostCurrent.activityBA);
 //BA.debugLineNum = 136;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 137;BA.debugLine="End Sub";
return "";
}
public static String  _btnaddb_click() throws Exception{
int _i = 0;
int _newid = 0;
String _code = "";
String _des = "";
String _unit = "";
 //BA.debugLineNum = 384;BA.debugLine="Sub btnAddB_Click";
 //BA.debugLineNum = 385;BA.debugLine="If txtLocation.Text = \"\" OR txtPersons.Text = \"\" OR txtStatus.Text = \"\" Then";
if ((mostCurrent._txtlocation.getText()).equals("") || (mostCurrent._txtpersons.getText()).equals("") || (mostCurrent._txtstatus.getText()).equals("")) { 
 //BA.debugLineNum = 386;BA.debugLine="Msgbox(\"You have to enter all fields\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("You have to enter all fields","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 389;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 390;BA.debugLine="Try";
try { //BA.debugLineNum = 391;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT ID FROM tblBanquet\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT ID FROM tblBanquet")));
 //BA.debugLineNum = 392;BA.debugLine="If cursor1.RowCount > 0 Then";
if (_cursor1.getRowCount()>0) { 
 //BA.debugLineNum = 393;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step339 = 1;
final double limit339 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step339 > 0 && _i <= limit339) || (step339 < 0 && _i >= limit339); _i += step339) {
 //BA.debugLineNum = 394;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 395;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 396;BA.debugLine="Dim code, des, unit As String";
_code = "";
_des = "";
_unit = "";
 //BA.debugLineNum = 397;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 398;BA.debugLine="NewID = NewID + 1";
_newid = (int)(_newid+1);
 }
};
 //BA.debugLineNum = 400;BA.debugLine="sql1.ExecNonQuery(\"INSERT INTO tblBanquet VALUES('\" & NewID & \"','\" & txtLocation.Text & \"','\" & txtPersons.Text & \"','\" & txtStatus.Text & \"')\")";
_sql1.ExecNonQuery("INSERT INTO tblBanquet VALUES('"+BA.NumberToString(_newid)+"','"+mostCurrent._txtlocation.getText()+"','"+mostCurrent._txtpersons.getText()+"','"+mostCurrent._txtstatus.getText()+"')");
 //BA.debugLineNum = 401;BA.debugLine="Msgbox (\"Successfully added!\", \"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Successfully added!","",mostCurrent.activityBA);
 //BA.debugLineNum = 402;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 };
 } 
       catch (Exception e351) {
			processBA.setLastException(e351); //BA.debugLineNum = 405;BA.debugLine="Msgbox (LastException.Message,\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox(anywheresoftware.b4a.keywords.Common.LastException(mostCurrent.activityBA).getMessage(),"",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 407;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 408;BA.debugLine="dbloadbanquet";
_dbloadbanquet();
 //BA.debugLineNum = 409;BA.debugLine="txtLocation.Text = \"\"";
mostCurrent._txtlocation.setText((Object)(""));
 //BA.debugLineNum = 411;BA.debugLine="txtStatus.Text = \"\"";
mostCurrent._txtstatus.setText((Object)(""));
 };
 //BA.debugLineNum = 413;BA.debugLine="End Sub";
return "";
}
public static String  _btnaddguest_click() throws Exception{
int _i = 0;
int _newid = 0;
String _code = "";
String _des = "";
String _unit = "";
 //BA.debugLineNum = 177;BA.debugLine="Sub btnAddGuest_Click";
 //BA.debugLineNum = 178;BA.debugLine="If txtGuestName.Text = \"\" OR txtGender.Text = \"\" OR txtAddress.Text = \"\" OR txtContact.Text = \"\" OR txtValid.Text = \"\"  Then";
if ((mostCurrent._txtguestname.getText()).equals("") || (mostCurrent._txtgender.getText()).equals("") || (mostCurrent._txtaddress.getText()).equals("") || (mostCurrent._txtcontact.getText()).equals("") || (mostCurrent._txtvalid.getText()).equals("")) { 
 //BA.debugLineNum = 179;BA.debugLine="Msgbox(\"You have to enter all fields\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("You have to enter all fields","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 182;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 183;BA.debugLine="Try";
try { //BA.debugLineNum = 184;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT ID FROM tblGuest\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT ID FROM tblGuest")));
 //BA.debugLineNum = 185;BA.debugLine="If cursor1.RowCount > 0 Then";
if (_cursor1.getRowCount()>0) { 
 //BA.debugLineNum = 186;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step146 = 1;
final double limit146 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step146 > 0 && _i <= limit146) || (step146 < 0 && _i >= limit146); _i += step146) {
 //BA.debugLineNum = 187;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 188;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 189;BA.debugLine="Dim code, des, unit As String";
_code = "";
_des = "";
_unit = "";
 //BA.debugLineNum = 190;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 191;BA.debugLine="NewID = NewID + 1";
_newid = (int)(_newid+1);
 }
};
 //BA.debugLineNum = 193;BA.debugLine="sql1.ExecNonQuery(\"INSERT INTO tblGuest VALUES('\" & NewID & \"','\" & txtGuestName.Text & \"','\" & txtGender.Text & \"','\" & txtAddress.Text & \"','\" & txtContact.Text & \"','\" & txtValid.Text & \"')\")";
_sql1.ExecNonQuery("INSERT INTO tblGuest VALUES('"+BA.NumberToString(_newid)+"','"+mostCurrent._txtguestname.getText()+"','"+mostCurrent._txtgender.getText()+"','"+mostCurrent._txtaddress.getText()+"','"+mostCurrent._txtcontact.getText()+"','"+mostCurrent._txtvalid.getText()+"')");
 //BA.debugLineNum = 194;BA.debugLine="Msgbox (\"Successfully added!\", \"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Successfully added!","",mostCurrent.activityBA);
 //BA.debugLineNum = 195;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 };
 } 
       catch (Exception e158) {
			processBA.setLastException(e158); //BA.debugLineNum = 198;BA.debugLine="Msgbox (LastException.Message,\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox(anywheresoftware.b4a.keywords.Common.LastException(mostCurrent.activityBA).getMessage(),"",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 200;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 201;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 202;BA.debugLine="txtGuestName.Text = \"\"";
mostCurrent._txtguestname.setText((Object)(""));
 //BA.debugLineNum = 204;BA.debugLine="txtAddress.Text = \"\"";
mostCurrent._txtaddress.setText((Object)(""));
 };
 //BA.debugLineNum = 206;BA.debugLine="End Sub";
return "";
}
public static String  _btnback_click() throws Exception{
 //BA.debugLineNum = 641;BA.debugLine="Sub btnBack_Click";
 //BA.debugLineNum = 642;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 643;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 //BA.debugLineNum = 644;BA.debugLine="End Sub";
return "";
}
public static String  _btnbackb_click() throws Exception{
 //BA.debugLineNum = 435;BA.debugLine="Sub btnBackB_Click";
 //BA.debugLineNum = 436;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 437;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 //BA.debugLineNum = 438;BA.debugLine="End Sub";
return "";
}
public static String  _btnbackbm_click() throws Exception{
 //BA.debugLineNum = 653;BA.debugLine="Sub btnbackBM_Click";
 //BA.debugLineNum = 654;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 655;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 //BA.debugLineNum = 656;BA.debugLine="End Sub";
return "";
}
public static String  _btnbackguest_click() throws Exception{
 //BA.debugLineNum = 356;BA.debugLine="Sub btnBackGuest_Click";
 //BA.debugLineNum = 357;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 358;BA.debugLine="Activity.LoadLayout(\"Guest\")";
mostCurrent._activity.LoadLayout("Guest",mostCurrent.activityBA);
 //BA.debugLineNum = 359;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 360;BA.debugLine="myArray(0)=\"Male\"";
mostCurrent._myarray[(int)(0)] = "Male";
 //BA.debugLineNum = 361;BA.debugLine="myArray(1)=\"Female\"";
mostCurrent._myarray[(int)(1)] = "Female";
 //BA.debugLineNum = 362;BA.debugLine="spnGender.Prompt=\"Select Gender\"";
mostCurrent._spngender.setPrompt("Select Gender");
 //BA.debugLineNum = 363;BA.debugLine="spnGender.AddAll(myArray)";
mostCurrent._spngender.AddAll(anywheresoftware.b4a.keywords.Common.ArrayToList(mostCurrent._myarray));
 //BA.debugLineNum = 364;BA.debugLine="End Sub";
return "";
}
public static String  _btnbackrr_click() throws Exception{
 //BA.debugLineNum = 582;BA.debugLine="Sub btnBackRR_Click";
 //BA.debugLineNum = 583;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 584;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 //BA.debugLineNum = 585;BA.debugLine="End Sub";
return "";
}
public static String  _btnbanquet_click() throws Exception{
 //BA.debugLineNum = 288;BA.debugLine="Sub btnBanquet_Click";
 //BA.debugLineNum = 289;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 290;BA.debugLine="Activity.LoadLayout(\"Banquet\")";
mostCurrent._activity.LoadLayout("Banquet",mostCurrent.activityBA);
 //BA.debugLineNum = 291;BA.debugLine="dbloadbanquet";
_dbloadbanquet();
 //BA.debugLineNum = 293;BA.debugLine="myArray(0)=\"Available\"";
mostCurrent._myarray[(int)(0)] = "Available";
 //BA.debugLineNum = 294;BA.debugLine="myArray(1)=\"Unavailable\"";
mostCurrent._myarray[(int)(1)] = "Unavailable";
 //BA.debugLineNum = 295;BA.debugLine="spnStat.Prompt=\"Select Status\"";
mostCurrent._spnstat.setPrompt("Select Status");
 //BA.debugLineNum = 296;BA.debugLine="spnStat.AddAll(myArray)";
mostCurrent._spnstat.AddAll(anywheresoftware.b4a.keywords.Common.ArrayToList(mostCurrent._myarray));
 //BA.debugLineNum = 297;BA.debugLine="txtStatus.Text = \"Available\"";
mostCurrent._txtstatus.setText((Object)("Available"));
 //BA.debugLineNum = 298;BA.debugLine="End Sub";
return "";
}
public static String  _btncancel_click() throws Exception{
int _i = 0;
int _noper = 0;
int _noperplus = 0;
 //BA.debugLineNum = 622;BA.debugLine="Sub btnCancel_Click";
 //BA.debugLineNum = 623;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT ID,Persons FROM tblbanquet where ID like '\" & txtBIDIn.Text & \"'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT ID,Persons FROM tblbanquet where ID like '"+mostCurrent._txtbidin.getText()+"'")));
 //BA.debugLineNum = 624;BA.debugLine="If cursor1.RowCount > 0 Then";
if (_cursor1.getRowCount()>0) { 
 //BA.debugLineNum = 625;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step527 = 1;
final double limit527 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step527 > 0 && _i <= limit527) || (step527 < 0 && _i >= limit527); _i += step527) {
 //BA.debugLineNum = 626;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 628;BA.debugLine="Dim noper, noperplus As Int";
_noper = 0;
_noperplus = 0;
 //BA.debugLineNum = 629;BA.debugLine="noper = cursor1.GetInt(\"Persons\")";
_noper = _cursor1.GetInt("Persons");
 }
};
 };
 //BA.debugLineNum = 632;BA.debugLine="noperplus = noper + 1";
_noperplus = (int)(_noper+1);
 //BA.debugLineNum = 633;BA.debugLine="sql1.ExecNonQuery(\"UPDATE tblBanquet set Status = 'Available' WHERE ID = \" & txtBIDIn.Text)";
_sql1.ExecNonQuery("UPDATE tblBanquet set Status = 'Available' WHERE ID = "+mostCurrent._txtbidin.getText());
 //BA.debugLineNum = 635;BA.debugLine="sql1.ExecNonQuery(\"DELETE FROM tblReservation where ID = '\" & txtIDIn.Text  & \"' \")";
_sql1.ExecNonQuery("DELETE FROM tblReservation where ID = '"+mostCurrent._txtidin.getText()+"' ");
 //BA.debugLineNum = 636;BA.debugLine="Msgbox(\"CANCELLED!\",\"Success\")";
anywheresoftware.b4a.keywords.Common.Msgbox("CANCELLED!","Success",mostCurrent.activityBA);
 //BA.debugLineNum = 637;BA.debugLine="txtBIDIn.Text = \"\"";
mostCurrent._txtbidin.setText((Object)(""));
 //BA.debugLineNum = 638;BA.debugLine="txtNameIn.Text = \"\"";
mostCurrent._txtnamein.setText((Object)(""));
 //BA.debugLineNum = 639;BA.debugLine="txtIDIn.text = \"\"";
mostCurrent._txtidin.setText((Object)(""));
 //BA.debugLineNum = 640;BA.debugLine="End Sub";
return "";
}
public static String  _btndate_click() throws Exception{
anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog _dt = null;
Object _ret = null;
 //BA.debugLineNum = 716;BA.debugLine="Sub btnDate_Click";
 //BA.debugLineNum = 717;BA.debugLine="Dim dt As DateDialog";
_dt = new anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog();
 //BA.debugLineNum = 718;BA.debugLine="Dim ret As Object";
_ret = new Object();
 //BA.debugLineNum = 719;BA.debugLine="dt.Year = DateTime.GetYear(DateTime.Now)";
_dt.setYear(anywheresoftware.b4a.keywords.Common.DateTime.GetYear(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 720;BA.debugLine="dt.Month = DateTime.GetMonth(DateTime.Now)";
_dt.setMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 721;BA.debugLine="dt.DayOfMonth = DateTime.GetDayOfMonth(DateTime.Now)";
_dt.setDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 722;BA.debugLine="ret = dt.Show(\"Set the required date\", \"Date Dialog\",\"\",\"\",\"\",Null)";
_ret = (Object)(_dt.Show("Set the required date","Date Dialog","","","",mostCurrent.activityBA,(android.graphics.Bitmap)(anywheresoftware.b4a.keywords.Common.Null)));
 //BA.debugLineNum = 723;BA.debugLine="txtFilterBM.Text = (dt.Month & \"/\" & dt.DayOfMonth  & \"/\" & dt.Year)";
mostCurrent._txtfilterbm.setText((Object)((BA.NumberToString(_dt.getMonth())+"/"+BA.NumberToString(_dt.getDayOfMonth())+"/"+BA.NumberToString(_dt.getYear()))));
 //BA.debugLineNum = 724;BA.debugLine="End Sub";
return "";
}
public static String  _btndelete_click() throws Exception{
int _newid = 0;
 //BA.debugLineNum = 234;BA.debugLine="Sub btnDelete_Click";
 //BA.debugLineNum = 235;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 236;BA.debugLine="If txtGuestName.Text = \"\" OR txtGender.Text = \"\" OR txtAddress.Text = \"\" Then";
if ((mostCurrent._txtguestname.getText()).equals("") || (mostCurrent._txtgender.getText()).equals("") || (mostCurrent._txtaddress.getText()).equals("")) { 
 //BA.debugLineNum = 237;BA.debugLine="Msgbox(\"Please select data to delete\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Please select data to delete","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 239;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 240;BA.debugLine="Try";
try { //BA.debugLineNum = 241;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 242;BA.debugLine="sql1.ExecNonQuery(\"DELETE FROM tblGuest where ID = '\" & NewID & \"' \")";
_sql1.ExecNonQuery("DELETE FROM tblGuest where ID = '"+BA.NumberToString(_newid)+"' ");
 //BA.debugLineNum = 243;BA.debugLine="Msgbox (\"Record Deleted!\", \"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Record Deleted!","",mostCurrent.activityBA);
 //BA.debugLineNum = 244;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 } 
       catch (Exception e202) {
			processBA.setLastException(e202); //BA.debugLineNum = 246;BA.debugLine="Msgbox (\"Please select data to delete\",\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Please select data to delete","",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 248;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 249;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 250;BA.debugLine="txtGuestName.Text = \"\"";
mostCurrent._txtguestname.setText((Object)(""));
 //BA.debugLineNum = 252;BA.debugLine="txtAddress.Text = \"\"";
mostCurrent._txtaddress.setText((Object)(""));
 };
 //BA.debugLineNum = 254;BA.debugLine="End Sub";
return "";
}
public static String  _btndeleteb_click() throws Exception{
int _newid = 0;
 //BA.debugLineNum = 455;BA.debugLine="Sub btnDeleteB_Click";
 //BA.debugLineNum = 456;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 457;BA.debugLine="If txtLocation.Text = \"\" OR txtPersons.Text = \"\" OR txtStatus.Text = \"\" Then";
if ((mostCurrent._txtlocation.getText()).equals("") || (mostCurrent._txtpersons.getText()).equals("") || (mostCurrent._txtstatus.getText()).equals("")) { 
 //BA.debugLineNum = 458;BA.debugLine="Msgbox(\"Please select data to delete\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Please select data to delete","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 460;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 461;BA.debugLine="Try";
try { //BA.debugLineNum = 462;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 463;BA.debugLine="sql1.ExecNonQuery(\"DELETE FROM tblBanquet where ID = '\" & NewID & \"' \")";
_sql1.ExecNonQuery("DELETE FROM tblBanquet where ID = '"+BA.NumberToString(_newid)+"' ");
 //BA.debugLineNum = 464;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 } 
       catch (Exception e407) {
			processBA.setLastException(e407); //BA.debugLineNum = 466;BA.debugLine="Msgbox (\"Please select data to delete\",\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Please select data to delete","",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 468;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 469;BA.debugLine="dbloadbanquet";
_dbloadbanquet();
 //BA.debugLineNum = 470;BA.debugLine="txtLocation.Text = \"\"";
mostCurrent._txtlocation.setText((Object)(""));
 //BA.debugLineNum = 472;BA.debugLine="txtPersons.Text = \"\"";
mostCurrent._txtpersons.setText((Object)(""));
 };
 //BA.debugLineNum = 474;BA.debugLine="End Sub";
return "";
}
public static String  _btnedit_click() throws Exception{
int _newid = 0;
 //BA.debugLineNum = 207;BA.debugLine="Sub btnEdit_Click";
 //BA.debugLineNum = 208;BA.debugLine="If txtGuestName.Text = \"\" OR txtGender.Text = \"\" OR txtAddress.Text = \"\" Then";
if ((mostCurrent._txtguestname.getText()).equals("") || (mostCurrent._txtgender.getText()).equals("") || (mostCurrent._txtaddress.getText()).equals("")) { 
 //BA.debugLineNum = 209;BA.debugLine="Msgbox(\"You have to enter all fields\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("You have to enter all fields","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 211;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 212;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 213;BA.debugLine="Try";
try { //BA.debugLineNum = 214;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 215;BA.debugLine="sql1.ExecNonQuery(\"UPDATE tblGuest set Gname = '\" & txtGuestName.text & \"',Gender ='\" & txtGender.text & \"', Address='\" & txtAddress.text & \"' , Cnum='\" & txtContact.text & \"' , ValID='\" & txtValid.text & \"' WHERE ID = \" & NewID)";
_sql1.ExecNonQuery("UPDATE tblGuest set Gname = '"+mostCurrent._txtguestname.getText()+"',Gender ='"+mostCurrent._txtgender.getText()+"', Address='"+mostCurrent._txtaddress.getText()+"' , Cnum='"+mostCurrent._txtcontact.getText()+"' , ValID='"+mostCurrent._txtvalid.getText()+"' WHERE ID = "+BA.NumberToString(_newid));
 //BA.debugLineNum = 216;BA.debugLine="Msgbox (\"Successfully updated!\", \"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Successfully updated!","",mostCurrent.activityBA);
 //BA.debugLineNum = 217;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 } 
       catch (Exception e178) {
			processBA.setLastException(e178); //BA.debugLineNum = 219;BA.debugLine="Msgbox (LastException.Message,\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox(anywheresoftware.b4a.keywords.Common.LastException(mostCurrent.activityBA).getMessage(),"",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 221;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 222;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 223;BA.debugLine="txtGuestName.Text = \"\"";
mostCurrent._txtguestname.setText((Object)(""));
 //BA.debugLineNum = 225;BA.debugLine="txtAddress.Text = \"\"";
mostCurrent._txtaddress.setText((Object)(""));
 };
 //BA.debugLineNum = 227;BA.debugLine="End Sub";
return "";
}
public static String  _btneditb_click() throws Exception{
int _newid = 0;
 //BA.debugLineNum = 414;BA.debugLine="Sub btnEditB_Click";
 //BA.debugLineNum = 415;BA.debugLine="If txtLocation.Text = \"\" OR txtPersons.Text = \"\" OR txtStatus.Text = \"\" Then";
if ((mostCurrent._txtlocation.getText()).equals("") || (mostCurrent._txtpersons.getText()).equals("") || (mostCurrent._txtstatus.getText()).equals("")) { 
 //BA.debugLineNum = 416;BA.debugLine="Msgbox(\"You have to enter all fields\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("You have to enter all fields","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 418;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 419;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 420;BA.debugLine="Try";
try { //BA.debugLineNum = 421;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 //BA.debugLineNum = 422;BA.debugLine="sql1.ExecNonQuery(\"UPDATE tblBanquet set BLocation = '\" & txtLocation.text & \"',Persons ='\" & txtPersons.text & \"', Status='\" & txtStatus.text & \"' WHERE ID = \" & NewID)";
_sql1.ExecNonQuery("UPDATE tblBanquet set BLocation = '"+mostCurrent._txtlocation.getText()+"',Persons ='"+mostCurrent._txtpersons.getText()+"', Status='"+mostCurrent._txtstatus.getText()+"' WHERE ID = "+BA.NumberToString(_newid));
 //BA.debugLineNum = 423;BA.debugLine="Msgbox (\"Successfully updated!\", \"\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Successfully updated!","",mostCurrent.activityBA);
 //BA.debugLineNum = 424;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 } 
       catch (Exception e371) {
			processBA.setLastException(e371); //BA.debugLineNum = 426;BA.debugLine="Msgbox (LastException.Message,\"\")";
anywheresoftware.b4a.keywords.Common.Msgbox(anywheresoftware.b4a.keywords.Common.LastException(mostCurrent.activityBA).getMessage(),"",mostCurrent.activityBA);
 };
 //BA.debugLineNum = 428;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 429;BA.debugLine="dbloadbanquet";
_dbloadbanquet();
 //BA.debugLineNum = 430;BA.debugLine="txtLocation.Text = \"\"";
mostCurrent._txtlocation.setText((Object)(""));
 //BA.debugLineNum = 432;BA.debugLine="txtStatus.Text = \"\"";
mostCurrent._txtstatus.setText((Object)(""));
 };
 //BA.debugLineNum = 434;BA.debugLine="End Sub";
return "";
}
public static String  _btnexit_click() throws Exception{
 //BA.debugLineNum = 315;BA.debugLine="Sub btnExit_Click";
 //BA.debugLineNum = 316;BA.debugLine="Activity.Finish";
mostCurrent._activity.Finish();
 //BA.debugLineNum = 317;BA.debugLine="End Sub";
return "";
}
public static String  _btnexit_up() throws Exception{
 //BA.debugLineNum = 713;BA.debugLine="Sub btnExit_Up";
 //BA.debugLineNum = 715;BA.debugLine="End Sub";
return "";
}
public static String  _btnexitlog_click() throws Exception{
 //BA.debugLineNum = 710;BA.debugLine="Sub btnExitLog_Click";
 //BA.debugLineNum = 711;BA.debugLine="Activity.Finish";
mostCurrent._activity.Finish();
 //BA.debugLineNum = 712;BA.debugLine="End Sub";
return "";
}
public static String  _btngback_click() throws Exception{
 //BA.debugLineNum = 522;BA.debugLine="Sub btnGBack_Click";
 //BA.debugLineNum = 523;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 524;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 //BA.debugLineNum = 525;BA.debugLine="End Sub";
return "";
}
public static String  _btnguest_click() throws Exception{
 //BA.debugLineNum = 276;BA.debugLine="Sub btnGuest_Click";
 //BA.debugLineNum = 277;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 278;BA.debugLine="Activity.LoadLayout(\"guest\")";
mostCurrent._activity.LoadLayout("guest",mostCurrent.activityBA);
 //BA.debugLineNum = 279;BA.debugLine="DBload";
_dbload();
 //BA.debugLineNum = 281;BA.debugLine="txtGender.Initialize(\"txtGender\")";
mostCurrent._txtgender.Initialize(mostCurrent.activityBA,"txtGender");
 //BA.debugLineNum = 282;BA.debugLine="txtGender.Text= \"Male\"";
mostCurrent._txtgender.setText((Object)("Male"));
 //BA.debugLineNum = 283;BA.debugLine="myArray(0)=\"Male\"";
mostCurrent._myarray[(int)(0)] = "Male";
 //BA.debugLineNum = 284;BA.debugLine="myArray(1)=\"Female\"";
mostCurrent._myarray[(int)(1)] = "Female";
 //BA.debugLineNum = 285;BA.debugLine="spnGender.Prompt=\"Select Gender\"";
mostCurrent._spngender.setPrompt("Select Gender");
 //BA.debugLineNum = 286;BA.debugLine="spnGender.AddAll(myArray)";
mostCurrent._spngender.AddAll(anywheresoftware.b4a.keywords.Common.ArrayToList(mostCurrent._myarray));
 //BA.debugLineNum = 287;BA.debugLine="End Sub";
return "";
}
public static String  _btninquiry_click() throws Exception{
 //BA.debugLineNum = 299;BA.debugLine="Sub btnInquiry_Click";
 //BA.debugLineNum = 300;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 301;BA.debugLine="Activity.LoadLayout(\"frmInquiry\")";
mostCurrent._activity.LoadLayout("frmInquiry",mostCurrent.activityBA);
 //BA.debugLineNum = 302;BA.debugLine="End Sub";
return "";
}
public static String  _btnlogin_click() throws Exception{
 //BA.debugLineNum = 692;BA.debugLine="Sub btnLogin_Click";
 //BA.debugLineNum = 694;BA.debugLine="If txtUser.text = \"admin\" AND txtPass.Text = \"admin\" Then";
if ((mostCurrent._txtuser.getText()).equals("admin") && (mostCurrent._txtpass.getText()).equals("admin")) { 
 //BA.debugLineNum = 696;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 697;BA.debugLine="Activity.LoadLayout(\"main\")";
mostCurrent._activity.LoadLayout("main",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 699;BA.debugLine="Msgbox(\"Incorrect username or password\",\"Intruder\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Incorrect username or password","Intruder",mostCurrent.activityBA);
 //BA.debugLineNum = 700;BA.debugLine="txtUser.Text = \"\"";
mostCurrent._txtuser.setText((Object)(""));
 //BA.debugLineNum = 701;BA.debugLine="txtPass.Text = \"\"";
mostCurrent._txtpass.setText((Object)(""));
 //BA.debugLineNum = 702;BA.debugLine="txtUser.RequestFocus";
mostCurrent._txtuser.RequestFocus();
 };
 //BA.debugLineNum = 706;BA.debugLine="End Sub";
return "";
}
public static String  _btnmonitoring_click() throws Exception{
anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog _tt = null;
 //BA.debugLineNum = 670;BA.debugLine="Sub btnMonitoring_Click";
 //BA.debugLineNum = 671;BA.debugLine="Dim tt As DateDialog";
_tt = new anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog();
 //BA.debugLineNum = 672;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 673;BA.debugLine="Activity.LoadLayout(\"frmbm\")";
mostCurrent._activity.LoadLayout("frmbm",mostCurrent.activityBA);
 //BA.debugLineNum = 674;BA.debugLine="tt.Year = DateTime.GetYear(DateTime.Now)";
_tt.setYear(anywheresoftware.b4a.keywords.Common.DateTime.GetYear(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 675;BA.debugLine="tt.Month = DateTime.GetMonth(DateTime.Now)";
_tt.setMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 676;BA.debugLine="tt.DayOfMonth = DateTime.GetDayOfMonth(DateTime.Now)";
_tt.setDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 677;BA.debugLine="txtFilterBM.Text = (tt.Month & \"/\" & tt.DayOfMonth  & \"/\" & tt.Year)";
mostCurrent._txtfilterbm.setText((Object)((BA.NumberToString(_tt.getMonth())+"/"+BA.NumberToString(_tt.getDayOfMonth())+"/"+BA.NumberToString(_tt.getYear()))));
 //BA.debugLineNum = 678;BA.debugLine="dbloadbanquet2(\"\")";
_dbloadbanquet2("");
 //BA.debugLineNum = 680;BA.debugLine="End Sub";
return "";
}
public static String  _btnreservation_click() throws Exception{
anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog _dd = null;
 //BA.debugLineNum = 303;BA.debugLine="Sub btnReservation_Click";
 //BA.debugLineNum = 304;BA.debugLine="Dim dd As DateDialog";
_dd = new anywheresoftware.b4a.agraham.dialogs.InputDialog.DateDialog();
 //BA.debugLineNum = 305;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 307;BA.debugLine="Activity.LoadLayout(\"Reservation\")";
mostCurrent._activity.LoadLayout("Reservation",mostCurrent.activityBA);
 //BA.debugLineNum = 308;BA.debugLine="dbReservation";
_dbreservation();
 //BA.debugLineNum = 309;BA.debugLine="dd.Year = DateTime.GetYear(DateTime.Now)";
_dd.setYear(anywheresoftware.b4a.keywords.Common.DateTime.GetYear(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 310;BA.debugLine="dd.Month = DateTime.GetMonth(DateTime.Now)";
_dd.setMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 311;BA.debugLine="dd.DayOfMonth = DateTime.GetDayOfMonth(DateTime.Now)";
_dd.setDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.GetDayOfMonth(anywheresoftware.b4a.keywords.Common.DateTime.getNow()));
 //BA.debugLineNum = 312;BA.debugLine="txtDate.Text = dd.Month & \"/\" & dd.DayOfMonth & \"/\" & dd.Year";
mostCurrent._txtdate.setText((Object)(BA.NumberToString(_dd.getMonth())+"/"+BA.NumberToString(_dd.getDayOfMonth())+"/"+BA.NumberToString(_dd.getYear())));
 //BA.debugLineNum = 314;BA.debugLine="End Sub";
return "";
}
public static String  _btnreserve_click() throws Exception{
int _i = 0;
int _newid = 0;
 //BA.debugLineNum = 534;BA.debugLine="Sub btnReserve_Click";
 //BA.debugLineNum = 535;BA.debugLine="If txtGnameR.Text = \"\" OR txtAddressR.Text = \"\" OR txtGenderR.Text = \"\" OR txtBLocationR.Text = \"\" OR txtPersonsR.Text = \"\" OR txtBLocationR.Text = \"\"  Then";
if ((mostCurrent._txtgnamer.getText()).equals("") || (mostCurrent._txtaddressr.getText()).equals("") || (mostCurrent._txtgenderr.getText()).equals("") || (mostCurrent._txtblocationr.getText()).equals("") || (mostCurrent._txtpersonsr.getText()).equals("") || (mostCurrent._txtblocationr.getText()).equals("")) { 
 //BA.debugLineNum = 536;BA.debugLine="Msgbox(\"You have to enter all fields\",\"Missed data field\")";
anywheresoftware.b4a.keywords.Common.Msgbox("You have to enter all fields","Missed data field",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 539;BA.debugLine="If txtPersonsR.Text = \"Available\" Then";
if ((mostCurrent._txtpersonsr.getText()).equals("Available")) { 
 //BA.debugLineNum = 541;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT ID FROM tblReservation\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT ID FROM tblReservation")));
 //BA.debugLineNum = 542;BA.debugLine="If cursor1.RowCount > 0 Then";
if (_cursor1.getRowCount()>0) { 
 //BA.debugLineNum = 543;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step473 = 1;
final double limit473 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step473 > 0 && _i <= limit473) || (step473 < 0 && _i >= limit473); _i += step473) {
 //BA.debugLineNum = 544;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 546;BA.debugLine="Dim NewID As Int";
_newid = 0;
 //BA.debugLineNum = 547;BA.debugLine="NewID = cursor1.GetInt(\"ID\")";
_newid = _cursor1.GetInt("ID");
 }
};
 };
 //BA.debugLineNum = 551;BA.debugLine="NewID = NewID +1";
_newid = (int)(_newid+1);
 //BA.debugLineNum = 553;BA.debugLine="sql1.ExecNonQuery(\"INSERT INTO tblReservation VALUES('\" & NewID & \"','\" & txtGnameR.Text & \"','\" & txtGenderR.Text & \"','\" & txtBIDR.Text & \"','\" & txtDate.Text & \"')\")";
_sql1.ExecNonQuery("INSERT INTO tblReservation VALUES('"+BA.NumberToString(_newid)+"','"+mostCurrent._txtgnamer.getText()+"','"+mostCurrent._txtgenderr.getText()+"','"+mostCurrent._txtbidr.getText()+"','"+mostCurrent._txtdate.getText()+"')");
 //BA.debugLineNum = 556;BA.debugLine="sql1.ExecNonQuery(\"UPDATE tblBanquet set Status = 'Unavailable', Persons = '\" & txtDate.Text & \"' WHERE ID = \" & txtBIDR.Text)";
_sql1.ExecNonQuery("UPDATE tblBanquet set Status = 'Unavailable', Persons = '"+mostCurrent._txtdate.getText()+"' WHERE ID = "+mostCurrent._txtbidr.getText());
 //BA.debugLineNum = 560;BA.debugLine="txtGnameR.Text = \"\"";
mostCurrent._txtgnamer.setText((Object)(""));
 //BA.debugLineNum = 561;BA.debugLine="txtBIDR.Text = \"\"";
mostCurrent._txtbidr.setText((Object)(""));
 //BA.debugLineNum = 562;BA.debugLine="txtGenderR.Text = \"\"";
mostCurrent._txtgenderr.setText((Object)(""));
 //BA.debugLineNum = 563;BA.debugLine="txtBLocationR.Text = \"\"";
mostCurrent._txtblocationr.setText((Object)(""));
 //BA.debugLineNum = 564;BA.debugLine="txtPersonsR.Text = \"\"";
mostCurrent._txtpersonsr.setText((Object)(""));
 //BA.debugLineNum = 565;BA.debugLine="txtBLocationR.Text = \"\"";
mostCurrent._txtblocationr.setText((Object)(""));
 //BA.debugLineNum = 566;BA.debugLine="txtAddressR.Text = \"\"";
mostCurrent._txtaddressr.setText((Object)(""));
 //BA.debugLineNum = 567;BA.debugLine="txtDate.Text = \"\"";
mostCurrent._txtdate.setText((Object)(""));
 //BA.debugLineNum = 568;BA.debugLine="Msgbox (\"Successfully Reserved!\",\"Success\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Successfully Reserved!","Success",mostCurrent.activityBA);
 //BA.debugLineNum = 569;BA.debugLine="dbReservation";
_dbreservation();
 };
 //BA.debugLineNum = 571;BA.debugLine="If txtPersonsR.Text = \"Unavailable\" Then";
if ((mostCurrent._txtpersonsr.getText()).equals("Unavailable")) { 
 //BA.debugLineNum = 572;BA.debugLine="Msgbox(\"Room already reserved!\",\"ERROR\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Room already reserved!","ERROR",mostCurrent.activityBA);
 };
 };
 //BA.debugLineNum = 581;BA.debugLine="End Sub";
return "";
}
public static String  _btnsearch_click() throws Exception{
 //BA.debugLineNum = 228;BA.debugLine="Sub btnSearch_Click";
 //BA.debugLineNum = 230;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 231;BA.debugLine="Activity.LoadLayout(\"SearchGuest\")";
mostCurrent._activity.LoadLayout("SearchGuest",mostCurrent.activityBA);
 //BA.debugLineNum = 233;BA.debugLine="End Sub";
return "";
}
public static String  _btnsearchb_click() throws Exception{
int _i = 0;
 //BA.debugLineNum = 475;BA.debugLine="Sub btnSearchB_Click";
 //BA.debugLineNum = 477;BA.debugLine="viewBanquet(txtSearchBanquet.Text)";
_viewbanquet(mostCurrent._txtsearchbanquet.getText());
 //BA.debugLineNum = 478;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step417 = 1;
final double limit417 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step417 > 0 && _i <= limit417) || (step417 < 0 && _i >= limit417); _i += step417) {
 //BA.debugLineNum = 479;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 480;BA.debugLine="If txtSearchBanquet.Text <> cursor1.GetString(\"BLocation\") Then";
if ((mostCurrent._txtsearchbanquet.getText()).equals(_cursor1.GetString("BLocation")) == false) { 
 //BA.debugLineNum = 481;BA.debugLine="Msgbox(\"Record not found.\",\"Note\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Record not found.","Note",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 484;BA.debugLine="dbloadbanquet";
_dbloadbanquet();
 };
 }
};
 //BA.debugLineNum = 490;BA.debugLine="End Sub";
return "";
}
public static String  _btnsearchguest_click() throws Exception{
int _i = 0;
 //BA.debugLineNum = 330;BA.debugLine="Sub btnSearchGuest_Click";
 //BA.debugLineNum = 331;BA.debugLine="view1(txtSearchGuest.Text)";
_view1(mostCurrent._txtsearchguest.getText());
 //BA.debugLineNum = 332;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step281 = 1;
final double limit281 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step281 > 0 && _i <= limit281) || (step281 < 0 && _i >= limit281); _i += step281) {
 //BA.debugLineNum = 333;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 334;BA.debugLine="If txtSearchGuest.Text <> cursor1.GetString(\"Gname\") Then";
if ((mostCurrent._txtsearchguest.getText()).equals(_cursor1.GetString("Gname")) == false) { 
 //BA.debugLineNum = 335;BA.debugLine="Msgbox(\"Record not found.\",\"Note\")";
anywheresoftware.b4a.keywords.Common.Msgbox("Record not found.","Note",mostCurrent.activityBA);
 }else {
 //BA.debugLineNum = 338;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 339;BA.debugLine="Activity.LoadLayout(\"guest\")";
mostCurrent._activity.LoadLayout("guest",mostCurrent.activityBA);
 //BA.debugLineNum = 340;BA.debugLine="myArray(0)=\"Male\"";
mostCurrent._myarray[(int)(0)] = "Male";
 //BA.debugLineNum = 341;BA.debugLine="myArray(1)=\"Female\"";
mostCurrent._myarray[(int)(1)] = "Female";
 //BA.debugLineNum = 342;BA.debugLine="spnGender.Prompt=\"Select Gender\"";
mostCurrent._spngender.setPrompt("Select Gender");
 //BA.debugLineNum = 343;BA.debugLine="spnGender.AddAll(myArray)";
mostCurrent._spngender.AddAll(anywheresoftware.b4a.keywords.Common.ArrayToList(mostCurrent._myarray));
 //BA.debugLineNum = 345;BA.debugLine="Listview1.AddSingleLine(cursor1.GetString(\"ID\")& \"-\" &cursor1.GetString(\"Gname\")& \" - \" & cursor1.GetString(\"Gender\") & \" - \" & cursor1.GetString(\"Address\"))";
mostCurrent._listview1.AddSingleLine(_cursor1.GetString("ID")+"-"+_cursor1.GetString("Gname")+" - "+_cursor1.GetString("Gender")+" - "+_cursor1.GetString("Address"));
 //BA.debugLineNum = 346;BA.debugLine="Listview1.SingleLineLayout.ItemHeight = 26";
mostCurrent._listview1.getSingleLineLayout().setItemHeight((int)(26));
 //BA.debugLineNum = 347;BA.debugLine="Listview1.SingleLineLayout.Label.TextSize = 12";
mostCurrent._listview1.getSingleLineLayout().Label.setTextSize((float)(12));
 //BA.debugLineNum = 348;BA.debugLine="Listview1.SingleLineLayout.Label.TextColor = Colors.Black";
mostCurrent._listview1.getSingleLineLayout().Label.setTextColor(anywheresoftware.b4a.keywords.Common.Colors.Black);
 //BA.debugLineNum = 349;BA.debugLine="Listview1.SingleLineLayout.Label.Color = Colors.White";
mostCurrent._listview1.getSingleLineLayout().Label.setColor(anywheresoftware.b4a.keywords.Common.Colors.White);
 };
 }
};
 //BA.debugLineNum = 352;BA.debugLine="End Sub";
return "";
}
public static String  _btnwowowee_click() throws Exception{
 //BA.debugLineNum = 681;BA.debugLine="Sub btnwowowee_Click";
 //BA.debugLineNum = 682;BA.debugLine="sql1.BeginTransaction";
_sql1.BeginTransaction();
 //BA.debugLineNum = 684;BA.debugLine="sql1.ExecNonQuery(\"UPDATE tblBanquet set Status = 'Available' WHERE ID = 1\")";
_sql1.ExecNonQuery("UPDATE tblBanquet set Status = 'Available' WHERE ID = 1");
 //BA.debugLineNum = 686;BA.debugLine="sql1.TransactionSuccessful";
_sql1.TransactionSuccessful();
 //BA.debugLineNum = 687;BA.debugLine="sql1.EndTransaction";
_sql1.EndTransaction();
 //BA.debugLineNum = 691;BA.debugLine="End Sub";
return "";
}
public static String  _dbload() throws Exception{
int _i = 0;
 //BA.debugLineNum = 151;BA.debugLine="Sub DBload";
 //BA.debugLineNum = 152;BA.debugLine="Listview1.Clear'need to clear the list";
mostCurrent._listview1.Clear();
 //BA.debugLineNum = 153;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblGuest\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblGuest")));
 //BA.debugLineNum = 154;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step117 = 1;
final double limit117 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step117 > 0 && _i <= limit117) || (step117 < 0 && _i >= limit117); _i += step117) {
 //BA.debugLineNum = 155;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 156;BA.debugLine="Listview1.AddSingleLine(cursor1.GetString(\"ID\")& \"-\" &cursor1.GetString(\"Gname\")& \" - \" & cursor1.GetString(\"Gender\") & \" - \" & cursor1.GetString(\"Address\") & \" - \" & cursor1.GetString(\"Cnum\") & \" - \" & cursor1.GetString(\"ValID\"))";
mostCurrent._listview1.AddSingleLine(_cursor1.GetString("ID")+"-"+_cursor1.GetString("Gname")+" - "+_cursor1.GetString("Gender")+" - "+_cursor1.GetString("Address")+" - "+_cursor1.GetString("Cnum")+" - "+_cursor1.GetString("ValID"));
 //BA.debugLineNum = 157;BA.debugLine="Listview1.SingleLineLayout.ItemHeight = 23";
mostCurrent._listview1.getSingleLineLayout().setItemHeight((int)(23));
 //BA.debugLineNum = 158;BA.debugLine="Listview1.SingleLineLayout.Label.TextSize = 12";
mostCurrent._listview1.getSingleLineLayout().Label.setTextSize((float)(12));
 //BA.debugLineNum = 159;BA.debugLine="Listview1.SingleLineLayout.Label.TextColor = Colors.Black";
mostCurrent._listview1.getSingleLineLayout().Label.setTextColor(anywheresoftware.b4a.keywords.Common.Colors.Black);
 //BA.debugLineNum = 160;BA.debugLine="Listview1.SingleLineLayout.Label.Color = Colors.White";
mostCurrent._listview1.getSingleLineLayout().Label.setColor(anywheresoftware.b4a.keywords.Common.Colors.White);
 }
};
 //BA.debugLineNum = 162;BA.debugLine="End Sub";
return "";
}
public static String  _dbloadbanquet() throws Exception{
int _i = 0;
 //BA.debugLineNum = 164;BA.debugLine="Sub dbloadbanquet";
 //BA.debugLineNum = 165;BA.debugLine="lstBanquet.Clear'need to clear the list";
mostCurrent._lstbanquet.Clear();
 //BA.debugLineNum = 166;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblBanquet\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblBanquet")));
 //BA.debugLineNum = 167;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step129 = 1;
final double limit129 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step129 > 0 && _i <= limit129) || (step129 < 0 && _i >= limit129); _i += step129) {
 //BA.debugLineNum = 168;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 169;BA.debugLine="lstBanquet.AddSingleLine(cursor1.GetString(\"ID\")& \"-\" &cursor1.GetString(\"BLocation\") & \" - \" & cursor1.GetString(\"Status\"))";
mostCurrent._lstbanquet.AddSingleLine(_cursor1.GetString("ID")+"-"+_cursor1.GetString("BLocation")+" - "+_cursor1.GetString("Status"));
 //BA.debugLineNum = 170;BA.debugLine="lstBanquet.SingleLineLayout.ItemHeight = 26";
mostCurrent._lstbanquet.getSingleLineLayout().setItemHeight((int)(26));
 //BA.debugLineNum = 171;BA.debugLine="lstBanquet.SingleLineLayout.Label.TextSize = 12";
mostCurrent._lstbanquet.getSingleLineLayout().Label.setTextSize((float)(12));
 //BA.debugLineNum = 172;BA.debugLine="lstBanquet.SingleLineLayout.Label.TextColor = Colors.Black";
mostCurrent._lstbanquet.getSingleLineLayout().Label.setTextColor(anywheresoftware.b4a.keywords.Common.Colors.Black);
 //BA.debugLineNum = 173;BA.debugLine="lstBanquet.SingleLineLayout.Label.Color = Colors.White";
mostCurrent._lstbanquet.getSingleLineLayout().Label.setColor(anywheresoftware.b4a.keywords.Common.Colors.White);
 }
};
 //BA.debugLineNum = 175;BA.debugLine="End Sub";
return "";
}
public static String  _dbloadbanquet2(String _psearch) throws Exception{
int _i = 0;
 //BA.debugLineNum = 658;BA.debugLine="Sub dbloadbanquet2( psearch As String)";
 //BA.debugLineNum = 659;BA.debugLine="lvBM.Clear'need to clear the list";
mostCurrent._lvbm.Clear();
 //BA.debugLineNum = 660;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblBanquet where Persons like '\" & psearch & \"%'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblBanquet where Persons like '"+_psearch+"%'")));
 //BA.debugLineNum = 661;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step560 = 1;
final double limit560 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step560 > 0 && _i <= limit560) || (step560 < 0 && _i >= limit560); _i += step560) {
 //BA.debugLineNum = 662;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 663;BA.debugLine="lvBM.AddSingleLine(cursor1.GetString(\"ID\")& \"-\" &cursor1.GetString(\"BLocation\")& \" - \" & cursor1.GetString(\"Persons\") & \" - \" & cursor1.GetString(\"Status\"))";
mostCurrent._lvbm.AddSingleLine(_cursor1.GetString("ID")+"-"+_cursor1.GetString("BLocation")+" - "+_cursor1.GetString("Persons")+" - "+_cursor1.GetString("Status"));
 //BA.debugLineNum = 664;BA.debugLine="lvBM.SingleLineLayout.ItemHeight = 26";
mostCurrent._lvbm.getSingleLineLayout().setItemHeight((int)(26));
 //BA.debugLineNum = 665;BA.debugLine="lvBM.SingleLineLayout.Label.TextSize = 12";
mostCurrent._lvbm.getSingleLineLayout().Label.setTextSize((float)(12));
 //BA.debugLineNum = 666;BA.debugLine="lvBM.SingleLineLayout.Label.TextColor = Colors.Black";
mostCurrent._lvbm.getSingleLineLayout().Label.setTextColor(anywheresoftware.b4a.keywords.Common.Colors.Black);
 //BA.debugLineNum = 667;BA.debugLine="lvBM.SingleLineLayout.Label.Color = Colors.White";
mostCurrent._lvbm.getSingleLineLayout().Label.setColor(anywheresoftware.b4a.keywords.Common.Colors.White);
 }
};
 //BA.debugLineNum = 669;BA.debugLine="End Sub";
return "";
}
public static String  _dbreservation() throws Exception{
int _i = 0;
 //BA.debugLineNum = 586;BA.debugLine="Sub dbReservation";
 //BA.debugLineNum = 587;BA.debugLine="lstReservation.Clear'need to clear the list";
mostCurrent._lstreservation.Clear();
 //BA.debugLineNum = 588;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblReservation\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblReservation")));
 //BA.debugLineNum = 589;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step505 = 1;
final double limit505 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step505 > 0 && _i <= limit505) || (step505 < 0 && _i >= limit505); _i += step505) {
 //BA.debugLineNum = 590;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 591;BA.debugLine="lstReservation.AddSingleLine(cursor1.GetString(\"ID\") & \"-\" &cursor1.GetString(\"GuestName\")& \" - \" & cursor1.GetString(\"GGender\") & \" - \" & cursor1.GetString(\"BanquetID\") & \" - \" & cursor1.GetString(\"BanquetLocation\"))";
mostCurrent._lstreservation.AddSingleLine(_cursor1.GetString("ID")+"-"+_cursor1.GetString("GuestName")+" - "+_cursor1.GetString("GGender")+" - "+_cursor1.GetString("BanquetID")+" - "+_cursor1.GetString("BanquetLocation"));
 //BA.debugLineNum = 592;BA.debugLine="lstReservation.SingleLineLayout.ItemHeight = 26";
mostCurrent._lstreservation.getSingleLineLayout().setItemHeight((int)(26));
 //BA.debugLineNum = 593;BA.debugLine="lstReservation.SingleLineLayout.Label.TextSize = 12";
mostCurrent._lstreservation.getSingleLineLayout().Label.setTextSize((float)(12));
 //BA.debugLineNum = 594;BA.debugLine="lstReservation.SingleLineLayout.Label.TextColor = Colors.Black";
mostCurrent._lstreservation.getSingleLineLayout().Label.setTextColor(anywheresoftware.b4a.keywords.Common.Colors.Black);
 //BA.debugLineNum = 595;BA.debugLine="lstReservation.SingleLineLayout.Label.Color = Colors.White";
mostCurrent._lstreservation.getSingleLineLayout().Label.setColor(anywheresoftware.b4a.keywords.Common.Colors.White);
 }
};
 //BA.debugLineNum = 597;BA.debugLine="End Sub";
return "";
}

public static void initializeProcessGlobals() {
    
    if (processGlobalsRun == false) {
	    processGlobalsRun = true;
		try {
		        main._process_globals();
		
        } catch (Exception e) {
			throw new RuntimeException(e);
		}
    }
}

public static boolean isAnyActivityVisible() {
    boolean vis = false;
vis = vis | (main.mostCurrent != null);
return vis;}
public static String  _globals() throws Exception{
 //BA.debugLineNum = 22;BA.debugLine="Sub Globals";
 //BA.debugLineNum = 25;BA.debugLine="Dim timer1 As Timer";
mostCurrent._timer1 = new anywheresoftware.b4a.objects.Timer();
 //BA.debugLineNum = 26;BA.debugLine="Dim pgb1 As ProgressBar";
mostCurrent._pgb1 = new anywheresoftware.b4a.objects.ProgressBarWrapper();
 //BA.debugLineNum = 27;BA.debugLine="Dim num As Int";
_num = 0;
 //BA.debugLineNum = 28;BA.debugLine="Dim lblPercent As Label";
mostCurrent._lblpercent = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 29;BA.debugLine="Dim Label1 As Label";
mostCurrent._label1 = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 30;BA.debugLine="Dim spnGender As Spinner";
mostCurrent._spngender = new anywheresoftware.b4a.objects.SpinnerWrapper();
 //BA.debugLineNum = 31;BA.debugLine="Dim btnSearch As Button";
mostCurrent._btnsearch = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 32;BA.debugLine="Dim txtGuestName As EditText";
mostCurrent._txtguestname = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 33;BA.debugLine="Dim txtAddress As EditText";
mostCurrent._txtaddress = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 34;BA.debugLine="Dim btnAddGuest As Button";
mostCurrent._btnaddguest = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 35;BA.debugLine="Dim btnEdit As Button";
mostCurrent._btnedit = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 36;BA.debugLine="Dim btnSearch As Button";
mostCurrent._btnsearch = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 37;BA.debugLine="Dim btnDelete As Button";
mostCurrent._btndelete = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 38;BA.debugLine="Dim Listview1 As ListView";
mostCurrent._listview1 = new anywheresoftware.b4a.objects.ListViewWrapper();
 //BA.debugLineNum = 39;BA.debugLine="Dim txtGender As EditText";
mostCurrent._txtgender = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 40;BA.debugLine="Dim list1 As List";
mostCurrent._list1 = new anywheresoftware.b4a.objects.collections.List();
 //BA.debugLineNum = 41;BA.debugLine="Dim btnGuest As Button";
mostCurrent._btnguest = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 42;BA.debugLine="Dim btnBanquet As Button";
mostCurrent._btnbanquet = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 43;BA.debugLine="Dim btnMonitoring As Button";
mostCurrent._btnmonitoring = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 44;BA.debugLine="Dim btnReservation As Button";
mostCurrent._btnreservation = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 45;BA.debugLine="Dim btnExit As Button";
mostCurrent._btnexit = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 46;BA.debugLine="Dim btnInquiry As Button";
mostCurrent._btninquiry = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 47;BA.debugLine="Dim myArray(2) As String";
mostCurrent._myarray = new String[(int)(2)];
java.util.Arrays.fill(mostCurrent._myarray,"");
 //BA.debugLineNum = 50;BA.debugLine="Dim txtSearchGuest As AutoCompleteEditText";
mostCurrent._txtsearchguest = new anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper();
 //BA.debugLineNum = 51;BA.debugLine="Dim btnSearchGuest As Button";
mostCurrent._btnsearchguest = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 52;BA.debugLine="Dim btnBackGuest As Button";
mostCurrent._btnbackguest = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 53;BA.debugLine="Dim lstBanquet As ListView";
mostCurrent._lstbanquet = new anywheresoftware.b4a.objects.ListViewWrapper();
 //BA.debugLineNum = 54;BA.debugLine="Dim btnAddB As Button";
mostCurrent._btnaddb = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 55;BA.debugLine="Dim btnEditB As Button";
mostCurrent._btneditb = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 56;BA.debugLine="Dim btnBackB As Button";
mostCurrent._btnbackb = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 57;BA.debugLine="Dim EditText1 As EditText";
mostCurrent._edittext1 = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 58;BA.debugLine="Dim txtLocation As EditText";
mostCurrent._txtlocation = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 59;BA.debugLine="Dim spnStat As Spinner";
mostCurrent._spnstat = new anywheresoftware.b4a.objects.SpinnerWrapper();
 //BA.debugLineNum = 60;BA.debugLine="Dim txtPersons As EditText";
mostCurrent._txtpersons = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 61;BA.debugLine="Dim txtStatus As EditText";
mostCurrent._txtstatus = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 63;BA.debugLine="Dim txtSearchBanquet As AutoCompleteEditText";
mostCurrent._txtsearchbanquet = new anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper();
 //BA.debugLineNum = 64;BA.debugLine="Dim btnDeleteB As Button";
mostCurrent._btndeleteb = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 65;BA.debugLine="Dim btnSearchB As Button";
mostCurrent._btnsearchb = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 66;BA.debugLine="Dim txtGnameR As AutoCompleteEditText";
mostCurrent._txtgnamer = new anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper();
 //BA.debugLineNum = 67;BA.debugLine="Dim txtGenderR As EditText";
mostCurrent._txtgenderr = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 68;BA.debugLine="Dim txtAddressR As EditText";
mostCurrent._txtaddressr = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 69;BA.debugLine="Dim btnGBack As Button";
mostCurrent._btngback = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 70;BA.debugLine="Dim txtBIDR As AutoCompleteEditText";
mostCurrent._txtbidr = new anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper();
 //BA.debugLineNum = 71;BA.debugLine="Dim txtBLocationR As EditText";
mostCurrent._txtblocationr = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 72;BA.debugLine="Dim txtPersonsR As EditText";
mostCurrent._txtpersonsr = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 73;BA.debugLine="Dim btnReserve As Button";
mostCurrent._btnreserve = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 74;BA.debugLine="Dim btnBackRR As Button";
mostCurrent._btnbackrr = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 75;BA.debugLine="Dim lstReservation As ListView";
mostCurrent._lstreservation = new anywheresoftware.b4a.objects.ListViewWrapper();
 //BA.debugLineNum = 76;BA.debugLine="Dim txtIDIn As EditText";
mostCurrent._txtidin = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 77;BA.debugLine="Dim txtBIDIn As EditText";
mostCurrent._txtbidin = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 78;BA.debugLine="Dim btnCancel As Button";
mostCurrent._btncancel = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 79;BA.debugLine="Dim txtNameIn As AutoCompleteEditText";
mostCurrent._txtnamein = new anywheresoftware.b4a.objects.AutoCompleteEditTextWrapper();
 //BA.debugLineNum = 80;BA.debugLine="Dim lvBM As ListView";
mostCurrent._lvbm = new anywheresoftware.b4a.objects.ListViewWrapper();
 //BA.debugLineNum = 81;BA.debugLine="Dim btnbackBM As Button";
mostCurrent._btnbackbm = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 82;BA.debugLine="Dim btnwowowee As Button";
mostCurrent._btnwowowee = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 83;BA.debugLine="Dim txtoccupants As EditText";
mostCurrent._txtoccupants = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 84;BA.debugLine="Dim txtDate As EditText";
mostCurrent._txtdate = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 85;BA.debugLine="Dim btnLogin As Button";
mostCurrent._btnlogin = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 86;BA.debugLine="Dim txtUser As EditText";
mostCurrent._txtuser = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 87;BA.debugLine="Dim txtPass As EditText";
mostCurrent._txtpass = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 88;BA.debugLine="Dim txtFilterBM As EditText";
mostCurrent._txtfilterbm = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 89;BA.debugLine="Dim btnExitLog As Button";
mostCurrent._btnexitlog = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 90;BA.debugLine="Dim txtValid As EditText";
mostCurrent._txtvalid = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 91;BA.debugLine="Dim txtContact As EditText";
mostCurrent._txtcontact = new anywheresoftware.b4a.objects.EditTextWrapper();
 //BA.debugLineNum = 92;BA.debugLine="Dim btnDate As Button";
mostCurrent._btndate = new anywheresoftware.b4a.objects.ButtonWrapper();
 //BA.debugLineNum = 93;BA.debugLine="End Sub";
return "";
}
public static String  _listview1_itemclick(int _position,Object _value) throws Exception{
String _idvalue = "";
int _countit = 0;
String _id = "";
int _i = 0;
 //BA.debugLineNum = 258;BA.debugLine="Sub ListView1_ItemClick (Position As Int, Value As Object)";
 //BA.debugLineNum = 259;BA.debugLine="Dim idvalue As String";
_idvalue = "";
 //BA.debugLineNum = 260;BA.debugLine="Dim countIt As Int";
_countit = 0;
 //BA.debugLineNum = 261;BA.debugLine="Dim ID As String";
_id = "";
 //BA.debugLineNum = 262;BA.debugLine="idvalue = Value";
_idvalue = String.valueOf(_value);
 //BA.debugLineNum = 263;BA.debugLine="countIt = idvalue.IndexOf(\"-\") 'find location of sperator";
_countit = _idvalue.indexOf("-");
 //BA.debugLineNum = 264;BA.debugLine="idvalue = idvalue.SubString2(0,countIt) 'find first part of label text";
_idvalue = _idvalue.substring((int)(0),_countit);
 //BA.debugLineNum = 265;BA.debugLine="ID = idvalue";
_id = _idvalue;
 //BA.debugLineNum = 266;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblGuest where ID = '\" & ID & \"' \")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblGuest where ID = '"+_id+"' ")));
 //BA.debugLineNum = 267;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step222 = 1;
final double limit222 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step222 > 0 && _i <= limit222) || (step222 < 0 && _i >= limit222); _i += step222) {
 //BA.debugLineNum = 268;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 269;BA.debugLine="txtGuestName.text=cursor1.getString(\"Gname\")";
mostCurrent._txtguestname.setText((Object)(_cursor1.GetString("Gname")));
 //BA.debugLineNum = 270;BA.debugLine="txtGender.text=cursor1.getString(\"Gender\")";
mostCurrent._txtgender.setText((Object)(_cursor1.GetString("Gender")));
 //BA.debugLineNum = 271;BA.debugLine="txtAddress.text=cursor1.getString(\"Address\")";
mostCurrent._txtaddress.setText((Object)(_cursor1.GetString("Address")));
 //BA.debugLineNum = 272;BA.debugLine="txtContact.text=cursor1.getString(\"Cnum\")";
mostCurrent._txtcontact.setText((Object)(_cursor1.GetString("Cnum")));
 //BA.debugLineNum = 273;BA.debugLine="txtValid.text=cursor1.getString(\"ValID\")";
mostCurrent._txtvalid.setText((Object)(_cursor1.GetString("ValID")));
 }
};
 //BA.debugLineNum = 275;BA.debugLine="End Sub";
return "";
}
public static String  _lstbanquet_itemclick(int _position,Object _value) throws Exception{
String _idvalue = "";
int _countit = 0;
String _id = "";
int _i = 0;
 //BA.debugLineNum = 365;BA.debugLine="Sub lstBanquet_ItemClick (Position As Int, Value As Object)";
 //BA.debugLineNum = 366;BA.debugLine="Dim idvalue As String";
_idvalue = "";
 //BA.debugLineNum = 367;BA.debugLine="Dim countIt As Int";
_countit = 0;
 //BA.debugLineNum = 368;BA.debugLine="Dim ID As String";
_id = "";
 //BA.debugLineNum = 369;BA.debugLine="idvalue = Value";
_idvalue = String.valueOf(_value);
 //BA.debugLineNum = 370;BA.debugLine="countIt = idvalue.IndexOf(\"-\") 'find location of sperator";
_countit = _idvalue.indexOf("-");
 //BA.debugLineNum = 371;BA.debugLine="idvalue = idvalue.SubString2(0,countIt) 'find first part of label text";
_idvalue = _idvalue.substring((int)(0),_countit);
 //BA.debugLineNum = 372;BA.debugLine="ID = idvalue";
_id = _idvalue;
 //BA.debugLineNum = 373;BA.debugLine="cursor1 = sql1.ExecQuery(\"SELECT * FROM tblBanquet where ID = '\" & ID & \"' \")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("SELECT * FROM tblBanquet where ID = '"+_id+"' ")));
 //BA.debugLineNum = 374;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step321 = 1;
final double limit321 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step321 > 0 && _i <= limit321) || (step321 < 0 && _i >= limit321); _i += step321) {
 //BA.debugLineNum = 375;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 376;BA.debugLine="txtLocation.text=cursor1.getString(\"BLocation\")";
mostCurrent._txtlocation.setText((Object)(_cursor1.GetString("BLocation")));
 //BA.debugLineNum = 377;BA.debugLine="txtPersons.text=cursor1.getString(\"Persons\")";
mostCurrent._txtpersons.setText((Object)(_cursor1.GetString("Persons")));
 //BA.debugLineNum = 378;BA.debugLine="txtStatus.text=cursor1.getString(\"Status\")";
mostCurrent._txtstatus.setText((Object)(_cursor1.GetString("Status")));
 }
};
 //BA.debugLineNum = 380;BA.debugLine="End Sub";
return "";
}
public static String  _process_globals() throws Exception{
 //BA.debugLineNum = 15;BA.debugLine="Sub Process_Globals";
 //BA.debugLineNum = 18;BA.debugLine="Dim sql1 As SQL";
_sql1 = new anywheresoftware.b4a.sql.SQL();
 //BA.debugLineNum = 19;BA.debugLine="Dim cursor1 As Cursor";
_cursor1 = new anywheresoftware.b4a.sql.SQL.CursorWrapper();
 //BA.debugLineNum = 20;BA.debugLine="End Sub";
return "";
}
public static String  _removeview() throws Exception{
int _i = 0;
 //BA.debugLineNum = 143;BA.debugLine="Public Sub RemoveView";
 //BA.debugLineNum = 144;BA.debugLine="Dim i As Int";
_i = 0;
 //BA.debugLineNum = 146;BA.debugLine="For i = Activity.NumberOfViews-1 To 0 Step-1";
{
final double step110 = -1;
final double limit110 = (int)(0);
for (_i = (int)(mostCurrent._activity.getNumberOfViews()-1); (step110 > 0 && _i <= limit110) || (step110 < 0 && _i >= limit110); _i += step110) {
 //BA.debugLineNum = 147;BA.debugLine="Activity.RemoveViewAt (i)";
mostCurrent._activity.RemoveViewAt(_i);
 }
};
 //BA.debugLineNum = 149;BA.debugLine="End Sub";
return "";
}
public static String  _spngender_itemclick(int _position,Object _value) throws Exception{
 //BA.debugLineNum = 255;BA.debugLine="Sub spnGender_ItemClick (Position As Int, Value As Object)";
 //BA.debugLineNum = 256;BA.debugLine="txtGender.Text= Value";
mostCurrent._txtgender.setText(_value);
 //BA.debugLineNum = 257;BA.debugLine="End Sub";
return "";
}
public static String  _spnstat_itemclick(int _position,Object _value) throws Exception{
 //BA.debugLineNum = 439;BA.debugLine="Sub spnStat_ItemClick (Position As Int, Value As Object)";
 //BA.debugLineNum = 440;BA.debugLine="txtStatus.Text = Value";
mostCurrent._txtstatus.setText(_value);
 //BA.debugLineNum = 441;BA.debugLine="End Sub";
return "";
}
public static String  _timer1_tick() throws Exception{
 //BA.debugLineNum = 119;BA.debugLine="Sub timer1_Tick";
 //BA.debugLineNum = 120;BA.debugLine="num = num + 1";
_num = (int)(_num+1);
 //BA.debugLineNum = 121;BA.debugLine="pgb1.Progress = num";
mostCurrent._pgb1.setProgress(_num);
 //BA.debugLineNum = 122;BA.debugLine="lblPercent.Text = num";
mostCurrent._lblpercent.setText((Object)(_num));
 //BA.debugLineNum = 123;BA.debugLine="If num > 100 Then";
if (_num>100) { 
 //BA.debugLineNum = 124;BA.debugLine="timer1.Enabled=False";
mostCurrent._timer1.setEnabled(anywheresoftware.b4a.keywords.Common.False);
 //BA.debugLineNum = 125;BA.debugLine="RemoveView";
_removeview();
 //BA.debugLineNum = 127;BA.debugLine="Activity.LoadLayout(\"frmlogin\")";
mostCurrent._activity.LoadLayout("frmlogin",mostCurrent.activityBA);
 //BA.debugLineNum = 129;BA.debugLine="DBload";
_dbload();
 };
 //BA.debugLineNum = 133;BA.debugLine="End Sub";
return "";
}
public static String  _txtbidr_itemclick(String _value) throws Exception{
 //BA.debugLineNum = 529;BA.debugLine="Sub txtBIDR_ItemClick (Value As String)";
 //BA.debugLineNum = 530;BA.debugLine="viewB(txtBIDR.Text)";
_viewb(mostCurrent._txtbidr.getText());
 //BA.debugLineNum = 531;BA.debugLine="txtBLocationR.Text =cursor1.GetString(\"BLocation\")";
mostCurrent._txtblocationr.setText((Object)(_cursor1.GetString("BLocation")));
 //BA.debugLineNum = 532;BA.debugLine="txtPersonsR.Text =cursor1.GetString(\"Status\")";
mostCurrent._txtpersonsr.setText((Object)(_cursor1.GetString("Status")));
 //BA.debugLineNum = 533;BA.debugLine="End Sub";
return "";
}
public static String  _txtbidr_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 526;BA.debugLine="Sub txtBIDR_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 527;BA.debugLine="viewB(txtBIDR.Text)";
_viewb(mostCurrent._txtbidr.getText());
 //BA.debugLineNum = 528;BA.debugLine="End Sub";
return "";
}
public static String  _txtfilterbm_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 707;BA.debugLine="Sub txtFilterBM_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 708;BA.debugLine="dbloadbanquet2(txtFilterBM.Text)";
_dbloadbanquet2(mostCurrent._txtfilterbm.getText());
 //BA.debugLineNum = 709;BA.debugLine="End Sub";
return "";
}
public static String  _txtgnamer_itemclick(String _value) throws Exception{
 //BA.debugLineNum = 491;BA.debugLine="Sub txtGnameR_ItemClick (Value As String)";
 //BA.debugLineNum = 492;BA.debugLine="viewguest(txtGnameR.Text)";
_viewguest(mostCurrent._txtgnamer.getText());
 //BA.debugLineNum = 493;BA.debugLine="txtGenderR.Text =cursor1.GetString(\"Gender\")";
mostCurrent._txtgenderr.setText((Object)(_cursor1.GetString("Gender")));
 //BA.debugLineNum = 494;BA.debugLine="txtAddressR.Text =cursor1.GetString(\"Address\")";
mostCurrent._txtaddressr.setText((Object)(_cursor1.GetString("Address")));
 //BA.debugLineNum = 495;BA.debugLine="End Sub";
return "";
}
public static String  _txtgnamer_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 496;BA.debugLine="Sub txtGnameR_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 497;BA.debugLine="viewguest(txtGnameR.Text)";
_viewguest(mostCurrent._txtgnamer.getText());
 //BA.debugLineNum = 498;BA.debugLine="End Sub";
return "";
}
public static String  _txtnamein_itemclick(String _value) throws Exception{
 //BA.debugLineNum = 648;BA.debugLine="Sub txtNameIn_ItemClick (Value As String)";
 //BA.debugLineNum = 649;BA.debugLine="viewRIn(txtNameIn.Text)";
_viewrin(mostCurrent._txtnamein.getText());
 //BA.debugLineNum = 650;BA.debugLine="txtIDIn.Text =cursor1.GetInt(\"ID\")";
mostCurrent._txtidin.setText((Object)(_cursor1.GetInt("ID")));
 //BA.debugLineNum = 651;BA.debugLine="txtBIDIn.Text =cursor1.GetInt(\"BanquetID\")";
mostCurrent._txtbidin.setText((Object)(_cursor1.GetInt("BanquetID")));
 //BA.debugLineNum = 652;BA.debugLine="End Sub";
return "";
}
public static String  _txtnamein_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 645;BA.debugLine="Sub txtNameIn_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 646;BA.debugLine="viewRIn(txtNameIn.Text)";
_viewrin(mostCurrent._txtnamein.getText());
 //BA.debugLineNum = 647;BA.debugLine="End Sub";
return "";
}
public static String  _txtsearchbanquet_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 381;BA.debugLine="Sub txtSearchBanquet_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 382;BA.debugLine="viewBanquet(txtSearchBanquet.Text)";
_viewbanquet(mostCurrent._txtsearchbanquet.getText());
 //BA.debugLineNum = 383;BA.debugLine="End Sub";
return "";
}
public static String  _txtsearchguest_textchanged(String _old,String _new) throws Exception{
 //BA.debugLineNum = 353;BA.debugLine="Sub txtSearchGuest_TextChanged (Old As String, New As String)";
 //BA.debugLineNum = 354;BA.debugLine="view1(txtSearchGuest.Text)";
_view1(mostCurrent._txtsearchguest.getText());
 //BA.debugLineNum = 355;BA.debugLine="End Sub";
return "";
}
public static String  _view1(String _psearch) throws Exception{
int _i = 0;
String[] _nomi = null;
anywheresoftware.b4a.objects.LabelWrapper _str = null;
 //BA.debugLineNum = 318;BA.debugLine="Sub view1( psearch As String)";
 //BA.debugLineNum = 320;BA.debugLine="cursor1 = sql1.ExecQuery(\"Select * from tblGuest WHERE Gname like '\" & psearch & \"%'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("Select * from tblGuest WHERE Gname like '"+_psearch+"%'")));
 //BA.debugLineNum = 321;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step271 = 1;
final double limit271 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step271 > 0 && _i <= limit271) || (step271 < 0 && _i >= limit271); _i += step271) {
 //BA.debugLineNum = 322;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 323;BA.debugLine="Dim nomi() As String";
_nomi = new String[(int)(0)];
java.util.Arrays.fill(_nomi,"");
 //BA.debugLineNum = 324;BA.debugLine="Dim str As Label";
_str = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 325;BA.debugLine="nomi = Array As String(cursor1.GetString(\"Gname\"))";
_nomi = new String[]{_cursor1.GetString("Gname")};
 //BA.debugLineNum = 326;BA.debugLine="txtSearchGuest.SetItems(nomi)";
mostCurrent._txtsearchguest.SetItems(processBA,anywheresoftware.b4a.keywords.Common.ArrayToList(_nomi));
 }
};
 //BA.debugLineNum = 328;BA.debugLine="End Sub";
return "";
}
public static String  _viewb(String _psearch) throws Exception{
int _i = 0;
String[] _nomi = null;
anywheresoftware.b4a.objects.LabelWrapper _str = null;
 //BA.debugLineNum = 511;BA.debugLine="Sub viewB( psearch As String)";
 //BA.debugLineNum = 513;BA.debugLine="cursor1 = sql1.ExecQuery(\"Select * from tblBanquet WHERE ID like '%\" & psearch & \"'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("Select * from tblBanquet WHERE ID like '%"+_psearch+"'")));
 //BA.debugLineNum = 514;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step446 = 1;
final double limit446 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step446 > 0 && _i <= limit446) || (step446 < 0 && _i >= limit446); _i += step446) {
 //BA.debugLineNum = 515;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 516;BA.debugLine="Dim nomi() As String";
_nomi = new String[(int)(0)];
java.util.Arrays.fill(_nomi,"");
 //BA.debugLineNum = 517;BA.debugLine="Dim str As Label";
_str = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 518;BA.debugLine="nomi = Array As String(cursor1.GetInt(\"ID\"))";
_nomi = new String[]{BA.NumberToString(_cursor1.GetInt("ID"))};
 //BA.debugLineNum = 519;BA.debugLine="txtBIDR.SetItems(nomi)";
mostCurrent._txtbidr.SetItems(processBA,anywheresoftware.b4a.keywords.Common.ArrayToList(_nomi));
 }
};
 //BA.debugLineNum = 521;BA.debugLine="End Sub";
return "";
}
public static String  _viewbanquet(String _psearch) throws Exception{
int _i = 0;
String[] _nomi = null;
anywheresoftware.b4a.objects.LabelWrapper _str = null;
 //BA.debugLineNum = 443;BA.debugLine="Sub viewBanquet(psearch As String)";
 //BA.debugLineNum = 445;BA.debugLine="cursor1 = sql1.ExecQuery(\"Select * from tblBanquet WHERE BLocation like '\" & psearch & \"%'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("Select * from tblBanquet WHERE BLocation like '"+_psearch+"%'")));
 //BA.debugLineNum = 446;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step388 = 1;
final double limit388 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step388 > 0 && _i <= limit388) || (step388 < 0 && _i >= limit388); _i += step388) {
 //BA.debugLineNum = 447;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 448;BA.debugLine="Dim nomi() As String";
_nomi = new String[(int)(0)];
java.util.Arrays.fill(_nomi,"");
 //BA.debugLineNum = 449;BA.debugLine="Dim str As Label";
_str = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 451;BA.debugLine="nomi = Array As String(cursor1.GetString(\"BLocation\"))";
_nomi = new String[]{_cursor1.GetString("BLocation")};
 //BA.debugLineNum = 452;BA.debugLine="txtSearchBanquet.SetItems(nomi)";
mostCurrent._txtsearchbanquet.SetItems(processBA,anywheresoftware.b4a.keywords.Common.ArrayToList(_nomi));
 }
};
 //BA.debugLineNum = 454;BA.debugLine="End Sub";
return "";
}
public static String  _viewguest(String _psearch) throws Exception{
int _i = 0;
String[] _nomi = null;
anywheresoftware.b4a.objects.LabelWrapper _str = null;
 //BA.debugLineNum = 499;BA.debugLine="Sub viewguest( psearch As String)";
 //BA.debugLineNum = 501;BA.debugLine="cursor1 = sql1.ExecQuery(\"Select * from tblGuest WHERE Gname like '\" & psearch & \"%'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("Select * from tblGuest WHERE Gname like '"+_psearch+"%'")));
 //BA.debugLineNum = 502;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step436 = 1;
final double limit436 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step436 > 0 && _i <= limit436) || (step436 < 0 && _i >= limit436); _i += step436) {
 //BA.debugLineNum = 503;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 504;BA.debugLine="Dim nomi() As String";
_nomi = new String[(int)(0)];
java.util.Arrays.fill(_nomi,"");
 //BA.debugLineNum = 505;BA.debugLine="Dim str As Label";
_str = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 506;BA.debugLine="nomi = Array As String(cursor1.GetString(\"Gname\"))";
_nomi = new String[]{_cursor1.GetString("Gname")};
 //BA.debugLineNum = 507;BA.debugLine="txtGnameR.SetItems(nomi)";
mostCurrent._txtgnamer.SetItems(processBA,anywheresoftware.b4a.keywords.Common.ArrayToList(_nomi));
 }
};
 //BA.debugLineNum = 510;BA.debugLine="End Sub";
return "";
}
public static String  _viewrin(String _psearch) throws Exception{
int _i = 0;
String[] _nomi = null;
anywheresoftware.b4a.objects.LabelWrapper _str = null;
 //BA.debugLineNum = 608;BA.debugLine="Sub viewRIn( psearch As String)";
 //BA.debugLineNum = 609;BA.debugLine="cursor1 = sql1.ExecQuery(\"Select * from tblReservation WHERE GuestName like '\" & psearch & \"%'\")";
_cursor1.setObject((android.database.Cursor)(_sql1.ExecQuery("Select * from tblReservation WHERE GuestName like '"+_psearch+"%'")));
 //BA.debugLineNum = 611;BA.debugLine="For i = 0 To cursor1.RowCount - 1";
{
final double step516 = 1;
final double limit516 = (int)(_cursor1.getRowCount()-1);
for (_i = (int)(0); (step516 > 0 && _i <= limit516) || (step516 < 0 && _i >= limit516); _i += step516) {
 //BA.debugLineNum = 612;BA.debugLine="cursor1.Position = i";
_cursor1.setPosition(_i);
 //BA.debugLineNum = 613;BA.debugLine="Dim nomi() As String";
_nomi = new String[(int)(0)];
java.util.Arrays.fill(_nomi,"");
 //BA.debugLineNum = 614;BA.debugLine="Dim str As Label";
_str = new anywheresoftware.b4a.objects.LabelWrapper();
 //BA.debugLineNum = 615;BA.debugLine="nomi = Array As String(cursor1.GetString(\"GuestName\"))";
_nomi = new String[]{_cursor1.GetString("GuestName")};
 //BA.debugLineNum = 616;BA.debugLine="txtNameIn.SetItems(nomi)";
mostCurrent._txtnamein.SetItems(processBA,anywheresoftware.b4a.keywords.Common.ArrayToList(_nomi));
 }
};
 //BA.debugLineNum = 619;BA.debugLine="End Sub";
return "";
}
}
