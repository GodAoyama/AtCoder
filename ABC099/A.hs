import Control.Applicative
import Data.List
import Control.Monad
import Data.Function
import Data.Array

main = getLine >>= putStrLn.answer.map read.words

answer [a] = if a >= 1000 then "ABD" else "ABC"


getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine