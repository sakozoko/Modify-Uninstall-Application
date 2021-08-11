﻿using Microsoft.Win32;

namespace URApplication.Models.Registry
{
    public static class Validation
    {
        public static bool Application(RegistryKey key)
        {
            return key.GetValue("DisplayName") is not null && key.GetValue("ParentKeyName") is null &&
                   (key.GetValue("SystemComponent") is null ||
                    (int)key.GetValue("SystemComponent") != 1);
        }
    }
}