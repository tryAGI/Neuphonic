#nullable enable

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class AgentsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agents", @"Agents endpoint commands.");
                         command.Subcommands.Add(AgentsCreateAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}