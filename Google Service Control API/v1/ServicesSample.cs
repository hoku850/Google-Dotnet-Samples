﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:34:22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the ServiceControl v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Google Service Control provides control plane functionality to managed services, such as logging, monitoring, and status checks.
// API Documentation Link https://cloud.google.com/service-control/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/ServiceControl/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.ServiceControl.v1/ 
// Install Command: PM>  Install-Package Google.Apis.ServiceControl.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.ServiceControl.v1;
using Google.Apis.ServiceControl.v1.Data;
using System;

namespace GoogleSamplecSharpSample.ServiceControlv1.Methods
{
  
    public static class ServicesSample
    {


        /// <summary>
        /// Checks an operation with Google Service Control to decide whether
the given operation should proceed. It should be called before the
operation is executed.

If feasible, the client should cache the check results and reuse them for
60 seconds. In case of server errors, the client can rely on the cached
results for longer time.

NOTE: the `CheckRequest` has the size limit of 1MB.

This method requires the `servicemanagement.services.check` permission
on the specified service. For more information, see
[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/check
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ServiceControl service.</param>  
        /// <param name="serviceName">The service name as specified in its service configuration. For example,
`"pubsub.googleapis.com"`.

See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid ServiceControl v1 body.</param>
        /// <returns>CheckResponseResponse</returns>
        public static CheckResponse Check(ServiceControlService service, string serviceName, CheckRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.Check(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.Check failed.", ex);
            }
        }


        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and
metrics. It should be called after an operation is completed.

If feasible, the client should aggregate reporting data for up to 5
seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
reduce data loss during client crashes. Clients should carefully choose
the aggregation time window to avoid data loss risk more than 0.01%
for business and compliance reasons.

NOTE: the `ReportRequest` has the size limit of 1MB.

This method requires the `servicemanagement.services.report` permission
on the specified service. For more information, see
[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/report
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ServiceControl service.</param>  
        /// <param name="serviceName">The service name as specified in its service configuration. For example,
`"pubsub.googleapis.com"`.

See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid ServiceControl v1 body.</param>
        /// <returns>ReportResponseResponse</returns>
        public static ReportResponse Report(ServiceControlService service, string serviceName, ReportRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.Report(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.Report failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}