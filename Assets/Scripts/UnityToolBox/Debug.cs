using System;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

public static class Debug
{
    /// <summary>
    ///     <para>Draws a line between specified start and end points.</para>
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawLine.html">
    ///         External
    ///         documentation for `Debug.DrawLine`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
    {
        var depthTest = true;
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line between specified start and end points.</para>
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawLine.html">
    ///         External
    ///         documentation for `Debug.DrawLine`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color)
    {
        var depthTest = true;
        var duration = 0.0f;
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line between specified start and end points.</para>
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawLine.html">
    ///         External
    ///         documentation for `Debug.DrawLine`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end)
    {
        var depthTest = true;
        var duration = 0.0f;
        var white = Color.white;
        UnityEngine.Debug.DrawLine(start, end, white, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line between specified start and end points.</para>
    /// </summary>
    /// <param name="start">Point in world space where the line should start.</param>
    /// <param name="end">Point in world space where the line should end.</param>
    /// <param name="color">Color of the line.</param>
    /// <param name="duration">How long the line should be visible for.</param>
    /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawLine.html">
    ///         External
    ///         documentation for `Debug.DrawLine`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(
        Vector3 start,
        Vector3 end,
        [DefaultValue("Color.white")] Color color,
        [DefaultValue("0.0f")] float duration,
        [DefaultValue("true")] bool depthTest)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line from start to start + dir in world coordinates.</para>
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawRay.html">
    ///         External
    ///         documentation for `Debug.DrawRay`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
    {
        var depthTest = true;
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line from start to start + dir in world coordinates.</para>
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawRay.html">
    ///         External
    ///         documentation for `Debug.DrawRay`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color)
    {
        var depthTest = true;
        var duration = 0.0f;
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line from start to start + dir in world coordinates.</para>
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawRay.html">
    ///         External
    ///         documentation for `Debug.DrawRay`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir)
    {
        var depthTest = true;
        var duration = 0.0f;
        var white = Color.white;
        UnityEngine.Debug.DrawRay(start, dir, white, duration, depthTest);
    }

    /// <summary>
    ///     <para>Draws a line from start to start + dir in world coordinates.</para>
    /// </summary>
    /// <param name="start">Point in world space where the ray should start.</param>
    /// <param name="dir">Direction and length of the ray.</param>
    /// <param name="color">Color of the drawn line.</param>
    /// <param name="duration">How long the line will be visible for (in seconds).</param>
    /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.DrawRay.html">
    ///         External
    ///         documentation for `Debug.DrawRay`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(
        Vector3 start,
        Vector3 dir,
        [DefaultValue("Color.white")] Color color,
        [DefaultValue("0.0f")] float duration,
        [DefaultValue("true")] bool depthTest)
    {
        UnityEngine.Debug.DrawLine(start, start + dir, color, duration, depthTest);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs a warning message to the console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogWarning.html">
    ///         External
    ///         documentation for `Debug.LogWarning`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message)
    {
        UnityEngine.Debug.LogWarning(message);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs a warning message to the console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogWarning.html">
    ///         External
    ///         documentation for `Debug.LogWarning`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, Object context)
    {
        UnityEngine.Debug.LogWarning(message, context);
    }

    /// <summary>
    ///     <para>Logs a formatted warning message to the Unity Console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogWarningFormat.html">
    ///         External
    ///         documentation for `Debug.LogWarningFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(format, args);
    }

    /// <summary>
    ///     <para>Logs a formatted warning message to the Unity Console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogWarningFormat.html">
    ///         External
    ///         documentation for `Debug.LogWarningFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(context, format, args);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs an error message to the console.</para>
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="exception">Runtime Exception.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogException.html">
    ///         External
    ///         documentation for `Debug.LogException`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogException(Exception exception)
    {
        UnityEngine.Debug.LogException(exception, null);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs an error message to the console.</para>
    /// </summary>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="exception">Runtime Exception.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogException.html">
    ///         External
    ///         documentation for `Debug.LogException`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogException(Exception exception, Object context)
    {
        UnityEngine.Debug.LogException(exception, context);
    }

    /// <summary>
    ///     <para>Logs a message to the Unity Console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.Log.html">
    ///         External
    ///         documentation for `Debug.Log`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(message);
    }

    /// <summary>
    ///     <para>Logs a message to the Unity Console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.Log.html">
    ///         External
    ///         documentation for `Debug.Log`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void Log(object message, Object context)
    {
        UnityEngine.Debug.Log(message, context);
    }

    /// <summary>
    ///     <para>Logs a formatted message to the Unity Console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="logType">Type of message e.g. warn or error etc.</param>
    /// <param name="logOptions">Option flags to treat the log message special.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogFormat.html">
    ///         External
    ///         documentation for `Debug.LogFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(format, args);
    }

    /// <summary>
    ///     <para>Logs a formatted message to the Unity Console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="logType">Type of message e.g. warn or error etc.</param>
    /// <param name="logOptions">Option flags to treat the log message special.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogFormat.html">
    ///         External
    ///         documentation for `Debug.LogFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(context, format, args);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs an error message to the console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogError.html">
    ///         External
    ///         documentation for `Debug.LogError`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogError(object message)
    {
        UnityEngine.Debug.LogError(message);
    }

    /// <summary>
    ///     <para>A variant of Debug.Log that logs an error message to the console.</para>
    /// </summary>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogError.html">
    ///         External
    ///         documentation for `Debug.LogError`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogError(object message, Object context)
    {
        UnityEngine.Debug.LogError(message, context);
    }

    /// <summary>
    ///     <para>Logs a formatted error message to the Unity console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogErrorFormat.html">
    ///         External
    ///         documentation for `Debug.LogErrorFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(format, args);
    }

    /// <summary>
    ///     <para>Logs a formatted error message to the Unity console.</para>
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <footer>
    ///     <a
    ///         href="file:///C:/Program%20Files/Unity/Hub/Editor/2019.4.30f1/Editor/Data/Documentation/en/ScriptReference/Debug.LogErrorFormat.html">
    ///         External
    ///         documentation for `Debug.LogErrorFormat`
    ///     </a>
    /// </footer>
    [Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(context, format, args);
    }
}