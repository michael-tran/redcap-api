﻿namespace Redcap.Interfaces
{
    /// <summary>
    /// The format which is provided when requesting through Redcap API
    /// RedcapFormat, 0 = JSON
    /// RedcapFormat, 1 = CSV
    /// RedcapFormat, 2 = XML
    /// </summary>
    public enum RedcapFormat
    {
        json = 0,
        csv = 1,
        xml = 2
    }
}
