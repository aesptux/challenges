def digital_root(n):
    return n if n < 10 else digital_root(sum([int(x) for x in str(n)]))


def digital_root2(n):
    return n-9*((n-1)/9)
