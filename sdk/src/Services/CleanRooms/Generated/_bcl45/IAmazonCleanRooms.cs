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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CleanRooms.Model;

namespace Amazon.CleanRooms
{
    /// <summary>
    /// Interface for accessing CleanRooms
    ///
    /// Welcome to the <i>Clean Rooms API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Clean Rooms is an Amazon Web Services service that helps multiple parties to join
    /// their data together in a secure collaboration workspace. In the collaboration, members
    /// who can query and receive results can get insights into the collective datasets without
    /// either party getting access to the other party's raw data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Clean Rooms concepts, procedures, and best practices, see the
    /// <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/what-is.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCleanRooms : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICleanRoomsPaginatorFactory Paginators { get; }

        
        #region  BatchGetCollaborationAnalysisTemplate


        /// <summary>
        /// Retrieves multiple analysis templates within a collaboration by their Amazon Resource
        /// Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollaborationAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the BatchGetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        BatchGetCollaborationAnalysisTemplateResponse BatchGetCollaborationAnalysisTemplate(BatchGetCollaborationAnalysisTemplateRequest request);



        /// <summary>
        /// Retrieves multiple analysis templates within a collaboration by their Amazon Resource
        /// Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollaborationAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        Task<BatchGetCollaborationAnalysisTemplateResponse> BatchGetCollaborationAnalysisTemplateAsync(BatchGetCollaborationAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetSchema


        /// <summary>
        /// Retrieves multiple schemas by their identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema service method.</param>
        /// 
        /// <returns>The response from the BatchGetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        BatchGetSchemaResponse BatchGetSchema(BatchGetSchemaRequest request);



        /// <summary>
        /// Retrieves multiple schemas by their identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        Task<BatchGetSchemaResponse> BatchGetSchemaAsync(BatchGetSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAnalysisTemplate


        /// <summary>
        /// Creates a new analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        CreateAnalysisTemplateResponse CreateAnalysisTemplate(CreateAnalysisTemplateRequest request);



        /// <summary>
        /// Creates a new analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        Task<CreateAnalysisTemplateResponse> CreateAnalysisTemplateAsync(CreateAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCollaboration


        /// <summary>
        /// Creates a new collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration service method.</param>
        /// 
        /// <returns>The response from the CreateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        CreateCollaborationResponse CreateCollaboration(CreateCollaborationRequest request);



        /// <summary>
        /// Creates a new collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        Task<CreateCollaborationResponse> CreateCollaborationAsync(CreateCollaborationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfiguredTable


        /// <summary>
        /// Creates a new configured table resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        CreateConfiguredTableResponse CreateConfiguredTable(CreateConfiguredTableRequest request);



        /// <summary>
        /// Creates a new configured table resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        Task<CreateConfiguredTableResponse> CreateConfiguredTableAsync(CreateConfiguredTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfiguredTableAnalysisRule


        /// <summary>
        /// Creates a new analysis rule for a configured table. Currently, only one analysis rule
        /// can be created for a given configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        CreateConfiguredTableAnalysisRuleResponse CreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request);



        /// <summary>
        /// Creates a new analysis rule for a configured table. Currently, only one analysis rule
        /// can be created for a given configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        Task<CreateConfiguredTableAnalysisRuleResponse> CreateConfiguredTableAnalysisRuleAsync(CreateConfiguredTableAnalysisRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfiguredTableAssociation


        /// <summary>
        /// Creates a configured table association. A configured table association links a configured
        /// table with a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        CreateConfiguredTableAssociationResponse CreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request);



        /// <summary>
        /// Creates a configured table association. A configured table association links a configured
        /// table with a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        Task<CreateConfiguredTableAssociationResponse> CreateConfiguredTableAssociationAsync(CreateConfiguredTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMembership


        /// <summary>
        /// Creates a membership for a specific collaboration identifier and joins the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse CreateMembership(CreateMembershipRequest request);



        /// <summary>
        /// Creates a membership for a specific collaboration identifier and joins the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAnalysisTemplate


        /// <summary>
        /// Deletes an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        DeleteAnalysisTemplateResponse DeleteAnalysisTemplate(DeleteAnalysisTemplateRequest request);



        /// <summary>
        /// Deletes an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        Task<DeleteAnalysisTemplateResponse> DeleteAnalysisTemplateAsync(DeleteAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCollaboration


        /// <summary>
        /// Deletes a collaboration. It can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration service method.</param>
        /// 
        /// <returns>The response from the DeleteCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        DeleteCollaborationResponse DeleteCollaboration(DeleteCollaborationRequest request);



        /// <summary>
        /// Deletes a collaboration. It can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        Task<DeleteCollaborationResponse> DeleteCollaborationAsync(DeleteCollaborationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfiguredTable


        /// <summary>
        /// Deletes a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        DeleteConfiguredTableResponse DeleteConfiguredTable(DeleteConfiguredTableRequest request);



        /// <summary>
        /// Deletes a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        Task<DeleteConfiguredTableResponse> DeleteConfiguredTableAsync(DeleteConfiguredTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfiguredTableAnalysisRule


