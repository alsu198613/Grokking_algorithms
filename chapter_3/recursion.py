# 1 countdown
def countdown(i):
  # base case
  if i <= 0:
    return 0
  # recursive case
  else:
    print(i)
    return countdown(i-1)

countdown(5)

# 2 greet
def greet2(name):
    print("how are you, ", name, "?")

def bye():
    print("ok bye!")

def greet(name):
    print("hello, ", name, "!")
    greet2(name)
    print("getting ready to say bye...")
    bye()

greet("adit")

# 3 fact
def fact(x):
  if x == 1:
    return 1
  else:
    return x * fact(x-1)

print(fact(5))

# 4 count
def count(arr):
    if not arr:
        return 0
    return 1 + count(arr[1:])

# 5 binary_search
def binary_search(arr, target):
    if not arr:
        return -1

    low = 0
    high = len(arr) - 1
    mid = (low + high) // 2

    if arr[mid] == target:
        return target
    elif arr[mid] > target:
        return binary_search(arr[:mid], target)
    else:
        return binary_search(arr[mid+1:], target)


print(binary_search([6, 7, 8, 9, 10], 8))
print(binary_search([6, 7, 8, 9, 10], 6))

# 6 find_max
def find_max(arr):
    if len(arr) == 0:
        return 0
    elif len(arr) == 1:
        return arr[0]
    elif len(arr) == 2:
        return arr[0] if arr[0] > arr[1] else arr[1]
    sub_max = find_max(arr[1:])
    return arr[0] if arr[0] > sub_max else sub_max

# 7 sum_array
def sum_array(arr):
    if not arr:
        return 0
    return arr[0] + sum_array(arr[1:])