main = getLine >>= putStrLn.show.answer.(read :: String -> Int)

answer n = minimum $ n:map (f 0) (zip [0..n] [0..n]) where
    f v (i,nn) = if i > 0 then f (v+mod i 6) (div i 6,nn) else g v (n-nn)
    g v i = if i > 0 then g (v+mod i 9) (div i 9) else v