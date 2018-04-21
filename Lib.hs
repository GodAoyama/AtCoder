import Control.Applicative
import Data.List
import Control.Monad

inputTuple n = map (listToTuple.map read).map words <$> getLineN n

listToTuple :: [a] -> (a,a)
listToTuple [a,b] = (a,b)
    
getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

minl,maxl :: [Int] -> Int
minl = foldl min maxBound
maxl = foldl max minBound
