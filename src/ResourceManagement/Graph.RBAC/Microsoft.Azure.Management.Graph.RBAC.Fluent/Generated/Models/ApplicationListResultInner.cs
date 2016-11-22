// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Role assignment list operation result.
    /// </summary>
    public partial class ApplicationListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationListResultInner class.
        /// </summary>
        public ApplicationListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationListResultInner class.
        /// </summary>
        /// <param name="value">Application list.</param>
        public ApplicationListResultInner(System.Collections.Generic.IList<ApplicationInner> value = default(System.Collections.Generic.IList<ApplicationInner>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets application list.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ApplicationInner> Value { get; set; }

    }
}