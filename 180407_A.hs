import Control.Applicative
import Data.List
import Control.Monad

main = do
    putStrLn.judge.sort =<< getLine
judge str = if str == "abc" then "Yes" else "No"