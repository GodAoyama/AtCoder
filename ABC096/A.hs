import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

getNum = read <$> getLine :: IO Int
getNumList = map read.words <$> getLine :: IO [Int]

main = do
    [a,b] <- getNumList
    putStrLn.show $ length $ filter (\c -> c < a || (c <= a && c <= b)) [1..12]