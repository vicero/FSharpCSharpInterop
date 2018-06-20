namespace FSharpLibrary

[<Struct>]
type ThisIsAValueType = ThisIsAValueType of string

type StructContainer = {
    ValueTypeProperty: ThisIsAValueType option
}