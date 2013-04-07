def byte_exchange(coin):
    print 'COIN {0}'.format(coin)
    print coin/2
    print coin/3
    print coin/4

    return 1 if coin == 0 else byte_exchange(coin/2) + byte_exchange(coin/3) + byte_exchange(coin/4)
