# 1 loop sum
def sum(arr):
  total = 0
  for x in arr:
    total += x
  return total

print(sum([1, 2, 3, 4]))

#2 recursive sum
def sum(list):
  if list == []:
    return 0
  return list[0] + sum(list[1:])

#3 recursive count
def count(list):
  if list == []:
    return 0
  return 1 + count(list[1:])

#4 recursive max
def max_(lst):
  if len(lst) == 0:
    return None
  if len(lst) == 1:
    return lst[0]
  else:
    sub_max = max_(lst[1:])
    return lst[0] if lst[0] > sub_max else sub_max

#5 quicksort
def quicksort(array):
  if len(array) < 2:
    # base case, arrays with 0 or 1 element are already "sorted"
    return array
  else:
    # recursive case
    pivot = array[0]
    # sub-array of all the elements less than the pivot
    less = [i for i in array[1:] if i <= pivot]
    # sub-array of all the elements greater than the pivot
    greater = [i for i in array[1:] if i > pivot]
    return quicksort(less) + [pivot] + quicksort(greater)

print(quicksort([10, 5, 2, 3]))
