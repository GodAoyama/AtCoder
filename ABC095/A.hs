import Control.Applicative
import Data.List
import Control.Monad

main = do
    n <- getLine
    putStrLn.show $ 700 + 100 * (length $ filter (=='o') n)