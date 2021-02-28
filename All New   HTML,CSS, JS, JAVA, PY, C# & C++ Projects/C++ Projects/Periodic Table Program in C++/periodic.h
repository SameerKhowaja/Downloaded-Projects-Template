#include<iostream>
#include<stdlib.h>
using namespace std;

//==============================================================Atomic=======================================================//
int main()
{
	system("cls");
	char a[][115]= {{" 0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001111111111"},
					{" 0000000001111111111222222222233333333334444444444555555555566666666667777777777888888888899999999990000000000"},
					{" 1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789"},
					{" HHLBBCNOFNNMASPSCAKCSTVCMFCNCZGGASBKRSYZNMTRRPACISSTIXCBLCPNPSEGTDHETYLHTWROIPAATPBPAPFRATPUNPACBCEFMNLRDSBHM"},
					{"  eie     eagli  lr aci rneoiunaeserrbr rbocuhdgdnnbe esaaerdmmudbyormbufa esrtugibiotnratha pummkfsmdorfbghst"},
					{" 1479111112222233333444555565667777888889999111111111111111111111111111111111111222222222222222222222222222   "},
					{"     024690347802589058125609350259046891368000011122233334444555566667778889999000001222233334444455556666   "},
					{"                                            136835918713790145027935793581460257047890236721874377247890125   "},
					{" HHLBBCNOFNSMASPSCAPCSTVCMICNCZGGASBKRSYZNMTRRPSCITATIXCBLCPNPSEGTDHETYLHTTROIPGMTLBPARFRATPUNPACBCEFMNLRDSBHM"},
					{" yeieoaixleoalihuhroaciaharoioiaererruttiioeuhaianineoeaaaererauaeyorhtuaauhsrloeheiosarachrrelmueaieeoauueoae"},
					{" dltrrrtyuodgulollgtlatnrnobcpnlrsloybrtrolctollddntldnernraoomrdrslbuttfnnemialraasltdadtooapuerrlnrnbwtbahsi"},
					{" rihyobrgoninmisfooacnaaognakpclmeempiorcbyhhdlvmi iliositisdmaoobpmileentgniitdcldmoaoniirtnttrikismderhnbrst"},
					{" ouilnooer ueicpurnsidndma lee iannitdnioibneiaeiu munniuhueyerpririuirtiasiuii ul untniuniaiuoiueftieleeiuiin"},
					{" gmul ngni msnohri suiiiin tlr uniinoitunudenudrum ore umamomtiiiuoumubiultumun ri tii umiucunncmpoeulinruruue"},
					{" e mi  e n  iino n imuuuue     micuenuimimetimi m  ni  m n dihuunmsm miumuem mu yu hun m umtmiii irimeucfmgmmr"},
					{" n  u  n e  uu r e u mmmms      u m  mu u niu u    yu    u yuimmi i   um mn   m  m  me   m i uuu unn vmio i  i"},
					{"    m       mm u   m     e      m     m m uum m     m    m mmu  u u   m                    n mmm mii i ur u  u"},
					{"               s                          mm               i m  m m                        i      uu u md m  m"},
					{"                                                           u                               u      mm m  i     "},
					{"                                                           m                               m            u     "},
					{"                                                                                                        m     "},
					{" 3221232313131314233615241415252516262415173716282128191724172727171616172527261724122314121326262411211111111"},
					{"                                                  0                                                           "}};
	
	int x;
	cout<<endl<<"Enter Atomic Number"<<endl;
	cin>>x;
	
	if(x>=0 && x<=109)
	{
    cout<<"Atomic no   =    ";
	for(int i=0 ;i <3;i++)
	{   
		cout<<i[a][x];
	}
	cout<<endl<<"Symbol      =    ";
	for(int i=3;i <5;i++)
	{
		
		cout<<i[a][x];

	}
	cout<<endl<<"Atomic Mass =    ";
	for(int i=5;i <8;i++)
	{
	
		cout<<i[a][x];
	
	}
	cout<<endl<<"Name        =    ";
	for(int i=8;i <21;i++)
	{

		cout<<i[a][x];

	}
	cout<<endl<<"Isotops     =    ";
	for(int i=21;i <23;i++)
	{
		cout<<i[a][x];
	}
	cout<<endl<<endl;
	}
	else
		cout<<endl<<"Not Discovered Yet"<<endl;
	int w; cin >>w;
	return 0;
	//system("pause");

}
