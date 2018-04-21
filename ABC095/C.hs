import Control.Applicative
import Data.List
import Control.Monad

main = getLine >>= putStrLn.show.answer.map read.words

answer :: [Int] ->Int
answer [a, b, c, x, y] = (a*x+b*y) `min` calc `min` allC where
    allC = 2*c * max x y
    xycount = (min x y)
    calc = 2*c * xycount + a*(x-xycount) + b*(y-xycount)
    