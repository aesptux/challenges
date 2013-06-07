digi_sum = lambda n: n if len(n) == 1 else digi_sum(str(sum(int(i) for i in n)))
