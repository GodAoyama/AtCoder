import Control.Applicative
import Data.List
import Control.Monad
import Data.Function
import Data.Array

main = do
    _ <- getLine
    s <- getLine
    putStrLn.show.minimum $ answer [(length $ filter (=='E') s)] ('A':s)

answer vs [x] = vs
answer vs@(v:_) (x:y:xs)
    | x == 'A' && y == 'W' = answer (v:vs) (y:xs)
    | x == 'A' && y == 'E' = answer (v-1:vs) (y:xs)
    | x == 'W' && y == 'W' = answer (v+1:vs) (y:xs)
    | x == 'W' && y == 'E' = answer (v:vs) (y:xs)
    | x == 'E' && y == 'W' = answer (v:vs) (y:xs)
    | x == 'E' && y == 'E' = answer (v-1:vs) (y:xs)