using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 
/// </summary>
namespace demo.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class Car
    {

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the brand.</summary>
        /// <value>The brand.</value>
        public string Brand { get; set; }

        /// <summary>Gets or sets the line.</summary>
        /// <value>The line.</value>
        public string Line { get; set; }

        /// <summary>Gets or sets the model.</summary>
        /// <value>The model.</value>
        public string Model { get; set; }
    }
}
