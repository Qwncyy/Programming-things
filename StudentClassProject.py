import random

#Student class
class Student():
#__init__ variable names
    def __init__(self):
        self.studentdetails = {}
        self.load()
#return variables
    def __str__(self):
        return f"{self.ID},{self.name},{self.subject}" 
#get user inputs for the name    
    def addStudentDetails(self, ID, name, subject):
        self.studentdetails[str(ID)] = {"name": name, "subject": subject}
        self.save()
        

    


class Marks():

    def __init__(self):
        self.studentgrades = {}
        self.load
    
    def addStudentGrades(self, ID, name, subject, grade):
        self.studentgrades[str(ID)] = {"name": name, "subject": subject, "grade": grade}
        self.save

def menu():
    print("1. add student details")

def main():
    while True:
        try:
            menu()  
            if choice == "1":
                Student.addStudentdetails() 



        