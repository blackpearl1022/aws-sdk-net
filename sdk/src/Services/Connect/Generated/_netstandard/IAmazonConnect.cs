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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Connect.Model;

namespace Amazon.Connect
{
    /// <summary>
    /// Interface for accessing Connect
    ///
    /// Amazon Connect is a cloud-based contact center solution that you use to set up and
    /// manage a customer contact center and provide reliable customer engagement at any scale.
    /// 
    ///  
    /// <para>
    /// Amazon Connect provides metrics and real-time reporting that enable you to optimize
    /// contact routing. You can also resolve customer issues more efficiently by getting
    /// customers in touch with the appropriate agents.
    /// </para>
    ///  
    /// <para>
    /// There are limits to the number of Amazon Connect resources that you can create. There
    /// are also limits to the number of requests that you can make per second. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can connect programmatically to an Amazon Web Services service by using an endpoint.
    /// For a list of Amazon Connect endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect Endpoints</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnect : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectPaginatorFactory Paginators { get; }
#endif
                
        #region  ActivateEvaluationForm



        /// <summary>
        /// Activates an evaluation form in the specified Amazon Connect instance. After the evaluation
        /// form is activated, it is available to start new evaluations based on the form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ActivateEvaluationForm">REST API Reference for ActivateEvaluationForm Operation</seealso>
        Task<ActivateEvaluationFormResponse> ActivateEvaluationFormAsync(ActivateEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateApprovedOrigin



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates an approved origin to an Amazon Connect instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovedOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApprovedOrigin service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateApprovedOrigin">REST API Reference for AssociateApprovedOrigin Operation</seealso>
        Task<AssociateApprovedOriginResponse> AssociateApprovedOriginAsync(AssociateApprovedOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateBot



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Amazon Lex or
        /// Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateBot">REST API Reference for AssociateBot Operation</seealso>
        Task<AssociateBotResponse> AssociateBotAsync(AssociateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateDefaultVocabulary



        /// <summary>
        /// Associates an existing vocabulary as the default. Contact Lens for Amazon Connect
        /// uses the vocabulary in post-call and real-time analysis sessions for the given language.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDefaultVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDefaultVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateDefaultVocabulary">REST API Reference for AssociateDefaultVocabulary Operation</seealso>
        Task<AssociateDefaultVocabularyResponse> AssociateDefaultVocabularyAsync(AssociateDefaultVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateInstanceStorageConfig



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a storage resource type for the first time. You can only associate one
        /// type of storage configuration in a single call. This means, for example, that you
        /// can't define an instance with multiple S3 buckets for storing chat transcripts.
        /// </para>
        ///  
        /// <para>
        /// This API does not create a resource that doesn't exist. It only associates it to the
        /// instance. Ensure that the resource being specified in the storage configuration, like
        /// an S3 bucket, exists when being used for association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateInstanceStorageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateInstanceStorageConfig">REST API Reference for AssociateInstanceStorageConfig Operation</seealso>
        Task<AssociateInstanceStorageConfigResponse> AssociateInstanceStorageConfigAsync(AssociateInstanceStorageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateLambdaFunction



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Lambda function.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLambdaFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLambdaFunction service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLambdaFunction">REST API Reference for AssociateLambdaFunction Operation</seealso>
        Task<AssociateLambdaFunctionResponse> AssociateLambdaFunctionAsync(AssociateLambdaFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateLexBot



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Amazon Lex V1
        /// bot. This API only supports the association of Amazon Lex V1 bots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLexBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLexBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLexBot">REST API Reference for AssociateLexBot Operation</seealso>
        Task<AssociateLexBotResponse> AssociateLexBotAsync(AssociateLexBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePhoneNumberContactFlow



        /// <summary>
        /// Associates a flow with a phone number claimed to your Amazon Connect instance.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling this
        /// API using an instance in the Amazon Web Services Region where the traffic distribution
        /// group was created, you can use either a full phone number ARN or UUID value for the
        /// <code>PhoneNumberId</code> URI request parameter. However, if the number is claimed
        /// to a traffic distribution group and you are calling this API using an instance in
        /// the alternate Amazon Web Services Region associated with the traffic distribution
        /// group, you must provide a full phone number ARN. If a UUID is provided in this scenario,
        /// you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberContactFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumberContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociatePhoneNumberContactFlow">REST API Reference for AssociatePhoneNumberContactFlow Operation</seealso>
        Task<AssociatePhoneNumberContactFlowResponse> AssociatePhoneNumberContactFlowAsync(AssociatePhoneNumberContactFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateQueueQuickConnects



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a set of quick connects with a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQueueQuickConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateQueueQuickConnects">REST API Reference for AssociateQueueQuickConnects Operation</seealso>
        Task<AssociateQueueQuickConnectsResponse> AssociateQueueQuickConnectsAsync(AssociateQueueQuickConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateRoutingProfileQueues



        /// <summary>
        /// Associates a set of queues with a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoutingProfileQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateRoutingProfileQueues">REST API Reference for AssociateRoutingProfileQueues Operation</seealso>
        Task<AssociateRoutingProfileQueuesResponse> AssociateRoutingProfileQueuesAsync(AssociateRoutingProfileQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateSecurityKey



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a security key to the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSecurityKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSecurityKey service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateSecurityKey">REST API Reference for AssociateSecurityKey Operation</seealso>
        Task<AssociateSecurityKeyResponse> AssociateSecurityKeyAsync(AssociateSecurityKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ClaimPhoneNumber



        /// <summary>
        /// Claims an available phone number to your Amazon Connect instance or traffic distribution
        /// group. You can call this API only in the same Amazon Web Services Region where the
        /// Amazon Connect instance or traffic distribution group was created.
        /// 
        ///  
        /// <para>
        /// For more information about how to use this operation, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/claim-phone-number.html">Claim
        /// a phone number in your country</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/claim-phone-numbers-traffic-distribution-groups.html">Claim
        /// phone numbers to traffic distribution groups</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_SearchAvailablePhoneNumbers.html">SearchAvailablePhoneNumbers</a>
        /// API for available phone numbers that you can claim. Call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
        /// API to verify the status of a previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
        /// operation.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you plan to claim and release numbers frequently during a 30 day period, contact
        /// us for a service quota exception. Otherwise, it is possible you will be blocked from
        /// claiming and releasing any more numbers until 30 days past the oldest number released
        /// has expired.
        /// </para>
        ///  
        /// <para>
        /// By default you can claim and release up to 200% of your maximum number of active phone
        /// numbers during any 30 day period. If you claim and release phone numbers using the
        /// UI or API during a rolling 30 day cycle that exceeds 200% of your phone number service
        /// level quota, you will be blocked from claiming any more numbers until 30 days past
        /// the oldest number released has expired. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you already have 99 claimed numbers and a service level quota of 99
        /// phone numbers, and in any 30 day period you release 99, claim 99, and then release
        /// 99, you will have exceeded the 200% limit. At that point you are blocked from claiming
        /// any more numbers until you open an Amazon Web Services support ticket.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ClaimPhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ClaimPhoneNumber">REST API Reference for ClaimPhoneNumber Operation</seealso>
        Task<ClaimPhoneNumberResponse> ClaimPhoneNumberAsync(ClaimPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAgentStatus



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates an agent status for the specified Amazon Connect instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateAgentStatus">REST API Reference for CreateAgentStatus Operation</seealso>
        Task<CreateAgentStatusResponse> CreateAgentStatusAsync(CreateAgentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContactFlow



        /// <summary>
        /// Creates a flow for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowException">
        /// The flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlow">REST API Reference for CreateContactFlow Operation</seealso>
        Task<CreateContactFlowResponse> CreateContactFlowAsync(CreateContactFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContactFlowModule



        /// <summary>
        /// Creates a flow module for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlowModule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowModuleException">
        /// The problems with the module. Please fix before trying again.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlowModule">REST API Reference for CreateContactFlowModule Operation</seealso>
        Task<CreateContactFlowModuleResponse> CreateContactFlowModuleAsync(CreateContactFlowModuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEvaluationForm



        /// <summary>
        /// Creates an evaluation form in the specified Amazon Connect instance. The form can
        /// be used to define questions related to agent performance, and create sections to organize
        /// such questions. Question and section identifiers cannot be duplicated within the same
        /// evaluation form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateEvaluationForm">REST API Reference for CreateEvaluationForm Operation</seealso>
        Task<CreateEvaluationFormResponse> CreateEvaluationFormAsync(CreateEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHoursOfOperation



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates hours of operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHoursOfOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateHoursOfOperation">REST API Reference for CreateHoursOfOperation Operation</seealso>
        Task<CreateHoursOfOperationResponse> CreateHoursOfOperationAsync(CreateHoursOfOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstance



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Initiates an Amazon Connect instance with all the supported channels enabled. It does
        /// not attach any storage, such as Amazon Simple Storage Service (Amazon S3) or Amazon
        /// Kinesis. It also does not allow for any configurations on features, such as Contact
        /// Lens for Amazon Connect. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Connect enforces a limit on the total number of instances that you can create
        /// or delete in 30 days. If you exceed this limit, you will get an error message indicating
        /// there has been an excessive number of attempts at creating or deleting instances.
        /// You must wait 30 days before you can restart creating and deleting instances in your
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIntegrationAssociation



        /// <summary>
        /// Creates an Amazon Web Services resource association with an Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegrationAssociation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateIntegrationAssociation">REST API Reference for CreateIntegrationAssociation Operation</seealso>
        Task<CreateIntegrationAssociationResponse> CreateIntegrationAssociationAsync(CreateIntegrationAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateParticipant



        /// <summary>
        /// Adds a new participant into an on-going chat contact. For more information, see <a
        /// href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-customize-flow.html">Customize
        /// chat flow experiences by integrating custom participants</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParticipant service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateParticipant">REST API Reference for CreateParticipant Operation</seealso>
        Task<CreateParticipantResponse> CreateParticipantAsync(CreateParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePrompt



        /// <summary>
        /// Creates a prompt. For more information about prompts, such as supported file types
        /// and maximum length, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/prompts.html">Create
        /// prompts</a> in the <i>Amazon Connect Administrator's Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrompt service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreatePrompt">REST API Reference for CreatePrompt Operation</seealso>
        Task<CreatePromptResponse> CreatePromptAsync(CreatePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQueue



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates a new queue for the specified Amazon Connect instance.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the number being used in the input is claimed to a traffic distribution group,
        /// and you are calling this API using an instance in the Amazon Web Services Region where
        /// the traffic distribution group was created, you can use either a full phone number
        /// ARN or UUID value for the <code>OutboundCallerIdNumberId</code> value of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_OutboundCallerConfig">OutboundCallerConfig</a>
        /// request body parameter. However, if the number is claimed to a traffic distribution
        /// group and you are calling this API using an instance in the alternate Amazon Web Services
        /// Region associated with the traffic distribution group, you must provide a full phone
        /// number ARN. If a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  
        /// <para>
        /// Only use the phone number ARN format that doesn't contain <code>instance</code> in
        /// the path, for example, <code>arn:aws:connect:us-east-1:1234567890:phone-number/uuid</code>.
        /// This is the same ARN format that is returned when you call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
        /// API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQuickConnect



        /// <summary>
        /// Creates a quick connect for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickConnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQuickConnect">REST API Reference for CreateQuickConnect Operation</seealso>
        Task<CreateQuickConnectResponse> CreateQuickConnectAsync(CreateQuickConnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoutingProfile



        /// <summary>
        /// Creates a new routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRoutingProfile">REST API Reference for CreateRoutingProfile Operation</seealso>
        Task<CreateRoutingProfileResponse> CreateRoutingProfileAsync(CreateRoutingProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRule



        /// <summary>
        /// Creates a rule for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
        /// Function language</a> to code conditions for the rule. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityProfile



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        Task<CreateSecurityProfileResponse> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTaskTemplate



        /// <summary>
        /// Creates a new task template in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.PropertyValidationException">
        /// The property is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTaskTemplate">REST API Reference for CreateTaskTemplate Operation</seealso>
        Task<CreateTaskTemplateResponse> CreateTaskTemplateAsync(CreateTaskTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficDistributionGroup



        /// <summary>
        /// Creates a traffic distribution group given an Amazon Connect instance that has been
        /// replicated. 
        /// 
        ///  
        /// <para>
        /// For more information about creating traffic distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-traffic-distribution-groups.html">Set
        /// up traffic distribution groups</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficDistributionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotReadyException">
        /// The resource is not ready.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTrafficDistributionGroup">REST API Reference for CreateTrafficDistributionGroup Operation</seealso>
        Task<CreateTrafficDistributionGroupResponse> CreateTrafficDistributionGroupAsync(CreateTrafficDistributionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUseCase



        /// <summary>
        /// Creates a use case for an integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUseCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUseCase service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUseCase">REST API Reference for CreateUseCase Operation</seealso>
        Task<CreateUseCaseResponse> CreateUseCaseAsync(CreateUseCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser



        /// <summary>
        /// Creates a user account for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For information about how to create user accounts using the Amazon Connect console,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/user-management.html">Add
        /// Users</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserHierarchyGroup



        /// <summary>
        /// Creates a new user hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserHierarchyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUserHierarchyGroup">REST API Reference for CreateUserHierarchyGroup Operation</seealso>
        Task<CreateUserHierarchyGroupResponse> CreateUserHierarchyGroupAsync(CreateUserHierarchyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVocabulary



        /// <summary>
        /// Creates a custom vocabulary associated with your Amazon Connect instance. You can
        /// set a custom vocabulary to be your default vocabulary for a given language. Contact
        /// Lens for Amazon Connect uses the default vocabulary in post-call and real-time contact
        /// analysis sessions for that language.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeactivateEvaluationForm



        /// <summary>
        /// Deactivates an evaluation form in the specified Amazon Connect instance. After a form
        /// is deactivated, it is no longer available for users to start new evaluations based
        /// on the form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeactivateEvaluationForm">REST API Reference for DeactivateEvaluationForm Operation</seealso>
        Task<DeactivateEvaluationFormResponse> DeactivateEvaluationFormAsync(DeactivateEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContactEvaluation



        /// <summary>
        /// Deletes a contact evaluation in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactEvaluation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactEvaluation">REST API Reference for DeleteContactEvaluation Operation</seealso>
        Task<DeleteContactEvaluationResponse> DeleteContactEvaluationAsync(DeleteContactEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContactFlow



        /// <summary>
        /// Deletes a flow for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlow">REST API Reference for DeleteContactFlow Operation</seealso>
        Task<DeleteContactFlowResponse> DeleteContactFlowAsync(DeleteContactFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContactFlowModule



        /// <summary>
        /// Deletes the specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlowModule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlowModule">REST API Reference for DeleteContactFlowModule Operation</seealso>
        Task<DeleteContactFlowModuleResponse> DeleteContactFlowModuleAsync(DeleteContactFlowModuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEvaluationForm



        /// <summary>
        /// Deletes an evaluation form in the specified Amazon Connect instance. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the version property is provided, only the specified version of the evaluation
        /// form is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If no version is provided, then the full form (all versions) is deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteEvaluationForm">REST API Reference for DeleteEvaluationForm Operation</seealso>
        Task<DeleteEvaluationFormResponse> DeleteEvaluationFormAsync(DeleteEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHoursOfOperation



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes an hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHoursOfOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteHoursOfOperation">REST API Reference for DeleteHoursOfOperation Operation</seealso>
        Task<DeleteHoursOfOperationResponse> DeleteHoursOfOperationAsync(DeleteHoursOfOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInstance



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes the Amazon Connect instance.
        /// </para>
        ///  
        /// <para>
        /// Amazon Connect enforces a limit on the total number of instances that you can create
        /// or delete in 30 days. If you exceed this limit, you will get an error message indicating
        /// there has been an excessive number of attempts at creating or deleting instances.
        /// You must wait 30 days before you can restart creating and deleting instances in your
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntegrationAssociation



        /// <summary>
        /// Deletes an Amazon Web Services resource association from an Amazon Connect instance.
        /// The association must not have any use cases associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegrationAssociation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteIntegrationAssociation">REST API Reference for DeleteIntegrationAssociation Operation</seealso>
        Task<DeleteIntegrationAssociationResponse> DeleteIntegrationAssociationAsync(DeleteIntegrationAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePrompt



        /// <summary>
        /// Deletes a prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrompt service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeletePrompt">REST API Reference for DeletePrompt Operation</seealso>
        Task<DeletePromptResponse> DeletePromptAsync(DeletePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueue



        /// <summary>
        /// Deletes a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQuickConnect



        /// <summary>
        /// Deletes a quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickConnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteQuickConnect">REST API Reference for DeleteQuickConnect Operation</seealso>
        Task<DeleteQuickConnectResponse> DeleteQuickConnectAsync(DeleteQuickConnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoutingProfile



        /// <summary>
        /// Deletes a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteRoutingProfile">REST API Reference for DeleteRoutingProfile Operation</seealso>
        Task<DeleteRoutingProfileResponse> DeleteRoutingProfileAsync(DeleteRoutingProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRule



        /// <summary>
        /// Deletes a rule for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityProfile



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        Task<DeleteSecurityProfileResponse> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTaskTemplate



        /// <summary>
        /// Deletes the task template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTaskTemplate">REST API Reference for DeleteTaskTemplate Operation</seealso>
        Task<DeleteTaskTemplateResponse> DeleteTaskTemplateAsync(DeleteTaskTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficDistributionGroup



        /// <summary>
        /// Deletes a traffic distribution group. This API can be called only in the Region where
        /// the traffic distribution group is created.
        /// 
        ///  
        /// <para>
        /// For more information about deleting traffic distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/delete-traffic-distribution-groups.html">Delete
        /// traffic distribution groups</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficDistributionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTrafficDistributionGroup">REST API Reference for DeleteTrafficDistributionGroup Operation</seealso>
        Task<DeleteTrafficDistributionGroupResponse> DeleteTrafficDistributionGroupAsync(DeleteTrafficDistributionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUseCase



        /// <summary>
        /// Deletes a use case from an integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUseCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUseCase service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUseCase">REST API Reference for DeleteUseCase Operation</seealso>
        Task<DeleteUseCaseResponse> DeleteUseCaseAsync(DeleteUseCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser



        /// <summary>
        /// Deletes a user account from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For information about what happens to a user's data when their account is deleted,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/delete-users.html">Delete
        /// Users from Your Amazon Connect Instance</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserHierarchyGroup



        /// <summary>
        /// Deletes an existing user hierarchy group. It must not be associated with any agents
        /// or have any active child groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserHierarchyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUserHierarchyGroup">REST API Reference for DeleteUserHierarchyGroup Operation</seealso>
        Task<DeleteUserHierarchyGroupResponse> DeleteUserHierarchyGroupAsync(DeleteUserHierarchyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVocabulary



        /// <summary>
        /// Deletes the vocabulary that has the given identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgentStatus



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes an agent status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeAgentStatus">REST API Reference for DescribeAgentStatus Operation</seealso>
        Task<DescribeAgentStatusResponse> DescribeAgentStatusAsync(DescribeAgentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContact



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified contact. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Contact information remains available in Amazon Connect for 24 months, and then it
        /// is deleted.
        /// </para>
        ///  
        /// <para>
        /// Only data from November 12, 2021, and later is returned by this API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        Task<DescribeContactResponse> DescribeContactAsync(DescribeContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContactEvaluation



        /// <summary>
        /// Describes a contact evaluation in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContactEvaluation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactEvaluation">REST API Reference for DescribeContactEvaluation Operation</seealso>
        Task<DescribeContactEvaluationResponse> DescribeContactEvaluationAsync(DescribeContactEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContactFlow



        /// <summary>
        /// Describes the specified flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactFlowNotPublishedException">
        /// The flow has not been published.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlow">REST API Reference for DescribeContactFlow Operation</seealso>
        Task<DescribeContactFlowResponse> DescribeContactFlowAsync(DescribeContactFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContactFlowModule



        /// <summary>
        /// Describes the specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlowModule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlowModule">REST API Reference for DescribeContactFlowModule Operation</seealso>
        Task<DescribeContactFlowModuleResponse> DescribeContactFlowModuleAsync(DescribeContactFlowModuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvaluationForm



        /// <summary>
        /// Describes an evaluation form in the specified Amazon Connect instance. If the version
        /// property is not provided, the latest version of the evaluation form is described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeEvaluationForm">REST API Reference for DescribeEvaluationForm Operation</seealso>
        Task<DescribeEvaluationFormResponse> DescribeEvaluationFormAsync(DescribeEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHoursOfOperation



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHoursOfOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeHoursOfOperation">REST API Reference for DescribeHoursOfOperation Operation</seealso>
        Task<DescribeHoursOfOperationResponse> DescribeHoursOfOperationAsync(DescribeHoursOfOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstance



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns the current state of the specified instance identifier. It tracks the instance
        /// while it is being created and returns an error status, if applicable. 
        /// </para>
        ///  
        /// <para>
        /// If an instance is not created successfully, the instance status reason field returns
        /// details relevant to the reason. The instance in a failed state is returned only for
        /// 24 hours after the CreateInstance API was invoked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceAttribute



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified instance attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceStorageConfig



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Retrieves the current storage configurations for the specified resource type, association
        /// ID, and instance ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStorageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceStorageConfig">REST API Reference for DescribeInstanceStorageConfig Operation</seealso>
        Task<DescribeInstanceStorageConfigResponse> DescribeInstanceStorageConfigAsync(DescribeInstanceStorageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePhoneNumber



        /// <summary>
        /// Gets details and status of a phone number that’s claimed to your Amazon Connect instance
        /// or traffic distribution group.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling in the
        /// Amazon Web Services Region where the traffic distribution group was created, you can
        /// use either a phone number ARN or UUID value for the <code>PhoneNumberId</code> URI
        /// request parameter. However, if the number is claimed to a traffic distribution group
        /// and you are calling this API in the alternate Amazon Web Services Region associated
        /// with the traffic distribution group, you must provide a full phone number ARN. If
        /// a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribePhoneNumber">REST API Reference for DescribePhoneNumber Operation</seealso>
        Task<DescribePhoneNumberResponse> DescribePhoneNumberAsync(DescribePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePrompt



        /// <summary>
        /// Describes the prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrompt service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribePrompt">REST API Reference for DescribePrompt Operation</seealso>
        Task<DescribePromptResponse> DescribePromptAsync(DescribePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeQueue



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQueue">REST API Reference for DescribeQueue Operation</seealso>
        Task<DescribeQueueResponse> DescribeQueueAsync(DescribeQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeQuickConnect



        /// <summary>
        /// Describes the quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickConnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQuickConnect">REST API Reference for DescribeQuickConnect Operation</seealso>
        Task<DescribeQuickConnectResponse> DescribeQuickConnectAsync(DescribeQuickConnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRoutingProfile



        /// <summary>
        /// Describes the specified routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRoutingProfile">REST API Reference for DescribeRoutingProfile Operation</seealso>
        Task<DescribeRoutingProfileResponse> DescribeRoutingProfileAsync(DescribeRoutingProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRule



        /// <summary>
        /// Describes a rule for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        Task<DescribeRuleResponse> DescribeRuleAsync(DescribeRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityProfile



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Gets basic information about the security profle.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        Task<DescribeSecurityProfileResponse> DescribeSecurityProfileAsync(DescribeSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrafficDistributionGroup



        /// <summary>
        /// Gets details and status of a traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficDistributionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeTrafficDistributionGroup">REST API Reference for DescribeTrafficDistributionGroup Operation</seealso>
        Task<DescribeTrafficDistributionGroupResponse> DescribeTrafficDistributionGroupAsync(DescribeTrafficDistributionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUser



        /// <summary>
        /// Describes the specified user account. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID in the Amazon Connect console</a> (it’s the final part of the ARN).
        /// The console does not display the user IDs. Instead, list the users and note the IDs
        /// provided in the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserHierarchyGroup



        /// <summary>
        /// Describes the specified hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        Task<DescribeUserHierarchyGroupResponse> DescribeUserHierarchyGroupAsync(DescribeUserHierarchyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserHierarchyStructure



        /// <summary>
        /// Describes the hierarchy structure of the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        Task<DescribeUserHierarchyStructureResponse> DescribeUserHierarchyStructureAsync(DescribeUserHierarchyStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVocabulary



        /// <summary>
        /// Describes the specified vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeVocabulary">REST API Reference for DescribeVocabulary Operation</seealso>
        Task<DescribeVocabularyResponse> DescribeVocabularyAsync(DescribeVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateApprovedOrigin



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes access to integrated applications from Amazon Connect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovedOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApprovedOrigin service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateApprovedOrigin">REST API Reference for DisassociateApprovedOrigin Operation</seealso>
        Task<DisassociateApprovedOriginResponse> DisassociateApprovedOriginAsync(DisassociateApprovedOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateBot



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes authorization from the specified instance to access the specified Amazon Lex
        /// or Amazon Lex V2 bot. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateBot">REST API Reference for DisassociateBot Operation</seealso>
        Task<DisassociateBotResponse> DisassociateBotAsync(DisassociateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateInstanceStorageConfig



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Removes the storage type configurations for the specified resource type and association
        /// ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateInstanceStorageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateInstanceStorageConfig">REST API Reference for DisassociateInstanceStorageConfig Operation</seealso>
        Task<DisassociateInstanceStorageConfigResponse> DisassociateInstanceStorageConfigAsync(DisassociateInstanceStorageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateLambdaFunction



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Remove the Lambda function from the dropdown options available in the relevant flow
        /// blocks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLambdaFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLambdaFunction service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLambdaFunction">REST API Reference for DisassociateLambdaFunction Operation</seealso>
        Task<DisassociateLambdaFunctionResponse> DisassociateLambdaFunctionAsync(DisassociateLambdaFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateLexBot



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes authorization from the specified instance to access the specified Amazon Lex
        /// bot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLexBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLexBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLexBot">REST API Reference for DisassociateLexBot Operation</seealso>
        Task<DisassociateLexBotResponse> DisassociateLexBotAsync(DisassociateLexBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumberContactFlow



        /// <summary>
        /// Removes the flow association from a phone number claimed to your Amazon Connect instance.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling this
        /// API using an instance in the Amazon Web Services Region where the traffic distribution
        /// group was created, you can use either a full phone number ARN or UUID value for the
        /// <code>PhoneNumberId</code> URI request parameter. However, if the number is claimed
        /// to a traffic distribution group and you are calling this API using an instance in
        /// the alternate Amazon Web Services Region associated with the traffic distribution
        /// group, you must provide a full phone number ARN. If a UUID is provided in this scenario,
        /// you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberContactFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumberContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociatePhoneNumberContactFlow">REST API Reference for DisassociatePhoneNumberContactFlow Operation</seealso>
        Task<DisassociatePhoneNumberContactFlowResponse> DisassociatePhoneNumberContactFlowAsync(DisassociatePhoneNumberContactFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateQueueQuickConnects



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Disassociates a set of quick connects from a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQueueQuickConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateQueueQuickConnects">REST API Reference for DisassociateQueueQuickConnects Operation</seealso>
        Task<DisassociateQueueQuickConnectsResponse> DisassociateQueueQuickConnectsAsync(DisassociateQueueQuickConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateRoutingProfileQueues



        /// <summary>
        /// Disassociates a set of queues from a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoutingProfileQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateRoutingProfileQueues">REST API Reference for DisassociateRoutingProfileQueues Operation</seealso>
        Task<DisassociateRoutingProfileQueuesResponse> DisassociateRoutingProfileQueuesAsync(DisassociateRoutingProfileQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateSecurityKey



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes the specified security key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSecurityKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSecurityKey service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateSecurityKey">REST API Reference for DisassociateSecurityKey Operation</seealso>
        Task<DisassociateSecurityKeyResponse> DisassociateSecurityKeyAsync(DisassociateSecurityKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DismissUserContact



        /// <summary>
        /// Dismisses contacts from an agent’s CCP and returns the agent to an available state,
        /// which allows the agent to receive a new routed contact. Contacts can only be dismissed
        /// if they are in a <code>MISSED</code>, <code>ERROR</code>, <code>ENDED</code>, or <code>REJECTED</code>
        /// state in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/about-contact-states.html">Agent
        /// Event Stream</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DismissUserContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DismissUserContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DismissUserContact">REST API Reference for DismissUserContact Operation</seealso>
        Task<DismissUserContactResponse> DismissUserContactAsync(DismissUserContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContactAttributes



        /// <summary>
        /// Retrieves the contact attributes for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        Task<GetContactAttributesResponse> GetContactAttributesAsync(GetContactAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCurrentMetricData



        /// <summary>
        /// Gets the real-time metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For a description of each metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html">Real-time
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCurrentMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        Task<GetCurrentMetricDataResponse> GetCurrentMetricDataAsync(GetCurrentMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCurrentUserData



        /// <summary>
        /// Gets the real-time active user data from the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUserData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCurrentUserData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentUserData">REST API Reference for GetCurrentUserData Operation</seealso>
        Task<GetCurrentUserDataResponse> GetCurrentUserDataAsync(GetCurrentUserDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFederationToken



        /// <summary>
        /// Retrieves a token for federation.
        /// 
        ///  <note> 
        /// <para>
        /// This API doesn't support root users. If you try to invoke GetFederationToken with
        /// root credentials, an error message similar to the following one appears: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Provided identity: Principal: .... User: .... cannot be used for federation
        /// with Amazon Connect</code> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.UserNotFoundException">
        /// No user with the specified credentials was found in the Amazon Connect instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMetricData



        /// <summary>
        /// Gets historical metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For a description of each historical metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMetricDataV2



        /// <summary>
        /// Gets metric data from the specified Amazon Connect instance. 
        /// 
        ///  
        /// <para>
        ///  <code>GetMetricDataV2</code> offers more features than <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricData.html">GetMetricData</a>,
        /// the previous version of this API. It has new metrics, offers filtering at a metric
        /// level, and offers the ability to filter and group data by channels, queues, routing
        /// profiles, agents, and agent hierarchy levels. It can retrieve historical data for
        /// the last 35 days, in 24-hour intervals.
        /// </para>
        ///  
        /// <para>
        /// For a description of the historical metrics that are supported by <code>GetMetricDataV2</code>
        /// and <code>GetMetricData</code>, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricDataV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricDataV2 service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricDataV2">REST API Reference for GetMetricDataV2 Operation</seealso>
        Task<GetMetricDataV2Response> GetMetricDataV2Async(GetMetricDataV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPromptFile



        /// <summary>
        /// Gets the prompt file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPromptFile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPromptFile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetPromptFile">REST API Reference for GetPromptFile Operation</seealso>
        Task<GetPromptFileResponse> GetPromptFileAsync(GetPromptFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTaskTemplate



        /// <summary>
        /// Gets details about a specific task template in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaskTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTaskTemplate">REST API Reference for GetTaskTemplate Operation</seealso>
        Task<GetTaskTemplateResponse> GetTaskTemplateAsync(GetTaskTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficDistribution



        /// <summary>
        /// Retrieves the current traffic distribution for a given traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficDistribution service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTrafficDistribution">REST API Reference for GetTrafficDistribution Operation</seealso>
        Task<GetTrafficDistributionResponse> GetTrafficDistributionAsync(GetTrafficDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAgentStatuses



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists agent statuses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentStatuses service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListAgentStatuses">REST API Reference for ListAgentStatuses Operation</seealso>
        Task<ListAgentStatusesResponse> ListAgentStatusesAsync(ListAgentStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApprovedOrigins



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all approved origins associated with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovedOrigins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApprovedOrigins service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListApprovedOrigins">REST API Reference for ListApprovedOrigins Operation</seealso>
        Task<ListApprovedOriginsResponse> ListApprovedOriginsAsync(ListApprovedOriginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBots



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// For the specified version of Amazon Lex, returns a paginated list of all the Amazon
        /// Lex bots currently associated with the instance. Use this API to returns both Amazon
        /// Lex V1 and V2 bots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListBots">REST API Reference for ListBots Operation</seealso>
        Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContactEvaluations



        /// <summary>
        /// Lists contact evaluations in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactEvaluations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactEvaluations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactEvaluations">REST API Reference for ListContactEvaluations Operation</seealso>
        Task<ListContactEvaluationsResponse> ListContactEvaluationsAsync(ListContactEvaluationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContactFlowModules



        /// <summary>
        /// Provides information about the flow modules for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlowModules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactFlowModules service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlowModules">REST API Reference for ListContactFlowModules Operation</seealso>
        Task<ListContactFlowModulesResponse> ListContactFlowModulesAsync(ListContactFlowModulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContactFlows



        /// <summary>
        /// Provides information about the flows for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about flows, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-contact-flows.html">Flows</a>
        /// in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactFlows service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        Task<ListContactFlowsResponse> ListContactFlowsAsync(ListContactFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContactReferences



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// For the specified <code>referenceTypes</code>, returns a list of references associated
        /// with the contact. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactReferences service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactReferences">REST API Reference for ListContactReferences Operation</seealso>
        Task<ListContactReferencesResponse> ListContactReferencesAsync(ListContactReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDefaultVocabularies



        /// <summary>
        /// Lists the default vocabularies for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDefaultVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDefaultVocabularies service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListDefaultVocabularies">REST API Reference for ListDefaultVocabularies Operation</seealso>
        Task<ListDefaultVocabulariesResponse> ListDefaultVocabulariesAsync(ListDefaultVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEvaluationForms



        /// <summary>
        /// Lists evaluation forms in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationForms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEvaluationForms service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListEvaluationForms">REST API Reference for ListEvaluationForms Operation</seealso>
        Task<ListEvaluationFormsResponse> ListEvaluationFormsAsync(ListEvaluationFormsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEvaluationFormVersions



        /// <summary>
        /// Lists versions of an evaluation form in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationFormVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEvaluationFormVersions service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListEvaluationFormVersions">REST API Reference for ListEvaluationFormVersions Operation</seealso>
        Task<ListEvaluationFormVersionsResponse> ListEvaluationFormVersionsAsync(ListEvaluationFormVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHoursOfOperations



        /// <summary>
        /// Provides information about the hours of operation for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about hours of operation, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-hours-operation.html">Set
        /// the Hours of Operation for a Queue</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHoursOfOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHoursOfOperations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        Task<ListHoursOfOperationsResponse> ListHoursOfOperationsAsync(ListHoursOfOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceAttributes



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all attribute types for the given instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceAttributes">REST API Reference for ListInstanceAttributes Operation</seealso>
        Task<ListInstanceAttributesResponse> ListInstanceAttributesAsync(ListInstanceAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstances



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Return a list of instances which are in active state, creation-in-progress state,
        /// and failed state. Instances that aren't successfully created (they are in a failed
        /// state) are returned only for 24 hours after the CreateInstance API was invoked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstances">REST API Reference for ListInstances Operation</seealso>
        Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceStorageConfigs



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of storage configs for the identified instance and resource
        /// type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceStorageConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceStorageConfigs service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceStorageConfigs">REST API Reference for ListInstanceStorageConfigs Operation</seealso>
        Task<ListInstanceStorageConfigsResponse> ListInstanceStorageConfigsAsync(ListInstanceStorageConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIntegrationAssociations



        /// <summary>
        /// Provides summary information about the Amazon Web Services resource associations for
        /// the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrationAssociations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListIntegrationAssociations">REST API Reference for ListIntegrationAssociations Operation</seealso>
        Task<ListIntegrationAssociationsResponse> ListIntegrationAssociationsAsync(ListIntegrationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLambdaFunctions



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all Lambda functions that display in the dropdown options
        /// in the relevant flow blocks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLambdaFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLambdaFunctions service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLambdaFunctions">REST API Reference for ListLambdaFunctions Operation</seealso>
        Task<ListLambdaFunctionsResponse> ListLambdaFunctionsAsync(ListLambdaFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLexBots



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all the Amazon Lex V1 bots currently associated with the
        /// instance. To return both Amazon Lex V1 and V2 bots, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListBots.html">ListBots</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLexBots service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLexBots">REST API Reference for ListLexBots Operation</seealso>
        Task<ListLexBotsResponse> ListLexBotsAsync(ListLexBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumbers



        /// <summary>
        /// Provides information about the phone numbers for the specified Amazon Connect instance.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
        /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The phone number <code>Arn</code> value that is returned from each of the items in
        /// the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbers.html#connect-ListPhoneNumbers-response-PhoneNumberSummaryList">PhoneNumberSummaryList</a>
        /// cannot be used to tag phone number resources. It will fail with a <code>ResourceNotFoundException</code>.
        /// Instead, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
        /// API. It returns the new phone number ARN that can be used to tag phone number resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumbersV2



        /// <summary>
        /// Lists phone numbers claimed to your Amazon Connect instance or traffic distribution
        /// group. If the provided <code>TargetArn</code> is a traffic distribution group, you
        /// can call this API in both Amazon Web Services Regions associated with traffic distribution
        /// group.
        /// 
        ///  
        /// <para>
        /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
        /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbersV2 service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbersV2">REST API Reference for ListPhoneNumbersV2 Operation</seealso>
        Task<ListPhoneNumbersV2Response> ListPhoneNumbersV2Async(ListPhoneNumbersV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPrompts



        /// <summary>
        /// Provides information about the prompts for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrompts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrompts service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPrompts">REST API Reference for ListPrompts Operation</seealso>
        Task<ListPromptsResponse> ListPromptsAsync(ListPromptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueueQuickConnects



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists the quick connects associated with a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueQuickConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueueQuickConnects">REST API Reference for ListQueueQuickConnects Operation</seealso>
        Task<ListQueueQuickConnectsResponse> ListQueueQuickConnectsAsync(ListQueueQuickConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueues



        /// <summary>
        /// Provides information about the queues for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// If you do not specify a <code>QueueTypes</code> parameter, both standard and agent
        /// queues are returned. This might cause an unexpected truncation of results if you have
        /// more than 1000 agents and you limit the number of results of the API call in code.
        /// </para>
        ///  
        /// <para>
        /// For more information about queues, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-queues-standard-and-agent.html">Queues:
        /// Standard and Agent</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQuickConnects



        /// <summary>
        /// Provides information about the quick connects for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQuickConnects">REST API Reference for ListQuickConnects Operation</seealso>
        Task<ListQuickConnectsResponse> ListQuickConnectsAsync(ListQuickConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoutingProfileQueues



        /// <summary>
        /// Lists the queues associated with a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfileQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfileQueues">REST API Reference for ListRoutingProfileQueues Operation</seealso>
        Task<ListRoutingProfileQueuesResponse> ListRoutingProfileQueuesAsync(ListRoutingProfileQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoutingProfiles



        /// <summary>
        /// Provides summary information about the routing profiles for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about routing profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing.html">Routing
        /// Profiles</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/routing-profiles.html">Create
        /// a Routing Profile</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        Task<ListRoutingProfilesResponse> ListRoutingProfilesAsync(ListRoutingProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRules



        /// <summary>
        /// List all rules for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityKeys



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all security keys associated with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityKeys service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityKeys">REST API Reference for ListSecurityKeys Operation</seealso>
        Task<ListSecurityKeysResponse> ListSecurityKeysAsync(ListSecurityKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityProfilePermissions



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists the permissions granted to a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityProfilePermissions service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfilePermissions">REST API Reference for ListSecurityProfilePermissions Operation</seealso>
        Task<ListSecurityProfilePermissionsResponse> ListSecurityProfilePermissionsAsync(ListSecurityProfilePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityProfiles



        /// <summary>
        /// Provides summary information about the security profiles for the specified Amazon
        /// Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information about security profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/connect-security-profiles.html">Security
        /// Profiles</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        Task<ListSecurityProfilesResponse> ListSecurityProfilesAsync(ListSecurityProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// 
        ///  
        /// <para>
        /// For sample policies that use tags, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_id-based-policy-examples.html">Amazon
        /// Connect Identity-Based Policy Examples</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTaskTemplates



        /// <summary>
        /// Lists task templates for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskTemplates service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTaskTemplates">REST API Reference for ListTaskTemplates Operation</seealso>
        Task<ListTaskTemplatesResponse> ListTaskTemplatesAsync(ListTaskTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficDistributionGroups



        /// <summary>
        /// Lists traffic distribution groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficDistributionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficDistributionGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTrafficDistributionGroups">REST API Reference for ListTrafficDistributionGroups Operation</seealso>
        Task<ListTrafficDistributionGroupsResponse> ListTrafficDistributionGroupsAsync(ListTrafficDistributionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUseCases



        /// <summary>
        /// Lists the use cases for the integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUseCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUseCases service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUseCases">REST API Reference for ListUseCases Operation</seealso>
        Task<ListUseCasesResponse> ListUseCasesAsync(ListUseCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserHierarchyGroups



        /// <summary>
        /// Provides summary information about the hierarchy groups for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about agent hierarchies, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/agent-hierarchy.html">Set
        /// Up Agent Hierarchies</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserHierarchyGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserHierarchyGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        Task<ListUserHierarchyGroupsResponse> ListUserHierarchyGroupsAsync(ListUserHierarchyGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers



        /// <summary>
        /// Provides summary information about the users for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MonitorContact



        /// <summary>
        /// Initiates silent monitoring of a contact. The Contact Control Panel (CCP) of the user
        /// specified by <i>userId</i> will be set to silent monitoring mode on the contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MonitorContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/MonitorContact">REST API Reference for MonitorContact Operation</seealso>
        Task<MonitorContactResponse> MonitorContactAsync(MonitorContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutUserStatus



        /// <summary>
        /// Changes the current status of a user or agent in Amazon Connect. If the agent is currently
        /// handling a contact, this sets the agent's next status.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-agent-status.html">Agent
        /// status</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-next-status.html">Set
        /// your next status</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutUserStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/PutUserStatus">REST API Reference for PutUserStatus Operation</seealso>
        Task<PutUserStatusResponse> PutUserStatusAsync(PutUserStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleasePhoneNumber



        /// <summary>
        /// Releases a phone number previously claimed to an Amazon Connect instance or traffic
        /// distribution group. You can call this API only in the Amazon Web Services Region where
        /// the number was claimed.
        /// 
        ///  <important> 
        /// <para>
        /// To release phone numbers from a traffic distribution group, use the <code>ReleasePhoneNumber</code>
        /// API, not the Amazon Connect console.
        /// </para>
        ///  
        /// <para>
        /// After releasing a phone number, the phone number enters into a cooldown period of
        /// 30 days. It cannot be searched for or claimed again until the period has ended. If
        /// you accidentally release a phone number, contact Amazon Web Services Support.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you plan to claim and release numbers frequently during a 30 day period, contact
        /// us for a service quota exception. Otherwise, it is possible you will be blocked from
        /// claiming and releasing any more numbers until 30 days past the oldest number released
        /// has expired.
        /// </para>
        ///  
        /// <para>
        /// By default you can claim and release up to 200% of your maximum number of active phone
        /// numbers during any 30 day period. If you claim and release phone numbers using the
        /// UI or API during a rolling 30 day cycle that exceeds 200% of your phone number service
        /// level quota, you will be blocked from claiming any more numbers until 30 days past
        /// the oldest number released has expired. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you already have 99 claimed numbers and a service level quota of 99
        /// phone numbers, and in any 30 day period you release 99, claim 99, and then release
        /// 99, you will have exceeded the 200% limit. At that point you are blocked from claiming
        /// any more numbers until you open an Amazon Web Services support ticket.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        Task<ReleasePhoneNumberResponse> ReleasePhoneNumberAsync(ReleasePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplicateInstance



        /// <summary>
        /// Replicates an Amazon Connect instance in the specified Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about replicating an Amazon Connect instance, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html">Create
        /// a replica of your existing Amazon Connect instance</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplicateInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotReadyException">
        /// The resource is not ready.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReplicateInstance">REST API Reference for ReplicateInstance Operation</seealso>
        Task<ReplicateInstanceResponse> ReplicateInstanceAsync(ReplicateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResumeContactRecording



        /// <summary>
        /// When a contact is being recorded, and the recording has been suspended using SuspendContactRecording,
        /// this API resumes recording the call or screen.
        /// 
        ///  
        /// <para>
        /// Voice and screen recordings are supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        Task<ResumeContactRecordingResponse> ResumeContactRecordingAsync(ResumeContactRecordingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchAvailablePhoneNumbers



        /// <summary>
        /// Searches for available phone numbers that you can claim to your Amazon Connect instance
        /// or traffic distribution group. If the provided <code>TargetArn</code> is a traffic
        /// distribution group, you can call this API in both Amazon Web Services Regions associated
        /// with the traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        Task<SearchAvailablePhoneNumbersResponse> SearchAvailablePhoneNumbersAsync(SearchAvailablePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchHoursOfOperations



        /// <summary>
        /// Searches the hours of operation in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchHoursOfOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchHoursOfOperations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchHoursOfOperations">REST API Reference for SearchHoursOfOperations Operation</seealso>
        Task<SearchHoursOfOperationsResponse> SearchHoursOfOperationsAsync(SearchHoursOfOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchPrompts



        /// <summary>
        /// Searches prompts in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPrompts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchPrompts service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchPrompts">REST API Reference for SearchPrompts Operation</seealso>
        Task<SearchPromptsResponse> SearchPromptsAsync(SearchPromptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchQueues



        /// <summary>
        /// Searches queues in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchQueues">REST API Reference for SearchQueues Operation</seealso>
        Task<SearchQueuesResponse> SearchQueuesAsync(SearchQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchQuickConnects



        /// <summary>
        /// Searches quick connects in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuickConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchQuickConnects">REST API Reference for SearchQuickConnects Operation</seealso>
        Task<SearchQuickConnectsResponse> SearchQuickConnectsAsync(SearchQuickConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchResourceTags



        /// <summary>
        /// Searches tags used in an Amazon Connect instance using optional search criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResourceTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchResourceTags service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.MaximumResultReturnedException">
        /// Maximum number (1000) of tags have been returned with current request. Consider changing
        /// request parameters to get more tags.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchResourceTags">REST API Reference for SearchResourceTags Operation</seealso>
        Task<SearchResourceTagsResponse> SearchResourceTagsAsync(SearchResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchRoutingProfiles



        /// <summary>
        /// Searches routing profiles in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRoutingProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchRoutingProfiles">REST API Reference for SearchRoutingProfiles Operation</seealso>
        Task<SearchRoutingProfilesResponse> SearchRoutingProfilesAsync(SearchRoutingProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchSecurityProfiles



        /// <summary>
        /// Searches security profiles in an Amazon Connect instance, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchSecurityProfiles">REST API Reference for SearchSecurityProfiles Operation</seealso>
        Task<SearchSecurityProfilesResponse> SearchSecurityProfilesAsync(SearchSecurityProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchUsers



        /// <summary>
        /// Searches users in an Amazon Connect instance, with optional filtering.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>AfterContactWorkTimeLimit</code> is returned in milliseconds. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchVocabularies



        /// <summary>
        /// Searches for vocabularies within a specific Amazon Connect instance using <code>State</code>,
        /// <code>NameStartsWith</code>, and <code>LanguageCode</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchVocabularies service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchVocabularies">REST API Reference for SearchVocabularies Operation</seealso>
        Task<SearchVocabulariesResponse> SearchVocabulariesAsync(SearchVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartChatContact



        /// <summary>
        /// Initiates a flow to start a new chat for the customer. Response of this API provides
        /// a token required to obtain credentials from the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API in the Amazon Connect Participant Service.
        /// 
        ///  
        /// <para>
        /// When a new chat contact is successfully created, clients must subscribe to the participant’s
        /// connection for the created chat within 5 minutes. This is achieved by invoking <a
        /// href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// with WEBSOCKET and CONNECTION_CREDENTIALS. 
        /// </para>
        ///  
        /// <para>
        /// A 429 error occurs in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// API rate limit is exceeded. API TPS throttling returns a <code>TooManyRequests</code>
        /// exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">quota
        /// for concurrent active chats</a> is exceeded. Active chat throttling returns a <code>LimitExceededException</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use the <code>ChatDurationInMinutes</code> parameter and receive a 400 error,
        /// your account may not support the ability to configure custom chat durations. For more
        /// information, contact Amazon Web Services Support. 
        /// </para>
        ///  
        /// <para>
        /// For more information about chat, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat.html">Chat</a>
        /// in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChatContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChatContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        Task<StartChatContactResponse> StartChatContactAsync(StartChatContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartContactEvaluation



        /// <summary>
        /// Starts an empty evaluation in the specified Amazon Connect instance, using the given
        /// evaluation form for the particular contact. The evaluation form version used for the
        /// contact evaluation corresponds to the currently activated version. If no version is
        /// activated for the evaluation form, the contact evaluation cannot be started. 
        /// 
        ///  <note> 
        /// <para>
        /// Evaluations created through the public API do not contain answer values suggested
        /// from automation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContactEvaluation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactEvaluation">REST API Reference for StartContactEvaluation Operation</seealso>
        Task<StartContactEvaluationResponse> StartContactEvaluationAsync(StartContactEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartContactRecording



        /// <summary>
        /// Starts recording the contact: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the API is called <i>before</i> the agent joins the call, recording starts when
        /// the agent joins the call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the API is called <i>after</i> the agent joins the call, recording starts at the
        /// time of the API call.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// StartContactRecording is a one-time action. For example, if you use StopContactRecording
        /// to stop recording an ongoing call, you can't use StartContactRecording to restart
        /// it. For scenarios where the recording has started and you want to suspend and resume
        /// it, such as when collecting sensitive information (for example, a credit card number),
        /// use SuspendContactRecording and ResumeContactRecording.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to override the recording behavior configured in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
        /// recording behavior</a> block.
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        Task<StartContactRecordingResponse> StartContactRecordingAsync(StartContactRecordingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartContactStreaming



        /// <summary>
        /// Initiates real-time message streaming for a new chat contact.
        /// 
        ///  
        /// <para>
        ///  For more information about message streaming, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-message-streaming.html">Enable
        /// real-time chat message streaming</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactStreaming service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContactStreaming service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactStreaming">REST API Reference for StartContactStreaming Operation</seealso>
        Task<StartContactStreamingResponse> StartContactStreamingAsync(StartContactStreamingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartOutboundVoiceContact



        /// <summary>
        /// Places an outbound call to a contact, and then initiates the flow. It performs the
        /// actions in the flow that's specified (in <code>ContactFlowId</code>).
        /// 
        ///  
        /// <para>
        /// Agents do not initiate the outbound API, which means that they do not dial the contact.
        /// If the flow places an outbound call to a contact, and then puts the contact in queue,
        /// the call is then routed to the agent, like any other inbound case.
        /// </para>
        ///  
        /// <para>
        /// There is a 60-second dialing timeout for this operation. If the call is not connected
        /// after 60 seconds, it fails.
        /// </para>
        ///  <note> 
        /// <para>
        /// UK numbers with a 447 prefix are not allowed by default. Before you can dial these
        /// UK mobile numbers, you must submit a service quota increase request. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Campaign calls are not allowed by default. Before you can make a call with <code>TrafficType</code>
        /// = <code>CAMPAIGN</code>, you must submit a service quota increase request to the quota
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#outbound-communications-quotas">Amazon
        /// Connect campaigns</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOutboundVoiceContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartOutboundVoiceContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DestinationNotAllowedException">
        /// Outbound calls to the destination number are not allowed.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.OutboundContactNotPermittedException">
        /// The contact is not permitted.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        Task<StartOutboundVoiceContactResponse> StartOutboundVoiceContactAsync(StartOutboundVoiceContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTaskContact



        /// <summary>
        /// Initiates a flow to start a new task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTaskContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartTaskContact">REST API Reference for StartTaskContact Operation</seealso>
        Task<StartTaskContactResponse> StartTaskContactAsync(StartTaskContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopContact



        /// <summary>
        /// Ends the specified contact. This call does not work for the following initiation methods:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DISCONNECT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TRANSFER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QUEUE_TRANSFER
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactNotFoundException">
        /// The contact with the specified ID is not active or does not exist. Applies to Voice
        /// calls only, not to Chat, Task, or Voice Callback.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        Task<StopContactResponse> StopContactAsync(StopContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopContactRecording



        /// <summary>
        /// Stops recording a call when a contact is being recorded. StopContactRecording is a
        /// one-time action. If you use StopContactRecording to stop recording an ongoing call,
        /// you can't use StartContactRecording to restart it. For scenarios where the recording
        /// has started and you want to suspend it for sensitive information (for example, to
        /// collect a credit card number), and then restart it, use SuspendContactRecording and
        /// ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        Task<StopContactRecordingResponse> StopContactRecordingAsync(StopContactRecordingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopContactStreaming



        /// <summary>
        /// Ends message streaming on a specified contact. To restart message streaming on that
        /// contact, call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartContactStreaming.html">StartContactStreaming</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactStreaming service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContactStreaming service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactStreaming">REST API Reference for StopContactStreaming Operation</seealso>
        Task<StopContactStreamingResponse> StopContactStreamingAsync(StopContactStreamingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SubmitContactEvaluation



        /// <summary>
        /// Submits a contact evaluation in the specified Amazon Connect instance. Answers included
        /// in the request are merged with existing answers for the given evaluation. If no answers
        /// or notes are passed, the evaluation is submitted with the existing answers and notes.
        /// You can delete an answer or note by passing an empty object (<code>{}</code>) to the
        /// question identifier. 
        /// 
        ///  
        /// <para>
        /// If a contact evaluation is already in submitted state, this operation will trigger
        /// a resubmission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitContactEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitContactEvaluation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SubmitContactEvaluation">REST API Reference for SubmitContactEvaluation Operation</seealso>
        Task<SubmitContactEvaluationResponse> SubmitContactEvaluationAsync(SubmitContactEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SuspendContactRecording



        /// <summary>
        /// When a contact is being recorded, this API suspends recording the call or screen.
        /// For example, you might suspend the call or screen recording while collecting sensitive
        /// information, such as a credit card number. Then use ResumeContactRecording to restart
        /// recording.
        /// 
        ///  
        /// <para>
        /// The period of time that the recording is suspended is filled with silence in the final
        /// recording.
        /// </para>
        ///  
        /// <para>
        /// Voice and screen recordings are supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        Task<SuspendContactRecordingResponse> SuspendContactRecordingAsync(SuspendContactRecordingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// 
        ///  
        /// <para>
        /// Some of the supported resource types are agents, routing profiles, queues, quick connects,
        /// contact flows, agent statuses, hours of operation, phone numbers, security profiles,
        /// and task templates. For a complete list, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/tagging.html">Tagging
        /// resources in Amazon Connect</a>.
        /// </para>
        ///  
        /// <para>
        /// For sample policies that use tags, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_id-based-policy-examples.html">Amazon
        /// Connect Identity-Based Policy Examples</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TransferContact



        /// <summary>
        /// Transfers contacts from one agent or queue to another agent or queue at any point
        /// after a contact is created. You can transfer a contact to another queue by providing
        /// the flow which orchestrates the contact to the destination queue. This gives you more
        /// control over contact handling and helps you adhere to the service level agreement
        /// (SLA) guaranteed to your customers.
        /// 
        ///  
        /// <para>
        /// Note the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Transfer is supported for only <code>TASK</code> contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use both <code>QueueId</code> and <code>UserId</code> in the same call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following flow types are supported: Inbound flow, Transfer to agent flow, and
        /// Transfer to queue flow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>TransferContact</code> API can be called only on active contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A contact cannot be transferred more than 11 times.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TransferContact">REST API Reference for TransferContact Operation</seealso>
        Task<TransferContactResponse> TransferContactAsync(TransferContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAgentStatus



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates agent status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        Task<UpdateAgentStatusResponse> UpdateAgentStatusAsync(UpdateAgentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContact



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Adds or updates user-defined contact information associated with the specified contact.
        /// At least one field to be updated must be present in the request.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can add or update user-defined contact information for both ongoing and completed
        /// contacts.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactAttributes



        /// <summary>
        /// Creates or updates user-defined contact attributes associated with the specified contact.
        /// 
        ///  
        /// <para>
        /// You can create or update user-defined attributes for both ongoing and completed contacts.
        /// For example, while the call is active, you can update the customer's name or the reason
        /// the customer called. You can add notes about steps that the agent took during the
        /// call that display to the next agent that takes the call. You can also update attributes
        /// for a contact using data from your CRM application and save the data with the contact
        /// in Amazon Connect. You could also flag calls for additional analysis, such as legal
        /// review or to identify abusive callers.
        /// </para>
        ///  
        /// <para>
        /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
        /// For information about contact record retention and the maximum size of the contact
        /// record attributes section, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        Task<UpdateContactAttributesResponse> UpdateContactAttributesAsync(UpdateContactAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactEvaluation



        /// <summary>
        /// Updates details about a contact evaluation in the specified Amazon Connect instance.
        /// A contact evaluation must be in draft state. Answers included in the request are merged
        /// with existing answers for the given evaluation. An answer or note can be deleted by
        /// passing an empty object (<code>{}</code>) to the question identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactEvaluation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactEvaluation">REST API Reference for UpdateContactEvaluation Operation</seealso>
        Task<UpdateContactEvaluationResponse> UpdateContactEvaluationAsync(UpdateContactEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactFlowContent



        /// <summary>
        /// Updates the specified flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactFlowContent service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowException">
        /// The flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowContent">REST API Reference for UpdateContactFlowContent Operation</seealso>
        Task<UpdateContactFlowContentResponse> UpdateContactFlowContentAsync(UpdateContactFlowContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactFlowMetadata



        /// <summary>
        /// Updates metadata about specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactFlowMetadata service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowMetadata">REST API Reference for UpdateContactFlowMetadata Operation</seealso>
        Task<UpdateContactFlowMetadataResponse> UpdateContactFlowMetadataAsync(UpdateContactFlowMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactFlowModuleContent



        /// <summary>
        /// Updates specified flow module for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactFlowModuleContent service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowModuleException">
        /// The problems with the module. Please fix before trying again.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleContent">REST API Reference for UpdateContactFlowModuleContent Operation</seealso>
        Task<UpdateContactFlowModuleContentResponse> UpdateContactFlowModuleContentAsync(UpdateContactFlowModuleContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactFlowModuleMetadata



        /// <summary>
        /// Updates metadata about specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactFlowModuleMetadata service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleMetadata">REST API Reference for UpdateContactFlowModuleMetadata Operation</seealso>
        Task<UpdateContactFlowModuleMetadataResponse> UpdateContactFlowModuleMetadataAsync(UpdateContactFlowModuleMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactFlowName



        /// <summary>
        /// The name of the flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactFlowName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowName">REST API Reference for UpdateContactFlowName Operation</seealso>
        Task<UpdateContactFlowNameResponse> UpdateContactFlowNameAsync(UpdateContactFlowNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactSchedule



        /// <summary>
        /// Updates the scheduled time of a task contact that is already scheduled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactSchedule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactSchedule">REST API Reference for UpdateContactSchedule Operation</seealso>
        Task<UpdateContactScheduleResponse> UpdateContactScheduleAsync(UpdateContactScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEvaluationForm



        /// <summary>
        /// Updates details about a specific evaluation form version in the specified Amazon Connect
        /// instance. Question and section identifiers cannot be duplicated within the same evaluation
        /// form.
        /// 
        ///  
        /// <para>
        /// This operation does not support partial updates. Instead it does a full update of
        /// evaluation form content.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluationForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEvaluationForm service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateEvaluationForm">REST API Reference for UpdateEvaluationForm Operation</seealso>
        Task<UpdateEvaluationFormResponse> UpdateEvaluationFormAsync(UpdateEvaluationFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHoursOfOperation



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHoursOfOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateHoursOfOperation">REST API Reference for UpdateHoursOfOperation Operation</seealso>
        Task<UpdateHoursOfOperationResponse> UpdateHoursOfOperationAsync(UpdateHoursOfOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInstanceAttribute



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the value for the specified attribute type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstanceAttribute service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceAttribute">REST API Reference for UpdateInstanceAttribute Operation</seealso>
        Task<UpdateInstanceAttributeResponse> UpdateInstanceAttributeAsync(UpdateInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInstanceStorageConfig



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates an existing configuration for a resource type. This API is idempotent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceStorageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceStorageConfig">REST API Reference for UpdateInstanceStorageConfig Operation</seealso>
        Task<UpdateInstanceStorageConfigResponse> UpdateInstanceStorageConfigAsync(UpdateInstanceStorageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateParticipantRoleConfig



        /// <summary>
        /// Updates timeouts for when human chat participants are to be considered idle, and when
        /// agents are automatically disconnected from a chat due to idleness. You can set four
        /// timers:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Customer idle timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer auto-disconnect timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent idle timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent auto-disconnect timeout
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
        /// up chat timeouts for human participants</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParticipantRoleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateParticipantRoleConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateParticipantRoleConfig">REST API Reference for UpdateParticipantRoleConfig Operation</seealso>
        Task<UpdateParticipantRoleConfigResponse> UpdateParticipantRoleConfigAsync(UpdateParticipantRoleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumber



        /// <summary>
        /// Updates your claimed phone number from its current Amazon Connect instance or traffic
        /// distribution group to another Amazon Connect instance or traffic distribution group
        /// in the same Amazon Web Services Region.
        /// 
        ///  <important> 
        /// <para>
        /// After using this API, you must verify that the phone number is attached to the correct
        /// flow in the target instance or traffic distribution group. You need to do this because
        /// the API switches only the phone number to a new instance or traffic distribution group.
        /// It doesn't migrate the flow configuration of the phone number, too.
        /// </para>
        ///  
        /// <para>
        /// You can call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
        /// API to verify the status of a previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
        /// operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePrompt



        /// <summary>
        /// Updates a prompt.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrompt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrompt service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdatePrompt">REST API Reference for UpdatePrompt Operation</seealso>
        Task<UpdatePromptResponse> UpdatePromptAsync(UpdatePromptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueueHoursOfOperation



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the hours of operation for the specified queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueHoursOfOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueHoursOfOperation">REST API Reference for UpdateQueueHoursOfOperation Operation</seealso>
        Task<UpdateQueueHoursOfOperationResponse> UpdateQueueHoursOfOperationAsync(UpdateQueueHoursOfOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueueMaxContacts



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the maximum number of contacts allowed in a queue before it is considered
        /// full.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueMaxContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueMaxContacts service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueMaxContacts">REST API Reference for UpdateQueueMaxContacts Operation</seealso>
        Task<UpdateQueueMaxContactsResponse> UpdateQueueMaxContactsAsync(UpdateQueueMaxContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueueName



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the name and description of a queue. At least <code>Name</code> or <code>Description</code>
        /// must be provided.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueName">REST API Reference for UpdateQueueName Operation</seealso>
        Task<UpdateQueueNameResponse> UpdateQueueNameAsync(UpdateQueueNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueueOutboundCallerConfig



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the outbound caller ID name, number, and outbound whisper flow for a specified
        /// queue.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the number being used in the input is claimed to a traffic distribution group,
        /// and you are calling this API using an instance in the Amazon Web Services Region where
        /// the traffic distribution group was created, you can use either a full phone number
        /// ARN or UUID value for the <code>OutboundCallerIdNumberId</code> value of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_OutboundCallerConfig">OutboundCallerConfig</a>
        /// request body parameter. However, if the number is claimed to a traffic distribution
        /// group and you are calling this API using an instance in the alternate Amazon Web Services
        /// Region associated with the traffic distribution group, you must provide a full phone
        /// number ARN. If a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  
        /// <para>
        /// Only use the phone number ARN format that doesn't contain <code>instance</code> in
        /// the path, for example, <code>arn:aws:connect:us-east-1:1234567890:phone-number/uuid</code>.
        /// This is the same ARN format that is returned when you call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
        /// API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueOutboundCallerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueOutboundCallerConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueOutboundCallerConfig">REST API Reference for UpdateQueueOutboundCallerConfig Operation</seealso>
        Task<UpdateQueueOutboundCallerConfigResponse> UpdateQueueOutboundCallerConfigAsync(UpdateQueueOutboundCallerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueueStatus



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the status of the queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueStatus">REST API Reference for UpdateQueueStatus Operation</seealso>
        Task<UpdateQueueStatusResponse> UpdateQueueStatusAsync(UpdateQueueStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQuickConnectConfig



        /// <summary>
        /// Updates the configuration settings for the specified quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickConnectConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectConfig">REST API Reference for UpdateQuickConnectConfig Operation</seealso>
        Task<UpdateQuickConnectConfigResponse> UpdateQuickConnectConfigAsync(UpdateQuickConnectConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQuickConnectName



        /// <summary>
        /// Updates the name and description of a quick connect. The request accepts the following
        /// data in JSON format. At least <code>Name</code> or <code>Description</code> must be
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickConnectName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectName">REST API Reference for UpdateQuickConnectName Operation</seealso>
        Task<UpdateQuickConnectNameResponse> UpdateQuickConnectNameAsync(UpdateQuickConnectNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingProfileAgentAvailabilityTimer



        /// <summary>
        /// Whether agents with this routing profile will have their routing order calculated
        /// based on <i>time since their last inbound contact</i> or <i>longest idle time</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileAgentAvailabilityTimer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileAgentAvailabilityTimer service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileAgentAvailabilityTimer">REST API Reference for UpdateRoutingProfileAgentAvailabilityTimer Operation</seealso>
        Task<UpdateRoutingProfileAgentAvailabilityTimerResponse> UpdateRoutingProfileAgentAvailabilityTimerAsync(UpdateRoutingProfileAgentAvailabilityTimerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingProfileConcurrency



        /// <summary>
        /// Updates the channels that agents can handle in the Contact Control Panel (CCP) for
        /// a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileConcurrency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileConcurrency service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileConcurrency">REST API Reference for UpdateRoutingProfileConcurrency Operation</seealso>
        Task<UpdateRoutingProfileConcurrencyResponse> UpdateRoutingProfileConcurrencyAsync(UpdateRoutingProfileConcurrencyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingProfileDefaultOutboundQueue



        /// <summary>
        /// Updates the default outbound queue of a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileDefaultOutboundQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileDefaultOutboundQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileDefaultOutboundQueue">REST API Reference for UpdateRoutingProfileDefaultOutboundQueue Operation</seealso>
        Task<UpdateRoutingProfileDefaultOutboundQueueResponse> UpdateRoutingProfileDefaultOutboundQueueAsync(UpdateRoutingProfileDefaultOutboundQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingProfileName



        /// <summary>
        /// Updates the name and description of a routing profile. The request accepts the following
        /// data in JSON format. At least <code>Name</code> or <code>Description</code> must be
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileName">REST API Reference for UpdateRoutingProfileName Operation</seealso>
        Task<UpdateRoutingProfileNameResponse> UpdateRoutingProfileNameAsync(UpdateRoutingProfileNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingProfileQueues



        /// <summary>
        /// Updates the properties associated with a set of queues for a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileQueues">REST API Reference for UpdateRoutingProfileQueues Operation</seealso>
        Task<UpdateRoutingProfileQueuesResponse> UpdateRoutingProfileQueuesAsync(UpdateRoutingProfileQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRule



        /// <summary>
        /// Updates a rule for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
        /// Function language</a> to code conditions for the rule. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityProfile



        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        Task<UpdateSecurityProfileResponse> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTaskTemplate



        /// <summary>
        /// Updates details about a specific task template in the specified Amazon Connect instance.
        /// This operation does not support partial updates. Instead it does a full update of
        /// template content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.PropertyValidationException">
        /// The property is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTaskTemplate">REST API Reference for UpdateTaskTemplate Operation</seealso>
        Task<UpdateTaskTemplateResponse> UpdateTaskTemplateAsync(UpdateTaskTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficDistribution



        /// <summary>
        /// Updates the traffic distribution for a given traffic distribution group. 
        /// 
        ///  
        /// <para>
        /// For more information about updating a traffic distribution group, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/update-telephony-traffic-distribution.html">Update
        /// telephony traffic distribution across Amazon Web Services Regions </a> in the <i>Amazon
        /// Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrafficDistribution service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTrafficDistribution">REST API Reference for UpdateTrafficDistribution Operation</seealso>
        Task<UpdateTrafficDistributionResponse> UpdateTrafficDistributionAsync(UpdateTrafficDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserHierarchy



        /// <summary>
        /// Assigns the specified hierarchy group to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserHierarchy service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        Task<UpdateUserHierarchyResponse> UpdateUserHierarchyAsync(UpdateUserHierarchyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserHierarchyGroupName



        /// <summary>
        /// Updates the name of the user hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyGroupName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserHierarchyGroupName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyGroupName">REST API Reference for UpdateUserHierarchyGroupName Operation</seealso>
        Task<UpdateUserHierarchyGroupNameResponse> UpdateUserHierarchyGroupNameAsync(UpdateUserHierarchyGroupNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserHierarchyStructure



        /// <summary>
        /// Updates the user hierarchy structure: add, remove, and rename user hierarchy levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyStructure">REST API Reference for UpdateUserHierarchyStructure Operation</seealso>
        Task<UpdateUserHierarchyStructureResponse> UpdateUserHierarchyStructureAsync(UpdateUserHierarchyStructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserIdentityInfo



        /// <summary>
        /// Updates the identity information for the specified user.
        /// 
        ///  <important> 
        /// <para>
        /// We strongly recommend limiting who has the ability to invoke <code>UpdateUserIdentityInfo</code>.
        /// Someone with that ability can change the login credentials of other users by changing
        /// their email address. This poses a security risk to your organization. They can change
        /// the email address of a user to the attacker's email address, and then reset the password
        /// through email. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-best-practices.html">Best
        /// Practices for Security Profiles</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserIdentityInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserIdentityInfo service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        Task<UpdateUserIdentityInfoResponse> UpdateUserIdentityInfoAsync(UpdateUserIdentityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserPhoneConfig



        /// <summary>
        /// Updates the phone configuration settings for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPhoneConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserPhoneConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        Task<UpdateUserPhoneConfigResponse> UpdateUserPhoneConfigAsync(UpdateUserPhoneConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserRoutingProfile



        /// <summary>
        /// Assigns the specified routing profile to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserRoutingProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        Task<UpdateUserRoutingProfileResponse> UpdateUserRoutingProfileAsync(UpdateUserRoutingProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserSecurityProfiles



        /// <summary>
        /// Assigns the specified security profiles to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        Task<UpdateUserSecurityProfilesResponse> UpdateUserSecurityProfilesAsync(UpdateUserSecurityProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}