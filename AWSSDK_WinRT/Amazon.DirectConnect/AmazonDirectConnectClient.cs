/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.DirectConnect.Model;
using Amazon.DirectConnect.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Implementation for accessing AmazonDirectConnect.
    /// 
    /// <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to Amazon Web Services (AWS). Using
    /// AWS Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in
    /// many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than
    /// Internet-based connections.</para> <para>The AWS Direct Connect API Reference provides descriptions, syntax, and usage examples for each of
    /// the actions and data types for AWS Direct Connect. Use the following links to get started using the <i>AWS Direct Connect API Reference</i>
    /// :</para>
    /// <ul>
    /// <li> Actions: An alphabetical list of all AWS Direct Connect actions.</li>
    /// <li> Data Types: An alphabetical list of all AWS Direct Connect data types.</li>
    /// <li> Common Query Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// 
    /// </ul>
    /// </summary>
	public partial class AmazonDirectConnectClient : AmazonWebServiceClient, Amazon.DirectConnect.IAmazonDirectConnect
	{

		AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectConnectConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials and an
        /// AmazonDirectConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para>Creates a new network connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection
        /// links your internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of
        /// the cable is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web
        /// Services in the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a
        /// connection in one region does not provide connectivity to other regions.</para>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest createConnectionRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateConnectionRequestMarshaller();
			var unmarshaller = CreateConnectionResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateConnectionRequest, CreateConnectionResponse>(createConnectionRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC). </para>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        /// service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreatePrivateVirtualInterfaceRequestMarshaller();
			var unmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreatePrivateVirtualInterfaceRequest, CreatePrivateVirtualInterfaceResponse>(createPrivateVirtualInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3). </para>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreatePublicVirtualInterfaceRequestMarshaller();
			var unmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreatePublicVirtualInterfaceRequest, CreatePublicVirtualInterfaceResponse>(createPublicVirtualInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Deletes the connection.</para> <para>Deleting a connection only stops the AWS Direct Connect port hour and data transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with the providers of those services.</para>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest deleteConnectionRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeleteConnectionRequestMarshaller();
			var unmarshaller = DeleteConnectionResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeleteConnectionRequest, DeleteConnectionResponse>(deleteConnectionRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeleteVirtualInterfaceRequestMarshaller();
			var unmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeleteVirtualInterfaceRequest, DeleteVirtualInterfaceResponse>(deleteVirtualInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Displays details about a specific connection including the order steps for the connection and the current state of the connection
        /// order.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail service method
        /// on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeConnectionDetailResponse> DescribeConnectionDetailAsync(DescribeConnectionDetailRequest describeConnectionDetailRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeConnectionDetailRequestMarshaller();
			var unmarshaller = DescribeConnectionDetailResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeConnectionDetailRequest, DescribeConnectionDetailResponse>(describeConnectionDetailRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest describeConnectionsRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeConnectionsRequestMarshaller();
			var unmarshaller = DescribeConnectionsResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeConnectionsRequest, DescribeConnectionsResponse>(describeConnectionsRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Displays additional ordering step details for a specified offering.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferingDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeOfferingDetailResponse> DescribeOfferingDetailAsync(DescribeOfferingDetailRequest describeOfferingDetailRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeOfferingDetailRequestMarshaller();
			var unmarshaller = DescribeOfferingDetailResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeOfferingDetailRequest, DescribeOfferingDetailResponse>(describeOfferingDetailRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Describes one or more of the offerings that are currently available for creating new connections. The results include offerings for
        /// all regions.</para> <para>To order a new connection you need to select a specific offering ID.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeOfferingsResponse> DescribeOfferingsAsync(DescribeOfferingsRequest describeOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeOfferingsRequestMarshaller();
			var unmarshaller = DescribeOfferingsResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeOfferingsRequest, DescribeOfferingsResponse>(describeOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the EC2 CreateVpnGateway action.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
        /// AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeVirtualGatewaysRequestMarshaller();
			var unmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeVirtualGatewaysRequest, DescribeVirtualGatewaysResponse>(describeVirtualGatewaysRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
        /// method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectServerException" />
        /// <exception cref="T:Amazon.DirectConnect.Model.DirectConnectClientException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeVirtualInterfacesRequestMarshaller();
			var unmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeVirtualInterfacesRequest, DescribeVirtualInterfacesResponse>(describeVirtualInterfacesRequest, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
	}
}