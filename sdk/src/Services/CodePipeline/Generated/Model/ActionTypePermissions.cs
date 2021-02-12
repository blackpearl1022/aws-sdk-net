/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Details identifying the users with permissions to use the action type.
    /// </summary>
    public partial class ActionTypePermissions
    {
        private List<string> _allowedAccounts = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowedAccounts. 
        /// <para>
        /// A list of AWS account IDs with allow access to use the action type in their pipelines.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<string> AllowedAccounts
        {
            get { return this._allowedAccounts; }
            set { this._allowedAccounts = value; }
        }

        // Check to see if AllowedAccounts property is set
        internal bool IsSetAllowedAccounts()
        {
            return this._allowedAccounts != null && this._allowedAccounts.Count > 0; 
        }

    }
}