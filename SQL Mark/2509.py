import sqlite3

connection = sqlite3.connect("aquarium.db")

cursor =connection.cursor()

cursor.execute("CREATE TABLE fish (name TEXT.species TEXT. tank number, INTEGER)")
cursor.execute("INSERT INTO faish VALUES('Sammy', 'shark'. 1)")
cursor.execute("INSERT Into fish VALUES('Jamie',m)")

rows=cursor.execute("SELECT name, species, tank_number FROM fish").fetchall()
cursor.close
print("rows")