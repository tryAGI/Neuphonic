#nullable enable

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static class AgentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agents", @"Agents endpoint commands.");
                         command.Subcommands.Add(AgentsCreateAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentsCommandApiCommand.Create());
        return command;
    }
}