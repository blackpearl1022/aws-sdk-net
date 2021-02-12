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
    /// Container for the parameters to the GetActionType operation.
    /// Returns information about an action type created for an external provider, where the
    /// action is to be used by customers of the external provider. The action can have been
    /// created with any supported integration model.
    /// </summary>
    public partial class GetActionTypeRequest : AmazonCodePipelineRequest
    {
        private ActionCategory _category;
        private string _owner;
        private string _provider;
        private string _version;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A category defines what kind of action can be taken in the stage. Valid categories
        /// are limited to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Source</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Build</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Test</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deploy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Approval</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Invoke</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The creator of an action type that has been created with any supported integration
        /// model. There are two valid values for the <code>owner</code> field in the action type
        /// category: <code>AWS</code> and <code>ThirdParty</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the action type being called. The provider name is specified when
        /// the action type is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=35)]
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A string that describes the action type version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}