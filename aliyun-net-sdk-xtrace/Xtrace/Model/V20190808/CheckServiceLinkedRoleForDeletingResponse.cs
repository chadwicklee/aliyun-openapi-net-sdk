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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.xtrace.Model.V20190808
{
	public class CheckServiceLinkedRoleForDeletingResponse : AcsResponse
	{

		private string requestId;

		private bool? deletable;

		private List<CheckServiceLinkedRoleForDeleting_RoleUsagesItem> roleUsages;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Deletable
		{
			get
			{
				return deletable;
			}
			set	
			{
				deletable = value;
			}
		}

		public List<CheckServiceLinkedRoleForDeleting_RoleUsagesItem> RoleUsages
		{
			get
			{
				return roleUsages;
			}
			set	
			{
				roleUsages = value;
			}
		}

		public class CheckServiceLinkedRoleForDeleting_RoleUsagesItem
		{

			private string region;

			private List<string> resources;

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public List<string> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}
		}
	}
}