﻿namespace GoogleTestAdapter
{
    public interface IDebuggedProcessLauncher
    {
        int LaunchProcessWithDebuggerAttached(string command, string workingDirectory, string param);
    }
}