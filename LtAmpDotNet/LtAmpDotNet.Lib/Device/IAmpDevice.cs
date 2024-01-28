﻿using LtAmpDotNet.Lib.Models.Protobuf;

namespace LtAmpDotNet.Lib.Device
{
    /// <summary>
    /// Represents a physical amplifier device to connect to
    /// </summary>
    public interface IAmpDevice : IDisposable
    {
        /// <summary>
        /// State of the amp connection
        /// </summary>
        public bool IsOpen { get; }

        /// <summary>
        /// Data length for reports communicated from the amplifier
        /// </summary>
        public int? ReportLength { get; }

        /// <summary>
        /// Fired when the amplifier opens and connects
        /// </summary>
        public event EventHandler? Opened;

        /// <summary>
        /// Fired when the connection to the amplifier is closed
        /// </summary>
        public event EventHandler? Closed;

        /// <summary>
        /// Fired when a message is received from the amplifier
        /// </summary>
        public event MessageReceivedEventHandler? MessageReceived;

        /// <summary>
        /// Fired when a message is sent to the amplifier
        /// </summary>
        public event MessageSentEventHandler? MessageSent;

        /// <summary>
        /// Opens a connection to the amplifier
        /// </summary>
        public void Open();

        /// <summary>
        /// Closes the amplifier connection
        /// </summary>
        public void Close();

        /// <summary>
        /// Sends a message to the amplifier
        /// </summary>
        /// <param name="message">A FenderMessageLT protobuf message to be sent</param>
        public void Write(FenderMessageLT message);

    }
}
