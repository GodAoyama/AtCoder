import Control.Applicative
import Data.List
import Control.Monad

main = do
    [n,x] <- map read. words <$> getLine
    ms <- f n
    let (v,rest) = (sum ms, x- sum ms)
    putStrLn.show $ n + (makeSweet rest ms)

makeSweet rest ms = rest `div` (head $ sort ms)

f :: Int -> IO [Int]
f 0 = return []
f n = do
    v <- read <$> getLine
    vs <- f (n-1)
    return (v:vs)