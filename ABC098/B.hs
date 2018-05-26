import Control.Applicative
import Data.List
import Control.Monad
import Data.Function
import Data.Array

main = do
    _ <- getLine
    s <- getLine
    putStrLn.show.maximum $ map (answer s) [1..(length s-1)]

answer :: String -> Int -> Int
answer s k = length  $ filter (\v -> v `elem` s1 ) s2 where
    s1 = nub $ take k s
    s2 = nub $ drop k s