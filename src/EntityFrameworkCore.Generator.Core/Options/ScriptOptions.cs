using System.Collections.Generic;

namespace EntityFrameworkCore.Generator.Options;

public class ScriptOptions : OptionsBase
{
    public ScriptOptions(VariableDictionary variables, string? prefix)
        : base(variables, AppendPrefix(prefix, "Script"))
    {
        Context = [];
        Entity = [];
        Model = [];
    }

    /// <summary>
    /// Gets or sets the list context script templates.
    /// </summary>
    /// <value>The list context script templates.</value>
    public List<TemplateOptions> Context { get; }

    /// <summary>
    /// Gets or sets the list entity script templates.
    /// </summary>
    /// <value>The list entity script templates.</value>
    public List<TemplateOptions> Entity { get; }

    /// <summary>
    /// Gets or sets the list model script templates.
    /// </summary>
    /// <value>The list model script templates.</value>
    public List<TemplateOptions> Model { get; }

}
