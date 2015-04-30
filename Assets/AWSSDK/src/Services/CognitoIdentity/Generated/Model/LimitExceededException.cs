//
// Copyright 2014-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//
// Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
// You may not use this file except in compliance with the License.
// A copy of the License is located in the "license" file accompanying this file.
// See the License for the specific language governing permissions and limitations under the License.
//
//

/*
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
    ///<summary>
    /// CognitoIdentity exception
    /// </summary>
    public class LimitExceededException : AmazonCognitoIdentityException 
    {
        /// <summary>
        /// Constructs a new LimitExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public LimitExceededException(string message) 
            : base(message) {}
          
        public LimitExceededException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public LimitExceededException(Exception innerException) 
            : base(innerException) {}
            
        public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        public LimitExceededException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

    }
}