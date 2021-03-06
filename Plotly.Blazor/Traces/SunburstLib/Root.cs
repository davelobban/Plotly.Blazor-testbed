/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.SunburstLib
{
    /// <summary>
    ///     The Root class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Root : IEquatable<Root>
    {
        /// <summary>
        ///     sets the color of the root node for a sunburst or a treemap trace. this
        ///     has no effect when a colorscale is used to set the markers.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Root other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Root other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Root and the right Root.
        /// </summary>
        /// <param name="left">Left Root.</param>
        /// <param name="right">Right Root.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Root left, Root right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Root and the right Root.
        /// </summary>
        /// <param name="left">Left Root.</param>
        /// <param name="right">Right Root.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Root left, Root right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Root</returns>
        public Root DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Root) formatter.Deserialize(ms);
        }
    }
}