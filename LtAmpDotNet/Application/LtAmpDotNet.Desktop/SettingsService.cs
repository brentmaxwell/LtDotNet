﻿using LtAmpDotNet.Services;

namespace LtAmpDotNet.Desktop
{
    public sealed class SettingsService : ISettingsService
    {
        /// <summary>
        /// The <see cref="IPropertySet"/> with the settings targeted by the current instance.
        /// </summary>
        private readonly IPropertySet SettingsStorage = ApplicationData.Current.LocalSettings.Values;

        /// <inheritdoc/>
        public void SetValue<T>(string key, T value)
        {
            if (!SettingsStorage.ContainsKey(key)) SettingsStorage.Add(key, value);
            else SettingsStorage[key] = value;
        }

        /// <inheritdoc/>
        public T GetValue<T>(string key) => SettingsStorage.TryGetValue(key, out object value) ? (T)value : default;
    }
}