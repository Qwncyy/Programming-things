import sqlite3

file = "contacts.db"
con = sqlite3.connect(file)
cur = con.cursor()
cur.execute("CREATE TABLE IF NOT EXISTS contacts (name, phone, address, email)")

def add(name, phone, address, email): cur.execute(f"INSERT INTO contacts VALUES('{name}', '{phone}', '{address}', '{email}')"); con.commit(); print(f"{name} has been added to contacts.")
def delete(name): res = advanced_search(name); (cur.execute(f"DELETE FROM contacts WHERE name = '{res[0]}' AND phone = '{res[1]}' AND address = '{res[2]}' AND email = '{res[3]}'"), con.commit(), print(f"{name} has been attempted to be deleted from the database")) if res else print("This user was not found")
def view(): [print(contact) for contact in cur.execute("SELECT * FROM contacts").fetchall()]
def search(name): [print(contact) for contact in cur.execute(f"SELECT * FROM contacts WHERE name = '{name}'").fetchall()]
def modify(name): res = advanced_search(name); (cur.execute(f"UPDATE contacts SET name = '{input('name: ')}', phone = '{input('phone: ')}', address = '{input('address: ')}', email = '{input('email: ')}' WHERE name = '{res[0]}' AND phone = '{res[1]}' AND address = '{res[2]}' AND email = '{res[3]}'"), con.commit(), print(f"Modified contact {name} has been modified")) if res else print("This user was not found")
def advanced_search(query): res = cur.execute(f"SELECT * FROM contacts WHERE name = '{query}'").fetchall(); return res[0] if len(res) == 1 else res[int(input("Enter option"))] if res and input("Enter option").isdigit() and int(input("Enter option")) in range(len(res)) else None
def menu(): print("""1. Contact add\n2. Delete contact\n3. Search\n4. Modify\n5. View all\n"""); options = {"1": lambda: add(input("name: "), input("phone: "), input("address: "), input("email: ")), "2": lambda: delete(input("name: ")), "3": lambda: search(input("name: ")), "4": lambda: modify(input("query: ")), "5": view}; options.get(input("")).__call__(); con.commit()

while True: menu()

