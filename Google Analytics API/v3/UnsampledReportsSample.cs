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
//     Build date: 01/02/2017 22:31:48
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the analytics v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Views and manages your Google Analytics data.
// API Documentation Link https://developers.google.com/analytics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/analytics/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.analytics.v3/ 
// Install Command: PM>  Install-Package Google.Apis.analytics.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.analytics.v3;
using Google.Apis.analytics.v3.Data;
using System;

namespace GoogleSamplecSharpSample.analyticsv3.Methods
{
  
    public static class UnsampledReportsSample
    {


        /// <summary>
        /// Deletes an unsampled report. 
        /// Documentation https://developers.google.com/analytics/v3/reference/unsampledReports/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to delete the unsampled report for.</param>
        /// <param name="webPropertyId">Web property ID to delete the unsampled reports for.</param>
        /// <param name="profileId">View (Profile) ID to delete the unsampled report for.</param>
        /// <param name="unsampledReportId">ID of the unsampled report to be deleted.</param>
        public static void Delete(analyticsService service, string accountId, string webPropertyId, string profileId, string unsampledReportId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (unsampledReportId == null)
                    throw new ArgumentNullException(unsampledReportId);

                // Make the request.
                return service.UnsampledReports.Delete(accountId, webPropertyId, profileId, unsampledReportId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request UnsampledReports.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Returns a single unsampled report. 
        /// Documentation https://developers.google.com/analytics/v3/reference/unsampledReports/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to retrieve unsampled report for.</param>
        /// <param name="webPropertyId">Web property ID to retrieve unsampled reports for.</param>
        /// <param name="profileId">View (Profile) ID to retrieve unsampled report for.</param>
        /// <param name="unsampledReportId">ID of the unsampled report to retrieve.</param>
        /// <returns>UnsampledReportResponse</returns>
        public static UnsampledReport Get(analyticsService service, string accountId, string webPropertyId, string profileId, string unsampledReportId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (unsampledReportId == null)
                    throw new ArgumentNullException(unsampledReportId);

                // Make the request.
                return service.UnsampledReports.Get(accountId, webPropertyId, profileId, unsampledReportId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request UnsampledReports.Get failed.", ex);
            }
        }


        /// <summary>
        /// Create a new unsampled report. 
        /// Documentation https://developers.google.com/analytics/v3/reference/unsampledReports/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to create the unsampled report for.</param>
        /// <param name="webPropertyId">Web property ID to create the unsampled report for.</param>
        /// <param name="profileId">View (Profile) ID to create the unsampled report for.</param>
        /// <param name="body">A valid analytics v3 body.</param>
        /// <returns>UnsampledReportResponse</returns>
        public static UnsampledReport Insert(analyticsService service, string accountId, string webPropertyId, string profileId, UnsampledReport body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.UnsampledReports.Insert(body, accountId, webPropertyId, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request UnsampledReports.Insert failed.", ex);
            }
        }

        public class UnsampledReportsListOptionalParms
        {
            /// The maximum number of unsampled reports to include in this response.
            public int Max-results { get; set; }  
            /// An index of the first unsampled report to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.
            public int Start-index { get; set; }  
        
        }
 
        /// <summary>
        /// Lists unsampled reports to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/unsampledReports/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated analytics service.</param>  
        /// <param name="accountId">Account ID to retrieve unsampled reports for. Must be a specific account ID, ~all is not supported.</param>
        /// <param name="webPropertyId">Web property ID to retrieve unsampled reports for. Must be a specific web property ID, ~all is not supported.</param>
        /// <param name="profileId">View (Profile) ID to retrieve unsampled reports for. Must be a specific view (profile) ID, ~all is not supported.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>UnsampledReportsResponse</returns>
        public static UnsampledReports List(analyticsService service, string accountId, string webPropertyId, string profileId, UnsampledReportsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.UnsampledReports.List(accountId, webPropertyId, profileId);

                // Applying optional parameters to the request.                
                request = (UnsampledReportsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request UnsampledReports.List failed.", ex);
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