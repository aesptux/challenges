byteExchange :: (Integral a, Num a1) => a -> a1
byteExchange 0 = 1
byteExchange n = byteExchange(n `div` 2) + byteExchange(n `div` 3) + byteExchange(n `div` 4)