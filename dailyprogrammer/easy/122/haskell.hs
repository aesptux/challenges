import Data.Char

digitalRoot :: Int -> Int
digitalRoot n
    | n > 9 = digitalRoot (sum . map digitToInt $ show n)
    | n <=9 = n


sumDigitsv2 :: Integer -> Integer
sumDigitsv2 0 = 0
sumDigitsv2 n = if mod n 9 == 0 then 9 else mod n 9