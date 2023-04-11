vowels = ['a','e','i','o','u'];

insert = input().lower();

result = 0;

for i in range(len(insert)):
    if insert[i] in vowels:
        result += 1;

print(result);