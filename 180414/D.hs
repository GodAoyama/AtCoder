import Control.Applicative
import Data.List
import Control.Monad


main = do
    n <- read <$> getLine :: IO Int
    xs <- map read.words <$> getLine :: IO [Int]
    let v = foldl max (-1) xs
    putStrLn.format $ f v (delete v xs)

format (a,b) = show a ++ " " ++ show b

f v xs = foldl g (v,0) xs where
    g (n,x) y = if a < c  then (n,x) else (n,y) where 
        a = (abs $ (n-x) - (div n 2)) `min` (abs $ x - (div n 2)) 
        c = (abs $ (n-y) - (div n 2)) `min` (abs $ y - (div n 2)) 