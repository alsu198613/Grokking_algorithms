#1 price of grosseries
book = {"apple": 0.67, "milk": 1.49, "avocado": 1.49}
print(book)

#2 check voted
voted = {}
def check_voter(name):
  if voted.get(name):
    print("kick them out!")
  else:
    voted[name] = True
    print("let them vote!")

check_voter("tom")
check_voter("mike")
check_voter("mike")