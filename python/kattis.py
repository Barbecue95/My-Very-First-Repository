und = input();

count = 0;

for i in range(len(und)):
    for j in range(i):
        if und[i] == ")" and und[j] == ":" and und[i] == "(" and und[j] == ":":
            count += 1;
        elif und[i] == "(" and und[j] == ":":
            count -= 2;
        elif und[i] == ")" and und[j] == ":":
            count = 0;
        else:
            count += 2;

if count > 1:
    print("machine");
elif count > 0:
    print("alive");
elif count < 0:
    print("undead");
elif count == 0:
    print("double agent");



