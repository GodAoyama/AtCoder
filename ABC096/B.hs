import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

getNum = read <$> getLine :: IO Int
getNumList = map read.words <$> getLine :: IO [Int]

main = do
    xs <- getNumList
    k <- getNum
    let v = maximum xs
    putStrLn.show $ v*2^k + sum (delete v xs)
no = "No"
yes = "Yes"

