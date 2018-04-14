import Control.Applicative
import Data.List
import Control.Monad

main = do
    [n,_,x] <- map read.words <$> getLine :: IO [Int]
    costs <- map read.words <$> getLine :: IO [Int]
    let cc = map (f costs) [1..n]
    putStrLn.show $ g x cc

f costs x = if x `elem` costs then 1 else 0
g x costs = min (sum (take x costs)) (sum (drop (x-1) costs))

answer bb x = sum $ map fst $ drop (x-1) bb