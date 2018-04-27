namespace FSharpLibrary


/// Regular Single Case Union
type EmailAddress = EmailAddress of string

/// Struct version of the above
[<Struct>]
type StructEmailAddress = StructEmailAddress of string

/// Regular Single Case Union with a private constructor
type PrivateEmailAddress = private PrivateEmailAddress of string
    with member this.Value = let (PrivateEmailAddress g) = this in g

/// Struct version of the above with a private constructor
[<Struct>]
type PrivateStructEmailAddress = private PrivateStructEmailAddress of string
    with member this.Value = let (PrivateStructEmailAddress g) = this in g

/// An aggregate that creates properties with private constructors
type ClassAggregateWithPrivates = {
    PrivateEmailAddress: PrivateEmailAddress
    PrivateStructEmailAddress: PrivateStructEmailAddress
}
    with
    static member Create
        emailAddress =
        
        {
            PrivateEmailAddress = PrivateEmailAddress emailAddress
            PrivateStructEmailAddress = PrivateStructEmailAddress emailAddress
        }
