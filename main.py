import random

print('Please enter "yes" or "no"')
answer = input()

random = random.random()
if answer=='yes':
    if(random >= 0.25):
        print('Real answer is "No"')
    else:
        print('Real answer is "Yes"')
elif answer=='no':
    if(random >= 0.25):
        print('Real answer is "Yes"')
    else:
        print('Real answer is "No"')
else:
    print('Please at least provide yes or no! God damn!')

# have fun