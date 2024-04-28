module CarsAssemble

let successRate (speed: int): float =
    match speed with
    | 0 -> 0
    | _ when speed >= 1 && speed <= 4 -> 1
    | _ when speed >= 5 && speed <= 8 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> failwith "Invalid speed setting"

    

let productionRatePerHour (speed: int): float =
    float (speed * 221) * successRate speed

let workingItemsPerMinute (speed: int): int =
    let perMinute = productionRatePerHour speed / float 60
    int perMinute
