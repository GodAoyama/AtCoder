import Data.Array.IO
import Control.Applicative
import Data.List
import Control.Monad

getNum = read <$> getLine :: IO Int

main = do
    n <- getNum
    putStrLn.format.take n $ filter ((==1).flip mod 5) $ eratosthenes 55555

format [] = []
format (x:xs) = show x ++ " " ++ format xs

eratosthenes :: Integer -> [Integer]
eratosthenes n =
    let primes = [2..n]
        recursion ms = 
          case ms of
            [] -> []
            (m:_) -> m : recursion [x | x <- ms, x `mod` m /= 0]
    in  recursion primes