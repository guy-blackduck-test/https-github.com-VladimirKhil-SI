﻿using SIPackages.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SIQuester.ViewModel;

/// <summary>
/// Represents a base view model class supporting commands and property chnage notifications.
/// </summary>
public abstract class ModelViewBase : INotifyPropertyChanged, IDisposable
{
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);

    /// <summary>
    /// Raises object property change event.
    /// </summary>
    /// <param name="oldValue">Old property value.</param>
    /// <param name="propertyName">Changed property name.</param>
    protected void OnPropertyChanged<T>(T oldValue, [CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new ExtendedPropertyChangedEventArgs<T>(propertyName, oldValue));

    public event PropertyChangedEventHandler? PropertyChanged;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) { }
}
