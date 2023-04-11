class Flight():
    def __init__(self, capacity):
        self.capacity = capacity;
        self.passengers = [];

    def add_passengers(self, name):
        if not self.open_seats():
            return False;
        self.passengers.append(name)
        return True;

    def open_seats(self):
        return self.capacity - len(self.passengers);

flight = Flight(4);

people = ['Yumi', 'Barbe', 'SoeDarleAung', 'KaungHtetZin', 'JJ'];

for person in people:

    if flight.add_passengers(person):
        print(f'Added {person} to passenger list successfully.');
    else:
        print(f'No seats are available for {person}.');
        
        