using System;
using System.Collections;
using System.Collections.Generic;
using Godot;

namespace Yarn.GodotYarn {
    interface ICommandDispatcher : IActionRegistration {
        CommandDispatchResult DispatchCommand(string command, out Delegate commandCoroutine, out object[] parameters);

        void SetupForProject(YarnProject yarnProject);

        IEnumerable<ICommand> Commands { get; }
    }
}