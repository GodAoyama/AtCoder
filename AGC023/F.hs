import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getLineN :: Int -> IO [String]
getLineN n = replicateM n getLine

getNum = read <$> getLine :: IO Int
getNumList = map read.words <$> getLine :: IO [Int]

data Tree = Node Index Int Tree Tree | Nil deriving (Eq,Show)
type Index = Int

main = do
    _ <- getNum
    ps <- getNumList
    (v:vs) <- getNumList
    let tree =  foldl mkTree (Node 1 v Nil Nil) $ zip3 [2..] ps vs
    putStrLn.show $ sum.map f.tails.openTree $ tree

mkTree (Node p1 v1 Nil Nil) (i,p,v) = if p1 == p then Node p1 v1 (Node i v Nil Nil) Nil else Node p1 v1 Nil Nil
mkTree (Node p1 v1 a Nil) (i,p,v) = if p1 == p then Node p1 v1 a (Node i v Nil Nil) else Node p1 v1 (mkTree a (i,p,v)) Nil
mkTree (Node p1 v1 a b) (i,p,v) = Node p1 v1 (mkTree a (i,p,v)) (mkTree b (i,p,v))

openTree :: Tree -> [Int]
openTree (Nil) = []
openTree (Node _ v a b)
    | b /= Nil = openTree b ++ [v] ++ openTree a
    | b == Nil = v:openTree a

f [] = 0
f (0:xs) = 0
f (1:xs) = length xs - sum xs

--mergeTree a b = if a == Nil then b else a