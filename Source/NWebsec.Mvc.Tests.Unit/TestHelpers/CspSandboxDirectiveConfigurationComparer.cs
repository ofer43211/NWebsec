// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.Collections.Generic;
using NWebsec.Core.HttpHeaders.Configuration;

namespace NWebsec.Mvc.Tests.Unit.TestHelpers
{
    public class CspSandboxDirectiveConfigurationComparer : IComparer<ICspSandboxDirectiveConfiguration>
    {
        public int Compare(ICspSandboxDirectiveConfiguration x, ICspSandboxDirectiveConfiguration y)
        {
            var result = x.Enabled.CompareTo(y.Enabled);
            if (result != 0) return result;

            result = x.AllowForms.CompareTo(y.AllowForms);
            if (result != 0) return result;

            result = x.AllowPointerLock.CompareTo(y.AllowPointerLock);
            if (result != 0) return result;

            result = x.AllowPopups.CompareTo(y.AllowPopups);
            if (result != 0) return result;

            result = x.AllowSameOrigin.CompareTo(y.AllowSameOrigin);
            if (result != 0) return result;

            result = x.AllowScripts.CompareTo(y.AllowScripts);
            if (result != 0) return result;

            return x.AllowTopNavigation.CompareTo(y.AllowTopNavigation);
        }
    }
}