        /// <summary>
        /// Deletes a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        DeleteConfiguredTableAnalysisRuleResponse DeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request);



        /// <summary>
        /// Deletes a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        Task<DeleteConfiguredTableAnalysisRuleResponse> DeleteConfiguredTableAnalysisRuleAsync(DeleteConfiguredTableAnalysisRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfiguredTableAssociation


        /// <summary>
        /// Deletes a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        DeleteConfiguredTableAssociationResponse DeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request);



        /// <summary>
        /// Deletes a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        Task<DeleteConfiguredTableAssociationResponse> DeleteConfiguredTableAssociationAsync(DeleteConfiguredTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMember


        /// <summary>
        /// Removes the specified member from a collaboration. The removed member is placed in
        /// the Removed status and can't interact with the collaboration. The removed member's
        /// data is inaccessible to active members of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        DeleteMemberResponse DeleteMember(DeleteMemberRequest request);



        /// <summary>
        /// Removes the specified member from a collaboration. The removed member is placed in
        /// the Removed status and can't interact with the collaboration. The removed member's
        /// data is inaccessible to active members of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMembership


        /// <summary>
        /// Deletes a specified membership. All resources under a membership must be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request);



        /// <summary>
        /// Deletes a specified membership. All resources under a membership must be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        Task<DeleteMembershipResponse> DeleteMembershipAsync(DeleteMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAnalysisTemplate


        /// <summary>
        /// Retrieves an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the GetAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        GetAnalysisTemplateResponse GetAnalysisTemplate(GetAnalysisTemplateRequest request);



        /// <summary>
        /// Retrieves an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        Task<GetAnalysisTemplateResponse> GetAnalysisTemplateAsync(GetAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCollaboration


        /// <summary>
        /// Returns metadata about a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration service method.</param>
        /// 
        /// <returns>The response from the GetCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        GetCollaborationResponse GetCollaboration(GetCollaborationRequest request);



        /// <summary>
        /// Returns metadata about a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        Task<GetCollaborationResponse> GetCollaborationAsync(GetCollaborationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCollaborationAnalysisTemplate


        /// <summary>
        /// Retrieves an analysis template within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        GetCollaborationAnalysisTemplateResponse GetCollaborationAnalysisTemplate(GetCollaborationAnalysisTemplateRequest request);



        /// <summary>
        /// Retrieves an analysis template within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        Task<GetCollaborationAnalysisTemplateResponse> GetCollaborationAnalysisTemplateAsync(GetCollaborationAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfiguredTable


        /// <summary>
        /// Retrieves a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        GetConfiguredTableResponse GetConfiguredTable(GetConfiguredTableRequest request);



        /// <summary>
        /// Retrieves a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        Task<GetConfiguredTableResponse> GetConfiguredTableAsync(GetConfiguredTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfiguredTableAnalysisRule


        /// <summary>
        /// Retrieves a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        GetConfiguredTableAnalysisRuleResponse GetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request);



        /// <summary>
        /// Retrieves a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        Task<GetConfiguredTableAnalysisRuleResponse> GetConfiguredTableAnalysisRuleAsync(GetConfiguredTableAnalysisRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfiguredTableAssociation


        /// <summary>
        /// Retrieves a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        GetConfiguredTableAssociationResponse GetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request);



        /// <summary>
        /// Retrieves a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        Task<GetConfiguredTableAssociationResponse> GetConfiguredTableAssociationAsync(GetConfiguredTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMembership


        /// <summary>
        /// Retrieves a specified membership for an identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        GetMembershipResponse GetMembership(GetMembershipRequest request);



        /// <summary>
        /// Retrieves a specified membership for an identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        Task<GetMembershipResponse> GetMembershipAsync(GetMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProtectedQuery


        /// <summary>
        /// Returns query processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the GetProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        GetProtectedQueryResponse GetProtectedQuery(GetProtectedQueryRequest request);



        /// <summary>
        /// Returns query processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        Task<GetProtectedQueryResponse> GetProtectedQueryAsync(GetProtectedQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSchema


        /// <summary>
        /// Retrieves the schema for a relation within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        GetSchemaResponse GetSchema(GetSchemaRequest request);



        /// <summary>
        /// Retrieves the schema for a relation within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSchemaAnalysisRule


        /// <summary>
        /// Retrieves a schema analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        GetSchemaAnalysisRuleResponse GetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request);



        /// <summary>
        /// Retrieves a schema analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        Task<GetSchemaAnalysisRuleResponse> GetSchemaAnalysisRuleAsync(GetSchemaAnalysisRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAnalysisTemplates


        /// <summary>
        /// Lists analysis templates that the caller owns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisTemplates service method.</param>
        /// 
        /// <returns>The response from the ListAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        ListAnalysisTemplatesResponse ListAnalysisTemplates(ListAnalysisTemplatesRequest request);



        /// <summary>
        /// Lists analysis templates that the caller owns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        Task<ListAnalysisTemplatesResponse> ListAnalysisTemplatesAsync(ListAnalysisTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCollaborationAnalysisTemplates


