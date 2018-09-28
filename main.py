import random

print('Please enter "yes" or "no"')
answer = input()

del answer # input is actually not important, just wasting time!!!

random = random.random()
if(random >= 0.25):
    print('50% sure real answer is "No"')
else:
    print('50% sure real answer is "Yes"')

# have fun
