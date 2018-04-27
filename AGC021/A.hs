import Control.Monad

main = do
    n <- getLine
    putStrLn.show $ f n
    
f n = (length n-1)*9 + g n where
    g n = if all (=='9') (tail n) || length n == 1 then read [head n] else read [head n] - 1