namespace FsToolkit.ErrorHandling.Operator.Option

open FsToolkit.ErrorHandling

[<AutoOpen>]
module Option =
    let inline (<!>)
        (([<InlineIfLambda>] mapper: 'input -> 'output))
        (input: Option<'input>)
        : Option<'output> =
        Option.map mapper input

    let inline (<*>)
        (applier: Option<'input -> 'output>)
        (input: Option<'input>)
        : Option<'output> =
        Option.apply applier input

    let inline (>>=)
        (input: Option<'input>)
        ([<InlineIfLambda>] binder: 'input -> Option<'output>)
        : Option<'output> =
        Option.bind binder input
