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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceGroupsResponseUnmarshaller
    {
        public static ListFaceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFaceGroupsResponse listFaceGroupsResponse = new ListFaceGroupsResponse();

			listFaceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listFaceGroupsResponse.RequestId = _ctx.StringValue("ListFaceGroups.RequestId");
			listFaceGroupsResponse.NextMarker = _ctx.StringValue("ListFaceGroups.NextMarker");

			List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem> listFaceGroupsResponse_faceGroups = new List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem>();
			for (int i = 0; i < _ctx.Length("ListFaceGroups.FaceGroups.Length"); i++) {
				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem faceGroupsItem = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem();
				faceGroupsItem.GroupId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupId");
				faceGroupsItem.GroupName = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupName");
				faceGroupsItem.FaceCount = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].FaceCount");
				faceGroupsItem.CreateTime = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].CreateTime");
				faceGroupsItem.ModifyTime = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].ModifyTime");
				faceGroupsItem.RemarksA = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksA");
				faceGroupsItem.RemarksB = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksB");
				faceGroupsItem.RemarksC = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksC");
				faceGroupsItem.RemarksD = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksD");
				faceGroupsItem.RemarksArrayA = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayA");
				faceGroupsItem.RemarksArrayB = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayB");
				faceGroupsItem.ExternalId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].ExternalId");
				faceGroupsItem.ImageCount = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].ImageCount");
				faceGroupsItem.Gender = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].Gender");
				faceGroupsItem.MaxAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].MaxAge");
				faceGroupsItem.AverageAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].AverageAge");
				faceGroupsItem.MinAge = _ctx.FloatValue("ListFaceGroups.FaceGroups["+ i +"].MinAge");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace groupCoverFace = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace();
				groupCoverFace.FaceId = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceId");
				groupCoverFace.ImageUri = _ctx.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ImageUri");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary faceBoundary = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary();
				faceBoundary.Left = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Left");
				faceBoundary.Top = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Top");
				faceBoundary.Width = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Width");
				faceBoundary.Height = _ctx.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Height");
				groupCoverFace.FaceBoundary = faceBoundary;
				faceGroupsItem.GroupCoverFace = groupCoverFace;

				listFaceGroupsResponse_faceGroups.Add(faceGroupsItem);
			}
			listFaceGroupsResponse.FaceGroups = listFaceGroupsResponse_faceGroups;
        
			return listFaceGroupsResponse;
        }
    }
}
