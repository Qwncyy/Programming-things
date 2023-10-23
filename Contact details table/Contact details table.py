import sqlite3
import random
from prettytable import from_db_cursor
#connect 
db = sqlite3.connect("Contacts.db")

cursor = db.cursor()


db.execute("CREATE TABLE IF NOT EXISTS ContactDetails(ContactID INTEGER, Name TEXT, Phone TEXT, Email TEXT, Address TEXT)")
def main_menu():

    while True:
            try:
                choice = int(input("1. Add Contact\n2. Search Contact\n3.Show all contacts\n4.Delete a contact\n"))
                 
                if choice == 1:
                        add_contact()
                elif choice == 2:
                     search_contact()
                elif choice == 3:
                     show_contact()
                elif choice == 4:
                     delete_contact()

            except ValueError:
                print("Please enter a valid choice")


#Insert a new contact
def add_contact():
    id = random.randint(1, 9999999)
    id = str(id)
    name = input("Enter Name: ")
    phone = input("Enter Phone: ") 
    email = input("Enter Email: ")
    address = input("Enter Address: ")


    db.execute("INSERT INTO ContactDetails(ContactID, Name, Phone, Email, Address) VALUES(?,?,?,?,?)", (id, name, phone, email, address))
    print("New Contact Added")
    
def search_contact(): 
    try:
        choice = input("Search by Name or ID:\n1.Name\n2.ID\n ")
        
        if choice == '1':
            Name_search()
        elif choice == '2':
            ID_Search()
        else:
            print("Invalid input")
    except ValueError:
        print("Please input valid choice")
def delete_contact():
    try:
         Delete_contact = input("Search ID or name to delete: \n1.ID\n2.Name\n")
         if Delete_contact == '1':
              delete_by_ID()
         elif Delete_contact== '2':
              delete_by_name()
         else:
              print("Invalid Choice")
    except ValueError:
         print("Invalid Choice")
        

def delete_by_ID():
    try:
        ContactID = input("Enter contact ID\n")
        success = db.execute(f"DELETE FROM ContactDetails WHERE ContactID = '{ContactID}'")
        return success
    finally:
        print("Contact Successfully deleted")
def delete_by_name():
    try:
        Name = input("Enter contact Name\n")
        success = db.execute(f"DELETE FROM ContactDetails WHERE Name = '{Name}'")
        return success
    finally:
        print("Contact Successfully deleted")


def ID_Search():
        try:
            ContactID = input("Enter Contact ID: ")
            result = db.execute(f"SELECT * FROM ContactDetails WHERE ContactID = '{ContactID}'").fetchall()
            
            if result:
                print("Printing ID: ", result)
            else:
                print("Contact does not exist")
        
        except sqlite3.Error as error:
            print("Contact not found", error)
def Name_search():
        try:
            Name = input("Enter Contact Name: ")
            result = db.execute(f"SELECT * FROM ContactDetails WHERE Name = '{Name}'").fetchall()
            
            if result:
                print("Printing ID: ", result)
            else:
                print("Contact does not exist")
        
        except sqlite3.Error as error:
            print("Invalid choice", error)    
     
def show_contact():
         #Create a table
    rows = cursor.execute("SELECT * FROM ContactDetails")
    mytable = from_db_cursor(cursor)
    print(mytable)
    db.commit()

#Search for contact

while True:
     main_menu()
