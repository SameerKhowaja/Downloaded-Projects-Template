

Coins=10

print('You have',Coins,'coins.')
TEXT=input("Type 5 numbers ")
print('Your number is:',TEXT)

print('\nSee if your number showed up. If didnt show up sorry. Alon-Sorry I cant change the code to help you win')

#generate 5 random numbers
import random
for x in range(0, 5):
    random_number=random.randint(10000, 99999)
    print(random_number)

print("Now youll see if you won:")
if TEXT==random_number:
	print('You won')
else:
	print('You didnt win')
	
if random_number != TEXT:
	Lottery_Lost=((Coins)-10)
else:
	Lottery_Winnings=((Coins)+10)
	
if random_number != TEXT:
	print('This is how many coins you have:',Lottery_Lost)
else:
	print('You have this many coins:',Lottery_Winnings)

if (random_number) == TEXT:
	Lottery_Tot=(Lottery_Winnings)
else:
	Lottery_Tot=(Lottery_Lost)

if(Lottery_Tot) == 0:
	print('Sorry you lost')

if (Lottery_Tot) == 20:
	print('You won money!!!')
	