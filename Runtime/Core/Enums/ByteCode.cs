namespace YarnSpinnerGodot {
    public enum ByteCode {
        /// <summary>
      	/// opA = string: label name
        /// </summary>
        Label,
        /// <summary>
        /// opA = string: label name
        /// </summary>
        JumpTo,
        /// <summary>
        /// peek string from stack and jump to that label
        /// </summary>
        Jump,
        /// <summary>
        /// opA = int: string number
        /// </summary>
        RunLine,
        /// <summary>
        /// opA = string: command text
        /// </summary>
        RunCommand,
        /// <summary>
        /// opA = int: string number for option to add
        /// </summary>
        AddOption,
        /// <summary>
        /// present the current list of options, then clear the list; most recently
        /// selected option will be on the top of the stack
        /// </summary>
        ShowOptions,
        /// <summary>
        /// opA = int: string number in table; push string to stack
        /// </summary>
        PushString,
        /// <summary>
        /// opA = float: number to push to stack
        /// </summary>
        PushNumber,
        /// <summary>
        /// opA = int (0 or 1): bool to push to stack
        /// </summary>
        PushBool,
        /// <summary>
        /// pushes a null value onto the stack
        /// </summary>
        PushNull,
        /// <summary>
        /// opA = string: label name if top of stack is not null, zero or false, jumps
        /// to that label
        /// </summary>
        JumpIfFalse,
        /// <summary>
        /// discard top of stack
        /// </summary>
        Pop,
        /// <summary>
        /// opA = string; looks up function, pops as many arguments as needed, result is
        /// pushed to stack
        /// </summary>
        CallFunc,
        /// <summary>
        /// opA = name of variable to get value of and push to stack
        /// </summary>
        PushVariable,
        /// <summary>
        /// opA = name of variable to store top of stack in
        /// </summary>
        StoreVariable,
        /// <summary>
        /// Stops execution
        /// </summary>
        Stop,
        /// <summary>
        /// Run the node whose name is at the top of the stack
        /// </summary>
        RunNode
    }
}