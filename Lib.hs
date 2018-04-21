import Control.Applicative
import Data.List
import Control.Monad


--f :: Num a => Int -> IO [(a,a)]
inputTuple n = map (listToTuple.map read).map words <$> getLineN n

listToTuple :: [a] -> (a,a)
listToTuple [a,b] = (a,b)
    
getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine