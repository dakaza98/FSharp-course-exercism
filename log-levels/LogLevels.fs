module LogLevels

let message (logLine: string): string = 
    let message = logLine.Split(':')[1] in
    message.Trim()

let logLevel(logLine: string): string = 
    let logLevel = logLine.Split(":")[0] in
    logLevel
        .Replace("[", "")
        .Replace("]", "")
        .ToLower()

let reformat(logLine: string): string = 
    let logLevel = logLevel logLine
    let message = message logLine in 
    $"{message} ({logLevel})"
