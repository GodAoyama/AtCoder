import Control.Applicative

data Hanoi = A [Int] | B [Int] | C [Int] deriving (Eq)

instance Show Hanoi where
    show (A xs) = "A"
    show (B xs) = "B"
    show (C xs) = "C"

hanoi :: Int -> [Hanoi] -> IO ()
hanoi k [t1,t2,t3] = if k >= 1
    then do
        hanoi (k-1) [tail' t1,t3,head' t1.:t2]
        putStrLn (show k ++ ": from " ++ show t1 ++ " to " ++ show t3)
        hanoi (k-1) [t2,t1,t3]
    else
        return ()

(.:) v (A xs) = A (v:xs)
(.:) v (B xs) = B (v:xs)
(.:) v (C xs) = C (v:xs)

tail' (A xs) = A (tail xs)
tail' (B xs) = B (tail xs)
tail' (C xs) = C (tail xs)

head' (A (x:xs)) = x
head' (B (x:xs)) = x
head' (C (x:xs)) = x

main = do
    n <- read <$> getLine
    hanoi n [A [1..n],B [], C []]