﻿namespace MogglesClient.PublicInterface
{
    public static class Is<T> where T: MogglesFeatureToggle, new ()
    {
        public static bool Enabled => new T().IsEnabled;
    }
}
