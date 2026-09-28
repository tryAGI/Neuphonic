#nullable enable

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class TtsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tts", @"Tts endpoint commands.");
                         command.Subcommands.Add(TtsCreateSseJwtTokenCommandApiCommand.Create());
                         command.Subcommands.Add(TtsPingCommandApiCommand.Create());
                         command.Subcommands.Add(TtsSpeakWithSseCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}