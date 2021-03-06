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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyAutoSnapshotPolicyRequest : RpcAcsRequest<ModifyAutoSnapshotPolicyResponse>
    {
        public ModifyAutoSnapshotPolicyRequest()
            : base("Ecs", "2014-05-26", "ModifyAutoSnapshotPolicy")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private bool? systemDiskPolicyEnabled;

		private int? systemDiskPolicyTimePeriod;

		private int? systemDiskPolicyRetentionDays;

		private bool? systemDiskPolicyRetentionLastWeek;

		private bool? dataDiskPolicyEnabled;

		private int? dataDiskPolicyTimePeriod;

		private int? dataDiskPolicyRetentionDays;

		private bool? dataDiskPolicyRetentionLastWeek;

		private string ownerAccount;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public bool? SystemDiskPolicyEnabled
		{
			get
			{
				return systemDiskPolicyEnabled;
			}
			set	
			{
				systemDiskPolicyEnabled = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyEnabled", value.ToString());
			}
		}

		public int? SystemDiskPolicyTimePeriod
		{
			get
			{
				return systemDiskPolicyTimePeriod;
			}
			set	
			{
				systemDiskPolicyTimePeriod = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyTimePeriod", value.ToString());
			}
		}

		public int? SystemDiskPolicyRetentionDays
		{
			get
			{
				return systemDiskPolicyRetentionDays;
			}
			set	
			{
				systemDiskPolicyRetentionDays = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyRetentionDays", value.ToString());
			}
		}

		public bool? SystemDiskPolicyRetentionLastWeek
		{
			get
			{
				return systemDiskPolicyRetentionLastWeek;
			}
			set	
			{
				systemDiskPolicyRetentionLastWeek = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskPolicyRetentionLastWeek", value.ToString());
			}
		}

		public bool? DataDiskPolicyEnabled
		{
			get
			{
				return dataDiskPolicyEnabled;
			}
			set	
			{
				dataDiskPolicyEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyEnabled", value.ToString());
			}
		}

		public int? DataDiskPolicyTimePeriod
		{
			get
			{
				return dataDiskPolicyTimePeriod;
			}
			set	
			{
				dataDiskPolicyTimePeriod = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyTimePeriod", value.ToString());
			}
		}

		public int? DataDiskPolicyRetentionDays
		{
			get
			{
				return dataDiskPolicyRetentionDays;
			}
			set	
			{
				dataDiskPolicyRetentionDays = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyRetentionDays", value.ToString());
			}
		}

		public bool? DataDiskPolicyRetentionLastWeek
		{
			get
			{
				return dataDiskPolicyRetentionLastWeek;
			}
			set	
			{
				dataDiskPolicyRetentionLastWeek = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskPolicyRetentionLastWeek", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override ModifyAutoSnapshotPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}