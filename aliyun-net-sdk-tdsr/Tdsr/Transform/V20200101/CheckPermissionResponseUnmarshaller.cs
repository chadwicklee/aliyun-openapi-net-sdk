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
using Aliyun.Acs.tdsr.Model.V20200101;

namespace Aliyun.Acs.tdsr.Transform.V20200101
{
    public class CheckPermissionResponseUnmarshaller
    {
        public static CheckPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckPermissionResponse checkPermissionResponse = new CheckPermissionResponse();

			checkPermissionResponse.HttpResponse = _ctx.HttpResponse;
			checkPermissionResponse.RequestId = _ctx.StringValue("CheckPermission.RequestId");
			checkPermissionResponse.Success = _ctx.BooleanValue("CheckPermission.Success");
			checkPermissionResponse.ErrMessage = _ctx.StringValue("CheckPermission.ErrMessage");
        
			return checkPermissionResponse;
        }
    }
}
