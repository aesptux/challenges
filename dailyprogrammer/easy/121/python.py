def byte_exchange(coin):
    return 1 if coin == 0 else byte_exchange(coin/2) + byte_exchange(coin/3) + byte_exchange(coin/4)
