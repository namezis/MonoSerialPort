﻿using System;

namespace MonoSerialPort.Port
{
    public class SerialPinChangedEventArgs : EventArgs
    {
        internal SerialPinChangedEventArgs(SerialPinChange eventType)
        {
            this.eventType = eventType;
        }

        // properties

        public SerialPinChange EventType
        {
            get
            {
                return eventType;
            }
        }

        SerialPinChange eventType;
    }
}
