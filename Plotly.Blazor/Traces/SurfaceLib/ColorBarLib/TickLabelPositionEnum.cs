/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.SurfaceLib.ColorBarLib
{
    /// <summary>
    ///     Determines where tick labels are drawn.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickLabelPositionEnum
    {
        [EnumMember(Value=@"outside")]
        Outside = 0,
        [EnumMember(Value=@"inside")]
        Inside,
        [EnumMember(Value=@"outside top")]
        OutsideTop,
        [EnumMember(Value=@"inside top")]
        InsideTop,
        [EnumMember(Value=@"outside bottom")]
        OutsideBottom,
        [EnumMember(Value=@"inside bottom")]
        InsideBottom
    }
}