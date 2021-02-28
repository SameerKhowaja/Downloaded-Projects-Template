#!/usr/bin/python
#-*- coding: utf-8 -*
print ("facture comptable coder par hicham berbache")
mb = float(input("Le montan brut:",))
rab = float(input("rabais:",))
rem = float(input("remise:",))
ris = float(input("ristourne:",))
esc = float(input("escompte:",))
ft = float(input("frais de transport:",))
tva = float(input("tva%:",))
consi = float(input("consignation:",))
net1 =mb-mb*rab
net2 = net1-net1*rem
net3 = net2-net2*ris
ct = net3+ft
net_finn = net3-net3*esc
TTC =ct+ct*tva
NAP =consi+TTC
if rab > 0 :
	print ("rabais:%r")% (mb * rab ) 
print ("net1:",net1)
if rem > 0 :
	print ("remise:%r")% (net1 * rem ) 
	print("net2:",net2)	
if ris > 0 :
	print ("ristourne:%r")% (net2 * ris ) 
	print ("net3:",net3)
if esc > 0 :
	print ("escompte:%r")% (net3 * esc ) 
	print ("net finnancier:",net_finn)
if ct > 0 :
	print ("cout total:%r")% (net_finn+ft) 
if tva > 0 :
	print ("tva:%r")% (ct* tva ) 
	print ("TTC:",TTC)
if consi > 0 :
	print ("Net a payer:",NAP)
print ("Fin")

	
	
