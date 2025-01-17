// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

namespace System.Activities.XamlIntegration;

[Serializable]
public class TextExpressionCompilerError
{
    internal TextExpressionCompilerError() { }

    public bool IsWarning { get; internal set; }

    public int SourceLineNumber { get; internal set; }

    public string Message { get; internal set; }

    public string Number { get; internal set; }

    public override string ToString()
    {
        return Message;
    }
}
