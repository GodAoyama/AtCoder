import Control.Applicative
import Data.List
import Control.Monad

main = do
    [a,b,k] <- map read.words <$> getLine :: IO [Int]
    mapM_ putStrLn (calc a b k)

calc a b k = nub $ map show ([a..(min (a+k-1) b)] ++[(max (b-k+1) a)..b])