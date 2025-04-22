using UnityEngine;

public interface ITerminalBehavior
{
    string TerminalName { get; }
    void OnTerminalOpen();
    void OnTerminalClose();
}
