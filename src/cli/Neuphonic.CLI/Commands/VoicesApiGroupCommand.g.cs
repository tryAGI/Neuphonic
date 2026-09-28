#nullable enable

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class VoicesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"voices", @"Voices endpoint commands.");
                         command.Subcommands.Add(VoicesCloneVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesDeleteVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesListVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesUpdateVoiceCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}