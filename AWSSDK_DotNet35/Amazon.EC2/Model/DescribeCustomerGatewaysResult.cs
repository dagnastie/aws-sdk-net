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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeCustomerGatewaysResult : AmazonWebServiceResponse
    {
        
        private List<CustomerGateway> customerGateways = new List<CustomerGateway>();


        /// <summary>
        /// Information about one or more customer gateways.
        ///  
        /// </summary>
        public List<CustomerGateway> CustomerGateways
        {
            get { return this.customerGateways; }
            set { this.customerGateways = value; }
        }

        // Check to see if CustomerGateways property is set
        internal bool IsSetCustomerGateways()
        {
            return this.customerGateways.Count > 0;
        }
    }
}
