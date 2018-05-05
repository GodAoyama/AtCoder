import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

getNum = read <$> getLine :: IO Int
getNumList = map read.words <$> getLine :: IO [Int]

main = do
    [h,w] <- getNumList
    canvas <- getLineN h
    putStrLn.judge $ evaluate canvas h w
    
evaluate cs h w = all (== True) $ map f [(x,y) | x <- [0..h-1], y <- [0..w-1]] where
    f (x,y) = if cs .!! (x,y) == '.' then True else any (\pos -> cs .!! pos == cs .!! (x,y)) [(x-1,y),(x+1,y),(x,y+1),(x,y-1)]
    (.!!) cs (x,y) = if (x < 0 || x >= h || y < 0 || y >= w) then 'a' else (cs !! x) !! y    

judge True = "Yes"
judge False = "No"