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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2SubnetDetails Marshaller
    /// </summary>       
    public class AwsEc2SubnetDetailsMarshaller : IRequestMarshaller<AwsEc2SubnetDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2SubnetDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssignIpv6AddressOnCreation())
            {
                context.Writer.WritePropertyName("AssignIpv6AddressOnCreation");
                context.Writer.Write(requestObject.AssignIpv6AddressOnCreation);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetAvailabilityZoneId())
            {
                context.Writer.WritePropertyName("AvailabilityZoneId");
                context.Writer.Write(requestObject.AvailabilityZoneId);
            }

            if(requestObject.IsSetAvailableIpAddressCount())
            {
                context.Writer.WritePropertyName("AvailableIpAddressCount");
                context.Writer.Write(requestObject.AvailableIpAddressCount);
            }

            if(requestObject.IsSetCidrBlock())
            {
                context.Writer.WritePropertyName("CidrBlock");
                context.Writer.Write(requestObject.CidrBlock);
            }

            if(requestObject.IsSetDefaultForAz())
            {
                context.Writer.WritePropertyName("DefaultForAz");
                context.Writer.Write(requestObject.DefaultForAz);
            }

            if(requestObject.IsSetIpv6CidrBlockAssociationSet())
            {
                context.Writer.WritePropertyName("Ipv6CidrBlockAssociationSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6CidrBlockAssociationSetListValue in requestObject.Ipv6CidrBlockAssociationSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = Ipv6CidrBlockAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6CidrBlockAssociationSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMapPublicIpOnLaunch())
            {
                context.Writer.WritePropertyName("MapPublicIpOnLaunch");
                context.Writer.Write(requestObject.MapPublicIpOnLaunch);
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.Write(requestObject.OwnerId);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

            if(requestObject.IsSetSubnetArn())
            {
                context.Writer.WritePropertyName("SubnetArn");
                context.Writer.Write(requestObject.SubnetArn);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.Write(requestObject.SubnetId);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEc2SubnetDetailsMarshaller Instance = new AwsEc2SubnetDetailsMarshaller();

    }
}