        /// <summary>
        /// Lists analysis templates within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationAnalysisTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        ListCollaborationAnalysisTemplatesResponse ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request);



        /// <summary>
        /// Lists analysis templates within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationAnalysisTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborationAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        Task<ListCollaborationAnalysisTemplatesResponse> ListCollaborationAnalysisTemplatesAsync(ListCollaborationAnalysisTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCollaborations


        /// <summary>
        /// Lists collaborations the caller owns, is active in, or has been invited to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        ListCollaborationsResponse ListCollaborations(ListCollaborationsRequest request);



        /// <summary>
        /// Lists collaborations the caller owns, is active in, or has been invited to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollaborations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        Task<ListCollaborationsResponse> ListCollaborationsAsync(ListCollaborationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfiguredTableAssociations


        /// <summary>
        /// Lists configured table associations for a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTableAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        ListConfiguredTableAssociationsResponse ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request);



        /// <summary>
        /// Lists configured table associations for a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredTableAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        Task<ListConfiguredTableAssociationsResponse> ListConfiguredTableAssociationsAsync(ListConfiguredTableAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfiguredTables


        /// <summary>
        /// Lists configured tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        ListConfiguredTablesResponse ListConfiguredTables(ListConfiguredTablesRequest request);



        /// <summary>
        /// Lists configured tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        Task<ListConfiguredTablesResponse> ListConfiguredTablesAsync(ListConfiguredTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists all members within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);



        /// <summary>
        /// Lists all members within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemberships


        /// <summary>
        /// Lists all memberships resources within the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse ListMemberships(ListMembershipsRequest request);



        /// <summary>
        /// Lists all memberships resources within the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProtectedQueries


        /// <summary>
        /// Lists protected queries, sorted by the most recent query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries service method.</param>
        /// 
        /// <returns>The response from the ListProtectedQueries service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        ListProtectedQueriesResponse ListProtectedQueries(ListProtectedQueriesRequest request);



        /// <summary>
        /// Lists protected queries, sorted by the most recent query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectedQueries service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        Task<ListProtectedQueriesResponse> ListProtectedQueriesAsync(ListProtectedQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// Lists the schemas for relations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);



        /// <summary>
        /// Lists the schemas for relations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all of the tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartProtectedQuery


        /// <summary>
        /// Creates a protected query that is started by Clean Rooms .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the StartProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        StartProtectedQueryResponse StartProtectedQuery(StartProtectedQueryRequest request);



        /// <summary>
        /// Creates a protected query that is started by Clean Rooms .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        Task<StartProtectedQueryResponse> StartProtectedQueryAsync(StartProtectedQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAnalysisTemplate


        /// <summary>
        /// Updates the analysis template metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        UpdateAnalysisTemplateResponse UpdateAnalysisTemplate(UpdateAnalysisTemplateRequest request);



        /// <summary>
        /// Updates the analysis template metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        Task<UpdateAnalysisTemplateResponse> UpdateAnalysisTemplateAsync(UpdateAnalysisTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCollaboration


        /// <summary>
        /// Updates collaboration metadata and can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration service method.</param>
        /// 
        /// <returns>The response from the UpdateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        UpdateCollaborationResponse UpdateCollaboration(UpdateCollaborationRequest request);



        /// <summary>
        /// Updates collaboration metadata and can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        Task<UpdateCollaborationResponse> UpdateCollaborationAsync(UpdateCollaborationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfiguredTable


        /// <summary>
        /// Updates a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        UpdateConfiguredTableResponse UpdateConfiguredTable(UpdateConfiguredTableRequest request);



        /// <summary>
        /// Updates a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        Task<UpdateConfiguredTableResponse> UpdateConfiguredTableAsync(UpdateConfiguredTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfiguredTableAnalysisRule


        /// <summary>
        /// Updates a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        UpdateConfiguredTableAnalysisRuleResponse UpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request);



        /// <summary>
        /// Updates a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        Task<UpdateConfiguredTableAnalysisRuleResponse> UpdateConfiguredTableAnalysisRuleAsync(UpdateConfiguredTableAnalysisRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfiguredTableAssociation


        /// <summary>
        /// Updates a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        UpdateConfiguredTableAssociationResponse UpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request);



        /// <summary>
        /// Updates a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        Task<UpdateConfiguredTableAssociationResponse> UpdateConfiguredTableAssociationAsync(UpdateConfiguredTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMembership


        /// <summary>
        /// Updates a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request);



        /// <summary>
        /// Updates a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        Task<UpdateMembershipResponse> UpdateMembershipAsync(UpdateMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProtectedQuery


        /// <summary>
        /// Updates the processing of a currently running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        UpdateProtectedQueryResponse UpdateProtectedQuery(UpdateProtectedQueryRequest request);



        /// <summary>
        /// Updates the processing of a currently running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        Task<UpdateProtectedQueryResponse> UpdateProtectedQueryAsync(UpdateProtectedQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}