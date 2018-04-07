import Control.Applicative
import Data.List
import Control.Monad

main = do
    nums@[a,b,c] <- sort.map read.words <$> getLine :: IO [Int]
    if c == a && c == b then putStrLn "0" else putStrLn.show $ count 0 [a,b,c]

count n [a,b,x] = if a' == x && b' == x then (n+1) else count (n+1) nums where
    nums = sort [x,a',b']
    x' = foldl max 0 [x,a',b']
    (a',b') = if (x >= a+2) then (a+2,b) else  (a+1,b+1)