/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnDomainDetailResponseUnmarshaller
    {
        public static DescribeCdnDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnDomainDetailResponse describeCdnDomainDetailResponse = new DescribeCdnDomainDetailResponse();

			describeCdnDomainDetailResponse.HttpResponse = context.HttpResponse;
			describeCdnDomainDetailResponse.RequestId = context.StringValue("DescribeCdnDomainDetail.RequestId");

			DescribeCdnDomainDetailResponse.GetDomainDetailModel_ getDomainDetailModel = new DescribeCdnDomainDetailResponse.GetDomainDetailModel_();
			getDomainDetailModel.GmtCreated = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtCreated");
			getDomainDetailModel.GmtModified = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.GmtModified");
			getDomainDetailModel.SourceType = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourceType");
			getDomainDetailModel.DomainStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainStatus");
			getDomainDetailModel.SourcePort = context.IntegerValue("DescribeCdnDomainDetail.GetDomainDetailModel.SourcePort");
			getDomainDetailModel.CdnType = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CdnType");
			getDomainDetailModel.Cname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Cname");
			getDomainDetailModel.HttpsCname = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.HttpsCname");
			getDomainDetailModel.DomainName = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.DomainName");
			getDomainDetailModel.Description = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Description");
			getDomainDetailModel.ServerCertificateStatus = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificateStatus");
			getDomainDetailModel.ServerCertificate = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.ServerCertificate");
			getDomainDetailModel.Scope = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Scope");
			getDomainDetailModel.CertificateName = context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.CertificateName");

			List<string> sources = new List<string>();
			for (int i = 0; i < context.Length("DescribeCdnDomainDetail.GetDomainDetailModel.Sources.Length"); i++) {
				sources.Add(context.StringValue("DescribeCdnDomainDetail.GetDomainDetailModel.Sources["+ i +"]"));
			}
			getDomainDetailModel.Sources = sources;
			describeCdnDomainDetailResponse.GetDomainDetailModel = getDomainDetailModel;
        
			return describeCdnDomainDetailResponse;
        }
    }
}