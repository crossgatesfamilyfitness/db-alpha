using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cgff_connect
{
    public static class Converters
    {
        public static cgff_connect.localModels.Checkin RemoteToLocalCheckin(cgff_connect.remoteModels.Checkin remote)
        {
            cgff_connect.localModels.Checkin returnValue = new localModels.Checkin();
            returnValue.Id = remote.Id;
            returnValue.UserId = remote.UserId;
            returnValue.CaacDoorId = remote.CaacDoorId;
            returnValue.LocationId = remote.LocationId;
            returnValue.Blocked = remote.Blocked;
            returnValue.BlockedDate = remote.BlockedDate;
            returnValue.BlockedTime = remote.BlockedTime;
            returnValue.Date = remote.Date;
            returnValue.Denied = remote.Denied;
            returnValue.DepartmentId = remote.DepartmentId;
            returnValue.EntityId = remote.EntityId;
            returnValue.In = remote.In;
            returnValue.Out = remote.Out;
            returnValue.UserId = remote.UserId;
            returnValue.UtcTimestamp = remote.UtcTimestamp;
            return returnValue;
        }

        public static cgff_connect.remoteModels.Checkin LocalToRemoteCheckin(cgff_connect.localModels.Checkin local)
        {
            cgff_connect.remoteModels.Checkin returnValue = new remoteModels.Checkin();
            returnValue.Id = local.Id;
            returnValue.UserId = local.UserId;
            returnValue.CaacDoorId = local.CaacDoorId;
            returnValue.LocationId = local.LocationId;
            returnValue.Blocked = local.Blocked;
            returnValue.BlockedDate = local.BlockedDate;
            returnValue.BlockedTime = local.BlockedTime;
            returnValue.Date = local.Date;
            returnValue.Denied = local.Denied;
            returnValue.DepartmentId = local.DepartmentId;
            returnValue.EntityId = local.EntityId;
            returnValue.In = local.In;
            returnValue.Out = local.Out;
            returnValue.UserId = local.UserId;
            returnValue.UtcTimestamp = local.UtcTimestamp;
            return returnValue;
        }

        public static object RemoteToLocal(object remote, object local)
        {
            Type sourceType = remote.GetType();
            Type targetType = local.GetType();

            // Loop through each property in the source object
            foreach (PropertyInfo sourceProperty in sourceType.GetProperties())
            {
                // Get the matching property in the target object
                PropertyInfo targetProperty = targetType.GetProperty(sourceProperty.Name);

                // If the target property exists and it's writable
                if (targetProperty != null && targetProperty.CanWrite)
                {
                    // Copy the value from the source to the target
                    object value = sourceProperty.GetValue(remote);
                    targetProperty.SetValue(local, value);
                }
            }

            return local;

        }

    }
}





