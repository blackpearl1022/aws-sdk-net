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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the StartFileTransfer operation.
    /// Begins a file transfer between local Amazon Web Services storage and a remote AS2
    /// or SFTP server.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For an AS2 connector, you specify the <code>ConnectorId</code> and one or more <code>SendFilePaths</code>
    /// to identify the files you want to transfer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For an SFTP connector, the file transfer can be either outbound or inbound. In both
    /// cases, you specify the <code>ConnectorId</code>. Depending on the direction of the
    /// transfer, you also specify the following items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you are transferring file from a partner's SFTP server to a Transfer Family server,
    /// you specify one or more <code>RetreiveFilePaths</code> to identify the files you want
    /// to transfer, and a <code>LocalDirectoryPath</code> to specify the destination folder.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are transferring file to a partner's SFTP server from Amazon Web Services storage,
    /// you specify one or more <code>SendFilePaths</code> to identify the files you want
    /// to transfer, and a <code>RemoteDirectoryPath</code> to specify the destination folder.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class StartFileTransferRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private string _localDirectoryPath;
        private string _remoteDirectoryPath;
        private List<string> _retrieveFilePaths = new List<string>();
        private List<string> _sendFilePaths = new List<string>();

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalDirectoryPath. 
        /// <para>
        /// For an inbound transfer, the <code>LocaDirectoryPath</code> specifies the destination
        /// for one or more files that are transferred from the partner's SFTP server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LocalDirectoryPath
        {
            get { return this._localDirectoryPath; }
            set { this._localDirectoryPath = value; }
        }

        // Check to see if LocalDirectoryPath property is set
        internal bool IsSetLocalDirectoryPath()
        {
            return this._localDirectoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDirectoryPath. 
        /// <para>
        /// For an outbound transfer, the <code>RemoteDirectoryPath</code> specifies the destination
        /// for one or more files that are transferred to the partner's SFTP server. If you don't
        /// specify a <code>RemoteDirectoryPath</code>, the destination for transferred files
        /// is the SFTP user's home directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RemoteDirectoryPath
        {
            get { return this._remoteDirectoryPath; }
            set { this._remoteDirectoryPath = value; }
        }

        // Check to see if RemoteDirectoryPath property is set
        internal bool IsSetRemoteDirectoryPath()
        {
            return this._remoteDirectoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property RetrieveFilePaths. 
        /// <para>
        /// One or more source paths for the partner's SFTP server. Each string represents a source
        /// file path for one inbound file transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> RetrieveFilePaths
        {
            get { return this._retrieveFilePaths; }
            set { this._retrieveFilePaths = value; }
        }

        // Check to see if RetrieveFilePaths property is set
        internal bool IsSetRetrieveFilePaths()
        {
            return this._retrieveFilePaths != null && this._retrieveFilePaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SendFilePaths. 
        /// <para>
        /// One or more source paths for the Transfer Family server. Each string represents a
        /// source file path for one outbound file transfer. For example, <code> <i>DOC-EXAMPLE-BUCKET</i>/<i>myfile.txt</i>
        /// </code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SendFilePaths
        {
            get { return this._sendFilePaths; }
            set { this._sendFilePaths = value; }
        }

        // Check to see if SendFilePaths property is set
        internal bool IsSetSendFilePaths()
        {
            return this._sendFilePaths != null && this._sendFilePaths.Count > 0; 
        }

    }
}