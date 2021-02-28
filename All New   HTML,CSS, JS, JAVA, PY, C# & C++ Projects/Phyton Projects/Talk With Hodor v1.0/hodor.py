print('Talk with Hodor! v1.0')
while True:
 answer=input('You: ')
 if len(answer)>10:
    print('Hodor: Hodor Hodor!')
 elif len(answer)==6:
    print('Hodor: Hodor?')
 elif 'how' in answer:
    print('Hodor: Hold the door!')
 elif answer=='Hodor':
    print('Hodor: Oh, I can speak!')
    break
 else:
    print('Hodor: Hodor!')