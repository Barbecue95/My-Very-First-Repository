people = [
    {"name": "Herry" , "House": "Gryffindor"},
    {"name": "Ron" , "House": "Gryffindor"},
    {"name": "Cho" , "House": "Gryffindor"},
];

people.sort(key = lambda person: person["name"])

print(people);


