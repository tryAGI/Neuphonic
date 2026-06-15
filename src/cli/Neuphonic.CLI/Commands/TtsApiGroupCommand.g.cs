#nullable enable

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static class TtsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tts", @"Tts endpoint commands.");
                         command.Subcommands.Add(TtsCreateSseJwtTokenCommandApiCommand.Create());
                         command.Subcommands.Add(TtsPingCommandApiCommand.Create());
                         command.Subcommands.Add(TtsSpeakWithSseCommandApiCommand.Create());
        return command;
    }
}