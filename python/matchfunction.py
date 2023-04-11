name = input();

match name:
    case "Harry" | "Hermonie" | "Ron":
        print("Gryffindor");
    case "Draco":
        print("Slytherin");
    case _:
        print("Who?");