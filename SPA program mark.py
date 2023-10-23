import sqlite3


def main():
#inputting customer details and putting them into a table
def customer_details():
    DOB = (Day,"/", Month,"/" Year)
    
#the customer details
    print("------Input Customer Details---")
    customer_Name = input("Enter Customer Name: ")
    Day = int(input("Enter Day of Birth: "))
    Month = int(input("Enter Month of Birth: "))
    Year = int(input("Enter Year of Birth: "))
    Address = input("Enter Address: ")
    Phone = int(input("Enter Phone Number: "))
    email = input("Enter Email Address: ")
    
    customer = (customer_Name, Day, Month, Year, Address, Phone, email)

#saving them to a database
conn = sqlite3.connect("customer.db")
cursor = conn.cursor()

cursore.execute("CREATE TABLE IF NOT EXISTS customer (customer_name TEXT, DOB INTEGER,Address TEXT, Phone INTEGER, email TEXT)")
cursor.execute("INSERT INTO customer VALUES (customer_name,DOB,Address,Phone,email)", customer)

rows = cursor.execute("SELECT * FROM customer").fetchall()
cursor.close()
def menu():
    print("1.Input Customer Details \n2.Choose Car\n3.Search customer details\n4.Search for car")
