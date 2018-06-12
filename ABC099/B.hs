import Control.Applicative
import Data.List
import Control.Monad
import Data.Function
import Data.Array

main = getLine >>= putStrLn.show.answer.map read.words

answer [a,b] = b2 - b where
    n = b-a
    b2 = sum [1..n]