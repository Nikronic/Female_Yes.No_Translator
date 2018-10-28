module Main
    where
import System.Random

main = do
    putStrLn "Please enter 'yes' or 'no'"
    input <- getLine
    g <- newStdGen
    let (a, r) = randomR(0.0 :: Float, 1.0 :: Float) g
    
    if (a >= 0.5)
        then putStrLn "50% sure real answer is 'No'"
        else putStrLn "50% sure real answer is 'Yes'"