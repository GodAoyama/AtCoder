import Control.Applicative
import Data.List
import Control.Monad

main = do
    [a,b,x] <- map read.words <$> getLine
    putStrLn $ if a + b >= x && a <= x then "YES" else "NO"
