import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

getNum = read <$> getLine :: IO Int
getNumList = map read.words <$> getLine :: IO [Int]

main = do
    n <- getNum
    xs <- getNumList
    putStrLn.show $ sum $  map answer (tails xs)

answer xs = fst $  foldl f (0,0) xs where
    f (cnt, v) x = if v + x == 0 then (cnt+1,v+x) else (cnt,v+x)