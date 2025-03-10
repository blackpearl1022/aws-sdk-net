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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PersonalizeRuntime.Model;
using Amazon.PersonalizeRuntime.Model.Internal.MarshallTransformations;
using Amazon.PersonalizeRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PersonalizeRuntime
{
    /// <summary>
    /// Implementation for accessing PersonalizeRuntime
    ///
    /// 
    /// </summary>
    public partial class AmazonPersonalizeRuntimeClient : AmazonServiceClient, IAmazonPersonalizeRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonPersonalizeRuntimeMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPersonalizeRuntimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeRuntimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPersonalizeRuntimeClient Configuration Object</param>
        public AmazonPersonalizeRuntimeClient(AmazonPersonalizeRuntimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPersonalizeRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonPersonalizeRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPersonalizeRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Credentials and an
        /// AmazonPersonalizeRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPersonalizeRuntimeClient Configuration Object</param>
        public AmazonPersonalizeRuntimeClient(AWSCredentials credentials, AmazonPersonalizeRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPersonalizeRuntimeClient Configuration Object</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPersonalizeRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPersonalizeRuntimeClient Configuration Object</param>
        public AmazonPersonalizeRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPersonalizeRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPersonalizeRuntimeEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  GetPersonalizedRanking

        /// <summary>
        /// Re-ranks a list of recommended items for the given user. The first item in the list
        /// is deemed the most likely item to be of interest to the user.
        /// 
        ///  <note> 
        /// <para>
        /// The solution backing the campaign must have been created using a recipe of type PERSONALIZED_RANKING.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalizedRanking service method.</param>
        /// 
        /// <returns>The response from the GetPersonalizedRanking service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        public virtual GetPersonalizedRankingResponse GetPersonalizedRanking(GetPersonalizedRankingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonalizedRankingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonalizedRankingResponseUnmarshaller.Instance;

            return Invoke<GetPersonalizedRankingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonalizedRanking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalizedRanking operation on AmazonPersonalizeRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPersonalizedRanking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        public virtual IAsyncResult BeginGetPersonalizedRanking(GetPersonalizedRankingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonalizedRankingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonalizedRankingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPersonalizedRanking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPersonalizedRanking.</param>
        /// 
        /// <returns>Returns a  GetPersonalizedRankingResult from PersonalizeRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        public virtual GetPersonalizedRankingResponse EndGetPersonalizedRanking(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPersonalizedRankingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendations

        /// <summary>
        /// Returns a list of recommended items. For campaigns, the campaign's Amazon Resource
        /// Name (ARN) is required and the required user and item input depends on the recipe
        /// type used to create the solution backing the campaign as follows:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// USER_PERSONALIZATION - <code>userId</code> required, <code>itemId</code> not used
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RELATED_ITEMS - <code>itemId</code> required, <code>userId</code> not used
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Campaigns that are backed by a solution created using a recipe of type PERSONALIZED_RANKING
        /// use the API.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For recommenders, the recommender's ARN is required and the required item and user
        /// input depends on the use case (domain-based recipe) backing the recommender. For information
        /// on use case requirements see <a href="https://docs.aws.amazon.com/personalize/latest/dg/domain-use-cases.html">Choosing
        /// recommender use cases</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonPersonalizeRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from PersonalizeRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        public virtual GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationsResponse>(asyncResult);
        }

        #endregion
        
    }
}