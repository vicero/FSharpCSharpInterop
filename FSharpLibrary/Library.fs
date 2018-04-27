namespace FSharp


// Regular Single Case Union
type EmailAddress = EmailAddress of string

// Struct version of the above
[<Struct>]
type StructEmailAddress = EmailAddress of string
