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
    using System.Net;
    using System.Collections.Generic;
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DescribeConnectionDetail operation
      /// </summary>
      internal class DescribeConnectionDetailResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          DescribeConnectionDetailResponse response = new DescribeConnectionDetailResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private void UnmarshallResult(JsonUnmarshallerContext context,DescribeConnectionDetailResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("connectionId", targetDepth))
              {
                response.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionName", targetDepth))
              {
                response.ConnectionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionState", targetDepth))
              {
                response.ConnectionState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("region", targetDepth))
              {
                response.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                response.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("bandwidth", targetDepth))
              {
                response.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionCosts", targetDepth))
              {
                response.ConnectionCosts = new List<ConnectionCost>();
                        ConnectionCostUnmarshaller unmarshaller = ConnectionCostUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     response.ConnectionCosts.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("orderSteps", targetDepth))
              {
                response.OrderSteps = new List<ConnectionOrderStep>();
                        ConnectionOrderStepUnmarshaller unmarshaller = ConnectionOrderStepUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     response.OrderSteps.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectServerException"))
          {
            return new DirectConnectServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectClientException"))
          {
            return new DirectConnectClientException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonDirectConnectException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeConnectionDetailResponseUnmarshaller instance;
        public static DescribeConnectionDetailResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeConnectionDetailResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  