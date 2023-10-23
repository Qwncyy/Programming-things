
def main_menu():
    choice = int(input("1.Manage Teams\n2.Show drivers wages\n"))
    if choice == 1:
        car_teams()
    elif choice == 2:
        Drivers_and_Wages()   


def car_teams():
    Teams = ["Ferrari", "Williams", "Haas","Aston Martin"]
    print(Teams)
    #Who is getting the bonus
    print("Current bonus payment: ",Teams[0])
    #Who is team 1's rival
    print("Their rival is Team", Teams[1])
    #Append 2 more teams
    Teams.append("Nissan")
    Teams.append("Toyota")
    print(Teams)
    #Ask for user input to replace team
    choice = int(input("Which team form 1 - 5 do you want to replace?"))
    del Teams[choice]
    User_team = input("What team would you like to input?\n")
    Teams.append(User_team)
    print(Teams)
def Drivers_and_Wages():
    TotalWage = 0
    #drivers and wages
    Driver = ["Sebastian Vettel", "Charles Leclerc", "Kevin Magnussen", "Lando Norris"]
    Wages = ["21", "17", "3", "5"]

    #tuple combination
    D_and_W = [Driver, Wages]
    #looping the print of drivers and wages
    for x, y in zip(Driver, Wages):
        print(x,y, "million")

while True:
    main_menu()