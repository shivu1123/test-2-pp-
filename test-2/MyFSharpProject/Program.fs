type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport


type Director = {
    Name: string
    Movies: int
}


type Movie = {
    Name: string
    RunLength: int 
    Genre: Genre
    Director: Director
    ImdbRating: float
}


let director1 = { Name = "Steven Spielberg"; Movies = 33 }
let director2 = { Name = "Christopher Nolan"; Movies = 12 }
let director3 = { Name = "Todd Phillips"; Movies = 15 }


let movies = [
    { Name = "KRISH-3 "; RunLength = 124; Genre = Horror; Director = director1; ImdbRating = 8.1 }
    { Name = "Koi Mil Gaya"; RunLength = 148; Genre = Thriller; Director = director2; ImdbRating = 8.8 }
    { Name = "GrassHopper"; RunLength = 100; Genre = Comedy; Director = director3; ImdbRating = 7.7 }
]


let oscarWinners = 
    movies 
    |> List.filter (fun movie -> movie.ImdbRating > 7.4)


let convertToHoursMinutes runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let runLengthsConverted = 
    movies 
    |> List.map (fun movie -> movie.Name, convertToHoursMinutes movie.RunLength)


printfn "Oscar Winners:"
oscarWinners 
|> List.iter (fun movie -> printfn "%s (%.1f)" movie.Name movie.ImdbRating)


printfn "\nRun Lengths in Hours and Minutes:"
runLengthsConverted
|> List.iter (fun (name, formattedTime) -> printfn "%s: %s" name formattedTime)