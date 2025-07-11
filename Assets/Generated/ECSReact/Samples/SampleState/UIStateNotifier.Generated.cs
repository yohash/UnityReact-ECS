// <auto-generated>
// This file was automatically generated by UIStateNotifier Generator
// Namespace: ECSReact.Samples.SampleState
// Do not modify this file directly - it will be overwritten
// </auto-generated>

using System;
using ECSReact.Core;
using ECSReact.Samples.SampleState;

namespace ECSReact.Samples.SampleState
{
  /// <summary>
  /// Generated extensions for UIStateNotifier that provide typed events for ECSReact.Samples.SampleState state types.
  /// </summary>
  public static class StateNotificationEvents
  {
    /// <summary>
    /// Event fired when GameState changes.
    /// </summary>
    public static System.Action<GameState> OnGameStateChanged;

    /// <summary>
    /// Event fired when PlayerState changes.
    /// </summary>
    public static System.Action<PlayerState> OnPlayerStateChanged;

    /// <summary>
    /// Initialize event processors for ECSReact.Samples.SampleState state types.
    /// Call this method during application startup or when setting up the UI system.
    /// </summary>
    public static void InitializeEvents()
    {
      ECSReact.Core.UIStateNotifier
        .RegisterEventProcessor<ECSReact.Samples.SampleState.GameStateChangedEvent>(evt => 
          OnGameStateChanged?.Invoke(evt.newState));

      ECSReact.Core.UIStateNotifier
        .RegisterEventProcessor<ECSReact.Samples.SampleState.PlayerStateChangedEvent>(evt => 
          OnPlayerStateChanged?.Invoke(evt.newState));
    }
  }
}
