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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// This is the response object from the EncryptData operation.
    /// </summary>
    public partial class EncryptDataResponse : AmazonWebServiceResponse
    {
        private string _cipherText;
        private string _keyArn;
        private string _keyCheckValue;

        /// <summary>
        /// Gets and sets the property CipherText. 
        /// <para>
        /// The encrypted ciphertext.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=4096)]
        public string CipherText
        {
            get { return this._cipherText; }
            set { this._cipherText = value; }
        }

        // Check to see if CipherText property is set
        internal bool IsSetCipherText()
        {
            return this._cipherText != null;
        }

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The <code>keyARN</code> of the encryption key that Amazon Web Services Payment Cryptography
        /// uses for plaintext encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the encryption key. The KCV is used to check if all parties
        /// holding a given key have the same key or to detect that a key has changed. Amazon
        /// Web Services Payment Cryptography calculates the KCV by using standard algorithms,
        /// typically by encrypting 8 or 16 bytes or "00" or "01" and then truncating the result
        /// to the first 3 bytes, or 6 hex digits, of the resulting cryptogram.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string KeyCheckValue
        {
            get { return this._keyCheckValue; }
            set { this._keyCheckValue = value; }
        }

        // Check to see if KeyCheckValue property is set
        internal bool IsSetKeyCheckValue()
        {
            return this._keyCheckValue != null;
        }

    }
}