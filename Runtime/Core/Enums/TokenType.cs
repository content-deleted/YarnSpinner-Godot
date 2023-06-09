namespace YarnSpinnerGodot {
    public enum TokenType {
        // 0 Special tokens
        Whitespace,
        Indent,
        Dedent,
        EndOfLine,
        EndOfInput,
        // 5 Numbers. Everybody loves a number
        Number,
        // 6 Strings. Everybody also loves a string
        Str,
        // 7 '#'
        TagMarker,
        // 8 Command syntax ("<<foo>>")
        BeginCommand,
        EndCommand,
        // 10 Variables ("$foo")
        Variable,
        // 11 Shortcut syntax ("->")
        ShortcutOption,
        // 12 Option syntax ("[[Let's go here|Destination]]")
        OptionStart,  // [[
        OptionDelimit,  // |
        OptionEnd,  // ]]
        // format functions are proccessed further in the compiler
        FormatFunctionStart,  // [
        FormatFunctionEnd,  // ]
        // for inline Expressions
        ExpressionFunctionStart,  // {
        ExpressionFunctionEnd,  // }
        // 15 Command types (specially recognised command word)
        IfToken,
        ElseIf,
        ElseToken,
        EndIf,
        Set,
        // 20 Boolean values
        TrueToken,
        FalseToken,
        // 22 The null value
        NullToken,
        // 23 Parentheses
        LeftParen,
        RightParen,
        // 25 Parameter delimiters
        Comma,
        // 26 Operators
        EqualTo,  // ==, eq, is
        GreaterThan,  // >, gt
        GreaterThanOrEqualTo,  // >=, gte
        LessThan,  // <, lt
        LessThanOrEqualTo,  // <=, lte
        NotEqualTo,  // !=, neq
        // 32 Logical operators
        Or,  // ||, or
        And,  // &&, and
        Xor,  // ^, xor
        Not,  // !, not
        // this guy's special because '=' can mean either 'equal to'
        // 36 or 'becomes' depending on context
        EqualToOrAssign,  // =, to
        // 37
        UnaryMinus,  // -; this is differentiated from Minus
        // when parsing expressions
        //38
        Add,  // +
        Minus,  // -
        Multiply,  // *
        Divide,  // /
        Modulo,  // %
        // 43
        AddAssign,  // +=
        MinusAssign,  // -=
        MultiplyAssign,  // *=
        DivideAssign,  // /=
        Comment,  // a run of text that we ignore
        Identifier,  // a single word (used for functions)
        Text  // a run of text until we hit other syntax
    }
}