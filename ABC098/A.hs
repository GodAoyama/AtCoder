import Control.Applicative
import Data.List
import Control.Monad
import Data.Function
import Data.Array

main = getLine >>= putStrLn.show.answer.map (read :: String -> Int).words

answer [a,b] = maximum [a+b,a-b,a*b]